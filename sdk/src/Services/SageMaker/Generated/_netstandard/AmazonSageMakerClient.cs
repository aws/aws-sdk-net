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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SageMaker.Model;
using Amazon.SageMaker.Model.Internal.MarshallTransformations;
using Amazon.SageMaker.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SageMaker
{
    /// <summary>
    /// Implementation for accessing SageMaker
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
    public partial class AmazonSageMakerClient : AmazonServiceClient, IAmazonSageMaker
    {
        private static IServiceMetadata serviceMetadata = new AmazonSageMakerMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSageMakerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonSageMakerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSageMakerConfig()) { }

        /// <summary>
        /// Constructs AmazonSageMakerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSageMakerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSageMakerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonSageMakerClient Configuration Object</param>
        public AmazonSageMakerClient(AmazonSageMakerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSageMakerClient(AWSCredentials credentials)
            : this(credentials, new AmazonSageMakerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSageMakerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Credentials and an
        /// AmazonSageMakerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSageMakerClient Configuration Object</param>
        public AmazonSageMakerClient(AWSCredentials credentials, AmazonSageMakerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSageMakerClient Configuration Object</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSageMakerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSageMakerClient Configuration Object</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSageMakerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ISageMakerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISageMakerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SageMakerPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSageMakerEndpointResolver());
        }
        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AddAssociation

        internal virtual AddAssociationResponse AddAssociation(AddAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddAssociationResponseUnmarshaller.Instance;

            return Invoke<AddAssociationResponse>(request, options);
        }



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
        public virtual Task<AddAssociationResponse> AddAssociationAsync(AddAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<AddAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddTags

        internal virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateTrialComponent

        internal virtual AssociateTrialComponentResponse AssociateTrialComponent(AssociateTrialComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTrialComponentResponseUnmarshaller.Instance;

            return Invoke<AssociateTrialComponentResponse>(request, options);
        }



        /// <summary>
        /// Associates a trial component with a trial. A trial component can be associated with
        /// multiple trials. To disassociate a trial component from a trial, call the <a>DisassociateTrialComponent</a>
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
        public virtual Task<AssociateTrialComponentResponse> AssociateTrialComponentAsync(AssociateTrialComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTrialComponentResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateTrialComponentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDescribeModelPackage

        internal virtual BatchDescribeModelPackageResponse BatchDescribeModelPackage(BatchDescribeModelPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDescribeModelPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDescribeModelPackageResponseUnmarshaller.Instance;

            return Invoke<BatchDescribeModelPackageResponse>(request, options);
        }



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
        public virtual Task<BatchDescribeModelPackageResponse> BatchDescribeModelPackageAsync(BatchDescribeModelPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDescribeModelPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDescribeModelPackageResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDescribeModelPackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAction

        internal virtual CreateActionResponse CreateAction(CreateActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateActionResponseUnmarshaller.Instance;

            return Invoke<CreateActionResponse>(request, options);
        }



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
        public virtual Task<CreateActionResponse> CreateActionAsync(CreateActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateActionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAlgorithm

        internal virtual CreateAlgorithmResponse CreateAlgorithm(CreateAlgorithmRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAlgorithmResponseUnmarshaller.Instance;

            return Invoke<CreateAlgorithmResponse>(request, options);
        }



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
        public virtual Task<CreateAlgorithmResponse> CreateAlgorithmAsync(CreateAlgorithmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAlgorithmResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAlgorithmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateApp

        internal virtual CreateAppResponse CreateApp(CreateAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppResponseUnmarshaller.Instance;

            return Invoke<CreateAppResponse>(request, options);
        }



        /// <summary>
        /// Creates a running app for the specified UserProfile. This operation is automatically
        /// invoked by Amazon SageMaker Studio upon access to the associated Domain, and when
        /// new kernel configurations are selected by the user. A user may have multiple Apps
        /// active simultaneously.
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
        public virtual Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAppImageConfig

        internal virtual CreateAppImageConfigResponse CreateAppImageConfig(CreateAppImageConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppImageConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppImageConfigResponseUnmarshaller.Instance;

            return Invoke<CreateAppImageConfigResponse>(request, options);
        }



        /// <summary>
        /// Creates a configuration for running a SageMaker image as a KernelGateway app. The
        /// configuration specifies the Amazon Elastic File System (EFS) storage volume on the
        /// image, and a list of the kernels in the image.
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
        public virtual Task<CreateAppImageConfigResponse> CreateAppImageConfigAsync(CreateAppImageConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppImageConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppImageConfigResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAppImageConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateArtifact

        internal virtual CreateArtifactResponse CreateArtifact(CreateArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateArtifactResponseUnmarshaller.Instance;

            return Invoke<CreateArtifactResponse>(request, options);
        }



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
        public virtual Task<CreateArtifactResponse> CreateArtifactAsync(CreateArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateArtifactResponseUnmarshaller.Instance;

            return InvokeAsync<CreateArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAutoMLJob

        internal virtual CreateAutoMLJobResponse CreateAutoMLJob(CreateAutoMLJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAutoMLJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutoMLJobResponseUnmarshaller.Instance;

            return Invoke<CreateAutoMLJobResponse>(request, options);
        }



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
        public virtual Task<CreateAutoMLJobResponse> CreateAutoMLJobAsync(CreateAutoMLJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAutoMLJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutoMLJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAutoMLJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCodeRepository

        internal virtual CreateCodeRepositoryResponse CreateCodeRepository(CreateCodeRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeRepositoryResponseUnmarshaller.Instance;

            return Invoke<CreateCodeRepositoryResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCodeRepository service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCodeRepository">REST API Reference for CreateCodeRepository Operation</seealso>
        public virtual Task<CreateCodeRepositoryResponse> CreateCodeRepositoryAsync(CreateCodeRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCodeRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCompilationJob

        internal virtual CreateCompilationJobResponse CreateCompilationJob(CreateCompilationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCompilationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCompilationJobResponseUnmarshaller.Instance;

            return Invoke<CreateCompilationJobResponse>(request, options);
        }



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
        public virtual Task<CreateCompilationJobResponse> CreateCompilationJobAsync(CreateCompilationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCompilationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCompilationJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCompilationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateContext

        internal virtual CreateContextResponse CreateContext(CreateContextRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContextResponseUnmarshaller.Instance;

            return Invoke<CreateContextResponse>(request, options);
        }



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
        public virtual Task<CreateContextResponse> CreateContextAsync(CreateContextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContextResponseUnmarshaller.Instance;

            return InvokeAsync<CreateContextResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDataQualityJobDefinition

        internal virtual CreateDataQualityJobDefinitionResponse CreateDataQualityJobDefinition(CreateDataQualityJobDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataQualityJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataQualityJobDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateDataQualityJobDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Creates a definition for a job that monitors data quality and drift. For information
        /// about model monitor, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-monitor.html">Amazon
        /// SageMaker Model Monitor</a>.
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
        public virtual Task<CreateDataQualityJobDefinitionResponse> CreateDataQualityJobDefinitionAsync(CreateDataQualityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataQualityJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataQualityJobDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataQualityJobDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDeviceFleet

        internal virtual CreateDeviceFleetResponse CreateDeviceFleet(CreateDeviceFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeviceFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeviceFleetResponseUnmarshaller.Instance;

            return Invoke<CreateDeviceFleetResponse>(request, options);
        }



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
        public virtual Task<CreateDeviceFleetResponse> CreateDeviceFleetAsync(CreateDeviceFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeviceFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeviceFleetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeviceFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDomain

        internal virtual CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return Invoke<CreateDomainResponse>(request, options);
        }



        /// <summary>
        /// Creates a <code>Domain</code> used by Amazon SageMaker Studio. A domain consists of
        /// an associated Amazon Elastic File System (EFS) volume, a list of authorized users,
        /// and a variety of security, application, policy, and Amazon Virtual Private Cloud (VPC)
        /// configurations. Users within a domain can share notebook files and other artifacts
        /// with each other.
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
        public virtual Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEdgeDeploymentPlan

        internal virtual CreateEdgeDeploymentPlanResponse CreateEdgeDeploymentPlan(CreateEdgeDeploymentPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEdgeDeploymentPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEdgeDeploymentPlanResponseUnmarshaller.Instance;

            return Invoke<CreateEdgeDeploymentPlanResponse>(request, options);
        }



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
        public virtual Task<CreateEdgeDeploymentPlanResponse> CreateEdgeDeploymentPlanAsync(CreateEdgeDeploymentPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEdgeDeploymentPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEdgeDeploymentPlanResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEdgeDeploymentPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEdgeDeploymentStage

        internal virtual CreateEdgeDeploymentStageResponse CreateEdgeDeploymentStage(CreateEdgeDeploymentStageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEdgeDeploymentStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEdgeDeploymentStageResponseUnmarshaller.Instance;

            return Invoke<CreateEdgeDeploymentStageResponse>(request, options);
        }



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
        public virtual Task<CreateEdgeDeploymentStageResponse> CreateEdgeDeploymentStageAsync(CreateEdgeDeploymentStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEdgeDeploymentStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEdgeDeploymentStageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEdgeDeploymentStageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEdgePackagingJob

        internal virtual CreateEdgePackagingJobResponse CreateEdgePackagingJob(CreateEdgePackagingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEdgePackagingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEdgePackagingJobResponseUnmarshaller.Instance;

            return Invoke<CreateEdgePackagingJobResponse>(request, options);
        }



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
        public virtual Task<CreateEdgePackagingJobResponse> CreateEdgePackagingJobAsync(CreateEdgePackagingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEdgePackagingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEdgePackagingJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEdgePackagingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEndpoint

        internal virtual CreateEndpointResponse CreateEndpoint(CreateEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateEndpointResponse>(request, options);
        }



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
        public virtual Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEndpointConfig

        internal virtual CreateEndpointConfigResponse CreateEndpointConfig(CreateEndpointConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointConfigResponseUnmarshaller.Instance;

            return Invoke<CreateEndpointConfigResponse>(request, options);
        }



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
        public virtual Task<CreateEndpointConfigResponse> CreateEndpointConfigAsync(CreateEndpointConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointConfigResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEndpointConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateExperiment

        internal virtual CreateExperimentResponse CreateExperiment(CreateExperimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExperimentResponseUnmarshaller.Instance;

            return Invoke<CreateExperimentResponse>(request, options);
        }



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
        public virtual Task<CreateExperimentResponse> CreateExperimentAsync(CreateExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExperimentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateExperimentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFeatureGroup

        internal virtual CreateFeatureGroupResponse CreateFeatureGroup(CreateFeatureGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFeatureGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFeatureGroupResponseUnmarshaller.Instance;

            return Invoke<CreateFeatureGroupResponse>(request, options);
        }



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
        public virtual Task<CreateFeatureGroupResponse> CreateFeatureGroupAsync(CreateFeatureGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFeatureGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFeatureGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFeatureGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFlowDefinition

        internal virtual CreateFlowDefinitionResponse CreateFlowDefinition(CreateFlowDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFlowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateFlowDefinitionResponse>(request, options);
        }



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
        public virtual Task<CreateFlowDefinitionResponse> CreateFlowDefinitionAsync(CreateFlowDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFlowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFlowDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateHub

        internal virtual CreateHubResponse CreateHub(CreateHubRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHubResponseUnmarshaller.Instance;

            return Invoke<CreateHubResponse>(request, options);
        }



        /// <summary>
        /// Create a hub.
        /// 
        ///  <note> 
        /// <para>
        /// Hub APIs are only callable through SageMaker Studio.
        /// </para>
        ///  </note>
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
        public virtual Task<CreateHubResponse> CreateHubAsync(CreateHubRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHubResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHubResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateHumanTaskUi

        internal virtual CreateHumanTaskUiResponse CreateHumanTaskUi(CreateHumanTaskUiRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHumanTaskUiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHumanTaskUiResponseUnmarshaller.Instance;

            return Invoke<CreateHumanTaskUiResponse>(request, options);
        }



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
        public virtual Task<CreateHumanTaskUiResponse> CreateHumanTaskUiAsync(CreateHumanTaskUiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHumanTaskUiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHumanTaskUiResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHumanTaskUiResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateHyperParameterTuningJob

        internal virtual CreateHyperParameterTuningJobResponse CreateHyperParameterTuningJob(CreateHyperParameterTuningJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHyperParameterTuningJobResponseUnmarshaller.Instance;

            return Invoke<CreateHyperParameterTuningJobResponse>(request, options);
        }



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
        public virtual Task<CreateHyperParameterTuningJobResponse> CreateHyperParameterTuningJobAsync(CreateHyperParameterTuningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHyperParameterTuningJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHyperParameterTuningJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateImage

        internal virtual CreateImageResponse CreateImage(CreateImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageResponseUnmarshaller.Instance;

            return Invoke<CreateImageResponse>(request, options);
        }



        /// <summary>
        /// Creates a custom SageMaker image. A SageMaker image is a set of image versions. Each
        /// image version represents a container image stored in Amazon Elastic Container Registry
        /// (ECR). For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/studio-byoi.html">Bring
        /// your own SageMaker image</a>.
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
        public virtual Task<CreateImageResponse> CreateImageAsync(CreateImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateImageVersion

        internal virtual CreateImageVersionResponse CreateImageVersion(CreateImageVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateImageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageVersionResponseUnmarshaller.Instance;

            return Invoke<CreateImageVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a version of the SageMaker image specified by <code>ImageName</code>. The
        /// version represents the Amazon Elastic Container Registry (ECR) container image specified
        /// by <code>BaseImage</code>.
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
        public virtual Task<CreateImageVersionResponse> CreateImageVersionAsync(CreateImageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateImageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateImageVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInferenceExperiment

        internal virtual CreateInferenceExperimentResponse CreateInferenceExperiment(CreateInferenceExperimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInferenceExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInferenceExperimentResponseUnmarshaller.Instance;

            return Invoke<CreateInferenceExperimentResponse>(request, options);
        }



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
        public virtual Task<CreateInferenceExperimentResponse> CreateInferenceExperimentAsync(CreateInferenceExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInferenceExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInferenceExperimentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInferenceExperimentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInferenceRecommendationsJob

        internal virtual CreateInferenceRecommendationsJobResponse CreateInferenceRecommendationsJob(CreateInferenceRecommendationsJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInferenceRecommendationsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInferenceRecommendationsJobResponseUnmarshaller.Instance;

            return Invoke<CreateInferenceRecommendationsJobResponse>(request, options);
        }



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
        public virtual Task<CreateInferenceRecommendationsJobResponse> CreateInferenceRecommendationsJobAsync(CreateInferenceRecommendationsJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInferenceRecommendationsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInferenceRecommendationsJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInferenceRecommendationsJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLabelingJob

        internal virtual CreateLabelingJobResponse CreateLabelingJob(CreateLabelingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLabelingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLabelingJobResponseUnmarshaller.Instance;

            return Invoke<CreateLabelingJobResponse>(request, options);
        }



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
        public virtual Task<CreateLabelingJobResponse> CreateLabelingJobAsync(CreateLabelingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLabelingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLabelingJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLabelingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateModel

        internal virtual CreateModelResponse CreateModel(CreateModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return Invoke<CreateModelResponse>(request, options);
        }



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
        public virtual Task<CreateModelResponse> CreateModelAsync(CreateModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateModelBiasJobDefinition

        internal virtual CreateModelBiasJobDefinitionResponse CreateModelBiasJobDefinition(CreateModelBiasJobDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelBiasJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelBiasJobDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateModelBiasJobDefinitionResponse>(request, options);
        }



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
        public virtual Task<CreateModelBiasJobDefinitionResponse> CreateModelBiasJobDefinitionAsync(CreateModelBiasJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelBiasJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelBiasJobDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateModelBiasJobDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateModelCard

        internal virtual CreateModelCardResponse CreateModelCard(CreateModelCardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelCardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelCardResponseUnmarshaller.Instance;

            return Invoke<CreateModelCardResponse>(request, options);
        }



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
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelCard">REST API Reference for CreateModelCard Operation</seealso>
        public virtual Task<CreateModelCardResponse> CreateModelCardAsync(CreateModelCardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelCardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelCardResponseUnmarshaller.Instance;

            return InvokeAsync<CreateModelCardResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateModelCardExportJob

        internal virtual CreateModelCardExportJobResponse CreateModelCardExportJob(CreateModelCardExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelCardExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelCardExportJobResponseUnmarshaller.Instance;

            return Invoke<CreateModelCardExportJobResponse>(request, options);
        }



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
        public virtual Task<CreateModelCardExportJobResponse> CreateModelCardExportJobAsync(CreateModelCardExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelCardExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelCardExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateModelCardExportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateModelExplainabilityJobDefinition

        internal virtual CreateModelExplainabilityJobDefinitionResponse CreateModelExplainabilityJobDefinition(CreateModelExplainabilityJobDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelExplainabilityJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelExplainabilityJobDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateModelExplainabilityJobDefinitionResponse>(request, options);
        }



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
        public virtual Task<CreateModelExplainabilityJobDefinitionResponse> CreateModelExplainabilityJobDefinitionAsync(CreateModelExplainabilityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelExplainabilityJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelExplainabilityJobDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateModelExplainabilityJobDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateModelPackage

        internal virtual CreateModelPackageResponse CreateModelPackage(CreateModelPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelPackageResponseUnmarshaller.Instance;

            return Invoke<CreateModelPackageResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateModelPackageResponse> CreateModelPackageAsync(CreateModelPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelPackageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateModelPackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateModelPackageGroup

        internal virtual CreateModelPackageGroupResponse CreateModelPackageGroup(CreateModelPackageGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelPackageGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelPackageGroupResponseUnmarshaller.Instance;

            return Invoke<CreateModelPackageGroupResponse>(request, options);
        }



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
        public virtual Task<CreateModelPackageGroupResponse> CreateModelPackageGroupAsync(CreateModelPackageGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelPackageGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelPackageGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateModelPackageGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateModelQualityJobDefinition

        internal virtual CreateModelQualityJobDefinitionResponse CreateModelQualityJobDefinition(CreateModelQualityJobDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelQualityJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelQualityJobDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateModelQualityJobDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Creates a definition for a job that monitors model quality and drift. For information
        /// about model monitor, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-monitor.html">Amazon
        /// SageMaker Model Monitor</a>.
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
        public virtual Task<CreateModelQualityJobDefinitionResponse> CreateModelQualityJobDefinitionAsync(CreateModelQualityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelQualityJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelQualityJobDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateModelQualityJobDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMonitoringSchedule

        internal virtual CreateMonitoringScheduleResponse CreateMonitoringSchedule(CreateMonitoringScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMonitoringScheduleResponseUnmarshaller.Instance;

            return Invoke<CreateMonitoringScheduleResponse>(request, options);
        }



        /// <summary>
        /// Creates a schedule that regularly starts Amazon SageMaker Processing Jobs to monitor
        /// the data captured for an Amazon SageMaker Endpoint.
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
        public virtual Task<CreateMonitoringScheduleResponse> CreateMonitoringScheduleAsync(CreateMonitoringScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMonitoringScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMonitoringScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNotebookInstance

        internal virtual CreateNotebookInstanceResponse CreateNotebookInstance(CreateNotebookInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateNotebookInstanceResponse>(request, options);
        }



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
        public virtual Task<CreateNotebookInstanceResponse> CreateNotebookInstanceAsync(CreateNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotebookInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNotebookInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNotebookInstanceLifecycleConfig

        internal virtual CreateNotebookInstanceLifecycleConfigResponse CreateNotebookInstanceLifecycleConfig(CreateNotebookInstanceLifecycleConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return Invoke<CreateNotebookInstanceLifecycleConfigResponse>(request, options);
        }



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
        public virtual Task<CreateNotebookInstanceLifecycleConfigResponse> CreateNotebookInstanceLifecycleConfigAsync(CreateNotebookInstanceLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNotebookInstanceLifecycleConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePipeline

        internal virtual CreatePipelineResponse CreatePipeline(CreatePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return Invoke<CreatePipelineResponse>(request, options);
        }



        /// <summary>
        /// Creates a pipeline using a JSON pipeline definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePresignedDomainUrl

        internal virtual CreatePresignedDomainUrlResponse CreatePresignedDomainUrl(CreatePresignedDomainUrlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePresignedDomainUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresignedDomainUrlResponseUnmarshaller.Instance;

            return Invoke<CreatePresignedDomainUrlResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePresignedDomainUrl service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedDomainUrl">REST API Reference for CreatePresignedDomainUrl Operation</seealso>
        public virtual Task<CreatePresignedDomainUrlResponse> CreatePresignedDomainUrlAsync(CreatePresignedDomainUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePresignedDomainUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresignedDomainUrlResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePresignedDomainUrlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePresignedNotebookInstanceUrl

        internal virtual CreatePresignedNotebookInstanceUrlResponse CreatePresignedNotebookInstanceUrl(CreatePresignedNotebookInstanceUrlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePresignedNotebookInstanceUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresignedNotebookInstanceUrlResponseUnmarshaller.Instance;

            return Invoke<CreatePresignedNotebookInstanceUrlResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePresignedNotebookInstanceUrl service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedNotebookInstanceUrl">REST API Reference for CreatePresignedNotebookInstanceUrl Operation</seealso>
        public virtual Task<CreatePresignedNotebookInstanceUrlResponse> CreatePresignedNotebookInstanceUrlAsync(CreatePresignedNotebookInstanceUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePresignedNotebookInstanceUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresignedNotebookInstanceUrlResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePresignedNotebookInstanceUrlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProcessingJob

        internal virtual CreateProcessingJobResponse CreateProcessingJob(CreateProcessingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProcessingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProcessingJobResponseUnmarshaller.Instance;

            return Invoke<CreateProcessingJobResponse>(request, options);
        }



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
        public virtual Task<CreateProcessingJobResponse> CreateProcessingJobAsync(CreateProcessingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProcessingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProcessingJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProcessingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProject

        internal virtual CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return Invoke<CreateProjectResponse>(request, options);
        }



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
        public virtual Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSpace

        internal virtual CreateSpaceResponse CreateSpace(CreateSpaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSpaceResponseUnmarshaller.Instance;

            return Invoke<CreateSpaceResponse>(request, options);
        }



        /// <summary>
        /// Creates a space used for real time collaboration in a Domain.
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
        public virtual Task<CreateSpaceResponse> CreateSpaceAsync(CreateSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSpaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSpaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStudioLifecycleConfig

        internal virtual CreateStudioLifecycleConfigResponse CreateStudioLifecycleConfig(CreateStudioLifecycleConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStudioLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStudioLifecycleConfigResponseUnmarshaller.Instance;

            return Invoke<CreateStudioLifecycleConfigResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Studio Lifecycle Configuration.
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
        public virtual Task<CreateStudioLifecycleConfigResponse> CreateStudioLifecycleConfigAsync(CreateStudioLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStudioLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStudioLifecycleConfigResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStudioLifecycleConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTrainingJob

        internal virtual CreateTrainingJobResponse CreateTrainingJob(CreateTrainingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrainingJobResponseUnmarshaller.Instance;

            return Invoke<CreateTrainingJobResponse>(request, options);
        }



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
        public virtual Task<CreateTrainingJobResponse> CreateTrainingJobAsync(CreateTrainingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrainingJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrainingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTransformJob

        internal virtual CreateTransformJobResponse CreateTransformJob(CreateTransformJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransformJobResponseUnmarshaller.Instance;

            return Invoke<CreateTransformJobResponse>(request, options);
        }



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
        public virtual Task<CreateTransformJobResponse> CreateTransformJobAsync(CreateTransformJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransformJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTransformJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTrial

        internal virtual CreateTrialResponse CreateTrial(CreateTrialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrialResponseUnmarshaller.Instance;

            return Invoke<CreateTrialResponse>(request, options);
        }



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
        public virtual Task<CreateTrialResponse> CreateTrialAsync(CreateTrialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrialResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrialResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTrialComponent

        internal virtual CreateTrialComponentResponse CreateTrialComponent(CreateTrialComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrialComponentResponseUnmarshaller.Instance;

            return Invoke<CreateTrialComponentResponse>(request, options);
        }



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
        public virtual Task<CreateTrialComponentResponse> CreateTrialComponentAsync(CreateTrialComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrialComponentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrialComponentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateUserProfile

        internal virtual CreateUserProfileResponse CreateUserProfile(CreateUserProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserProfileResponseUnmarshaller.Instance;

            return Invoke<CreateUserProfileResponse>(request, options);
        }



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
        public virtual Task<CreateUserProfileResponse> CreateUserProfileAsync(CreateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWorkforce

        internal virtual CreateWorkforceResponse CreateWorkforce(CreateWorkforceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkforceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkforceResponseUnmarshaller.Instance;

            return Invoke<CreateWorkforceResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkforce service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateWorkforce">REST API Reference for CreateWorkforce Operation</seealso>
        public virtual Task<CreateWorkforceResponse> CreateWorkforceAsync(CreateWorkforceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkforceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkforceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkforceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWorkteam

        internal virtual CreateWorkteamResponse CreateWorkteam(CreateWorkteamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkteamResponseUnmarshaller.Instance;

            return Invoke<CreateWorkteamResponse>(request, options);
        }



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
        public virtual Task<CreateWorkteamResponse> CreateWorkteamAsync(CreateWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkteamResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkteamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAction

        internal virtual DeleteActionResponse DeleteAction(DeleteActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteActionResponseUnmarshaller.Instance;

            return Invoke<DeleteActionResponse>(request, options);
        }



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
        public virtual Task<DeleteActionResponse> DeleteActionAsync(DeleteActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteActionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAlgorithm

        internal virtual DeleteAlgorithmResponse DeleteAlgorithm(DeleteAlgorithmRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlgorithmResponseUnmarshaller.Instance;

            return Invoke<DeleteAlgorithmResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified algorithm from your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlgorithm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlgorithm service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAlgorithm">REST API Reference for DeleteAlgorithm Operation</seealso>
        public virtual Task<DeleteAlgorithmResponse> DeleteAlgorithmAsync(DeleteAlgorithmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlgorithmResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAlgorithmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApp

        internal virtual DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return Invoke<DeleteAppResponse>(request, options);
        }



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
        public virtual Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAppImageConfig

        internal virtual DeleteAppImageConfigResponse DeleteAppImageConfig(DeleteAppImageConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppImageConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppImageConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteAppImageConfigResponse>(request, options);
        }



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
        public virtual Task<DeleteAppImageConfigResponse> DeleteAppImageConfigAsync(DeleteAppImageConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppImageConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppImageConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAppImageConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteArtifact

        internal virtual DeleteArtifactResponse DeleteArtifact(DeleteArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteArtifactResponseUnmarshaller.Instance;

            return Invoke<DeleteArtifactResponse>(request, options);
        }



        /// <summary>
        /// Deletes an artifact. Either <code>ArtifactArn</code> or <code>Source</code> must be
        /// specified.
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
        public virtual Task<DeleteArtifactResponse> DeleteArtifactAsync(DeleteArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteArtifactResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAssociation

        internal virtual DeleteAssociationResponse DeleteAssociation(DeleteAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteAssociationResponse>(request, options);
        }



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
        public virtual Task<DeleteAssociationResponse> DeleteAssociationAsync(DeleteAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCodeRepository

        internal virtual DeleteCodeRepositoryResponse DeleteCodeRepository(DeleteCodeRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCodeRepositoryResponseUnmarshaller.Instance;

            return Invoke<DeleteCodeRepositoryResponse>(request, options);
        }



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
        public virtual Task<DeleteCodeRepositoryResponse> DeleteCodeRepositoryAsync(DeleteCodeRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCodeRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCodeRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteContext

        internal virtual DeleteContextResponse DeleteContext(DeleteContextRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContextResponseUnmarshaller.Instance;

            return Invoke<DeleteContextResponse>(request, options);
        }



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
        public virtual Task<DeleteContextResponse> DeleteContextAsync(DeleteContextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContextResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteContextResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDataQualityJobDefinition

        internal virtual DeleteDataQualityJobDefinitionResponse DeleteDataQualityJobDefinition(DeleteDataQualityJobDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataQualityJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataQualityJobDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteDataQualityJobDefinitionResponse>(request, options);
        }



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
        public virtual Task<DeleteDataQualityJobDefinitionResponse> DeleteDataQualityJobDefinitionAsync(DeleteDataQualityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataQualityJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataQualityJobDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDataQualityJobDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDeviceFleet

        internal virtual DeleteDeviceFleetResponse DeleteDeviceFleet(DeleteDeviceFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeviceFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeviceFleetResponseUnmarshaller.Instance;

            return Invoke<DeleteDeviceFleetResponse>(request, options);
        }



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
        public virtual Task<DeleteDeviceFleetResponse> DeleteDeviceFleetAsync(DeleteDeviceFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeviceFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeviceFleetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDeviceFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomain

        internal virtual DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainResponse>(request, options);
        }



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
        public virtual Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEdgeDeploymentPlan

        internal virtual DeleteEdgeDeploymentPlanResponse DeleteEdgeDeploymentPlan(DeleteEdgeDeploymentPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEdgeDeploymentPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEdgeDeploymentPlanResponseUnmarshaller.Instance;

            return Invoke<DeleteEdgeDeploymentPlanResponse>(request, options);
        }



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
        public virtual Task<DeleteEdgeDeploymentPlanResponse> DeleteEdgeDeploymentPlanAsync(DeleteEdgeDeploymentPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEdgeDeploymentPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEdgeDeploymentPlanResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEdgeDeploymentPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEdgeDeploymentStage

        internal virtual DeleteEdgeDeploymentStageResponse DeleteEdgeDeploymentStage(DeleteEdgeDeploymentStageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEdgeDeploymentStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEdgeDeploymentStageResponseUnmarshaller.Instance;

            return Invoke<DeleteEdgeDeploymentStageResponse>(request, options);
        }



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
        public virtual Task<DeleteEdgeDeploymentStageResponse> DeleteEdgeDeploymentStageAsync(DeleteEdgeDeploymentStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEdgeDeploymentStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEdgeDeploymentStageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEdgeDeploymentStageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEndpoint

        internal virtual DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        public virtual Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEndpointConfig

        internal virtual DeleteEndpointConfigResponse DeleteEndpointConfig(DeleteEndpointConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointConfigResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEndpointConfig service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpointConfig">REST API Reference for DeleteEndpointConfig Operation</seealso>
        public virtual Task<DeleteEndpointConfigResponse> DeleteEndpointConfigAsync(DeleteEndpointConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEndpointConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteExperiment

        internal virtual DeleteExperimentResponse DeleteExperiment(DeleteExperimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExperimentResponseUnmarshaller.Instance;

            return Invoke<DeleteExperimentResponse>(request, options);
        }



        /// <summary>
        /// Deletes an SageMaker experiment. All trials associated with the experiment must be
        /// deleted first. Use the <a>ListTrials</a> API to get a list of the trials associated
        /// with the experiment.
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
        public virtual Task<DeleteExperimentResponse> DeleteExperimentAsync(DeleteExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExperimentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteExperimentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFeatureGroup

        internal virtual DeleteFeatureGroupResponse DeleteFeatureGroup(DeleteFeatureGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFeatureGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFeatureGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteFeatureGroupResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFeatureGroup service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteFeatureGroup">REST API Reference for DeleteFeatureGroup Operation</seealso>
        public virtual Task<DeleteFeatureGroupResponse> DeleteFeatureGroupAsync(DeleteFeatureGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFeatureGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFeatureGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFeatureGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFlowDefinition

        internal virtual DeleteFlowDefinitionResponse DeleteFlowDefinition(DeleteFlowDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFlowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteFlowDefinitionResponse>(request, options);
        }



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
        public virtual Task<DeleteFlowDefinitionResponse> DeleteFlowDefinitionAsync(DeleteFlowDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFlowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFlowDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteHub

        internal virtual DeleteHubResponse DeleteHub(DeleteHubRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHubResponseUnmarshaller.Instance;

            return Invoke<DeleteHubResponse>(request, options);
        }



        /// <summary>
        /// Delete a hub.
        /// 
        ///  <note> 
        /// <para>
        /// Hub APIs are only callable through SageMaker Studio.
        /// </para>
        ///  </note>
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
        public virtual Task<DeleteHubResponse> DeleteHubAsync(DeleteHubRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHubResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHubResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteHubContent

        internal virtual DeleteHubContentResponse DeleteHubContent(DeleteHubContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHubContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHubContentResponseUnmarshaller.Instance;

            return Invoke<DeleteHubContentResponse>(request, options);
        }



        /// <summary>
        /// Delete the contents of a hub.
        /// 
        ///  <note> 
        /// <para>
        /// Hub APIs are only callable through SageMaker Studio.
        /// </para>
        ///  </note>
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
        public virtual Task<DeleteHubContentResponse> DeleteHubContentAsync(DeleteHubContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHubContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHubContentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHubContentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteHumanTaskUi

        internal virtual DeleteHumanTaskUiResponse DeleteHumanTaskUi(DeleteHumanTaskUiRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHumanTaskUiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHumanTaskUiResponseUnmarshaller.Instance;

            return Invoke<DeleteHumanTaskUiResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHumanTaskUi service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteHumanTaskUi">REST API Reference for DeleteHumanTaskUi Operation</seealso>
        public virtual Task<DeleteHumanTaskUiResponse> DeleteHumanTaskUiAsync(DeleteHumanTaskUiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHumanTaskUiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHumanTaskUiResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHumanTaskUiResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteImage

        internal virtual DeleteImageResponse DeleteImage(DeleteImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageResponseUnmarshaller.Instance;

            return Invoke<DeleteImageResponse>(request, options);
        }



        /// <summary>
        /// Deletes a SageMaker image and all versions of the image. The container images aren't
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
        public virtual Task<DeleteImageResponse> DeleteImageAsync(DeleteImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteImageVersion

        internal virtual DeleteImageVersionResponse DeleteImageVersion(DeleteImageVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteImageVersionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a version of a SageMaker image. The container image the version represents
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
        public virtual Task<DeleteImageVersionResponse> DeleteImageVersionAsync(DeleteImageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImageVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteImageVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInferenceExperiment

        internal virtual DeleteInferenceExperimentResponse DeleteInferenceExperiment(DeleteInferenceExperimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInferenceExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInferenceExperimentResponseUnmarshaller.Instance;

            return Invoke<DeleteInferenceExperimentResponse>(request, options);
        }



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
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteInferenceExperiment">REST API Reference for DeleteInferenceExperiment Operation</seealso>
        public virtual Task<DeleteInferenceExperimentResponse> DeleteInferenceExperimentAsync(DeleteInferenceExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInferenceExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInferenceExperimentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInferenceExperimentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteModel

        internal virtual DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return Invoke<DeleteModelResponse>(request, options);
        }



        /// <summary>
        /// Deletes a model. The <code>DeleteModel</code> API deletes only the model entry that
        /// was created in SageMaker when you called the <code>CreateModel</code> API. It does
        /// not delete model artifacts, inference code, or the IAM role that you specified when
        /// creating the model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModel service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual Task<DeleteModelResponse> DeleteModelAsync(DeleteModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteModelBiasJobDefinition

        internal virtual DeleteModelBiasJobDefinitionResponse DeleteModelBiasJobDefinition(DeleteModelBiasJobDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelBiasJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelBiasJobDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteModelBiasJobDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon SageMaker model bias job definition.
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
        public virtual Task<DeleteModelBiasJobDefinitionResponse> DeleteModelBiasJobDefinitionAsync(DeleteModelBiasJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelBiasJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelBiasJobDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteModelBiasJobDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteModelCard

        internal virtual DeleteModelCardResponse DeleteModelCard(DeleteModelCardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelCardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelCardResponseUnmarshaller.Instance;

            return Invoke<DeleteModelCardResponse>(request, options);
        }



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
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelCard">REST API Reference for DeleteModelCard Operation</seealso>
        public virtual Task<DeleteModelCardResponse> DeleteModelCardAsync(DeleteModelCardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelCardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelCardResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteModelCardResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteModelExplainabilityJobDefinition

        internal virtual DeleteModelExplainabilityJobDefinitionResponse DeleteModelExplainabilityJobDefinition(DeleteModelExplainabilityJobDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelExplainabilityJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelExplainabilityJobDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteModelExplainabilityJobDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon SageMaker model explainability job definition.
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
        public virtual Task<DeleteModelExplainabilityJobDefinitionResponse> DeleteModelExplainabilityJobDefinitionAsync(DeleteModelExplainabilityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelExplainabilityJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelExplainabilityJobDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteModelExplainabilityJobDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteModelPackage

        internal virtual DeleteModelPackageResponse DeleteModelPackage(DeleteModelPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelPackageResponseUnmarshaller.Instance;

            return Invoke<DeleteModelPackageResponse>(request, options);
        }



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
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackage">REST API Reference for DeleteModelPackage Operation</seealso>
        public virtual Task<DeleteModelPackageResponse> DeleteModelPackageAsync(DeleteModelPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelPackageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteModelPackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteModelPackageGroup

        internal virtual DeleteModelPackageGroupResponse DeleteModelPackageGroup(DeleteModelPackageGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelPackageGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelPackageGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteModelPackageGroupResponse>(request, options);
        }



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
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackageGroup">REST API Reference for DeleteModelPackageGroup Operation</seealso>
        public virtual Task<DeleteModelPackageGroupResponse> DeleteModelPackageGroupAsync(DeleteModelPackageGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelPackageGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelPackageGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteModelPackageGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteModelPackageGroupPolicy

        internal virtual DeleteModelPackageGroupPolicyResponse DeleteModelPackageGroupPolicy(DeleteModelPackageGroupPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelPackageGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelPackageGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteModelPackageGroupPolicyResponse>(request, options);
        }



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
        public virtual Task<DeleteModelPackageGroupPolicyResponse> DeleteModelPackageGroupPolicyAsync(DeleteModelPackageGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelPackageGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelPackageGroupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteModelPackageGroupPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteModelQualityJobDefinition

        internal virtual DeleteModelQualityJobDefinitionResponse DeleteModelQualityJobDefinition(DeleteModelQualityJobDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelQualityJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelQualityJobDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteModelQualityJobDefinitionResponse>(request, options);
        }



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
        public virtual Task<DeleteModelQualityJobDefinitionResponse> DeleteModelQualityJobDefinitionAsync(DeleteModelQualityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelQualityJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelQualityJobDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteModelQualityJobDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMonitoringSchedule

        internal virtual DeleteMonitoringScheduleResponse DeleteMonitoringSchedule(DeleteMonitoringScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMonitoringScheduleResponseUnmarshaller.Instance;

            return Invoke<DeleteMonitoringScheduleResponse>(request, options);
        }



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
        public virtual Task<DeleteMonitoringScheduleResponse> DeleteMonitoringScheduleAsync(DeleteMonitoringScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMonitoringScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMonitoringScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNotebookInstance

        internal virtual DeleteNotebookInstanceResponse DeleteNotebookInstance(DeleteNotebookInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteNotebookInstanceResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNotebookInstance service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstance">REST API Reference for DeleteNotebookInstance Operation</seealso>
        public virtual Task<DeleteNotebookInstanceResponse> DeleteNotebookInstanceAsync(DeleteNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotebookInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNotebookInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNotebookInstanceLifecycleConfig

        internal virtual DeleteNotebookInstanceLifecycleConfigResponse DeleteNotebookInstanceLifecycleConfig(DeleteNotebookInstanceLifecycleConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteNotebookInstanceLifecycleConfigResponse>(request, options);
        }



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
        public virtual Task<DeleteNotebookInstanceLifecycleConfigResponse> DeleteNotebookInstanceLifecycleConfigAsync(DeleteNotebookInstanceLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNotebookInstanceLifecycleConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePipeline

        internal virtual DeletePipelineResponse DeletePipeline(DeletePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return Invoke<DeletePipelineResponse>(request, options);
        }



        /// <summary>
        /// Deletes a pipeline if there are no running instances of the pipeline. To delete a
        /// pipeline, you must stop all running instances of the pipeline using the <code>StopPipelineExecution</code>
        /// API. When you delete a pipeline, all instances of the pipeline are deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public virtual Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProject

        internal virtual DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectResponse>(request, options);
        }



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
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSpace

        internal virtual DeleteSpaceResponse DeleteSpace(DeleteSpaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSpaceResponseUnmarshaller.Instance;

            return Invoke<DeleteSpaceResponse>(request, options);
        }



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
        public virtual Task<DeleteSpaceResponse> DeleteSpaceAsync(DeleteSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSpaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSpaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStudioLifecycleConfig

        internal virtual DeleteStudioLifecycleConfigResponse DeleteStudioLifecycleConfig(DeleteStudioLifecycleConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStudioLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStudioLifecycleConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteStudioLifecycleConfigResponse>(request, options);
        }



        /// <summary>
        /// Deletes the Studio Lifecycle Configuration. In order to delete the Lifecycle Configuration,
        /// there must be no running apps using the Lifecycle Configuration. You must also remove
        /// the Lifecycle Configuration from UserSettings in all Domains and UserProfiles.
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
        public virtual Task<DeleteStudioLifecycleConfigResponse> DeleteStudioLifecycleConfigAsync(DeleteStudioLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStudioLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStudioLifecycleConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStudioLifecycleConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTags

        internal virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTrial

        internal virtual DeleteTrialResponse DeleteTrial(DeleteTrialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrialResponseUnmarshaller.Instance;

            return Invoke<DeleteTrialResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified trial. All trial components that make up the trial must be deleted
        /// first. Use the <a>DescribeTrialComponent</a> API to get the list of trial components.
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
        public virtual Task<DeleteTrialResponse> DeleteTrialAsync(DeleteTrialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrialResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrialResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTrialComponent

        internal virtual DeleteTrialComponentResponse DeleteTrialComponent(DeleteTrialComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrialComponentResponseUnmarshaller.Instance;

            return Invoke<DeleteTrialComponentResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified trial component. A trial component must be disassociated from
        /// all trials before the trial component can be deleted. To disassociate a trial component
        /// from a trial, call the <a>DisassociateTrialComponent</a> API.
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
        public virtual Task<DeleteTrialComponentResponse> DeleteTrialComponentAsync(DeleteTrialComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrialComponentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrialComponentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUserProfile

        internal virtual DeleteUserProfileResponse DeleteUserProfile(DeleteUserProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteUserProfileResponse>(request, options);
        }



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
        public virtual Task<DeleteUserProfileResponse> DeleteUserProfileAsync(DeleteUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWorkforce

        internal virtual DeleteWorkforceResponse DeleteWorkforce(DeleteWorkforceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkforceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkforceResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkforceResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkforce service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteWorkforce">REST API Reference for DeleteWorkforce Operation</seealso>
        public virtual Task<DeleteWorkforceResponse> DeleteWorkforceAsync(DeleteWorkforceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkforceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkforceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkforceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWorkteam

        internal virtual DeleteWorkteamResponse DeleteWorkteam(DeleteWorkteamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkteamResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkteamResponse>(request, options);
        }



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
        public virtual Task<DeleteWorkteamResponse> DeleteWorkteamAsync(DeleteWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkteamResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkteamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterDevices

        internal virtual DeregisterDevicesResponse DeregisterDevices(DeregisterDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterDevicesResponseUnmarshaller.Instance;

            return Invoke<DeregisterDevicesResponse>(request, options);
        }



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
        public virtual Task<DeregisterDevicesResponse> DeregisterDevicesAsync(DeregisterDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterDevicesResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterDevicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAction

        internal virtual DescribeActionResponse DescribeAction(DescribeActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActionResponseUnmarshaller.Instance;

            return Invoke<DescribeActionResponse>(request, options);
        }



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
        public virtual Task<DescribeActionResponse> DescribeActionAsync(DescribeActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAlgorithm

        internal virtual DescribeAlgorithmResponse DescribeAlgorithm(DescribeAlgorithmRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlgorithmResponseUnmarshaller.Instance;

            return Invoke<DescribeAlgorithmResponse>(request, options);
        }



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
        public virtual Task<DescribeAlgorithmResponse> DescribeAlgorithmAsync(DescribeAlgorithmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlgorithmResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAlgorithmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeApp

        internal virtual DescribeAppResponse DescribeApp(DescribeAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppResponseUnmarshaller.Instance;

            return Invoke<DescribeAppResponse>(request, options);
        }



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
        public virtual Task<DescribeAppResponse> DescribeAppAsync(DescribeAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAppImageConfig

        internal virtual DescribeAppImageConfigResponse DescribeAppImageConfig(DescribeAppImageConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppImageConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppImageConfigResponseUnmarshaller.Instance;

            return Invoke<DescribeAppImageConfigResponse>(request, options);
        }



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
        public virtual Task<DescribeAppImageConfigResponse> DescribeAppImageConfigAsync(DescribeAppImageConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppImageConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppImageConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAppImageConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeArtifact

        internal virtual DescribeArtifactResponse DescribeArtifact(DescribeArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeArtifactResponseUnmarshaller.Instance;

            return Invoke<DescribeArtifactResponse>(request, options);
        }



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
        public virtual Task<DescribeArtifactResponse> DescribeArtifactAsync(DescribeArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeArtifactResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAutoMLJob

        internal virtual DescribeAutoMLJobResponse DescribeAutoMLJob(DescribeAutoMLJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutoMLJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoMLJobResponseUnmarshaller.Instance;

            return Invoke<DescribeAutoMLJobResponse>(request, options);
        }



        /// <summary>
        /// Returns information about an Amazon SageMaker AutoML job.
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
        public virtual Task<DescribeAutoMLJobResponse> DescribeAutoMLJobAsync(DescribeAutoMLJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutoMLJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoMLJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAutoMLJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCodeRepository

        internal virtual DescribeCodeRepositoryResponse DescribeCodeRepository(DescribeCodeRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCodeRepositoryResponseUnmarshaller.Instance;

            return Invoke<DescribeCodeRepositoryResponse>(request, options);
        }



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
        public virtual Task<DescribeCodeRepositoryResponse> DescribeCodeRepositoryAsync(DescribeCodeRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCodeRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCodeRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCompilationJob

        internal virtual DescribeCompilationJobResponse DescribeCompilationJob(DescribeCompilationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCompilationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCompilationJobResponseUnmarshaller.Instance;

            return Invoke<DescribeCompilationJobResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCompilationJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCompilationJob">REST API Reference for DescribeCompilationJob Operation</seealso>
        public virtual Task<DescribeCompilationJobResponse> DescribeCompilationJobAsync(DescribeCompilationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCompilationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCompilationJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCompilationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeContext

        internal virtual DescribeContextResponse DescribeContext(DescribeContextRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeContextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContextResponseUnmarshaller.Instance;

            return Invoke<DescribeContextResponse>(request, options);
        }



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
        public virtual Task<DescribeContextResponse> DescribeContextAsync(DescribeContextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeContextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContextResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeContextResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDataQualityJobDefinition

        internal virtual DescribeDataQualityJobDefinitionResponse DescribeDataQualityJobDefinition(DescribeDataQualityJobDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataQualityJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataQualityJobDefinitionResponseUnmarshaller.Instance;

            return Invoke<DescribeDataQualityJobDefinitionResponse>(request, options);
        }



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
        public virtual Task<DescribeDataQualityJobDefinitionResponse> DescribeDataQualityJobDefinitionAsync(DescribeDataQualityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataQualityJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataQualityJobDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDataQualityJobDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDevice

        internal virtual DescribeDeviceResponse DescribeDevice(DescribeDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeviceResponseUnmarshaller.Instance;

            return Invoke<DescribeDeviceResponse>(request, options);
        }



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
        public virtual Task<DescribeDeviceResponse> DescribeDeviceAsync(DescribeDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDeviceFleet

        internal virtual DescribeDeviceFleetResponse DescribeDeviceFleet(DescribeDeviceFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeviceFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeviceFleetResponseUnmarshaller.Instance;

            return Invoke<DescribeDeviceFleetResponse>(request, options);
        }



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
        public virtual Task<DescribeDeviceFleetResponse> DescribeDeviceFleetAsync(DescribeDeviceFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeviceFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeviceFleetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDeviceFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDomain

        internal virtual DescribeDomainResponse DescribeDomain(DescribeDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainResponse>(request, options);
        }



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
        public virtual Task<DescribeDomainResponse> DescribeDomainAsync(DescribeDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEdgeDeploymentPlan

        internal virtual DescribeEdgeDeploymentPlanResponse DescribeEdgeDeploymentPlan(DescribeEdgeDeploymentPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEdgeDeploymentPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEdgeDeploymentPlanResponseUnmarshaller.Instance;

            return Invoke<DescribeEdgeDeploymentPlanResponse>(request, options);
        }



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
        public virtual Task<DescribeEdgeDeploymentPlanResponse> DescribeEdgeDeploymentPlanAsync(DescribeEdgeDeploymentPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEdgeDeploymentPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEdgeDeploymentPlanResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEdgeDeploymentPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEdgePackagingJob

        internal virtual DescribeEdgePackagingJobResponse DescribeEdgePackagingJob(DescribeEdgePackagingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEdgePackagingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEdgePackagingJobResponseUnmarshaller.Instance;

            return Invoke<DescribeEdgePackagingJobResponse>(request, options);
        }



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
        public virtual Task<DescribeEdgePackagingJobResponse> DescribeEdgePackagingJobAsync(DescribeEdgePackagingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEdgePackagingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEdgePackagingJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEdgePackagingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEndpoint

        internal virtual DescribeEndpointResponse DescribeEndpoint(DescribeEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointResponse>(request, options);
        }



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
        public virtual Task<DescribeEndpointResponse> DescribeEndpointAsync(DescribeEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEndpointConfig

        internal virtual DescribeEndpointConfigResponse DescribeEndpointConfig(DescribeEndpointConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointConfigResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointConfigResponse>(request, options);
        }



        /// <summary>
        /// Returns the description of an endpoint configuration created using the <code>CreateEndpointConfig</code>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEndpointConfig service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpointConfig">REST API Reference for DescribeEndpointConfig Operation</seealso>
        public virtual Task<DescribeEndpointConfigResponse> DescribeEndpointConfigAsync(DescribeEndpointConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEndpointConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeExperiment

        internal virtual DescribeExperimentResponse DescribeExperiment(DescribeExperimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExperimentResponseUnmarshaller.Instance;

            return Invoke<DescribeExperimentResponse>(request, options);
        }



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
        public virtual Task<DescribeExperimentResponse> DescribeExperimentAsync(DescribeExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExperimentResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeExperimentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFeatureGroup

        internal virtual DescribeFeatureGroupResponse DescribeFeatureGroup(DescribeFeatureGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFeatureGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFeatureGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeFeatureGroupResponse>(request, options);
        }



        /// <summary>
        /// Use this operation to describe a <code>FeatureGroup</code>. The response includes
        /// information on the creation time, <code>FeatureGroup</code> name, the unique identifier
        /// for each <code>FeatureGroup</code>, and more.
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
        public virtual Task<DescribeFeatureGroupResponse> DescribeFeatureGroupAsync(DescribeFeatureGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFeatureGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFeatureGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFeatureGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFeatureMetadata

        internal virtual DescribeFeatureMetadataResponse DescribeFeatureMetadata(DescribeFeatureMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFeatureMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFeatureMetadataResponseUnmarshaller.Instance;

            return Invoke<DescribeFeatureMetadataResponse>(request, options);
        }



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
        public virtual Task<DescribeFeatureMetadataResponse> DescribeFeatureMetadataAsync(DescribeFeatureMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFeatureMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFeatureMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFeatureMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFlowDefinition

        internal virtual DescribeFlowDefinitionResponse DescribeFlowDefinition(DescribeFlowDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFlowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowDefinitionResponseUnmarshaller.Instance;

            return Invoke<DescribeFlowDefinitionResponse>(request, options);
        }



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
        public virtual Task<DescribeFlowDefinitionResponse> DescribeFlowDefinitionAsync(DescribeFlowDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFlowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFlowDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeHub

        internal virtual DescribeHubResponse DescribeHub(DescribeHubRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHubResponseUnmarshaller.Instance;

            return Invoke<DescribeHubResponse>(request, options);
        }



        /// <summary>
        /// Describe a hub.
        /// 
        ///  <note> 
        /// <para>
        /// Hub APIs are only callable through SageMaker Studio.
        /// </para>
        ///  </note>
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
        public virtual Task<DescribeHubResponse> DescribeHubAsync(DescribeHubRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHubResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHubResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeHubContent

        internal virtual DescribeHubContentResponse DescribeHubContent(DescribeHubContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHubContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHubContentResponseUnmarshaller.Instance;

            return Invoke<DescribeHubContentResponse>(request, options);
        }



        /// <summary>
        /// Describe the content of a hub.
        /// 
        ///  <note> 
        /// <para>
        /// Hub APIs are only callable through SageMaker Studio.
        /// </para>
        ///  </note>
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
        public virtual Task<DescribeHubContentResponse> DescribeHubContentAsync(DescribeHubContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHubContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHubContentResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHubContentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeHumanTaskUi

        internal virtual DescribeHumanTaskUiResponse DescribeHumanTaskUi(DescribeHumanTaskUiRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHumanTaskUiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHumanTaskUiResponseUnmarshaller.Instance;

            return Invoke<DescribeHumanTaskUiResponse>(request, options);
        }



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
        public virtual Task<DescribeHumanTaskUiResponse> DescribeHumanTaskUiAsync(DescribeHumanTaskUiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHumanTaskUiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHumanTaskUiResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHumanTaskUiResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeHyperParameterTuningJob

        internal virtual DescribeHyperParameterTuningJobResponse DescribeHyperParameterTuningJob(DescribeHyperParameterTuningJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHyperParameterTuningJobResponseUnmarshaller.Instance;

            return Invoke<DescribeHyperParameterTuningJobResponse>(request, options);
        }



        /// <summary>
        /// Gets a description of a hyperparameter tuning job.
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
        public virtual Task<DescribeHyperParameterTuningJobResponse> DescribeHyperParameterTuningJobAsync(DescribeHyperParameterTuningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHyperParameterTuningJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHyperParameterTuningJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeImage

        internal virtual DescribeImageResponse DescribeImage(DescribeImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImageResponseUnmarshaller.Instance;

            return Invoke<DescribeImageResponse>(request, options);
        }



        /// <summary>
        /// Describes a SageMaker image.
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
        public virtual Task<DescribeImageResponse> DescribeImageAsync(DescribeImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImageResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeImageVersion

        internal virtual DescribeImageVersionResponse DescribeImageVersion(DescribeImageVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImageVersionResponseUnmarshaller.Instance;

            return Invoke<DescribeImageVersionResponse>(request, options);
        }



        /// <summary>
        /// Describes a version of a SageMaker image.
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
        public virtual Task<DescribeImageVersionResponse> DescribeImageVersionAsync(DescribeImageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImageVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImageVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInferenceExperiment

        internal virtual DescribeInferenceExperimentResponse DescribeInferenceExperiment(DescribeInferenceExperimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInferenceExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInferenceExperimentResponseUnmarshaller.Instance;

            return Invoke<DescribeInferenceExperimentResponse>(request, options);
        }



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
        public virtual Task<DescribeInferenceExperimentResponse> DescribeInferenceExperimentAsync(DescribeInferenceExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInferenceExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInferenceExperimentResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInferenceExperimentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInferenceRecommendationsJob

        internal virtual DescribeInferenceRecommendationsJobResponse DescribeInferenceRecommendationsJob(DescribeInferenceRecommendationsJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInferenceRecommendationsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInferenceRecommendationsJobResponseUnmarshaller.Instance;

            return Invoke<DescribeInferenceRecommendationsJobResponse>(request, options);
        }



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
        public virtual Task<DescribeInferenceRecommendationsJobResponse> DescribeInferenceRecommendationsJobAsync(DescribeInferenceRecommendationsJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInferenceRecommendationsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInferenceRecommendationsJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInferenceRecommendationsJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLabelingJob

        internal virtual DescribeLabelingJobResponse DescribeLabelingJob(DescribeLabelingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLabelingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLabelingJobResponseUnmarshaller.Instance;

            return Invoke<DescribeLabelingJobResponse>(request, options);
        }



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
        public virtual Task<DescribeLabelingJobResponse> DescribeLabelingJobAsync(DescribeLabelingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLabelingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLabelingJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLabelingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLineageGroup

        internal virtual DescribeLineageGroupResponse DescribeLineageGroup(DescribeLineageGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLineageGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLineageGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeLineageGroupResponse>(request, options);
        }



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
        public virtual Task<DescribeLineageGroupResponse> DescribeLineageGroupAsync(DescribeLineageGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLineageGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLineageGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLineageGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeModel

        internal virtual DescribeModelResponse DescribeModel(DescribeModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelResponseUnmarshaller.Instance;

            return Invoke<DescribeModelResponse>(request, options);
        }



        /// <summary>
        /// Describes a model that you created using the <code>CreateModel</code> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeModel service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        public virtual Task<DescribeModelResponse> DescribeModelAsync(DescribeModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeModelBiasJobDefinition

        internal virtual DescribeModelBiasJobDefinitionResponse DescribeModelBiasJobDefinition(DescribeModelBiasJobDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelBiasJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelBiasJobDefinitionResponseUnmarshaller.Instance;

            return Invoke<DescribeModelBiasJobDefinitionResponse>(request, options);
        }



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
        public virtual Task<DescribeModelBiasJobDefinitionResponse> DescribeModelBiasJobDefinitionAsync(DescribeModelBiasJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelBiasJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelBiasJobDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeModelBiasJobDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeModelCard

        internal virtual DescribeModelCardResponse DescribeModelCard(DescribeModelCardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelCardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelCardResponseUnmarshaller.Instance;

            return Invoke<DescribeModelCardResponse>(request, options);
        }



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
        public virtual Task<DescribeModelCardResponse> DescribeModelCardAsync(DescribeModelCardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelCardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelCardResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeModelCardResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeModelCardExportJob

        internal virtual DescribeModelCardExportJobResponse DescribeModelCardExportJob(DescribeModelCardExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelCardExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelCardExportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeModelCardExportJobResponse>(request, options);
        }



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
        public virtual Task<DescribeModelCardExportJobResponse> DescribeModelCardExportJobAsync(DescribeModelCardExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelCardExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelCardExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeModelCardExportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeModelExplainabilityJobDefinition

        internal virtual DescribeModelExplainabilityJobDefinitionResponse DescribeModelExplainabilityJobDefinition(DescribeModelExplainabilityJobDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelExplainabilityJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelExplainabilityJobDefinitionResponseUnmarshaller.Instance;

            return Invoke<DescribeModelExplainabilityJobDefinitionResponse>(request, options);
        }



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
        public virtual Task<DescribeModelExplainabilityJobDefinitionResponse> DescribeModelExplainabilityJobDefinitionAsync(DescribeModelExplainabilityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelExplainabilityJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelExplainabilityJobDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeModelExplainabilityJobDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeModelPackage

        internal virtual DescribeModelPackageResponse DescribeModelPackage(DescribeModelPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelPackageResponseUnmarshaller.Instance;

            return Invoke<DescribeModelPackageResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeModelPackage service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelPackage">REST API Reference for DescribeModelPackage Operation</seealso>
        public virtual Task<DescribeModelPackageResponse> DescribeModelPackageAsync(DescribeModelPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelPackageResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeModelPackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeModelPackageGroup

        internal virtual DescribeModelPackageGroupResponse DescribeModelPackageGroup(DescribeModelPackageGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelPackageGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelPackageGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeModelPackageGroupResponse>(request, options);
        }



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
        public virtual Task<DescribeModelPackageGroupResponse> DescribeModelPackageGroupAsync(DescribeModelPackageGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelPackageGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelPackageGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeModelPackageGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeModelQualityJobDefinition

        internal virtual DescribeModelQualityJobDefinitionResponse DescribeModelQualityJobDefinition(DescribeModelQualityJobDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelQualityJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelQualityJobDefinitionResponseUnmarshaller.Instance;

            return Invoke<DescribeModelQualityJobDefinitionResponse>(request, options);
        }



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
        public virtual Task<DescribeModelQualityJobDefinitionResponse> DescribeModelQualityJobDefinitionAsync(DescribeModelQualityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelQualityJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelQualityJobDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeModelQualityJobDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMonitoringSchedule

        internal virtual DescribeMonitoringScheduleResponse DescribeMonitoringSchedule(DescribeMonitoringScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMonitoringScheduleResponseUnmarshaller.Instance;

            return Invoke<DescribeMonitoringScheduleResponse>(request, options);
        }



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
        public virtual Task<DescribeMonitoringScheduleResponse> DescribeMonitoringScheduleAsync(DescribeMonitoringScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMonitoringScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMonitoringScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNotebookInstance

        internal virtual DescribeNotebookInstanceResponse DescribeNotebookInstance(DescribeNotebookInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<DescribeNotebookInstanceResponse>(request, options);
        }



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
        public virtual Task<DescribeNotebookInstanceResponse> DescribeNotebookInstanceAsync(DescribeNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotebookInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNotebookInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNotebookInstanceLifecycleConfig

        internal virtual DescribeNotebookInstanceLifecycleConfigResponse DescribeNotebookInstanceLifecycleConfig(DescribeNotebookInstanceLifecycleConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return Invoke<DescribeNotebookInstanceLifecycleConfigResponse>(request, options);
        }



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
        public virtual Task<DescribeNotebookInstanceLifecycleConfigResponse> DescribeNotebookInstanceLifecycleConfigAsync(DescribeNotebookInstanceLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNotebookInstanceLifecycleConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePipeline

        internal virtual DescribePipelineResponse DescribePipeline(DescribePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePipelineResponseUnmarshaller.Instance;

            return Invoke<DescribePipelineResponse>(request, options);
        }



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
        public virtual Task<DescribePipelineResponse> DescribePipelineAsync(DescribePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePipelineDefinitionForExecution

        internal virtual DescribePipelineDefinitionForExecutionResponse DescribePipelineDefinitionForExecution(DescribePipelineDefinitionForExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePipelineDefinitionForExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePipelineDefinitionForExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribePipelineDefinitionForExecutionResponse>(request, options);
        }



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
        public virtual Task<DescribePipelineDefinitionForExecutionResponse> DescribePipelineDefinitionForExecutionAsync(DescribePipelineDefinitionForExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePipelineDefinitionForExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePipelineDefinitionForExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePipelineDefinitionForExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePipelineExecution

        internal virtual DescribePipelineExecutionResponse DescribePipelineExecution(DescribePipelineExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePipelineExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribePipelineExecutionResponse>(request, options);
        }



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
        public virtual Task<DescribePipelineExecutionResponse> DescribePipelineExecutionAsync(DescribePipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePipelineExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePipelineExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProcessingJob

        internal virtual DescribeProcessingJobResponse DescribeProcessingJob(DescribeProcessingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProcessingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProcessingJobResponseUnmarshaller.Instance;

            return Invoke<DescribeProcessingJobResponse>(request, options);
        }



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
        public virtual Task<DescribeProcessingJobResponse> DescribeProcessingJobAsync(DescribeProcessingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProcessingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProcessingJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProcessingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProject

        internal virtual DescribeProjectResponse DescribeProject(DescribeProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProjectResponseUnmarshaller.Instance;

            return Invoke<DescribeProjectResponse>(request, options);
        }



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
        public virtual Task<DescribeProjectResponse> DescribeProjectAsync(DescribeProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProjectResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpace

        internal virtual DescribeSpaceResponse DescribeSpace(DescribeSpaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpaceResponseUnmarshaller.Instance;

            return Invoke<DescribeSpaceResponse>(request, options);
        }



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
        public virtual Task<DescribeSpaceResponse> DescribeSpaceAsync(DescribeSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpaceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStudioLifecycleConfig

        internal virtual DescribeStudioLifecycleConfigResponse DescribeStudioLifecycleConfig(DescribeStudioLifecycleConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStudioLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStudioLifecycleConfigResponseUnmarshaller.Instance;

            return Invoke<DescribeStudioLifecycleConfigResponse>(request, options);
        }



        /// <summary>
        /// Describes the Studio Lifecycle Configuration.
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
        public virtual Task<DescribeStudioLifecycleConfigResponse> DescribeStudioLifecycleConfigAsync(DescribeStudioLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStudioLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStudioLifecycleConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStudioLifecycleConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSubscribedWorkteam

        internal virtual DescribeSubscribedWorkteamResponse DescribeSubscribedWorkteam(DescribeSubscribedWorkteamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSubscribedWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubscribedWorkteamResponseUnmarshaller.Instance;

            return Invoke<DescribeSubscribedWorkteamResponse>(request, options);
        }



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
        public virtual Task<DescribeSubscribedWorkteamResponse> DescribeSubscribedWorkteamAsync(DescribeSubscribedWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSubscribedWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubscribedWorkteamResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSubscribedWorkteamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTrainingJob

        internal virtual DescribeTrainingJobResponse DescribeTrainingJob(DescribeTrainingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrainingJobResponseUnmarshaller.Instance;

            return Invoke<DescribeTrainingJobResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrainingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrainingJob">REST API Reference for DescribeTrainingJob Operation</seealso>
        public virtual Task<DescribeTrainingJobResponse> DescribeTrainingJobAsync(DescribeTrainingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrainingJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTrainingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTransformJob

        internal virtual DescribeTransformJobResponse DescribeTransformJob(DescribeTransformJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransformJobResponseUnmarshaller.Instance;

            return Invoke<DescribeTransformJobResponse>(request, options);
        }



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
        public virtual Task<DescribeTransformJobResponse> DescribeTransformJobAsync(DescribeTransformJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransformJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTransformJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTrial

        internal virtual DescribeTrialResponse DescribeTrial(DescribeTrialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrialResponseUnmarshaller.Instance;

            return Invoke<DescribeTrialResponse>(request, options);
        }



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
        public virtual Task<DescribeTrialResponse> DescribeTrialAsync(DescribeTrialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrialResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTrialResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTrialComponent

        internal virtual DescribeTrialComponentResponse DescribeTrialComponent(DescribeTrialComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrialComponentResponseUnmarshaller.Instance;

            return Invoke<DescribeTrialComponentResponse>(request, options);
        }



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
        public virtual Task<DescribeTrialComponentResponse> DescribeTrialComponentAsync(DescribeTrialComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrialComponentResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTrialComponentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeUserProfile

        internal virtual DescribeUserProfileResponse DescribeUserProfile(DescribeUserProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserProfileResponseUnmarshaller.Instance;

            return Invoke<DescribeUserProfileResponse>(request, options);
        }



        /// <summary>
        /// Describes a user profile. For more information, see <code>CreateUserProfile</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUserProfile service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeUserProfile">REST API Reference for DescribeUserProfile Operation</seealso>
        public virtual Task<DescribeUserProfileResponse> DescribeUserProfileAsync(DescribeUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUserProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkforce

        internal virtual DescribeWorkforceResponse DescribeWorkforce(DescribeWorkforceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkforceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkforceResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkforceResponse>(request, options);
        }



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
        public virtual Task<DescribeWorkforceResponse> DescribeWorkforceAsync(DescribeWorkforceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkforceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkforceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkforceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkteam

        internal virtual DescribeWorkteamResponse DescribeWorkteam(DescribeWorkteamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkteamResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkteamResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a specific work team. You can see information such as the create
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
        public virtual Task<DescribeWorkteamResponse> DescribeWorkteamAsync(DescribeWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkteamResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkteamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableSagemakerServicecatalogPortfolio

        internal virtual DisableSagemakerServicecatalogPortfolioResponse DisableSagemakerServicecatalogPortfolio(DisableSagemakerServicecatalogPortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableSagemakerServicecatalogPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableSagemakerServicecatalogPortfolioResponseUnmarshaller.Instance;

            return Invoke<DisableSagemakerServicecatalogPortfolioResponse>(request, options);
        }



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
        public virtual Task<DisableSagemakerServicecatalogPortfolioResponse> DisableSagemakerServicecatalogPortfolioAsync(DisableSagemakerServicecatalogPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableSagemakerServicecatalogPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableSagemakerServicecatalogPortfolioResponseUnmarshaller.Instance;

            return InvokeAsync<DisableSagemakerServicecatalogPortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateTrialComponent

        internal virtual DisassociateTrialComponentResponse DisassociateTrialComponent(DisassociateTrialComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTrialComponentResponseUnmarshaller.Instance;

            return Invoke<DisassociateTrialComponentResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DisassociateTrialComponent">REST API Reference for DisassociateTrialComponent Operation</seealso>
        public virtual Task<DisassociateTrialComponentResponse> DisassociateTrialComponentAsync(DisassociateTrialComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTrialComponentResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateTrialComponentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableSagemakerServicecatalogPortfolio

        internal virtual EnableSagemakerServicecatalogPortfolioResponse EnableSagemakerServicecatalogPortfolio(EnableSagemakerServicecatalogPortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableSagemakerServicecatalogPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSagemakerServicecatalogPortfolioResponseUnmarshaller.Instance;

            return Invoke<EnableSagemakerServicecatalogPortfolioResponse>(request, options);
        }



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
        public virtual Task<EnableSagemakerServicecatalogPortfolioResponse> EnableSagemakerServicecatalogPortfolioAsync(EnableSagemakerServicecatalogPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableSagemakerServicecatalogPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSagemakerServicecatalogPortfolioResponseUnmarshaller.Instance;

            return InvokeAsync<EnableSagemakerServicecatalogPortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDeviceFleetReport

        internal virtual GetDeviceFleetReportResponse GetDeviceFleetReport(GetDeviceFleetReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceFleetReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceFleetReportResponseUnmarshaller.Instance;

            return Invoke<GetDeviceFleetReportResponse>(request, options);
        }



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
        public virtual Task<GetDeviceFleetReportResponse> GetDeviceFleetReportAsync(GetDeviceFleetReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceFleetReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceFleetReportResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeviceFleetReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLineageGroupPolicy

        internal virtual GetLineageGroupPolicyResponse GetLineageGroupPolicy(GetLineageGroupPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLineageGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLineageGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<GetLineageGroupPolicyResponse>(request, options);
        }



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
        public virtual Task<GetLineageGroupPolicyResponse> GetLineageGroupPolicyAsync(GetLineageGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLineageGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLineageGroupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetLineageGroupPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetModelPackageGroupPolicy

        internal virtual GetModelPackageGroupPolicyResponse GetModelPackageGroupPolicy(GetModelPackageGroupPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelPackageGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelPackageGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<GetModelPackageGroupPolicyResponse>(request, options);
        }



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
        public virtual Task<GetModelPackageGroupPolicyResponse> GetModelPackageGroupPolicyAsync(GetModelPackageGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelPackageGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelPackageGroupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetModelPackageGroupPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSagemakerServicecatalogPortfolioStatus

        internal virtual GetSagemakerServicecatalogPortfolioStatusResponse GetSagemakerServicecatalogPortfolioStatus(GetSagemakerServicecatalogPortfolioStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSagemakerServicecatalogPortfolioStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSagemakerServicecatalogPortfolioStatusResponseUnmarshaller.Instance;

            return Invoke<GetSagemakerServicecatalogPortfolioStatusResponse>(request, options);
        }



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
        public virtual Task<GetSagemakerServicecatalogPortfolioStatusResponse> GetSagemakerServicecatalogPortfolioStatusAsync(GetSagemakerServicecatalogPortfolioStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSagemakerServicecatalogPortfolioStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSagemakerServicecatalogPortfolioStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetSagemakerServicecatalogPortfolioStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSearchSuggestions

        internal virtual GetSearchSuggestionsResponse GetSearchSuggestions(GetSearchSuggestionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSearchSuggestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSearchSuggestionsResponseUnmarshaller.Instance;

            return Invoke<GetSearchSuggestionsResponse>(request, options);
        }



        /// <summary>
        /// An auto-complete API for the search functionality in the SageMaker console. It returns
        /// suggestions of possible matches for the property name to use in <code>Search</code>
        /// queries. Provides suggestions for <code>HyperParameters</code>, <code>Tags</code>,
        /// and <code>Metrics</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSearchSuggestions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSearchSuggestions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetSearchSuggestions">REST API Reference for GetSearchSuggestions Operation</seealso>
        public virtual Task<GetSearchSuggestionsResponse> GetSearchSuggestionsAsync(GetSearchSuggestionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSearchSuggestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSearchSuggestionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSearchSuggestionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportHubContent

        internal virtual ImportHubContentResponse ImportHubContent(ImportHubContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportHubContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportHubContentResponseUnmarshaller.Instance;

            return Invoke<ImportHubContentResponse>(request, options);
        }



        /// <summary>
        /// Import hub content.
        /// 
        ///  <note> 
        /// <para>
        /// Hub APIs are only callable through SageMaker Studio.
        /// </para>
        ///  </note>
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
        public virtual Task<ImportHubContentResponse> ImportHubContentAsync(ImportHubContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportHubContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportHubContentResponseUnmarshaller.Instance;

            return InvokeAsync<ImportHubContentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListActions

        internal virtual ListActionsResponse ListActions(ListActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActionsResponseUnmarshaller.Instance;

            return Invoke<ListActionsResponse>(request, options);
        }



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
        public virtual Task<ListActionsResponse> ListActionsAsync(ListActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAlgorithms

        internal virtual ListAlgorithmsResponse ListAlgorithms(ListAlgorithmsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAlgorithmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlgorithmsResponseUnmarshaller.Instance;

            return Invoke<ListAlgorithmsResponse>(request, options);
        }



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
        public virtual Task<ListAlgorithmsResponse> ListAlgorithmsAsync(ListAlgorithmsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAlgorithmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlgorithmsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAlgorithmsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAliases

        internal virtual ListAliasesResponse ListAliases(ListAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAliasesResponse>(request, options);
        }



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
        public virtual Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAliasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAppImageConfigs

        internal virtual ListAppImageConfigsResponse ListAppImageConfigs(ListAppImageConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppImageConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppImageConfigsResponseUnmarshaller.Instance;

            return Invoke<ListAppImageConfigsResponse>(request, options);
        }



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
        public virtual Task<ListAppImageConfigsResponse> ListAppImageConfigsAsync(ListAppImageConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppImageConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppImageConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAppImageConfigsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApps

        internal virtual ListAppsResponse ListApps(ListAppsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppsResponseUnmarshaller.Instance;

            return Invoke<ListAppsResponse>(request, options);
        }



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
        public virtual Task<ListAppsResponse> ListAppsAsync(ListAppsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAppsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListArtifacts

        internal virtual ListArtifactsResponse ListArtifacts(ListArtifactsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArtifactsResponseUnmarshaller.Instance;

            return Invoke<ListArtifactsResponse>(request, options);
        }



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
        public virtual Task<ListArtifactsResponse> ListArtifactsAsync(ListArtifactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArtifactsResponseUnmarshaller.Instance;

            return InvokeAsync<ListArtifactsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssociations

        internal virtual ListAssociationsResponse ListAssociations(ListAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListAssociationsResponse>(request, options);
        }



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
        public virtual Task<ListAssociationsResponse> ListAssociationsAsync(ListAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAutoMLJobs

        internal virtual ListAutoMLJobsResponse ListAutoMLJobs(ListAutoMLJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAutoMLJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutoMLJobsResponseUnmarshaller.Instance;

            return Invoke<ListAutoMLJobsResponse>(request, options);
        }



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
        public virtual Task<ListAutoMLJobsResponse> ListAutoMLJobsAsync(ListAutoMLJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAutoMLJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutoMLJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAutoMLJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCandidatesForAutoMLJob

        internal virtual ListCandidatesForAutoMLJobResponse ListCandidatesForAutoMLJob(ListCandidatesForAutoMLJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCandidatesForAutoMLJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCandidatesForAutoMLJobResponseUnmarshaller.Instance;

            return Invoke<ListCandidatesForAutoMLJobResponse>(request, options);
        }



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
        public virtual Task<ListCandidatesForAutoMLJobResponse> ListCandidatesForAutoMLJobAsync(ListCandidatesForAutoMLJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCandidatesForAutoMLJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCandidatesForAutoMLJobResponseUnmarshaller.Instance;

            return InvokeAsync<ListCandidatesForAutoMLJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCodeRepositories

        internal virtual ListCodeRepositoriesResponse ListCodeRepositories(ListCodeRepositoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCodeRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeRepositoriesResponseUnmarshaller.Instance;

            return Invoke<ListCodeRepositoriesResponse>(request, options);
        }



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
        public virtual Task<ListCodeRepositoriesResponse> ListCodeRepositoriesAsync(ListCodeRepositoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCodeRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeRepositoriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCodeRepositoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCompilationJobs

        internal virtual ListCompilationJobsResponse ListCompilationJobs(ListCompilationJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCompilationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCompilationJobsResponseUnmarshaller.Instance;

            return Invoke<ListCompilationJobsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCompilationJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCompilationJobs">REST API Reference for ListCompilationJobs Operation</seealso>
        public virtual Task<ListCompilationJobsResponse> ListCompilationJobsAsync(ListCompilationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCompilationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCompilationJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCompilationJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListContexts

        internal virtual ListContextsResponse ListContexts(ListContextsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContextsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContextsResponseUnmarshaller.Instance;

            return Invoke<ListContextsResponse>(request, options);
        }



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
        public virtual Task<ListContextsResponse> ListContextsAsync(ListContextsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListContextsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContextsResponseUnmarshaller.Instance;

            return InvokeAsync<ListContextsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDataQualityJobDefinitions

        internal virtual ListDataQualityJobDefinitionsResponse ListDataQualityJobDefinitions(ListDataQualityJobDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataQualityJobDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataQualityJobDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListDataQualityJobDefinitionsResponse>(request, options);
        }



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
        public virtual Task<ListDataQualityJobDefinitionsResponse> ListDataQualityJobDefinitionsAsync(ListDataQualityJobDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataQualityJobDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataQualityJobDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataQualityJobDefinitionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDeviceFleets

        internal virtual ListDeviceFleetsResponse ListDeviceFleets(ListDeviceFleetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeviceFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceFleetsResponseUnmarshaller.Instance;

            return Invoke<ListDeviceFleetsResponse>(request, options);
        }



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
        public virtual Task<ListDeviceFleetsResponse> ListDeviceFleetsAsync(ListDeviceFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeviceFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceFleetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeviceFleetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDevices

        internal virtual ListDevicesResponse ListDevices(ListDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return Invoke<ListDevicesResponse>(request, options);
        }



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
        public virtual Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDevicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDomains

        internal virtual ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return Invoke<ListDomainsResponse>(request, options);
        }



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
        public virtual Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEdgeDeploymentPlans

        internal virtual ListEdgeDeploymentPlansResponse ListEdgeDeploymentPlans(ListEdgeDeploymentPlansRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEdgeDeploymentPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEdgeDeploymentPlansResponseUnmarshaller.Instance;

            return Invoke<ListEdgeDeploymentPlansResponse>(request, options);
        }



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
        public virtual Task<ListEdgeDeploymentPlansResponse> ListEdgeDeploymentPlansAsync(ListEdgeDeploymentPlansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEdgeDeploymentPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEdgeDeploymentPlansResponseUnmarshaller.Instance;

            return InvokeAsync<ListEdgeDeploymentPlansResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEdgePackagingJobs

        internal virtual ListEdgePackagingJobsResponse ListEdgePackagingJobs(ListEdgePackagingJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEdgePackagingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEdgePackagingJobsResponseUnmarshaller.Instance;

            return Invoke<ListEdgePackagingJobsResponse>(request, options);
        }



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
        public virtual Task<ListEdgePackagingJobsResponse> ListEdgePackagingJobsAsync(ListEdgePackagingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEdgePackagingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEdgePackagingJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEdgePackagingJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEndpointConfigs

        internal virtual ListEndpointConfigsResponse ListEndpointConfigs(ListEndpointConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointConfigsResponseUnmarshaller.Instance;

            return Invoke<ListEndpointConfigsResponse>(request, options);
        }



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
        public virtual Task<ListEndpointConfigsResponse> ListEndpointConfigsAsync(ListEndpointConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEndpointConfigsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEndpoints

        internal virtual ListEndpointsResponse ListEndpoints(ListEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListEndpointsResponse>(request, options);
        }



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
        public virtual Task<ListEndpointsResponse> ListEndpointsAsync(ListEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListExperiments

        internal virtual ListExperimentsResponse ListExperiments(ListExperimentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExperimentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentsResponseUnmarshaller.Instance;

            return Invoke<ListExperimentsResponse>(request, options);
        }



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
        public virtual Task<ListExperimentsResponse> ListExperimentsAsync(ListExperimentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExperimentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListExperimentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFeatureGroups

        internal virtual ListFeatureGroupsResponse ListFeatureGroups(ListFeatureGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFeatureGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFeatureGroupsResponseUnmarshaller.Instance;

            return Invoke<ListFeatureGroupsResponse>(request, options);
        }



        /// <summary>
        /// List <code>FeatureGroup</code>s based on given filter and order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFeatureGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFeatureGroups service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListFeatureGroups">REST API Reference for ListFeatureGroups Operation</seealso>
        public virtual Task<ListFeatureGroupsResponse> ListFeatureGroupsAsync(ListFeatureGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFeatureGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFeatureGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFeatureGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFlowDefinitions

        internal virtual ListFlowDefinitionsResponse ListFlowDefinitions(ListFlowDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFlowDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListFlowDefinitionsResponse>(request, options);
        }



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
        public virtual Task<ListFlowDefinitionsResponse> ListFlowDefinitionsAsync(ListFlowDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFlowDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFlowDefinitionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHubContents

        internal virtual ListHubContentsResponse ListHubContents(ListHubContentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHubContentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHubContentsResponseUnmarshaller.Instance;

            return Invoke<ListHubContentsResponse>(request, options);
        }



        /// <summary>
        /// List the contents of a hub.
        /// 
        ///  <note> 
        /// <para>
        /// Hub APIs are only callable through SageMaker Studio.
        /// </para>
        ///  </note>
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
        public virtual Task<ListHubContentsResponse> ListHubContentsAsync(ListHubContentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHubContentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHubContentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListHubContentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHubContentVersions

        internal virtual ListHubContentVersionsResponse ListHubContentVersions(ListHubContentVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHubContentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHubContentVersionsResponseUnmarshaller.Instance;

            return Invoke<ListHubContentVersionsResponse>(request, options);
        }



        /// <summary>
        /// List hub content versions.
        /// 
        ///  <note> 
        /// <para>
        /// Hub APIs are only callable through SageMaker Studio.
        /// </para>
        ///  </note>
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
        public virtual Task<ListHubContentVersionsResponse> ListHubContentVersionsAsync(ListHubContentVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHubContentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHubContentVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListHubContentVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHubs

        internal virtual ListHubsResponse ListHubs(ListHubsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHubsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHubsResponseUnmarshaller.Instance;

            return Invoke<ListHubsResponse>(request, options);
        }



        /// <summary>
        /// List all existing hubs.
        /// 
        ///  <note> 
        /// <para>
        /// Hub APIs are only callable through SageMaker Studio.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHubs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHubs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHubs">REST API Reference for ListHubs Operation</seealso>
        public virtual Task<ListHubsResponse> ListHubsAsync(ListHubsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHubsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHubsResponseUnmarshaller.Instance;

            return InvokeAsync<ListHubsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHumanTaskUis

        internal virtual ListHumanTaskUisResponse ListHumanTaskUis(ListHumanTaskUisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHumanTaskUisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHumanTaskUisResponseUnmarshaller.Instance;

            return Invoke<ListHumanTaskUisResponse>(request, options);
        }



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
        public virtual Task<ListHumanTaskUisResponse> ListHumanTaskUisAsync(ListHumanTaskUisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHumanTaskUisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHumanTaskUisResponseUnmarshaller.Instance;

            return InvokeAsync<ListHumanTaskUisResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHyperParameterTuningJobs

        internal virtual ListHyperParameterTuningJobsResponse ListHyperParameterTuningJobs(ListHyperParameterTuningJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHyperParameterTuningJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHyperParameterTuningJobsResponseUnmarshaller.Instance;

            return Invoke<ListHyperParameterTuningJobsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of <a>HyperParameterTuningJobSummary</a> objects that describe the hyperparameter
        /// tuning jobs launched in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHyperParameterTuningJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHyperParameterTuningJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHyperParameterTuningJobs">REST API Reference for ListHyperParameterTuningJobs Operation</seealso>
        public virtual Task<ListHyperParameterTuningJobsResponse> ListHyperParameterTuningJobsAsync(ListHyperParameterTuningJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHyperParameterTuningJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHyperParameterTuningJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListHyperParameterTuningJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListImages

        internal virtual ListImagesResponse ListImages(ListImagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagesResponseUnmarshaller.Instance;

            return Invoke<ListImagesResponse>(request, options);
        }



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
        public virtual Task<ListImagesResponse> ListImagesAsync(ListImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListImagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListImageVersions

        internal virtual ListImageVersionsResponse ListImageVersions(ListImageVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImageVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImageVersionsResponseUnmarshaller.Instance;

            return Invoke<ListImageVersionsResponse>(request, options);
        }



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
        public virtual Task<ListImageVersionsResponse> ListImageVersionsAsync(ListImageVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImageVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImageVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListImageVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInferenceExperiments

        internal virtual ListInferenceExperimentsResponse ListInferenceExperiments(ListInferenceExperimentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInferenceExperimentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInferenceExperimentsResponseUnmarshaller.Instance;

            return Invoke<ListInferenceExperimentsResponse>(request, options);
        }



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
        public virtual Task<ListInferenceExperimentsResponse> ListInferenceExperimentsAsync(ListInferenceExperimentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInferenceExperimentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInferenceExperimentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInferenceExperimentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInferenceRecommendationsJobs

        internal virtual ListInferenceRecommendationsJobsResponse ListInferenceRecommendationsJobs(ListInferenceRecommendationsJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInferenceRecommendationsJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInferenceRecommendationsJobsResponseUnmarshaller.Instance;

            return Invoke<ListInferenceRecommendationsJobsResponse>(request, options);
        }



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
        public virtual Task<ListInferenceRecommendationsJobsResponse> ListInferenceRecommendationsJobsAsync(ListInferenceRecommendationsJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInferenceRecommendationsJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInferenceRecommendationsJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInferenceRecommendationsJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInferenceRecommendationsJobSteps

        internal virtual ListInferenceRecommendationsJobStepsResponse ListInferenceRecommendationsJobSteps(ListInferenceRecommendationsJobStepsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInferenceRecommendationsJobStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInferenceRecommendationsJobStepsResponseUnmarshaller.Instance;

            return Invoke<ListInferenceRecommendationsJobStepsResponse>(request, options);
        }



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
        public virtual Task<ListInferenceRecommendationsJobStepsResponse> ListInferenceRecommendationsJobStepsAsync(ListInferenceRecommendationsJobStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInferenceRecommendationsJobStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInferenceRecommendationsJobStepsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInferenceRecommendationsJobStepsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLabelingJobs

        internal virtual ListLabelingJobsResponse ListLabelingJobs(ListLabelingJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLabelingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLabelingJobsResponseUnmarshaller.Instance;

            return Invoke<ListLabelingJobsResponse>(request, options);
        }



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
        public virtual Task<ListLabelingJobsResponse> ListLabelingJobsAsync(ListLabelingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLabelingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLabelingJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLabelingJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLabelingJobsForWorkteam

        internal virtual ListLabelingJobsForWorkteamResponse ListLabelingJobsForWorkteam(ListLabelingJobsForWorkteamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLabelingJobsForWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLabelingJobsForWorkteamResponseUnmarshaller.Instance;

            return Invoke<ListLabelingJobsForWorkteamResponse>(request, options);
        }



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
        public virtual Task<ListLabelingJobsForWorkteamResponse> ListLabelingJobsForWorkteamAsync(ListLabelingJobsForWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLabelingJobsForWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLabelingJobsForWorkteamResponseUnmarshaller.Instance;

            return InvokeAsync<ListLabelingJobsForWorkteamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLineageGroups

        internal virtual ListLineageGroupsResponse ListLineageGroups(ListLineageGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLineageGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLineageGroupsResponseUnmarshaller.Instance;

            return Invoke<ListLineageGroupsResponse>(request, options);
        }



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
        public virtual Task<ListLineageGroupsResponse> ListLineageGroupsAsync(ListLineageGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLineageGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLineageGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLineageGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListModelBiasJobDefinitions

        internal virtual ListModelBiasJobDefinitionsResponse ListModelBiasJobDefinitions(ListModelBiasJobDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelBiasJobDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelBiasJobDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListModelBiasJobDefinitionsResponse>(request, options);
        }



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
        public virtual Task<ListModelBiasJobDefinitionsResponse> ListModelBiasJobDefinitionsAsync(ListModelBiasJobDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelBiasJobDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelBiasJobDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListModelBiasJobDefinitionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListModelCardExportJobs

        internal virtual ListModelCardExportJobsResponse ListModelCardExportJobs(ListModelCardExportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelCardExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelCardExportJobsResponseUnmarshaller.Instance;

            return Invoke<ListModelCardExportJobsResponse>(request, options);
        }



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
        public virtual Task<ListModelCardExportJobsResponse> ListModelCardExportJobsAsync(ListModelCardExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelCardExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelCardExportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListModelCardExportJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListModelCards

        internal virtual ListModelCardsResponse ListModelCards(ListModelCardsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelCardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelCardsResponseUnmarshaller.Instance;

            return Invoke<ListModelCardsResponse>(request, options);
        }



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
        public virtual Task<ListModelCardsResponse> ListModelCardsAsync(ListModelCardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelCardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelCardsResponseUnmarshaller.Instance;

            return InvokeAsync<ListModelCardsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListModelCardVersions

        internal virtual ListModelCardVersionsResponse ListModelCardVersions(ListModelCardVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelCardVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelCardVersionsResponseUnmarshaller.Instance;

            return Invoke<ListModelCardVersionsResponse>(request, options);
        }



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
        public virtual Task<ListModelCardVersionsResponse> ListModelCardVersionsAsync(ListModelCardVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelCardVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelCardVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListModelCardVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListModelExplainabilityJobDefinitions

        internal virtual ListModelExplainabilityJobDefinitionsResponse ListModelExplainabilityJobDefinitions(ListModelExplainabilityJobDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelExplainabilityJobDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelExplainabilityJobDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListModelExplainabilityJobDefinitionsResponse>(request, options);
        }



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
        public virtual Task<ListModelExplainabilityJobDefinitionsResponse> ListModelExplainabilityJobDefinitionsAsync(ListModelExplainabilityJobDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelExplainabilityJobDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelExplainabilityJobDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListModelExplainabilityJobDefinitionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListModelMetadata

        internal virtual ListModelMetadataResponse ListModelMetadata(ListModelMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelMetadataResponseUnmarshaller.Instance;

            return Invoke<ListModelMetadataResponse>(request, options);
        }



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
        public virtual Task<ListModelMetadataResponse> ListModelMetadataAsync(ListModelMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<ListModelMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListModelPackageGroups

        internal virtual ListModelPackageGroupsResponse ListModelPackageGroups(ListModelPackageGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelPackageGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelPackageGroupsResponseUnmarshaller.Instance;

            return Invoke<ListModelPackageGroupsResponse>(request, options);
        }



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
        public virtual Task<ListModelPackageGroupsResponse> ListModelPackageGroupsAsync(ListModelPackageGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelPackageGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelPackageGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListModelPackageGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListModelPackages

        internal virtual ListModelPackagesResponse ListModelPackages(ListModelPackagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelPackagesResponseUnmarshaller.Instance;

            return Invoke<ListModelPackagesResponse>(request, options);
        }



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
        public virtual Task<ListModelPackagesResponse> ListModelPackagesAsync(ListModelPackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelPackagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListModelPackagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListModelQualityJobDefinitions

        internal virtual ListModelQualityJobDefinitionsResponse ListModelQualityJobDefinitions(ListModelQualityJobDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelQualityJobDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelQualityJobDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListModelQualityJobDefinitionsResponse>(request, options);
        }



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
        public virtual Task<ListModelQualityJobDefinitionsResponse> ListModelQualityJobDefinitionsAsync(ListModelQualityJobDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelQualityJobDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelQualityJobDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListModelQualityJobDefinitionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListModels

        internal virtual ListModelsResponse ListModels(ListModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelsResponseUnmarshaller.Instance;

            return Invoke<ListModelsResponse>(request, options);
        }



        /// <summary>
        /// Lists models created with the <code>CreateModel</code> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModels service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModels">REST API Reference for ListModels Operation</seealso>
        public virtual Task<ListModelsResponse> ListModelsAsync(ListModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListModelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMonitoringAlertHistory

        internal virtual ListMonitoringAlertHistoryResponse ListMonitoringAlertHistory(ListMonitoringAlertHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMonitoringAlertHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitoringAlertHistoryResponseUnmarshaller.Instance;

            return Invoke<ListMonitoringAlertHistoryResponse>(request, options);
        }



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
        public virtual Task<ListMonitoringAlertHistoryResponse> ListMonitoringAlertHistoryAsync(ListMonitoringAlertHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMonitoringAlertHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitoringAlertHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<ListMonitoringAlertHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMonitoringAlerts

        internal virtual ListMonitoringAlertsResponse ListMonitoringAlerts(ListMonitoringAlertsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMonitoringAlertsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitoringAlertsResponseUnmarshaller.Instance;

            return Invoke<ListMonitoringAlertsResponse>(request, options);
        }



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
        public virtual Task<ListMonitoringAlertsResponse> ListMonitoringAlertsAsync(ListMonitoringAlertsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMonitoringAlertsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitoringAlertsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMonitoringAlertsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMonitoringExecutions

        internal virtual ListMonitoringExecutionsResponse ListMonitoringExecutions(ListMonitoringExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMonitoringExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitoringExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListMonitoringExecutionsResponse>(request, options);
        }



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
        public virtual Task<ListMonitoringExecutionsResponse> ListMonitoringExecutionsAsync(ListMonitoringExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMonitoringExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitoringExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMonitoringExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMonitoringSchedules

        internal virtual ListMonitoringSchedulesResponse ListMonitoringSchedules(ListMonitoringSchedulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMonitoringSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitoringSchedulesResponseUnmarshaller.Instance;

            return Invoke<ListMonitoringSchedulesResponse>(request, options);
        }



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
        public virtual Task<ListMonitoringSchedulesResponse> ListMonitoringSchedulesAsync(ListMonitoringSchedulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMonitoringSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitoringSchedulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListMonitoringSchedulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNotebookInstanceLifecycleConfigs

        internal virtual ListNotebookInstanceLifecycleConfigsResponse ListNotebookInstanceLifecycleConfigs(ListNotebookInstanceLifecycleConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotebookInstanceLifecycleConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotebookInstanceLifecycleConfigsResponseUnmarshaller.Instance;

            return Invoke<ListNotebookInstanceLifecycleConfigsResponse>(request, options);
        }



        /// <summary>
        /// Lists notebook instance lifestyle configurations created with the <a>CreateNotebookInstanceLifecycleConfig</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstanceLifecycleConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotebookInstanceLifecycleConfigs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstanceLifecycleConfigs">REST API Reference for ListNotebookInstanceLifecycleConfigs Operation</seealso>
        public virtual Task<ListNotebookInstanceLifecycleConfigsResponse> ListNotebookInstanceLifecycleConfigsAsync(ListNotebookInstanceLifecycleConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotebookInstanceLifecycleConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotebookInstanceLifecycleConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<ListNotebookInstanceLifecycleConfigsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNotebookInstances

        internal virtual ListNotebookInstancesResponse ListNotebookInstances(ListNotebookInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotebookInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotebookInstancesResponseUnmarshaller.Instance;

            return Invoke<ListNotebookInstancesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the SageMaker notebook instances in the requester's account in an
        /// Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotebookInstances service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstances">REST API Reference for ListNotebookInstances Operation</seealso>
        public virtual Task<ListNotebookInstancesResponse> ListNotebookInstancesAsync(ListNotebookInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotebookInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotebookInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListNotebookInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPipelineExecutions

        internal virtual ListPipelineExecutionsResponse ListPipelineExecutions(ListPipelineExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPipelineExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelineExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListPipelineExecutionsResponse>(request, options);
        }



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
        public virtual Task<ListPipelineExecutionsResponse> ListPipelineExecutionsAsync(ListPipelineExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPipelineExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelineExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPipelineExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPipelineExecutionSteps

        internal virtual ListPipelineExecutionStepsResponse ListPipelineExecutionSteps(ListPipelineExecutionStepsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPipelineExecutionStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelineExecutionStepsResponseUnmarshaller.Instance;

            return Invoke<ListPipelineExecutionStepsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of <code>PipeLineExecutionStep</code> objects.
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
        public virtual Task<ListPipelineExecutionStepsResponse> ListPipelineExecutionStepsAsync(ListPipelineExecutionStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPipelineExecutionStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelineExecutionStepsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPipelineExecutionStepsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPipelineParametersForExecution

        internal virtual ListPipelineParametersForExecutionResponse ListPipelineParametersForExecution(ListPipelineParametersForExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPipelineParametersForExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelineParametersForExecutionResponseUnmarshaller.Instance;

            return Invoke<ListPipelineParametersForExecutionResponse>(request, options);
        }



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
        public virtual Task<ListPipelineParametersForExecutionResponse> ListPipelineParametersForExecutionAsync(ListPipelineParametersForExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPipelineParametersForExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelineParametersForExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<ListPipelineParametersForExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPipelines

        internal virtual ListPipelinesResponse ListPipelines(ListPipelinesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return Invoke<ListPipelinesResponse>(request, options);
        }



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
        public virtual Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPipelinesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProcessingJobs

        internal virtual ListProcessingJobsResponse ListProcessingJobs(ListProcessingJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProcessingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProcessingJobsResponseUnmarshaller.Instance;

            return Invoke<ListProcessingJobsResponse>(request, options);
        }



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
        public virtual Task<ListProcessingJobsResponse> ListProcessingJobsAsync(ListProcessingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProcessingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProcessingJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProcessingJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProjects

        internal virtual ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return Invoke<ListProjectsResponse>(request, options);
        }



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
        public virtual Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProjectsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSpaces

        internal virtual ListSpacesResponse ListSpaces(ListSpacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSpacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSpacesResponseUnmarshaller.Instance;

            return Invoke<ListSpacesResponse>(request, options);
        }



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
        public virtual Task<ListSpacesResponse> ListSpacesAsync(ListSpacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSpacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSpacesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSpacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStageDevices

        internal virtual ListStageDevicesResponse ListStageDevices(ListStageDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStageDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStageDevicesResponseUnmarshaller.Instance;

            return Invoke<ListStageDevicesResponse>(request, options);
        }



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
        public virtual Task<ListStageDevicesResponse> ListStageDevicesAsync(ListStageDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStageDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStageDevicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListStageDevicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStudioLifecycleConfigs

        internal virtual ListStudioLifecycleConfigsResponse ListStudioLifecycleConfigs(ListStudioLifecycleConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStudioLifecycleConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStudioLifecycleConfigsResponseUnmarshaller.Instance;

            return Invoke<ListStudioLifecycleConfigsResponse>(request, options);
        }



        /// <summary>
        /// Lists the Studio Lifecycle Configurations in your Amazon Web Services Account.
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
        public virtual Task<ListStudioLifecycleConfigsResponse> ListStudioLifecycleConfigsAsync(ListStudioLifecycleConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStudioLifecycleConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStudioLifecycleConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStudioLifecycleConfigsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSubscribedWorkteams

        internal virtual ListSubscribedWorkteamsResponse ListSubscribedWorkteams(ListSubscribedWorkteamsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubscribedWorkteamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscribedWorkteamsResponseUnmarshaller.Instance;

            return Invoke<ListSubscribedWorkteamsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of the work teams that you are subscribed to in the Amazon Web Services
        /// Marketplace. The list may be empty if no work team satisfies the filter specified
        /// in the <code>NameContains</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribedWorkteams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscribedWorkteams service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListSubscribedWorkteams">REST API Reference for ListSubscribedWorkteams Operation</seealso>
        public virtual Task<ListSubscribedWorkteamsResponse> ListSubscribedWorkteamsAsync(ListSubscribedWorkteamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubscribedWorkteamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscribedWorkteamsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSubscribedWorkteamsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTags

        internal virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }



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
        public virtual Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTrainingJobs

        internal virtual ListTrainingJobsResponse ListTrainingJobs(ListTrainingJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrainingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrainingJobsResponseUnmarshaller.Instance;

            return Invoke<ListTrainingJobsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrainingJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobs">REST API Reference for ListTrainingJobs Operation</seealso>
        public virtual Task<ListTrainingJobsResponse> ListTrainingJobsAsync(ListTrainingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrainingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrainingJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrainingJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTrainingJobsForHyperParameterTuningJob

        internal virtual ListTrainingJobsForHyperParameterTuningJobResponse ListTrainingJobsForHyperParameterTuningJob(ListTrainingJobsForHyperParameterTuningJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrainingJobsForHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrainingJobsForHyperParameterTuningJobResponseUnmarshaller.Instance;

            return Invoke<ListTrainingJobsForHyperParameterTuningJobResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of <a>TrainingJobSummary</a> objects that describe the training jobs that
        /// a hyperparameter tuning job launched.
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
        public virtual Task<ListTrainingJobsForHyperParameterTuningJobResponse> ListTrainingJobsForHyperParameterTuningJobAsync(ListTrainingJobsForHyperParameterTuningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrainingJobsForHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrainingJobsForHyperParameterTuningJobResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrainingJobsForHyperParameterTuningJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTransformJobs

        internal virtual ListTransformJobsResponse ListTransformJobs(ListTransformJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTransformJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTransformJobsResponseUnmarshaller.Instance;

            return Invoke<ListTransformJobsResponse>(request, options);
        }



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
        public virtual Task<ListTransformJobsResponse> ListTransformJobsAsync(ListTransformJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTransformJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTransformJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTransformJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTrialComponents

        internal virtual ListTrialComponentsResponse ListTrialComponents(ListTrialComponentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrialComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrialComponentsResponseUnmarshaller.Instance;

            return Invoke<ListTrialComponentsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrialComponents service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrialComponents">REST API Reference for ListTrialComponents Operation</seealso>
        public virtual Task<ListTrialComponentsResponse> ListTrialComponentsAsync(ListTrialComponentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrialComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrialComponentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrialComponentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTrials

        internal virtual ListTrialsResponse ListTrials(ListTrialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrialsResponseUnmarshaller.Instance;

            return Invoke<ListTrialsResponse>(request, options);
        }



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
        public virtual Task<ListTrialsResponse> ListTrialsAsync(ListTrialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrialsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrialsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUserProfiles

        internal virtual ListUserProfilesResponse ListUserProfiles(ListUserProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserProfilesResponseUnmarshaller.Instance;

            return Invoke<ListUserProfilesResponse>(request, options);
        }



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
        public virtual Task<ListUserProfilesResponse> ListUserProfilesAsync(ListUserProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<ListUserProfilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWorkforces

        internal virtual ListWorkforcesResponse ListWorkforces(ListWorkforcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkforcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkforcesResponseUnmarshaller.Instance;

            return Invoke<ListWorkforcesResponse>(request, options);
        }



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
        public virtual Task<ListWorkforcesResponse> ListWorkforcesAsync(ListWorkforcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkforcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkforcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkforcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWorkteams

        internal virtual ListWorkteamsResponse ListWorkteams(ListWorkteamsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkteamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkteamsResponseUnmarshaller.Instance;

            return Invoke<ListWorkteamsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of private work teams that you have defined in a region. The list may
        /// be empty if no work team satisfies the filter specified in the <code>NameContains</code>
        /// parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkteams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkteams service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListWorkteams">REST API Reference for ListWorkteams Operation</seealso>
        public virtual Task<ListWorkteamsResponse> ListWorkteamsAsync(ListWorkteamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkteamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkteamsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkteamsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutModelPackageGroupPolicy

        internal virtual PutModelPackageGroupPolicyResponse PutModelPackageGroupPolicy(PutModelPackageGroupPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutModelPackageGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutModelPackageGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<PutModelPackageGroupPolicyResponse>(request, options);
        }



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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/PutModelPackageGroupPolicy">REST API Reference for PutModelPackageGroupPolicy Operation</seealso>
        public virtual Task<PutModelPackageGroupPolicyResponse> PutModelPackageGroupPolicyAsync(PutModelPackageGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutModelPackageGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutModelPackageGroupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutModelPackageGroupPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  QueryLineage

        internal virtual QueryLineageResponse QueryLineage(QueryLineageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QueryLineageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryLineageResponseUnmarshaller.Instance;

            return Invoke<QueryLineageResponse>(request, options);
        }



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
        public virtual Task<QueryLineageResponse> QueryLineageAsync(QueryLineageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QueryLineageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryLineageResponseUnmarshaller.Instance;

            return InvokeAsync<QueryLineageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterDevices

        internal virtual RegisterDevicesResponse RegisterDevices(RegisterDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDevicesResponseUnmarshaller.Instance;

            return Invoke<RegisterDevicesResponse>(request, options);
        }



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
        public virtual Task<RegisterDevicesResponse> RegisterDevicesAsync(RegisterDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDevicesResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterDevicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RenderUiTemplate

        internal virtual RenderUiTemplateResponse RenderUiTemplate(RenderUiTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RenderUiTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenderUiTemplateResponseUnmarshaller.Instance;

            return Invoke<RenderUiTemplateResponse>(request, options);
        }



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
        public virtual Task<RenderUiTemplateResponse> RenderUiTemplateAsync(RenderUiTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RenderUiTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenderUiTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<RenderUiTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RetryPipelineExecution

        internal virtual RetryPipelineExecutionResponse RetryPipelineExecution(RetryPipelineExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetryPipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetryPipelineExecutionResponseUnmarshaller.Instance;

            return Invoke<RetryPipelineExecutionResponse>(request, options);
        }



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
        public virtual Task<RetryPipelineExecutionResponse> RetryPipelineExecutionAsync(RetryPipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetryPipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetryPipelineExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<RetryPipelineExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Search

        internal virtual SearchResponse Search(SearchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchResponseUnmarshaller.Instance;

            return Invoke<SearchResponse>(request, options);
        }



        /// <summary>
        /// Finds SageMaker resources that match a search query. Matching resources are returned
        /// as a list of <code>SearchRecord</code> objects in the response. You can sort the search
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
        public virtual Task<SearchResponse> SearchAsync(SearchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchResponseUnmarshaller.Instance;

            return InvokeAsync<SearchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendPipelineExecutionStepFailure

        internal virtual SendPipelineExecutionStepFailureResponse SendPipelineExecutionStepFailure(SendPipelineExecutionStepFailureRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendPipelineExecutionStepFailureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendPipelineExecutionStepFailureResponseUnmarshaller.Instance;

            return Invoke<SendPipelineExecutionStepFailureResponse>(request, options);
        }



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
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/SendPipelineExecutionStepFailure">REST API Reference for SendPipelineExecutionStepFailure Operation</seealso>
        public virtual Task<SendPipelineExecutionStepFailureResponse> SendPipelineExecutionStepFailureAsync(SendPipelineExecutionStepFailureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendPipelineExecutionStepFailureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendPipelineExecutionStepFailureResponseUnmarshaller.Instance;

            return InvokeAsync<SendPipelineExecutionStepFailureResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendPipelineExecutionStepSuccess

        internal virtual SendPipelineExecutionStepSuccessResponse SendPipelineExecutionStepSuccess(SendPipelineExecutionStepSuccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendPipelineExecutionStepSuccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendPipelineExecutionStepSuccessResponseUnmarshaller.Instance;

            return Invoke<SendPipelineExecutionStepSuccessResponse>(request, options);
        }



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
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/SendPipelineExecutionStepSuccess">REST API Reference for SendPipelineExecutionStepSuccess Operation</seealso>
        public virtual Task<SendPipelineExecutionStepSuccessResponse> SendPipelineExecutionStepSuccessAsync(SendPipelineExecutionStepSuccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendPipelineExecutionStepSuccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendPipelineExecutionStepSuccessResponseUnmarshaller.Instance;

            return InvokeAsync<SendPipelineExecutionStepSuccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartEdgeDeploymentStage

        internal virtual StartEdgeDeploymentStageResponse StartEdgeDeploymentStage(StartEdgeDeploymentStageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEdgeDeploymentStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEdgeDeploymentStageResponseUnmarshaller.Instance;

            return Invoke<StartEdgeDeploymentStageResponse>(request, options);
        }



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
        public virtual Task<StartEdgeDeploymentStageResponse> StartEdgeDeploymentStageAsync(StartEdgeDeploymentStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEdgeDeploymentStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEdgeDeploymentStageResponseUnmarshaller.Instance;

            return InvokeAsync<StartEdgeDeploymentStageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartInferenceExperiment

        internal virtual StartInferenceExperimentResponse StartInferenceExperiment(StartInferenceExperimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartInferenceExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInferenceExperimentResponseUnmarshaller.Instance;

            return Invoke<StartInferenceExperimentResponse>(request, options);
        }



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
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartInferenceExperiment">REST API Reference for StartInferenceExperiment Operation</seealso>
        public virtual Task<StartInferenceExperimentResponse> StartInferenceExperimentAsync(StartInferenceExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartInferenceExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInferenceExperimentResponseUnmarshaller.Instance;

            return InvokeAsync<StartInferenceExperimentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartMonitoringSchedule

        internal virtual StartMonitoringScheduleResponse StartMonitoringSchedule(StartMonitoringScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMonitoringScheduleResponseUnmarshaller.Instance;

            return Invoke<StartMonitoringScheduleResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartMonitoringSchedule">REST API Reference for StartMonitoringSchedule Operation</seealso>
        public virtual Task<StartMonitoringScheduleResponse> StartMonitoringScheduleAsync(StartMonitoringScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMonitoringScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<StartMonitoringScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartNotebookInstance

        internal virtual StartNotebookInstanceResponse StartNotebookInstance(StartNotebookInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<StartNotebookInstanceResponse>(request, options);
        }



        /// <summary>
        /// Launches an ML compute instance with the latest version of the libraries and attaches
        /// your ML storage volume. After configuring the notebook instance, SageMaker sets the
        /// notebook instance status to <code>InService</code>. A notebook instance's status must
        /// be <code>InService</code> before you can connect to your Jupyter notebook.
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
        public virtual Task<StartNotebookInstanceResponse> StartNotebookInstanceAsync(StartNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartNotebookInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<StartNotebookInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartPipelineExecution

        internal virtual StartPipelineExecutionResponse StartPipelineExecution(StartPipelineExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPipelineExecutionResponseUnmarshaller.Instance;

            return Invoke<StartPipelineExecutionResponse>(request, options);
        }



        /// <summary>
        /// Starts a pipeline execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPipelineExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartPipelineExecutionResponse> StartPipelineExecutionAsync(StartPipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPipelineExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StartPipelineExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopAutoMLJob

        internal virtual StopAutoMLJobResponse StopAutoMLJob(StopAutoMLJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopAutoMLJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAutoMLJobResponseUnmarshaller.Instance;

            return Invoke<StopAutoMLJobResponse>(request, options);
        }



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
        public virtual Task<StopAutoMLJobResponse> StopAutoMLJobAsync(StopAutoMLJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopAutoMLJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAutoMLJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopAutoMLJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopCompilationJob

        internal virtual StopCompilationJobResponse StopCompilationJob(StopCompilationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCompilationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCompilationJobResponseUnmarshaller.Instance;

            return Invoke<StopCompilationJobResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopCompilationJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopCompilationJob">REST API Reference for StopCompilationJob Operation</seealso>
        public virtual Task<StopCompilationJobResponse> StopCompilationJobAsync(StopCompilationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCompilationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCompilationJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopCompilationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopEdgeDeploymentStage

        internal virtual StopEdgeDeploymentStageResponse StopEdgeDeploymentStage(StopEdgeDeploymentStageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEdgeDeploymentStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEdgeDeploymentStageResponseUnmarshaller.Instance;

            return Invoke<StopEdgeDeploymentStageResponse>(request, options);
        }



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
        public virtual Task<StopEdgeDeploymentStageResponse> StopEdgeDeploymentStageAsync(StopEdgeDeploymentStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEdgeDeploymentStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEdgeDeploymentStageResponseUnmarshaller.Instance;

            return InvokeAsync<StopEdgeDeploymentStageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopEdgePackagingJob

        internal virtual StopEdgePackagingJobResponse StopEdgePackagingJob(StopEdgePackagingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEdgePackagingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEdgePackagingJobResponseUnmarshaller.Instance;

            return Invoke<StopEdgePackagingJobResponse>(request, options);
        }



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
        public virtual Task<StopEdgePackagingJobResponse> StopEdgePackagingJobAsync(StopEdgePackagingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEdgePackagingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEdgePackagingJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopEdgePackagingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopHyperParameterTuningJob

        internal virtual StopHyperParameterTuningJobResponse StopHyperParameterTuningJob(StopHyperParameterTuningJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopHyperParameterTuningJobResponseUnmarshaller.Instance;

            return Invoke<StopHyperParameterTuningJobResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopHyperParameterTuningJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopHyperParameterTuningJob">REST API Reference for StopHyperParameterTuningJob Operation</seealso>
        public virtual Task<StopHyperParameterTuningJobResponse> StopHyperParameterTuningJobAsync(StopHyperParameterTuningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopHyperParameterTuningJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopHyperParameterTuningJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopInferenceExperiment

        internal virtual StopInferenceExperimentResponse StopInferenceExperiment(StopInferenceExperimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopInferenceExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopInferenceExperimentResponseUnmarshaller.Instance;

            return Invoke<StopInferenceExperimentResponse>(request, options);
        }



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
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopInferenceExperiment">REST API Reference for StopInferenceExperiment Operation</seealso>
        public virtual Task<StopInferenceExperimentResponse> StopInferenceExperimentAsync(StopInferenceExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopInferenceExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopInferenceExperimentResponseUnmarshaller.Instance;

            return InvokeAsync<StopInferenceExperimentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopInferenceRecommendationsJob

        internal virtual StopInferenceRecommendationsJobResponse StopInferenceRecommendationsJob(StopInferenceRecommendationsJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopInferenceRecommendationsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopInferenceRecommendationsJobResponseUnmarshaller.Instance;

            return Invoke<StopInferenceRecommendationsJobResponse>(request, options);
        }



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
        public virtual Task<StopInferenceRecommendationsJobResponse> StopInferenceRecommendationsJobAsync(StopInferenceRecommendationsJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopInferenceRecommendationsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopInferenceRecommendationsJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopInferenceRecommendationsJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopLabelingJob

        internal virtual StopLabelingJobResponse StopLabelingJob(StopLabelingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopLabelingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopLabelingJobResponseUnmarshaller.Instance;

            return Invoke<StopLabelingJobResponse>(request, options);
        }



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
        public virtual Task<StopLabelingJobResponse> StopLabelingJobAsync(StopLabelingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopLabelingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopLabelingJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopLabelingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopMonitoringSchedule

        internal virtual StopMonitoringScheduleResponse StopMonitoringSchedule(StopMonitoringScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopMonitoringScheduleResponseUnmarshaller.Instance;

            return Invoke<StopMonitoringScheduleResponse>(request, options);
        }



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
        public virtual Task<StopMonitoringScheduleResponse> StopMonitoringScheduleAsync(StopMonitoringScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopMonitoringScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<StopMonitoringScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopNotebookInstance

        internal virtual StopNotebookInstanceResponse StopNotebookInstance(StopNotebookInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<StopNotebookInstanceResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopNotebookInstance service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopNotebookInstance">REST API Reference for StopNotebookInstance Operation</seealso>
        public virtual Task<StopNotebookInstanceResponse> StopNotebookInstanceAsync(StopNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopNotebookInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<StopNotebookInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopPipelineExecution

        internal virtual StopPipelineExecutionResponse StopPipelineExecution(StopPipelineExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopPipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopPipelineExecutionResponseUnmarshaller.Instance;

            return Invoke<StopPipelineExecutionResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopPipelineExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopPipelineExecution">REST API Reference for StopPipelineExecution Operation</seealso>
        public virtual Task<StopPipelineExecutionResponse> StopPipelineExecutionAsync(StopPipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopPipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopPipelineExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StopPipelineExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopProcessingJob

        internal virtual StopProcessingJobResponse StopProcessingJob(StopProcessingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopProcessingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopProcessingJobResponseUnmarshaller.Instance;

            return Invoke<StopProcessingJobResponse>(request, options);
        }



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
        public virtual Task<StopProcessingJobResponse> StopProcessingJobAsync(StopProcessingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopProcessingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopProcessingJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopProcessingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopTrainingJob

        internal virtual StopTrainingJobResponse StopTrainingJob(StopTrainingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTrainingJobResponseUnmarshaller.Instance;

            return Invoke<StopTrainingJobResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopTrainingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTrainingJob">REST API Reference for StopTrainingJob Operation</seealso>
        public virtual Task<StopTrainingJobResponse> StopTrainingJobAsync(StopTrainingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTrainingJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopTrainingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopTransformJob

        internal virtual StopTransformJobResponse StopTransformJob(StopTransformJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTransformJobResponseUnmarshaller.Instance;

            return Invoke<StopTransformJobResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopTransformJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTransformJob">REST API Reference for StopTransformJob Operation</seealso>
        public virtual Task<StopTransformJobResponse> StopTransformJobAsync(StopTransformJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTransformJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopTransformJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAction

        internal virtual UpdateActionResponse UpdateAction(UpdateActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateActionResponseUnmarshaller.Instance;

            return Invoke<UpdateActionResponse>(request, options);
        }



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
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateAction">REST API Reference for UpdateAction Operation</seealso>
        public virtual Task<UpdateActionResponse> UpdateActionAsync(UpdateActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateActionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAppImageConfig

        internal virtual UpdateAppImageConfigResponse UpdateAppImageConfig(UpdateAppImageConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppImageConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppImageConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateAppImageConfigResponse>(request, options);
        }



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
        public virtual Task<UpdateAppImageConfigResponse> UpdateAppImageConfigAsync(UpdateAppImageConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppImageConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppImageConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAppImageConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateArtifact

        internal virtual UpdateArtifactResponse UpdateArtifact(UpdateArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateArtifactResponseUnmarshaller.Instance;

            return Invoke<UpdateArtifactResponse>(request, options);
        }



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
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateArtifact">REST API Reference for UpdateArtifact Operation</seealso>
        public virtual Task<UpdateArtifactResponse> UpdateArtifactAsync(UpdateArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateArtifactResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCodeRepository

        internal virtual UpdateCodeRepositoryResponse UpdateCodeRepository(UpdateCodeRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCodeRepositoryResponseUnmarshaller.Instance;

            return Invoke<UpdateCodeRepositoryResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified Git repository with the specified values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCodeRepository service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateCodeRepository">REST API Reference for UpdateCodeRepository Operation</seealso>
        public virtual Task<UpdateCodeRepositoryResponse> UpdateCodeRepositoryAsync(UpdateCodeRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCodeRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCodeRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateContext

        internal virtual UpdateContextResponse UpdateContext(UpdateContextRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContextResponseUnmarshaller.Instance;

            return Invoke<UpdateContextResponse>(request, options);
        }



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
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateContext">REST API Reference for UpdateContext Operation</seealso>
        public virtual Task<UpdateContextResponse> UpdateContextAsync(UpdateContextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContextResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateContextResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDeviceFleet

        internal virtual UpdateDeviceFleetResponse UpdateDeviceFleet(UpdateDeviceFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeviceFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceFleetResponseUnmarshaller.Instance;

            return Invoke<UpdateDeviceFleetResponse>(request, options);
        }



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
        public virtual Task<UpdateDeviceFleetResponse> UpdateDeviceFleetAsync(UpdateDeviceFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeviceFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceFleetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDeviceFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDevices

        internal virtual UpdateDevicesResponse UpdateDevices(UpdateDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDevicesResponseUnmarshaller.Instance;

            return Invoke<UpdateDevicesResponse>(request, options);
        }



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
        public virtual Task<UpdateDevicesResponse> UpdateDevicesAsync(UpdateDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDevicesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDevicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomain

        internal virtual UpdateDomainResponse UpdateDomain(UpdateDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainResponse>(request, options);
        }



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
        public virtual Task<UpdateDomainResponse> UpdateDomainAsync(UpdateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEndpoint

        internal virtual UpdateEndpointResponse UpdateEndpoint(UpdateEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointResponse>(request, options);
        }



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
        public virtual Task<UpdateEndpointResponse> UpdateEndpointAsync(UpdateEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEndpointWeightsAndCapacities

        internal virtual UpdateEndpointWeightsAndCapacitiesResponse UpdateEndpointWeightsAndCapacities(UpdateEndpointWeightsAndCapacitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointWeightsAndCapacitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointWeightsAndCapacitiesResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointWeightsAndCapacitiesResponse>(request, options);
        }



        /// <summary>
        /// Updates variant weight of one or more variants associated with an existing endpoint,
        /// or capacity of one variant associated with an existing endpoint. When it receives
        /// the request, SageMaker sets the endpoint status to <code>Updating</code>. After updating
        /// the endpoint, it sets the status to <code>InService</code>. To check the status of
        /// an endpoint, use the <a>DescribeEndpoint</a> API.
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
        public virtual Task<UpdateEndpointWeightsAndCapacitiesResponse> UpdateEndpointWeightsAndCapacitiesAsync(UpdateEndpointWeightsAndCapacitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointWeightsAndCapacitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointWeightsAndCapacitiesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEndpointWeightsAndCapacitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateExperiment

        internal virtual UpdateExperimentResponse UpdateExperiment(UpdateExperimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExperimentResponseUnmarshaller.Instance;

            return Invoke<UpdateExperimentResponse>(request, options);
        }



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
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateExperiment">REST API Reference for UpdateExperiment Operation</seealso>
        public virtual Task<UpdateExperimentResponse> UpdateExperimentAsync(UpdateExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExperimentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateExperimentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFeatureGroup

        internal virtual UpdateFeatureGroupResponse UpdateFeatureGroup(UpdateFeatureGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFeatureGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFeatureGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateFeatureGroupResponse>(request, options);
        }



        /// <summary>
        /// Updates the feature group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFeatureGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFeatureGroup service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateFeatureGroup">REST API Reference for UpdateFeatureGroup Operation</seealso>
        public virtual Task<UpdateFeatureGroupResponse> UpdateFeatureGroupAsync(UpdateFeatureGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFeatureGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFeatureGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFeatureGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFeatureMetadata

        internal virtual UpdateFeatureMetadataResponse UpdateFeatureMetadata(UpdateFeatureMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFeatureMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFeatureMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateFeatureMetadataResponse>(request, options);
        }



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
        public virtual Task<UpdateFeatureMetadataResponse> UpdateFeatureMetadataAsync(UpdateFeatureMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFeatureMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFeatureMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFeatureMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateHub

        internal virtual UpdateHubResponse UpdateHub(UpdateHubRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHubResponseUnmarshaller.Instance;

            return Invoke<UpdateHubResponse>(request, options);
        }



        /// <summary>
        /// Update a hub.
        /// 
        ///  <note> 
        /// <para>
        /// Hub APIs are only callable through SageMaker Studio.
        /// </para>
        ///  </note>
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
        public virtual Task<UpdateHubResponse> UpdateHubAsync(UpdateHubRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHubResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateHubResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateImage

        internal virtual UpdateImageResponse UpdateImage(UpdateImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateImageResponseUnmarshaller.Instance;

            return Invoke<UpdateImageResponse>(request, options);
        }



        /// <summary>
        /// Updates the properties of a SageMaker image. To change the image's tags, use the <a>AddTags</a>
        /// and <a>DeleteTags</a> APIs.
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
        public virtual Task<UpdateImageResponse> UpdateImageAsync(UpdateImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateImageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateImageVersion

        internal virtual UpdateImageVersionResponse UpdateImageVersion(UpdateImageVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateImageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateImageVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateImageVersionResponse>(request, options);
        }



        /// <summary>
        /// Updates the properties of a SageMaker image version.
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
        public virtual Task<UpdateImageVersionResponse> UpdateImageVersionAsync(UpdateImageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateImageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateImageVersionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateImageVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateInferenceExperiment

        internal virtual UpdateInferenceExperimentResponse UpdateInferenceExperiment(UpdateInferenceExperimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInferenceExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInferenceExperimentResponseUnmarshaller.Instance;

            return Invoke<UpdateInferenceExperimentResponse>(request, options);
        }



        /// <summary>
        /// Updates an inference experiment that you created. The status of the inference experiment
        /// has to be either <code>Created</code>, <code>Running</code>. For more information
        /// on the status of an inference experiment, see <a>DescribeInferenceExperimentResponse$Status</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInferenceExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateInferenceExperimentResponse> UpdateInferenceExperimentAsync(UpdateInferenceExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInferenceExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInferenceExperimentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateInferenceExperimentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateModelCard

        internal virtual UpdateModelCardResponse UpdateModelCard(UpdateModelCardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelCardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelCardResponseUnmarshaller.Instance;

            return Invoke<UpdateModelCardResponse>(request, options);
        }



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
        public virtual Task<UpdateModelCardResponse> UpdateModelCardAsync(UpdateModelCardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelCardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelCardResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateModelCardResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateModelPackage

        internal virtual UpdateModelPackageResponse UpdateModelPackage(UpdateModelPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelPackageResponseUnmarshaller.Instance;

            return Invoke<UpdateModelPackageResponse>(request, options);
        }



        /// <summary>
        /// Updates a versioned model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateModelPackage service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateModelPackage">REST API Reference for UpdateModelPackage Operation</seealso>
        public virtual Task<UpdateModelPackageResponse> UpdateModelPackageAsync(UpdateModelPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelPackageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateModelPackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMonitoringAlert

        internal virtual UpdateMonitoringAlertResponse UpdateMonitoringAlert(UpdateMonitoringAlertRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMonitoringAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMonitoringAlertResponseUnmarshaller.Instance;

            return Invoke<UpdateMonitoringAlertResponse>(request, options);
        }



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
        public virtual Task<UpdateMonitoringAlertResponse> UpdateMonitoringAlertAsync(UpdateMonitoringAlertRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMonitoringAlertRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMonitoringAlertResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMonitoringAlertResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMonitoringSchedule

        internal virtual UpdateMonitoringScheduleResponse UpdateMonitoringSchedule(UpdateMonitoringScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMonitoringScheduleResponseUnmarshaller.Instance;

            return Invoke<UpdateMonitoringScheduleResponse>(request, options);
        }



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
        public virtual Task<UpdateMonitoringScheduleResponse> UpdateMonitoringScheduleAsync(UpdateMonitoringScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMonitoringScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMonitoringScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMonitoringScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNotebookInstance

        internal virtual UpdateNotebookInstanceResponse UpdateNotebookInstance(UpdateNotebookInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateNotebookInstanceResponse>(request, options);
        }



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
        public virtual Task<UpdateNotebookInstanceResponse> UpdateNotebookInstanceAsync(UpdateNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotebookInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNotebookInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNotebookInstanceLifecycleConfig

        internal virtual UpdateNotebookInstanceLifecycleConfigResponse UpdateNotebookInstanceLifecycleConfig(UpdateNotebookInstanceLifecycleConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateNotebookInstanceLifecycleConfigResponse>(request, options);
        }



        /// <summary>
        /// Updates a notebook instance lifecycle configuration created with the <a>CreateNotebookInstanceLifecycleConfig</a>
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
        public virtual Task<UpdateNotebookInstanceLifecycleConfigResponse> UpdateNotebookInstanceLifecycleConfigAsync(UpdateNotebookInstanceLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNotebookInstanceLifecycleConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePipeline

        internal virtual UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return Invoke<UpdatePipelineResponse>(request, options);
        }



        /// <summary>
        /// Updates a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        public virtual Task<UpdatePipelineResponse> UpdatePipelineAsync(UpdatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePipelineExecution

        internal virtual UpdatePipelineExecutionResponse UpdatePipelineExecution(UpdatePipelineExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineExecutionResponseUnmarshaller.Instance;

            return Invoke<UpdatePipelineExecutionResponse>(request, options);
        }



        /// <summary>
        /// Updates a pipeline execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePipelineExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdatePipelineExecution">REST API Reference for UpdatePipelineExecution Operation</seealso>
        public virtual Task<UpdatePipelineExecutionResponse> UpdatePipelineExecutionAsync(UpdatePipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePipelineExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProject

        internal virtual UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSpace

        internal virtual UpdateSpaceResponse UpdateSpace(UpdateSpaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSpaceResponseUnmarshaller.Instance;

            return Invoke<UpdateSpaceResponse>(request, options);
        }



        /// <summary>
        /// Updates the settings of a space.
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
        public virtual Task<UpdateSpaceResponse> UpdateSpaceAsync(UpdateSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSpaceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSpaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTrainingJob

        internal virtual UpdateTrainingJobResponse UpdateTrainingJob(UpdateTrainingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrainingJobResponseUnmarshaller.Instance;

            return Invoke<UpdateTrainingJobResponse>(request, options);
        }



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
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrainingJob">REST API Reference for UpdateTrainingJob Operation</seealso>
        public virtual Task<UpdateTrainingJobResponse> UpdateTrainingJobAsync(UpdateTrainingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrainingJobResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTrainingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTrial

        internal virtual UpdateTrialResponse UpdateTrial(UpdateTrialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrialResponseUnmarshaller.Instance;

            return Invoke<UpdateTrialResponse>(request, options);
        }



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
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrial">REST API Reference for UpdateTrial Operation</seealso>
        public virtual Task<UpdateTrialResponse> UpdateTrialAsync(UpdateTrialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrialResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTrialResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTrialComponent

        internal virtual UpdateTrialComponentResponse UpdateTrialComponent(UpdateTrialComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrialComponentResponseUnmarshaller.Instance;

            return Invoke<UpdateTrialComponentResponse>(request, options);
        }



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
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrialComponent">REST API Reference for UpdateTrialComponent Operation</seealso>
        public virtual Task<UpdateTrialComponentResponse> UpdateTrialComponentAsync(UpdateTrialComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrialComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrialComponentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTrialComponentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateUserProfile

        internal virtual UpdateUserProfileResponse UpdateUserProfile(UpdateUserProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateUserProfileResponse>(request, options);
        }



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
        public virtual Task<UpdateUserProfileResponse> UpdateUserProfileAsync(UpdateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWorkforce

        internal virtual UpdateWorkforceResponse UpdateWorkforce(UpdateWorkforceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkforceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkforceResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkforceResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkforce service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <code>Experiment</code>
        /// or <code>Artifact</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateWorkforce">REST API Reference for UpdateWorkforce Operation</seealso>
        public virtual Task<UpdateWorkforceResponse> UpdateWorkforceAsync(UpdateWorkforceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkforceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkforceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWorkforceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWorkteam

        internal virtual UpdateWorkteamResponse UpdateWorkteam(UpdateWorkteamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkteamResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkteamResponse>(request, options);
        }



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
        public virtual Task<UpdateWorkteamResponse> UpdateWorkteamAsync(UpdateWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkteamResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWorkteamResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}