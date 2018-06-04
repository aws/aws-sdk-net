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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SageMaker.Model;

namespace Amazon.SageMaker
{
    /// <summary>
    /// Interface for accessing SageMaker
    ///
    /// Definition of the public APIs exposed by SageMaker
    /// </summary>
    public partial interface IAmazonSageMaker : IAmazonService, IDisposable
    {

        
        #region  AddTags


        /// <summary>
        /// Adds or overwrites one or more tags for the specified Amazon SageMaker resource. You
        /// can add tags to notebook instances, training jobs, models, endpoint configurations,
        /// and endpoints. 
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and an optional value. Tag keys must be unique per resource.
        /// For more information about tags, see <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html#allocation-what">Using
        /// Cost Allocation Tags</a> in the <i>AWS Billing and Cost Management User Guide</i>.
        /// 
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AddTags">REST API Reference for AddTags Operation</seealso>
        Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateEndpoint


        /// <summary>
        /// Creates an endpoint using the endpoint configuration specified in the request. Amazon
        /// SageMaker uses the endpoint to provision resources and deploy models. You create the
        /// endpoint configuration with the <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_CreateEndpointConfig.html">CreateEndpointConfig</a>
        /// API. 
        /// 
        ///  <note> 
        /// <para>
        ///  Use this API only for hosting models using Amazon SageMaker hosting services. 
        /// </para>
        ///  </note> 
        /// <para>
        /// The endpoint name must be unique within an AWS Region in your AWS account. 
        /// </para>
        ///  
        /// <para>
        /// When it receives the request, Amazon SageMaker creates the endpoint, launches the
        /// resources (ML compute instances), and deploys the model(s) on them. 
        /// </para>
        ///  
        /// <para>
        /// When Amazon SageMaker receives the request, it sets the endpoint status to <code>Creating</code>.
        /// After it creates the endpoint, it sets the status to <code>InService</code>. Amazon
        /// SageMaker can then process incoming requests for inferences. To check the status of
        /// an endpoint, use the <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_DescribeEndpoint.html">DescribeEndpoint</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// For an example, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/ex1.html">Exercise
        /// 1: Using the K-Means Algorithm Provided by Amazon SageMaker</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateEndpoint service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        CreateEndpointResponse CreateEndpoint(CreateEndpointRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateEndpointConfig


        /// <summary>
        /// Creates an endpoint configuration that Amazon SageMaker hosting services uses to deploy
        /// models. In the configuration, you identify one or more models, created using the <code>CreateModel</code>
        /// API, to deploy and the resources that you want Amazon SageMaker to provision. Then
        /// you call the <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_CreateEndpoint.html">CreateEndpoint</a>
        /// API.
        /// 
        ///  <note> 
        /// <para>
        ///  Use this API only if you want to use Amazon SageMaker hosting services to deploy
        /// models into production. 
        /// </para>
        ///  </note> 
        /// <para>
        /// In the request, you define one or more <code>ProductionVariant</code>s, each of which
        /// identifies a model. Each <code>ProductionVariant</code> parameter also describes the
        /// resources that you want Amazon SageMaker to provision. This includes the number and
        /// type of ML compute instances to deploy. 
        /// </para>
        ///  
        /// <para>
        /// If you are hosting multiple models, you also assign a <code>VariantWeight</code> to
        /// specify how much traffic you want to allocate to each model. For example, suppose
        /// that you want to host two models, A and B, and you assign traffic weight 2 for model
        /// A and 1 for model B. Amazon SageMaker distributes two-thirds of the traffic to Model
        /// A, and one-third to model B. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointConfig service method.</param>
        /// 
        /// <returns>The response from the CreateEndpointConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpointConfig">REST API Reference for CreateEndpointConfig Operation</seealso>
        CreateEndpointConfigResponse CreateEndpointConfig(CreateEndpointConfigRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpointConfig">REST API Reference for CreateEndpointConfig Operation</seealso>
        Task<CreateEndpointConfigResponse> CreateEndpointConfigAsync(CreateEndpointConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateHyperParameterTuningJob


        /// <summary>
        /// Starts a hyperparameter tuning job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHyperParameterTuningJob service method.</param>
        /// 
        /// <returns>The response from the CreateHyperParameterTuningJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHyperParameterTuningJob">REST API Reference for CreateHyperParameterTuningJob Operation</seealso>
        CreateHyperParameterTuningJobResponse CreateHyperParameterTuningJob(CreateHyperParameterTuningJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHyperParameterTuningJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHyperParameterTuningJob">REST API Reference for CreateHyperParameterTuningJob Operation</seealso>
        Task<CreateHyperParameterTuningJobResponse> CreateHyperParameterTuningJobAsync(CreateHyperParameterTuningJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateModel


        /// <summary>
        /// Creates a model in Amazon SageMaker. In the request, you name the model and describe
        /// one or more containers. For each container, you specify the docker image containing
        /// inference code, artifacts (from prior training), and custom environment map that the
        /// inference code uses when you deploy the model into production. 
        /// 
        ///  
        /// <para>
        /// Use this API to create a model only if you want to use Amazon SageMaker hosting services.
        /// To host your model, you create an endpoint configuration with the <code>CreateEndpointConfig</code>
        /// API, and then create an endpoint with the <code>CreateEndpoint</code> API. 
        /// </para>
        ///  
        /// <para>
        /// Amazon SageMaker then deploys all of the containers that you defined for the model
        /// in the hosting environment. 
        /// </para>
        ///  
        /// <para>
        /// In the <code>CreateModel</code> request, you must define a container with the <code>PrimaryContainer</code>
        /// parameter. 
        /// </para>
        ///  
        /// <para>
        /// In the request, you also provide an IAM role that Amazon SageMaker can assume to access
        /// model artifacts and docker image for deployment on ML compute hosting instances. In
        /// addition, you also use the IAM role to manage permissions the inference code needs.
        /// For example, if the inference code access any other AWS resources, you grant necessary
        /// permissions via this role.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// 
        /// <returns>The response from the CreateModel service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModel">REST API Reference for CreateModel Operation</seealso>
        CreateModelResponse CreateModel(CreateModelRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModel">REST API Reference for CreateModel Operation</seealso>
        Task<CreateModelResponse> CreateModelAsync(CreateModelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateNotebookInstance


        /// <summary>
        /// Creates an Amazon SageMaker notebook instance. A notebook instance is a machine learning
        /// (ML) compute instance running on a Jupyter notebook. 
        /// 
        ///  
        /// <para>
        /// In a <code>CreateNotebookInstance</code> request, specify the type of ML compute instance
        /// that you want to run. Amazon SageMaker launches the instance, installs common libraries
        /// that you can use to explore datasets for model training, and attaches an ML storage
        /// volume to the notebook instance. 
        /// </para>
        ///  
        /// <para>
        /// Amazon SageMaker also provides a set of example notebooks. Each notebook demonstrates
        /// how to use Amazon SageMaker with a specific algorithm or with a machine learning framework.
        /// 
        /// </para>
        ///  
        /// <para>
        /// After receiving the request, Amazon SageMaker does the following:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Creates a network interface in the Amazon SageMaker VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Option) If you specified <code>SubnetId</code>, Amazon SageMaker creates a network
        /// interface in your own VPC, which is inferred from the subnet ID that you provide in
        /// the input. When creating this network interface, Amazon SageMaker attaches the security
        /// group that you specified in the request to the network interface that it creates in
        /// your VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Launches an EC2 instance of the type specified in the request in the Amazon SageMaker
        /// VPC. If you specified <code>SubnetId</code> of your VPC, Amazon SageMaker specifies
        /// both network interfaces when launching this instance. This enables inbound traffic
        /// from your own VPC to the notebook instance, assuming that the security groups allow
        /// it.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// After creating the notebook instance, Amazon SageMaker returns its Amazon Resource
        /// Name (ARN).
        /// </para>
        ///  
        /// <para>
        /// After Amazon SageMaker creates the notebook instance, you can connect to the Jupyter
        /// server and work in Jupyter notebooks. For example, you can write code to explore a
        /// dataset that you can use for model training, train a model, host models by creating
        /// Amazon SageMaker endpoints, and validate hosted models. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
        /// It Works</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebookInstance service method.</param>
        /// 
        /// <returns>The response from the CreateNotebookInstance service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstance">REST API Reference for CreateNotebookInstance Operation</seealso>
        CreateNotebookInstanceResponse CreateNotebookInstance(CreateNotebookInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebookInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstance">REST API Reference for CreateNotebookInstance Operation</seealso>
        Task<CreateNotebookInstanceResponse> CreateNotebookInstanceAsync(CreateNotebookInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// For information about notebook instance lifestyle configurations, see <a>notebook-lifecycle-config</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebookInstanceLifecycleConfig service method.</param>
        /// 
        /// <returns>The response from the CreateNotebookInstanceLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstanceLifecycleConfig">REST API Reference for CreateNotebookInstanceLifecycleConfig Operation</seealso>
        CreateNotebookInstanceLifecycleConfigResponse CreateNotebookInstanceLifecycleConfig(CreateNotebookInstanceLifecycleConfigRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebookInstanceLifecycleConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstanceLifecycleConfig">REST API Reference for CreateNotebookInstanceLifecycleConfig Operation</seealso>
        Task<CreateNotebookInstanceLifecycleConfigResponse> CreateNotebookInstanceLifecycleConfigAsync(CreateNotebookInstanceLifecycleConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePresignedNotebookInstanceUrl


        /// <summary>
        /// Returns a URL that you can use to connect to the Jupyter server from a notebook instance.
        /// In the Amazon SageMaker console, when you choose <code>Open</code> next to a notebook
        /// instance, Amazon SageMaker opens a new tab showing the Jupyter server home page from
        /// the notebook instance. The console uses this API to get the URL and show the page.
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
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedNotebookInstanceUrl operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedNotebookInstanceUrl">REST API Reference for CreatePresignedNotebookInstanceUrl Operation</seealso>
        Task<CreatePresignedNotebookInstanceUrlResponse> CreatePresignedNotebookInstanceUrlAsync(CreatePresignedNotebookInstanceUrlRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTrainingJob


        /// <summary>
        /// Starts a model training job. After training completes, Amazon SageMaker saves the
        /// resulting model artifacts to an Amazon S3 location that you specify. 
        /// 
        ///  
        /// <para>
        /// If you choose to host your model using Amazon SageMaker hosting services, you can
        /// use the resulting model artifacts as part of the model. You can also use the artifacts
        /// in a deep learning service other than Amazon SageMaker, provided that you know how
        /// to use them for inferences. 
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
        ///  <code>HyperParameters</code> - Specify these algorithm-specific parameters to influence
        /// the quality of the final model. For a list of hyperparameters for each training algorithm
        /// provided by Amazon SageMaker, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/algos.html">Algorithms</a>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InputDataConfig</code> - Describes the training dataset and the Amazon S3 location
        /// where it is stored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OutputDataConfig</code> - Identifies the Amazon S3 location where you want
        /// Amazon SageMaker to save the results of model training. 
        /// </para>
        ///   </li> <li> 
        /// <para>
        ///  <code>ResourceConfig</code> - Identifies the resources, ML compute instances, and
        /// ML storage volumes to deploy for model training. In distributed training, you specify
        /// more than one instance. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RoleARN</code> - The Amazon Resource Number (ARN) that Amazon SageMaker assumes
        /// to perform tasks on your behalf during model training. You must grant this role the
        /// necessary permissions so that Amazon SageMaker can successfully complete model training.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>StoppingCondition</code> - Sets a duration for training. Use this parameter
        /// to cap model training costs. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information about Amazon SageMaker, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
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
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrainingJob">REST API Reference for CreateTrainingJob Operation</seealso>
        CreateTrainingJobResponse CreateTrainingJob(CreateTrainingJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrainingJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrainingJob">REST API Reference for CreateTrainingJob Operation</seealso>
        Task<CreateTrainingJobResponse> CreateTrainingJobAsync(CreateTrainingJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEndpoint


        /// <summary>
        /// Deletes an endpoint. Amazon SageMaker frees up all of the resources that were deployed
        /// when the endpoint was created.
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEndpointConfig


        /// <summary>
        /// Deletes an endpoint configuration. The <code>DeleteEndpointConfig</code> API deletes
        /// only the specified configuration. It does not delete endpoints created using the configuration.
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpointConfig">REST API Reference for DeleteEndpointConfig Operation</seealso>
        Task<DeleteEndpointConfigResponse> DeleteEndpointConfigAsync(DeleteEndpointConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteModel


        /// <summary>
        /// Deletes a model. The <code>DeleteModel</code> API deletes only the model entry that
        /// was created in Amazon SageMaker when you called the <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_CreateModel.html">CreateModel</a>
        /// API. It does not delete model artifacts, inference code, or the IAM role that you
        /// specified when creating the model.
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        Task<DeleteModelResponse> DeleteModelAsync(DeleteModelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteNotebookInstance


        /// <summary>
        /// Deletes an Amazon SageMaker notebook instance. Before you can delete a notebook instance,
        /// you must call the <code>StopNotebookInstance</code> API. 
        /// 
        ///  <important> 
        /// <para>
        /// When you delete a notebook instance, you lose all of your data. Amazon SageMaker removes
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebookInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstance">REST API Reference for DeleteNotebookInstance Operation</seealso>
        Task<DeleteNotebookInstanceResponse> DeleteNotebookInstanceAsync(DeleteNotebookInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebookInstanceLifecycleConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstanceLifecycleConfig">REST API Reference for DeleteNotebookInstanceLifecycleConfig Operation</seealso>
        Task<DeleteNotebookInstanceLifecycleConfigResponse> DeleteNotebookInstanceLifecycleConfigAsync(DeleteNotebookInstanceLifecycleConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTags


        /// <summary>
        /// Deletes the specified tags from an Amazon SageMaker resource.
        /// 
        ///  
        /// <para>
        /// To list a resource's tags, use the <code>ListTags</code> API. 
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        Task<DescribeEndpointResponse> DescribeEndpointAsync(DescribeEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpointConfig">REST API Reference for DescribeEndpointConfig Operation</seealso>
        Task<DescribeEndpointConfigResponse> DescribeEndpointConfigAsync(DescribeEndpointConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeHyperParameterTuningJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHyperParameterTuningJob">REST API Reference for DescribeHyperParameterTuningJob Operation</seealso>
        Task<DescribeHyperParameterTuningJobResponse> DescribeHyperParameterTuningJobAsync(DescribeHyperParameterTuningJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        Task<DescribeModelResponse> DescribeModelAsync(DescribeModelRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstance">REST API Reference for DescribeNotebookInstance Operation</seealso>
        Task<DescribeNotebookInstanceResponse> DescribeNotebookInstanceAsync(DescribeNotebookInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeNotebookInstanceLifecycleConfig


        /// <summary>
        /// Returns a description of a notebook instance lifecycle configuration.
        /// 
        ///  
        /// <para>
        /// For information about notebook instance lifestyle configurations, see <a>notebook-lifecycle-config</a>.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookInstanceLifecycleConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstanceLifecycleConfig">REST API Reference for DescribeNotebookInstanceLifecycleConfig Operation</seealso>
        Task<DescribeNotebookInstanceLifecycleConfigResponse> DescribeNotebookInstanceLifecycleConfigAsync(DescribeNotebookInstanceLifecycleConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTrainingJob


        /// <summary>
        /// Returns information about a training job.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrainingJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrainingJob">REST API Reference for DescribeTrainingJob Operation</seealso>
        Task<DescribeTrainingJobResponse> DescribeTrainingJobAsync(DescribeTrainingJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointConfigs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpointConfigs">REST API Reference for ListEndpointConfigs Operation</seealso>
        Task<ListEndpointConfigsResponse> ListEndpointConfigsAsync(ListEndpointConfigsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the ListEndpoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        Task<ListEndpointsResponse> ListEndpointsAsync(ListEndpointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListHyperParameterTuningJobs


        /// <summary>
        /// Gets a list of objects that describe the hyperparameter tuning jobs launched in your
        /// account.
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
        /// <param name="request">Container for the necessary parameters to execute the ListHyperParameterTuningJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHyperParameterTuningJobs">REST API Reference for ListHyperParameterTuningJobs Operation</seealso>
        Task<ListHyperParameterTuningJobsResponse> ListHyperParameterTuningJobsAsync(ListHyperParameterTuningJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListModels


        /// <summary>
        /// Lists models created with the <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_CreateModel.html">CreateModel</a>
        /// API.
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
        /// <param name="request">Container for the necessary parameters to execute the ListModels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModels">REST API Reference for ListModels Operation</seealso>
        Task<ListModelsResponse> ListModelsAsync(ListModelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListNotebookInstanceLifecycleConfigs


        /// <summary>
        /// Lists notebook instance lifestyle configurations created with the API.
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
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstanceLifecycleConfigs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstanceLifecycleConfigs">REST API Reference for ListNotebookInstanceLifecycleConfigs Operation</seealso>
        Task<ListNotebookInstanceLifecycleConfigsResponse> ListNotebookInstanceLifecycleConfigsAsync(ListNotebookInstanceLifecycleConfigsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListNotebookInstances


        /// <summary>
        /// Returns a list of the Amazon SageMaker notebook instances in the requester's account
        /// in an AWS Region.
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
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstances">REST API Reference for ListNotebookInstances Operation</seealso>
        Task<ListNotebookInstancesResponse> ListNotebookInstancesAsync(ListNotebookInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTags


        /// <summary>
        /// Returns the tags for the specified Amazon SageMaker resource.
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
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTags">REST API Reference for ListTags Operation</seealso>
        Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTrainingJobs


        /// <summary>
        /// Lists training jobs.
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
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobs">REST API Reference for ListTrainingJobs Operation</seealso>
        Task<ListTrainingJobsResponse> ListTrainingJobsAsync(ListTrainingJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTrainingJobsForHyperParameterTuningJob


        /// <summary>
        /// Gets a list of objects that describe the training jobs that a hyperparameter tuning
        /// job launched.
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
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingJobsForHyperParameterTuningJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobsForHyperParameterTuningJob">REST API Reference for ListTrainingJobsForHyperParameterTuningJob Operation</seealso>
        Task<ListTrainingJobsForHyperParameterTuningJobResponse> ListTrainingJobsForHyperParameterTuningJobAsync(ListTrainingJobsForHyperParameterTuningJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartNotebookInstance


        /// <summary>
        /// Launches an ML compute instance with the latest version of the libraries and attaches
        /// your ML storage volume. After configuring the notebook instance, Amazon SageMaker
        /// sets the notebook instance status to <code>InService</code>. A notebook instance's
        /// status must be <code>InService</code> before you can connect to your Jupyter notebook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNotebookInstance service method.</param>
        /// 
        /// <returns>The response from the StartNotebookInstance service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartNotebookInstance">REST API Reference for StartNotebookInstance Operation</seealso>
        StartNotebookInstanceResponse StartNotebookInstance(StartNotebookInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartNotebookInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartNotebookInstance">REST API Reference for StartNotebookInstance Operation</seealso>
        Task<StartNotebookInstanceResponse> StartNotebookInstanceAsync(StartNotebookInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopHyperParameterTuningJob


        /// <summary>
        /// Stops a running hyperparameter tuning job and all running training jobs that the tuning
        /// job launched.
        /// 
        ///  
        /// <para>
        /// All model artifacts output from the training jobs are stored in Amazon Simple Storage
        /// Service (Amazon S3). All data that the training jobs write toAmazon CloudWatch Logs
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
        /// <param name="request">Container for the necessary parameters to execute the StopHyperParameterTuningJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopHyperParameterTuningJob">REST API Reference for StopHyperParameterTuningJob Operation</seealso>
        Task<StopHyperParameterTuningJobResponse> StopHyperParameterTuningJobAsync(StopHyperParameterTuningJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopNotebookInstance


        /// <summary>
        /// Terminates the ML compute instance. Before terminating the instance, Amazon SageMaker
        /// disconnects the ML storage volume from it. Amazon SageMaker preserves the ML storage
        /// volume. 
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
        /// <param name="request">Container for the necessary parameters to execute the StopNotebookInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopNotebookInstance">REST API Reference for StopNotebookInstance Operation</seealso>
        Task<StopNotebookInstanceResponse> StopNotebookInstanceAsync(StopNotebookInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopTrainingJob


        /// <summary>
        /// Stops a training job. To stop a job, Amazon SageMaker sends the algorithm the <code>SIGTERM</code>
        /// signal, which delays job termination for 120 seconds. Algorithms might use this 120-second
        /// window to save the model artifacts, so the results of the training is not lost. 
        /// 
        ///  
        /// <para>
        /// Training algorithms provided by Amazon SageMaker save the intermediate results of
        /// a model training job. This intermediate data is a valid model artifact. You can use
        /// the model artifacts that are saved when Amazon SageMaker stops a training job to create
        /// a model. 
        /// </para>
        ///  
        /// <para>
        /// When it receives a <code>StopTrainingJob</code> request, Amazon SageMaker changes
        /// the status of the job to <code>Stopping</code>. After Amazon SageMaker stops the job,
        /// it sets the status to <code>Stopped</code>.
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
        /// <param name="request">Container for the necessary parameters to execute the StopTrainingJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTrainingJob">REST API Reference for StopTrainingJob Operation</seealso>
        Task<StopTrainingJobResponse> StopTrainingJobAsync(StopTrainingJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEndpoint


        /// <summary>
        /// Deploys the new <code>EndpointConfig</code> specified in the request, switches to
        /// using newly created endpoint, and then deletes resources provisioned for the endpoint
        /// using the previous <code>EndpointConfig</code> (there is no availability loss). 
        /// 
        ///  
        /// <para>
        /// When Amazon SageMaker receives the request, it sets the endpoint status to <code>Updating</code>.
        /// After updating the endpoint, it sets the status to <code>InService</code>. To check
        /// the status of an endpoint, use the <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_DescribeEndpoint.html">DescribeEndpoint</a>
        /// API. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateEndpoint service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        UpdateEndpointResponse UpdateEndpoint(UpdateEndpointRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        Task<UpdateEndpointResponse> UpdateEndpointAsync(UpdateEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEndpointWeightsAndCapacities


        /// <summary>
        /// Updates variant weight of one or more variants associated with an existing endpoint,
        /// or capacity of one variant associated with an existing endpoint. When it receives
        /// the request, Amazon SageMaker sets the endpoint status to <code>Updating</code>. After
        /// updating the endpoint, it sets the status to <code>InService</code>. To check the
        /// status of an endpoint, use the <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_DescribeEndpoint.html">DescribeEndpoint</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointWeightsAndCapacities service method.</param>
        /// 
        /// <returns>The response from the UpdateEndpointWeightsAndCapacities service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpointWeightsAndCapacities">REST API Reference for UpdateEndpointWeightsAndCapacities Operation</seealso>
        UpdateEndpointWeightsAndCapacitiesResponse UpdateEndpointWeightsAndCapacities(UpdateEndpointWeightsAndCapacitiesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpointWeightsAndCapacities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointWeightsAndCapacities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpointWeightsAndCapacities">REST API Reference for UpdateEndpointWeightsAndCapacities Operation</seealso>
        Task<UpdateEndpointWeightsAndCapacitiesResponse> UpdateEndpointWeightsAndCapacitiesAsync(UpdateEndpointWeightsAndCapacitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateNotebookInstance


        /// <summary>
        /// Updates a notebook instance. NotebookInstance updates include upgrading or downgrading
        /// the ML compute instance used for your notebook instance to accommodate changes in
        /// your workload requirements. You can also update the VPC security groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstance service method.</param>
        /// 
        /// <returns>The response from the UpdateNotebookInstance service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstance">REST API Reference for UpdateNotebookInstance Operation</seealso>
        UpdateNotebookInstanceResponse UpdateNotebookInstance(UpdateNotebookInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstance">REST API Reference for UpdateNotebookInstance Operation</seealso>
        Task<UpdateNotebookInstanceResponse> UpdateNotebookInstanceAsync(UpdateNotebookInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateNotebookInstanceLifecycleConfig


        /// <summary>
        /// Updates a notebook instance lifecycle configuration created with the API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstanceLifecycleConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateNotebookInstanceLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstanceLifecycleConfig">REST API Reference for UpdateNotebookInstanceLifecycleConfig Operation</seealso>
        UpdateNotebookInstanceLifecycleConfigResponse UpdateNotebookInstanceLifecycleConfig(UpdateNotebookInstanceLifecycleConfigRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstanceLifecycleConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstanceLifecycleConfig">REST API Reference for UpdateNotebookInstanceLifecycleConfig Operation</seealso>
        Task<UpdateNotebookInstanceLifecycleConfigResponse> UpdateNotebookInstanceLifecycleConfigAsync(UpdateNotebookInstanceLifecycleConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}