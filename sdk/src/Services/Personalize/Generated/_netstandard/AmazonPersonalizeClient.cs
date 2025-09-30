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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Personalize.Model;
using Amazon.Personalize.Model.Internal.MarshallTransformations;
using Amazon.Personalize.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Personalize
{
    /// <summary>
    /// <para>Implementation for accessing Personalize</para>
    ///
    /// Amazon Personalize is a machine learning service that makes it easy to add individualized
    /// recommendations to customers.
    /// </summary>
    public partial class AmazonPersonalizeClient : AmazonServiceClient, IAmazonPersonalize
    {
        private static IServiceMetadata serviceMetadata = new AmazonPersonalizeMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonPersonalizeClient with the credentials loaded from the application's
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
        public AmazonPersonalizeClient()
            : base(new AmazonPersonalizeConfig()) { }

        /// <summary>
        /// Constructs AmazonPersonalizeClient with the credentials loaded from the application's
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
        public AmazonPersonalizeClient(RegionEndpoint region)
            : base(new AmazonPersonalizeConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPersonalizeClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPersonalizeClient Configuration Object</param>
        public AmazonPersonalizeClient(AmazonPersonalizeConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonPersonalizeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPersonalizeClient(AWSCredentials credentials)
            : this(credentials, new AmazonPersonalizeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPersonalizeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPersonalizeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeClient with AWS Credentials and an
        /// AmazonPersonalizeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPersonalizeClient Configuration Object</param>
        public AmazonPersonalizeClient(AWSCredentials credentials, AmazonPersonalizeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPersonalizeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPersonalizeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPersonalizeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPersonalizeConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPersonalizeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPersonalizeClient Configuration Object</param>
        public AmazonPersonalizeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPersonalizeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPersonalizeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPersonalizeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPersonalizeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPersonalizeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPersonalizeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPersonalizeClient Configuration Object</param>
        public AmazonPersonalizeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPersonalizeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IPersonalizePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPersonalizePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new PersonalizePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPersonalizeEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPersonalizeAuthSchemeHandler());
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


        #region  CreateBatchInferenceJob

        internal virtual CreateBatchInferenceJobResponse CreateBatchInferenceJob(CreateBatchInferenceJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBatchInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBatchInferenceJobResponseUnmarshaller.Instance;

            return Invoke<CreateBatchInferenceJobResponse>(request, options);
        }



        /// <summary>
        /// Generates batch recommendations based on a list of items or users stored in Amazon
        /// S3 and exports the recommendations to an Amazon S3 bucket.
        /// 
        ///  
        /// <para>
        /// To generate batch recommendations, specify the ARN of a solution version and an Amazon
        /// S3 URI for the input and output data. For user personalization, popular items, and
        /// personalized ranking solutions, the batch inference job generates a list of recommended
        /// items for each user ID in the input file. For related items solutions, the job generates
        /// a list of recommended items for each item ID in the input file.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/getting-batch-recommendations.html">Creating
        /// a batch inference job </a>.
        /// </para>
        ///  
        /// <para>
        ///  If you use the Similar-Items recipe, Amazon Personalize can add descriptive themes
        /// to batch recommendations. To generate themes, set the job's mode to <c>THEME_GENERATION</c>
        /// and specify the name of the field that contains item names in the input data.
        /// </para>
        ///  
        /// <para>
        ///  For more information about generating themes, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/themed-batch-recommendations.html">Batch
        /// recommendations with themes from Content Generator </a>. 
        /// </para>
        ///  
        /// <para>
        /// You can't get batch recommendations with the Trending-Now or Next-Best-Action recipes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchInferenceJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBatchInferenceJob service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.TooManyTagsException">
        /// You have exceeded the maximum number of tags you can apply to this resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateBatchInferenceJob">REST API Reference for CreateBatchInferenceJob Operation</seealso>
        public virtual Task<CreateBatchInferenceJobResponse> CreateBatchInferenceJobAsync(CreateBatchInferenceJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBatchInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBatchInferenceJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBatchInferenceJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateBatchSegmentJob

        internal virtual CreateBatchSegmentJobResponse CreateBatchSegmentJob(CreateBatchSegmentJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBatchSegmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBatchSegmentJobResponseUnmarshaller.Instance;

            return Invoke<CreateBatchSegmentJobResponse>(request, options);
        }



        /// <summary>
        /// Creates a batch segment job. The operation can handle up to 50 million records and
        /// the input file must be in JSON format. For more information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/recommendations-batch.html">Getting
        /// batch recommendations and user segments</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchSegmentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBatchSegmentJob service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.TooManyTagsException">
        /// You have exceeded the maximum number of tags you can apply to this resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateBatchSegmentJob">REST API Reference for CreateBatchSegmentJob Operation</seealso>
        public virtual Task<CreateBatchSegmentJobResponse> CreateBatchSegmentJobAsync(CreateBatchSegmentJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBatchSegmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBatchSegmentJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBatchSegmentJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCampaign

        internal virtual CreateCampaignResponse CreateCampaign(CreateCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return Invoke<CreateCampaignResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        ///  You incur campaign costs while it is active. To avoid unnecessary costs, make sure
        /// to delete the campaign when you are finished. For information about campaign costs,
        /// see <a href="https://aws.amazon.com/personalize/pricing/">Amazon Personalize pricing</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a campaign that deploys a solution version. When a client calls the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetRecommendations.html">GetRecommendations</a>
        /// and <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetPersonalizedRanking.html">GetPersonalizedRanking</a>
        /// APIs, a campaign is specified in the request.
        /// </para>
        ///  
        /// <para>
        ///  <b>Minimum Provisioned TPS and Auto-Scaling</b> 
        /// </para>
        ///  <important> 
        /// <para>
        ///  A high <c>minProvisionedTPS</c> will increase your cost. We recommend starting with
        /// 1 for <c>minProvisionedTPS</c> (the default). Track your usage using Amazon CloudWatch
        /// metrics, and increase the <c>minProvisionedTPS</c> as necessary.
        /// </para>
        ///  </important> 
        /// <para>
        ///  When you create an Amazon Personalize campaign, you can specify the minimum provisioned
        /// transactions per second (<c>minProvisionedTPS</c>) for the campaign. This is the baseline
        /// transaction throughput for the campaign provisioned by Amazon Personalize. It sets
        /// the minimum billing charge for the campaign while it is active. A transaction is a
        /// single <c>GetRecommendations</c> or <c>GetPersonalizedRanking</c> request. The default
        /// <c>minProvisionedTPS</c> is 1.
        /// </para>
        ///  
        /// <para>
        ///  If your TPS increases beyond the <c>minProvisionedTPS</c>, Amazon Personalize auto-scales
        /// the provisioned capacity up and down, but never below <c>minProvisionedTPS</c>. There's
        /// a short time delay while the capacity is increased that might cause loss of transactions.
        /// When your traffic reduces, capacity returns to the <c>minProvisionedTPS</c>. 
        /// </para>
        ///  
        /// <para>
        /// You are charged for the the minimum provisioned TPS or, if your requests exceed the
        /// <c>minProvisionedTPS</c>, the actual TPS. The actual TPS is the total number of recommendation
        /// requests you make. We recommend starting with a low <c>minProvisionedTPS</c>, track
        /// your usage using Amazon CloudWatch metrics, and then increase the <c>minProvisionedTPS</c>
        /// as necessary.
        /// </para>
        ///  
        /// <para>
        /// For more information about campaign costs, see <a href="https://aws.amazon.com/personalize/pricing/">Amazon
        /// Personalize pricing</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Status</b> 
        /// </para>
        ///  
        /// <para>
        /// A campaign can be in one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE PENDING &gt; DELETE IN_PROGRESS
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the campaign status, call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeCampaign.html">DescribeCampaign</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Wait until the <c>status</c> of the campaign is <c>ACTIVE</c> before asking the campaign
        /// for recommendations.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Related APIs</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListCampaigns.html">ListCampaigns</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeCampaign.html">DescribeCampaign</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_UpdateCampaign.html">UpdateCampaign</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DeleteCampaign.html">DeleteCampaign</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCampaign service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.TooManyTagsException">
        /// You have exceeded the maximum number of tags you can apply to this resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        public virtual Task<CreateCampaignResponse> CreateCampaignAsync(CreateCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCampaignResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDataDeletionJob

        internal virtual CreateDataDeletionJobResponse CreateDataDeletionJob(CreateDataDeletionJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataDeletionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataDeletionJobResponseUnmarshaller.Instance;

            return Invoke<CreateDataDeletionJobResponse>(request, options);
        }



        /// <summary>
        /// Creates a batch job that deletes all references to specific users from an Amazon Personalize
        /// dataset group in batches. You specify the users to delete in a CSV file of userIds
        /// in an Amazon S3 bucket. After a job completes, Amazon Personalize no longer trains
        /// on the users’ data and no longer considers the users when generating user segments.
        /// For more information about creating a data deletion job, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/delete-records.html">Deleting
        /// users</a>.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Your input file must be a CSV file with a single USER_ID column that lists the users
        /// IDs. For more information about preparing the CSV file, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/prepare-deletion-input-file.html">Preparing
        /// your data deletion file and uploading it to Amazon S3</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To give Amazon Personalize permission to access your input CSV file of userIds, you
        /// must specify an IAM service role that has permission to read from the data source.
        /// This role needs <c>GetObject</c> and <c>ListBucket</c> permissions for the bucket
        /// and its content. These permissions are the same as importing data. For information
        /// on granting access to your Amazon S3 bucket, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/granting-personalize-s3-access.html">Giving
        /// Amazon Personalize Access to Amazon S3 Resources</a>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  After you create a job, it can take up to a day to delete all references to the users
        /// from datasets and models. Until the job completes, Amazon Personalize continues to
        /// use the data when training. And if you use a User Segmentation recipe, the users might
        /// appear in user segments. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Status</b> 
        /// </para>
        ///  
        /// <para>
        /// A data deletion job can have one of the following statuses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PENDING &gt; IN_PROGRESS &gt; COMPLETED -or- FAILED
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the status of the data deletion job, call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeDataDeletionJob.html">DescribeDataDeletionJob</a>
        /// API operation and specify the Amazon Resource Name (ARN) of the job. If the status
        /// is FAILED, the response includes a <c>failureReason</c> key, which describes why the
        /// job failed.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related APIs</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListDataDeletionJobs.html">ListDataDeletionJobs</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeDataDeletionJob.html">DescribeDataDeletionJob</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataDeletionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataDeletionJob service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.TooManyTagsException">
        /// You have exceeded the maximum number of tags you can apply to this resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateDataDeletionJob">REST API Reference for CreateDataDeletionJob Operation</seealso>
        public virtual Task<CreateDataDeletionJobResponse> CreateDataDeletionJobAsync(CreateDataDeletionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataDeletionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataDeletionJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataDeletionJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDataset

        internal virtual CreateDatasetResponse CreateDataset(CreateDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetResponse>(request, options);
        }



        /// <summary>
        /// Creates an empty dataset and adds it to the specified dataset group. Use <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDatasetImportJob.html">CreateDatasetImportJob</a>
        /// to import your training data to a dataset.
        /// 
        ///  
        /// <para>
        /// There are 5 types of datasets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Item interactions
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Items
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Users
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Action interactions
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Actions
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Each dataset type has an associated schema with required field types. Only the <c>Item
        /// interactions</c> dataset is required in order to train a model (also referred to as
        /// creating a solution).
        /// </para>
        ///  
        /// <para>
        /// A dataset can be in one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE PENDING &gt; DELETE IN_PROGRESS
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the status of the dataset, call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeDataset.html">DescribeDataset</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related APIs</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDatasetGroup.html">CreateDatasetGroup</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListDatasets.html">ListDatasets</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeDataset.html">DescribeDataset</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DeleteDataset.html">DeleteDataset</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataset service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.TooManyTagsException">
        /// You have exceeded the maximum number of tags you can apply to this resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual Task<CreateDatasetResponse> CreateDatasetAsync(CreateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatasetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDatasetExportJob

        internal virtual CreateDatasetExportJobResponse CreateDatasetExportJob(CreateDatasetExportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatasetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetExportJobResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetExportJobResponse>(request, options);
        }



        /// <summary>
        /// Creates a job that exports data from your dataset to an Amazon S3 bucket. To allow
        /// Amazon Personalize to export the training data, you must specify an service-linked
        /// IAM role that gives Amazon Personalize <c>PutObject</c> permissions for your Amazon
        /// S3 bucket. For information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/export-data.html">Exporting
        /// a dataset</a> in the Amazon Personalize developer guide. 
        /// 
        ///  
        /// <para>
        ///  <b>Status</b> 
        /// </para>
        ///  
        /// <para>
        /// A dataset export job can be in one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  To get the status of the export job, call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeDatasetExportJob.html">DescribeDatasetExportJob</a>,
        /// and specify the Amazon Resource Name (ARN) of the dataset export job. The dataset
        /// export is complete when the status shows as ACTIVE. If the status shows as CREATE
        /// FAILED, the response includes a <c>failureReason</c> key, which describes why the
        /// job failed. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDatasetExportJob service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.TooManyTagsException">
        /// You have exceeded the maximum number of tags you can apply to this resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateDatasetExportJob">REST API Reference for CreateDatasetExportJob Operation</seealso>
        public virtual Task<CreateDatasetExportJobResponse> CreateDatasetExportJobAsync(CreateDatasetExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatasetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatasetExportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDatasetGroup

        internal virtual CreateDatasetGroupResponse CreateDatasetGroup(CreateDatasetGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates an empty dataset group. A dataset group is a container for Amazon Personalize
        /// resources. A dataset group can contain at most three datasets, one for each type of
        /// dataset:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Item interactions
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Items
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Users
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Actions
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Action interactions
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  A dataset group can be a Domain dataset group, where you specify a domain and use
        /// pre-configured resources like recommenders, or a Custom dataset group, where you use
        /// custom resources, such as a solution with a solution version, that you deploy with
        /// a campaign. If you start with a Domain dataset group, you can still add custom resources
        /// such as solutions and solution versions trained with recipes for custom use cases
        /// and deployed with campaigns. 
        /// </para>
        ///  
        /// <para>
        /// A dataset group can be in one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE PENDING
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the status of the dataset group, call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeDatasetGroup.html">DescribeDatasetGroup</a>.
        /// If the status shows as CREATE FAILED, the response includes a <c>failureReason</c>
        /// key, which describes why the creation failed.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must wait until the <c>status</c> of the dataset group is <c>ACTIVE</c> before
        /// adding a dataset to the group.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can specify an Key Management Service (KMS) key to encrypt the datasets in the
        /// group. If you specify a KMS key, you must also include an Identity and Access Management
        /// (IAM) role that has permission to access the key.
        /// </para>
        ///  
        /// <para>
        ///  <b>APIs that require a dataset group ARN in the request</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDataset.html">CreateDataset</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateEventTracker.html">CreateEventTracker</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSolution.html">CreateSolution</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related APIs</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListDatasetGroups.html">ListDatasetGroups</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeDatasetGroup.html">DescribeDatasetGroup</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DeleteDatasetGroup.html">DeleteDatasetGroup</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDatasetGroup service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.TooManyTagsException">
        /// You have exceeded the maximum number of tags you can apply to this resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateDatasetGroup">REST API Reference for CreateDatasetGroup Operation</seealso>
        public virtual Task<CreateDatasetGroupResponse> CreateDatasetGroupAsync(CreateDatasetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatasetGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDatasetImportJob

        internal virtual CreateDatasetImportJobResponse CreateDatasetImportJob(CreateDatasetImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatasetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetImportJobResponse>(request, options);
        }



        /// <summary>
        /// Creates a job that imports training data from your data source (an Amazon S3 bucket)
        /// to an Amazon Personalize dataset. To allow Amazon Personalize to import the training
        /// data, you must specify an IAM service role that has permission to read from the data
        /// source, as Amazon Personalize makes a copy of your data and processes it internally.
        /// For information on granting access to your Amazon S3 bucket, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/granting-personalize-s3-access.html">Giving
        /// Amazon Personalize Access to Amazon S3 Resources</a>. 
        /// 
        ///  
        /// <para>
        /// If you already created a recommender or deployed a custom solution version with a
        /// campaign, how new bulk records influence recommendations depends on the domain use
        /// case or recipe that you use. For more information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/how-new-data-influences-recommendations.html">How
        /// new data influences real-time recommendations</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// By default, a dataset import job replaces any existing data in the dataset that you
        /// imported in bulk. To add new records without replacing existing data, specify INCREMENTAL
        /// for the import mode in the CreateDatasetImportJob operation.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Status</b> 
        /// </para>
        ///  
        /// <para>
        /// A dataset import job can be in one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the status of the import job, call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeDatasetImportJob.html">DescribeDatasetImportJob</a>,
        /// providing the Amazon Resource Name (ARN) of the dataset import job. The dataset import
        /// is complete when the status shows as ACTIVE. If the status shows as CREATE FAILED,
        /// the response includes a <c>failureReason</c> key, which describes why the job failed.
        /// </para>
        ///  <note> 
        /// <para>
        /// Importing takes time. You must wait until the status shows as ACTIVE before training
        /// a model using the dataset.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Related APIs</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListDatasetImportJobs.html">ListDatasetImportJobs</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeDatasetImportJob.html">DescribeDatasetImportJob</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDatasetImportJob service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.TooManyTagsException">
        /// You have exceeded the maximum number of tags you can apply to this resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateDatasetImportJob">REST API Reference for CreateDatasetImportJob Operation</seealso>
        public virtual Task<CreateDatasetImportJobResponse> CreateDatasetImportJobAsync(CreateDatasetImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatasetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatasetImportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateEventTracker

        internal virtual CreateEventTrackerResponse CreateEventTracker(CreateEventTrackerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventTrackerResponseUnmarshaller.Instance;

            return Invoke<CreateEventTrackerResponse>(request, options);
        }



        /// <summary>
        /// Creates an event tracker that you use when adding event data to a specified dataset
        /// group using the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_UBS_PutEvents.html">PutEvents</a>
        /// API.
        /// 
        ///  <note> 
        /// <para>
        /// Only one event tracker can be associated with a dataset group. You will get an error
        /// if you call <c>CreateEventTracker</c> using the same dataset group as an existing
        /// event tracker.
        /// </para>
        ///  </note> 
        /// <para>
        /// When you create an event tracker, the response includes a tracking ID, which you pass
        /// as a parameter when you use the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_UBS_PutEvents.html">PutEvents</a>
        /// operation. Amazon Personalize then appends the event data to the Item interactions
        /// dataset of the dataset group you specify in your event tracker. 
        /// </para>
        ///  
        /// <para>
        /// The event tracker can be in one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE PENDING &gt; DELETE IN_PROGRESS
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the status of the event tracker, call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeEventTracker.html">DescribeEventTracker</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The event tracker must be in the ACTIVE state before using the tracking ID.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Related APIs</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListEventTrackers.html">ListEventTrackers</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeEventTracker.html">DescribeEventTracker</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DeleteEventTracker.html">DeleteEventTracker</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventTracker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventTracker service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.TooManyTagsException">
        /// You have exceeded the maximum number of tags you can apply to this resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateEventTracker">REST API Reference for CreateEventTracker Operation</seealso>
        public virtual Task<CreateEventTrackerResponse> CreateEventTrackerAsync(CreateEventTrackerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventTrackerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEventTrackerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFilter

        internal virtual CreateFilterResponse CreateFilter(CreateFilterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFilterResponseUnmarshaller.Instance;

            return Invoke<CreateFilterResponse>(request, options);
        }



        /// <summary>
        /// Creates a recommendation filter. For more information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/filter.html">Filtering
        /// recommendations and user segments</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFilter service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.TooManyTagsException">
        /// You have exceeded the maximum number of tags you can apply to this resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        public virtual Task<CreateFilterResponse> CreateFilterAsync(CreateFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFilterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFilterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateMetricAttribution

        internal virtual CreateMetricAttributionResponse CreateMetricAttribution(CreateMetricAttributionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMetricAttributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMetricAttributionResponseUnmarshaller.Instance;

            return Invoke<CreateMetricAttributionResponse>(request, options);
        }



        /// <summary>
        /// Creates a metric attribution. A metric attribution creates reports on the data that
        /// you import into Amazon Personalize. Depending on how you imported the data, you can
        /// view reports in Amazon CloudWatch or Amazon S3. For more information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/measuring-recommendation-impact.html">Measuring
        /// impact of recommendations</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMetricAttribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMetricAttribution service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateMetricAttribution">REST API Reference for CreateMetricAttribution Operation</seealso>
        public virtual Task<CreateMetricAttributionResponse> CreateMetricAttributionAsync(CreateMetricAttributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMetricAttributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMetricAttributionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMetricAttributionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRecommender

        internal virtual CreateRecommenderResponse CreateRecommender(CreateRecommenderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRecommenderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRecommenderResponseUnmarshaller.Instance;

            return Invoke<CreateRecommenderResponse>(request, options);
        }



        /// <summary>
        /// Creates a recommender with the recipe (a Domain dataset group use case) you specify.
        /// You create recommenders for a Domain dataset group and specify the recommender's Amazon
        /// Resource Name (ARN) when you make a <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetRecommendations.html">GetRecommendations</a>
        /// request. 
        /// 
        ///  
        /// <para>
        ///  <b>Minimum recommendation requests per second</b> 
        /// </para>
        ///  <important> 
        /// <para>
        /// A high <c>minRecommendationRequestsPerSecond</c> will increase your bill. We recommend
        /// starting with 1 for <c>minRecommendationRequestsPerSecond</c> (the default). Track
        /// your usage using Amazon CloudWatch metrics, and increase the <c>minRecommendationRequestsPerSecond</c>
        /// as necessary.
        /// </para>
        ///  </important> 
        /// <para>
        /// When you create a recommender, you can configure the recommender's minimum recommendation
        /// requests per second. The minimum recommendation requests per second (<c>minRecommendationRequestsPerSecond</c>)
        /// specifies the baseline recommendation request throughput provisioned by Amazon Personalize.
        /// The default minRecommendationRequestsPerSecond is <c>1</c>. A recommendation request
        /// is a single <c>GetRecommendations</c> operation. Request throughput is measured in
        /// requests per second and Amazon Personalize uses your requests per second to derive
        /// your requests per hour and the price of your recommender usage. 
        /// </para>
        ///  
        /// <para>
        ///  If your requests per second increases beyond <c>minRecommendationRequestsPerSecond</c>,
        /// Amazon Personalize auto-scales the provisioned capacity up and down, but never below
        /// <c>minRecommendationRequestsPerSecond</c>. There's a short time delay while the capacity
        /// is increased that might cause loss of requests.
        /// </para>
        ///  
        /// <para>
        ///  Your bill is the greater of either the minimum requests per hour (based on minRecommendationRequestsPerSecond)
        /// or the actual number of requests. The actual request throughput used is calculated
        /// as the average requests/second within a one-hour window. We recommend starting with
        /// the default <c>minRecommendationRequestsPerSecond</c>, track your usage using Amazon
        /// CloudWatch metrics, and then increase the <c>minRecommendationRequestsPerSecond</c>
        /// as necessary. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Status</b> 
        /// </para>
        ///  
        /// <para>
        /// A recommender can be in one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STOP PENDING &gt; STOP IN_PROGRESS &gt; INACTIVE &gt; START PENDING &gt; START IN_PROGRESS
        /// &gt; ACTIVE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE PENDING &gt; DELETE IN_PROGRESS
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the recommender status, call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeRecommender.html">DescribeRecommender</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Wait until the <c>status</c> of the recommender is <c>ACTIVE</c> before asking the
        /// recommender for recommendations.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Related APIs</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListRecommenders.html">ListRecommenders</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeRecommender.html">DescribeRecommender</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_UpdateRecommender.html">UpdateRecommender</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DeleteRecommender.html">DeleteRecommender</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecommender service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRecommender service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.TooManyTagsException">
        /// You have exceeded the maximum number of tags you can apply to this resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateRecommender">REST API Reference for CreateRecommender Operation</seealso>
        public virtual Task<CreateRecommenderResponse> CreateRecommenderAsync(CreateRecommenderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRecommenderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRecommenderResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRecommenderResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSchema

        internal virtual CreateSchemaResponse CreateSchema(CreateSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return Invoke<CreateSchemaResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Personalize schema from the specified schema string. The schema
        /// you create must be in Avro JSON format.
        /// 
        ///  
        /// <para>
        /// Amazon Personalize recognizes three schema variants. Each schema is associated with
        /// a dataset type and has a set of required field and keywords. If you are creating a
        /// schema for a dataset in a Domain dataset group, you provide the domain of the Domain
        /// dataset group. You specify a schema when you call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDataset.html">CreateDataset</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related APIs</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListSchemas.html">ListSchemas</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeSchema.html">DescribeSchema</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DeleteSchema.html">DeleteSchema</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSchema service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        public virtual Task<CreateSchemaResponse> CreateSchemaAsync(CreateSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSchemaResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSolution

        internal virtual CreateSolutionResponse CreateSolution(CreateSolutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSolutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSolutionResponseUnmarshaller.Instance;

            return Invoke<CreateSolutionResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// By default, all new solutions use automatic training. With automatic training, you
        /// incur training costs while your solution is active. To avoid unnecessary costs, when
        /// you are finished you can <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_UpdateSolution.html">update
        /// the solution</a> to turn off automatic training. For information about training costs,
        /// see <a href="https://aws.amazon.com/personalize/pricing/">Amazon Personalize pricing</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates the configuration for training a model (creating a solution version). This
        /// configuration includes the recipe to use for model training and optional training
        /// configuration, such as columns to use in training and feature transformation parameters.
        /// For more information about configuring a solution, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/customizing-solution-config.html">Creating
        /// and configuring a solution</a>. 
        /// </para>
        ///  
        /// <para>
        ///  By default, new solutions use automatic training to create solution versions every
        /// 7 days. You can change the training frequency. Automatic solution version creation
        /// starts within one hour after the solution is ACTIVE. If you manually create a solution
        /// version within the hour, the solution skips the first automatic training. For more
        /// information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/solution-config-auto-training.html">Configuring
        /// automatic training</a>.
        /// </para>
        ///  
        /// <para>
        ///  To turn off automatic training, set <c>performAutoTraining</c> to false. If you turn
        /// off automatic training, you must manually create a solution version by calling the
        /// <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSolutionVersion.html">CreateSolutionVersion</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// After training starts, you can get the solution version's Amazon Resource Name (ARN)
        /// with the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListSolutionVersions.html">ListSolutionVersions</a>
        /// API operation. To get its status, use the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeSolutionVersion.html">DescribeSolutionVersion</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// After training completes you can evaluate model accuracy by calling <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_GetSolutionMetrics.html">GetSolutionMetrics</a>.
        /// When you are satisfied with the solution version, you deploy it using <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateCampaign.html">CreateCampaign</a>.
        /// The campaign provides recommendations to a client through the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetRecommendations.html">GetRecommendations</a>
        /// API.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Personalize doesn't support configuring the <c>hpoObjective</c> for solution
        /// hyperparameter optimization at this time.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Status</b> 
        /// </para>
        ///  
        /// <para>
        /// A solution can be in one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE PENDING &gt; DELETE IN_PROGRESS
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the status of the solution, call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeSolution.html">DescribeSolution</a>.
        /// If you use manual training, the status must be ACTIVE before you call <c>CreateSolutionVersion</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related APIs</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_UpdateSolution.html">UpdateSolution</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListSolutions.html">ListSolutions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSolutionVersion.html">CreateSolutionVersion</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeSolution.html">DescribeSolution</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DeleteSolution.html">DeleteSolution</a>
        /// 
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListSolutionVersions.html">ListSolutionVersions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeSolutionVersion.html">DescribeSolutionVersion</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSolution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSolution service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.TooManyTagsException">
        /// You have exceeded the maximum number of tags you can apply to this resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateSolution">REST API Reference for CreateSolution Operation</seealso>
        public virtual Task<CreateSolutionResponse> CreateSolutionAsync(CreateSolutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSolutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSolutionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSolutionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSolutionVersion

        internal virtual CreateSolutionVersionResponse CreateSolutionVersion(CreateSolutionVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSolutionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSolutionVersionResponseUnmarshaller.Instance;

            return Invoke<CreateSolutionVersionResponse>(request, options);
        }



        /// <summary>
        /// Trains or retrains an active solution in a Custom dataset group. A solution is created
        /// using the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSolution.html">CreateSolution</a>
        /// operation and must be in the ACTIVE state before calling <c>CreateSolutionVersion</c>.
        /// A new version of the solution is created every time you call this operation.
        /// 
        ///  
        /// <para>
        ///  <b>Status</b> 
        /// </para>
        ///  
        /// <para>
        /// A solution version can be in one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATE PENDING
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE IN_PROGRESS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACTIVE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE FAILED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE STOPPING
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE STOPPED
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the status of the version, call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeSolutionVersion.html">DescribeSolutionVersion</a>.
        /// Wait until the status shows as ACTIVE before calling <c>CreateCampaign</c>.
        /// </para>
        ///  
        /// <para>
        /// If the status shows as CREATE FAILED, the response includes a <c>failureReason</c>
        /// key, which describes why the job failed.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related APIs</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListSolutionVersions.html">ListSolutionVersions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeSolutionVersion.html">DescribeSolutionVersion</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListSolutions.html">ListSolutions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSolution.html">CreateSolution</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeSolution.html">DescribeSolution</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DeleteSolution.html">DeleteSolution</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSolutionVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSolutionVersion service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.TooManyTagsException">
        /// You have exceeded the maximum number of tags you can apply to this resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateSolutionVersion">REST API Reference for CreateSolutionVersion Operation</seealso>
        public virtual Task<CreateSolutionVersionResponse> CreateSolutionVersionAsync(CreateSolutionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSolutionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSolutionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSolutionVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCampaign

        internal virtual DeleteCampaignResponse DeleteCampaign(DeleteCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return Invoke<DeleteCampaignResponse>(request, options);
        }



        /// <summary>
        /// Removes a campaign by deleting the solution deployment. The solution that the campaign
        /// is based on is not deleted and can be redeployed when needed. A deleted campaign can
        /// no longer be specified in a <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetRecommendations.html">GetRecommendations</a>
        /// request. For information on creating campaigns, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateCampaign.html">CreateCampaign</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCampaign service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        public virtual Task<DeleteCampaignResponse> DeleteCampaignAsync(DeleteCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCampaignResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDataset

        internal virtual DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetResponse>(request, options);
        }



        /// <summary>
        /// Deletes a dataset. You can't delete a dataset if an associated <c>DatasetImportJob</c>
        /// or <c>SolutionVersion</c> is in the CREATE PENDING or IN PROGRESS state. For more
        /// information about deleting datasets, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/delete-dataset.html">Deleting
        /// a dataset</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatasetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDatasetGroup

        internal virtual DeleteDatasetGroupResponse DeleteDatasetGroup(DeleteDatasetGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a dataset group. Before you delete a dataset group, you must delete the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// All associated event trackers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All associated solutions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All datasets in the dataset group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDatasetGroup service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteDatasetGroup">REST API Reference for DeleteDatasetGroup Operation</seealso>
        public virtual Task<DeleteDatasetGroupResponse> DeleteDatasetGroupAsync(DeleteDatasetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatasetGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEventTracker

        internal virtual DeleteEventTrackerResponse DeleteEventTracker(DeleteEventTrackerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventTrackerResponseUnmarshaller.Instance;

            return Invoke<DeleteEventTrackerResponse>(request, options);
        }



        /// <summary>
        /// Deletes the event tracker. Does not delete the dataset from the dataset group. For
        /// more information on event trackers, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateEventTracker.html">CreateEventTracker</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventTracker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventTracker service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteEventTracker">REST API Reference for DeleteEventTracker Operation</seealso>
        public virtual Task<DeleteEventTrackerResponse> DeleteEventTrackerAsync(DeleteEventTrackerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventTrackerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEventTrackerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFilter

        internal virtual DeleteFilterResponse DeleteFilter(DeleteFilterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFilterResponseUnmarshaller.Instance;

            return Invoke<DeleteFilterResponse>(request, options);
        }



        /// <summary>
        /// Deletes a filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFilter service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteFilter">REST API Reference for DeleteFilter Operation</seealso>
        public virtual Task<DeleteFilterResponse> DeleteFilterAsync(DeleteFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFilterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFilterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteMetricAttribution

        internal virtual DeleteMetricAttributionResponse DeleteMetricAttribution(DeleteMetricAttributionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMetricAttributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMetricAttributionResponseUnmarshaller.Instance;

            return Invoke<DeleteMetricAttributionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a metric attribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMetricAttribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMetricAttribution service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteMetricAttribution">REST API Reference for DeleteMetricAttribution Operation</seealso>
        public virtual Task<DeleteMetricAttributionResponse> DeleteMetricAttributionAsync(DeleteMetricAttributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMetricAttributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMetricAttributionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMetricAttributionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRecommender

        internal virtual DeleteRecommenderResponse DeleteRecommender(DeleteRecommenderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRecommenderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecommenderResponseUnmarshaller.Instance;

            return Invoke<DeleteRecommenderResponse>(request, options);
        }



        /// <summary>
        /// Deactivates and removes a recommender. A deleted recommender can no longer be specified
        /// in a <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetRecommendations.html">GetRecommendations</a>
        /// request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecommender service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRecommender service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteRecommender">REST API Reference for DeleteRecommender Operation</seealso>
        public virtual Task<DeleteRecommenderResponse> DeleteRecommenderAsync(DeleteRecommenderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRecommenderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecommenderResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRecommenderResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSchema

        internal virtual DeleteSchemaResponse DeleteSchema(DeleteSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return Invoke<DeleteSchemaResponse>(request, options);
        }



        /// <summary>
        /// Deletes a schema. Before deleting a schema, you must delete all datasets referencing
        /// the schema. For more information on schemas, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSchema.html">CreateSchema</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSchema service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        public virtual Task<DeleteSchemaResponse> DeleteSchemaAsync(DeleteSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSchemaResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSolution

        internal virtual DeleteSolutionResponse DeleteSolution(DeleteSolutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSolutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSolutionResponseUnmarshaller.Instance;

            return Invoke<DeleteSolutionResponse>(request, options);
        }



        /// <summary>
        /// Deletes all versions of a solution and the <c>Solution</c> object itself. Before deleting
        /// a solution, you must delete all campaigns based on the solution. To determine what
        /// campaigns are using the solution, call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListCampaigns.html">ListCampaigns</a>
        /// and supply the Amazon Resource Name (ARN) of the solution. You can't delete a solution
        /// if an associated <c>SolutionVersion</c> is in the CREATE PENDING or IN PROGRESS state.
        /// For more information on solutions, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSolution.html">CreateSolution</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSolution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSolution service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteSolution">REST API Reference for DeleteSolution Operation</seealso>
        public virtual Task<DeleteSolutionResponse> DeleteSolutionAsync(DeleteSolutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSolutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSolutionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSolutionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAlgorithm

        internal virtual DescribeAlgorithmResponse DescribeAlgorithm(DescribeAlgorithmRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlgorithmResponseUnmarshaller.Instance;

            return Invoke<DescribeAlgorithmResponse>(request, options);
        }



        /// <summary>
        /// Describes the given algorithm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlgorithm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAlgorithm service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeAlgorithm">REST API Reference for DescribeAlgorithm Operation</seealso>
        public virtual Task<DescribeAlgorithmResponse> DescribeAlgorithmAsync(DescribeAlgorithmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlgorithmResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAlgorithmResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeBatchInferenceJob

        internal virtual DescribeBatchInferenceJobResponse DescribeBatchInferenceJob(DescribeBatchInferenceJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBatchInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBatchInferenceJobResponseUnmarshaller.Instance;

            return Invoke<DescribeBatchInferenceJobResponse>(request, options);
        }



        /// <summary>
        /// Gets the properties of a batch inference job including name, Amazon Resource Name
        /// (ARN), status, input and output configurations, and the ARN of the solution version
        /// used to generate the recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBatchInferenceJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBatchInferenceJob service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeBatchInferenceJob">REST API Reference for DescribeBatchInferenceJob Operation</seealso>
        public virtual Task<DescribeBatchInferenceJobResponse> DescribeBatchInferenceJobAsync(DescribeBatchInferenceJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBatchInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBatchInferenceJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBatchInferenceJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeBatchSegmentJob

        internal virtual DescribeBatchSegmentJobResponse DescribeBatchSegmentJob(DescribeBatchSegmentJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBatchSegmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBatchSegmentJobResponseUnmarshaller.Instance;

            return Invoke<DescribeBatchSegmentJobResponse>(request, options);
        }



        /// <summary>
        /// Gets the properties of a batch segment job including name, Amazon Resource Name (ARN),
        /// status, input and output configurations, and the ARN of the solution version used
        /// to generate segments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBatchSegmentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBatchSegmentJob service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeBatchSegmentJob">REST API Reference for DescribeBatchSegmentJob Operation</seealso>
        public virtual Task<DescribeBatchSegmentJobResponse> DescribeBatchSegmentJobAsync(DescribeBatchSegmentJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBatchSegmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBatchSegmentJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBatchSegmentJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeCampaign

        internal virtual DescribeCampaignResponse DescribeCampaign(DescribeCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCampaignResponseUnmarshaller.Instance;

            return Invoke<DescribeCampaignResponse>(request, options);
        }



        /// <summary>
        /// Describes the given campaign, including its status.
        /// 
        ///  
        /// <para>
        /// A campaign can be in one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE PENDING &gt; DELETE IN_PROGRESS
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When the <c>status</c> is <c>CREATE FAILED</c>, the response includes the <c>failureReason</c>
        /// key, which describes why.
        /// </para>
        ///  
        /// <para>
        /// For more information on campaigns, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateCampaign.html">CreateCampaign</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCampaign service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeCampaign">REST API Reference for DescribeCampaign Operation</seealso>
        public virtual Task<DescribeCampaignResponse> DescribeCampaignAsync(DescribeCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCampaignResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCampaignResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDataDeletionJob

        internal virtual DescribeDataDeletionJobResponse DescribeDataDeletionJob(DescribeDataDeletionJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDataDeletionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataDeletionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDataDeletionJobResponse>(request, options);
        }



        /// <summary>
        /// Describes the data deletion job created by <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDataDeletionJob.html">CreateDataDeletionJob</a>,
        /// including the job status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataDeletionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataDeletionJob service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDataDeletionJob">REST API Reference for DescribeDataDeletionJob Operation</seealso>
        public virtual Task<DescribeDataDeletionJobResponse> DescribeDataDeletionJobAsync(DescribeDataDeletionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDataDeletionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataDeletionJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDataDeletionJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDataset

        internal virtual DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetResponse>(request, options);
        }



        /// <summary>
        /// Describes the given dataset. For more information on datasets, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDataset.html">CreateDataset</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual Task<DescribeDatasetResponse> DescribeDatasetAsync(DescribeDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDatasetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDatasetExportJob

        internal virtual DescribeDatasetExportJobResponse DescribeDatasetExportJob(DescribeDatasetExportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatasetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetExportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetExportJobResponse>(request, options);
        }



        /// <summary>
        /// Describes the dataset export job created by <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDatasetExportJob.html">CreateDatasetExportJob</a>,
        /// including the export job status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDatasetExportJob service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDatasetExportJob">REST API Reference for DescribeDatasetExportJob Operation</seealso>
        public virtual Task<DescribeDatasetExportJobResponse> DescribeDatasetExportJobAsync(DescribeDatasetExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatasetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDatasetExportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDatasetGroup

        internal virtual DescribeDatasetGroupResponse DescribeDatasetGroup(DescribeDatasetGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetGroupResponse>(request, options);
        }



        /// <summary>
        /// Describes the given dataset group. For more information on dataset groups, see <a
        /// href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDatasetGroup.html">CreateDatasetGroup</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDatasetGroup service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDatasetGroup">REST API Reference for DescribeDatasetGroup Operation</seealso>
        public virtual Task<DescribeDatasetGroupResponse> DescribeDatasetGroupAsync(DescribeDatasetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDatasetGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDatasetImportJob

        internal virtual DescribeDatasetImportJobResponse DescribeDatasetImportJob(DescribeDatasetImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatasetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetImportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetImportJobResponse>(request, options);
        }



        /// <summary>
        /// Describes the dataset import job created by <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDatasetImportJob.html">CreateDatasetImportJob</a>,
        /// including the import job status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDatasetImportJob service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDatasetImportJob">REST API Reference for DescribeDatasetImportJob Operation</seealso>
        public virtual Task<DescribeDatasetImportJobResponse> DescribeDatasetImportJobAsync(DescribeDatasetImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatasetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDatasetImportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeEventTracker

        internal virtual DescribeEventTrackerResponse DescribeEventTracker(DescribeEventTrackerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventTrackerResponseUnmarshaller.Instance;

            return Invoke<DescribeEventTrackerResponse>(request, options);
        }



        /// <summary>
        /// Describes an event tracker. The response includes the <c>trackingId</c> and <c>status</c>
        /// of the event tracker. For more information on event trackers, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateEventTracker.html">CreateEventTracker</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventTracker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventTracker service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeEventTracker">REST API Reference for DescribeEventTracker Operation</seealso>
        public virtual Task<DescribeEventTrackerResponse> DescribeEventTrackerAsync(DescribeEventTrackerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventTrackerResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventTrackerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFeatureTransformation

        internal virtual DescribeFeatureTransformationResponse DescribeFeatureTransformation(DescribeFeatureTransformationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFeatureTransformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFeatureTransformationResponseUnmarshaller.Instance;

            return Invoke<DescribeFeatureTransformationResponse>(request, options);
        }



        /// <summary>
        /// Describes the given feature transformation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFeatureTransformation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFeatureTransformation service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeFeatureTransformation">REST API Reference for DescribeFeatureTransformation Operation</seealso>
        public virtual Task<DescribeFeatureTransformationResponse> DescribeFeatureTransformationAsync(DescribeFeatureTransformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFeatureTransformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFeatureTransformationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFeatureTransformationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFilter

        internal virtual DescribeFilterResponse DescribeFilter(DescribeFilterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFilterResponseUnmarshaller.Instance;

            return Invoke<DescribeFilterResponse>(request, options);
        }



        /// <summary>
        /// Describes a filter's properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFilter service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeFilter">REST API Reference for DescribeFilter Operation</seealso>
        public virtual Task<DescribeFilterResponse> DescribeFilterAsync(DescribeFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFilterResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFilterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeMetricAttribution

        internal virtual DescribeMetricAttributionResponse DescribeMetricAttribution(DescribeMetricAttributionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMetricAttributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetricAttributionResponseUnmarshaller.Instance;

            return Invoke<DescribeMetricAttributionResponse>(request, options);
        }



        /// <summary>
        /// Describes a metric attribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricAttribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMetricAttribution service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeMetricAttribution">REST API Reference for DescribeMetricAttribution Operation</seealso>
        public virtual Task<DescribeMetricAttributionResponse> DescribeMetricAttributionAsync(DescribeMetricAttributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMetricAttributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetricAttributionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMetricAttributionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeRecipe

        internal virtual DescribeRecipeResponse DescribeRecipe(DescribeRecipeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecipeResponseUnmarshaller.Instance;

            return Invoke<DescribeRecipeResponse>(request, options);
        }



        /// <summary>
        /// Describes a recipe.
        /// 
        ///  
        /// <para>
        /// A recipe contains three items:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An algorithm that trains a model.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Hyperparameters that govern the training.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Feature transformation information for modifying the input data before training.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon Personalize provides a set of predefined recipes. You specify a recipe when
        /// you create a solution with the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSolution.html">CreateSolution</a>
        /// API. <c>CreateSolution</c> trains a model by using the algorithm in the specified
        /// recipe and a training dataset. The solution, when deployed as a campaign, can provide
        /// recommendations using the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetRecommendations.html">GetRecommendations</a>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecipe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRecipe service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeRecipe">REST API Reference for DescribeRecipe Operation</seealso>
        public virtual Task<DescribeRecipeResponse> DescribeRecipeAsync(DescribeRecipeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecipeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRecipeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeRecommender

        internal virtual DescribeRecommenderResponse DescribeRecommender(DescribeRecommenderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRecommenderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecommenderResponseUnmarshaller.Instance;

            return Invoke<DescribeRecommenderResponse>(request, options);
        }



        /// <summary>
        /// Describes the given recommender, including its status.
        /// 
        ///  
        /// <para>
        /// A recommender can be in one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STOP PENDING &gt; STOP IN_PROGRESS &gt; INACTIVE &gt; START PENDING &gt; START IN_PROGRESS
        /// &gt; ACTIVE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE PENDING &gt; DELETE IN_PROGRESS
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When the <c>status</c> is <c>CREATE FAILED</c>, the response includes the <c>failureReason</c>
        /// key, which describes why.
        /// </para>
        ///  
        /// <para>
        /// The <c>modelMetrics</c> key is null when the recommender is being created or deleted.
        /// </para>
        ///  
        /// <para>
        /// For more information on recommenders, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateRecommender.html">CreateRecommender</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecommender service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRecommender service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeRecommender">REST API Reference for DescribeRecommender Operation</seealso>
        public virtual Task<DescribeRecommenderResponse> DescribeRecommenderAsync(DescribeRecommenderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRecommenderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecommenderResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRecommenderResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSchema

        internal virtual DescribeSchemaResponse DescribeSchema(DescribeSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSchemaResponseUnmarshaller.Instance;

            return Invoke<DescribeSchemaResponse>(request, options);
        }



        /// <summary>
        /// Describes a schema. For more information on schemas, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSchema.html">CreateSchema</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSchema service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeSchema">REST API Reference for DescribeSchema Operation</seealso>
        public virtual Task<DescribeSchemaResponse> DescribeSchemaAsync(DescribeSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSchemaResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSolution

        internal virtual DescribeSolutionResponse DescribeSolution(DescribeSolutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSolutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSolutionResponseUnmarshaller.Instance;

            return Invoke<DescribeSolutionResponse>(request, options);
        }



        /// <summary>
        /// Describes a solution. For more information on solutions, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSolution.html">CreateSolution</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSolution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSolution service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeSolution">REST API Reference for DescribeSolution Operation</seealso>
        public virtual Task<DescribeSolutionResponse> DescribeSolutionAsync(DescribeSolutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSolutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSolutionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSolutionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSolutionVersion

        internal virtual DescribeSolutionVersionResponse DescribeSolutionVersion(DescribeSolutionVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSolutionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSolutionVersionResponseUnmarshaller.Instance;

            return Invoke<DescribeSolutionVersionResponse>(request, options);
        }



        /// <summary>
        /// Describes a specific version of a solution. For more information on solutions, see
        /// <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSolution.html">CreateSolution</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSolutionVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSolutionVersion service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeSolutionVersion">REST API Reference for DescribeSolutionVersion Operation</seealso>
        public virtual Task<DescribeSolutionVersionResponse> DescribeSolutionVersionAsync(DescribeSolutionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSolutionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSolutionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSolutionVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSolutionMetrics

        internal virtual GetSolutionMetricsResponse GetSolutionMetrics(GetSolutionMetricsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSolutionMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolutionMetricsResponseUnmarshaller.Instance;

            return Invoke<GetSolutionMetricsResponse>(request, options);
        }



        /// <summary>
        /// Gets the metrics for the specified solution version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSolutionMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSolutionMetrics service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/GetSolutionMetrics">REST API Reference for GetSolutionMetrics Operation</seealso>
        public virtual Task<GetSolutionMetricsResponse> GetSolutionMetricsAsync(GetSolutionMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSolutionMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolutionMetricsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSolutionMetricsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBatchInferenceJobs

        internal virtual ListBatchInferenceJobsResponse ListBatchInferenceJobs(ListBatchInferenceJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBatchInferenceJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBatchInferenceJobsResponseUnmarshaller.Instance;

            return Invoke<ListBatchInferenceJobsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of the batch inference jobs that have been performed off of a solution
        /// version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBatchInferenceJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBatchInferenceJobs service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListBatchInferenceJobs">REST API Reference for ListBatchInferenceJobs Operation</seealso>
        public virtual Task<ListBatchInferenceJobsResponse> ListBatchInferenceJobsAsync(ListBatchInferenceJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBatchInferenceJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBatchInferenceJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBatchInferenceJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBatchSegmentJobs

        internal virtual ListBatchSegmentJobsResponse ListBatchSegmentJobs(ListBatchSegmentJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBatchSegmentJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBatchSegmentJobsResponseUnmarshaller.Instance;

            return Invoke<ListBatchSegmentJobsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of the batch segment jobs that have been performed off of a solution version
        /// that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBatchSegmentJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBatchSegmentJobs service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListBatchSegmentJobs">REST API Reference for ListBatchSegmentJobs Operation</seealso>
        public virtual Task<ListBatchSegmentJobsResponse> ListBatchSegmentJobsAsync(ListBatchSegmentJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBatchSegmentJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBatchSegmentJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBatchSegmentJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCampaigns

        internal virtual ListCampaignsResponse ListCampaigns(ListCampaignsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCampaignsResponseUnmarshaller.Instance;

            return Invoke<ListCampaignsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of campaigns that use the given solution. When a solution is not specified,
        /// all the campaigns associated with the account are listed. The response provides the
        /// properties for each campaign, including the Amazon Resource Name (ARN). For more information
        /// on campaigns, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateCampaign.html">CreateCampaign</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCampaigns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCampaigns service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        public virtual Task<ListCampaignsResponse> ListCampaignsAsync(ListCampaignsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCampaignsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCampaignsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDataDeletionJobs

        internal virtual ListDataDeletionJobsResponse ListDataDeletionJobs(ListDataDeletionJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataDeletionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataDeletionJobsResponseUnmarshaller.Instance;

            return Invoke<ListDataDeletionJobsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of data deletion jobs for a dataset group ordered by creation time,
        /// with the most recent first. When a dataset group is not specified, all the data deletion
        /// jobs associated with the account are listed. The response provides the properties
        /// for each job, including the Amazon Resource Name (ARN). For more information on data
        /// deletion jobs, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/delete-records.html">Deleting
        /// users</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataDeletionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataDeletionJobs service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDataDeletionJobs">REST API Reference for ListDataDeletionJobs Operation</seealso>
        public virtual Task<ListDataDeletionJobsResponse> ListDataDeletionJobsAsync(ListDataDeletionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataDeletionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataDeletionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataDeletionJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDatasetExportJobs

        internal virtual ListDatasetExportJobsResponse ListDatasetExportJobs(ListDatasetExportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetExportJobsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetExportJobsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of dataset export jobs that use the given dataset. When a dataset is
        /// not specified, all the dataset export jobs associated with the account are listed.
        /// The response provides the properties for each dataset export job, including the Amazon
        /// Resource Name (ARN). For more information on dataset export jobs, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDatasetExportJob.html">CreateDatasetExportJob</a>.
        /// For more information on datasets, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDataset.html">CreateDataset</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetExportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasetExportJobs service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDatasetExportJobs">REST API Reference for ListDatasetExportJobs Operation</seealso>
        public virtual Task<ListDatasetExportJobsResponse> ListDatasetExportJobsAsync(ListDatasetExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetExportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetExportJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDatasetGroups

        internal virtual ListDatasetGroupsResponse ListDatasetGroups(ListDatasetGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetGroupsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetGroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of dataset groups. The response provides the properties for each dataset
        /// group, including the Amazon Resource Name (ARN). For more information on dataset groups,
        /// see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDatasetGroup.html">CreateDatasetGroup</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasetGroups service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDatasetGroups">REST API Reference for ListDatasetGroups Operation</seealso>
        public virtual Task<ListDatasetGroupsResponse> ListDatasetGroupsAsync(ListDatasetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDatasetImportJobs

        internal virtual ListDatasetImportJobsResponse ListDatasetImportJobs(ListDatasetImportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetImportJobsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of dataset import jobs that use the given dataset. When a dataset is
        /// not specified, all the dataset import jobs associated with the account are listed.
        /// The response provides the properties for each dataset import job, including the Amazon
        /// Resource Name (ARN). For more information on dataset import jobs, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDatasetImportJob.html">CreateDatasetImportJob</a>.
        /// For more information on datasets, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDataset.html">CreateDataset</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasetImportJobs service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDatasetImportJobs">REST API Reference for ListDatasetImportJobs Operation</seealso>
        public virtual Task<ListDatasetImportJobsResponse> ListDatasetImportJobsAsync(ListDatasetImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetImportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetImportJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDatasets

        internal virtual ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetsResponse>(request, options);
        }



        /// <summary>
        /// Returns the list of datasets contained in the given dataset group. The response provides
        /// the properties for each dataset, including the Amazon Resource Name (ARN). For more
        /// information on datasets, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDataset.html">CreateDataset</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEventTrackers

        internal virtual ListEventTrackersResponse ListEventTrackers(ListEventTrackersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventTrackersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventTrackersResponseUnmarshaller.Instance;

            return Invoke<ListEventTrackersResponse>(request, options);
        }



        /// <summary>
        /// Returns the list of event trackers associated with the account. The response provides
        /// the properties for each event tracker, including the Amazon Resource Name (ARN) and
        /// tracking ID. For more information on event trackers, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateEventTracker.html">CreateEventTracker</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventTrackers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventTrackers service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListEventTrackers">REST API Reference for ListEventTrackers Operation</seealso>
        public virtual Task<ListEventTrackersResponse> ListEventTrackersAsync(ListEventTrackersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventTrackersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventTrackersResponseUnmarshaller.Instance;

            return InvokeAsync<ListEventTrackersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFilters

        internal virtual ListFiltersResponse ListFilters(ListFiltersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFiltersResponseUnmarshaller.Instance;

            return Invoke<ListFiltersResponse>(request, options);
        }



        /// <summary>
        /// Lists all filters that belong to a given dataset group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFilters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFilters service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListFilters">REST API Reference for ListFilters Operation</seealso>
        public virtual Task<ListFiltersResponse> ListFiltersAsync(ListFiltersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFiltersResponseUnmarshaller.Instance;

            return InvokeAsync<ListFiltersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMetricAttributionMetrics

        internal virtual ListMetricAttributionMetricsResponse ListMetricAttributionMetrics(ListMetricAttributionMetricsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMetricAttributionMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMetricAttributionMetricsResponseUnmarshaller.Instance;

            return Invoke<ListMetricAttributionMetricsResponse>(request, options);
        }



        /// <summary>
        /// Lists the metrics for the metric attribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMetricAttributionMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMetricAttributionMetrics service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListMetricAttributionMetrics">REST API Reference for ListMetricAttributionMetrics Operation</seealso>
        public virtual Task<ListMetricAttributionMetricsResponse> ListMetricAttributionMetricsAsync(ListMetricAttributionMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMetricAttributionMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMetricAttributionMetricsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMetricAttributionMetricsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMetricAttributions

        internal virtual ListMetricAttributionsResponse ListMetricAttributions(ListMetricAttributionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMetricAttributionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMetricAttributionsResponseUnmarshaller.Instance;

            return Invoke<ListMetricAttributionsResponse>(request, options);
        }



        /// <summary>
        /// Lists metric attributions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMetricAttributions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMetricAttributions service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListMetricAttributions">REST API Reference for ListMetricAttributions Operation</seealso>
        public virtual Task<ListMetricAttributionsResponse> ListMetricAttributionsAsync(ListMetricAttributionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMetricAttributionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMetricAttributionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMetricAttributionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRecipes

        internal virtual ListRecipesResponse ListRecipes(ListRecipesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecipesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecipesResponseUnmarshaller.Instance;

            return Invoke<ListRecipesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of available recipes. The response provides the properties for each
        /// recipe, including the recipe's Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecipes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecipes service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListRecipes">REST API Reference for ListRecipes Operation</seealso>
        public virtual Task<ListRecipesResponse> ListRecipesAsync(ListRecipesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecipesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecipesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRecipesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRecommenders

        internal virtual ListRecommendersResponse ListRecommenders(ListRecommendersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendersResponseUnmarshaller.Instance;

            return Invoke<ListRecommendersResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of recommenders in a given Domain dataset group. When a Domain dataset
        /// group is not specified, all the recommenders associated with the account are listed.
        /// The response provides the properties for each recommender, including the Amazon Resource
        /// Name (ARN). For more information on recommenders, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateRecommender.html">CreateRecommender</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommenders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommenders service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListRecommenders">REST API Reference for ListRecommenders Operation</seealso>
        public virtual Task<ListRecommendersResponse> ListRecommendersAsync(ListRecommendersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendersResponseUnmarshaller.Instance;

            return InvokeAsync<ListRecommendersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSchemas

        internal virtual ListSchemasResponse ListSchemas(ListSchemasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemasResponseUnmarshaller.Instance;

            return Invoke<ListSchemasResponse>(request, options);
        }



        /// <summary>
        /// Returns the list of schemas associated with the account. The response provides the
        /// properties for each schema, including the Amazon Resource Name (ARN). For more information
        /// on schemas, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSchema.html">CreateSchema</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSchemas service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        public virtual Task<ListSchemasResponse> ListSchemasAsync(ListSchemasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemasResponseUnmarshaller.Instance;

            return InvokeAsync<ListSchemasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSolutions

        internal virtual ListSolutionsResponse ListSolutions(ListSolutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSolutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolutionsResponseUnmarshaller.Instance;

            return Invoke<ListSolutionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of solutions in a given dataset group. When a dataset group is not
        /// specified, all the solutions associated with the account are listed. The response
        /// provides the properties for each solution, including the Amazon Resource Name (ARN).
        /// For more information on solutions, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSolution.html">CreateSolution</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSolutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSolutions service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListSolutions">REST API Reference for ListSolutions Operation</seealso>
        public virtual Task<ListSolutionsResponse> ListSolutionsAsync(ListSolutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSolutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSolutionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSolutionVersions

        internal virtual ListSolutionVersionsResponse ListSolutionVersions(ListSolutionVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSolutionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolutionVersionsResponseUnmarshaller.Instance;

            return Invoke<ListSolutionVersionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of solution versions for the given solution. When a solution is not
        /// specified, all the solution versions associated with the account are listed. The response
        /// provides the properties for each solution version, including the Amazon Resource Name
        /// (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSolutionVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSolutionVersions service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListSolutionVersions">REST API Reference for ListSolutionVersions Operation</seealso>
        public virtual Task<ListSolutionVersionsResponse> ListSolutionVersionsAsync(ListSolutionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSolutionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolutionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSolutionVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Get a list of <a href="https://docs.aws.amazon.com/personalize/latest/dg/tagging-resources.html">tags</a>
        /// attached to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartRecommender

        internal virtual StartRecommenderResponse StartRecommender(StartRecommenderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartRecommenderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRecommenderResponseUnmarshaller.Instance;

            return Invoke<StartRecommenderResponse>(request, options);
        }



        /// <summary>
        /// Starts a recommender that is INACTIVE. Starting a recommender does not create any
        /// new models, but resumes billing and automatic retraining for the recommender.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRecommender service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartRecommender service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/StartRecommender">REST API Reference for StartRecommender Operation</seealso>
        public virtual Task<StartRecommenderResponse> StartRecommenderAsync(StartRecommenderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartRecommenderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRecommenderResponseUnmarshaller.Instance;

            return InvokeAsync<StartRecommenderResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopRecommender

        internal virtual StopRecommenderResponse StopRecommender(StopRecommenderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopRecommenderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopRecommenderResponseUnmarshaller.Instance;

            return Invoke<StopRecommenderResponse>(request, options);
        }



        /// <summary>
        /// Stops a recommender that is ACTIVE. Stopping a recommender halts billing and automatic
        /// retraining for the recommender.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopRecommender service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopRecommender service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/StopRecommender">REST API Reference for StopRecommender Operation</seealso>
        public virtual Task<StopRecommenderResponse> StopRecommenderAsync(StopRecommenderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopRecommenderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopRecommenderResponseUnmarshaller.Instance;

            return InvokeAsync<StopRecommenderResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopSolutionVersionCreation

        internal virtual StopSolutionVersionCreationResponse StopSolutionVersionCreation(StopSolutionVersionCreationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopSolutionVersionCreationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopSolutionVersionCreationResponseUnmarshaller.Instance;

            return Invoke<StopSolutionVersionCreationResponse>(request, options);
        }



        /// <summary>
        /// Stops creating a solution version that is in a state of CREATE_PENDING or CREATE IN_PROGRESS.
        /// 
        /// 
        ///  
        /// <para>
        /// Depending on the current state of the solution version, the solution version state
        /// changes as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATE_PENDING &gt; CREATE_STOPPED
        /// </para>
        ///  
        /// <para>
        /// or
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_IN_PROGRESS &gt; CREATE_STOPPING &gt; CREATE_STOPPED
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You are billed for all of the training completed up until you stop the solution version
        /// creation. You cannot resume creating a solution version once it has been stopped.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopSolutionVersionCreation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopSolutionVersionCreation service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/StopSolutionVersionCreation">REST API Reference for StopSolutionVersionCreation Operation</seealso>
        public virtual Task<StopSolutionVersionCreationResponse> StopSolutionVersionCreationAsync(StopSolutionVersionCreationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopSolutionVersionCreationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopSolutionVersionCreationResponseUnmarshaller.Instance;

            return InvokeAsync<StopSolutionVersionCreationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Add a list of tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.TooManyTagsException">
        /// You have exceeded the maximum number of tags you can apply to this resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified tags that are attached to a resource. For more information,
        /// see <a href="https://docs.aws.amazon.com/personalize/latest/dg/tags-remove.html">Removing
        /// tags from Amazon Personalize resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.TooManyTagKeysException">
        /// The request contains more tag keys than can be associated with a resource (50 tag
        /// keys per resource).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateCampaign

        internal virtual UpdateCampaignResponse UpdateCampaign(UpdateCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignResponseUnmarshaller.Instance;

            return Invoke<UpdateCampaignResponse>(request, options);
        }



        /// <summary>
        /// Updates a campaign to deploy a retrained solution version with an existing campaign,
        /// change your campaign's <c>minProvisionedTPS</c>, or modify your campaign's configuration.
        /// For example, you can set <c>enableMetadataWithRecommendations</c> to true for an existing
        /// campaign.
        /// 
        ///  
        /// <para>
        ///  To update a campaign to start automatically using the latest solution version, specify
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For the <c>SolutionVersionArn</c> parameter, specify the Amazon Resource Name (ARN)
        /// of your solution in <c>SolutionArn/$LATEST</c> format. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  In the <c>campaignConfig</c>, set <c>syncWithLatestSolutionVersion</c> to <c>true</c>.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To update a campaign, the campaign status must be ACTIVE or CREATE FAILED. Check the
        /// campaign status using the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeCampaign.html">DescribeCampaign</a>
        /// operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can still get recommendations from a campaign while an update is in progress.
        /// The campaign will use the previous solution version and campaign configuration to
        /// generate recommendations until the latest campaign update status is <c>Active</c>.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about updating a campaign, including code samples, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/update-campaigns.html">Updating
        /// a campaign</a>. For more information about campaigns, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/campaigns.html">Creating
        /// a campaign</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCampaign service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/UpdateCampaign">REST API Reference for UpdateCampaign Operation</seealso>
        public virtual Task<UpdateCampaignResponse> UpdateCampaignAsync(UpdateCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCampaignResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDataset

        internal virtual UpdateDatasetResponse UpdateDataset(UpdateDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetResponseUnmarshaller.Instance;

            return Invoke<UpdateDatasetResponse>(request, options);
        }



        /// <summary>
        /// Update a dataset to replace its schema with a new or existing one. For more information,
        /// see <a href="https://docs.aws.amazon.com/personalize/latest/dg/updating-dataset-schema.html">Replacing
        /// a dataset's schema</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataset service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        public virtual Task<UpdateDatasetResponse> UpdateDatasetAsync(UpdateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDatasetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateMetricAttribution

        internal virtual UpdateMetricAttributionResponse UpdateMetricAttribution(UpdateMetricAttributionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMetricAttributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMetricAttributionResponseUnmarshaller.Instance;

            return Invoke<UpdateMetricAttributionResponse>(request, options);
        }



        /// <summary>
        /// Updates a metric attribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMetricAttribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMetricAttribution service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/UpdateMetricAttribution">REST API Reference for UpdateMetricAttribution Operation</seealso>
        public virtual Task<UpdateMetricAttributionResponse> UpdateMetricAttributionAsync(UpdateMetricAttributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMetricAttributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMetricAttributionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMetricAttributionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRecommender

        internal virtual UpdateRecommenderResponse UpdateRecommender(UpdateRecommenderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRecommenderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecommenderResponseUnmarshaller.Instance;

            return Invoke<UpdateRecommenderResponse>(request, options);
        }



        /// <summary>
        /// Updates the recommender to modify the recommender configuration. If you update the
        /// recommender to modify the columns used in training, Amazon Personalize automatically
        /// starts a full retraining of the models backing your recommender. While the update
        /// completes, you can still get recommendations from the recommender. The recommender
        /// uses the previous configuration until the update completes. To track the status of
        /// this update, use the <c>latestRecommenderUpdate</c> returned in the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeRecommender.html">DescribeRecommender</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecommender service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRecommender service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/UpdateRecommender">REST API Reference for UpdateRecommender Operation</seealso>
        public virtual Task<UpdateRecommenderResponse> UpdateRecommenderAsync(UpdateRecommenderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRecommenderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecommenderResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRecommenderResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSolution

        internal virtual UpdateSolutionResponse UpdateSolution(UpdateSolutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSolutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSolutionResponseUnmarshaller.Instance;

            return Invoke<UpdateSolutionResponse>(request, options);
        }



        /// <summary>
        /// Updates an Amazon Personalize solution to use a different automatic training configuration.
        /// When you update a solution, you can change whether the solution uses automatic training,
        /// and you can change the training frequency. For more information about updating a solution,
        /// see <a href="https://docs.aws.amazon.com/personalize/latest/dg/updating-solution.html">Updating
        /// a solution</a>.
        /// 
        ///  
        /// <para>
        /// A solution update can be in one of the following states:
        /// </para>
        ///  
        /// <para>
        /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
        /// </para>
        ///  
        /// <para>
        /// To get the status of a solution update, call the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeSolution.html">DescribeSolution</a>
        /// API operation and find the status in the <c>latestSolutionUpdate</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSolution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSolution service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/UpdateSolution">REST API Reference for UpdateSolution Operation</seealso>
        public virtual Task<UpdateSolutionResponse> UpdateSolutionAsync(UpdateSolutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSolutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSolutionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSolutionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}