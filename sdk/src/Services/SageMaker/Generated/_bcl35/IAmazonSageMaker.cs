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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SageMaker.Model;

namespace Amazon.SageMaker
{
    /// <summary>
    /// Interface for accessing SageMaker
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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
        AddAssociationResponse AddAssociation(AddAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddAssociation operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AddAssociation">REST API Reference for AddAssociation Operation</seealso>
        IAsyncResult BeginAddAssociation(AddAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddAssociation.</param>
        /// 
        /// <returns>Returns a  AddAssociationResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AddAssociation">REST API Reference for AddAssociation Operation</seealso>
        AddAssociationResponse EndAddAssociation(IAsyncResult asyncResult);

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
        /// add the tags when you first create the tuning job by specifying them in the <code>Tags</code>
        /// parameter of <a>CreateHyperParameterTuningJob</a> 
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Tags that you add to a SageMaker Studio Domain or User Profile by calling this API
        /// are also added to any Apps that the Domain or User Profile launches after you call
        /// this API, but not to Apps that the Domain or User Profile launched before you called
        /// this API. To make sure that the tags associated with a Domain or User Profile are
        /// also added to all Apps that the Domain or User Profile launches, add the tags when
        /// you first create the Domain or User Profile by specifying them in the <code>Tags</code>
        /// parameter of <a>CreateDomain</a> or <a>CreateUserProfile</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AddTags">REST API Reference for AddTags Operation</seealso>
        AddTagsResponse AddTags(AddTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AddTags">REST API Reference for AddTags Operation</seealso>
        IAsyncResult BeginAddTags(AddTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTags.</param>
        /// 
        /// <returns>Returns a  AddTagsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AddTags">REST API Reference for AddTags Operation</seealso>
        AddTagsResponse EndAddTags(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateTrialComponent


        /// <summary>
        /// Associates a trial component with a trial. A trial component can be associated with
        /// multiple trials. To disassociate a trial component from a trial, call the <a>DisassociateTrialComponent</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTrialComponent service method.</param>
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
        AssociateTrialComponentResponse AssociateTrialComponent(AssociateTrialComponentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateTrialComponent operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateTrialComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AssociateTrialComponent">REST API Reference for AssociateTrialComponent Operation</seealso>
        IAsyncResult BeginAssociateTrialComponent(AssociateTrialComponentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateTrialComponent.</param>
        /// 
        /// <returns>Returns a  AssociateTrialComponentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AssociateTrialComponent">REST API Reference for AssociateTrialComponent Operation</seealso>
        AssociateTrialComponentResponse EndAssociateTrialComponent(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDescribeModelPackage


        /// <summary>
        /// This action batch describes a list of versioned model packages
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDescribeModelPackage service method.</param>
        /// 
        /// <returns>The response from the BatchDescribeModelPackage service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/BatchDescribeModelPackage">REST API Reference for BatchDescribeModelPackage Operation</seealso>
        BatchDescribeModelPackageResponse BatchDescribeModelPackage(BatchDescribeModelPackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDescribeModelPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDescribeModelPackage operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDescribeModelPackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/BatchDescribeModelPackage">REST API Reference for BatchDescribeModelPackage Operation</seealso>
        IAsyncResult BeginBatchDescribeModelPackage(BatchDescribeModelPackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDescribeModelPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDescribeModelPackage.</param>
        /// 
        /// <returns>Returns a  BatchDescribeModelPackageResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/BatchDescribeModelPackage">REST API Reference for BatchDescribeModelPackage Operation</seealso>
        BatchDescribeModelPackageResponse EndBatchDescribeModelPackage(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAction


        /// <summary>
        /// Creates an <i>action</i>. An action is a lineage tracking entity that represents an
        /// action or activity. For example, a model deployment or an HPO job. Generally, an action
        /// involves at least one input or output artifact. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/lineage-tracking.html">Amazon
        /// SageMaker ML Lineage Tracking</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAction service method.</param>
        /// 
        /// <returns>The response from the CreateAction service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAction">REST API Reference for CreateAction Operation</seealso>
        CreateActionResponse CreateAction(CreateActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAction operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAction">REST API Reference for CreateAction Operation</seealso>
        IAsyncResult BeginCreateAction(CreateActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAction.</param>
        /// 
        /// <returns>Returns a  CreateActionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAction">REST API Reference for CreateAction Operation</seealso>
        CreateActionResponse EndCreateAction(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAlgorithm


        /// <summary>
        /// Create a machine learning algorithm that you can use in SageMaker and list in the
        /// Amazon Web Services Marketplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlgorithm service method.</param>
        /// 
        /// <returns>The response from the CreateAlgorithm service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAlgorithm">REST API Reference for CreateAlgorithm Operation</seealso>
        CreateAlgorithmResponse CreateAlgorithm(CreateAlgorithmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlgorithm operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAlgorithm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAlgorithm">REST API Reference for CreateAlgorithm Operation</seealso>
        IAsyncResult BeginCreateAlgorithm(CreateAlgorithmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAlgorithm.</param>
        /// 
        /// <returns>Returns a  CreateAlgorithmResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAlgorithm">REST API Reference for CreateAlgorithm Operation</seealso>
        CreateAlgorithmResponse EndCreateAlgorithm(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateApp


        /// <summary>
        /// Creates a running app for the specified UserProfile. This operation is automatically
        /// invoked by Amazon SageMaker Studio upon access to the associated Domain, and when
        /// new kernel configurations are selected by the user. A user may have multiple Apps
        /// active simultaneously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApp service method.</param>
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
        CreateAppResponse CreateApp(CreateAppRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApp operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateApp">REST API Reference for CreateApp Operation</seealso>
        IAsyncResult BeginCreateApp(CreateAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApp.</param>
        /// 
        /// <returns>Returns a  CreateAppResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateApp">REST API Reference for CreateApp Operation</seealso>
        CreateAppResponse EndCreateApp(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAppImageConfig


        /// <summary>
        /// Creates a configuration for running a SageMaker image as a KernelGateway app. The
        /// configuration specifies the Amazon Elastic File System (EFS) storage volume on the
        /// image, and a list of the kernels in the image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppImageConfig service method.</param>
        /// 
        /// <returns>The response from the CreateAppImageConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAppImageConfig">REST API Reference for CreateAppImageConfig Operation</seealso>
        CreateAppImageConfigResponse CreateAppImageConfig(CreateAppImageConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppImageConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppImageConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAppImageConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAppImageConfig">REST API Reference for CreateAppImageConfig Operation</seealso>
        IAsyncResult BeginCreateAppImageConfig(CreateAppImageConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAppImageConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAppImageConfig.</param>
        /// 
        /// <returns>Returns a  CreateAppImageConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAppImageConfig">REST API Reference for CreateAppImageConfig Operation</seealso>
        CreateAppImageConfigResponse EndCreateAppImageConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateArtifact


        /// <summary>
        /// Creates an <i>artifact</i>. An artifact is a lineage tracking entity that represents
        /// a URI addressable object or data. Some examples are the S3 URI of a dataset and the
        /// ECR registry path of an image. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/lineage-tracking.html">Amazon
        /// SageMaker ML Lineage Tracking</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateArtifact service method.</param>
        /// 
        /// <returns>The response from the CreateArtifact service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateArtifact">REST API Reference for CreateArtifact Operation</seealso>
        CreateArtifactResponse CreateArtifact(CreateArtifactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateArtifact operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateArtifact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateArtifact">REST API Reference for CreateArtifact Operation</seealso>
        IAsyncResult BeginCreateArtifact(CreateArtifactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateArtifact.</param>
        /// 
        /// <returns>Returns a  CreateArtifactResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateArtifact">REST API Reference for CreateArtifact Operation</seealso>
        CreateArtifactResponse EndCreateArtifact(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAutoMLJob


        /// <summary>
        /// Creates an Autopilot job.
        /// 
        ///  
        /// <para>
        /// Find the best-performing model after you run an Autopilot job by calling .
        /// </para>
        ///  
        /// <para>
        /// For information about how to use Autopilot, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-automate-model-development.html">Automate
        /// Model Development with Amazon SageMaker Autopilot</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoMLJob service method.</param>
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
        CreateAutoMLJobResponse CreateAutoMLJob(CreateAutoMLJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAutoMLJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoMLJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAutoMLJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAutoMLJob">REST API Reference for CreateAutoMLJob Operation</seealso>
        IAsyncResult BeginCreateAutoMLJob(CreateAutoMLJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAutoMLJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAutoMLJob.</param>
        /// 
        /// <returns>Returns a  CreateAutoMLJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAutoMLJob">REST API Reference for CreateAutoMLJob Operation</seealso>
        CreateAutoMLJobResponse EndCreateAutoMLJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCodeRepository


        /// <summary>
        /// Creates a Git repository as a resource in your SageMaker account. You can associate
        /// the repository with notebook instances so that you can use Git source control for
        /// the notebooks you create. The Git repository is a resource in your SageMaker account,
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
        /// 
        /// <returns>The response from the CreateCodeRepository service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCodeRepository">REST API Reference for CreateCodeRepository Operation</seealso>
        CreateCodeRepositoryResponse CreateCodeRepository(CreateCodeRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeRepository operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCodeRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCodeRepository">REST API Reference for CreateCodeRepository Operation</seealso>
        IAsyncResult BeginCreateCodeRepository(CreateCodeRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCodeRepository.</param>
        /// 
        /// <returns>Returns a  CreateCodeRepositoryResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCodeRepository">REST API Reference for CreateCodeRepository Operation</seealso>
        CreateCodeRepositoryResponse EndCreateCodeRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCompilationJob


        /// <summary>
        /// Starts a model compilation job. After the model has been compiled, Amazon SageMaker
        /// saves the resulting model artifacts to an Amazon Simple Storage Service (Amazon S3)
        /// bucket that you specify. 
        /// 
        ///  
        /// <para>
        /// If you choose to host your model using Amazon SageMaker hosting services, you can
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
        /// The Amazon Resource Name (ARN) of the IAM role that Amazon SageMaker assumes to perform
        /// the model compilation job. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can also provide a <code>Tag</code> to track the model compilation job's resource
        /// use and costs. The response body contains the <code>CompilationJobArn</code> for the
        /// compiled job.
        /// </para>
        ///  
        /// <para>
        /// To stop a model compilation job, use <a>StopCompilationJob</a>. To get information
        /// about a particular model compilation job, use <a>DescribeCompilationJob</a>. To get
        /// information about multiple model compilation jobs, use <a>ListCompilationJobs</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCompilationJob service method.</param>
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
        CreateCompilationJobResponse CreateCompilationJob(CreateCompilationJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCompilationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCompilationJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCompilationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCompilationJob">REST API Reference for CreateCompilationJob Operation</seealso>
        IAsyncResult BeginCreateCompilationJob(CreateCompilationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCompilationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCompilationJob.</param>
        /// 
        /// <returns>Returns a  CreateCompilationJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCompilationJob">REST API Reference for CreateCompilationJob Operation</seealso>
        CreateCompilationJobResponse EndCreateCompilationJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateContext


        /// <summary>
        /// Creates a <i>context</i>. A context is a lineage tracking entity that represents a
        /// logical grouping of other tracking or experiment entities. Some examples are an endpoint
        /// and a model package. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/lineage-tracking.html">Amazon
        /// SageMaker ML Lineage Tracking</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContext service method.</param>
        /// 
        /// <returns>The response from the CreateContext service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateContext">REST API Reference for CreateContext Operation</seealso>
        CreateContextResponse CreateContext(CreateContextRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateContext operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContext operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateContext
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateContext">REST API Reference for CreateContext Operation</seealso>
        IAsyncResult BeginCreateContext(CreateContextRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateContext operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateContext.</param>
        /// 
        /// <returns>Returns a  CreateContextResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateContext">REST API Reference for CreateContext Operation</seealso>
        CreateContextResponse EndCreateContext(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataQualityJobDefinition


        /// <summary>
        /// Creates a definition for a job that monitors data quality and drift. For information
        /// about model monitor, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-monitor.html">Amazon
        /// SageMaker Model Monitor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataQualityJobDefinition service method.</param>
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
        CreateDataQualityJobDefinitionResponse CreateDataQualityJobDefinition(CreateDataQualityJobDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataQualityJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataQualityJobDefinition operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataQualityJobDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateDataQualityJobDefinition">REST API Reference for CreateDataQualityJobDefinition Operation</seealso>
        IAsyncResult BeginCreateDataQualityJobDefinition(CreateDataQualityJobDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataQualityJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataQualityJobDefinition.</param>
        /// 
        /// <returns>Returns a  CreateDataQualityJobDefinitionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateDataQualityJobDefinition">REST API Reference for CreateDataQualityJobDefinition Operation</seealso>
        CreateDataQualityJobDefinitionResponse EndCreateDataQualityJobDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDeviceFleet


        /// <summary>
        /// Creates a device fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceFleet service method.</param>
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
        CreateDeviceFleetResponse CreateDeviceFleet(CreateDeviceFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeviceFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceFleet operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeviceFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateDeviceFleet">REST API Reference for CreateDeviceFleet Operation</seealso>
        IAsyncResult BeginCreateDeviceFleet(CreateDeviceFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeviceFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeviceFleet.</param>
        /// 
        /// <returns>Returns a  CreateDeviceFleetResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateDeviceFleet">REST API Reference for CreateDeviceFleet Operation</seealso>
        CreateDeviceFleetResponse EndCreateDeviceFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDomain


        /// <summary>
        /// Creates a <code>Domain</code> used by Amazon SageMaker Studio. A domain consists of
        /// an associated Amazon Elastic File System (EFS) volume, a list of authorized users,
        /// and a variety of security, application, policy, and Amazon Virtual Private Cloud (VPC)
        /// configurations. An Amazon Web Services account is limited to one domain per region.
        /// Users within a domain can share notebook files and other artifacts with each other.
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
        /// SageMaker uses the Amazon Web Services Key Management Service (Amazon Web Services
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
        /// All SageMaker Studio traffic between the domain and the EFS volume is through the
        /// specified VPC and subnets. For other Studio traffic, you can specify the <code>AppNetworkAccessType</code>
        /// parameter. <code>AppNetworkAccessType</code> corresponds to the network access type
        /// that you choose when you onboard to Studio. The following options are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PublicInternetOnly</code> - Non-EFS traffic goes through a VPC managed by Amazon
        /// SageMaker, which allows internet access. This is the default value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VpcOnly</code> - All Studio traffic is through the specified VPC and subnets.
        /// Internet access is disabled by default. To allow internet access, you must specify
        /// a NAT gateway.
        /// </para>
        ///  
        /// <para>
        /// When internet access is disabled, you won't be able to run a Studio notebook or to
        /// train or host models unless your VPC has an interface endpoint to the SageMaker API
        /// and runtime or a NAT gateway and your security groups allow outbound connections.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// NFS traffic over TCP on port 2049 needs to be allowed in both inbound and outbound
        /// rules in order to launch a SageMaker Studio app successfully.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/studio-notebooks-and-internet-access.html">Connect
        /// SageMaker Studio Notebooks to Resources in a VPC</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
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
        CreateDomainResponse CreateDomain(CreateDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        IAsyncResult BeginCreateDomain(CreateDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomain.</param>
        /// 
        /// <returns>Returns a  CreateDomainResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        CreateDomainResponse EndCreateDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEdgeDeploymentPlan


        /// <summary>
        /// Creates an edge deployment plan, consisting of multiple stages. Each stage may have
        /// a different deployment configuration and devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEdgeDeploymentPlan service method.</param>
        /// 
        /// <returns>The response from the CreateEdgeDeploymentPlan service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEdgeDeploymentPlan">REST API Reference for CreateEdgeDeploymentPlan Operation</seealso>
        CreateEdgeDeploymentPlanResponse CreateEdgeDeploymentPlan(CreateEdgeDeploymentPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEdgeDeploymentPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEdgeDeploymentPlan operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEdgeDeploymentPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEdgeDeploymentPlan">REST API Reference for CreateEdgeDeploymentPlan Operation</seealso>
        IAsyncResult BeginCreateEdgeDeploymentPlan(CreateEdgeDeploymentPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEdgeDeploymentPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEdgeDeploymentPlan.</param>
        /// 
        /// <returns>Returns a  CreateEdgeDeploymentPlanResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEdgeDeploymentPlan">REST API Reference for CreateEdgeDeploymentPlan Operation</seealso>
        CreateEdgeDeploymentPlanResponse EndCreateEdgeDeploymentPlan(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEdgeDeploymentStage


        /// <summary>
        /// Creates a new stage in an existing edge deployment plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEdgeDeploymentStage service method.</param>
        /// 
        /// <returns>The response from the CreateEdgeDeploymentStage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEdgeDeploymentStage">REST API Reference for CreateEdgeDeploymentStage Operation</seealso>
        CreateEdgeDeploymentStageResponse CreateEdgeDeploymentStage(CreateEdgeDeploymentStageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEdgeDeploymentStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEdgeDeploymentStage operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEdgeDeploymentStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEdgeDeploymentStage">REST API Reference for CreateEdgeDeploymentStage Operation</seealso>
        IAsyncResult BeginCreateEdgeDeploymentStage(CreateEdgeDeploymentStageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEdgeDeploymentStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEdgeDeploymentStage.</param>
        /// 
        /// <returns>Returns a  CreateEdgeDeploymentStageResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEdgeDeploymentStage">REST API Reference for CreateEdgeDeploymentStage Operation</seealso>
        CreateEdgeDeploymentStageResponse EndCreateEdgeDeploymentStage(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEdgePackagingJob


        /// <summary>
        /// Starts a SageMaker Edge Manager model packaging job. Edge Manager will use the model
        /// artifacts from the Amazon Simple Storage Service bucket that you specify. After the
        /// model has been packaged, Amazon SageMaker saves the resulting artifacts to an S3 bucket
        /// that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEdgePackagingJob service method.</param>
        /// 
        /// <returns>The response from the CreateEdgePackagingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEdgePackagingJob">REST API Reference for CreateEdgePackagingJob Operation</seealso>
        CreateEdgePackagingJobResponse CreateEdgePackagingJob(CreateEdgePackagingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEdgePackagingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEdgePackagingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEdgePackagingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEdgePackagingJob">REST API Reference for CreateEdgePackagingJob Operation</seealso>
        IAsyncResult BeginCreateEdgePackagingJob(CreateEdgePackagingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEdgePackagingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEdgePackagingJob.</param>
        /// 
        /// <returns>Returns a  CreateEdgePackagingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEdgePackagingJob">REST API Reference for CreateEdgePackagingJob Operation</seealso>
        CreateEdgePackagingJobResponse EndCreateEdgePackagingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEndpoint


        /// <summary>
        /// Creates an endpoint using the endpoint configuration specified in the request. SageMaker
        /// uses the endpoint to provision resources and deploy models. You create the endpoint
        /// configuration with the <a>CreateEndpointConfig</a> API. 
        /// 
        ///  
        /// <para>
        ///  Use this API to deploy models using SageMaker hosting services. 
        /// </para>
        ///  
        /// <para>
        /// For an example that calls this method when deploying a model to SageMaker hosting
        /// services, see the <a href="https://github.com/aws/amazon-sagemaker-examples/blob/master/sagemaker-fundamentals/create-endpoint/create_endpoint.ipynb">Create
        /// Endpoint example notebook.</a> 
        /// </para>
        ///  <note> 
        /// <para>
        ///  You must not delete an <code>EndpointConfig</code> that is in use by an endpoint
        /// that is live or while the <code>UpdateEndpoint</code> or <code>CreateEndpoint</code>
        /// operations are being performed on the endpoint. To update an endpoint, you must create
        /// a new <code>EndpointConfig</code>.
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
        /// When you call <a>CreateEndpoint</a>, a load call is made to DynamoDB to verify that
        /// your endpoint configuration exists. When you read data from a DynamoDB table supporting
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadConsistency.html">
        /// <code>Eventually Consistent Reads</code> </a>, the response might not reflect the
        /// results of a recently completed write operation. The response might include some stale
        /// data. If the dependent entities are not yet in DynamoDB, this causes a validation
        /// error. If you repeat your read request after a short time, the response should return
        /// the latest data. So retry logic is recommended to handle these possible issues. We
        /// also recommend that customers call <a>DescribeEndpointConfig</a> before calling <a>CreateEndpoint</a>
        /// to minimize the potential impact of a DynamoDB eventually consistent read.
        /// </para>
        ///  </note> 
        /// <para>
        /// When SageMaker receives the request, it sets the endpoint status to <code>Creating</code>.
        /// After it creates the endpoint, it sets the status to <code>InService</code>. SageMaker
        /// can then process incoming requests for inferences. To check the status of an endpoint,
        /// use the <a>DescribeEndpoint</a> API.
        /// </para>
        ///  
        /// <para>
        /// If any of the models hosted at this endpoint get model data from an Amazon S3 location,
        /// SageMaker uses Amazon Web Services Security Token Service to download model artifacts
        /// from the S3 path you provided. Amazon Web Services STS is activated in your IAM user
        /// account by default. If you previously deactivated Amazon Web Services STS for a region,
        /// you need to reactivate Amazon Web Services STS for that region. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating Amazon Web Services STS in an Amazon Web Services Region</a> in the
        /// <i>Amazon Web Services Identity and Access Management User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  To add the IAM role policies for using this API operation, go to the <a href="https://console.aws.amazon.com/iam/">IAM
        /// console</a>, and choose Roles in the left navigation pane. Search the IAM role that
        /// you want to grant access to use the <a>CreateEndpoint</a> and <a>CreateEndpointConfig</a>
        /// API operations, add the following policies to the role. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Option 1: For a full SageMaker access, search and attach the <code>AmazonSageMakerFullAccess</code>
        /// policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Option 2: For granting a limited access to an IAM role, paste the following Action
        /// elements manually into the JSON file of the IAM role: 
        /// </para>
        ///  
        /// <para>
        ///  <code>"Action": ["sagemaker:CreateEndpoint", "sagemaker:CreateEndpointConfig"]</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>"Resource": [</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"arn:aws:sagemaker:region:account-id:endpoint/endpointName"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"arn:aws:sagemaker:region:account-id:endpoint-config/endpointConfigName"</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>]</code> 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/api-permissions-reference.html">SageMaker
        /// API Permissions: Actions, Permissions, and Resources Reference</a>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateEndpoint service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        CreateEndpointResponse CreateEndpoint(CreateEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        IAsyncResult BeginCreateEndpoint(CreateEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateEndpointResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        CreateEndpointResponse EndCreateEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEndpointConfig


        /// <summary>
        /// Creates an endpoint configuration that SageMaker hosting services uses to deploy models.
        /// In the configuration, you identify one or more models, created using the <code>CreateModel</code>
        /// API, to deploy and the resources that you want SageMaker to provision. Then you call
        /// the <a>CreateEndpoint</a> API.
        /// 
        ///  <note> 
        /// <para>
        ///  Use this API if you want to use SageMaker hosting services to deploy models into
        /// production. 
        /// </para>
        ///  </note> 
        /// <para>
        /// In the request, you define a <code>ProductionVariant</code>, for each model that you
        /// want to deploy. Each <code>ProductionVariant</code> parameter also describes the resources
        /// that you want SageMaker to provision. This includes the number and type of ML compute
        /// instances to deploy. 
        /// </para>
        ///  
        /// <para>
        /// If you are hosting multiple models, you also assign a <code>VariantWeight</code> to
        /// specify how much traffic you want to allocate to each model. For example, suppose
        /// that you want to host two models, A and B, and you assign traffic weight 2 for model
        /// A and 1 for model B. SageMaker distributes two-thirds of the traffic to Model A, and
        /// one-third to model B. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you call <a>CreateEndpoint</a>, a load call is made to DynamoDB to verify that
        /// your endpoint configuration exists. When you read data from a DynamoDB table supporting
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadConsistency.html">
        /// <code>Eventually Consistent Reads</code> </a>, the response might not reflect the
        /// results of a recently completed write operation. The response might include some stale
        /// data. If the dependent entities are not yet in DynamoDB, this causes a validation
        /// error. If you repeat your read request after a short time, the response should return
        /// the latest data. So retry logic is recommended to handle these possible issues. We
        /// also recommend that customers call <a>DescribeEndpointConfig</a> before calling <a>CreateEndpoint</a>
        /// to minimize the potential impact of a DynamoDB eventually consistent read.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointConfig service method.</param>
        /// 
        /// <returns>The response from the CreateEndpointConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpointConfig">REST API Reference for CreateEndpointConfig Operation</seealso>
        CreateEndpointConfigResponse CreateEndpointConfig(CreateEndpointConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEndpointConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpointConfig">REST API Reference for CreateEndpointConfig Operation</seealso>
        IAsyncResult BeginCreateEndpointConfig(CreateEndpointConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEndpointConfig.</param>
        /// 
        /// <returns>Returns a  CreateEndpointConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpointConfig">REST API Reference for CreateEndpointConfig Operation</seealso>
        CreateEndpointConfigResponse EndCreateEndpointConfig(IAsyncResult asyncResult);

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
        /// You can add tags to experiments, trials, trial components and then use the <a>Search</a>
        /// API to search for the tags.
        /// </para>
        ///  
        /// <para>
        /// To add a description to an experiment, specify the optional <code>Description</code>
        /// parameter. To add a description later, or to change the description, call the <a>UpdateExperiment</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your experiments, call the <a>ListExperiments</a> API. To view
        /// an experiment's properties, call the <a>DescribeExperiment</a> API. To get a list
        /// of all the trials associated with an experiment, call the <a>ListTrials</a> API. To
        /// create a trial call the <a>CreateTrial</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExperiment service method.</param>
        /// 
        /// <returns>The response from the CreateExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateExperiment">REST API Reference for CreateExperiment Operation</seealso>
        CreateExperimentResponse CreateExperiment(CreateExperimentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExperiment operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateExperiment">REST API Reference for CreateExperiment Operation</seealso>
        IAsyncResult BeginCreateExperiment(CreateExperimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateExperiment.</param>
        /// 
        /// <returns>Returns a  CreateExperimentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateExperiment">REST API Reference for CreateExperiment Operation</seealso>
        CreateExperimentResponse EndCreateExperiment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFeatureGroup


        /// <summary>
        /// Create a new <code>FeatureGroup</code>. A <code>FeatureGroup</code> is a group of
        /// <code>Features</code> defined in the <code>FeatureStore</code> to describe a <code>Record</code>.
        /// 
        /// 
        ///  
        /// <para>
        /// The <code>FeatureGroup</code> defines the schema and features contained in the FeatureGroup.
        /// A <code>FeatureGroup</code> definition is composed of a list of <code>Features</code>,
        /// a <code>RecordIdentifierFeatureName</code>, an <code>EventTimeFeatureName</code> and
        /// configurations for its <code>OnlineStore</code> and <code>OfflineStore</code>. Check
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">Amazon
        /// Web Services service quotas</a> to see the <code>FeatureGroup</code>s quota for your
        /// Amazon Web Services account.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must include at least one of <code>OnlineStoreConfig</code> and <code>OfflineStoreConfig</code>
        /// to create a <code>FeatureGroup</code>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFeatureGroup service method.</param>
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
        CreateFeatureGroupResponse CreateFeatureGroup(CreateFeatureGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFeatureGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFeatureGroup operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFeatureGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateFeatureGroup">REST API Reference for CreateFeatureGroup Operation</seealso>
        IAsyncResult BeginCreateFeatureGroup(CreateFeatureGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFeatureGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFeatureGroup.</param>
        /// 
        /// <returns>Returns a  CreateFeatureGroupResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateFeatureGroup">REST API Reference for CreateFeatureGroup Operation</seealso>
        CreateFeatureGroupResponse EndCreateFeatureGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFlowDefinition


        /// <summary>
        /// Creates a flow definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowDefinition service method.</param>
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
        CreateFlowDefinitionResponse CreateFlowDefinition(CreateFlowDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFlowDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowDefinition operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFlowDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateFlowDefinition">REST API Reference for CreateFlowDefinition Operation</seealso>
        IAsyncResult BeginCreateFlowDefinition(CreateFlowDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFlowDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFlowDefinition.</param>
        /// 
        /// <returns>Returns a  CreateFlowDefinitionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateFlowDefinition">REST API Reference for CreateFlowDefinition Operation</seealso>
        CreateFlowDefinitionResponse EndCreateFlowDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateHub


        /// <summary>
        /// Create a hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHub service method.</param>
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
        CreateHubResponse CreateHub(CreateHubRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHub operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHub operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHub
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHub">REST API Reference for CreateHub Operation</seealso>
        IAsyncResult BeginCreateHub(CreateHubRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHub operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHub.</param>
        /// 
        /// <returns>Returns a  CreateHubResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHub">REST API Reference for CreateHub Operation</seealso>
        CreateHubResponse EndCreateHub(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateHumanTaskUi


        /// <summary>
        /// Defines the settings you will use for the human review workflow user interface. Reviewers
        /// will see a three-panel interface with an instruction area, the item to review, and
        /// an input area.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHumanTaskUi service method.</param>
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
        CreateHumanTaskUiResponse CreateHumanTaskUi(CreateHumanTaskUiRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHumanTaskUi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHumanTaskUi operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHumanTaskUi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHumanTaskUi">REST API Reference for CreateHumanTaskUi Operation</seealso>
        IAsyncResult BeginCreateHumanTaskUi(CreateHumanTaskUiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHumanTaskUi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHumanTaskUi.</param>
        /// 
        /// <returns>Returns a  CreateHumanTaskUiResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHumanTaskUi">REST API Reference for CreateHumanTaskUi Operation</seealso>
        CreateHumanTaskUiResponse EndCreateHumanTaskUi(IAsyncResult asyncResult);

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
        /// Do not include any security-sensitive information including account access IDs, secrets
        /// or tokens in any hyperparameter field. If the use of security-sensitive credentials
        /// are detected, SageMaker will reject your training job request and return an exception
        /// error.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHyperParameterTuningJob service method.</param>
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
        CreateHyperParameterTuningJobResponse CreateHyperParameterTuningJob(CreateHyperParameterTuningJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHyperParameterTuningJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHyperParameterTuningJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHyperParameterTuningJob">REST API Reference for CreateHyperParameterTuningJob Operation</seealso>
        IAsyncResult BeginCreateHyperParameterTuningJob(CreateHyperParameterTuningJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHyperParameterTuningJob.</param>
        /// 
        /// <returns>Returns a  CreateHyperParameterTuningJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHyperParameterTuningJob">REST API Reference for CreateHyperParameterTuningJob Operation</seealso>
        CreateHyperParameterTuningJobResponse EndCreateHyperParameterTuningJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateImage


        /// <summary>
        /// Creates a custom SageMaker image. A SageMaker image is a set of image versions. Each
        /// image version represents a container image stored in Amazon Elastic Container Registry
        /// (ECR). For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/studio-byoi.html">Bring
        /// your own SageMaker image</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImage service method.</param>
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
        CreateImageResponse CreateImage(CreateImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImage operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateImage">REST API Reference for CreateImage Operation</seealso>
        IAsyncResult BeginCreateImage(CreateImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateImage.</param>
        /// 
        /// <returns>Returns a  CreateImageResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateImage">REST API Reference for CreateImage Operation</seealso>
        CreateImageResponse EndCreateImage(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateImageVersion


        /// <summary>
        /// Creates a version of the SageMaker image specified by <code>ImageName</code>. The
        /// version represents the Amazon Elastic Container Registry (ECR) container image specified
        /// by <code>BaseImage</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImageVersion service method.</param>
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
        CreateImageVersionResponse CreateImageVersion(CreateImageVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImageVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImageVersion operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateImageVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateImageVersion">REST API Reference for CreateImageVersion Operation</seealso>
        IAsyncResult BeginCreateImageVersion(CreateImageVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateImageVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateImageVersion.</param>
        /// 
        /// <returns>Returns a  CreateImageVersionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateImageVersion">REST API Reference for CreateImageVersion Operation</seealso>
        CreateImageVersionResponse EndCreateImageVersion(IAsyncResult asyncResult);

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
        CreateInferenceExperimentResponse CreateInferenceExperiment(CreateInferenceExperimentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInferenceExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInferenceExperiment operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInferenceExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateInferenceExperiment">REST API Reference for CreateInferenceExperiment Operation</seealso>
        IAsyncResult BeginCreateInferenceExperiment(CreateInferenceExperimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInferenceExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInferenceExperiment.</param>
        /// 
        /// <returns>Returns a  CreateInferenceExperimentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateInferenceExperiment">REST API Reference for CreateInferenceExperiment Operation</seealso>
        CreateInferenceExperimentResponse EndCreateInferenceExperiment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateInferenceRecommendationsJob


        /// <summary>
        /// Starts a recommendation job. You can create either an instance recommendation or load
        /// test job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInferenceRecommendationsJob service method.</param>
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
        CreateInferenceRecommendationsJobResponse CreateInferenceRecommendationsJob(CreateInferenceRecommendationsJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInferenceRecommendationsJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInferenceRecommendationsJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInferenceRecommendationsJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateInferenceRecommendationsJob">REST API Reference for CreateInferenceRecommendationsJob Operation</seealso>
        IAsyncResult BeginCreateInferenceRecommendationsJob(CreateInferenceRecommendationsJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInferenceRecommendationsJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInferenceRecommendationsJob.</param>
        /// 
        /// <returns>Returns a  CreateInferenceRecommendationsJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateInferenceRecommendationsJob">REST API Reference for CreateInferenceRecommendationsJob Operation</seealso>
        CreateInferenceRecommendationsJobResponse EndCreateInferenceRecommendationsJob(IAsyncResult asyncResult);

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
        /// in <code>ManifestS3Uri</code> have been labeled. A streaming labeling job runs perpetually
        /// until it is manually stopped, or remains idle for 10 days. You can send new data objects
        /// to an active (<code>InProgress</code>) streaming labeling job in real time. To learn
        /// how to create a static labeling job, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-create-labeling-job-api.html">Create
        /// a Labeling Job (API) </a> in the Amazon SageMaker Developer Guide. To learn how to
        /// create a streaming labeling job, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-streaming-create-job.html">Create
        /// a Streaming Labeling Job</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLabelingJob service method.</param>
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
        CreateLabelingJobResponse CreateLabelingJob(CreateLabelingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLabelingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLabelingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLabelingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateLabelingJob">REST API Reference for CreateLabelingJob Operation</seealso>
        IAsyncResult BeginCreateLabelingJob(CreateLabelingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLabelingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLabelingJob.</param>
        /// 
        /// <returns>Returns a  CreateLabelingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateLabelingJob">REST API Reference for CreateLabelingJob Operation</seealso>
        CreateLabelingJobResponse EndCreateLabelingJob(IAsyncResult asyncResult);

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
        /// To host your model, you create an endpoint configuration with the <code>CreateEndpointConfig</code>
        /// API, and then create an endpoint with the <code>CreateEndpoint</code> API. SageMaker
        /// then deploys all of the containers that you defined for the model in the hosting environment.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For an example that calls this method when deploying a model to SageMaker hosting
        /// services, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/realtime-endpoints-deployment.html#realtime-endpoints-deployment-create-model">Create
        /// a Model (Amazon Web Services SDK for Python (Boto 3)).</a> 
        /// </para>
        ///  
        /// <para>
        /// To run a batch transform using your model, you start a job with the <code>CreateTransformJob</code>
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
        /// 
        /// <returns>The response from the CreateModel service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModel">REST API Reference for CreateModel Operation</seealso>
        CreateModelResponse CreateModel(CreateModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModel operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModel">REST API Reference for CreateModel Operation</seealso>
        IAsyncResult BeginCreateModel(CreateModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModel.</param>
        /// 
        /// <returns>Returns a  CreateModelResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModel">REST API Reference for CreateModel Operation</seealso>
        CreateModelResponse EndCreateModel(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateModelBiasJobDefinition


        /// <summary>
        /// Creates the definition for a model bias job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelBiasJobDefinition service method.</param>
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
        CreateModelBiasJobDefinitionResponse CreateModelBiasJobDefinition(CreateModelBiasJobDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModelBiasJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModelBiasJobDefinition operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModelBiasJobDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelBiasJobDefinition">REST API Reference for CreateModelBiasJobDefinition Operation</seealso>
        IAsyncResult BeginCreateModelBiasJobDefinition(CreateModelBiasJobDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModelBiasJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModelBiasJobDefinition.</param>
        /// 
        /// <returns>Returns a  CreateModelBiasJobDefinitionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelBiasJobDefinition">REST API Reference for CreateModelBiasJobDefinition Operation</seealso>
        CreateModelBiasJobDefinitionResponse EndCreateModelBiasJobDefinition(IAsyncResult asyncResult);

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
        /// 
        /// <returns>The response from the CreateModelCard service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelCard">REST API Reference for CreateModelCard Operation</seealso>
        CreateModelCardResponse CreateModelCard(CreateModelCardRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModelCard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModelCard operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModelCard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelCard">REST API Reference for CreateModelCard Operation</seealso>
        IAsyncResult BeginCreateModelCard(CreateModelCardRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModelCard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModelCard.</param>
        /// 
        /// <returns>Returns a  CreateModelCardResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelCard">REST API Reference for CreateModelCard Operation</seealso>
        CreateModelCardResponse EndCreateModelCard(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateModelCardExportJob


        /// <summary>
        /// Creates an Amazon SageMaker Model Card export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelCardExportJob service method.</param>
        /// 
        /// <returns>The response from the CreateModelCardExportJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelCardExportJob">REST API Reference for CreateModelCardExportJob Operation</seealso>
        CreateModelCardExportJobResponse CreateModelCardExportJob(CreateModelCardExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModelCardExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModelCardExportJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModelCardExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelCardExportJob">REST API Reference for CreateModelCardExportJob Operation</seealso>
        IAsyncResult BeginCreateModelCardExportJob(CreateModelCardExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModelCardExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModelCardExportJob.</param>
        /// 
        /// <returns>Returns a  CreateModelCardExportJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelCardExportJob">REST API Reference for CreateModelCardExportJob Operation</seealso>
        CreateModelCardExportJobResponse EndCreateModelCardExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateModelExplainabilityJobDefinition


        /// <summary>
        /// Creates the definition for a model explainability job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelExplainabilityJobDefinition service method.</param>
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
        CreateModelExplainabilityJobDefinitionResponse CreateModelExplainabilityJobDefinition(CreateModelExplainabilityJobDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModelExplainabilityJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModelExplainabilityJobDefinition operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModelExplainabilityJobDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelExplainabilityJobDefinition">REST API Reference for CreateModelExplainabilityJobDefinition Operation</seealso>
        IAsyncResult BeginCreateModelExplainabilityJobDefinition(CreateModelExplainabilityJobDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModelExplainabilityJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModelExplainabilityJobDefinition.</param>
        /// 
        /// <returns>Returns a  CreateModelExplainabilityJobDefinitionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelExplainabilityJobDefinition">REST API Reference for CreateModelExplainabilityJobDefinition Operation</seealso>
        CreateModelExplainabilityJobDefinitionResponse EndCreateModelExplainabilityJobDefinition(IAsyncResult asyncResult);

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
        /// code and the Amazon S3 location of your model artifacts, provide values for <code>InferenceSpecification</code>.
        /// To create a model from an algorithm resource that you created or subscribed to in
        /// Amazon Web Services Marketplace, provide a value for <code>SourceAlgorithmSpecification</code>.
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
        /// 
        /// <returns>The response from the CreateModelPackage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelPackage">REST API Reference for CreateModelPackage Operation</seealso>
        CreateModelPackageResponse CreateModelPackage(CreateModelPackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModelPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModelPackage operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModelPackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelPackage">REST API Reference for CreateModelPackage Operation</seealso>
        IAsyncResult BeginCreateModelPackage(CreateModelPackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModelPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModelPackage.</param>
        /// 
        /// <returns>Returns a  CreateModelPackageResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelPackage">REST API Reference for CreateModelPackage Operation</seealso>
        CreateModelPackageResponse EndCreateModelPackage(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateModelPackageGroup


        /// <summary>
        /// Creates a model group. A model group contains a group of model versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelPackageGroup service method.</param>
        /// 
        /// <returns>The response from the CreateModelPackageGroup service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelPackageGroup">REST API Reference for CreateModelPackageGroup Operation</seealso>
        CreateModelPackageGroupResponse CreateModelPackageGroup(CreateModelPackageGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModelPackageGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModelPackageGroup operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModelPackageGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelPackageGroup">REST API Reference for CreateModelPackageGroup Operation</seealso>
        IAsyncResult BeginCreateModelPackageGroup(CreateModelPackageGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModelPackageGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModelPackageGroup.</param>
        /// 
        /// <returns>Returns a  CreateModelPackageGroupResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelPackageGroup">REST API Reference for CreateModelPackageGroup Operation</seealso>
        CreateModelPackageGroupResponse EndCreateModelPackageGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateModelQualityJobDefinition


        /// <summary>
        /// Creates a definition for a job that monitors model quality and drift. For information
        /// about model monitor, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-monitor.html">Amazon
        /// SageMaker Model Monitor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelQualityJobDefinition service method.</param>
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
        CreateModelQualityJobDefinitionResponse CreateModelQualityJobDefinition(CreateModelQualityJobDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModelQualityJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModelQualityJobDefinition operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModelQualityJobDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelQualityJobDefinition">REST API Reference for CreateModelQualityJobDefinition Operation</seealso>
        IAsyncResult BeginCreateModelQualityJobDefinition(CreateModelQualityJobDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModelQualityJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModelQualityJobDefinition.</param>
        /// 
        /// <returns>Returns a  CreateModelQualityJobDefinitionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelQualityJobDefinition">REST API Reference for CreateModelQualityJobDefinition Operation</seealso>
        CreateModelQualityJobDefinitionResponse EndCreateModelQualityJobDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMonitoringSchedule


        /// <summary>
        /// Creates a schedule that regularly starts Amazon SageMaker Processing Jobs to monitor
        /// the data captured for an Amazon SageMaker Endoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitoringSchedule service method.</param>
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
        CreateMonitoringScheduleResponse CreateMonitoringSchedule(CreateMonitoringScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitoringSchedule operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMonitoringSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateMonitoringSchedule">REST API Reference for CreateMonitoringSchedule Operation</seealso>
        IAsyncResult BeginCreateMonitoringSchedule(CreateMonitoringScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMonitoringSchedule.</param>
        /// 
        /// <returns>Returns a  CreateMonitoringScheduleResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateMonitoringSchedule">REST API Reference for CreateMonitoringSchedule Operation</seealso>
        CreateMonitoringScheduleResponse EndCreateMonitoringSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateNotebookInstance


        /// <summary>
        /// Creates an SageMaker notebook instance. A notebook instance is a machine learning
        /// (ML) compute instance running on a Jupyter notebook. 
        /// 
        ///  
        /// <para>
        /// In a <code>CreateNotebookInstance</code> request, specify the type of ML compute instance
        /// that you want to run. SageMaker launches the instance, installs common libraries that
        /// you can use to explore datasets for model training, and attaches an ML storage volume
        /// to the notebook instance. 
        /// </para>
        ///  
        /// <para>
        /// SageMaker also provides a set of example notebooks. Each notebook demonstrates how
        /// to use SageMaker with a specific algorithm or with a machine learning framework. 
        /// </para>
        ///  
        /// <para>
        /// After receiving the request, SageMaker does the following:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Creates a network interface in the SageMaker VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Option) If you specified <code>SubnetId</code>, SageMaker creates a network interface
        /// in your own VPC, which is inferred from the subnet ID that you provide in the input.
        /// When creating this network interface, SageMaker attaches the security group that you
        /// specified in the request to the network interface that it creates in your VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Launches an EC2 instance of the type specified in the request in the SageMaker VPC.
        /// If you specified <code>SubnetId</code> of your VPC, SageMaker specifies both network
        /// interfaces when launching this instance. This enables inbound traffic from your own
        /// VPC to the notebook instance, assuming that the security groups allow it.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// After creating the notebook instance, SageMaker returns its Amazon Resource Name (ARN).
        /// You can't change the name of a notebook instance after you create it.
        /// </para>
        ///  
        /// <para>
        /// After SageMaker creates the notebook instance, you can connect to the Jupyter server
        /// and work in Jupyter notebooks. For example, you can write code to explore a dataset
        /// that you can use for model training, train a model, host models by creating SageMaker
        /// endpoints, and validate hosted models. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
        /// It Works</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebookInstance service method.</param>
        /// 
        /// <returns>The response from the CreateNotebookInstance service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstance">REST API Reference for CreateNotebookInstance Operation</seealso>
        CreateNotebookInstanceResponse CreateNotebookInstance(CreateNotebookInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebookInstance operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNotebookInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstance">REST API Reference for CreateNotebookInstance Operation</seealso>
        IAsyncResult BeginCreateNotebookInstance(CreateNotebookInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNotebookInstance.</param>
        /// 
        /// <returns>Returns a  CreateNotebookInstanceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstance">REST API Reference for CreateNotebookInstance Operation</seealso>
        CreateNotebookInstanceResponse EndCreateNotebookInstance(IAsyncResult asyncResult);

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
        /// The value of the <code>$PATH</code> environment variable that is available to both
        /// scripts is <code>/sbin:bin:/usr/sbin:/usr/bin</code>.
        /// </para>
        ///  
        /// <para>
        /// View CloudWatch Logs for notebook instance lifecycle configurations in log group <code>/aws/sagemaker/NotebookInstances</code>
        /// in log stream <code>[notebook-instance-name]/[LifecycleConfigHook]</code>.
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
        /// 
        /// <returns>The response from the CreateNotebookInstanceLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstanceLifecycleConfig">REST API Reference for CreateNotebookInstanceLifecycleConfig Operation</seealso>
        CreateNotebookInstanceLifecycleConfigResponse CreateNotebookInstanceLifecycleConfig(CreateNotebookInstanceLifecycleConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebookInstanceLifecycleConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNotebookInstanceLifecycleConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstanceLifecycleConfig">REST API Reference for CreateNotebookInstanceLifecycleConfig Operation</seealso>
        IAsyncResult BeginCreateNotebookInstanceLifecycleConfig(CreateNotebookInstanceLifecycleConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNotebookInstanceLifecycleConfig.</param>
        /// 
        /// <returns>Returns a  CreateNotebookInstanceLifecycleConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstanceLifecycleConfig">REST API Reference for CreateNotebookInstanceLifecycleConfig Operation</seealso>
        CreateNotebookInstanceLifecycleConfigResponse EndCreateNotebookInstanceLifecycleConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePipeline


        /// <summary>
        /// Creates a pipeline using a JSON pipeline definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        CreatePipelineResponse CreatePipeline(CreatePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        IAsyncResult BeginCreatePipeline(CreatePipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePipeline.</param>
        /// 
        /// <returns>Returns a  CreatePipelineResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        CreatePipelineResponse EndCreatePipeline(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePresignedDomainUrl


        /// <summary>
        /// Creates a URL for a specified UserProfile in a Domain. When accessed in a web browser,
        /// the user will be automatically signed in to Amazon SageMaker Studio, and granted access
        /// to all of the Apps and files associated with the Domain's Amazon Elastic File System
        /// (EFS) volume. This operation can only be called when the authentication mode equals
        /// IAM. 
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
        /// to SageMaker Studio Through an Interface VPC Endpoint</a> .
        /// </para>
        ///  <note> 
        /// <para>
        /// The URL that you get from a call to <code>CreatePresignedDomainUrl</code> has a default
        /// timeout of 5 minutes. You can configure this value using <code>ExpiresInSeconds</code>.
        /// If you try to use the URL after the timeout limit expires, you are directed to the
        /// Amazon Web Services console sign-in page.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedDomainUrl service method.</param>
        /// 
        /// <returns>The response from the CreatePresignedDomainUrl service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedDomainUrl">REST API Reference for CreatePresignedDomainUrl Operation</seealso>
        CreatePresignedDomainUrlResponse CreatePresignedDomainUrl(CreatePresignedDomainUrlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePresignedDomainUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedDomainUrl operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePresignedDomainUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedDomainUrl">REST API Reference for CreatePresignedDomainUrl Operation</seealso>
        IAsyncResult BeginCreatePresignedDomainUrl(CreatePresignedDomainUrlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePresignedDomainUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePresignedDomainUrl.</param>
        /// 
        /// <returns>Returns a  CreatePresignedDomainUrlResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedDomainUrl">REST API Reference for CreatePresignedDomainUrl Operation</seealso>
        CreatePresignedDomainUrlResponse EndCreatePresignedDomainUrl(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePresignedNotebookInstanceUrl


        /// <summary>
        /// Returns a URL that you can use to connect to the Jupyter server from a notebook instance.
        /// In the SageMaker console, when you choose <code>Open</code> next to a notebook instance,
        /// SageMaker opens a new tab showing the Jupyter server home page from the notebook instance.
        /// The console uses this API to get the URL and show the page.
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
        /// addresses that you specify. Use the <code>NotIpAddress</code> condition operator and
        /// the <code>aws:SourceIP</code> condition context key to specify the list of IP addresses
        /// that you want to have access to the notebook instance. For more information, see <a
        /// href="https://docs.aws.amazon.com/sagemaker/latest/dg/security_iam_id-based-policy-examples.html#nbi-ip-filter">Limit
        /// Access to a Notebook Instance by IP Address</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The URL that you get from a call to <a>CreatePresignedNotebookInstanceUrl</a> is valid
        /// only for 5 minutes. If you try to use the URL after the 5-minute limit expires, you
        /// are directed to the Amazon Web Services console sign-in page.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedNotebookInstanceUrl service method.</param>
        /// 
        /// <returns>The response from the CreatePresignedNotebookInstanceUrl service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedNotebookInstanceUrl">REST API Reference for CreatePresignedNotebookInstanceUrl Operation</seealso>
        CreatePresignedNotebookInstanceUrlResponse CreatePresignedNotebookInstanceUrl(CreatePresignedNotebookInstanceUrlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePresignedNotebookInstanceUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedNotebookInstanceUrl operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePresignedNotebookInstanceUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedNotebookInstanceUrl">REST API Reference for CreatePresignedNotebookInstanceUrl Operation</seealso>
        IAsyncResult BeginCreatePresignedNotebookInstanceUrl(CreatePresignedNotebookInstanceUrlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePresignedNotebookInstanceUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePresignedNotebookInstanceUrl.</param>
        /// 
        /// <returns>Returns a  CreatePresignedNotebookInstanceUrlResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedNotebookInstanceUrl">REST API Reference for CreatePresignedNotebookInstanceUrl Operation</seealso>
        CreatePresignedNotebookInstanceUrlResponse EndCreatePresignedNotebookInstanceUrl(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProcessingJob


        /// <summary>
        /// Creates a processing job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProcessingJob service method.</param>
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
        CreateProcessingJobResponse CreateProcessingJob(CreateProcessingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProcessingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProcessingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProcessingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateProcessingJob">REST API Reference for CreateProcessingJob Operation</seealso>
        IAsyncResult BeginCreateProcessingJob(CreateProcessingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProcessingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProcessingJob.</param>
        /// 
        /// <returns>Returns a  CreateProcessingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateProcessingJob">REST API Reference for CreateProcessingJob Operation</seealso>
        CreateProcessingJobResponse EndCreateProcessingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProject


        /// <summary>
        /// Creates a machine learning (ML) project that can contain one or more templates that
        /// set up an ML pipeline from training to deploying an approved model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateProject">REST API Reference for CreateProject Operation</seealso>
        CreateProjectResponse CreateProject(CreateProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateProject">REST API Reference for CreateProject Operation</seealso>
        IAsyncResult BeginCreateProject(CreateProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProject.</param>
        /// 
        /// <returns>Returns a  CreateProjectResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateProject">REST API Reference for CreateProject Operation</seealso>
        CreateProjectResponse EndCreateProject(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSpace


        /// <summary>
        /// Creates a space used for real time collaboration in a Domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSpace service method.</param>
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
        CreateSpaceResponse CreateSpace(CreateSpaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSpace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSpace operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSpace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateSpace">REST API Reference for CreateSpace Operation</seealso>
        IAsyncResult BeginCreateSpace(CreateSpaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSpace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSpace.</param>
        /// 
        /// <returns>Returns a  CreateSpaceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateSpace">REST API Reference for CreateSpace Operation</seealso>
        CreateSpaceResponse EndCreateSpace(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStudioLifecycleConfig


        /// <summary>
        /// Creates a new Studio Lifecycle Configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStudioLifecycleConfig service method.</param>
        /// 
        /// <returns>The response from the CreateStudioLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateStudioLifecycleConfig">REST API Reference for CreateStudioLifecycleConfig Operation</seealso>
        CreateStudioLifecycleConfigResponse CreateStudioLifecycleConfig(CreateStudioLifecycleConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStudioLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStudioLifecycleConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStudioLifecycleConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateStudioLifecycleConfig">REST API Reference for CreateStudioLifecycleConfig Operation</seealso>
        IAsyncResult BeginCreateStudioLifecycleConfig(CreateStudioLifecycleConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStudioLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStudioLifecycleConfig.</param>
        /// 
        /// <returns>Returns a  CreateStudioLifecycleConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateStudioLifecycleConfig">REST API Reference for CreateStudioLifecycleConfig Operation</seealso>
        CreateStudioLifecycleConfigResponse EndCreateStudioLifecycleConfig(IAsyncResult asyncResult);

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
        ///  <code>AlgorithmSpecification</code> - Identifies the training algorithm to use. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HyperParameters</code> - Specify these algorithm-specific parameters to enable
        /// the estimation of model parameters during training. Hyperparameters can be tuned to
        /// optimize this learning process. For a list of hyperparameters for each training algorithm
        /// provided by SageMaker, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/algos.html">Algorithms</a>.
        /// 
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not include any security-sensitive information including account access IDs, secrets
        /// or tokens in any hyperparameter field. If the use of security-sensitive credentials
        /// are detected, SageMaker will reject your training job request and return an exception
        /// error.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        ///  <code>InputDataConfig</code> - Describes the input required by the training job and
        /// the Amazon S3, EFS, or FSx location where it is stored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OutputDataConfig</code> - Identifies the Amazon S3 bucket where you want SageMaker
        /// to save the results of model training. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ResourceConfig</code> - Identifies the resources, ML compute instances, and
        /// ML storage volumes to deploy for model training. In distributed training, you specify
        /// more than one instance. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EnableManagedSpotTraining</code> - Optimize the cost of training machine learning
        /// models by up to 80% by using Amazon EC2 Spot instances. For more information, see
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-managed-spot-training.html">Managed
        /// Spot Training</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RoleArn</code> - The Amazon Resource Name (ARN) that SageMaker assumes to perform
        /// tasks on your behalf during model training. You must grant this role the necessary
        /// permissions so that SageMaker can successfully complete model training. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>StoppingCondition</code> - To help cap training costs, use <code>MaxRuntimeInSeconds</code>
        /// to set a time limit for training. Use <code>MaxWaitTimeInSeconds</code> to specify
        /// how long a managed spot training job has to complete. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Environment</code> - The environment variables to set in the Docker container.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RetryStrategy</code> - The number of times to retry the job when the job fails
        /// due to an <code>InternalServerError</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information about SageMaker, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
        /// It Works</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrainingJob service method.</param>
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
        CreateTrainingJobResponse CreateTrainingJob(CreateTrainingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrainingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrainingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrainingJob">REST API Reference for CreateTrainingJob Operation</seealso>
        IAsyncResult BeginCreateTrainingJob(CreateTrainingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrainingJob.</param>
        /// 
        /// <returns>Returns a  CreateTrainingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrainingJob">REST API Reference for CreateTrainingJob Operation</seealso>
        CreateTrainingJobResponse EndCreateTrainingJob(IAsyncResult asyncResult);

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
        ///  <code>TransformJobName</code> - Identifies the transform job. The name must be unique
        /// within an Amazon Web Services Region in an Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ModelName</code> - Identifies the model to use. <code>ModelName</code> must
        /// be the name of an existing Amazon SageMaker model in the same Amazon Web Services
        /// Region and Amazon Web Services account. For information on creating a model, see <a
        /// href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateModel.html">CreateModel</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TransformInput</code> - Describes the dataset to be transformed and the Amazon
        /// S3 location where it is stored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TransformOutput</code> - Identifies the Amazon S3 location where you want Amazon
        /// SageMaker to save the results from the transform job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TransformResources</code> - Identifies the ML compute instances for the transform
        /// job.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about how batch transformation works, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/batch-transform.html">Batch
        /// Transform</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransformJob service method.</param>
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
        CreateTransformJobResponse CreateTransformJob(CreateTransformJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTransformJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTransformJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTransformJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTransformJob">REST API Reference for CreateTransformJob Operation</seealso>
        IAsyncResult BeginCreateTransformJob(CreateTransformJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTransformJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTransformJob.</param>
        /// 
        /// <returns>Returns a  CreateTransformJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTransformJob">REST API Reference for CreateTransformJob Operation</seealso>
        CreateTransformJobResponse EndCreateTransformJob(IAsyncResult asyncResult);

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
        /// You can add tags to a trial and then use the <a>Search</a> API to search for the tags.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your trials, call the <a>ListTrials</a> API. To view a trial's
        /// properties, call the <a>DescribeTrial</a> API. To create a trial component, call the
        /// <a>CreateTrialComponent</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrial service method.</param>
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
        CreateTrialResponse CreateTrial(CreateTrialRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrial operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrial operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrial
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrial">REST API Reference for CreateTrial Operation</seealso>
        IAsyncResult BeginCreateTrial(CreateTrialRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrial operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrial.</param>
        /// 
        /// <returns>Returns a  CreateTrialResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrial">REST API Reference for CreateTrial Operation</seealso>
        CreateTrialResponse EndCreateTrial(IAsyncResult asyncResult);

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
        /// You can add tags to a trial component and then use the <a>Search</a> API to search
        /// for the tags.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrialComponent service method.</param>
        /// 
        /// <returns>The response from the CreateTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrialComponent">REST API Reference for CreateTrialComponent Operation</seealso>
        CreateTrialComponentResponse CreateTrialComponent(CreateTrialComponentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrialComponent operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrialComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrialComponent">REST API Reference for CreateTrialComponent Operation</seealso>
        IAsyncResult BeginCreateTrialComponent(CreateTrialComponentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrialComponent.</param>
        /// 
        /// <returns>Returns a  CreateTrialComponentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrialComponent">REST API Reference for CreateTrialComponent Operation</seealso>
        CreateTrialComponentResponse EndCreateTrialComponent(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateUserProfile


        /// <summary>
        /// Creates a user profile. A user profile represents a single user within a domain, and
        /// is the main way to reference a "person" for the purposes of sharing, reporting, and
        /// other user-oriented features. This entity is created when a user onboards to Amazon
        /// SageMaker Studio. If an administrator invites a person by email or imports them from
        /// IAM Identity Center, a user profile is automatically created. A user profile is the
        /// primary holder of settings for an individual user and has a reference to the user's
        /// private Amazon Elastic File System (EFS) home directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile service method.</param>
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
        CreateUserProfileResponse CreateUserProfile(CreateUserProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUserProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        IAsyncResult BeginCreateUserProfile(CreateUserProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserProfile.</param>
        /// 
        /// <returns>Returns a  CreateUserProfileResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        CreateUserProfileResponse EndCreateUserProfile(IAsyncResult asyncResult);

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
        /// already exists, use the API operation to delete the existing workforce and then use
        /// <code>CreateWorkforce</code> to create a new workforce.
        /// </para>
        ///  
        /// <para>
        /// To create a private workforce using Amazon Cognito, you must specify a Cognito user
        /// pool in <code>CognitoConfig</code>. You can also create an Amazon Cognito workforce
        /// using the Amazon SageMaker console. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-workforce-create-private.html">
        /// Create a Private Workforce (Amazon Cognito)</a>.
        /// </para>
        ///  
        /// <para>
        /// To create a private workforce using your own OIDC Identity Provider (IdP), specify
        /// your IdP configuration in <code>OidcConfig</code>. Your OIDC IdP must support <i>groups</i>
        /// because groups are used by Ground Truth and Amazon A2I to create work teams. For more
        /// information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-workforce-create-private-oidc.html">
        /// Create a Private Workforce (OIDC IdP)</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkforce service method.</param>
        /// 
        /// <returns>The response from the CreateWorkforce service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateWorkforce">REST API Reference for CreateWorkforce Operation</seealso>
        CreateWorkforceResponse CreateWorkforce(CreateWorkforceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkforce operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkforce operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkforce
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateWorkforce">REST API Reference for CreateWorkforce Operation</seealso>
        IAsyncResult BeginCreateWorkforce(CreateWorkforceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkforce operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkforce.</param>
        /// 
        /// <returns>Returns a  CreateWorkforceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateWorkforce">REST API Reference for CreateWorkforce Operation</seealso>
        CreateWorkforceResponse EndCreateWorkforce(IAsyncResult asyncResult);

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
        CreateWorkteamResponse CreateWorkteam(CreateWorkteamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkteam operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkteam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateWorkteam">REST API Reference for CreateWorkteam Operation</seealso>
        IAsyncResult BeginCreateWorkteam(CreateWorkteamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkteam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkteam.</param>
        /// 
        /// <returns>Returns a  CreateWorkteamResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateWorkteam">REST API Reference for CreateWorkteam Operation</seealso>
        CreateWorkteamResponse EndCreateWorkteam(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAction


        /// <summary>
        /// Deletes an action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAction service method.</param>
        /// 
        /// <returns>The response from the DeleteAction service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAction">REST API Reference for DeleteAction Operation</seealso>
        DeleteActionResponse DeleteAction(DeleteActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAction operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAction">REST API Reference for DeleteAction Operation</seealso>
        IAsyncResult BeginDeleteAction(DeleteActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAction.</param>
        /// 
        /// <returns>Returns a  DeleteActionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAction">REST API Reference for DeleteAction Operation</seealso>
        DeleteActionResponse EndDeleteAction(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAlgorithm


        /// <summary>
        /// Removes the specified algorithm from your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlgorithm service method.</param>
        /// 
        /// <returns>The response from the DeleteAlgorithm service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAlgorithm">REST API Reference for DeleteAlgorithm Operation</seealso>
        DeleteAlgorithmResponse DeleteAlgorithm(DeleteAlgorithmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlgorithm operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAlgorithm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAlgorithm">REST API Reference for DeleteAlgorithm Operation</seealso>
        IAsyncResult BeginDeleteAlgorithm(DeleteAlgorithmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlgorithm.</param>
        /// 
        /// <returns>Returns a  DeleteAlgorithmResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAlgorithm">REST API Reference for DeleteAlgorithm Operation</seealso>
        DeleteAlgorithmResponse EndDeleteAlgorithm(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApp


        /// <summary>
        /// Used to stop and delete an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        DeleteAppResponse DeleteApp(DeleteAppRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        IAsyncResult BeginDeleteApp(DeleteAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApp.</param>
        /// 
        /// <returns>Returns a  DeleteAppResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        DeleteAppResponse EndDeleteApp(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAppImageConfig


        /// <summary>
        /// Deletes an AppImageConfig.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppImageConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteAppImageConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAppImageConfig">REST API Reference for DeleteAppImageConfig Operation</seealso>
        DeleteAppImageConfigResponse DeleteAppImageConfig(DeleteAppImageConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppImageConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppImageConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAppImageConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAppImageConfig">REST API Reference for DeleteAppImageConfig Operation</seealso>
        IAsyncResult BeginDeleteAppImageConfig(DeleteAppImageConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAppImageConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAppImageConfig.</param>
        /// 
        /// <returns>Returns a  DeleteAppImageConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAppImageConfig">REST API Reference for DeleteAppImageConfig Operation</seealso>
        DeleteAppImageConfigResponse EndDeleteAppImageConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteArtifact


        /// <summary>
        /// Deletes an artifact. Either <code>ArtifactArn</code> or <code>Source</code> must be
        /// specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArtifact service method.</param>
        /// 
        /// <returns>The response from the DeleteArtifact service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteArtifact">REST API Reference for DeleteArtifact Operation</seealso>
        DeleteArtifactResponse DeleteArtifact(DeleteArtifactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteArtifact operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteArtifact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteArtifact">REST API Reference for DeleteArtifact Operation</seealso>
        IAsyncResult BeginDeleteArtifact(DeleteArtifactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteArtifact.</param>
        /// 
        /// <returns>Returns a  DeleteArtifactResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteArtifact">REST API Reference for DeleteArtifact Operation</seealso>
        DeleteArtifactResponse EndDeleteArtifact(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAssociation


        /// <summary>
        /// Deletes an association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteAssociation service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAssociation">REST API Reference for DeleteAssociation Operation</seealso>
        DeleteAssociationResponse DeleteAssociation(DeleteAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssociation operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAssociation">REST API Reference for DeleteAssociation Operation</seealso>
        IAsyncResult BeginDeleteAssociation(DeleteAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteAssociationResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAssociation">REST API Reference for DeleteAssociation Operation</seealso>
        DeleteAssociationResponse EndDeleteAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCodeRepository


        /// <summary>
        /// Deletes the specified Git repository from your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeRepository service method.</param>
        /// 
        /// <returns>The response from the DeleteCodeRepository service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteCodeRepository">REST API Reference for DeleteCodeRepository Operation</seealso>
        DeleteCodeRepositoryResponse DeleteCodeRepository(DeleteCodeRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeRepository operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCodeRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteCodeRepository">REST API Reference for DeleteCodeRepository Operation</seealso>
        IAsyncResult BeginDeleteCodeRepository(DeleteCodeRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCodeRepository.</param>
        /// 
        /// <returns>Returns a  DeleteCodeRepositoryResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteCodeRepository">REST API Reference for DeleteCodeRepository Operation</seealso>
        DeleteCodeRepositoryResponse EndDeleteCodeRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteContext


        /// <summary>
        /// Deletes an context.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContext service method.</param>
        /// 
        /// <returns>The response from the DeleteContext service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteContext">REST API Reference for DeleteContext Operation</seealso>
        DeleteContextResponse DeleteContext(DeleteContextRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContext operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContext operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteContext
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteContext">REST API Reference for DeleteContext Operation</seealso>
        IAsyncResult BeginDeleteContext(DeleteContextRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteContext operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteContext.</param>
        /// 
        /// <returns>Returns a  DeleteContextResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteContext">REST API Reference for DeleteContext Operation</seealso>
        DeleteContextResponse EndDeleteContext(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataQualityJobDefinition


        /// <summary>
        /// Deletes a data quality monitoring job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataQualityJobDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteDataQualityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteDataQualityJobDefinition">REST API Reference for DeleteDataQualityJobDefinition Operation</seealso>
        DeleteDataQualityJobDefinitionResponse DeleteDataQualityJobDefinition(DeleteDataQualityJobDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataQualityJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataQualityJobDefinition operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataQualityJobDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteDataQualityJobDefinition">REST API Reference for DeleteDataQualityJobDefinition Operation</seealso>
        IAsyncResult BeginDeleteDataQualityJobDefinition(DeleteDataQualityJobDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataQualityJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataQualityJobDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteDataQualityJobDefinitionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteDataQualityJobDefinition">REST API Reference for DeleteDataQualityJobDefinition Operation</seealso>
        DeleteDataQualityJobDefinitionResponse EndDeleteDataQualityJobDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDeviceFleet


        /// <summary>
        /// Deletes a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeviceFleet service method.</param>
        /// 
        /// <returns>The response from the DeleteDeviceFleet service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteDeviceFleet">REST API Reference for DeleteDeviceFleet Operation</seealso>
        DeleteDeviceFleetResponse DeleteDeviceFleet(DeleteDeviceFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeviceFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeviceFleet operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDeviceFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteDeviceFleet">REST API Reference for DeleteDeviceFleet Operation</seealso>
        IAsyncResult BeginDeleteDeviceFleet(DeleteDeviceFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeviceFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeviceFleet.</param>
        /// 
        /// <returns>Returns a  DeleteDeviceFleetResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteDeviceFleet">REST API Reference for DeleteDeviceFleet Operation</seealso>
        DeleteDeviceFleetResponse EndDeleteDeviceFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDomain


        /// <summary>
        /// Used to delete a domain. If you onboarded with IAM mode, you will need to delete your
        /// domain to onboard again using IAM Identity Center. Use with caution. All of the members
        /// of the domain will lose access to their EFS volume, including data, notebooks, and
        /// other artifacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        DeleteDomainResponse DeleteDomain(DeleteDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        IAsyncResult BeginDeleteDomain(DeleteDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomain.</param>
        /// 
        /// <returns>Returns a  DeleteDomainResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        DeleteDomainResponse EndDeleteDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEdgeDeploymentPlan


        /// <summary>
        /// Deletes an edge deployment plan if (and only if) all the stages in the plan are inactive
        /// or there are no stages in the plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEdgeDeploymentPlan service method.</param>
        /// 
        /// <returns>The response from the DeleteEdgeDeploymentPlan service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEdgeDeploymentPlan">REST API Reference for DeleteEdgeDeploymentPlan Operation</seealso>
        DeleteEdgeDeploymentPlanResponse DeleteEdgeDeploymentPlan(DeleteEdgeDeploymentPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEdgeDeploymentPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEdgeDeploymentPlan operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEdgeDeploymentPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEdgeDeploymentPlan">REST API Reference for DeleteEdgeDeploymentPlan Operation</seealso>
        IAsyncResult BeginDeleteEdgeDeploymentPlan(DeleteEdgeDeploymentPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEdgeDeploymentPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEdgeDeploymentPlan.</param>
        /// 
        /// <returns>Returns a  DeleteEdgeDeploymentPlanResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEdgeDeploymentPlan">REST API Reference for DeleteEdgeDeploymentPlan Operation</seealso>
        DeleteEdgeDeploymentPlanResponse EndDeleteEdgeDeploymentPlan(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEdgeDeploymentStage


        /// <summary>
        /// Delete a stage in an edge deployment plan if (and only if) the stage is inactive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEdgeDeploymentStage service method.</param>
        /// 
        /// <returns>The response from the DeleteEdgeDeploymentStage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEdgeDeploymentStage">REST API Reference for DeleteEdgeDeploymentStage Operation</seealso>
        DeleteEdgeDeploymentStageResponse DeleteEdgeDeploymentStage(DeleteEdgeDeploymentStageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEdgeDeploymentStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEdgeDeploymentStage operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEdgeDeploymentStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEdgeDeploymentStage">REST API Reference for DeleteEdgeDeploymentStage Operation</seealso>
        IAsyncResult BeginDeleteEdgeDeploymentStage(DeleteEdgeDeploymentStageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEdgeDeploymentStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEdgeDeploymentStage.</param>
        /// 
        /// <returns>Returns a  DeleteEdgeDeploymentStageResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEdgeDeploymentStage">REST API Reference for DeleteEdgeDeploymentStage Operation</seealso>
        DeleteEdgeDeploymentStageResponse EndDeleteEdgeDeploymentStage(IAsyncResult asyncResult);

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
        /// for your <code> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateModel.html#sagemaker-CreateModel-request-ExecutionRoleArn">ExecutionRoleArn</a>
        /// </code>, otherwise SageMaker cannot delete these resources.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        IAsyncResult BeginDeleteEndpoint(DeleteEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        DeleteEndpointResponse EndDeleteEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEndpointConfig


        /// <summary>
        /// Deletes an endpoint configuration. The <code>DeleteEndpointConfig</code> API deletes
        /// only the specified configuration. It does not delete endpoints created using the configuration.
        /// 
        /// 
        ///  
        /// <para>
        /// You must not delete an <code>EndpointConfig</code> in use by an endpoint that is live
        /// or while the <code>UpdateEndpoint</code> or <code>CreateEndpoint</code> operations
        /// are being performed on the endpoint. If you delete the <code>EndpointConfig</code>
        /// of an endpoint that is active or being created or updated you may lose visibility
        /// into the instance type the endpoint is using. The endpoint must be deleted in order
        /// to stop incurring charges.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpointConfig service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpointConfig">REST API Reference for DeleteEndpointConfig Operation</seealso>
        DeleteEndpointConfigResponse DeleteEndpointConfig(DeleteEndpointConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEndpointConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpointConfig">REST API Reference for DeleteEndpointConfig Operation</seealso>
        IAsyncResult BeginDeleteEndpointConfig(DeleteEndpointConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpointConfig.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpointConfig">REST API Reference for DeleteEndpointConfig Operation</seealso>
        DeleteEndpointConfigResponse EndDeleteEndpointConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteExperiment


        /// <summary>
        /// Deletes an SageMaker experiment. All trials associated with the experiment must be
        /// deleted first. Use the <a>ListTrials</a> API to get a list of the trials associated
        /// with the experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExperiment service method.</param>
        /// 
        /// <returns>The response from the DeleteExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteExperiment">REST API Reference for DeleteExperiment Operation</seealso>
        DeleteExperimentResponse DeleteExperiment(DeleteExperimentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteExperiment operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteExperiment">REST API Reference for DeleteExperiment Operation</seealso>
        IAsyncResult BeginDeleteExperiment(DeleteExperimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteExperiment.</param>
        /// 
        /// <returns>Returns a  DeleteExperimentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteExperiment">REST API Reference for DeleteExperiment Operation</seealso>
        DeleteExperimentResponse EndDeleteExperiment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFeatureGroup


        /// <summary>
        /// Delete the <code>FeatureGroup</code> and any data that was written to the <code>OnlineStore</code>
        /// of the <code>FeatureGroup</code>. Data cannot be accessed from the <code>OnlineStore</code>
        /// immediately after <code>DeleteFeatureGroup</code> is called. 
        /// 
        ///  
        /// <para>
        /// Data written into the <code>OfflineStore</code> will not be deleted. The Amazon Web
        /// Services Glue database and tables that are automatically created for your <code>OfflineStore</code>
        /// are not deleted. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFeatureGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteFeatureGroup service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteFeatureGroup">REST API Reference for DeleteFeatureGroup Operation</seealso>
        DeleteFeatureGroupResponse DeleteFeatureGroup(DeleteFeatureGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFeatureGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFeatureGroup operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFeatureGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteFeatureGroup">REST API Reference for DeleteFeatureGroup Operation</seealso>
        IAsyncResult BeginDeleteFeatureGroup(DeleteFeatureGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFeatureGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFeatureGroup.</param>
        /// 
        /// <returns>Returns a  DeleteFeatureGroupResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteFeatureGroup">REST API Reference for DeleteFeatureGroup Operation</seealso>
        DeleteFeatureGroupResponse EndDeleteFeatureGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFlowDefinition


        /// <summary>
        /// Deletes the specified flow definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteFlowDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteFlowDefinition">REST API Reference for DeleteFlowDefinition Operation</seealso>
        DeleteFlowDefinitionResponse DeleteFlowDefinition(DeleteFlowDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFlowDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowDefinition operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFlowDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteFlowDefinition">REST API Reference for DeleteFlowDefinition Operation</seealso>
        IAsyncResult BeginDeleteFlowDefinition(DeleteFlowDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFlowDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFlowDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteFlowDefinitionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteFlowDefinition">REST API Reference for DeleteFlowDefinition Operation</seealso>
        DeleteFlowDefinitionResponse EndDeleteFlowDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteHub


        /// <summary>
        /// Delete a hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHub service method.</param>
        /// 
        /// <returns>The response from the DeleteHub service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteHub">REST API Reference for DeleteHub Operation</seealso>
        DeleteHubResponse DeleteHub(DeleteHubRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHub operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHub operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHub
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteHub">REST API Reference for DeleteHub Operation</seealso>
        IAsyncResult BeginDeleteHub(DeleteHubRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHub operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHub.</param>
        /// 
        /// <returns>Returns a  DeleteHubResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteHub">REST API Reference for DeleteHub Operation</seealso>
        DeleteHubResponse EndDeleteHub(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteHubContent


        /// <summary>
        /// Delete the contents of a hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHubContent service method.</param>
        /// 
        /// <returns>The response from the DeleteHubContent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteHubContent">REST API Reference for DeleteHubContent Operation</seealso>
        DeleteHubContentResponse DeleteHubContent(DeleteHubContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHubContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHubContent operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHubContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteHubContent">REST API Reference for DeleteHubContent Operation</seealso>
        IAsyncResult BeginDeleteHubContent(DeleteHubContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHubContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHubContent.</param>
        /// 
        /// <returns>Returns a  DeleteHubContentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteHubContent">REST API Reference for DeleteHubContent Operation</seealso>
        DeleteHubContentResponse EndDeleteHubContent(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteHumanTaskUi


        /// <summary>
        /// Use this operation to delete a human task user interface (worker task template).
        /// 
        ///  
        /// <para>
        ///  To see a list of human task user interfaces (work task templates) in your account,
        /// use . When you delete a worker task template, it no longer appears when you call <code>ListHumanTaskUis</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHumanTaskUi service method.</param>
        /// 
        /// <returns>The response from the DeleteHumanTaskUi service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteHumanTaskUi">REST API Reference for DeleteHumanTaskUi Operation</seealso>
        DeleteHumanTaskUiResponse DeleteHumanTaskUi(DeleteHumanTaskUiRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHumanTaskUi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHumanTaskUi operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHumanTaskUi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteHumanTaskUi">REST API Reference for DeleteHumanTaskUi Operation</seealso>
        IAsyncResult BeginDeleteHumanTaskUi(DeleteHumanTaskUiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHumanTaskUi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHumanTaskUi.</param>
        /// 
        /// <returns>Returns a  DeleteHumanTaskUiResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteHumanTaskUi">REST API Reference for DeleteHumanTaskUi Operation</seealso>
        DeleteHumanTaskUiResponse EndDeleteHumanTaskUi(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteImage


        /// <summary>
        /// Deletes a SageMaker image and all versions of the image. The container images aren't
        /// deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImage service method.</param>
        /// 
        /// <returns>The response from the DeleteImage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteImage">REST API Reference for DeleteImage Operation</seealso>
        DeleteImageResponse DeleteImage(DeleteImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImage operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteImage">REST API Reference for DeleteImage Operation</seealso>
        IAsyncResult BeginDeleteImage(DeleteImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteImage.</param>
        /// 
        /// <returns>Returns a  DeleteImageResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteImage">REST API Reference for DeleteImage Operation</seealso>
        DeleteImageResponse EndDeleteImage(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteImageVersion


        /// <summary>
        /// Deletes a version of a SageMaker image. The container image the version represents
        /// isn't deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImageVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteImageVersion service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteImageVersion">REST API Reference for DeleteImageVersion Operation</seealso>
        DeleteImageVersionResponse DeleteImageVersion(DeleteImageVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImageVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImageVersion operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteImageVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteImageVersion">REST API Reference for DeleteImageVersion Operation</seealso>
        IAsyncResult BeginDeleteImageVersion(DeleteImageVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteImageVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteImageVersion.</param>
        /// 
        /// <returns>Returns a  DeleteImageVersionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteImageVersion">REST API Reference for DeleteImageVersion Operation</seealso>
        DeleteImageVersionResponse EndDeleteImageVersion(IAsyncResult asyncResult);

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
        /// 
        /// <returns>The response from the DeleteInferenceExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteInferenceExperiment">REST API Reference for DeleteInferenceExperiment Operation</seealso>
        DeleteInferenceExperimentResponse DeleteInferenceExperiment(DeleteInferenceExperimentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInferenceExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInferenceExperiment operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInferenceExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteInferenceExperiment">REST API Reference for DeleteInferenceExperiment Operation</seealso>
        IAsyncResult BeginDeleteInferenceExperiment(DeleteInferenceExperimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInferenceExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInferenceExperiment.</param>
        /// 
        /// <returns>Returns a  DeleteInferenceExperimentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteInferenceExperiment">REST API Reference for DeleteInferenceExperiment Operation</seealso>
        DeleteInferenceExperimentResponse EndDeleteInferenceExperiment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteModel


        /// <summary>
        /// Deletes a model. The <code>DeleteModel</code> API deletes only the model entry that
        /// was created in SageMaker when you called the <code>CreateModel</code> API. It does
        /// not delete model artifacts, inference code, or the IAM role that you specified when
        /// creating the model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// 
        /// <returns>The response from the DeleteModel service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        DeleteModelResponse DeleteModel(DeleteModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        IAsyncResult BeginDeleteModel(DeleteModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModel.</param>
        /// 
        /// <returns>Returns a  DeleteModelResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        DeleteModelResponse EndDeleteModel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteModelBiasJobDefinition


        /// <summary>
        /// Deletes an Amazon SageMaker model bias job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelBiasJobDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteModelBiasJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelBiasJobDefinition">REST API Reference for DeleteModelBiasJobDefinition Operation</seealso>
        DeleteModelBiasJobDefinitionResponse DeleteModelBiasJobDefinition(DeleteModelBiasJobDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModelBiasJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelBiasJobDefinition operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModelBiasJobDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelBiasJobDefinition">REST API Reference for DeleteModelBiasJobDefinition Operation</seealso>
        IAsyncResult BeginDeleteModelBiasJobDefinition(DeleteModelBiasJobDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModelBiasJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModelBiasJobDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteModelBiasJobDefinitionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelBiasJobDefinition">REST API Reference for DeleteModelBiasJobDefinition Operation</seealso>
        DeleteModelBiasJobDefinitionResponse EndDeleteModelBiasJobDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteModelCard


        /// <summary>
        /// Deletes an Amazon SageMaker Model Card.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelCard service method.</param>
        /// 
        /// <returns>The response from the DeleteModelCard service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelCard">REST API Reference for DeleteModelCard Operation</seealso>
        DeleteModelCardResponse DeleteModelCard(DeleteModelCardRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModelCard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelCard operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModelCard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelCard">REST API Reference for DeleteModelCard Operation</seealso>
        IAsyncResult BeginDeleteModelCard(DeleteModelCardRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModelCard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModelCard.</param>
        /// 
        /// <returns>Returns a  DeleteModelCardResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelCard">REST API Reference for DeleteModelCard Operation</seealso>
        DeleteModelCardResponse EndDeleteModelCard(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteModelExplainabilityJobDefinition


        /// <summary>
        /// Deletes an Amazon SageMaker model explainability job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelExplainabilityJobDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteModelExplainabilityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelExplainabilityJobDefinition">REST API Reference for DeleteModelExplainabilityJobDefinition Operation</seealso>
        DeleteModelExplainabilityJobDefinitionResponse DeleteModelExplainabilityJobDefinition(DeleteModelExplainabilityJobDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModelExplainabilityJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelExplainabilityJobDefinition operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModelExplainabilityJobDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelExplainabilityJobDefinition">REST API Reference for DeleteModelExplainabilityJobDefinition Operation</seealso>
        IAsyncResult BeginDeleteModelExplainabilityJobDefinition(DeleteModelExplainabilityJobDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModelExplainabilityJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModelExplainabilityJobDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteModelExplainabilityJobDefinitionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelExplainabilityJobDefinition">REST API Reference for DeleteModelExplainabilityJobDefinition Operation</seealso>
        DeleteModelExplainabilityJobDefinitionResponse EndDeleteModelExplainabilityJobDefinition(IAsyncResult asyncResult);

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
        /// 
        /// <returns>The response from the DeleteModelPackage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackage">REST API Reference for DeleteModelPackage Operation</seealso>
        DeleteModelPackageResponse DeleteModelPackage(DeleteModelPackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModelPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelPackage operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModelPackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackage">REST API Reference for DeleteModelPackage Operation</seealso>
        IAsyncResult BeginDeleteModelPackage(DeleteModelPackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModelPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModelPackage.</param>
        /// 
        /// <returns>Returns a  DeleteModelPackageResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackage">REST API Reference for DeleteModelPackage Operation</seealso>
        DeleteModelPackageResponse EndDeleteModelPackage(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteModelPackageGroup


        /// <summary>
        /// Deletes the specified model group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelPackageGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteModelPackageGroup service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackageGroup">REST API Reference for DeleteModelPackageGroup Operation</seealso>
        DeleteModelPackageGroupResponse DeleteModelPackageGroup(DeleteModelPackageGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModelPackageGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelPackageGroup operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModelPackageGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackageGroup">REST API Reference for DeleteModelPackageGroup Operation</seealso>
        IAsyncResult BeginDeleteModelPackageGroup(DeleteModelPackageGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModelPackageGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModelPackageGroup.</param>
        /// 
        /// <returns>Returns a  DeleteModelPackageGroupResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackageGroup">REST API Reference for DeleteModelPackageGroup Operation</seealso>
        DeleteModelPackageGroupResponse EndDeleteModelPackageGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteModelPackageGroupPolicy


        /// <summary>
        /// Deletes a model group resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelPackageGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteModelPackageGroupPolicy service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackageGroupPolicy">REST API Reference for DeleteModelPackageGroupPolicy Operation</seealso>
        DeleteModelPackageGroupPolicyResponse DeleteModelPackageGroupPolicy(DeleteModelPackageGroupPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModelPackageGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelPackageGroupPolicy operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModelPackageGroupPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackageGroupPolicy">REST API Reference for DeleteModelPackageGroupPolicy Operation</seealso>
        IAsyncResult BeginDeleteModelPackageGroupPolicy(DeleteModelPackageGroupPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModelPackageGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModelPackageGroupPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteModelPackageGroupPolicyResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackageGroupPolicy">REST API Reference for DeleteModelPackageGroupPolicy Operation</seealso>
        DeleteModelPackageGroupPolicyResponse EndDeleteModelPackageGroupPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteModelQualityJobDefinition


        /// <summary>
        /// Deletes the secified model quality monitoring job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelQualityJobDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteModelQualityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelQualityJobDefinition">REST API Reference for DeleteModelQualityJobDefinition Operation</seealso>
        DeleteModelQualityJobDefinitionResponse DeleteModelQualityJobDefinition(DeleteModelQualityJobDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModelQualityJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelQualityJobDefinition operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModelQualityJobDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelQualityJobDefinition">REST API Reference for DeleteModelQualityJobDefinition Operation</seealso>
        IAsyncResult BeginDeleteModelQualityJobDefinition(DeleteModelQualityJobDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModelQualityJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModelQualityJobDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteModelQualityJobDefinitionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelQualityJobDefinition">REST API Reference for DeleteModelQualityJobDefinition Operation</seealso>
        DeleteModelQualityJobDefinitionResponse EndDeleteModelQualityJobDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMonitoringSchedule


        /// <summary>
        /// Deletes a monitoring schedule. Also stops the schedule had not already been stopped.
        /// This does not delete the job execution history of the monitoring schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitoringSchedule service method.</param>
        /// 
        /// <returns>The response from the DeleteMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteMonitoringSchedule">REST API Reference for DeleteMonitoringSchedule Operation</seealso>
        DeleteMonitoringScheduleResponse DeleteMonitoringSchedule(DeleteMonitoringScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitoringSchedule operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMonitoringSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteMonitoringSchedule">REST API Reference for DeleteMonitoringSchedule Operation</seealso>
        IAsyncResult BeginDeleteMonitoringSchedule(DeleteMonitoringScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMonitoringSchedule.</param>
        /// 
        /// <returns>Returns a  DeleteMonitoringScheduleResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteMonitoringSchedule">REST API Reference for DeleteMonitoringSchedule Operation</seealso>
        DeleteMonitoringScheduleResponse EndDeleteMonitoringSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNotebookInstance


        /// <summary>
        /// Deletes an SageMaker notebook instance. Before you can delete a notebook instance,
        /// you must call the <code>StopNotebookInstance</code> API. 
        /// 
        ///  <important> 
        /// <para>
        /// When you delete a notebook instance, you lose all of your data. SageMaker removes
        /// the ML compute instance, and deletes the ML storage volume and the network interface
        /// associated with the notebook instance. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebookInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteNotebookInstance service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstance">REST API Reference for DeleteNotebookInstance Operation</seealso>
        DeleteNotebookInstanceResponse DeleteNotebookInstance(DeleteNotebookInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebookInstance operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNotebookInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstance">REST API Reference for DeleteNotebookInstance Operation</seealso>
        IAsyncResult BeginDeleteNotebookInstance(DeleteNotebookInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotebookInstance.</param>
        /// 
        /// <returns>Returns a  DeleteNotebookInstanceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstance">REST API Reference for DeleteNotebookInstance Operation</seealso>
        DeleteNotebookInstanceResponse EndDeleteNotebookInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNotebookInstanceLifecycleConfig


        /// <summary>
        /// Deletes a notebook instance lifecycle configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebookInstanceLifecycleConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteNotebookInstanceLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstanceLifecycleConfig">REST API Reference for DeleteNotebookInstanceLifecycleConfig Operation</seealso>
        DeleteNotebookInstanceLifecycleConfigResponse DeleteNotebookInstanceLifecycleConfig(DeleteNotebookInstanceLifecycleConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebookInstanceLifecycleConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNotebookInstanceLifecycleConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstanceLifecycleConfig">REST API Reference for DeleteNotebookInstanceLifecycleConfig Operation</seealso>
        IAsyncResult BeginDeleteNotebookInstanceLifecycleConfig(DeleteNotebookInstanceLifecycleConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotebookInstanceLifecycleConfig.</param>
        /// 
        /// <returns>Returns a  DeleteNotebookInstanceLifecycleConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstanceLifecycleConfig">REST API Reference for DeleteNotebookInstanceLifecycleConfig Operation</seealso>
        DeleteNotebookInstanceLifecycleConfigResponse EndDeleteNotebookInstanceLifecycleConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePipeline


        /// <summary>
        /// Deletes a pipeline if there are no running instances of the pipeline. To delete a
        /// pipeline, you must stop all running instances of the pipeline using the <code>StopPipelineExecution</code>
        /// API. When you delete a pipeline, all instances of the pipeline are deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        DeletePipelineResponse DeletePipeline(DeletePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        IAsyncResult BeginDeletePipeline(DeletePipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePipeline.</param>
        /// 
        /// <returns>Returns a  DeletePipelineResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        DeletePipelineResponse EndDeletePipeline(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProject


        /// <summary>
        /// Delete the specified project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        DeleteProjectResponse DeleteProject(DeleteProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        IAsyncResult BeginDeleteProject(DeleteProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProject.</param>
        /// 
        /// <returns>Returns a  DeleteProjectResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        DeleteProjectResponse EndDeleteProject(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSpace


        /// <summary>
        /// Used to delete a space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpace service method.</param>
        /// 
        /// <returns>The response from the DeleteSpace service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteSpace">REST API Reference for DeleteSpace Operation</seealso>
        DeleteSpaceResponse DeleteSpace(DeleteSpaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSpace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpace operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSpace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteSpace">REST API Reference for DeleteSpace Operation</seealso>
        IAsyncResult BeginDeleteSpace(DeleteSpaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSpace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSpace.</param>
        /// 
        /// <returns>Returns a  DeleteSpaceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteSpace">REST API Reference for DeleteSpace Operation</seealso>
        DeleteSpaceResponse EndDeleteSpace(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteStudioLifecycleConfig


        /// <summary>
        /// Deletes the Studio Lifecycle Configuration. In order to delete the Lifecycle Configuration,
        /// there must be no running apps using the Lifecycle Configuration. You must also remove
        /// the Lifecycle Configuration from UserSettings in all Domains and UserProfiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudioLifecycleConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteStudioLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteStudioLifecycleConfig">REST API Reference for DeleteStudioLifecycleConfig Operation</seealso>
        DeleteStudioLifecycleConfigResponse DeleteStudioLifecycleConfig(DeleteStudioLifecycleConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStudioLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudioLifecycleConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStudioLifecycleConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteStudioLifecycleConfig">REST API Reference for DeleteStudioLifecycleConfig Operation</seealso>
        IAsyncResult BeginDeleteStudioLifecycleConfig(DeleteStudioLifecycleConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStudioLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStudioLifecycleConfig.</param>
        /// 
        /// <returns>Returns a  DeleteStudioLifecycleConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteStudioLifecycleConfig">REST API Reference for DeleteStudioLifecycleConfig Operation</seealso>
        DeleteStudioLifecycleConfigResponse EndDeleteStudioLifecycleConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTags


        /// <summary>
        /// Deletes the specified tags from an SageMaker resource.
        /// 
        ///  
        /// <para>
        /// To list a resource's tags, use the <code>ListTags</code> API. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you call this API to delete tags from a hyperparameter tuning job, the deleted
        /// tags are not removed from training jobs that the hyperparameter tuning job launched
        /// before you called this API.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// When you call this API to delete tags from a SageMaker Studio Domain or User Profile,
        /// the deleted tags are not removed from Apps that the SageMaker Studio Domain or User
        /// Profile launched before you called this API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        DeleteTagsResponse DeleteTags(DeleteTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        IAsyncResult BeginDeleteTags(DeleteTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTags.</param>
        /// 
        /// <returns>Returns a  DeleteTagsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        DeleteTagsResponse EndDeleteTags(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTrial


        /// <summary>
        /// Deletes the specified trial. All trial components that make up the trial must be deleted
        /// first. Use the <a>DescribeTrialComponent</a> API to get the list of trial components.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrial service method.</param>
        /// 
        /// <returns>The response from the DeleteTrial service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTrial">REST API Reference for DeleteTrial Operation</seealso>
        DeleteTrialResponse DeleteTrial(DeleteTrialRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrial operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrial operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrial
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTrial">REST API Reference for DeleteTrial Operation</seealso>
        IAsyncResult BeginDeleteTrial(DeleteTrialRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrial operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrial.</param>
        /// 
        /// <returns>Returns a  DeleteTrialResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTrial">REST API Reference for DeleteTrial Operation</seealso>
        DeleteTrialResponse EndDeleteTrial(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTrialComponent


        /// <summary>
        /// Deletes the specified trial component. A trial component must be disassociated from
        /// all trials before the trial component can be deleted. To disassociate a trial component
        /// from a trial, call the <a>DisassociateTrialComponent</a> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrialComponent service method.</param>
        /// 
        /// <returns>The response from the DeleteTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTrialComponent">REST API Reference for DeleteTrialComponent Operation</seealso>
        DeleteTrialComponentResponse DeleteTrialComponent(DeleteTrialComponentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrialComponent operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrialComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTrialComponent">REST API Reference for DeleteTrialComponent Operation</seealso>
        IAsyncResult BeginDeleteTrialComponent(DeleteTrialComponentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrialComponent.</param>
        /// 
        /// <returns>Returns a  DeleteTrialComponentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTrialComponent">REST API Reference for DeleteTrialComponent Operation</seealso>
        DeleteTrialComponentResponse EndDeleteTrialComponent(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUserProfile


        /// <summary>
        /// Deletes a user profile. When a user profile is deleted, the user loses access to their
        /// EFS volume, including data, notebooks, and other artifacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteUserProfile service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteUserProfile">REST API Reference for DeleteUserProfile Operation</seealso>
        DeleteUserProfileResponse DeleteUserProfile(DeleteUserProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserProfile operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteUserProfile">REST API Reference for DeleteUserProfile Operation</seealso>
        IAsyncResult BeginDeleteUserProfile(DeleteUserProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserProfile.</param>
        /// 
        /// <returns>Returns a  DeleteUserProfileResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteUserProfile">REST API Reference for DeleteUserProfile Operation</seealso>
        DeleteUserProfileResponse EndDeleteUserProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorkforce


        /// <summary>
        /// Use this operation to delete a workforce.
        /// 
        ///  
        /// <para>
        /// If you want to create a new workforce in an Amazon Web Services Region where a workforce
        /// already exists, use this operation to delete the existing workforce and then use to
        /// create a new workforce.
        /// </para>
        ///  <important> 
        /// <para>
        /// If a private workforce contains one or more work teams, you must use the operation
        /// to delete all work teams before you delete the workforce. If you try to delete a workforce
        /// that contains one or more work teams, you will recieve a <code>ResourceInUse</code>
        /// error.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkforce service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkforce service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteWorkforce">REST API Reference for DeleteWorkforce Operation</seealso>
        DeleteWorkforceResponse DeleteWorkforce(DeleteWorkforceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkforce operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkforce operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkforce
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteWorkforce">REST API Reference for DeleteWorkforce Operation</seealso>
        IAsyncResult BeginDeleteWorkforce(DeleteWorkforceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkforce operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkforce.</param>
        /// 
        /// <returns>Returns a  DeleteWorkforceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteWorkforce">REST API Reference for DeleteWorkforce Operation</seealso>
        DeleteWorkforceResponse EndDeleteWorkforce(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorkteam


        /// <summary>
        /// Deletes an existing work team. This operation can't be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkteam service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkteam service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteWorkteam">REST API Reference for DeleteWorkteam Operation</seealso>
        DeleteWorkteamResponse DeleteWorkteam(DeleteWorkteamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkteam operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkteam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteWorkteam">REST API Reference for DeleteWorkteam Operation</seealso>
        IAsyncResult BeginDeleteWorkteam(DeleteWorkteamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkteam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkteam.</param>
        /// 
        /// <returns>Returns a  DeleteWorkteamResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteWorkteam">REST API Reference for DeleteWorkteam Operation</seealso>
        DeleteWorkteamResponse EndDeleteWorkteam(IAsyncResult asyncResult);

        #endregion
        
        #region  DeregisterDevices


        /// <summary>
        /// Deregisters the specified devices. After you deregister a device, you will need to
        /// re-register the devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterDevices service method.</param>
        /// 
        /// <returns>The response from the DeregisterDevices service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeregisterDevices">REST API Reference for DeregisterDevices Operation</seealso>
        DeregisterDevicesResponse DeregisterDevices(DeregisterDevicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterDevices operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeregisterDevices">REST API Reference for DeregisterDevices Operation</seealso>
        IAsyncResult BeginDeregisterDevices(DeregisterDevicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterDevices.</param>
        /// 
        /// <returns>Returns a  DeregisterDevicesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeregisterDevices">REST API Reference for DeregisterDevices Operation</seealso>
        DeregisterDevicesResponse EndDeregisterDevices(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAction


        /// <summary>
        /// Describes an action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAction service method.</param>
        /// 
        /// <returns>The response from the DescribeAction service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAction">REST API Reference for DescribeAction Operation</seealso>
        DescribeActionResponse DescribeAction(DescribeActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAction operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAction">REST API Reference for DescribeAction Operation</seealso>
        IAsyncResult BeginDescribeAction(DescribeActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAction.</param>
        /// 
        /// <returns>Returns a  DescribeActionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAction">REST API Reference for DescribeAction Operation</seealso>
        DescribeActionResponse EndDescribeAction(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAlgorithm


        /// <summary>
        /// Returns a description of the specified algorithm that is in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlgorithm service method.</param>
        /// 
        /// <returns>The response from the DescribeAlgorithm service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAlgorithm">REST API Reference for DescribeAlgorithm Operation</seealso>
        DescribeAlgorithmResponse DescribeAlgorithm(DescribeAlgorithmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlgorithm operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlgorithm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAlgorithm">REST API Reference for DescribeAlgorithm Operation</seealso>
        IAsyncResult BeginDescribeAlgorithm(DescribeAlgorithmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlgorithm.</param>
        /// 
        /// <returns>Returns a  DescribeAlgorithmResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAlgorithm">REST API Reference for DescribeAlgorithm Operation</seealso>
        DescribeAlgorithmResponse EndDescribeAlgorithm(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeApp


        /// <summary>
        /// Describes the app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApp service method.</param>
        /// 
        /// <returns>The response from the DescribeApp service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        DescribeAppResponse DescribeApp(DescribeAppRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApp operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        IAsyncResult BeginDescribeApp(DescribeAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApp.</param>
        /// 
        /// <returns>Returns a  DescribeAppResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        DescribeAppResponse EndDescribeApp(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAppImageConfig


        /// <summary>
        /// Describes an AppImageConfig.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppImageConfig service method.</param>
        /// 
        /// <returns>The response from the DescribeAppImageConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAppImageConfig">REST API Reference for DescribeAppImageConfig Operation</seealso>
        DescribeAppImageConfigResponse DescribeAppImageConfig(DescribeAppImageConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAppImageConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppImageConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAppImageConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAppImageConfig">REST API Reference for DescribeAppImageConfig Operation</seealso>
        IAsyncResult BeginDescribeAppImageConfig(DescribeAppImageConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAppImageConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAppImageConfig.</param>
        /// 
        /// <returns>Returns a  DescribeAppImageConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAppImageConfig">REST API Reference for DescribeAppImageConfig Operation</seealso>
        DescribeAppImageConfigResponse EndDescribeAppImageConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeArtifact


        /// <summary>
        /// Describes an artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeArtifact service method.</param>
        /// 
        /// <returns>The response from the DescribeArtifact service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeArtifact">REST API Reference for DescribeArtifact Operation</seealso>
        DescribeArtifactResponse DescribeArtifact(DescribeArtifactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeArtifact operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeArtifact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeArtifact">REST API Reference for DescribeArtifact Operation</seealso>
        IAsyncResult BeginDescribeArtifact(DescribeArtifactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeArtifact.</param>
        /// 
        /// <returns>Returns a  DescribeArtifactResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeArtifact">REST API Reference for DescribeArtifact Operation</seealso>
        DescribeArtifactResponse EndDescribeArtifact(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAutoMLJob


        /// <summary>
        /// Returns information about an Amazon SageMaker AutoML job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoMLJob service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoMLJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAutoMLJob">REST API Reference for DescribeAutoMLJob Operation</seealso>
        DescribeAutoMLJobResponse DescribeAutoMLJob(DescribeAutoMLJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoMLJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoMLJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAutoMLJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAutoMLJob">REST API Reference for DescribeAutoMLJob Operation</seealso>
        IAsyncResult BeginDescribeAutoMLJob(DescribeAutoMLJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAutoMLJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutoMLJob.</param>
        /// 
        /// <returns>Returns a  DescribeAutoMLJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAutoMLJob">REST API Reference for DescribeAutoMLJob Operation</seealso>
        DescribeAutoMLJobResponse EndDescribeAutoMLJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCodeRepository


        /// <summary>
        /// Gets details about the specified Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeRepository service method.</param>
        /// 
        /// <returns>The response from the DescribeCodeRepository service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCodeRepository">REST API Reference for DescribeCodeRepository Operation</seealso>
        DescribeCodeRepositoryResponse DescribeCodeRepository(DescribeCodeRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeRepository operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCodeRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCodeRepository">REST API Reference for DescribeCodeRepository Operation</seealso>
        IAsyncResult BeginDescribeCodeRepository(DescribeCodeRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCodeRepository.</param>
        /// 
        /// <returns>Returns a  DescribeCodeRepositoryResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCodeRepository">REST API Reference for DescribeCodeRepository Operation</seealso>
        DescribeCodeRepositoryResponse EndDescribeCodeRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCompilationJob


        /// <summary>
        /// Returns information about a model compilation job.
        /// 
        ///  
        /// <para>
        /// To create a model compilation job, use <a>CreateCompilationJob</a>. To get information
        /// about multiple model compilation jobs, use <a>ListCompilationJobs</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCompilationJob service method.</param>
        /// 
        /// <returns>The response from the DescribeCompilationJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCompilationJob">REST API Reference for DescribeCompilationJob Operation</seealso>
        DescribeCompilationJobResponse DescribeCompilationJob(DescribeCompilationJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCompilationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCompilationJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCompilationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCompilationJob">REST API Reference for DescribeCompilationJob Operation</seealso>
        IAsyncResult BeginDescribeCompilationJob(DescribeCompilationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCompilationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCompilationJob.</param>
        /// 
        /// <returns>Returns a  DescribeCompilationJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCompilationJob">REST API Reference for DescribeCompilationJob Operation</seealso>
        DescribeCompilationJobResponse EndDescribeCompilationJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeContext


        /// <summary>
        /// Describes a context.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContext service method.</param>
        /// 
        /// <returns>The response from the DescribeContext service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeContext">REST API Reference for DescribeContext Operation</seealso>
        DescribeContextResponse DescribeContext(DescribeContextRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeContext operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeContext operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeContext
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeContext">REST API Reference for DescribeContext Operation</seealso>
        IAsyncResult BeginDescribeContext(DescribeContextRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeContext operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeContext.</param>
        /// 
        /// <returns>Returns a  DescribeContextResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeContext">REST API Reference for DescribeContext Operation</seealso>
        DescribeContextResponse EndDescribeContext(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDataQualityJobDefinition


        /// <summary>
        /// Gets the details of a data quality monitoring job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataQualityJobDefinition service method.</param>
        /// 
        /// <returns>The response from the DescribeDataQualityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDataQualityJobDefinition">REST API Reference for DescribeDataQualityJobDefinition Operation</seealso>
        DescribeDataQualityJobDefinitionResponse DescribeDataQualityJobDefinition(DescribeDataQualityJobDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataQualityJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataQualityJobDefinition operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataQualityJobDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDataQualityJobDefinition">REST API Reference for DescribeDataQualityJobDefinition Operation</seealso>
        IAsyncResult BeginDescribeDataQualityJobDefinition(DescribeDataQualityJobDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataQualityJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataQualityJobDefinition.</param>
        /// 
        /// <returns>Returns a  DescribeDataQualityJobDefinitionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDataQualityJobDefinition">REST API Reference for DescribeDataQualityJobDefinition Operation</seealso>
        DescribeDataQualityJobDefinitionResponse EndDescribeDataQualityJobDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDevice


        /// <summary>
        /// Describes the device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice service method.</param>
        /// 
        /// <returns>The response from the DescribeDevice service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        DescribeDeviceResponse DescribeDevice(DescribeDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        IAsyncResult BeginDescribeDevice(DescribeDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDevice.</param>
        /// 
        /// <returns>Returns a  DescribeDeviceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        DescribeDeviceResponse EndDescribeDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDeviceFleet


        /// <summary>
        /// A description of the fleet the device belongs to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeviceFleet service method.</param>
        /// 
        /// <returns>The response from the DescribeDeviceFleet service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDeviceFleet">REST API Reference for DescribeDeviceFleet Operation</seealso>
        DescribeDeviceFleetResponse DescribeDeviceFleet(DescribeDeviceFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeviceFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeviceFleet operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDeviceFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDeviceFleet">REST API Reference for DescribeDeviceFleet Operation</seealso>
        IAsyncResult BeginDescribeDeviceFleet(DescribeDeviceFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDeviceFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDeviceFleet.</param>
        /// 
        /// <returns>Returns a  DescribeDeviceFleetResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDeviceFleet">REST API Reference for DescribeDeviceFleet Operation</seealso>
        DescribeDeviceFleetResponse EndDescribeDeviceFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDomain


        /// <summary>
        /// The description of the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain service method.</param>
        /// 
        /// <returns>The response from the DescribeDomain service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        DescribeDomainResponse DescribeDomain(DescribeDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        IAsyncResult BeginDescribeDomain(DescribeDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomain.</param>
        /// 
        /// <returns>Returns a  DescribeDomainResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        DescribeDomainResponse EndDescribeDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEdgeDeploymentPlan


        /// <summary>
        /// Describes an edge deployment plan with deployment status per stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEdgeDeploymentPlan service method.</param>
        /// 
        /// <returns>The response from the DescribeEdgeDeploymentPlan service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEdgeDeploymentPlan">REST API Reference for DescribeEdgeDeploymentPlan Operation</seealso>
        DescribeEdgeDeploymentPlanResponse DescribeEdgeDeploymentPlan(DescribeEdgeDeploymentPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEdgeDeploymentPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEdgeDeploymentPlan operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEdgeDeploymentPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEdgeDeploymentPlan">REST API Reference for DescribeEdgeDeploymentPlan Operation</seealso>
        IAsyncResult BeginDescribeEdgeDeploymentPlan(DescribeEdgeDeploymentPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEdgeDeploymentPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEdgeDeploymentPlan.</param>
        /// 
        /// <returns>Returns a  DescribeEdgeDeploymentPlanResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEdgeDeploymentPlan">REST API Reference for DescribeEdgeDeploymentPlan Operation</seealso>
        DescribeEdgeDeploymentPlanResponse EndDescribeEdgeDeploymentPlan(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEdgePackagingJob


        /// <summary>
        /// A description of edge packaging jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEdgePackagingJob service method.</param>
        /// 
        /// <returns>The response from the DescribeEdgePackagingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEdgePackagingJob">REST API Reference for DescribeEdgePackagingJob Operation</seealso>
        DescribeEdgePackagingJobResponse DescribeEdgePackagingJob(DescribeEdgePackagingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEdgePackagingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEdgePackagingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEdgePackagingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEdgePackagingJob">REST API Reference for DescribeEdgePackagingJob Operation</seealso>
        IAsyncResult BeginDescribeEdgePackagingJob(DescribeEdgePackagingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEdgePackagingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEdgePackagingJob.</param>
        /// 
        /// <returns>Returns a  DescribeEdgePackagingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEdgePackagingJob">REST API Reference for DescribeEdgePackagingJob Operation</seealso>
        DescribeEdgePackagingJobResponse EndDescribeEdgePackagingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEndpoint


        /// <summary>
        /// Returns the description of an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpoint service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        DescribeEndpointResponse DescribeEndpoint(DescribeEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        IAsyncResult BeginDescribeEndpoint(DescribeEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEndpoint.</param>
        /// 
        /// <returns>Returns a  DescribeEndpointResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        DescribeEndpointResponse EndDescribeEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEndpointConfig


        /// <summary>
        /// Returns the description of an endpoint configuration created using the <code>CreateEndpointConfig</code>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointConfig service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpointConfig service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpointConfig">REST API Reference for DescribeEndpointConfig Operation</seealso>
        DescribeEndpointConfigResponse DescribeEndpointConfig(DescribeEndpointConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEndpointConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpointConfig">REST API Reference for DescribeEndpointConfig Operation</seealso>
        IAsyncResult BeginDescribeEndpointConfig(DescribeEndpointConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEndpointConfig.</param>
        /// 
        /// <returns>Returns a  DescribeEndpointConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpointConfig">REST API Reference for DescribeEndpointConfig Operation</seealso>
        DescribeEndpointConfigResponse EndDescribeEndpointConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeExperiment


        /// <summary>
        /// Provides a list of an experiment's properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExperiment service method.</param>
        /// 
        /// <returns>The response from the DescribeExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeExperiment">REST API Reference for DescribeExperiment Operation</seealso>
        DescribeExperimentResponse DescribeExperiment(DescribeExperimentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExperiment operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeExperiment">REST API Reference for DescribeExperiment Operation</seealso>
        IAsyncResult BeginDescribeExperiment(DescribeExperimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExperiment.</param>
        /// 
        /// <returns>Returns a  DescribeExperimentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeExperiment">REST API Reference for DescribeExperiment Operation</seealso>
        DescribeExperimentResponse EndDescribeExperiment(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFeatureGroup


        /// <summary>
        /// Use this operation to describe a <code>FeatureGroup</code>. The response includes
        /// information on the creation time, <code>FeatureGroup</code> name, the unique identifier
        /// for each <code>FeatureGroup</code>, and more.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFeatureGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeFeatureGroup service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeFeatureGroup">REST API Reference for DescribeFeatureGroup Operation</seealso>
        DescribeFeatureGroupResponse DescribeFeatureGroup(DescribeFeatureGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFeatureGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFeatureGroup operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFeatureGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeFeatureGroup">REST API Reference for DescribeFeatureGroup Operation</seealso>
        IAsyncResult BeginDescribeFeatureGroup(DescribeFeatureGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFeatureGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFeatureGroup.</param>
        /// 
        /// <returns>Returns a  DescribeFeatureGroupResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeFeatureGroup">REST API Reference for DescribeFeatureGroup Operation</seealso>
        DescribeFeatureGroupResponse EndDescribeFeatureGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFeatureMetadata


        /// <summary>
        /// Shows the metadata for a feature within a feature group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFeatureMetadata service method.</param>
        /// 
        /// <returns>The response from the DescribeFeatureMetadata service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeFeatureMetadata">REST API Reference for DescribeFeatureMetadata Operation</seealso>
        DescribeFeatureMetadataResponse DescribeFeatureMetadata(DescribeFeatureMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFeatureMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFeatureMetadata operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFeatureMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeFeatureMetadata">REST API Reference for DescribeFeatureMetadata Operation</seealso>
        IAsyncResult BeginDescribeFeatureMetadata(DescribeFeatureMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFeatureMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFeatureMetadata.</param>
        /// 
        /// <returns>Returns a  DescribeFeatureMetadataResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeFeatureMetadata">REST API Reference for DescribeFeatureMetadata Operation</seealso>
        DescribeFeatureMetadataResponse EndDescribeFeatureMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFlowDefinition


        /// <summary>
        /// Returns information about the specified flow definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowDefinition service method.</param>
        /// 
        /// <returns>The response from the DescribeFlowDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeFlowDefinition">REST API Reference for DescribeFlowDefinition Operation</seealso>
        DescribeFlowDefinitionResponse DescribeFlowDefinition(DescribeFlowDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFlowDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowDefinition operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFlowDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeFlowDefinition">REST API Reference for DescribeFlowDefinition Operation</seealso>
        IAsyncResult BeginDescribeFlowDefinition(DescribeFlowDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFlowDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFlowDefinition.</param>
        /// 
        /// <returns>Returns a  DescribeFlowDefinitionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeFlowDefinition">REST API Reference for DescribeFlowDefinition Operation</seealso>
        DescribeFlowDefinitionResponse EndDescribeFlowDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeHub


        /// <summary>
        /// Describe a hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHub service method.</param>
        /// 
        /// <returns>The response from the DescribeHub service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHub">REST API Reference for DescribeHub Operation</seealso>
        DescribeHubResponse DescribeHub(DescribeHubRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHub operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHub operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHub
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHub">REST API Reference for DescribeHub Operation</seealso>
        IAsyncResult BeginDescribeHub(DescribeHubRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHub operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHub.</param>
        /// 
        /// <returns>Returns a  DescribeHubResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHub">REST API Reference for DescribeHub Operation</seealso>
        DescribeHubResponse EndDescribeHub(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeHubContent


        /// <summary>
        /// Describe the content of a hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHubContent service method.</param>
        /// 
        /// <returns>The response from the DescribeHubContent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHubContent">REST API Reference for DescribeHubContent Operation</seealso>
        DescribeHubContentResponse DescribeHubContent(DescribeHubContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHubContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHubContent operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHubContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHubContent">REST API Reference for DescribeHubContent Operation</seealso>
        IAsyncResult BeginDescribeHubContent(DescribeHubContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHubContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHubContent.</param>
        /// 
        /// <returns>Returns a  DescribeHubContentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHubContent">REST API Reference for DescribeHubContent Operation</seealso>
        DescribeHubContentResponse EndDescribeHubContent(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeHumanTaskUi


        /// <summary>
        /// Returns information about the requested human task user interface (worker task template).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHumanTaskUi service method.</param>
        /// 
        /// <returns>The response from the DescribeHumanTaskUi service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHumanTaskUi">REST API Reference for DescribeHumanTaskUi Operation</seealso>
        DescribeHumanTaskUiResponse DescribeHumanTaskUi(DescribeHumanTaskUiRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHumanTaskUi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHumanTaskUi operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHumanTaskUi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHumanTaskUi">REST API Reference for DescribeHumanTaskUi Operation</seealso>
        IAsyncResult BeginDescribeHumanTaskUi(DescribeHumanTaskUiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHumanTaskUi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHumanTaskUi.</param>
        /// 
        /// <returns>Returns a  DescribeHumanTaskUiResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHumanTaskUi">REST API Reference for DescribeHumanTaskUi Operation</seealso>
        DescribeHumanTaskUiResponse EndDescribeHumanTaskUi(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeHyperParameterTuningJob


        /// <summary>
        /// Gets a description of a hyperparameter tuning job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHyperParameterTuningJob service method.</param>
        /// 
        /// <returns>The response from the DescribeHyperParameterTuningJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHyperParameterTuningJob">REST API Reference for DescribeHyperParameterTuningJob Operation</seealso>
        DescribeHyperParameterTuningJobResponse DescribeHyperParameterTuningJob(DescribeHyperParameterTuningJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHyperParameterTuningJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHyperParameterTuningJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHyperParameterTuningJob">REST API Reference for DescribeHyperParameterTuningJob Operation</seealso>
        IAsyncResult BeginDescribeHyperParameterTuningJob(DescribeHyperParameterTuningJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHyperParameterTuningJob.</param>
        /// 
        /// <returns>Returns a  DescribeHyperParameterTuningJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHyperParameterTuningJob">REST API Reference for DescribeHyperParameterTuningJob Operation</seealso>
        DescribeHyperParameterTuningJobResponse EndDescribeHyperParameterTuningJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeImage


        /// <summary>
        /// Describes a SageMaker image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImage service method.</param>
        /// 
        /// <returns>The response from the DescribeImage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeImage">REST API Reference for DescribeImage Operation</seealso>
        DescribeImageResponse DescribeImage(DescribeImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImage operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeImage">REST API Reference for DescribeImage Operation</seealso>
        IAsyncResult BeginDescribeImage(DescribeImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImage.</param>
        /// 
        /// <returns>Returns a  DescribeImageResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeImage">REST API Reference for DescribeImage Operation</seealso>
        DescribeImageResponse EndDescribeImage(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeImageVersion


        /// <summary>
        /// Describes a version of a SageMaker image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageVersion service method.</param>
        /// 
        /// <returns>The response from the DescribeImageVersion service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeImageVersion">REST API Reference for DescribeImageVersion Operation</seealso>
        DescribeImageVersionResponse DescribeImageVersion(DescribeImageVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImageVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageVersion operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImageVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeImageVersion">REST API Reference for DescribeImageVersion Operation</seealso>
        IAsyncResult BeginDescribeImageVersion(DescribeImageVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImageVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImageVersion.</param>
        /// 
        /// <returns>Returns a  DescribeImageVersionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeImageVersion">REST API Reference for DescribeImageVersion Operation</seealso>
        DescribeImageVersionResponse EndDescribeImageVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInferenceExperiment


        /// <summary>
        /// Returns details about an inference experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInferenceExperiment service method.</param>
        /// 
        /// <returns>The response from the DescribeInferenceExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeInferenceExperiment">REST API Reference for DescribeInferenceExperiment Operation</seealso>
        DescribeInferenceExperimentResponse DescribeInferenceExperiment(DescribeInferenceExperimentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInferenceExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInferenceExperiment operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInferenceExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeInferenceExperiment">REST API Reference for DescribeInferenceExperiment Operation</seealso>
        IAsyncResult BeginDescribeInferenceExperiment(DescribeInferenceExperimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInferenceExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInferenceExperiment.</param>
        /// 
        /// <returns>Returns a  DescribeInferenceExperimentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeInferenceExperiment">REST API Reference for DescribeInferenceExperiment Operation</seealso>
        DescribeInferenceExperimentResponse EndDescribeInferenceExperiment(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInferenceRecommendationsJob


        /// <summary>
        /// Provides the results of the Inference Recommender job. One or more recommendation
        /// jobs are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInferenceRecommendationsJob service method.</param>
        /// 
        /// <returns>The response from the DescribeInferenceRecommendationsJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeInferenceRecommendationsJob">REST API Reference for DescribeInferenceRecommendationsJob Operation</seealso>
        DescribeInferenceRecommendationsJobResponse DescribeInferenceRecommendationsJob(DescribeInferenceRecommendationsJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInferenceRecommendationsJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInferenceRecommendationsJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInferenceRecommendationsJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeInferenceRecommendationsJob">REST API Reference for DescribeInferenceRecommendationsJob Operation</seealso>
        IAsyncResult BeginDescribeInferenceRecommendationsJob(DescribeInferenceRecommendationsJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInferenceRecommendationsJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInferenceRecommendationsJob.</param>
        /// 
        /// <returns>Returns a  DescribeInferenceRecommendationsJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeInferenceRecommendationsJob">REST API Reference for DescribeInferenceRecommendationsJob Operation</seealso>
        DescribeInferenceRecommendationsJobResponse EndDescribeInferenceRecommendationsJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLabelingJob


        /// <summary>
        /// Gets information about a labeling job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLabelingJob service method.</param>
        /// 
        /// <returns>The response from the DescribeLabelingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeLabelingJob">REST API Reference for DescribeLabelingJob Operation</seealso>
        DescribeLabelingJobResponse DescribeLabelingJob(DescribeLabelingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLabelingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLabelingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLabelingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeLabelingJob">REST API Reference for DescribeLabelingJob Operation</seealso>
        IAsyncResult BeginDescribeLabelingJob(DescribeLabelingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLabelingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLabelingJob.</param>
        /// 
        /// <returns>Returns a  DescribeLabelingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeLabelingJob">REST API Reference for DescribeLabelingJob Operation</seealso>
        DescribeLabelingJobResponse EndDescribeLabelingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLineageGroup


        /// <summary>
        /// Provides a list of properties for the requested lineage group. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/xaccount-lineage-tracking.html">
        /// Cross-Account Lineage Tracking </a> in the <i>Amazon SageMaker Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLineageGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeLineageGroup service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeLineageGroup">REST API Reference for DescribeLineageGroup Operation</seealso>
        DescribeLineageGroupResponse DescribeLineageGroup(DescribeLineageGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLineageGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLineageGroup operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLineageGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeLineageGroup">REST API Reference for DescribeLineageGroup Operation</seealso>
        IAsyncResult BeginDescribeLineageGroup(DescribeLineageGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLineageGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLineageGroup.</param>
        /// 
        /// <returns>Returns a  DescribeLineageGroupResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeLineageGroup">REST API Reference for DescribeLineageGroup Operation</seealso>
        DescribeLineageGroupResponse EndDescribeLineageGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeModel


        /// <summary>
        /// Describes a model that you created using the <code>CreateModel</code> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModel service method.</param>
        /// 
        /// <returns>The response from the DescribeModel service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        DescribeModelResponse DescribeModel(DescribeModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeModel operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        IAsyncResult BeginDescribeModel(DescribeModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeModel.</param>
        /// 
        /// <returns>Returns a  DescribeModelResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        DescribeModelResponse EndDescribeModel(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeModelBiasJobDefinition


        /// <summary>
        /// Returns a description of a model bias job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelBiasJobDefinition service method.</param>
        /// 
        /// <returns>The response from the DescribeModelBiasJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelBiasJobDefinition">REST API Reference for DescribeModelBiasJobDefinition Operation</seealso>
        DescribeModelBiasJobDefinitionResponse DescribeModelBiasJobDefinition(DescribeModelBiasJobDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeModelBiasJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelBiasJobDefinition operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeModelBiasJobDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelBiasJobDefinition">REST API Reference for DescribeModelBiasJobDefinition Operation</seealso>
        IAsyncResult BeginDescribeModelBiasJobDefinition(DescribeModelBiasJobDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeModelBiasJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeModelBiasJobDefinition.</param>
        /// 
        /// <returns>Returns a  DescribeModelBiasJobDefinitionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelBiasJobDefinition">REST API Reference for DescribeModelBiasJobDefinition Operation</seealso>
        DescribeModelBiasJobDefinitionResponse EndDescribeModelBiasJobDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeModelCard


        /// <summary>
        /// Describes the content, creation time, and security configuration of an Amazon SageMaker
        /// Model Card.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelCard service method.</param>
        /// 
        /// <returns>The response from the DescribeModelCard service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelCard">REST API Reference for DescribeModelCard Operation</seealso>
        DescribeModelCardResponse DescribeModelCard(DescribeModelCardRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeModelCard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelCard operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeModelCard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelCard">REST API Reference for DescribeModelCard Operation</seealso>
        IAsyncResult BeginDescribeModelCard(DescribeModelCardRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeModelCard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeModelCard.</param>
        /// 
        /// <returns>Returns a  DescribeModelCardResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelCard">REST API Reference for DescribeModelCard Operation</seealso>
        DescribeModelCardResponse EndDescribeModelCard(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeModelCardExportJob


        /// <summary>
        /// Describes an Amazon SageMaker Model Card export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelCardExportJob service method.</param>
        /// 
        /// <returns>The response from the DescribeModelCardExportJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelCardExportJob">REST API Reference for DescribeModelCardExportJob Operation</seealso>
        DescribeModelCardExportJobResponse DescribeModelCardExportJob(DescribeModelCardExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeModelCardExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelCardExportJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeModelCardExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelCardExportJob">REST API Reference for DescribeModelCardExportJob Operation</seealso>
        IAsyncResult BeginDescribeModelCardExportJob(DescribeModelCardExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeModelCardExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeModelCardExportJob.</param>
        /// 
        /// <returns>Returns a  DescribeModelCardExportJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelCardExportJob">REST API Reference for DescribeModelCardExportJob Operation</seealso>
        DescribeModelCardExportJobResponse EndDescribeModelCardExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeModelExplainabilityJobDefinition


        /// <summary>
        /// Returns a description of a model explainability job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelExplainabilityJobDefinition service method.</param>
        /// 
        /// <returns>The response from the DescribeModelExplainabilityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelExplainabilityJobDefinition">REST API Reference for DescribeModelExplainabilityJobDefinition Operation</seealso>
        DescribeModelExplainabilityJobDefinitionResponse DescribeModelExplainabilityJobDefinition(DescribeModelExplainabilityJobDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeModelExplainabilityJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelExplainabilityJobDefinition operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeModelExplainabilityJobDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelExplainabilityJobDefinition">REST API Reference for DescribeModelExplainabilityJobDefinition Operation</seealso>
        IAsyncResult BeginDescribeModelExplainabilityJobDefinition(DescribeModelExplainabilityJobDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeModelExplainabilityJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeModelExplainabilityJobDefinition.</param>
        /// 
        /// <returns>Returns a  DescribeModelExplainabilityJobDefinitionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelExplainabilityJobDefinition">REST API Reference for DescribeModelExplainabilityJobDefinition Operation</seealso>
        DescribeModelExplainabilityJobDefinitionResponse EndDescribeModelExplainabilityJobDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeModelPackage


        /// <summary>
        /// Returns a description of the specified model package, which is used to create SageMaker
        /// models or list them on Amazon Web Services Marketplace.
        /// 
        ///  
        /// <para>
        /// To create models in SageMaker, buyers can subscribe to model packages listed on Amazon
        /// Web Services Marketplace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelPackage service method.</param>
        /// 
        /// <returns>The response from the DescribeModelPackage service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelPackage">REST API Reference for DescribeModelPackage Operation</seealso>
        DescribeModelPackageResponse DescribeModelPackage(DescribeModelPackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeModelPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelPackage operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeModelPackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelPackage">REST API Reference for DescribeModelPackage Operation</seealso>
        IAsyncResult BeginDescribeModelPackage(DescribeModelPackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeModelPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeModelPackage.</param>
        /// 
        /// <returns>Returns a  DescribeModelPackageResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelPackage">REST API Reference for DescribeModelPackage Operation</seealso>
        DescribeModelPackageResponse EndDescribeModelPackage(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeModelPackageGroup


        /// <summary>
        /// Gets a description for the specified model group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelPackageGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeModelPackageGroup service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelPackageGroup">REST API Reference for DescribeModelPackageGroup Operation</seealso>
        DescribeModelPackageGroupResponse DescribeModelPackageGroup(DescribeModelPackageGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeModelPackageGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelPackageGroup operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeModelPackageGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelPackageGroup">REST API Reference for DescribeModelPackageGroup Operation</seealso>
        IAsyncResult BeginDescribeModelPackageGroup(DescribeModelPackageGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeModelPackageGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeModelPackageGroup.</param>
        /// 
        /// <returns>Returns a  DescribeModelPackageGroupResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelPackageGroup">REST API Reference for DescribeModelPackageGroup Operation</seealso>
        DescribeModelPackageGroupResponse EndDescribeModelPackageGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeModelQualityJobDefinition


        /// <summary>
        /// Returns a description of a model quality job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelQualityJobDefinition service method.</param>
        /// 
        /// <returns>The response from the DescribeModelQualityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelQualityJobDefinition">REST API Reference for DescribeModelQualityJobDefinition Operation</seealso>
        DescribeModelQualityJobDefinitionResponse DescribeModelQualityJobDefinition(DescribeModelQualityJobDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeModelQualityJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelQualityJobDefinition operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeModelQualityJobDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelQualityJobDefinition">REST API Reference for DescribeModelQualityJobDefinition Operation</seealso>
        IAsyncResult BeginDescribeModelQualityJobDefinition(DescribeModelQualityJobDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeModelQualityJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeModelQualityJobDefinition.</param>
        /// 
        /// <returns>Returns a  DescribeModelQualityJobDefinitionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelQualityJobDefinition">REST API Reference for DescribeModelQualityJobDefinition Operation</seealso>
        DescribeModelQualityJobDefinitionResponse EndDescribeModelQualityJobDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeMonitoringSchedule


        /// <summary>
        /// Describes the schedule for a monitoring job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMonitoringSchedule service method.</param>
        /// 
        /// <returns>The response from the DescribeMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeMonitoringSchedule">REST API Reference for DescribeMonitoringSchedule Operation</seealso>
        DescribeMonitoringScheduleResponse DescribeMonitoringSchedule(DescribeMonitoringScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMonitoringSchedule operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMonitoringSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeMonitoringSchedule">REST API Reference for DescribeMonitoringSchedule Operation</seealso>
        IAsyncResult BeginDescribeMonitoringSchedule(DescribeMonitoringScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMonitoringSchedule.</param>
        /// 
        /// <returns>Returns a  DescribeMonitoringScheduleResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeMonitoringSchedule">REST API Reference for DescribeMonitoringSchedule Operation</seealso>
        DescribeMonitoringScheduleResponse EndDescribeMonitoringSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeNotebookInstance


        /// <summary>
        /// Returns information about a notebook instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookInstance service method.</param>
        /// 
        /// <returns>The response from the DescribeNotebookInstance service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstance">REST API Reference for DescribeNotebookInstance Operation</seealso>
        DescribeNotebookInstanceResponse DescribeNotebookInstance(DescribeNotebookInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookInstance operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNotebookInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstance">REST API Reference for DescribeNotebookInstance Operation</seealso>
        IAsyncResult BeginDescribeNotebookInstance(DescribeNotebookInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNotebookInstance.</param>
        /// 
        /// <returns>Returns a  DescribeNotebookInstanceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstance">REST API Reference for DescribeNotebookInstance Operation</seealso>
        DescribeNotebookInstanceResponse EndDescribeNotebookInstance(IAsyncResult asyncResult);

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
        /// 
        /// <returns>The response from the DescribeNotebookInstanceLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstanceLifecycleConfig">REST API Reference for DescribeNotebookInstanceLifecycleConfig Operation</seealso>
        DescribeNotebookInstanceLifecycleConfigResponse DescribeNotebookInstanceLifecycleConfig(DescribeNotebookInstanceLifecycleConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookInstanceLifecycleConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNotebookInstanceLifecycleConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstanceLifecycleConfig">REST API Reference for DescribeNotebookInstanceLifecycleConfig Operation</seealso>
        IAsyncResult BeginDescribeNotebookInstanceLifecycleConfig(DescribeNotebookInstanceLifecycleConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNotebookInstanceLifecycleConfig.</param>
        /// 
        /// <returns>Returns a  DescribeNotebookInstanceLifecycleConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstanceLifecycleConfig">REST API Reference for DescribeNotebookInstanceLifecycleConfig Operation</seealso>
        DescribeNotebookInstanceLifecycleConfigResponse EndDescribeNotebookInstanceLifecycleConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePipeline


        /// <summary>
        /// Describes the details of a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePipeline service method.</param>
        /// 
        /// <returns>The response from the DescribePipeline service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribePipeline">REST API Reference for DescribePipeline Operation</seealso>
        DescribePipelineResponse DescribePipeline(DescribePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePipeline operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribePipeline">REST API Reference for DescribePipeline Operation</seealso>
        IAsyncResult BeginDescribePipeline(DescribePipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePipeline.</param>
        /// 
        /// <returns>Returns a  DescribePipelineResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribePipeline">REST API Reference for DescribePipeline Operation</seealso>
        DescribePipelineResponse EndDescribePipeline(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePipelineDefinitionForExecution


        /// <summary>
        /// Describes the details of an execution's pipeline definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePipelineDefinitionForExecution service method.</param>
        /// 
        /// <returns>The response from the DescribePipelineDefinitionForExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribePipelineDefinitionForExecution">REST API Reference for DescribePipelineDefinitionForExecution Operation</seealso>
        DescribePipelineDefinitionForExecutionResponse DescribePipelineDefinitionForExecution(DescribePipelineDefinitionForExecutionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePipelineDefinitionForExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePipelineDefinitionForExecution operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePipelineDefinitionForExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribePipelineDefinitionForExecution">REST API Reference for DescribePipelineDefinitionForExecution Operation</seealso>
        IAsyncResult BeginDescribePipelineDefinitionForExecution(DescribePipelineDefinitionForExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePipelineDefinitionForExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePipelineDefinitionForExecution.</param>
        /// 
        /// <returns>Returns a  DescribePipelineDefinitionForExecutionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribePipelineDefinitionForExecution">REST API Reference for DescribePipelineDefinitionForExecution Operation</seealso>
        DescribePipelineDefinitionForExecutionResponse EndDescribePipelineDefinitionForExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePipelineExecution


        /// <summary>
        /// Describes the details of a pipeline execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePipelineExecution service method.</param>
        /// 
        /// <returns>The response from the DescribePipelineExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribePipelineExecution">REST API Reference for DescribePipelineExecution Operation</seealso>
        DescribePipelineExecutionResponse DescribePipelineExecution(DescribePipelineExecutionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePipelineExecution operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePipelineExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribePipelineExecution">REST API Reference for DescribePipelineExecution Operation</seealso>
        IAsyncResult BeginDescribePipelineExecution(DescribePipelineExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePipelineExecution.</param>
        /// 
        /// <returns>Returns a  DescribePipelineExecutionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribePipelineExecution">REST API Reference for DescribePipelineExecution Operation</seealso>
        DescribePipelineExecutionResponse EndDescribePipelineExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeProcessingJob


        /// <summary>
        /// Returns a description of a processing job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProcessingJob service method.</param>
        /// 
        /// <returns>The response from the DescribeProcessingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeProcessingJob">REST API Reference for DescribeProcessingJob Operation</seealso>
        DescribeProcessingJobResponse DescribeProcessingJob(DescribeProcessingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProcessingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProcessingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProcessingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeProcessingJob">REST API Reference for DescribeProcessingJob Operation</seealso>
        IAsyncResult BeginDescribeProcessingJob(DescribeProcessingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProcessingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProcessingJob.</param>
        /// 
        /// <returns>Returns a  DescribeProcessingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeProcessingJob">REST API Reference for DescribeProcessingJob Operation</seealso>
        DescribeProcessingJobResponse EndDescribeProcessingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeProject


        /// <summary>
        /// Describes the details of a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject service method.</param>
        /// 
        /// <returns>The response from the DescribeProject service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        DescribeProjectResponse DescribeProject(DescribeProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        IAsyncResult BeginDescribeProject(DescribeProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProject.</param>
        /// 
        /// <returns>Returns a  DescribeProjectResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        DescribeProjectResponse EndDescribeProject(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSpace


        /// <summary>
        /// Describes the space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpace service method.</param>
        /// 
        /// <returns>The response from the DescribeSpace service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeSpace">REST API Reference for DescribeSpace Operation</seealso>
        DescribeSpaceResponse DescribeSpace(DescribeSpaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpace operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSpace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeSpace">REST API Reference for DescribeSpace Operation</seealso>
        IAsyncResult BeginDescribeSpace(DescribeSpaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSpace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpace.</param>
        /// 
        /// <returns>Returns a  DescribeSpaceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeSpace">REST API Reference for DescribeSpace Operation</seealso>
        DescribeSpaceResponse EndDescribeSpace(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStudioLifecycleConfig


        /// <summary>
        /// Describes the Studio Lifecycle Configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStudioLifecycleConfig service method.</param>
        /// 
        /// <returns>The response from the DescribeStudioLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeStudioLifecycleConfig">REST API Reference for DescribeStudioLifecycleConfig Operation</seealso>
        DescribeStudioLifecycleConfigResponse DescribeStudioLifecycleConfig(DescribeStudioLifecycleConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStudioLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStudioLifecycleConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStudioLifecycleConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeStudioLifecycleConfig">REST API Reference for DescribeStudioLifecycleConfig Operation</seealso>
        IAsyncResult BeginDescribeStudioLifecycleConfig(DescribeStudioLifecycleConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStudioLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStudioLifecycleConfig.</param>
        /// 
        /// <returns>Returns a  DescribeStudioLifecycleConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeStudioLifecycleConfig">REST API Reference for DescribeStudioLifecycleConfig Operation</seealso>
        DescribeStudioLifecycleConfigResponse EndDescribeStudioLifecycleConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSubscribedWorkteam


        /// <summary>
        /// Gets information about a work team provided by a vendor. It returns details about
        /// the subscription with a vendor in the Amazon Web Services Marketplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscribedWorkteam service method.</param>
        /// 
        /// <returns>The response from the DescribeSubscribedWorkteam service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeSubscribedWorkteam">REST API Reference for DescribeSubscribedWorkteam Operation</seealso>
        DescribeSubscribedWorkteamResponse DescribeSubscribedWorkteam(DescribeSubscribedWorkteamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubscribedWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscribedWorkteam operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSubscribedWorkteam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeSubscribedWorkteam">REST API Reference for DescribeSubscribedWorkteam Operation</seealso>
        IAsyncResult BeginDescribeSubscribedWorkteam(DescribeSubscribedWorkteamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSubscribedWorkteam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSubscribedWorkteam.</param>
        /// 
        /// <returns>Returns a  DescribeSubscribedWorkteamResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeSubscribedWorkteam">REST API Reference for DescribeSubscribedWorkteam Operation</seealso>
        DescribeSubscribedWorkteamResponse EndDescribeSubscribedWorkteam(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTrainingJob


        /// <summary>
        /// Returns information about a training job. 
        /// 
        ///  
        /// <para>
        /// Some of the attributes below only appear if the training job successfully starts.
        /// If the training job fails, <code>TrainingJobStatus</code> is <code>Failed</code> and,
        /// depending on the <code>FailureReason</code>, attributes like <code>TrainingStartTime</code>,
        /// <code>TrainingTimeInSeconds</code>, <code>TrainingEndTime</code>, and <code>BillableTimeInSeconds</code>
        /// may not be present in the response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrainingJob service method.</param>
        /// 
        /// <returns>The response from the DescribeTrainingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrainingJob">REST API Reference for DescribeTrainingJob Operation</seealso>
        DescribeTrainingJobResponse DescribeTrainingJob(DescribeTrainingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrainingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTrainingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrainingJob">REST API Reference for DescribeTrainingJob Operation</seealso>
        IAsyncResult BeginDescribeTrainingJob(DescribeTrainingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrainingJob.</param>
        /// 
        /// <returns>Returns a  DescribeTrainingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrainingJob">REST API Reference for DescribeTrainingJob Operation</seealso>
        DescribeTrainingJobResponse EndDescribeTrainingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTransformJob


        /// <summary>
        /// Returns information about a transform job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransformJob service method.</param>
        /// 
        /// <returns>The response from the DescribeTransformJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTransformJob">REST API Reference for DescribeTransformJob Operation</seealso>
        DescribeTransformJobResponse DescribeTransformJob(DescribeTransformJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTransformJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransformJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTransformJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTransformJob">REST API Reference for DescribeTransformJob Operation</seealso>
        IAsyncResult BeginDescribeTransformJob(DescribeTransformJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTransformJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTransformJob.</param>
        /// 
        /// <returns>Returns a  DescribeTransformJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTransformJob">REST API Reference for DescribeTransformJob Operation</seealso>
        DescribeTransformJobResponse EndDescribeTransformJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTrial


        /// <summary>
        /// Provides a list of a trial's properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrial service method.</param>
        /// 
        /// <returns>The response from the DescribeTrial service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrial">REST API Reference for DescribeTrial Operation</seealso>
        DescribeTrialResponse DescribeTrial(DescribeTrialRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrial operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrial operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTrial
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrial">REST API Reference for DescribeTrial Operation</seealso>
        IAsyncResult BeginDescribeTrial(DescribeTrialRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTrial operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrial.</param>
        /// 
        /// <returns>Returns a  DescribeTrialResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrial">REST API Reference for DescribeTrial Operation</seealso>
        DescribeTrialResponse EndDescribeTrial(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTrialComponent


        /// <summary>
        /// Provides a list of a trials component's properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrialComponent service method.</param>
        /// 
        /// <returns>The response from the DescribeTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrialComponent">REST API Reference for DescribeTrialComponent Operation</seealso>
        DescribeTrialComponentResponse DescribeTrialComponent(DescribeTrialComponentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrialComponent operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTrialComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrialComponent">REST API Reference for DescribeTrialComponent Operation</seealso>
        IAsyncResult BeginDescribeTrialComponent(DescribeTrialComponentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrialComponent.</param>
        /// 
        /// <returns>Returns a  DescribeTrialComponentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrialComponent">REST API Reference for DescribeTrialComponent Operation</seealso>
        DescribeTrialComponentResponse EndDescribeTrialComponent(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeUserProfile


        /// <summary>
        /// Describes a user profile. For more information, see <code>CreateUserProfile</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserProfile service method.</param>
        /// 
        /// <returns>The response from the DescribeUserProfile service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeUserProfile">REST API Reference for DescribeUserProfile Operation</seealso>
        DescribeUserProfileResponse DescribeUserProfile(DescribeUserProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserProfile operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUserProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeUserProfile">REST API Reference for DescribeUserProfile Operation</seealso>
        IAsyncResult BeginDescribeUserProfile(DescribeUserProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserProfile.</param>
        /// 
        /// <returns>Returns a  DescribeUserProfileResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeUserProfile">REST API Reference for DescribeUserProfile Operation</seealso>
        DescribeUserProfileResponse EndDescribeUserProfile(IAsyncResult asyncResult);

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
        /// 
        /// <returns>The response from the DescribeWorkforce service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeWorkforce">REST API Reference for DescribeWorkforce Operation</seealso>
        DescribeWorkforceResponse DescribeWorkforce(DescribeWorkforceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkforce operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkforce operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkforce
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeWorkforce">REST API Reference for DescribeWorkforce Operation</seealso>
        IAsyncResult BeginDescribeWorkforce(DescribeWorkforceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkforce operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkforce.</param>
        /// 
        /// <returns>Returns a  DescribeWorkforceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeWorkforce">REST API Reference for DescribeWorkforce Operation</seealso>
        DescribeWorkforceResponse EndDescribeWorkforce(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeWorkteam


        /// <summary>
        /// Gets information about a specific work team. You can see information such as the create
        /// date, the last updated date, membership information, and the work team's Amazon Resource
        /// Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkteam service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkteam service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeWorkteam">REST API Reference for DescribeWorkteam Operation</seealso>
        DescribeWorkteamResponse DescribeWorkteam(DescribeWorkteamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkteam operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkteam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeWorkteam">REST API Reference for DescribeWorkteam Operation</seealso>
        IAsyncResult BeginDescribeWorkteam(DescribeWorkteamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkteam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkteam.</param>
        /// 
        /// <returns>Returns a  DescribeWorkteamResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeWorkteam">REST API Reference for DescribeWorkteam Operation</seealso>
        DescribeWorkteamResponse EndDescribeWorkteam(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableSagemakerServicecatalogPortfolio


        /// <summary>
        /// Disables using Service Catalog in SageMaker. Service Catalog is used to create SageMaker
        /// projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableSagemakerServicecatalogPortfolio service method.</param>
        /// 
        /// <returns>The response from the DisableSagemakerServicecatalogPortfolio service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DisableSagemakerServicecatalogPortfolio">REST API Reference for DisableSagemakerServicecatalogPortfolio Operation</seealso>
        DisableSagemakerServicecatalogPortfolioResponse DisableSagemakerServicecatalogPortfolio(DisableSagemakerServicecatalogPortfolioRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableSagemakerServicecatalogPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableSagemakerServicecatalogPortfolio operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableSagemakerServicecatalogPortfolio
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DisableSagemakerServicecatalogPortfolio">REST API Reference for DisableSagemakerServicecatalogPortfolio Operation</seealso>
        IAsyncResult BeginDisableSagemakerServicecatalogPortfolio(DisableSagemakerServicecatalogPortfolioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableSagemakerServicecatalogPortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableSagemakerServicecatalogPortfolio.</param>
        /// 
        /// <returns>Returns a  DisableSagemakerServicecatalogPortfolioResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DisableSagemakerServicecatalogPortfolio">REST API Reference for DisableSagemakerServicecatalogPortfolio Operation</seealso>
        DisableSagemakerServicecatalogPortfolioResponse EndDisableSagemakerServicecatalogPortfolio(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateTrialComponent


        /// <summary>
        /// Disassociates a trial component from a trial. This doesn't effect other trials the
        /// component is associated with. Before you can delete a component, you must disassociate
        /// the component from all trials it is associated with. To associate a trial component
        /// with a trial, call the <a>AssociateTrialComponent</a> API.
        /// 
        ///  
        /// <para>
        /// To get a list of the trials a component is associated with, use the <a>Search</a>
        /// API. Specify <code>ExperimentTrialComponent</code> for the <code>Resource</code> parameter.
        /// The list appears in the response under <code>Results.TrialComponent.Parents</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTrialComponent service method.</param>
        /// 
        /// <returns>The response from the DisassociateTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DisassociateTrialComponent">REST API Reference for DisassociateTrialComponent Operation</seealso>
        DisassociateTrialComponentResponse DisassociateTrialComponent(DisassociateTrialComponentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTrialComponent operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateTrialComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DisassociateTrialComponent">REST API Reference for DisassociateTrialComponent Operation</seealso>
        IAsyncResult BeginDisassociateTrialComponent(DisassociateTrialComponentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateTrialComponent.</param>
        /// 
        /// <returns>Returns a  DisassociateTrialComponentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DisassociateTrialComponent">REST API Reference for DisassociateTrialComponent Operation</seealso>
        DisassociateTrialComponentResponse EndDisassociateTrialComponent(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableSagemakerServicecatalogPortfolio


        /// <summary>
        /// Enables using Service Catalog in SageMaker. Service Catalog is used to create SageMaker
        /// projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableSagemakerServicecatalogPortfolio service method.</param>
        /// 
        /// <returns>The response from the EnableSagemakerServicecatalogPortfolio service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/EnableSagemakerServicecatalogPortfolio">REST API Reference for EnableSagemakerServicecatalogPortfolio Operation</seealso>
        EnableSagemakerServicecatalogPortfolioResponse EnableSagemakerServicecatalogPortfolio(EnableSagemakerServicecatalogPortfolioRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableSagemakerServicecatalogPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableSagemakerServicecatalogPortfolio operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableSagemakerServicecatalogPortfolio
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/EnableSagemakerServicecatalogPortfolio">REST API Reference for EnableSagemakerServicecatalogPortfolio Operation</seealso>
        IAsyncResult BeginEnableSagemakerServicecatalogPortfolio(EnableSagemakerServicecatalogPortfolioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableSagemakerServicecatalogPortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableSagemakerServicecatalogPortfolio.</param>
        /// 
        /// <returns>Returns a  EnableSagemakerServicecatalogPortfolioResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/EnableSagemakerServicecatalogPortfolio">REST API Reference for EnableSagemakerServicecatalogPortfolio Operation</seealso>
        EnableSagemakerServicecatalogPortfolioResponse EndEnableSagemakerServicecatalogPortfolio(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDeviceFleetReport


        /// <summary>
        /// Describes a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceFleetReport service method.</param>
        /// 
        /// <returns>The response from the GetDeviceFleetReport service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetDeviceFleetReport">REST API Reference for GetDeviceFleetReport Operation</seealso>
        GetDeviceFleetReportResponse GetDeviceFleetReport(GetDeviceFleetReportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeviceFleetReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceFleetReport operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeviceFleetReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetDeviceFleetReport">REST API Reference for GetDeviceFleetReport Operation</seealso>
        IAsyncResult BeginGetDeviceFleetReport(GetDeviceFleetReportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeviceFleetReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeviceFleetReport.</param>
        /// 
        /// <returns>Returns a  GetDeviceFleetReportResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetDeviceFleetReport">REST API Reference for GetDeviceFleetReport Operation</seealso>
        GetDeviceFleetReportResponse EndGetDeviceFleetReport(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLineageGroupPolicy


        /// <summary>
        /// The resource policy for the lineage group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLineageGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the GetLineageGroupPolicy service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetLineageGroupPolicy">REST API Reference for GetLineageGroupPolicy Operation</seealso>
        GetLineageGroupPolicyResponse GetLineageGroupPolicy(GetLineageGroupPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLineageGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLineageGroupPolicy operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLineageGroupPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetLineageGroupPolicy">REST API Reference for GetLineageGroupPolicy Operation</seealso>
        IAsyncResult BeginGetLineageGroupPolicy(GetLineageGroupPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLineageGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLineageGroupPolicy.</param>
        /// 
        /// <returns>Returns a  GetLineageGroupPolicyResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetLineageGroupPolicy">REST API Reference for GetLineageGroupPolicy Operation</seealso>
        GetLineageGroupPolicyResponse EndGetLineageGroupPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetModelPackageGroupPolicy


        /// <summary>
        /// Gets a resource policy that manages access for a model group. For information about
        /// resource policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_identity-vs-resource.html">Identity-based
        /// policies and resource-based policies</a> in the <i>Amazon Web Services Identity and
        /// Access Management User Guide.</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelPackageGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the GetModelPackageGroupPolicy service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetModelPackageGroupPolicy">REST API Reference for GetModelPackageGroupPolicy Operation</seealso>
        GetModelPackageGroupPolicyResponse GetModelPackageGroupPolicy(GetModelPackageGroupPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetModelPackageGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModelPackageGroupPolicy operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModelPackageGroupPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetModelPackageGroupPolicy">REST API Reference for GetModelPackageGroupPolicy Operation</seealso>
        IAsyncResult BeginGetModelPackageGroupPolicy(GetModelPackageGroupPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetModelPackageGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModelPackageGroupPolicy.</param>
        /// 
        /// <returns>Returns a  GetModelPackageGroupPolicyResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetModelPackageGroupPolicy">REST API Reference for GetModelPackageGroupPolicy Operation</seealso>
        GetModelPackageGroupPolicyResponse EndGetModelPackageGroupPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSagemakerServicecatalogPortfolioStatus


        /// <summary>
        /// Gets the status of Service Catalog in SageMaker. Service Catalog is used to create
        /// SageMaker projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSagemakerServicecatalogPortfolioStatus service method.</param>
        /// 
        /// <returns>The response from the GetSagemakerServicecatalogPortfolioStatus service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetSagemakerServicecatalogPortfolioStatus">REST API Reference for GetSagemakerServicecatalogPortfolioStatus Operation</seealso>
        GetSagemakerServicecatalogPortfolioStatusResponse GetSagemakerServicecatalogPortfolioStatus(GetSagemakerServicecatalogPortfolioStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSagemakerServicecatalogPortfolioStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSagemakerServicecatalogPortfolioStatus operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSagemakerServicecatalogPortfolioStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetSagemakerServicecatalogPortfolioStatus">REST API Reference for GetSagemakerServicecatalogPortfolioStatus Operation</seealso>
        IAsyncResult BeginGetSagemakerServicecatalogPortfolioStatus(GetSagemakerServicecatalogPortfolioStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSagemakerServicecatalogPortfolioStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSagemakerServicecatalogPortfolioStatus.</param>
        /// 
        /// <returns>Returns a  GetSagemakerServicecatalogPortfolioStatusResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetSagemakerServicecatalogPortfolioStatus">REST API Reference for GetSagemakerServicecatalogPortfolioStatus Operation</seealso>
        GetSagemakerServicecatalogPortfolioStatusResponse EndGetSagemakerServicecatalogPortfolioStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSearchSuggestions


        /// <summary>
        /// An auto-complete API for the search functionality in the Amazon SageMaker console.
        /// It returns suggestions of possible matches for the property name to use in <code>Search</code>
        /// queries. Provides suggestions for <code>HyperParameters</code>, <code>Tags</code>,
        /// and <code>Metrics</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSearchSuggestions service method.</param>
        /// 
        /// <returns>The response from the GetSearchSuggestions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetSearchSuggestions">REST API Reference for GetSearchSuggestions Operation</seealso>
        GetSearchSuggestionsResponse GetSearchSuggestions(GetSearchSuggestionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSearchSuggestions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSearchSuggestions operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSearchSuggestions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetSearchSuggestions">REST API Reference for GetSearchSuggestions Operation</seealso>
        IAsyncResult BeginGetSearchSuggestions(GetSearchSuggestionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSearchSuggestions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSearchSuggestions.</param>
        /// 
        /// <returns>Returns a  GetSearchSuggestionsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetSearchSuggestions">REST API Reference for GetSearchSuggestions Operation</seealso>
        GetSearchSuggestionsResponse EndGetSearchSuggestions(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportHubContent


        /// <summary>
        /// Import hub content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportHubContent service method.</param>
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
        ImportHubContentResponse ImportHubContent(ImportHubContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportHubContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportHubContent operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportHubContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ImportHubContent">REST API Reference for ImportHubContent Operation</seealso>
        IAsyncResult BeginImportHubContent(ImportHubContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportHubContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportHubContent.</param>
        /// 
        /// <returns>Returns a  ImportHubContentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ImportHubContent">REST API Reference for ImportHubContent Operation</seealso>
        ImportHubContentResponse EndImportHubContent(IAsyncResult asyncResult);

        #endregion
        
        #region  ListActions


        /// <summary>
        /// Lists the actions in your account and their properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActions service method.</param>
        /// 
        /// <returns>The response from the ListActions service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListActions">REST API Reference for ListActions Operation</seealso>
        ListActionsResponse ListActions(ListActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActions operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListActions">REST API Reference for ListActions Operation</seealso>
        IAsyncResult BeginListActions(ListActionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListActions.</param>
        /// 
        /// <returns>Returns a  ListActionsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListActions">REST API Reference for ListActions Operation</seealso>
        ListActionsResponse EndListActions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAlgorithms


        /// <summary>
        /// Lists the machine learning algorithms that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlgorithms service method.</param>
        /// 
        /// <returns>The response from the ListAlgorithms service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAlgorithms">REST API Reference for ListAlgorithms Operation</seealso>
        ListAlgorithmsResponse ListAlgorithms(ListAlgorithmsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAlgorithms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAlgorithms operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAlgorithms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAlgorithms">REST API Reference for ListAlgorithms Operation</seealso>
        IAsyncResult BeginListAlgorithms(ListAlgorithmsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAlgorithms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAlgorithms.</param>
        /// 
        /// <returns>Returns a  ListAlgorithmsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAlgorithms">REST API Reference for ListAlgorithms Operation</seealso>
        ListAlgorithmsResponse EndListAlgorithms(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAliases


        /// <summary>
        /// Lists the aliases of a specified image or image version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAliases">REST API Reference for ListAliases Operation</seealso>
        ListAliasesResponse ListAliases(ListAliasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAliases">REST API Reference for ListAliases Operation</seealso>
        IAsyncResult BeginListAliases(ListAliasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAliases.</param>
        /// 
        /// <returns>Returns a  ListAliasesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAliases">REST API Reference for ListAliases Operation</seealso>
        ListAliasesResponse EndListAliases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAppImageConfigs


        /// <summary>
        /// Lists the AppImageConfigs in your account and their properties. The list can be filtered
        /// by creation time or modified time, and whether the AppImageConfig name contains a
        /// specified string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppImageConfigs service method.</param>
        /// 
        /// <returns>The response from the ListAppImageConfigs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAppImageConfigs">REST API Reference for ListAppImageConfigs Operation</seealso>
        ListAppImageConfigsResponse ListAppImageConfigs(ListAppImageConfigsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppImageConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppImageConfigs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppImageConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAppImageConfigs">REST API Reference for ListAppImageConfigs Operation</seealso>
        IAsyncResult BeginListAppImageConfigs(ListAppImageConfigsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppImageConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppImageConfigs.</param>
        /// 
        /// <returns>Returns a  ListAppImageConfigsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAppImageConfigs">REST API Reference for ListAppImageConfigs Operation</seealso>
        ListAppImageConfigsResponse EndListAppImageConfigs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApps


        /// <summary>
        /// Lists apps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApps service method.</param>
        /// 
        /// <returns>The response from the ListApps service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListApps">REST API Reference for ListApps Operation</seealso>
        ListAppsResponse ListApps(ListAppsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApps operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListApps">REST API Reference for ListApps Operation</seealso>
        IAsyncResult BeginListApps(ListAppsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApps.</param>
        /// 
        /// <returns>Returns a  ListAppsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListApps">REST API Reference for ListApps Operation</seealso>
        ListAppsResponse EndListApps(IAsyncResult asyncResult);

        #endregion
        
        #region  ListArtifacts


        /// <summary>
        /// Lists the artifacts in your account and their properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArtifacts service method.</param>
        /// 
        /// <returns>The response from the ListArtifacts service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListArtifacts">REST API Reference for ListArtifacts Operation</seealso>
        ListArtifactsResponse ListArtifacts(ListArtifactsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListArtifacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListArtifacts operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListArtifacts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListArtifacts">REST API Reference for ListArtifacts Operation</seealso>
        IAsyncResult BeginListArtifacts(ListArtifactsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListArtifacts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListArtifacts.</param>
        /// 
        /// <returns>Returns a  ListArtifactsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListArtifacts">REST API Reference for ListArtifacts Operation</seealso>
        ListArtifactsResponse EndListArtifacts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAssociations


        /// <summary>
        /// Lists the associations in your account and their properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations service method.</param>
        /// 
        /// <returns>The response from the ListAssociations service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        ListAssociationsResponse ListAssociations(ListAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        IAsyncResult BeginListAssociations(ListAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssociations.</param>
        /// 
        /// <returns>Returns a  ListAssociationsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        ListAssociationsResponse EndListAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAutoMLJobs


        /// <summary>
        /// Request a list of jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutoMLJobs service method.</param>
        /// 
        /// <returns>The response from the ListAutoMLJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAutoMLJobs">REST API Reference for ListAutoMLJobs Operation</seealso>
        ListAutoMLJobsResponse ListAutoMLJobs(ListAutoMLJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAutoMLJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAutoMLJobs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAutoMLJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAutoMLJobs">REST API Reference for ListAutoMLJobs Operation</seealso>
        IAsyncResult BeginListAutoMLJobs(ListAutoMLJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAutoMLJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAutoMLJobs.</param>
        /// 
        /// <returns>Returns a  ListAutoMLJobsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAutoMLJobs">REST API Reference for ListAutoMLJobs Operation</seealso>
        ListAutoMLJobsResponse EndListAutoMLJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCandidatesForAutoMLJob


        /// <summary>
        /// List the candidates created for the job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCandidatesForAutoMLJob service method.</param>
        /// 
        /// <returns>The response from the ListCandidatesForAutoMLJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCandidatesForAutoMLJob">REST API Reference for ListCandidatesForAutoMLJob Operation</seealso>
        ListCandidatesForAutoMLJobResponse ListCandidatesForAutoMLJob(ListCandidatesForAutoMLJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCandidatesForAutoMLJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCandidatesForAutoMLJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCandidatesForAutoMLJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCandidatesForAutoMLJob">REST API Reference for ListCandidatesForAutoMLJob Operation</seealso>
        IAsyncResult BeginListCandidatesForAutoMLJob(ListCandidatesForAutoMLJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCandidatesForAutoMLJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCandidatesForAutoMLJob.</param>
        /// 
        /// <returns>Returns a  ListCandidatesForAutoMLJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCandidatesForAutoMLJob">REST API Reference for ListCandidatesForAutoMLJob Operation</seealso>
        ListCandidatesForAutoMLJobResponse EndListCandidatesForAutoMLJob(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCodeRepositories


        /// <summary>
        /// Gets a list of the Git repositories in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeRepositories service method.</param>
        /// 
        /// <returns>The response from the ListCodeRepositories service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCodeRepositories">REST API Reference for ListCodeRepositories Operation</seealso>
        ListCodeRepositoriesResponse ListCodeRepositories(ListCodeRepositoriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCodeRepositories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCodeRepositories operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCodeRepositories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCodeRepositories">REST API Reference for ListCodeRepositories Operation</seealso>
        IAsyncResult BeginListCodeRepositories(ListCodeRepositoriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCodeRepositories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCodeRepositories.</param>
        /// 
        /// <returns>Returns a  ListCodeRepositoriesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCodeRepositories">REST API Reference for ListCodeRepositories Operation</seealso>
        ListCodeRepositoriesResponse EndListCodeRepositories(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCompilationJobs


        /// <summary>
        /// Lists model compilation jobs that satisfy various filters.
        /// 
        ///  
        /// <para>
        /// To create a model compilation job, use <a>CreateCompilationJob</a>. To get information
        /// about a particular model compilation job you have created, use <a>DescribeCompilationJob</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCompilationJobs service method.</param>
        /// 
        /// <returns>The response from the ListCompilationJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCompilationJobs">REST API Reference for ListCompilationJobs Operation</seealso>
        ListCompilationJobsResponse ListCompilationJobs(ListCompilationJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCompilationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCompilationJobs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCompilationJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCompilationJobs">REST API Reference for ListCompilationJobs Operation</seealso>
        IAsyncResult BeginListCompilationJobs(ListCompilationJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCompilationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCompilationJobs.</param>
        /// 
        /// <returns>Returns a  ListCompilationJobsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCompilationJobs">REST API Reference for ListCompilationJobs Operation</seealso>
        ListCompilationJobsResponse EndListCompilationJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListContexts


        /// <summary>
        /// Lists the contexts in your account and their properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContexts service method.</param>
        /// 
        /// <returns>The response from the ListContexts service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListContexts">REST API Reference for ListContexts Operation</seealso>
        ListContextsResponse ListContexts(ListContextsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListContexts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContexts operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListContexts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListContexts">REST API Reference for ListContexts Operation</seealso>
        IAsyncResult BeginListContexts(ListContextsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListContexts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListContexts.</param>
        /// 
        /// <returns>Returns a  ListContextsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListContexts">REST API Reference for ListContexts Operation</seealso>
        ListContextsResponse EndListContexts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataQualityJobDefinitions


        /// <summary>
        /// Lists the data quality job definitions in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataQualityJobDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListDataQualityJobDefinitions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDataQualityJobDefinitions">REST API Reference for ListDataQualityJobDefinitions Operation</seealso>
        ListDataQualityJobDefinitionsResponse ListDataQualityJobDefinitions(ListDataQualityJobDefinitionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataQualityJobDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataQualityJobDefinitions operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataQualityJobDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDataQualityJobDefinitions">REST API Reference for ListDataQualityJobDefinitions Operation</seealso>
        IAsyncResult BeginListDataQualityJobDefinitions(ListDataQualityJobDefinitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataQualityJobDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataQualityJobDefinitions.</param>
        /// 
        /// <returns>Returns a  ListDataQualityJobDefinitionsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDataQualityJobDefinitions">REST API Reference for ListDataQualityJobDefinitions Operation</seealso>
        ListDataQualityJobDefinitionsResponse EndListDataQualityJobDefinitions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDeviceFleets


        /// <summary>
        /// Returns a list of devices in the fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceFleets service method.</param>
        /// 
        /// <returns>The response from the ListDeviceFleets service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDeviceFleets">REST API Reference for ListDeviceFleets Operation</seealso>
        ListDeviceFleetsResponse ListDeviceFleets(ListDeviceFleetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeviceFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceFleets operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeviceFleets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDeviceFleets">REST API Reference for ListDeviceFleets Operation</seealso>
        IAsyncResult BeginListDeviceFleets(ListDeviceFleetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeviceFleets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeviceFleets.</param>
        /// 
        /// <returns>Returns a  ListDeviceFleetsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDeviceFleets">REST API Reference for ListDeviceFleets Operation</seealso>
        ListDeviceFleetsResponse EndListDeviceFleets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDevices


        /// <summary>
        /// A list of devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
        /// 
        /// <returns>The response from the ListDevices service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDevices">REST API Reference for ListDevices Operation</seealso>
        ListDevicesResponse ListDevices(ListDevicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevices operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDevices">REST API Reference for ListDevices Operation</seealso>
        IAsyncResult BeginListDevices(ListDevicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevices.</param>
        /// 
        /// <returns>Returns a  ListDevicesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDevices">REST API Reference for ListDevices Operation</seealso>
        ListDevicesResponse EndListDevices(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDomains


        /// <summary>
        /// Lists the domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDomains">REST API Reference for ListDomains Operation</seealso>
        ListDomainsResponse ListDomains(ListDomainsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDomains">REST API Reference for ListDomains Operation</seealso>
        IAsyncResult BeginListDomains(ListDomainsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomains.</param>
        /// 
        /// <returns>Returns a  ListDomainsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDomains">REST API Reference for ListDomains Operation</seealso>
        ListDomainsResponse EndListDomains(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEdgeDeploymentPlans


        /// <summary>
        /// Lists all edge deployment plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEdgeDeploymentPlans service method.</param>
        /// 
        /// <returns>The response from the ListEdgeDeploymentPlans service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEdgeDeploymentPlans">REST API Reference for ListEdgeDeploymentPlans Operation</seealso>
        ListEdgeDeploymentPlansResponse ListEdgeDeploymentPlans(ListEdgeDeploymentPlansRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEdgeDeploymentPlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEdgeDeploymentPlans operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEdgeDeploymentPlans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEdgeDeploymentPlans">REST API Reference for ListEdgeDeploymentPlans Operation</seealso>
        IAsyncResult BeginListEdgeDeploymentPlans(ListEdgeDeploymentPlansRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEdgeDeploymentPlans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEdgeDeploymentPlans.</param>
        /// 
        /// <returns>Returns a  ListEdgeDeploymentPlansResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEdgeDeploymentPlans">REST API Reference for ListEdgeDeploymentPlans Operation</seealso>
        ListEdgeDeploymentPlansResponse EndListEdgeDeploymentPlans(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEdgePackagingJobs


        /// <summary>
        /// Returns a list of edge packaging jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEdgePackagingJobs service method.</param>
        /// 
        /// <returns>The response from the ListEdgePackagingJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEdgePackagingJobs">REST API Reference for ListEdgePackagingJobs Operation</seealso>
        ListEdgePackagingJobsResponse ListEdgePackagingJobs(ListEdgePackagingJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEdgePackagingJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEdgePackagingJobs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEdgePackagingJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEdgePackagingJobs">REST API Reference for ListEdgePackagingJobs Operation</seealso>
        IAsyncResult BeginListEdgePackagingJobs(ListEdgePackagingJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEdgePackagingJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEdgePackagingJobs.</param>
        /// 
        /// <returns>Returns a  ListEdgePackagingJobsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEdgePackagingJobs">REST API Reference for ListEdgePackagingJobs Operation</seealso>
        ListEdgePackagingJobsResponse EndListEdgePackagingJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEndpointConfigs


        /// <summary>
        /// Lists endpoint configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointConfigs service method.</param>
        /// 
        /// <returns>The response from the ListEndpointConfigs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpointConfigs">REST API Reference for ListEndpointConfigs Operation</seealso>
        ListEndpointConfigsResponse ListEndpointConfigs(ListEndpointConfigsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEndpointConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointConfigs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEndpointConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpointConfigs">REST API Reference for ListEndpointConfigs Operation</seealso>
        IAsyncResult BeginListEndpointConfigs(ListEndpointConfigsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEndpointConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEndpointConfigs.</param>
        /// 
        /// <returns>Returns a  ListEndpointConfigsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpointConfigs">REST API Reference for ListEndpointConfigs Operation</seealso>
        ListEndpointConfigsResponse EndListEndpointConfigs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEndpoints


        /// <summary>
        /// Lists endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListEndpoints service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        ListEndpointsResponse ListEndpoints(ListEndpointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEndpoints operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        IAsyncResult BeginListEndpoints(ListEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEndpoints.</param>
        /// 
        /// <returns>Returns a  ListEndpointsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        ListEndpointsResponse EndListEndpoints(IAsyncResult asyncResult);

        #endregion
        
        #region  ListExperiments


        /// <summary>
        /// Lists all the experiments in your account. The list can be filtered to show only experiments
        /// that were created in a specific time range. The list can be sorted by experiment name
        /// or creation time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperiments service method.</param>
        /// 
        /// <returns>The response from the ListExperiments service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListExperiments">REST API Reference for ListExperiments Operation</seealso>
        ListExperimentsResponse ListExperiments(ListExperimentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListExperiments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExperiments operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExperiments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListExperiments">REST API Reference for ListExperiments Operation</seealso>
        IAsyncResult BeginListExperiments(ListExperimentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListExperiments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExperiments.</param>
        /// 
        /// <returns>Returns a  ListExperimentsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListExperiments">REST API Reference for ListExperiments Operation</seealso>
        ListExperimentsResponse EndListExperiments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFeatureGroups


        /// <summary>
        /// List <code>FeatureGroup</code>s based on given filter and order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFeatureGroups service method.</param>
        /// 
        /// <returns>The response from the ListFeatureGroups service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListFeatureGroups">REST API Reference for ListFeatureGroups Operation</seealso>
        ListFeatureGroupsResponse ListFeatureGroups(ListFeatureGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFeatureGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFeatureGroups operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFeatureGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListFeatureGroups">REST API Reference for ListFeatureGroups Operation</seealso>
        IAsyncResult BeginListFeatureGroups(ListFeatureGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFeatureGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFeatureGroups.</param>
        /// 
        /// <returns>Returns a  ListFeatureGroupsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListFeatureGroups">REST API Reference for ListFeatureGroups Operation</seealso>
        ListFeatureGroupsResponse EndListFeatureGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFlowDefinitions


        /// <summary>
        /// Returns information about the flow definitions in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlowDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListFlowDefinitions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListFlowDefinitions">REST API Reference for ListFlowDefinitions Operation</seealso>
        ListFlowDefinitionsResponse ListFlowDefinitions(ListFlowDefinitionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFlowDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFlowDefinitions operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFlowDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListFlowDefinitions">REST API Reference for ListFlowDefinitions Operation</seealso>
        IAsyncResult BeginListFlowDefinitions(ListFlowDefinitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFlowDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFlowDefinitions.</param>
        /// 
        /// <returns>Returns a  ListFlowDefinitionsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListFlowDefinitions">REST API Reference for ListFlowDefinitions Operation</seealso>
        ListFlowDefinitionsResponse EndListFlowDefinitions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListHubContents


        /// <summary>
        /// List the contents of a hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHubContents service method.</param>
        /// 
        /// <returns>The response from the ListHubContents service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHubContents">REST API Reference for ListHubContents Operation</seealso>
        ListHubContentsResponse ListHubContents(ListHubContentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListHubContents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHubContents operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHubContents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHubContents">REST API Reference for ListHubContents Operation</seealso>
        IAsyncResult BeginListHubContents(ListHubContentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListHubContents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHubContents.</param>
        /// 
        /// <returns>Returns a  ListHubContentsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHubContents">REST API Reference for ListHubContents Operation</seealso>
        ListHubContentsResponse EndListHubContents(IAsyncResult asyncResult);

        #endregion
        
        #region  ListHubContentVersions


        /// <summary>
        /// List hub content versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHubContentVersions service method.</param>
        /// 
        /// <returns>The response from the ListHubContentVersions service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHubContentVersions">REST API Reference for ListHubContentVersions Operation</seealso>
        ListHubContentVersionsResponse ListHubContentVersions(ListHubContentVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListHubContentVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHubContentVersions operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHubContentVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHubContentVersions">REST API Reference for ListHubContentVersions Operation</seealso>
        IAsyncResult BeginListHubContentVersions(ListHubContentVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListHubContentVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHubContentVersions.</param>
        /// 
        /// <returns>Returns a  ListHubContentVersionsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHubContentVersions">REST API Reference for ListHubContentVersions Operation</seealso>
        ListHubContentVersionsResponse EndListHubContentVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListHubs


        /// <summary>
        /// List all existing hubs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHubs service method.</param>
        /// 
        /// <returns>The response from the ListHubs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHubs">REST API Reference for ListHubs Operation</seealso>
        ListHubsResponse ListHubs(ListHubsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListHubs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHubs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHubs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHubs">REST API Reference for ListHubs Operation</seealso>
        IAsyncResult BeginListHubs(ListHubsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListHubs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHubs.</param>
        /// 
        /// <returns>Returns a  ListHubsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHubs">REST API Reference for ListHubs Operation</seealso>
        ListHubsResponse EndListHubs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListHumanTaskUis


        /// <summary>
        /// Returns information about the human task user interfaces in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHumanTaskUis service method.</param>
        /// 
        /// <returns>The response from the ListHumanTaskUis service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHumanTaskUis">REST API Reference for ListHumanTaskUis Operation</seealso>
        ListHumanTaskUisResponse ListHumanTaskUis(ListHumanTaskUisRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListHumanTaskUis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHumanTaskUis operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHumanTaskUis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHumanTaskUis">REST API Reference for ListHumanTaskUis Operation</seealso>
        IAsyncResult BeginListHumanTaskUis(ListHumanTaskUisRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListHumanTaskUis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHumanTaskUis.</param>
        /// 
        /// <returns>Returns a  ListHumanTaskUisResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHumanTaskUis">REST API Reference for ListHumanTaskUis Operation</seealso>
        ListHumanTaskUisResponse EndListHumanTaskUis(IAsyncResult asyncResult);

        #endregion
        
        #region  ListHyperParameterTuningJobs


        /// <summary>
        /// Gets a list of <a>HyperParameterTuningJobSummary</a> objects that describe the hyperparameter
        /// tuning jobs launched in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHyperParameterTuningJobs service method.</param>
        /// 
        /// <returns>The response from the ListHyperParameterTuningJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHyperParameterTuningJobs">REST API Reference for ListHyperParameterTuningJobs Operation</seealso>
        ListHyperParameterTuningJobsResponse ListHyperParameterTuningJobs(ListHyperParameterTuningJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListHyperParameterTuningJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHyperParameterTuningJobs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHyperParameterTuningJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHyperParameterTuningJobs">REST API Reference for ListHyperParameterTuningJobs Operation</seealso>
        IAsyncResult BeginListHyperParameterTuningJobs(ListHyperParameterTuningJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListHyperParameterTuningJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHyperParameterTuningJobs.</param>
        /// 
        /// <returns>Returns a  ListHyperParameterTuningJobsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHyperParameterTuningJobs">REST API Reference for ListHyperParameterTuningJobs Operation</seealso>
        ListHyperParameterTuningJobsResponse EndListHyperParameterTuningJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListImages


        /// <summary>
        /// Lists the images in your account and their properties. The list can be filtered by
        /// creation time or modified time, and whether the image name contains a specified string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImages service method.</param>
        /// 
        /// <returns>The response from the ListImages service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListImages">REST API Reference for ListImages Operation</seealso>
        ListImagesResponse ListImages(ListImagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImages operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListImages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListImages">REST API Reference for ListImages Operation</seealso>
        IAsyncResult BeginListImages(ListImagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListImages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListImages.</param>
        /// 
        /// <returns>Returns a  ListImagesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListImages">REST API Reference for ListImages Operation</seealso>
        ListImagesResponse EndListImages(IAsyncResult asyncResult);

        #endregion
        
        #region  ListImageVersions


        /// <summary>
        /// Lists the versions of a specified image and their properties. The list can be filtered
        /// by creation time or modified time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImageVersions service method.</param>
        /// 
        /// <returns>The response from the ListImageVersions service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListImageVersions">REST API Reference for ListImageVersions Operation</seealso>
        ListImageVersionsResponse ListImageVersions(ListImageVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListImageVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImageVersions operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListImageVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListImageVersions">REST API Reference for ListImageVersions Operation</seealso>
        IAsyncResult BeginListImageVersions(ListImageVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListImageVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListImageVersions.</param>
        /// 
        /// <returns>Returns a  ListImageVersionsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListImageVersions">REST API Reference for ListImageVersions Operation</seealso>
        ListImageVersionsResponse EndListImageVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInferenceExperiments


        /// <summary>
        /// Returns the list of all inference experiments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceExperiments service method.</param>
        /// 
        /// <returns>The response from the ListInferenceExperiments service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListInferenceExperiments">REST API Reference for ListInferenceExperiments Operation</seealso>
        ListInferenceExperimentsResponse ListInferenceExperiments(ListInferenceExperimentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInferenceExperiments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceExperiments operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInferenceExperiments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListInferenceExperiments">REST API Reference for ListInferenceExperiments Operation</seealso>
        IAsyncResult BeginListInferenceExperiments(ListInferenceExperimentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInferenceExperiments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInferenceExperiments.</param>
        /// 
        /// <returns>Returns a  ListInferenceExperimentsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListInferenceExperiments">REST API Reference for ListInferenceExperiments Operation</seealso>
        ListInferenceExperimentsResponse EndListInferenceExperiments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInferenceRecommendationsJobs


        /// <summary>
        /// Lists recommendation jobs that satisfy various filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceRecommendationsJobs service method.</param>
        /// 
        /// <returns>The response from the ListInferenceRecommendationsJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListInferenceRecommendationsJobs">REST API Reference for ListInferenceRecommendationsJobs Operation</seealso>
        ListInferenceRecommendationsJobsResponse ListInferenceRecommendationsJobs(ListInferenceRecommendationsJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInferenceRecommendationsJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceRecommendationsJobs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInferenceRecommendationsJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListInferenceRecommendationsJobs">REST API Reference for ListInferenceRecommendationsJobs Operation</seealso>
        IAsyncResult BeginListInferenceRecommendationsJobs(ListInferenceRecommendationsJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInferenceRecommendationsJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInferenceRecommendationsJobs.</param>
        /// 
        /// <returns>Returns a  ListInferenceRecommendationsJobsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListInferenceRecommendationsJobs">REST API Reference for ListInferenceRecommendationsJobs Operation</seealso>
        ListInferenceRecommendationsJobsResponse EndListInferenceRecommendationsJobs(IAsyncResult asyncResult);

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
        /// 
        /// <returns>The response from the ListInferenceRecommendationsJobSteps service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListInferenceRecommendationsJobSteps">REST API Reference for ListInferenceRecommendationsJobSteps Operation</seealso>
        ListInferenceRecommendationsJobStepsResponse ListInferenceRecommendationsJobSteps(ListInferenceRecommendationsJobStepsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInferenceRecommendationsJobSteps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceRecommendationsJobSteps operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInferenceRecommendationsJobSteps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListInferenceRecommendationsJobSteps">REST API Reference for ListInferenceRecommendationsJobSteps Operation</seealso>
        IAsyncResult BeginListInferenceRecommendationsJobSteps(ListInferenceRecommendationsJobStepsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInferenceRecommendationsJobSteps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInferenceRecommendationsJobSteps.</param>
        /// 
        /// <returns>Returns a  ListInferenceRecommendationsJobStepsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListInferenceRecommendationsJobSteps">REST API Reference for ListInferenceRecommendationsJobSteps Operation</seealso>
        ListInferenceRecommendationsJobStepsResponse EndListInferenceRecommendationsJobSteps(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLabelingJobs


        /// <summary>
        /// Gets a list of labeling jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLabelingJobs service method.</param>
        /// 
        /// <returns>The response from the ListLabelingJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobs">REST API Reference for ListLabelingJobs Operation</seealso>
        ListLabelingJobsResponse ListLabelingJobs(ListLabelingJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLabelingJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLabelingJobs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLabelingJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobs">REST API Reference for ListLabelingJobs Operation</seealso>
        IAsyncResult BeginListLabelingJobs(ListLabelingJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLabelingJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLabelingJobs.</param>
        /// 
        /// <returns>Returns a  ListLabelingJobsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobs">REST API Reference for ListLabelingJobs Operation</seealso>
        ListLabelingJobsResponse EndListLabelingJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLabelingJobsForWorkteam


        /// <summary>
        /// Gets a list of labeling jobs assigned to a specified work team.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLabelingJobsForWorkteam service method.</param>
        /// 
        /// <returns>The response from the ListLabelingJobsForWorkteam service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobsForWorkteam">REST API Reference for ListLabelingJobsForWorkteam Operation</seealso>
        ListLabelingJobsForWorkteamResponse ListLabelingJobsForWorkteam(ListLabelingJobsForWorkteamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLabelingJobsForWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLabelingJobsForWorkteam operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLabelingJobsForWorkteam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobsForWorkteam">REST API Reference for ListLabelingJobsForWorkteam Operation</seealso>
        IAsyncResult BeginListLabelingJobsForWorkteam(ListLabelingJobsForWorkteamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLabelingJobsForWorkteam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLabelingJobsForWorkteam.</param>
        /// 
        /// <returns>Returns a  ListLabelingJobsForWorkteamResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobsForWorkteam">REST API Reference for ListLabelingJobsForWorkteam Operation</seealso>
        ListLabelingJobsForWorkteamResponse EndListLabelingJobsForWorkteam(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLineageGroups


        /// <summary>
        /// A list of lineage groups shared with your Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/xaccount-lineage-tracking.html">
        /// Cross-Account Lineage Tracking </a> in the <i>Amazon SageMaker Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLineageGroups service method.</param>
        /// 
        /// <returns>The response from the ListLineageGroups service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLineageGroups">REST API Reference for ListLineageGroups Operation</seealso>
        ListLineageGroupsResponse ListLineageGroups(ListLineageGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLineageGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLineageGroups operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLineageGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLineageGroups">REST API Reference for ListLineageGroups Operation</seealso>
        IAsyncResult BeginListLineageGroups(ListLineageGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLineageGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLineageGroups.</param>
        /// 
        /// <returns>Returns a  ListLineageGroupsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLineageGroups">REST API Reference for ListLineageGroups Operation</seealso>
        ListLineageGroupsResponse EndListLineageGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListModelBiasJobDefinitions


        /// <summary>
        /// Lists model bias jobs definitions that satisfy various filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelBiasJobDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListModelBiasJobDefinitions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelBiasJobDefinitions">REST API Reference for ListModelBiasJobDefinitions Operation</seealso>
        ListModelBiasJobDefinitionsResponse ListModelBiasJobDefinitions(ListModelBiasJobDefinitionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListModelBiasJobDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModelBiasJobDefinitions operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModelBiasJobDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelBiasJobDefinitions">REST API Reference for ListModelBiasJobDefinitions Operation</seealso>
        IAsyncResult BeginListModelBiasJobDefinitions(ListModelBiasJobDefinitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListModelBiasJobDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModelBiasJobDefinitions.</param>
        /// 
        /// <returns>Returns a  ListModelBiasJobDefinitionsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelBiasJobDefinitions">REST API Reference for ListModelBiasJobDefinitions Operation</seealso>
        ListModelBiasJobDefinitionsResponse EndListModelBiasJobDefinitions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListModelCardExportJobs


        /// <summary>
        /// List the export jobs for the Amazon SageMaker Model Card.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelCardExportJobs service method.</param>
        /// 
        /// <returns>The response from the ListModelCardExportJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelCardExportJobs">REST API Reference for ListModelCardExportJobs Operation</seealso>
        ListModelCardExportJobsResponse ListModelCardExportJobs(ListModelCardExportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListModelCardExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModelCardExportJobs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModelCardExportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelCardExportJobs">REST API Reference for ListModelCardExportJobs Operation</seealso>
        IAsyncResult BeginListModelCardExportJobs(ListModelCardExportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListModelCardExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModelCardExportJobs.</param>
        /// 
        /// <returns>Returns a  ListModelCardExportJobsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelCardExportJobs">REST API Reference for ListModelCardExportJobs Operation</seealso>
        ListModelCardExportJobsResponse EndListModelCardExportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListModelCards


        /// <summary>
        /// List existing model cards.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelCards service method.</param>
        /// 
        /// <returns>The response from the ListModelCards service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelCards">REST API Reference for ListModelCards Operation</seealso>
        ListModelCardsResponse ListModelCards(ListModelCardsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListModelCards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModelCards operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModelCards
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelCards">REST API Reference for ListModelCards Operation</seealso>
        IAsyncResult BeginListModelCards(ListModelCardsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListModelCards operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModelCards.</param>
        /// 
        /// <returns>Returns a  ListModelCardsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelCards">REST API Reference for ListModelCards Operation</seealso>
        ListModelCardsResponse EndListModelCards(IAsyncResult asyncResult);

        #endregion
        
        #region  ListModelCardVersions


        /// <summary>
        /// List existing versions of an Amazon SageMaker Model Card.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelCardVersions service method.</param>
        /// 
        /// <returns>The response from the ListModelCardVersions service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelCardVersions">REST API Reference for ListModelCardVersions Operation</seealso>
        ListModelCardVersionsResponse ListModelCardVersions(ListModelCardVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListModelCardVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModelCardVersions operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModelCardVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelCardVersions">REST API Reference for ListModelCardVersions Operation</seealso>
        IAsyncResult BeginListModelCardVersions(ListModelCardVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListModelCardVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModelCardVersions.</param>
        /// 
        /// <returns>Returns a  ListModelCardVersionsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelCardVersions">REST API Reference for ListModelCardVersions Operation</seealso>
        ListModelCardVersionsResponse EndListModelCardVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListModelExplainabilityJobDefinitions


        /// <summary>
        /// Lists model explainability job definitions that satisfy various filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelExplainabilityJobDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListModelExplainabilityJobDefinitions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelExplainabilityJobDefinitions">REST API Reference for ListModelExplainabilityJobDefinitions Operation</seealso>
        ListModelExplainabilityJobDefinitionsResponse ListModelExplainabilityJobDefinitions(ListModelExplainabilityJobDefinitionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListModelExplainabilityJobDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModelExplainabilityJobDefinitions operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModelExplainabilityJobDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelExplainabilityJobDefinitions">REST API Reference for ListModelExplainabilityJobDefinitions Operation</seealso>
        IAsyncResult BeginListModelExplainabilityJobDefinitions(ListModelExplainabilityJobDefinitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListModelExplainabilityJobDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModelExplainabilityJobDefinitions.</param>
        /// 
        /// <returns>Returns a  ListModelExplainabilityJobDefinitionsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelExplainabilityJobDefinitions">REST API Reference for ListModelExplainabilityJobDefinitions Operation</seealso>
        ListModelExplainabilityJobDefinitionsResponse EndListModelExplainabilityJobDefinitions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListModelMetadata


        /// <summary>
        /// Lists the domain, framework, task, and model name of standard machine learning models
        /// found in common model zoos.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelMetadata service method.</param>
        /// 
        /// <returns>The response from the ListModelMetadata service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelMetadata">REST API Reference for ListModelMetadata Operation</seealso>
        ListModelMetadataResponse ListModelMetadata(ListModelMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListModelMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModelMetadata operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModelMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelMetadata">REST API Reference for ListModelMetadata Operation</seealso>
        IAsyncResult BeginListModelMetadata(ListModelMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListModelMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModelMetadata.</param>
        /// 
        /// <returns>Returns a  ListModelMetadataResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelMetadata">REST API Reference for ListModelMetadata Operation</seealso>
        ListModelMetadataResponse EndListModelMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  ListModelPackageGroups


        /// <summary>
        /// Gets a list of the model groups in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelPackageGroups service method.</param>
        /// 
        /// <returns>The response from the ListModelPackageGroups service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelPackageGroups">REST API Reference for ListModelPackageGroups Operation</seealso>
        ListModelPackageGroupsResponse ListModelPackageGroups(ListModelPackageGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListModelPackageGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModelPackageGroups operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModelPackageGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelPackageGroups">REST API Reference for ListModelPackageGroups Operation</seealso>
        IAsyncResult BeginListModelPackageGroups(ListModelPackageGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListModelPackageGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModelPackageGroups.</param>
        /// 
        /// <returns>Returns a  ListModelPackageGroupsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelPackageGroups">REST API Reference for ListModelPackageGroups Operation</seealso>
        ListModelPackageGroupsResponse EndListModelPackageGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListModelPackages


        /// <summary>
        /// Lists the model packages that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelPackages service method.</param>
        /// 
        /// <returns>The response from the ListModelPackages service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelPackages">REST API Reference for ListModelPackages Operation</seealso>
        ListModelPackagesResponse ListModelPackages(ListModelPackagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListModelPackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModelPackages operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModelPackages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelPackages">REST API Reference for ListModelPackages Operation</seealso>
        IAsyncResult BeginListModelPackages(ListModelPackagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListModelPackages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModelPackages.</param>
        /// 
        /// <returns>Returns a  ListModelPackagesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelPackages">REST API Reference for ListModelPackages Operation</seealso>
        ListModelPackagesResponse EndListModelPackages(IAsyncResult asyncResult);

        #endregion
        
        #region  ListModelQualityJobDefinitions


        /// <summary>
        /// Gets a list of model quality monitoring job definitions in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelQualityJobDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListModelQualityJobDefinitions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelQualityJobDefinitions">REST API Reference for ListModelQualityJobDefinitions Operation</seealso>
        ListModelQualityJobDefinitionsResponse ListModelQualityJobDefinitions(ListModelQualityJobDefinitionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListModelQualityJobDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModelQualityJobDefinitions operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModelQualityJobDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelQualityJobDefinitions">REST API Reference for ListModelQualityJobDefinitions Operation</seealso>
        IAsyncResult BeginListModelQualityJobDefinitions(ListModelQualityJobDefinitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListModelQualityJobDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModelQualityJobDefinitions.</param>
        /// 
        /// <returns>Returns a  ListModelQualityJobDefinitionsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelQualityJobDefinitions">REST API Reference for ListModelQualityJobDefinitions Operation</seealso>
        ListModelQualityJobDefinitionsResponse EndListModelQualityJobDefinitions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListModels


        /// <summary>
        /// Lists models created with the <code>CreateModel</code> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModels service method.</param>
        /// 
        /// <returns>The response from the ListModels service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModels">REST API Reference for ListModels Operation</seealso>
        ListModelsResponse ListModels(ListModelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModels operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModels">REST API Reference for ListModels Operation</seealso>
        IAsyncResult BeginListModels(ListModelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModels.</param>
        /// 
        /// <returns>Returns a  ListModelsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModels">REST API Reference for ListModels Operation</seealso>
        ListModelsResponse EndListModels(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMonitoringAlertHistory


        /// <summary>
        /// Gets a list of past alerts in a model monitoring schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitoringAlertHistory service method.</param>
        /// 
        /// <returns>The response from the ListMonitoringAlertHistory service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringAlertHistory">REST API Reference for ListMonitoringAlertHistory Operation</seealso>
        ListMonitoringAlertHistoryResponse ListMonitoringAlertHistory(ListMonitoringAlertHistoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMonitoringAlertHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMonitoringAlertHistory operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMonitoringAlertHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringAlertHistory">REST API Reference for ListMonitoringAlertHistory Operation</seealso>
        IAsyncResult BeginListMonitoringAlertHistory(ListMonitoringAlertHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMonitoringAlertHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMonitoringAlertHistory.</param>
        /// 
        /// <returns>Returns a  ListMonitoringAlertHistoryResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringAlertHistory">REST API Reference for ListMonitoringAlertHistory Operation</seealso>
        ListMonitoringAlertHistoryResponse EndListMonitoringAlertHistory(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMonitoringAlerts


        /// <summary>
        /// Gets the alerts for a single monitoring schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitoringAlerts service method.</param>
        /// 
        /// <returns>The response from the ListMonitoringAlerts service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringAlerts">REST API Reference for ListMonitoringAlerts Operation</seealso>
        ListMonitoringAlertsResponse ListMonitoringAlerts(ListMonitoringAlertsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMonitoringAlerts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMonitoringAlerts operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMonitoringAlerts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringAlerts">REST API Reference for ListMonitoringAlerts Operation</seealso>
        IAsyncResult BeginListMonitoringAlerts(ListMonitoringAlertsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMonitoringAlerts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMonitoringAlerts.</param>
        /// 
        /// <returns>Returns a  ListMonitoringAlertsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringAlerts">REST API Reference for ListMonitoringAlerts Operation</seealso>
        ListMonitoringAlertsResponse EndListMonitoringAlerts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMonitoringExecutions


        /// <summary>
        /// Returns list of all monitoring job executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitoringExecutions service method.</param>
        /// 
        /// <returns>The response from the ListMonitoringExecutions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringExecutions">REST API Reference for ListMonitoringExecutions Operation</seealso>
        ListMonitoringExecutionsResponse ListMonitoringExecutions(ListMonitoringExecutionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMonitoringExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMonitoringExecutions operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMonitoringExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringExecutions">REST API Reference for ListMonitoringExecutions Operation</seealso>
        IAsyncResult BeginListMonitoringExecutions(ListMonitoringExecutionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMonitoringExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMonitoringExecutions.</param>
        /// 
        /// <returns>Returns a  ListMonitoringExecutionsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringExecutions">REST API Reference for ListMonitoringExecutions Operation</seealso>
        ListMonitoringExecutionsResponse EndListMonitoringExecutions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMonitoringSchedules


        /// <summary>
        /// Returns list of all monitoring schedules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitoringSchedules service method.</param>
        /// 
        /// <returns>The response from the ListMonitoringSchedules service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringSchedules">REST API Reference for ListMonitoringSchedules Operation</seealso>
        ListMonitoringSchedulesResponse ListMonitoringSchedules(ListMonitoringSchedulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMonitoringSchedules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMonitoringSchedules operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMonitoringSchedules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringSchedules">REST API Reference for ListMonitoringSchedules Operation</seealso>
        IAsyncResult BeginListMonitoringSchedules(ListMonitoringSchedulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMonitoringSchedules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMonitoringSchedules.</param>
        /// 
        /// <returns>Returns a  ListMonitoringSchedulesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringSchedules">REST API Reference for ListMonitoringSchedules Operation</seealso>
        ListMonitoringSchedulesResponse EndListMonitoringSchedules(IAsyncResult asyncResult);

        #endregion
        
        #region  ListNotebookInstanceLifecycleConfigs


        /// <summary>
        /// Lists notebook instance lifestyle configurations created with the <a>CreateNotebookInstanceLifecycleConfig</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstanceLifecycleConfigs service method.</param>
        /// 
        /// <returns>The response from the ListNotebookInstanceLifecycleConfigs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstanceLifecycleConfigs">REST API Reference for ListNotebookInstanceLifecycleConfigs Operation</seealso>
        ListNotebookInstanceLifecycleConfigsResponse ListNotebookInstanceLifecycleConfigs(ListNotebookInstanceLifecycleConfigsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListNotebookInstanceLifecycleConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstanceLifecycleConfigs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotebookInstanceLifecycleConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstanceLifecycleConfigs">REST API Reference for ListNotebookInstanceLifecycleConfigs Operation</seealso>
        IAsyncResult BeginListNotebookInstanceLifecycleConfigs(ListNotebookInstanceLifecycleConfigsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotebookInstanceLifecycleConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotebookInstanceLifecycleConfigs.</param>
        /// 
        /// <returns>Returns a  ListNotebookInstanceLifecycleConfigsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstanceLifecycleConfigs">REST API Reference for ListNotebookInstanceLifecycleConfigs Operation</seealso>
        ListNotebookInstanceLifecycleConfigsResponse EndListNotebookInstanceLifecycleConfigs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListNotebookInstances


        /// <summary>
        /// Returns a list of the SageMaker notebook instances in the requester's account in an
        /// Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstances service method.</param>
        /// 
        /// <returns>The response from the ListNotebookInstances service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstances">REST API Reference for ListNotebookInstances Operation</seealso>
        ListNotebookInstancesResponse ListNotebookInstances(ListNotebookInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListNotebookInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstances operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotebookInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstances">REST API Reference for ListNotebookInstances Operation</seealso>
        IAsyncResult BeginListNotebookInstances(ListNotebookInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotebookInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotebookInstances.</param>
        /// 
        /// <returns>Returns a  ListNotebookInstancesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstances">REST API Reference for ListNotebookInstances Operation</seealso>
        ListNotebookInstancesResponse EndListNotebookInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPipelineExecutions


        /// <summary>
        /// Gets a list of the pipeline executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineExecutions service method.</param>
        /// 
        /// <returns>The response from the ListPipelineExecutions service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListPipelineExecutions">REST API Reference for ListPipelineExecutions Operation</seealso>
        ListPipelineExecutionsResponse ListPipelineExecutions(ListPipelineExecutionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelineExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineExecutions operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPipelineExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListPipelineExecutions">REST API Reference for ListPipelineExecutions Operation</seealso>
        IAsyncResult BeginListPipelineExecutions(ListPipelineExecutionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPipelineExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPipelineExecutions.</param>
        /// 
        /// <returns>Returns a  ListPipelineExecutionsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListPipelineExecutions">REST API Reference for ListPipelineExecutions Operation</seealso>
        ListPipelineExecutionsResponse EndListPipelineExecutions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPipelineExecutionSteps


        /// <summary>
        /// Gets a list of <code>PipeLineExecutionStep</code> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineExecutionSteps service method.</param>
        /// 
        /// <returns>The response from the ListPipelineExecutionSteps service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListPipelineExecutionSteps">REST API Reference for ListPipelineExecutionSteps Operation</seealso>
        ListPipelineExecutionStepsResponse ListPipelineExecutionSteps(ListPipelineExecutionStepsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelineExecutionSteps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineExecutionSteps operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPipelineExecutionSteps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListPipelineExecutionSteps">REST API Reference for ListPipelineExecutionSteps Operation</seealso>
        IAsyncResult BeginListPipelineExecutionSteps(ListPipelineExecutionStepsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPipelineExecutionSteps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPipelineExecutionSteps.</param>
        /// 
        /// <returns>Returns a  ListPipelineExecutionStepsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListPipelineExecutionSteps">REST API Reference for ListPipelineExecutionSteps Operation</seealso>
        ListPipelineExecutionStepsResponse EndListPipelineExecutionSteps(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPipelineParametersForExecution


        /// <summary>
        /// Gets a list of parameters for a pipeline execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineParametersForExecution service method.</param>
        /// 
        /// <returns>The response from the ListPipelineParametersForExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListPipelineParametersForExecution">REST API Reference for ListPipelineParametersForExecution Operation</seealso>
        ListPipelineParametersForExecutionResponse ListPipelineParametersForExecution(ListPipelineParametersForExecutionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelineParametersForExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineParametersForExecution operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPipelineParametersForExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListPipelineParametersForExecution">REST API Reference for ListPipelineParametersForExecution Operation</seealso>
        IAsyncResult BeginListPipelineParametersForExecution(ListPipelineParametersForExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPipelineParametersForExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPipelineParametersForExecution.</param>
        /// 
        /// <returns>Returns a  ListPipelineParametersForExecutionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListPipelineParametersForExecution">REST API Reference for ListPipelineParametersForExecution Operation</seealso>
        ListPipelineParametersForExecutionResponse EndListPipelineParametersForExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPipelines


        /// <summary>
        /// Gets a list of pipelines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        ListPipelinesResponse ListPipelines(ListPipelinesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPipelines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        IAsyncResult BeginListPipelines(ListPipelinesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPipelines.</param>
        /// 
        /// <returns>Returns a  ListPipelinesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        ListPipelinesResponse EndListPipelines(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProcessingJobs


        /// <summary>
        /// Lists processing jobs that satisfy various filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProcessingJobs service method.</param>
        /// 
        /// <returns>The response from the ListProcessingJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListProcessingJobs">REST API Reference for ListProcessingJobs Operation</seealso>
        ListProcessingJobsResponse ListProcessingJobs(ListProcessingJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProcessingJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProcessingJobs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProcessingJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListProcessingJobs">REST API Reference for ListProcessingJobs Operation</seealso>
        IAsyncResult BeginListProcessingJobs(ListProcessingJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProcessingJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProcessingJobs.</param>
        /// 
        /// <returns>Returns a  ListProcessingJobsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListProcessingJobs">REST API Reference for ListProcessingJobs Operation</seealso>
        ListProcessingJobsResponse EndListProcessingJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProjects


        /// <summary>
        /// Gets a list of the projects in an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListProjects">REST API Reference for ListProjects Operation</seealso>
        ListProjectsResponse ListProjects(ListProjectsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListProjects">REST API Reference for ListProjects Operation</seealso>
        IAsyncResult BeginListProjects(ListProjectsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProjects.</param>
        /// 
        /// <returns>Returns a  ListProjectsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListProjects">REST API Reference for ListProjects Operation</seealso>
        ListProjectsResponse EndListProjects(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSpaces


        /// <summary>
        /// Lists spaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpaces service method.</param>
        /// 
        /// <returns>The response from the ListSpaces service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListSpaces">REST API Reference for ListSpaces Operation</seealso>
        ListSpacesResponse ListSpaces(ListSpacesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSpaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSpaces operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSpaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListSpaces">REST API Reference for ListSpaces Operation</seealso>
        IAsyncResult BeginListSpaces(ListSpacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSpaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSpaces.</param>
        /// 
        /// <returns>Returns a  ListSpacesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListSpaces">REST API Reference for ListSpaces Operation</seealso>
        ListSpacesResponse EndListSpaces(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStageDevices


        /// <summary>
        /// Lists devices allocated to the stage, containing detailed device information and deployment
        /// status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStageDevices service method.</param>
        /// 
        /// <returns>The response from the ListStageDevices service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListStageDevices">REST API Reference for ListStageDevices Operation</seealso>
        ListStageDevicesResponse ListStageDevices(ListStageDevicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStageDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStageDevices operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStageDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListStageDevices">REST API Reference for ListStageDevices Operation</seealso>
        IAsyncResult BeginListStageDevices(ListStageDevicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStageDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStageDevices.</param>
        /// 
        /// <returns>Returns a  ListStageDevicesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListStageDevices">REST API Reference for ListStageDevices Operation</seealso>
        ListStageDevicesResponse EndListStageDevices(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStudioLifecycleConfigs


        /// <summary>
        /// Lists the Studio Lifecycle Configurations in your Amazon Web Services Account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStudioLifecycleConfigs service method.</param>
        /// 
        /// <returns>The response from the ListStudioLifecycleConfigs service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListStudioLifecycleConfigs">REST API Reference for ListStudioLifecycleConfigs Operation</seealso>
        ListStudioLifecycleConfigsResponse ListStudioLifecycleConfigs(ListStudioLifecycleConfigsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStudioLifecycleConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStudioLifecycleConfigs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStudioLifecycleConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListStudioLifecycleConfigs">REST API Reference for ListStudioLifecycleConfigs Operation</seealso>
        IAsyncResult BeginListStudioLifecycleConfigs(ListStudioLifecycleConfigsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStudioLifecycleConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStudioLifecycleConfigs.</param>
        /// 
        /// <returns>Returns a  ListStudioLifecycleConfigsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListStudioLifecycleConfigs">REST API Reference for ListStudioLifecycleConfigs Operation</seealso>
        ListStudioLifecycleConfigsResponse EndListStudioLifecycleConfigs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSubscribedWorkteams


        /// <summary>
        /// Gets a list of the work teams that you are subscribed to in the Amazon Web Services
        /// Marketplace. The list may be empty if no work team satisfies the filter specified
        /// in the <code>NameContains</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribedWorkteams service method.</param>
        /// 
        /// <returns>The response from the ListSubscribedWorkteams service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListSubscribedWorkteams">REST API Reference for ListSubscribedWorkteams Operation</seealso>
        ListSubscribedWorkteamsResponse ListSubscribedWorkteams(ListSubscribedWorkteamsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscribedWorkteams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribedWorkteams operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubscribedWorkteams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListSubscribedWorkteams">REST API Reference for ListSubscribedWorkteams Operation</seealso>
        IAsyncResult BeginListSubscribedWorkteams(ListSubscribedWorkteamsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubscribedWorkteams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscribedWorkteams.</param>
        /// 
        /// <returns>Returns a  ListSubscribedWorkteamsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListSubscribedWorkteams">REST API Reference for ListSubscribedWorkteams Operation</seealso>
        ListSubscribedWorkteamsResponse EndListSubscribedWorkteams(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTags


        /// <summary>
        /// Returns the tags for the specified SageMaker resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTags">REST API Reference for ListTags Operation</seealso>
        ListTagsResponse ListTags(ListTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTags">REST API Reference for ListTags Operation</seealso>
        IAsyncResult BeginListTags(ListTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTags.</param>
        /// 
        /// <returns>Returns a  ListTagsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTags">REST API Reference for ListTags Operation</seealso>
        ListTagsResponse EndListTags(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTrainingJobs


        /// <summary>
        /// Lists training jobs.
        /// 
        ///  <note> 
        /// <para>
        /// When <code>StatusEquals</code> and <code>MaxResults</code> are set at the same time,
        /// the <code>MaxResults</code> number of training jobs are first retrieved ignoring the
        /// <code>StatusEquals</code> parameter and then they are filtered by the <code>StatusEquals</code>
        /// parameter, which is returned as a response.
        /// </para>
        ///  
        /// <para>
        /// For example, if <code>ListTrainingJobs</code> is invoked with the following parameters:
        /// </para>
        ///  
        /// <para>
        ///  <code>{ ... MaxResults: 100, StatusEquals: InProgress ... }</code> 
        /// </para>
        ///  
        /// <para>
        /// First, 100 trainings jobs with any status, including those other than <code>InProgress</code>,
        /// are selected (sorted according to the creation time, from the most current to the
        /// oldest). Next, those with a status of <code>InProgress</code> are returned.
        /// </para>
        ///  
        /// <para>
        /// You can quickly test the API using the following Amazon Web Services CLI code.
        /// </para>
        ///  
        /// <para>
        ///  <code>aws sagemaker list-training-jobs --max-results 100 --status-equals InProgress</code>
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingJobs service method.</param>
        /// 
        /// <returns>The response from the ListTrainingJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobs">REST API Reference for ListTrainingJobs Operation</seealso>
        ListTrainingJobsResponse ListTrainingJobs(ListTrainingJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrainingJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingJobs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrainingJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobs">REST API Reference for ListTrainingJobs Operation</seealso>
        IAsyncResult BeginListTrainingJobs(ListTrainingJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrainingJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrainingJobs.</param>
        /// 
        /// <returns>Returns a  ListTrainingJobsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobs">REST API Reference for ListTrainingJobs Operation</seealso>
        ListTrainingJobsResponse EndListTrainingJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTrainingJobsForHyperParameterTuningJob


        /// <summary>
        /// Gets a list of <a>TrainingJobSummary</a> objects that describe the training jobs that
        /// a hyperparameter tuning job launched.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingJobsForHyperParameterTuningJob service method.</param>
        /// 
        /// <returns>The response from the ListTrainingJobsForHyperParameterTuningJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobsForHyperParameterTuningJob">REST API Reference for ListTrainingJobsForHyperParameterTuningJob Operation</seealso>
        ListTrainingJobsForHyperParameterTuningJobResponse ListTrainingJobsForHyperParameterTuningJob(ListTrainingJobsForHyperParameterTuningJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrainingJobsForHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingJobsForHyperParameterTuningJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrainingJobsForHyperParameterTuningJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobsForHyperParameterTuningJob">REST API Reference for ListTrainingJobsForHyperParameterTuningJob Operation</seealso>
        IAsyncResult BeginListTrainingJobsForHyperParameterTuningJob(ListTrainingJobsForHyperParameterTuningJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrainingJobsForHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrainingJobsForHyperParameterTuningJob.</param>
        /// 
        /// <returns>Returns a  ListTrainingJobsForHyperParameterTuningJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobsForHyperParameterTuningJob">REST API Reference for ListTrainingJobsForHyperParameterTuningJob Operation</seealso>
        ListTrainingJobsForHyperParameterTuningJobResponse EndListTrainingJobsForHyperParameterTuningJob(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTransformJobs


        /// <summary>
        /// Lists transform jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTransformJobs service method.</param>
        /// 
        /// <returns>The response from the ListTransformJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTransformJobs">REST API Reference for ListTransformJobs Operation</seealso>
        ListTransformJobsResponse ListTransformJobs(ListTransformJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTransformJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTransformJobs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTransformJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTransformJobs">REST API Reference for ListTransformJobs Operation</seealso>
        IAsyncResult BeginListTransformJobs(ListTransformJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTransformJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTransformJobs.</param>
        /// 
        /// <returns>Returns a  ListTransformJobsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTransformJobs">REST API Reference for ListTransformJobs Operation</seealso>
        ListTransformJobsResponse EndListTransformJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTrialComponents


        /// <summary>
        /// Lists the trial components in your account. You can sort the list by trial component
        /// name or creation time. You can filter the list to show only components that were created
        /// in a specific time range. You can also filter on one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>ExperimentName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SourceArn</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TrialName</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrialComponents service method.</param>
        /// 
        /// <returns>The response from the ListTrialComponents service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrialComponents">REST API Reference for ListTrialComponents Operation</seealso>
        ListTrialComponentsResponse ListTrialComponents(ListTrialComponentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrialComponents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrialComponents operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrialComponents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrialComponents">REST API Reference for ListTrialComponents Operation</seealso>
        IAsyncResult BeginListTrialComponents(ListTrialComponentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrialComponents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrialComponents.</param>
        /// 
        /// <returns>Returns a  ListTrialComponentsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrialComponents">REST API Reference for ListTrialComponents Operation</seealso>
        ListTrialComponentsResponse EndListTrialComponents(IAsyncResult asyncResult);

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
        /// 
        /// <returns>The response from the ListTrials service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrials">REST API Reference for ListTrials Operation</seealso>
        ListTrialsResponse ListTrials(ListTrialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrials operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrials">REST API Reference for ListTrials Operation</seealso>
        IAsyncResult BeginListTrials(ListTrialsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrials.</param>
        /// 
        /// <returns>Returns a  ListTrialsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrials">REST API Reference for ListTrials Operation</seealso>
        ListTrialsResponse EndListTrials(IAsyncResult asyncResult);

        #endregion
        
        #region  ListUserProfiles


        /// <summary>
        /// Lists user profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserProfiles service method.</param>
        /// 
        /// <returns>The response from the ListUserProfiles service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListUserProfiles">REST API Reference for ListUserProfiles Operation</seealso>
        ListUserProfilesResponse ListUserProfiles(ListUserProfilesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserProfiles operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUserProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListUserProfiles">REST API Reference for ListUserProfiles Operation</seealso>
        IAsyncResult BeginListUserProfiles(ListUserProfilesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserProfiles.</param>
        /// 
        /// <returns>Returns a  ListUserProfilesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListUserProfiles">REST API Reference for ListUserProfiles Operation</seealso>
        ListUserProfilesResponse EndListUserProfiles(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkforces


        /// <summary>
        /// Use this operation to list all private and vendor workforces in an Amazon Web Services
        /// Region. Note that you can only have one private workforce per Amazon Web Services
        /// Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkforces service method.</param>
        /// 
        /// <returns>The response from the ListWorkforces service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListWorkforces">REST API Reference for ListWorkforces Operation</seealso>
        ListWorkforcesResponse ListWorkforces(ListWorkforcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkforces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkforces operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkforces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListWorkforces">REST API Reference for ListWorkforces Operation</seealso>
        IAsyncResult BeginListWorkforces(ListWorkforcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkforces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkforces.</param>
        /// 
        /// <returns>Returns a  ListWorkforcesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListWorkforces">REST API Reference for ListWorkforces Operation</seealso>
        ListWorkforcesResponse EndListWorkforces(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkteams


        /// <summary>
        /// Gets a list of private work teams that you have defined in a region. The list may
        /// be empty if no work team satisfies the filter specified in the <code>NameContains</code>
        /// parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkteams service method.</param>
        /// 
        /// <returns>The response from the ListWorkteams service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListWorkteams">REST API Reference for ListWorkteams Operation</seealso>
        ListWorkteamsResponse ListWorkteams(ListWorkteamsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkteams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkteams operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkteams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListWorkteams">REST API Reference for ListWorkteams Operation</seealso>
        IAsyncResult BeginListWorkteams(ListWorkteamsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkteams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkteams.</param>
        /// 
        /// <returns>Returns a  ListWorkteamsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListWorkteams">REST API Reference for ListWorkteams Operation</seealso>
        ListWorkteamsResponse EndListWorkteams(IAsyncResult asyncResult);

        #endregion
        
        #region  PutModelPackageGroupPolicy


        /// <summary>
        /// Adds a resouce policy to control access to a model group. For information about resoure
        /// policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_identity-vs-resource.html">Identity-based
        /// policies and resource-based policies</a> in the <i>Amazon Web Services Identity and
        /// Access Management User Guide.</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutModelPackageGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the PutModelPackageGroupPolicy service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/PutModelPackageGroupPolicy">REST API Reference for PutModelPackageGroupPolicy Operation</seealso>
        PutModelPackageGroupPolicyResponse PutModelPackageGroupPolicy(PutModelPackageGroupPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutModelPackageGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutModelPackageGroupPolicy operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutModelPackageGroupPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/PutModelPackageGroupPolicy">REST API Reference for PutModelPackageGroupPolicy Operation</seealso>
        IAsyncResult BeginPutModelPackageGroupPolicy(PutModelPackageGroupPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutModelPackageGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutModelPackageGroupPolicy.</param>
        /// 
        /// <returns>Returns a  PutModelPackageGroupPolicyResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/PutModelPackageGroupPolicy">REST API Reference for PutModelPackageGroupPolicy Operation</seealso>
        PutModelPackageGroupPolicyResponse EndPutModelPackageGroupPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  QueryLineage


        /// <summary>
        /// Use this action to inspect your lineage and discover relationships between entities.
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/querying-lineage-entities.html">
        /// Querying Lineage Entities</a> in the <i>Amazon SageMaker Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryLineage service method.</param>
        /// 
        /// <returns>The response from the QueryLineage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/QueryLineage">REST API Reference for QueryLineage Operation</seealso>
        QueryLineageResponse QueryLineage(QueryLineageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the QueryLineage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryLineage operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryLineage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/QueryLineage">REST API Reference for QueryLineage Operation</seealso>
        IAsyncResult BeginQueryLineage(QueryLineageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  QueryLineage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryLineage.</param>
        /// 
        /// <returns>Returns a  QueryLineageResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/QueryLineage">REST API Reference for QueryLineage Operation</seealso>
        QueryLineageResponse EndQueryLineage(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterDevices


        /// <summary>
        /// Register devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDevices service method.</param>
        /// 
        /// <returns>The response from the RegisterDevices service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/RegisterDevices">REST API Reference for RegisterDevices Operation</seealso>
        RegisterDevicesResponse RegisterDevices(RegisterDevicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterDevices operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/RegisterDevices">REST API Reference for RegisterDevices Operation</seealso>
        IAsyncResult BeginRegisterDevices(RegisterDevicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterDevices.</param>
        /// 
        /// <returns>Returns a  RegisterDevicesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/RegisterDevices">REST API Reference for RegisterDevices Operation</seealso>
        RegisterDevicesResponse EndRegisterDevices(IAsyncResult asyncResult);

        #endregion
        
        #region  RenderUiTemplate


        /// <summary>
        /// Renders the UI template so that you can preview the worker's experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenderUiTemplate service method.</param>
        /// 
        /// <returns>The response from the RenderUiTemplate service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/RenderUiTemplate">REST API Reference for RenderUiTemplate Operation</seealso>
        RenderUiTemplateResponse RenderUiTemplate(RenderUiTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RenderUiTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RenderUiTemplate operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRenderUiTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/RenderUiTemplate">REST API Reference for RenderUiTemplate Operation</seealso>
        IAsyncResult BeginRenderUiTemplate(RenderUiTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RenderUiTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRenderUiTemplate.</param>
        /// 
        /// <returns>Returns a  RenderUiTemplateResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/RenderUiTemplate">REST API Reference for RenderUiTemplate Operation</seealso>
        RenderUiTemplateResponse EndRenderUiTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  RetryPipelineExecution


        /// <summary>
        /// Retry the execution of the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryPipelineExecution service method.</param>
        /// 
        /// <returns>The response from the RetryPipelineExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/RetryPipelineExecution">REST API Reference for RetryPipelineExecution Operation</seealso>
        RetryPipelineExecutionResponse RetryPipelineExecution(RetryPipelineExecutionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RetryPipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetryPipelineExecution operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetryPipelineExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/RetryPipelineExecution">REST API Reference for RetryPipelineExecution Operation</seealso>
        IAsyncResult BeginRetryPipelineExecution(RetryPipelineExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RetryPipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetryPipelineExecution.</param>
        /// 
        /// <returns>Returns a  RetryPipelineExecutionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/RetryPipelineExecution">REST API Reference for RetryPipelineExecution Operation</seealso>
        RetryPipelineExecutionResponse EndRetryPipelineExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  Search


        /// <summary>
        /// Finds Amazon SageMaker resources that match a search query. Matching resources are
        /// returned as a list of <code>SearchRecord</code> objects in the response. You can sort
        /// the search results by any resource property in a ascending or descending order.
        /// 
        ///  
        /// <para>
        /// You can query against the following value types: numeric, text, Boolean, and timestamp.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Search service method.</param>
        /// 
        /// <returns>The response from the Search service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/Search">REST API Reference for Search Operation</seealso>
        SearchResponse Search(SearchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Search operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Search operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/Search">REST API Reference for Search Operation</seealso>
        IAsyncResult BeginSearch(SearchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Search operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearch.</param>
        /// 
        /// <returns>Returns a  SearchResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/Search">REST API Reference for Search Operation</seealso>
        SearchResponse EndSearch(IAsyncResult asyncResult);

        #endregion
        
        #region  SendPipelineExecutionStepFailure


        /// <summary>
        /// Notifies the pipeline that the execution of a callback step failed, along with a message
        /// describing why. When a callback step is run, the pipeline generates a callback token
        /// and includes the token in a message sent to Amazon Simple Queue Service (Amazon SQS).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendPipelineExecutionStepFailure service method.</param>
        /// 
        /// <returns>The response from the SendPipelineExecutionStepFailure service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/SendPipelineExecutionStepFailure">REST API Reference for SendPipelineExecutionStepFailure Operation</seealso>
        SendPipelineExecutionStepFailureResponse SendPipelineExecutionStepFailure(SendPipelineExecutionStepFailureRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendPipelineExecutionStepFailure operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendPipelineExecutionStepFailure operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendPipelineExecutionStepFailure
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/SendPipelineExecutionStepFailure">REST API Reference for SendPipelineExecutionStepFailure Operation</seealso>
        IAsyncResult BeginSendPipelineExecutionStepFailure(SendPipelineExecutionStepFailureRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendPipelineExecutionStepFailure operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendPipelineExecutionStepFailure.</param>
        /// 
        /// <returns>Returns a  SendPipelineExecutionStepFailureResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/SendPipelineExecutionStepFailure">REST API Reference for SendPipelineExecutionStepFailure Operation</seealso>
        SendPipelineExecutionStepFailureResponse EndSendPipelineExecutionStepFailure(IAsyncResult asyncResult);

        #endregion
        
        #region  SendPipelineExecutionStepSuccess


        /// <summary>
        /// Notifies the pipeline that the execution of a callback step succeeded and provides
        /// a list of the step's output parameters. When a callback step is run, the pipeline
        /// generates a callback token and includes the token in a message sent to Amazon Simple
        /// Queue Service (Amazon SQS).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendPipelineExecutionStepSuccess service method.</param>
        /// 
        /// <returns>The response from the SendPipelineExecutionStepSuccess service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/SendPipelineExecutionStepSuccess">REST API Reference for SendPipelineExecutionStepSuccess Operation</seealso>
        SendPipelineExecutionStepSuccessResponse SendPipelineExecutionStepSuccess(SendPipelineExecutionStepSuccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendPipelineExecutionStepSuccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendPipelineExecutionStepSuccess operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendPipelineExecutionStepSuccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/SendPipelineExecutionStepSuccess">REST API Reference for SendPipelineExecutionStepSuccess Operation</seealso>
        IAsyncResult BeginSendPipelineExecutionStepSuccess(SendPipelineExecutionStepSuccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendPipelineExecutionStepSuccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendPipelineExecutionStepSuccess.</param>
        /// 
        /// <returns>Returns a  SendPipelineExecutionStepSuccessResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/SendPipelineExecutionStepSuccess">REST API Reference for SendPipelineExecutionStepSuccess Operation</seealso>
        SendPipelineExecutionStepSuccessResponse EndSendPipelineExecutionStepSuccess(IAsyncResult asyncResult);

        #endregion
        
        #region  StartEdgeDeploymentStage


        /// <summary>
        /// Starts a stage in an edge deployment plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEdgeDeploymentStage service method.</param>
        /// 
        /// <returns>The response from the StartEdgeDeploymentStage service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartEdgeDeploymentStage">REST API Reference for StartEdgeDeploymentStage Operation</seealso>
        StartEdgeDeploymentStageResponse StartEdgeDeploymentStage(StartEdgeDeploymentStageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartEdgeDeploymentStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartEdgeDeploymentStage operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartEdgeDeploymentStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartEdgeDeploymentStage">REST API Reference for StartEdgeDeploymentStage Operation</seealso>
        IAsyncResult BeginStartEdgeDeploymentStage(StartEdgeDeploymentStageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartEdgeDeploymentStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartEdgeDeploymentStage.</param>
        /// 
        /// <returns>Returns a  StartEdgeDeploymentStageResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartEdgeDeploymentStage">REST API Reference for StartEdgeDeploymentStage Operation</seealso>
        StartEdgeDeploymentStageResponse EndStartEdgeDeploymentStage(IAsyncResult asyncResult);

        #endregion
        
        #region  StartInferenceExperiment


        /// <summary>
        /// Starts an inference experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInferenceExperiment service method.</param>
        /// 
        /// <returns>The response from the StartInferenceExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartInferenceExperiment">REST API Reference for StartInferenceExperiment Operation</seealso>
        StartInferenceExperimentResponse StartInferenceExperiment(StartInferenceExperimentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartInferenceExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInferenceExperiment operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartInferenceExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartInferenceExperiment">REST API Reference for StartInferenceExperiment Operation</seealso>
        IAsyncResult BeginStartInferenceExperiment(StartInferenceExperimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartInferenceExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartInferenceExperiment.</param>
        /// 
        /// <returns>Returns a  StartInferenceExperimentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartInferenceExperiment">REST API Reference for StartInferenceExperiment Operation</seealso>
        StartInferenceExperimentResponse EndStartInferenceExperiment(IAsyncResult asyncResult);

        #endregion
        
        #region  StartMonitoringSchedule


        /// <summary>
        /// Starts a previously stopped monitoring schedule.
        /// 
        ///  <note> 
        /// <para>
        /// By default, when you successfully create a new schedule, the status of a monitoring
        /// schedule is <code>scheduled</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMonitoringSchedule service method.</param>
        /// 
        /// <returns>The response from the StartMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartMonitoringSchedule">REST API Reference for StartMonitoringSchedule Operation</seealso>
        StartMonitoringScheduleResponse StartMonitoringSchedule(StartMonitoringScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMonitoringSchedule operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMonitoringSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartMonitoringSchedule">REST API Reference for StartMonitoringSchedule Operation</seealso>
        IAsyncResult BeginStartMonitoringSchedule(StartMonitoringScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMonitoringSchedule.</param>
        /// 
        /// <returns>Returns a  StartMonitoringScheduleResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartMonitoringSchedule">REST API Reference for StartMonitoringSchedule Operation</seealso>
        StartMonitoringScheduleResponse EndStartMonitoringSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  StartNotebookInstance


        /// <summary>
        /// Launches an ML compute instance with the latest version of the libraries and attaches
        /// your ML storage volume. After configuring the notebook instance, SageMaker sets the
        /// notebook instance status to <code>InService</code>. A notebook instance's status must
        /// be <code>InService</code> before you can connect to your Jupyter notebook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNotebookInstance service method.</param>
        /// 
        /// <returns>The response from the StartNotebookInstance service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartNotebookInstance">REST API Reference for StartNotebookInstance Operation</seealso>
        StartNotebookInstanceResponse StartNotebookInstance(StartNotebookInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartNotebookInstance operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartNotebookInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartNotebookInstance">REST API Reference for StartNotebookInstance Operation</seealso>
        IAsyncResult BeginStartNotebookInstance(StartNotebookInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartNotebookInstance.</param>
        /// 
        /// <returns>Returns a  StartNotebookInstanceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartNotebookInstance">REST API Reference for StartNotebookInstance Operation</seealso>
        StartNotebookInstanceResponse EndStartNotebookInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  StartPipelineExecution


        /// <summary>
        /// Starts a pipeline execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPipelineExecution service method.</param>
        /// 
        /// <returns>The response from the StartPipelineExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartPipelineExecution">REST API Reference for StartPipelineExecution Operation</seealso>
        StartPipelineExecutionResponse StartPipelineExecution(StartPipelineExecutionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartPipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartPipelineExecution operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartPipelineExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartPipelineExecution">REST API Reference for StartPipelineExecution Operation</seealso>
        IAsyncResult BeginStartPipelineExecution(StartPipelineExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartPipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartPipelineExecution.</param>
        /// 
        /// <returns>Returns a  StartPipelineExecutionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartPipelineExecution">REST API Reference for StartPipelineExecution Operation</seealso>
        StartPipelineExecutionResponse EndStartPipelineExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  StopAutoMLJob


        /// <summary>
        /// A method for forcing the termination of a running job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAutoMLJob service method.</param>
        /// 
        /// <returns>The response from the StopAutoMLJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopAutoMLJob">REST API Reference for StopAutoMLJob Operation</seealso>
        StopAutoMLJobResponse StopAutoMLJob(StopAutoMLJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopAutoMLJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopAutoMLJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopAutoMLJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopAutoMLJob">REST API Reference for StopAutoMLJob Operation</seealso>
        IAsyncResult BeginStopAutoMLJob(StopAutoMLJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopAutoMLJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopAutoMLJob.</param>
        /// 
        /// <returns>Returns a  StopAutoMLJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopAutoMLJob">REST API Reference for StopAutoMLJob Operation</seealso>
        StopAutoMLJobResponse EndStopAutoMLJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StopCompilationJob


        /// <summary>
        /// Stops a model compilation job.
        /// 
        ///  
        /// <para>
        ///  To stop a job, Amazon SageMaker sends the algorithm the SIGTERM signal. This gracefully
        /// shuts the job down. If the job hasn't stopped, it sends the SIGKILL signal.
        /// </para>
        ///  
        /// <para>
        /// When it receives a <code>StopCompilationJob</code> request, Amazon SageMaker changes
        /// the <a>CompilationJobSummary$CompilationJobStatus</a> of the job to <code>Stopping</code>.
        /// After Amazon SageMaker stops the job, it sets the <a>CompilationJobSummary$CompilationJobStatus</a>
        /// to <code>Stopped</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCompilationJob service method.</param>
        /// 
        /// <returns>The response from the StopCompilationJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopCompilationJob">REST API Reference for StopCompilationJob Operation</seealso>
        StopCompilationJobResponse StopCompilationJob(StopCompilationJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopCompilationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopCompilationJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopCompilationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopCompilationJob">REST API Reference for StopCompilationJob Operation</seealso>
        IAsyncResult BeginStopCompilationJob(StopCompilationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopCompilationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopCompilationJob.</param>
        /// 
        /// <returns>Returns a  StopCompilationJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopCompilationJob">REST API Reference for StopCompilationJob Operation</seealso>
        StopCompilationJobResponse EndStopCompilationJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StopEdgeDeploymentStage


        /// <summary>
        /// Stops a stage in an edge deployment plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEdgeDeploymentStage service method.</param>
        /// 
        /// <returns>The response from the StopEdgeDeploymentStage service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopEdgeDeploymentStage">REST API Reference for StopEdgeDeploymentStage Operation</seealso>
        StopEdgeDeploymentStageResponse StopEdgeDeploymentStage(StopEdgeDeploymentStageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopEdgeDeploymentStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopEdgeDeploymentStage operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopEdgeDeploymentStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopEdgeDeploymentStage">REST API Reference for StopEdgeDeploymentStage Operation</seealso>
        IAsyncResult BeginStopEdgeDeploymentStage(StopEdgeDeploymentStageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopEdgeDeploymentStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopEdgeDeploymentStage.</param>
        /// 
        /// <returns>Returns a  StopEdgeDeploymentStageResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopEdgeDeploymentStage">REST API Reference for StopEdgeDeploymentStage Operation</seealso>
        StopEdgeDeploymentStageResponse EndStopEdgeDeploymentStage(IAsyncResult asyncResult);

        #endregion
        
        #region  StopEdgePackagingJob


        /// <summary>
        /// Request to stop an edge packaging job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEdgePackagingJob service method.</param>
        /// 
        /// <returns>The response from the StopEdgePackagingJob service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopEdgePackagingJob">REST API Reference for StopEdgePackagingJob Operation</seealso>
        StopEdgePackagingJobResponse StopEdgePackagingJob(StopEdgePackagingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopEdgePackagingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopEdgePackagingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopEdgePackagingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopEdgePackagingJob">REST API Reference for StopEdgePackagingJob Operation</seealso>
        IAsyncResult BeginStopEdgePackagingJob(StopEdgePackagingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopEdgePackagingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopEdgePackagingJob.</param>
        /// 
        /// <returns>Returns a  StopEdgePackagingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopEdgePackagingJob">REST API Reference for StopEdgePackagingJob Operation</seealso>
        StopEdgePackagingJobResponse EndStopEdgePackagingJob(IAsyncResult asyncResult);

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
        /// are still available in CloudWatch. After the tuning job moves to the <code>Stopped</code>
        /// state, it releases all reserved resources for the tuning job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopHyperParameterTuningJob service method.</param>
        /// 
        /// <returns>The response from the StopHyperParameterTuningJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopHyperParameterTuningJob">REST API Reference for StopHyperParameterTuningJob Operation</seealso>
        StopHyperParameterTuningJobResponse StopHyperParameterTuningJob(StopHyperParameterTuningJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopHyperParameterTuningJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopHyperParameterTuningJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopHyperParameterTuningJob">REST API Reference for StopHyperParameterTuningJob Operation</seealso>
        IAsyncResult BeginStopHyperParameterTuningJob(StopHyperParameterTuningJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopHyperParameterTuningJob.</param>
        /// 
        /// <returns>Returns a  StopHyperParameterTuningJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopHyperParameterTuningJob">REST API Reference for StopHyperParameterTuningJob Operation</seealso>
        StopHyperParameterTuningJobResponse EndStopHyperParameterTuningJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StopInferenceExperiment


        /// <summary>
        /// Stops an inference experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopInferenceExperiment service method.</param>
        /// 
        /// <returns>The response from the StopInferenceExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopInferenceExperiment">REST API Reference for StopInferenceExperiment Operation</seealso>
        StopInferenceExperimentResponse StopInferenceExperiment(StopInferenceExperimentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopInferenceExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInferenceExperiment operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopInferenceExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopInferenceExperiment">REST API Reference for StopInferenceExperiment Operation</seealso>
        IAsyncResult BeginStopInferenceExperiment(StopInferenceExperimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopInferenceExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopInferenceExperiment.</param>
        /// 
        /// <returns>Returns a  StopInferenceExperimentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopInferenceExperiment">REST API Reference for StopInferenceExperiment Operation</seealso>
        StopInferenceExperimentResponse EndStopInferenceExperiment(IAsyncResult asyncResult);

        #endregion
        
        #region  StopInferenceRecommendationsJob


        /// <summary>
        /// Stops an Inference Recommender job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopInferenceRecommendationsJob service method.</param>
        /// 
        /// <returns>The response from the StopInferenceRecommendationsJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopInferenceRecommendationsJob">REST API Reference for StopInferenceRecommendationsJob Operation</seealso>
        StopInferenceRecommendationsJobResponse StopInferenceRecommendationsJob(StopInferenceRecommendationsJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopInferenceRecommendationsJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInferenceRecommendationsJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopInferenceRecommendationsJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopInferenceRecommendationsJob">REST API Reference for StopInferenceRecommendationsJob Operation</seealso>
        IAsyncResult BeginStopInferenceRecommendationsJob(StopInferenceRecommendationsJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopInferenceRecommendationsJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopInferenceRecommendationsJob.</param>
        /// 
        /// <returns>Returns a  StopInferenceRecommendationsJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopInferenceRecommendationsJob">REST API Reference for StopInferenceRecommendationsJob Operation</seealso>
        StopInferenceRecommendationsJobResponse EndStopInferenceRecommendationsJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StopLabelingJob


        /// <summary>
        /// Stops a running labeling job. A job that is stopped cannot be restarted. Any results
        /// obtained before the job is stopped are placed in the Amazon S3 output bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopLabelingJob service method.</param>
        /// 
        /// <returns>The response from the StopLabelingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopLabelingJob">REST API Reference for StopLabelingJob Operation</seealso>
        StopLabelingJobResponse StopLabelingJob(StopLabelingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopLabelingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopLabelingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopLabelingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopLabelingJob">REST API Reference for StopLabelingJob Operation</seealso>
        IAsyncResult BeginStopLabelingJob(StopLabelingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopLabelingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopLabelingJob.</param>
        /// 
        /// <returns>Returns a  StopLabelingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopLabelingJob">REST API Reference for StopLabelingJob Operation</seealso>
        StopLabelingJobResponse EndStopLabelingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StopMonitoringSchedule


        /// <summary>
        /// Stops a previously started monitoring schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopMonitoringSchedule service method.</param>
        /// 
        /// <returns>The response from the StopMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopMonitoringSchedule">REST API Reference for StopMonitoringSchedule Operation</seealso>
        StopMonitoringScheduleResponse StopMonitoringSchedule(StopMonitoringScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopMonitoringSchedule operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopMonitoringSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopMonitoringSchedule">REST API Reference for StopMonitoringSchedule Operation</seealso>
        IAsyncResult BeginStopMonitoringSchedule(StopMonitoringScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopMonitoringSchedule.</param>
        /// 
        /// <returns>Returns a  StopMonitoringScheduleResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopMonitoringSchedule">REST API Reference for StopMonitoringSchedule Operation</seealso>
        StopMonitoringScheduleResponse EndStopMonitoringSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  StopNotebookInstance


        /// <summary>
        /// Terminates the ML compute instance. Before terminating the instance, SageMaker disconnects
        /// the ML storage volume from it. SageMaker preserves the ML storage volume. SageMaker
        /// stops charging you for the ML compute instance when you call <code>StopNotebookInstance</code>.
        /// 
        ///  
        /// <para>
        /// To access data on the ML storage volume for a notebook instance that has been terminated,
        /// call the <code>StartNotebookInstance</code> API. <code>StartNotebookInstance</code>
        /// launches another ML compute instance, configures it, and attaches the preserved ML
        /// storage volume so you can continue your work. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopNotebookInstance service method.</param>
        /// 
        /// <returns>The response from the StopNotebookInstance service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopNotebookInstance">REST API Reference for StopNotebookInstance Operation</seealso>
        StopNotebookInstanceResponse StopNotebookInstance(StopNotebookInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopNotebookInstance operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopNotebookInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopNotebookInstance">REST API Reference for StopNotebookInstance Operation</seealso>
        IAsyncResult BeginStopNotebookInstance(StopNotebookInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopNotebookInstance.</param>
        /// 
        /// <returns>Returns a  StopNotebookInstanceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopNotebookInstance">REST API Reference for StopNotebookInstance Operation</seealso>
        StopNotebookInstanceResponse EndStopNotebookInstance(IAsyncResult asyncResult);

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
        /// A pipeline execution won't stop while a callback step is running. When you call <code>StopPipelineExecution</code>
        /// on a pipeline execution with a running callback step, SageMaker Pipelines sends an
        /// additional Amazon SQS message to the specified SQS queue. The body of the SQS message
        /// contains a "Status" field which is set to "Stopping".
        /// </para>
        ///  
        /// <para>
        /// You should add logic to your Amazon SQS message consumer to take any needed action
        /// (for example, resource cleanup) upon receipt of the message followed by a call to
        /// <code>SendPipelineExecutionStepSuccess</code> or <code>SendPipelineExecutionStepFailure</code>.
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
        /// Lambda function finishes, the pipeline execution status is <code>Stopped</code>. If
        /// the timeout is hit the pipeline execution status is <code>Failed</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopPipelineExecution service method.</param>
        /// 
        /// <returns>The response from the StopPipelineExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopPipelineExecution">REST API Reference for StopPipelineExecution Operation</seealso>
        StopPipelineExecutionResponse StopPipelineExecution(StopPipelineExecutionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopPipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopPipelineExecution operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopPipelineExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopPipelineExecution">REST API Reference for StopPipelineExecution Operation</seealso>
        IAsyncResult BeginStopPipelineExecution(StopPipelineExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopPipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopPipelineExecution.</param>
        /// 
        /// <returns>Returns a  StopPipelineExecutionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopPipelineExecution">REST API Reference for StopPipelineExecution Operation</seealso>
        StopPipelineExecutionResponse EndStopPipelineExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  StopProcessingJob


        /// <summary>
        /// Stops a processing job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopProcessingJob service method.</param>
        /// 
        /// <returns>The response from the StopProcessingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopProcessingJob">REST API Reference for StopProcessingJob Operation</seealso>
        StopProcessingJobResponse StopProcessingJob(StopProcessingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopProcessingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopProcessingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopProcessingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopProcessingJob">REST API Reference for StopProcessingJob Operation</seealso>
        IAsyncResult BeginStopProcessingJob(StopProcessingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopProcessingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopProcessingJob.</param>
        /// 
        /// <returns>Returns a  StopProcessingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopProcessingJob">REST API Reference for StopProcessingJob Operation</seealso>
        StopProcessingJobResponse EndStopProcessingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StopTrainingJob


        /// <summary>
        /// Stops a training job. To stop a job, SageMaker sends the algorithm the <code>SIGTERM</code>
        /// signal, which delays job termination for 120 seconds. Algorithms might use this 120-second
        /// window to save the model artifacts, so the results of the training is not lost. 
        /// 
        ///  
        /// <para>
        /// When it receives a <code>StopTrainingJob</code> request, SageMaker changes the status
        /// of the job to <code>Stopping</code>. After SageMaker stops the job, it sets the status
        /// to <code>Stopped</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTrainingJob service method.</param>
        /// 
        /// <returns>The response from the StopTrainingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTrainingJob">REST API Reference for StopTrainingJob Operation</seealso>
        StopTrainingJobResponse StopTrainingJob(StopTrainingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTrainingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTrainingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTrainingJob">REST API Reference for StopTrainingJob Operation</seealso>
        IAsyncResult BeginStopTrainingJob(StopTrainingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTrainingJob.</param>
        /// 
        /// <returns>Returns a  StopTrainingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTrainingJob">REST API Reference for StopTrainingJob Operation</seealso>
        StopTrainingJobResponse EndStopTrainingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StopTransformJob


        /// <summary>
        /// Stops a batch transform job.
        /// 
        ///  
        /// <para>
        /// When Amazon SageMaker receives a <code>StopTransformJob</code> request, the status
        /// of the job changes to <code>Stopping</code>. After Amazon SageMaker stops the job,
        /// the status is set to <code>Stopped</code>. When you stop a batch transform job before
        /// it is completed, Amazon SageMaker doesn't store the job's output in Amazon S3.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTransformJob service method.</param>
        /// 
        /// <returns>The response from the StopTransformJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTransformJob">REST API Reference for StopTransformJob Operation</seealso>
        StopTransformJobResponse StopTransformJob(StopTransformJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopTransformJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTransformJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTransformJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTransformJob">REST API Reference for StopTransformJob Operation</seealso>
        IAsyncResult BeginStopTransformJob(StopTransformJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopTransformJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTransformJob.</param>
        /// 
        /// <returns>Returns a  StopTransformJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTransformJob">REST API Reference for StopTransformJob Operation</seealso>
        StopTransformJobResponse EndStopTransformJob(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAction


        /// <summary>
        /// Updates an action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAction service method.</param>
        /// 
        /// <returns>The response from the UpdateAction service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateAction">REST API Reference for UpdateAction Operation</seealso>
        UpdateActionResponse UpdateAction(UpdateActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAction operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateAction">REST API Reference for UpdateAction Operation</seealso>
        IAsyncResult BeginUpdateAction(UpdateActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAction.</param>
        /// 
        /// <returns>Returns a  UpdateActionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateAction">REST API Reference for UpdateAction Operation</seealso>
        UpdateActionResponse EndUpdateAction(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAppImageConfig


        /// <summary>
        /// Updates the properties of an AppImageConfig.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppImageConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateAppImageConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateAppImageConfig">REST API Reference for UpdateAppImageConfig Operation</seealso>
        UpdateAppImageConfigResponse UpdateAppImageConfig(UpdateAppImageConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAppImageConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppImageConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAppImageConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateAppImageConfig">REST API Reference for UpdateAppImageConfig Operation</seealso>
        IAsyncResult BeginUpdateAppImageConfig(UpdateAppImageConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAppImageConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAppImageConfig.</param>
        /// 
        /// <returns>Returns a  UpdateAppImageConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateAppImageConfig">REST API Reference for UpdateAppImageConfig Operation</seealso>
        UpdateAppImageConfigResponse EndUpdateAppImageConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateArtifact


        /// <summary>
        /// Updates an artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateArtifact service method.</param>
        /// 
        /// <returns>The response from the UpdateArtifact service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateArtifact">REST API Reference for UpdateArtifact Operation</seealso>
        UpdateArtifactResponse UpdateArtifact(UpdateArtifactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateArtifact operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateArtifact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateArtifact">REST API Reference for UpdateArtifact Operation</seealso>
        IAsyncResult BeginUpdateArtifact(UpdateArtifactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateArtifact.</param>
        /// 
        /// <returns>Returns a  UpdateArtifactResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateArtifact">REST API Reference for UpdateArtifact Operation</seealso>
        UpdateArtifactResponse EndUpdateArtifact(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCodeRepository


        /// <summary>
        /// Updates the specified Git repository with the specified values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeRepository service method.</param>
        /// 
        /// <returns>The response from the UpdateCodeRepository service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateCodeRepository">REST API Reference for UpdateCodeRepository Operation</seealso>
        UpdateCodeRepositoryResponse UpdateCodeRepository(UpdateCodeRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeRepository operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCodeRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateCodeRepository">REST API Reference for UpdateCodeRepository Operation</seealso>
        IAsyncResult BeginUpdateCodeRepository(UpdateCodeRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCodeRepository.</param>
        /// 
        /// <returns>Returns a  UpdateCodeRepositoryResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateCodeRepository">REST API Reference for UpdateCodeRepository Operation</seealso>
        UpdateCodeRepositoryResponse EndUpdateCodeRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateContext


        /// <summary>
        /// Updates a context.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContext service method.</param>
        /// 
        /// <returns>The response from the UpdateContext service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateContext">REST API Reference for UpdateContext Operation</seealso>
        UpdateContextResponse UpdateContext(UpdateContextRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContext operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContext operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContext
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateContext">REST API Reference for UpdateContext Operation</seealso>
        IAsyncResult BeginUpdateContext(UpdateContextRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContext operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContext.</param>
        /// 
        /// <returns>Returns a  UpdateContextResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateContext">REST API Reference for UpdateContext Operation</seealso>
        UpdateContextResponse EndUpdateContext(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDeviceFleet


        /// <summary>
        /// Updates a fleet of devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceFleet service method.</param>
        /// 
        /// <returns>The response from the UpdateDeviceFleet service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateDeviceFleet">REST API Reference for UpdateDeviceFleet Operation</seealso>
        UpdateDeviceFleetResponse UpdateDeviceFleet(UpdateDeviceFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeviceFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceFleet operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDeviceFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateDeviceFleet">REST API Reference for UpdateDeviceFleet Operation</seealso>
        IAsyncResult BeginUpdateDeviceFleet(UpdateDeviceFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDeviceFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDeviceFleet.</param>
        /// 
        /// <returns>Returns a  UpdateDeviceFleetResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateDeviceFleet">REST API Reference for UpdateDeviceFleet Operation</seealso>
        UpdateDeviceFleetResponse EndUpdateDeviceFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDevices


        /// <summary>
        /// Updates one or more devices in a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevices service method.</param>
        /// 
        /// <returns>The response from the UpdateDevices service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateDevices">REST API Reference for UpdateDevices Operation</seealso>
        UpdateDevicesResponse UpdateDevices(UpdateDevicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevices operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateDevices">REST API Reference for UpdateDevices Operation</seealso>
        IAsyncResult BeginUpdateDevices(UpdateDevicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDevices.</param>
        /// 
        /// <returns>Returns a  UpdateDevicesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateDevices">REST API Reference for UpdateDevices Operation</seealso>
        UpdateDevicesResponse EndUpdateDevices(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDomain


        /// <summary>
        /// Updates the default settings for new user profiles in the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomain service method.</param>
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
        UpdateDomainResponse UpdateDomain(UpdateDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomain operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        IAsyncResult BeginUpdateDomain(UpdateDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomain.</param>
        /// 
        /// <returns>Returns a  UpdateDomainResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        UpdateDomainResponse EndUpdateDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEndpoint


        /// <summary>
        /// Deploys the new <code>EndpointConfig</code> specified in the request, switches to
        /// using newly created endpoint, and then deletes resources provisioned for the endpoint
        /// using the previous <code>EndpointConfig</code> (there is no availability loss). 
        /// 
        ///  
        /// <para>
        /// When SageMaker receives the request, it sets the endpoint status to <code>Updating</code>.
        /// After updating the endpoint, it sets the status to <code>InService</code>. To check
        /// the status of an endpoint, use the <a>DescribeEndpoint</a> API. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You must not delete an <code>EndpointConfig</code> in use by an endpoint that is live
        /// or while the <code>UpdateEndpoint</code> or <code>CreateEndpoint</code> operations
        /// are being performed on the endpoint. To update an endpoint, you must create a new
        /// <code>EndpointConfig</code>.
        /// </para>
        ///  
        /// <para>
        /// If you delete the <code>EndpointConfig</code> of an endpoint that is active or being
        /// created or updated you may lose visibility into the instance type the endpoint is
        /// using. The endpoint must be deleted in order to stop incurring charges.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateEndpoint service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        UpdateEndpointResponse UpdateEndpoint(UpdateEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        IAsyncResult BeginUpdateEndpoint(UpdateEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        UpdateEndpointResponse EndUpdateEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEndpointWeightsAndCapacities


        /// <summary>
        /// Updates variant weight of one or more variants associated with an existing endpoint,
        /// or capacity of one variant associated with an existing endpoint. When it receives
        /// the request, SageMaker sets the endpoint status to <code>Updating</code>. After updating
        /// the endpoint, it sets the status to <code>InService</code>. To check the status of
        /// an endpoint, use the <a>DescribeEndpoint</a> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointWeightsAndCapacities service method.</param>
        /// 
        /// <returns>The response from the UpdateEndpointWeightsAndCapacities service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpointWeightsAndCapacities">REST API Reference for UpdateEndpointWeightsAndCapacities Operation</seealso>
        UpdateEndpointWeightsAndCapacitiesResponse UpdateEndpointWeightsAndCapacities(UpdateEndpointWeightsAndCapacitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpointWeightsAndCapacities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointWeightsAndCapacities operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEndpointWeightsAndCapacities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpointWeightsAndCapacities">REST API Reference for UpdateEndpointWeightsAndCapacities Operation</seealso>
        IAsyncResult BeginUpdateEndpointWeightsAndCapacities(UpdateEndpointWeightsAndCapacitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpointWeightsAndCapacities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpointWeightsAndCapacities.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointWeightsAndCapacitiesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpointWeightsAndCapacities">REST API Reference for UpdateEndpointWeightsAndCapacities Operation</seealso>
        UpdateEndpointWeightsAndCapacitiesResponse EndUpdateEndpointWeightsAndCapacities(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateExperiment


        /// <summary>
        /// Adds, updates, or removes the description of an experiment. Updates the display name
        /// of an experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperiment service method.</param>
        /// 
        /// <returns>The response from the UpdateExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateExperiment">REST API Reference for UpdateExperiment Operation</seealso>
        UpdateExperimentResponse UpdateExperiment(UpdateExperimentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperiment operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateExperiment">REST API Reference for UpdateExperiment Operation</seealso>
        IAsyncResult BeginUpdateExperiment(UpdateExperimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateExperiment.</param>
        /// 
        /// <returns>Returns a  UpdateExperimentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateExperiment">REST API Reference for UpdateExperiment Operation</seealso>
        UpdateExperimentResponse EndUpdateExperiment(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFeatureGroup


        /// <summary>
        /// Updates the feature group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFeatureGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateFeatureGroup service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateFeatureGroup">REST API Reference for UpdateFeatureGroup Operation</seealso>
        UpdateFeatureGroupResponse UpdateFeatureGroup(UpdateFeatureGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFeatureGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFeatureGroup operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFeatureGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateFeatureGroup">REST API Reference for UpdateFeatureGroup Operation</seealso>
        IAsyncResult BeginUpdateFeatureGroup(UpdateFeatureGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFeatureGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFeatureGroup.</param>
        /// 
        /// <returns>Returns a  UpdateFeatureGroupResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateFeatureGroup">REST API Reference for UpdateFeatureGroup Operation</seealso>
        UpdateFeatureGroupResponse EndUpdateFeatureGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFeatureMetadata


        /// <summary>
        /// Updates the description and parameters of the feature group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFeatureMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateFeatureMetadata service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateFeatureMetadata">REST API Reference for UpdateFeatureMetadata Operation</seealso>
        UpdateFeatureMetadataResponse UpdateFeatureMetadata(UpdateFeatureMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFeatureMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFeatureMetadata operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFeatureMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateFeatureMetadata">REST API Reference for UpdateFeatureMetadata Operation</seealso>
        IAsyncResult BeginUpdateFeatureMetadata(UpdateFeatureMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFeatureMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFeatureMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateFeatureMetadataResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateFeatureMetadata">REST API Reference for UpdateFeatureMetadata Operation</seealso>
        UpdateFeatureMetadataResponse EndUpdateFeatureMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateHub


        /// <summary>
        /// Update a hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHub service method.</param>
        /// 
        /// <returns>The response from the UpdateHub service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateHub">REST API Reference for UpdateHub Operation</seealso>
        UpdateHubResponse UpdateHub(UpdateHubRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHub operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHub operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateHub
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateHub">REST API Reference for UpdateHub Operation</seealso>
        IAsyncResult BeginUpdateHub(UpdateHubRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateHub operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateHub.</param>
        /// 
        /// <returns>Returns a  UpdateHubResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateHub">REST API Reference for UpdateHub Operation</seealso>
        UpdateHubResponse EndUpdateHub(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateImage


        /// <summary>
        /// Updates the properties of a SageMaker image. To change the image's tags, use the <a>AddTags</a>
        /// and <a>DeleteTags</a> APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateImage service method.</param>
        /// 
        /// <returns>The response from the UpdateImage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateImage">REST API Reference for UpdateImage Operation</seealso>
        UpdateImageResponse UpdateImage(UpdateImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateImage operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateImage">REST API Reference for UpdateImage Operation</seealso>
        IAsyncResult BeginUpdateImage(UpdateImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateImage.</param>
        /// 
        /// <returns>Returns a  UpdateImageResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateImage">REST API Reference for UpdateImage Operation</seealso>
        UpdateImageResponse EndUpdateImage(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateImageVersion


        /// <summary>
        /// Updates the properties of a SageMaker image version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateImageVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateImageVersion service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateImageVersion">REST API Reference for UpdateImageVersion Operation</seealso>
        UpdateImageVersionResponse UpdateImageVersion(UpdateImageVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateImageVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateImageVersion operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateImageVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateImageVersion">REST API Reference for UpdateImageVersion Operation</seealso>
        IAsyncResult BeginUpdateImageVersion(UpdateImageVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateImageVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateImageVersion.</param>
        /// 
        /// <returns>Returns a  UpdateImageVersionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateImageVersion">REST API Reference for UpdateImageVersion Operation</seealso>
        UpdateImageVersionResponse EndUpdateImageVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateInferenceExperiment


        /// <summary>
        /// Updates an inference experiment that you created. The status of the inference experiment
        /// has to be either <code>Created</code>, <code>Running</code>. For more information
        /// on the status of an inference experiment, see <a>DescribeInferenceExperimentResponse$Status</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInferenceExperiment service method.</param>
        /// 
        /// <returns>The response from the UpdateInferenceExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateInferenceExperiment">REST API Reference for UpdateInferenceExperiment Operation</seealso>
        UpdateInferenceExperimentResponse UpdateInferenceExperiment(UpdateInferenceExperimentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInferenceExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInferenceExperiment operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInferenceExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateInferenceExperiment">REST API Reference for UpdateInferenceExperiment Operation</seealso>
        IAsyncResult BeginUpdateInferenceExperiment(UpdateInferenceExperimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInferenceExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInferenceExperiment.</param>
        /// 
        /// <returns>Returns a  UpdateInferenceExperimentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateInferenceExperiment">REST API Reference for UpdateInferenceExperiment Operation</seealso>
        UpdateInferenceExperimentResponse EndUpdateInferenceExperiment(IAsyncResult asyncResult);

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
        /// 
        /// <returns>The response from the UpdateModelCard service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateModelCard">REST API Reference for UpdateModelCard Operation</seealso>
        UpdateModelCardResponse UpdateModelCard(UpdateModelCardRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateModelCard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelCard operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateModelCard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateModelCard">REST API Reference for UpdateModelCard Operation</seealso>
        IAsyncResult BeginUpdateModelCard(UpdateModelCardRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateModelCard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateModelCard.</param>
        /// 
        /// <returns>Returns a  UpdateModelCardResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateModelCard">REST API Reference for UpdateModelCard Operation</seealso>
        UpdateModelCardResponse EndUpdateModelCard(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateModelPackage


        /// <summary>
        /// Updates a versioned model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelPackage service method.</param>
        /// 
        /// <returns>The response from the UpdateModelPackage service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateModelPackage">REST API Reference for UpdateModelPackage Operation</seealso>
        UpdateModelPackageResponse UpdateModelPackage(UpdateModelPackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateModelPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelPackage operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateModelPackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateModelPackage">REST API Reference for UpdateModelPackage Operation</seealso>
        IAsyncResult BeginUpdateModelPackage(UpdateModelPackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateModelPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateModelPackage.</param>
        /// 
        /// <returns>Returns a  UpdateModelPackageResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateModelPackage">REST API Reference for UpdateModelPackage Operation</seealso>
        UpdateModelPackageResponse EndUpdateModelPackage(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMonitoringAlert


        /// <summary>
        /// Update the parameters of a model monitor alert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitoringAlert service method.</param>
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
        UpdateMonitoringAlertResponse UpdateMonitoringAlert(UpdateMonitoringAlertRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMonitoringAlert operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitoringAlert operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMonitoringAlert
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateMonitoringAlert">REST API Reference for UpdateMonitoringAlert Operation</seealso>
        IAsyncResult BeginUpdateMonitoringAlert(UpdateMonitoringAlertRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMonitoringAlert operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMonitoringAlert.</param>
        /// 
        /// <returns>Returns a  UpdateMonitoringAlertResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateMonitoringAlert">REST API Reference for UpdateMonitoringAlert Operation</seealso>
        UpdateMonitoringAlertResponse EndUpdateMonitoringAlert(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMonitoringSchedule


        /// <summary>
        /// Updates a previously created schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitoringSchedule service method.</param>
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
        UpdateMonitoringScheduleResponse UpdateMonitoringSchedule(UpdateMonitoringScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitoringSchedule operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMonitoringSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateMonitoringSchedule">REST API Reference for UpdateMonitoringSchedule Operation</seealso>
        IAsyncResult BeginUpdateMonitoringSchedule(UpdateMonitoringScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMonitoringSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMonitoringSchedule.</param>
        /// 
        /// <returns>Returns a  UpdateMonitoringScheduleResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateMonitoringSchedule">REST API Reference for UpdateMonitoringSchedule Operation</seealso>
        UpdateMonitoringScheduleResponse EndUpdateMonitoringSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateNotebookInstance


        /// <summary>
        /// Updates a notebook instance. NotebookInstance updates include upgrading or downgrading
        /// the ML compute instance used for your notebook instance to accommodate changes in
        /// your workload requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstance service method.</param>
        /// 
        /// <returns>The response from the UpdateNotebookInstance service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstance">REST API Reference for UpdateNotebookInstance Operation</seealso>
        UpdateNotebookInstanceResponse UpdateNotebookInstance(UpdateNotebookInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstance operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNotebookInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstance">REST API Reference for UpdateNotebookInstance Operation</seealso>
        IAsyncResult BeginUpdateNotebookInstance(UpdateNotebookInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNotebookInstance.</param>
        /// 
        /// <returns>Returns a  UpdateNotebookInstanceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstance">REST API Reference for UpdateNotebookInstance Operation</seealso>
        UpdateNotebookInstanceResponse EndUpdateNotebookInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateNotebookInstanceLifecycleConfig


        /// <summary>
        /// Updates a notebook instance lifecycle configuration created with the <a>CreateNotebookInstanceLifecycleConfig</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstanceLifecycleConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateNotebookInstanceLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstanceLifecycleConfig">REST API Reference for UpdateNotebookInstanceLifecycleConfig Operation</seealso>
        UpdateNotebookInstanceLifecycleConfigResponse UpdateNotebookInstanceLifecycleConfig(UpdateNotebookInstanceLifecycleConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstanceLifecycleConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNotebookInstanceLifecycleConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstanceLifecycleConfig">REST API Reference for UpdateNotebookInstanceLifecycleConfig Operation</seealso>
        IAsyncResult BeginUpdateNotebookInstanceLifecycleConfig(UpdateNotebookInstanceLifecycleConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNotebookInstanceLifecycleConfig.</param>
        /// 
        /// <returns>Returns a  UpdateNotebookInstanceLifecycleConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstanceLifecycleConfig">REST API Reference for UpdateNotebookInstanceLifecycleConfig Operation</seealso>
        UpdateNotebookInstanceLifecycleConfigResponse EndUpdateNotebookInstanceLifecycleConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePipeline


        /// <summary>
        /// Updates a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline service method.</param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        IAsyncResult BeginUpdatePipeline(UpdatePipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePipeline.</param>
        /// 
        /// <returns>Returns a  UpdatePipelineResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        UpdatePipelineResponse EndUpdatePipeline(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePipelineExecution


        /// <summary>
        /// Updates a pipeline execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineExecution service method.</param>
        /// 
        /// <returns>The response from the UpdatePipelineExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdatePipelineExecution">REST API Reference for UpdatePipelineExecution Operation</seealso>
        UpdatePipelineExecutionResponse UpdatePipelineExecution(UpdatePipelineExecutionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineExecution operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePipelineExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdatePipelineExecution">REST API Reference for UpdatePipelineExecution Operation</seealso>
        IAsyncResult BeginUpdatePipelineExecution(UpdatePipelineExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePipelineExecution.</param>
        /// 
        /// <returns>Returns a  UpdatePipelineExecutionResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdatePipelineExecution">REST API Reference for UpdatePipelineExecution Operation</seealso>
        UpdatePipelineExecutionResponse EndUpdatePipelineExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProject


        /// <summary>
        /// Updates a machine learning (ML) project that is created from a template that sets
        /// up an ML pipeline from training to deploying an approved model.
        /// 
        ///  <note> 
        /// <para>
        /// You must not update a project that is in use. If you update the <code>ServiceCatalogProvisioningUpdateDetails</code>
        /// of a project that is active or being created, or updated, you may lose resources already
        /// created by the project.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        UpdateProjectResponse UpdateProject(UpdateProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        IAsyncResult BeginUpdateProject(UpdateProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProject.</param>
        /// 
        /// <returns>Returns a  UpdateProjectResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        UpdateProjectResponse EndUpdateProject(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSpace


        /// <summary>
        /// Updates the settings of a space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSpace service method.</param>
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
        UpdateSpaceResponse UpdateSpace(UpdateSpaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSpace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSpace operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSpace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateSpace">REST API Reference for UpdateSpace Operation</seealso>
        IAsyncResult BeginUpdateSpace(UpdateSpaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSpace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSpace.</param>
        /// 
        /// <returns>Returns a  UpdateSpaceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateSpace">REST API Reference for UpdateSpace Operation</seealso>
        UpdateSpaceResponse EndUpdateSpace(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTrainingJob


        /// <summary>
        /// Update a model training job to request a new Debugger profiling configuration or to
        /// change warm pool retention length.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrainingJob service method.</param>
        /// 
        /// <returns>The response from the UpdateTrainingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrainingJob">REST API Reference for UpdateTrainingJob Operation</seealso>
        UpdateTrainingJobResponse UpdateTrainingJob(UpdateTrainingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrainingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTrainingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrainingJob">REST API Reference for UpdateTrainingJob Operation</seealso>
        IAsyncResult BeginUpdateTrainingJob(UpdateTrainingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTrainingJob.</param>
        /// 
        /// <returns>Returns a  UpdateTrainingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrainingJob">REST API Reference for UpdateTrainingJob Operation</seealso>
        UpdateTrainingJobResponse EndUpdateTrainingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTrial


        /// <summary>
        /// Updates the display name of a trial.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrial service method.</param>
        /// 
        /// <returns>The response from the UpdateTrial service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrial">REST API Reference for UpdateTrial Operation</seealso>
        UpdateTrialResponse UpdateTrial(UpdateTrialRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrial operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrial operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTrial
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrial">REST API Reference for UpdateTrial Operation</seealso>
        IAsyncResult BeginUpdateTrial(UpdateTrialRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTrial operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTrial.</param>
        /// 
        /// <returns>Returns a  UpdateTrialResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrial">REST API Reference for UpdateTrial Operation</seealso>
        UpdateTrialResponse EndUpdateTrial(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTrialComponent


        /// <summary>
        /// Updates one or more properties of a trial component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrialComponent service method.</param>
        /// 
        /// <returns>The response from the UpdateTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrialComponent">REST API Reference for UpdateTrialComponent Operation</seealso>
        UpdateTrialComponentResponse UpdateTrialComponent(UpdateTrialComponentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrialComponent operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTrialComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrialComponent">REST API Reference for UpdateTrialComponent Operation</seealso>
        IAsyncResult BeginUpdateTrialComponent(UpdateTrialComponentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTrialComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTrialComponent.</param>
        /// 
        /// <returns>Returns a  UpdateTrialComponentResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrialComponent">REST API Reference for UpdateTrialComponent Operation</seealso>
        UpdateTrialComponentResponse EndUpdateTrialComponent(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUserProfile


        /// <summary>
        /// Updates a user profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile service method.</param>
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
        UpdateUserProfileResponse UpdateUserProfile(UpdateUserProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        IAsyncResult BeginUpdateUserProfile(UpdateUserProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserProfile.</param>
        /// 
        /// <returns>Returns a  UpdateUserProfileResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        UpdateUserProfileResponse EndUpdateUserProfile(IAsyncResult asyncResult);

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
        ///  Use <code>SourceIpConfig</code> to restrict worker access to tasks to a specific
        /// range of IP addresses. You specify allowed IP addresses by creating a list of up to
        /// ten <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">CIDRs</a>.
        /// By default, a workforce isn't restricted to specific IP addresses. If you specify
        /// a range of IP addresses, workers who attempt to access tasks using any IP address
        /// outside the specified range are denied and get a <code>Not Found</code> error message
        /// on the worker portal.
        /// </para>
        ///  
        /// <para>
        /// To restrict access to all the workers in public internet, add the <code>SourceIpConfig</code>
        /// CIDR value as "0.0.0.0/0".
        /// </para>
        ///  <important> 
        /// <para>
        /// Amazon SageMaker does not support Source Ip restriction for worker portals in VPC.
        /// </para>
        ///  </important> 
        /// <para>
        /// Use <code>OidcConfig</code> to update the configuration of a workforce created using
        /// your own OIDC IdP. 
        /// </para>
        ///  <important> 
        /// <para>
        /// You can only update your OIDC IdP configuration when there are no work teams associated
        /// with your workforce. You can delete work teams using the operation.
        /// </para>
        ///  </important> 
        /// <para>
        /// After restricting access to a range of IP addresses or updating your OIDC IdP configuration
        /// with this operation, you can view details about your update workforce using the operation.
        /// </para>
        ///  <important> 
        /// <para>
        /// This operation only applies to private workforces.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkforce service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkforce service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateWorkforce">REST API Reference for UpdateWorkforce Operation</seealso>
        UpdateWorkforceResponse UpdateWorkforce(UpdateWorkforceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkforce operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkforce operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkforce
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateWorkforce">REST API Reference for UpdateWorkforce Operation</seealso>
        IAsyncResult BeginUpdateWorkforce(UpdateWorkforceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkforce operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkforce.</param>
        /// 
        /// <returns>Returns a  UpdateWorkforceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateWorkforce">REST API Reference for UpdateWorkforce Operation</seealso>
        UpdateWorkforceResponse EndUpdateWorkforce(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWorkteam


        /// <summary>
        /// Updates an existing work team with new member definitions or description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkteam service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkteam service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateWorkteam">REST API Reference for UpdateWorkteam Operation</seealso>
        UpdateWorkteamResponse UpdateWorkteam(UpdateWorkteamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkteam operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkteam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateWorkteam">REST API Reference for UpdateWorkteam Operation</seealso>
        IAsyncResult BeginUpdateWorkteam(UpdateWorkteamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkteam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkteam.</param>
        /// 
        /// <returns>Returns a  UpdateWorkteamResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateWorkteam">REST API Reference for UpdateWorkteam Operation</seealso>
        UpdateWorkteamResponse EndUpdateWorkteam(IAsyncResult asyncResult);

        #endregion
        
    }
}