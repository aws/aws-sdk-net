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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CloudWatchEvidently.Model;
using Amazon.CloudWatchEvidently.Model.Internal.MarshallTransformations;
using Amazon.CloudWatchEvidently.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudWatchEvidently
{
    /// <summary>
    /// Implementation for accessing CloudWatchEvidently
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
    public partial class AmazonCloudWatchEvidentlyClient : AmazonServiceClient, IAmazonCloudWatchEvidently
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudWatchEvidentlyMetadata();
        private ICloudWatchEvidentlyPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICloudWatchEvidentlyPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CloudWatchEvidentlyPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudWatchEvidentlyClient with the credentials loaded from the application's
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
        public AmazonCloudWatchEvidentlyClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudWatchEvidentlyConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudWatchEvidentlyClient with the credentials loaded from the application's
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
        public AmazonCloudWatchEvidentlyClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudWatchEvidentlyConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudWatchEvidentlyClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudWatchEvidentlyClient Configuration Object</param>
        public AmazonCloudWatchEvidentlyClient(AmazonCloudWatchEvidentlyConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonCloudWatchEvidentlyClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudWatchEvidentlyClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudWatchEvidentlyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEvidentlyClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchEvidentlyClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudWatchEvidentlyConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEvidentlyClient with AWS Credentials and an
        /// AmazonCloudWatchEvidentlyClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudWatchEvidentlyClient Configuration Object</param>
        public AmazonCloudWatchEvidentlyClient(AWSCredentials credentials, AmazonCloudWatchEvidentlyConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEvidentlyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudWatchEvidentlyClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudWatchEvidentlyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEvidentlyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchEvidentlyClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudWatchEvidentlyConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEvidentlyClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudWatchEvidentlyClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudWatchEvidentlyClient Configuration Object</param>
        public AmazonCloudWatchEvidentlyClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudWatchEvidentlyConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEvidentlyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudWatchEvidentlyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudWatchEvidentlyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEvidentlyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchEvidentlyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudWatchEvidentlyConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEvidentlyClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudWatchEvidentlyClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudWatchEvidentlyClient Configuration Object</param>
        public AmazonCloudWatchEvidentlyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudWatchEvidentlyConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudWatchEvidentlyEndpointResolver());
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
        public virtual BatchEvaluateFeatureResponse BatchEvaluateFeature(BatchEvaluateFeatureRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchEvaluateFeatureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchEvaluateFeatureResponseUnmarshaller.Instance;

            return Invoke<BatchEvaluateFeatureResponse>(request, options);
        }


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
        public virtual Task<BatchEvaluateFeatureResponse> BatchEvaluateFeatureAsync(BatchEvaluateFeatureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchEvaluateFeatureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchEvaluateFeatureResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchEvaluateFeatureResponse>(request, options, cancellationToken);
        }

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
        public virtual CreateExperimentResponse CreateExperiment(CreateExperimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExperimentResponseUnmarshaller.Instance;

            return Invoke<CreateExperimentResponse>(request, options);
        }


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
        public virtual Task<CreateExperimentResponse> CreateExperimentAsync(CreateExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExperimentResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateExperimentResponse>(request, options, cancellationToken);
        }

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
        public virtual CreateFeatureResponse CreateFeature(CreateFeatureRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFeatureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFeatureResponseUnmarshaller.Instance;

            return Invoke<CreateFeatureResponse>(request, options);
        }


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
        public virtual Task<CreateFeatureResponse> CreateFeatureAsync(CreateFeatureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFeatureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFeatureResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateFeatureResponse>(request, options, cancellationToken);
        }

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
        public virtual CreateLaunchResponse CreateLaunch(CreateLaunchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLaunchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLaunchResponseUnmarshaller.Instance;

            return Invoke<CreateLaunchResponse>(request, options);
        }


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
        public virtual Task<CreateLaunchResponse> CreateLaunchAsync(CreateLaunchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLaunchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLaunchResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateLaunchResponse>(request, options, cancellationToken);
        }

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
        public virtual CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return Invoke<CreateProjectResponse>(request, options);
        }


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
        public virtual Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateProjectResponse>(request, options, cancellationToken);
        }

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
        public virtual CreateSegmentResponse CreateSegment(CreateSegmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSegmentResponseUnmarshaller.Instance;

            return Invoke<CreateSegmentResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateSegmentResponse> CreateSegmentAsync(CreateSegmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSegmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSegmentResponse>(request, options, cancellationToken);
        }

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
        public virtual DeleteExperimentResponse DeleteExperiment(DeleteExperimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExperimentResponseUnmarshaller.Instance;

            return Invoke<DeleteExperimentResponse>(request, options);
        }


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
        public virtual Task<DeleteExperimentResponse> DeleteExperimentAsync(DeleteExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExperimentResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteExperimentResponse>(request, options, cancellationToken);
        }

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
        public virtual DeleteFeatureResponse DeleteFeature(DeleteFeatureRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFeatureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFeatureResponseUnmarshaller.Instance;

            return Invoke<DeleteFeatureResponse>(request, options);
        }


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
        public virtual Task<DeleteFeatureResponse> DeleteFeatureAsync(DeleteFeatureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFeatureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFeatureResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteFeatureResponse>(request, options, cancellationToken);
        }

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
        public virtual DeleteLaunchResponse DeleteLaunch(DeleteLaunchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLaunchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLaunchResponseUnmarshaller.Instance;

            return Invoke<DeleteLaunchResponse>(request, options);
        }


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
        public virtual Task<DeleteLaunchResponse> DeleteLaunchAsync(DeleteLaunchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLaunchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLaunchResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteLaunchResponse>(request, options, cancellationToken);
        }

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
        public virtual DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectResponse>(request, options);
        }


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
        public virtual Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteProjectResponse>(request, options, cancellationToken);
        }

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
        public virtual DeleteSegmentResponse DeleteSegment(DeleteSegmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSegmentResponseUnmarshaller.Instance;

            return Invoke<DeleteSegmentResponse>(request, options);
        }


        /// <summary>
        /// Deletes a segment. You can't delete a segment that is being used in a launch or experiment,
        /// even if that launch or experiment is not currently running.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSegment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteSegmentResponse> DeleteSegmentAsync(DeleteSegmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSegmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSegmentResponse>(request, options, cancellationToken);
        }

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
        public virtual EvaluateFeatureResponse EvaluateFeature(EvaluateFeatureRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EvaluateFeatureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EvaluateFeatureResponseUnmarshaller.Instance;

            return Invoke<EvaluateFeatureResponse>(request, options);
        }


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
        public virtual Task<EvaluateFeatureResponse> EvaluateFeatureAsync(EvaluateFeatureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EvaluateFeatureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EvaluateFeatureResponseUnmarshaller.Instance;
            
            return InvokeAsync<EvaluateFeatureResponse>(request, options, cancellationToken);
        }

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
        public virtual GetExperimentResponse GetExperiment(GetExperimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExperimentResponseUnmarshaller.Instance;

            return Invoke<GetExperimentResponse>(request, options);
        }


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
        public virtual Task<GetExperimentResponse> GetExperimentAsync(GetExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExperimentResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetExperimentResponse>(request, options, cancellationToken);
        }

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
        public virtual GetExperimentResultsResponse GetExperimentResults(GetExperimentResultsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExperimentResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExperimentResultsResponseUnmarshaller.Instance;

            return Invoke<GetExperimentResultsResponse>(request, options);
        }


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
        public virtual Task<GetExperimentResultsResponse> GetExperimentResultsAsync(GetExperimentResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExperimentResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExperimentResultsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetExperimentResultsResponse>(request, options, cancellationToken);
        }

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
        public virtual GetFeatureResponse GetFeature(GetFeatureRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFeatureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFeatureResponseUnmarshaller.Instance;

            return Invoke<GetFeatureResponse>(request, options);
        }


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
        public virtual Task<GetFeatureResponse> GetFeatureAsync(GetFeatureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFeatureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFeatureResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFeatureResponse>(request, options, cancellationToken);
        }

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
        public virtual GetLaunchResponse GetLaunch(GetLaunchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLaunchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLaunchResponseUnmarshaller.Instance;

            return Invoke<GetLaunchResponse>(request, options);
        }


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
        public virtual Task<GetLaunchResponse> GetLaunchAsync(GetLaunchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLaunchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLaunchResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetLaunchResponse>(request, options, cancellationToken);
        }

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
        public virtual GetProjectResponse GetProject(GetProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProjectResponseUnmarshaller.Instance;

            return Invoke<GetProjectResponse>(request, options);
        }


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
        public virtual Task<GetProjectResponse> GetProjectAsync(GetProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetProjectResponse>(request, options, cancellationToken);
        }

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
        public virtual GetSegmentResponse GetSegment(GetSegmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentResponseUnmarshaller.Instance;

            return Invoke<GetSegmentResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the specified segment. Specify the segment you want to view
        /// by specifying its ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetSegmentResponse> GetSegmentAsync(GetSegmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSegmentResponse>(request, options, cancellationToken);
        }

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
        public virtual ListExperimentsResponse ListExperiments(ListExperimentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExperimentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentsResponseUnmarshaller.Instance;

            return Invoke<ListExperimentsResponse>(request, options);
        }


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
        public virtual Task<ListExperimentsResponse> ListExperimentsAsync(ListExperimentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExperimentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListExperimentsResponse>(request, options, cancellationToken);
        }

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
        public virtual ListFeaturesResponse ListFeatures(ListFeaturesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFeaturesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFeaturesResponseUnmarshaller.Instance;

            return Invoke<ListFeaturesResponse>(request, options);
        }


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
        public virtual Task<ListFeaturesResponse> ListFeaturesAsync(ListFeaturesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFeaturesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFeaturesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFeaturesResponse>(request, options, cancellationToken);
        }

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
        public virtual ListLaunchesResponse ListLaunches(ListLaunchesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLaunchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLaunchesResponseUnmarshaller.Instance;

            return Invoke<ListLaunchesResponse>(request, options);
        }


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
        public virtual Task<ListLaunchesResponse> ListLaunchesAsync(ListLaunchesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLaunchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLaunchesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListLaunchesResponse>(request, options, cancellationToken);
        }

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
        public virtual ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return Invoke<ListProjectsResponse>(request, options);
        }


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
        public virtual Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListProjectsResponse>(request, options, cancellationToken);
        }

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
        public virtual ListSegmentReferencesResponse ListSegmentReferences(ListSegmentReferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSegmentReferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSegmentReferencesResponseUnmarshaller.Instance;

            return Invoke<ListSegmentReferencesResponse>(request, options);
        }


        /// <summary>
        /// Use this operation to find which experiments or launches are using a specified segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSegmentReferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListSegmentReferencesResponse> ListSegmentReferencesAsync(ListSegmentReferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSegmentReferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSegmentReferencesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSegmentReferencesResponse>(request, options, cancellationToken);
        }

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
        public virtual ListSegmentsResponse ListSegments(ListSegmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSegmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSegmentsResponseUnmarshaller.Instance;

            return Invoke<ListSegmentsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of audience segments that you have created in your account in this
        /// Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSegments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListSegmentsResponse> ListSegmentsAsync(ListSegmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSegmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSegmentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSegmentsResponse>(request, options, cancellationToken);
        }

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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

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
        public virtual PutProjectEventsResponse PutProjectEvents(PutProjectEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutProjectEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProjectEventsResponseUnmarshaller.Instance;

            return Invoke<PutProjectEventsResponse>(request, options);
        }


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
        public virtual Task<PutProjectEventsResponse> PutProjectEventsAsync(PutProjectEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutProjectEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProjectEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutProjectEventsResponse>(request, options, cancellationToken);
        }

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
        public virtual StartExperimentResponse StartExperiment(StartExperimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExperimentResponseUnmarshaller.Instance;

            return Invoke<StartExperimentResponse>(request, options);
        }


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
        public virtual Task<StartExperimentResponse> StartExperimentAsync(StartExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExperimentResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartExperimentResponse>(request, options, cancellationToken);
        }

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
        public virtual StartLaunchResponse StartLaunch(StartLaunchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartLaunchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLaunchResponseUnmarshaller.Instance;

            return Invoke<StartLaunchResponse>(request, options);
        }


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
        public virtual Task<StartLaunchResponse> StartLaunchAsync(StartLaunchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartLaunchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLaunchResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartLaunchResponse>(request, options, cancellationToken);
        }

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
        public virtual StopExperimentResponse StopExperiment(StopExperimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopExperimentResponseUnmarshaller.Instance;

            return Invoke<StopExperimentResponse>(request, options);
        }


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
        public virtual Task<StopExperimentResponse> StopExperimentAsync(StopExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopExperimentResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopExperimentResponse>(request, options, cancellationToken);
        }

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
        public virtual StopLaunchResponse StopLaunch(StopLaunchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopLaunchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopLaunchResponseUnmarshaller.Instance;

            return Invoke<StopLaunchResponse>(request, options);
        }


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
        public virtual Task<StopLaunchResponse> StopLaunchAsync(StopLaunchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopLaunchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopLaunchResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopLaunchResponse>(request, options, cancellationToken);
        }

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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

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
        public virtual TestSegmentPatternResponse TestSegmentPattern(TestSegmentPatternRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestSegmentPatternRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestSegmentPatternResponseUnmarshaller.Instance;

            return Invoke<TestSegmentPatternResponse>(request, options);
        }


        /// <summary>
        /// Use this operation to test a rules pattern that you plan to use to create an audience
        /// segment. For more information about segments, see <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_CreateSegment.html">CreateSegment</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestSegmentPattern service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<TestSegmentPatternResponse> TestSegmentPatternAsync(TestSegmentPatternRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestSegmentPatternRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestSegmentPatternResponseUnmarshaller.Instance;
            
            return InvokeAsync<TestSegmentPatternResponse>(request, options, cancellationToken);
        }

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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

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
        public virtual UpdateExperimentResponse UpdateExperiment(UpdateExperimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExperimentResponseUnmarshaller.Instance;

            return Invoke<UpdateExperimentResponse>(request, options);
        }


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
        public virtual Task<UpdateExperimentResponse> UpdateExperimentAsync(UpdateExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExperimentResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateExperimentResponse>(request, options, cancellationToken);
        }

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
        public virtual UpdateFeatureResponse UpdateFeature(UpdateFeatureRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFeatureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFeatureResponseUnmarshaller.Instance;

            return Invoke<UpdateFeatureResponse>(request, options);
        }


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
        public virtual Task<UpdateFeatureResponse> UpdateFeatureAsync(UpdateFeatureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFeatureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFeatureResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateFeatureResponse>(request, options, cancellationToken);
        }

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
        public virtual UpdateLaunchResponse UpdateLaunch(UpdateLaunchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLaunchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLaunchResponseUnmarshaller.Instance;

            return Invoke<UpdateLaunchResponse>(request, options);
        }


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
        public virtual Task<UpdateLaunchResponse> UpdateLaunchAsync(UpdateLaunchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLaunchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLaunchResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateLaunchResponse>(request, options, cancellationToken);
        }

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
        public virtual UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectResponse>(request, options);
        }


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
        public virtual Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateProjectResponse>(request, options, cancellationToken);
        }

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
        public virtual UpdateProjectDataDeliveryResponse UpdateProjectDataDelivery(UpdateProjectDataDeliveryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProjectDataDeliveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectDataDeliveryResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectDataDeliveryResponse>(request, options);
        }


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
        public virtual Task<UpdateProjectDataDeliveryResponse> UpdateProjectDataDeliveryAsync(UpdateProjectDataDeliveryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProjectDataDeliveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectDataDeliveryResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateProjectDataDeliveryResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}