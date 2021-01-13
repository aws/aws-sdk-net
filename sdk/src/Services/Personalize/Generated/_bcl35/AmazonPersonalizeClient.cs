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
using System.Collections.Generic;
using System.Net;

using Amazon.Personalize.Model;
using Amazon.Personalize.Model.Internal.MarshallTransformations;
using Amazon.Personalize.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Personalize
{
    /// <summary>
    /// Implementation for accessing Personalize
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPersonalizeConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPersonalizeConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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

        /// <summary>
        /// Creates a batch inference job. The operation can handle up to 50 million records and
        /// the input file must be in JSON format. For more information, see <a>recommendations-batch</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchInferenceJob service method.</param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateBatchInferenceJob">REST API Reference for CreateBatchInferenceJob Operation</seealso>
        public virtual CreateBatchInferenceJobResponse CreateBatchInferenceJob(CreateBatchInferenceJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBatchInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBatchInferenceJobResponseUnmarshaller.Instance;

            return Invoke<CreateBatchInferenceJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBatchInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchInferenceJob operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBatchInferenceJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateBatchInferenceJob">REST API Reference for CreateBatchInferenceJob Operation</seealso>
        public virtual IAsyncResult BeginCreateBatchInferenceJob(CreateBatchInferenceJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBatchInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBatchInferenceJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBatchInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBatchInferenceJob.</param>
        /// 
        /// <returns>Returns a  CreateBatchInferenceJobResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateBatchInferenceJob">REST API Reference for CreateBatchInferenceJob Operation</seealso>
        public virtual CreateBatchInferenceJobResponse EndCreateBatchInferenceJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBatchInferenceJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCampaign

        /// <summary>
        /// Creates a campaign by deploying a solution version. When a client calls the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetRecommendations.html">GetRecommendations</a>
        /// and <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetPersonalizedRanking.html">GetPersonalizedRanking</a>
        /// APIs, a campaign is specified in the request.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum Provisioned TPS and Auto-Scaling</b> 
        /// </para>
        ///  
        /// <para>
        /// A transaction is a single <code>GetRecommendations</code> or <code>GetPersonalizedRanking</code>
        /// call. Transactions per second (TPS) is the throughput and unit of billing for Amazon
        /// Personalize. The minimum provisioned TPS (<code>minProvisionedTPS</code>) specifies
        /// the baseline throughput provisioned by Amazon Personalize, and thus, the minimum billing
        /// charge. 
        /// </para>
        ///  
        /// <para>
        ///  If your TPS increases beyond <code>minProvisionedTPS</code>, Amazon Personalize auto-scales
        /// the provisioned capacity up and down, but never below <code>minProvisionedTPS</code>.
        /// There's a short time delay while the capacity is increased that might cause loss of
        /// transactions.
        /// </para>
        ///  
        /// <para>
        /// The actual TPS used is calculated as the average requests/second within a 5-minute
        /// window. You pay for maximum of either the minimum provisioned TPS or the actual TPS.
        /// We recommend starting with a low <code>minProvisionedTPS</code>, track your usage
        /// using Amazon CloudWatch metrics, and then increase the <code>minProvisionedTPS</code>
        /// as necessary.
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
        /// To get the campaign status, call <a>DescribeCampaign</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Wait until the <code>status</code> of the campaign is <code>ACTIVE</code> before asking
        /// the campaign for recommendations.
        /// </para>
        ///  </note> <p class="title"> <b>Related APIs</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListCampaigns</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeCampaign</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateCampaign</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteCampaign</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign service method.</param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        public virtual CreateCampaignResponse CreateCampaign(CreateCampaignRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return Invoke<CreateCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        public virtual IAsyncResult BeginCreateCampaign(CreateCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCampaign.</param>
        /// 
        /// <returns>Returns a  CreateCampaignResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        public virtual CreateCampaignResponse EndCreateCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCampaignResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataset

        /// <summary>
        /// Creates an empty dataset and adds it to the specified dataset group. Use <a>CreateDatasetImportJob</a>
        /// to import your training data to a dataset.
        /// 
        ///  
        /// <para>
        /// There are three types of datasets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Interactions
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Items
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Users
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Each dataset type has an associated schema with required field types. Only the <code>Interactions</code>
        /// dataset is required in order to train a model (also referred to as creating a solution).
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
        /// To get the status of the dataset, call <a>DescribeDataset</a>.
        /// </para>
        ///  <p class="title"> <b>Related APIs</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateDatasetGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListDatasets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeDataset</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteDataset</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual CreateDatasetResponse CreateDataset(CreateDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual IAsyncResult BeginCreateDataset(CreateDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataset.</param>
        /// 
        /// <returns>Returns a  CreateDatasetResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual CreateDatasetResponse EndCreateDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDatasetGroup

        /// <summary>
        /// Creates an empty dataset group. A dataset group contains related datasets that supply
        /// data for training a model. A dataset group can contain at most three datasets, one
        /// for each type of dataset:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Interactions
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Items
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Users
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To train a model (create a solution), a dataset group that contains an <code>Interactions</code>
        /// dataset is required. Call <a>CreateDataset</a> to add a dataset to the group.
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
        /// To get the status of the dataset group, call <a>DescribeDatasetGroup</a>. If the status
        /// shows as CREATE FAILED, the response includes a <code>failureReason</code> key, which
        /// describes why the creation failed.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must wait until the <code>status</code> of the dataset group is <code>ACTIVE</code>
        /// before adding a dataset to the group.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can specify an AWS Key Management Service (KMS) key to encrypt the datasets in
        /// the group. If you specify a KMS key, you must also include an AWS Identity and Access
        /// Management (IAM) role that has permission to access the key.
        /// </para>
        ///  <p class="title"> <b>APIs that require a dataset group ARN in the request</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateDataset</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateEventTracker</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateSolution</a> 
        /// </para>
        ///  </li> </ul> <p class="title"> <b>Related APIs</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListDatasetGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeDatasetGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteDatasetGroup</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetGroup service method.</param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateDatasetGroup">REST API Reference for CreateDatasetGroup Operation</seealso>
        public virtual CreateDatasetGroupResponse CreateDatasetGroup(CreateDatasetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetGroup operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDatasetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateDatasetGroup">REST API Reference for CreateDatasetGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateDatasetGroup(CreateDatasetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatasetGroup.</param>
        /// 
        /// <returns>Returns a  CreateDatasetGroupResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateDatasetGroup">REST API Reference for CreateDatasetGroup Operation</seealso>
        public virtual CreateDatasetGroupResponse EndCreateDatasetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDatasetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDatasetImportJob

        /// <summary>
        /// Creates a job that imports training data from your data source (an Amazon S3 bucket)
        /// to an Amazon Personalize dataset. To allow Amazon Personalize to import the training
        /// data, you must specify an AWS Identity and Access Management (IAM) role that has permission
        /// to read from the data source, as Amazon Personalize makes a copy of your data and
        /// processes it in an internal AWS system.
        /// 
        ///  <important> 
        /// <para>
        /// The dataset import job replaces any existing data in the dataset that you imported
        /// in bulk.
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
        /// To get the status of the import job, call <a>DescribeDatasetImportJob</a>, providing
        /// the Amazon Resource Name (ARN) of the dataset import job. The dataset import is complete
        /// when the status shows as ACTIVE. If the status shows as CREATE FAILED, the response
        /// includes a <code>failureReason</code> key, which describes why the job failed.
        /// </para>
        ///  <note> 
        /// <para>
        /// Importing takes time. You must wait until the status shows as ACTIVE before training
        /// a model using the dataset.
        /// </para>
        ///  </note> <p class="title"> <b>Related APIs</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListDatasetImportJobs</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeDatasetImportJob</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetImportJob service method.</param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateDatasetImportJob">REST API Reference for CreateDatasetImportJob Operation</seealso>
        public virtual CreateDatasetImportJobResponse CreateDatasetImportJob(CreateDatasetImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetImportJob operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDatasetImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateDatasetImportJob">REST API Reference for CreateDatasetImportJob Operation</seealso>
        public virtual IAsyncResult BeginCreateDatasetImportJob(CreateDatasetImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatasetImportJob.</param>
        /// 
        /// <returns>Returns a  CreateDatasetImportJobResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateDatasetImportJob">REST API Reference for CreateDatasetImportJob Operation</seealso>
        public virtual CreateDatasetImportJobResponse EndCreateDatasetImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDatasetImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEventTracker

        /// <summary>
        /// Creates an event tracker that you use when adding event data to a specified dataset
        /// group using the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_UBS_PutEvents.html">PutEvents</a>
        /// API.
        /// 
        ///  <note> 
        /// <para>
        /// Only one event tracker can be associated with a dataset group. You will get an error
        /// if you call <code>CreateEventTracker</code> using the same dataset group as an existing
        /// event tracker.
        /// </para>
        ///  </note> 
        /// <para>
        /// When you create an event tracker, the response includes a tracking ID, which you pass
        /// as a parameter when you use the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_UBS_PutEvents.html">PutEvents</a>
        /// operation. Amazon Personalize then appends the event data to the Interactions dataset
        /// of the dataset group you specify in your event tracker. 
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
        /// To get the status of the event tracker, call <a>DescribeEventTracker</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The event tracker must be in the ACTIVE state before using the tracking ID.
        /// </para>
        ///  </note> <p class="title"> <b>Related APIs</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListEventTrackers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEventTracker</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteEventTracker</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventTracker service method.</param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateEventTracker">REST API Reference for CreateEventTracker Operation</seealso>
        public virtual CreateEventTrackerResponse CreateEventTracker(CreateEventTrackerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventTrackerResponseUnmarshaller.Instance;

            return Invoke<CreateEventTrackerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventTracker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventTracker operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventTracker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateEventTracker">REST API Reference for CreateEventTracker Operation</seealso>
        public virtual IAsyncResult BeginCreateEventTracker(CreateEventTrackerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventTrackerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventTracker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventTracker.</param>
        /// 
        /// <returns>Returns a  CreateEventTrackerResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateEventTracker">REST API Reference for CreateEventTracker Operation</seealso>
        public virtual CreateEventTrackerResponse EndCreateEventTracker(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEventTrackerResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFilter

        /// <summary>
        /// Creates a recommendation filter. For more information, see <a>filter</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFilter service method.</param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        public virtual CreateFilterResponse CreateFilter(CreateFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFilterResponseUnmarshaller.Instance;

            return Invoke<CreateFilterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFilter operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        public virtual IAsyncResult BeginCreateFilter(CreateFilterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFilterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFilter.</param>
        /// 
        /// <returns>Returns a  CreateFilterResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        public virtual CreateFilterResponse EndCreateFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFilterResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSchema

        /// <summary>
        /// Creates an Amazon Personalize schema from the specified schema string. The schema
        /// you create must be in Avro JSON format.
        /// 
        ///  
        /// <para>
        /// Amazon Personalize recognizes three schema variants. Each schema is associated with
        /// a dataset type and has a set of required field and keywords. You specify a schema
        /// when you call <a>CreateDataset</a>.
        /// </para>
        ///  <p class="title"> <b>Related APIs</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListSchemas</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeSchema</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteSchema</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchema service method.</param>
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
        public virtual CreateSchemaResponse CreateSchema(CreateSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return Invoke<CreateSchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSchema operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        public virtual IAsyncResult BeginCreateSchema(CreateSchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSchema.</param>
        /// 
        /// <returns>Returns a  CreateSchemaResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        public virtual CreateSchemaResponse EndCreateSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSchemaResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSolution

        /// <summary>
        /// Creates the configuration for training a model. A trained model is known as a solution.
        /// After the configuration is created, you train the model (create a solution) by calling
        /// the <a>CreateSolutionVersion</a> operation. Every time you call <code>CreateSolutionVersion</code>,
        /// a new version of the solution is created.
        /// 
        ///  
        /// <para>
        /// After creating a solution version, you check its accuracy by calling <a>GetSolutionMetrics</a>.
        /// When you are satisfied with the version, you deploy it using <a>CreateCampaign</a>.
        /// The campaign provides recommendations to a client through the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetRecommendations.html">GetRecommendations</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// To train a model, Amazon Personalize requires training data and a recipe. The training
        /// data comes from the dataset group that you provide in the request. A recipe specifies
        /// the training algorithm and a feature transformation. You can specify one of the predefined
        /// recipes provided by Amazon Personalize. Alternatively, you can specify <code>performAutoML</code>
        /// and Amazon Personalize will analyze your data and select the optimum USER_PERSONALIZATION
        /// recipe for you.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Personalize doesn't support configuring the <code>hpoObjective</code> for solution
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
        /// To get the status of the solution, call <a>DescribeSolution</a>. Wait until the status
        /// shows as ACTIVE before calling <code>CreateSolutionVersion</code>.
        /// </para>
        ///  <p class="title"> <b>Related APIs</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListSolutions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateSolutionVersion</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeSolution</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteSolution</a> 
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        ///  <a>ListSolutionVersions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeSolutionVersion</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSolution service method.</param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateSolution">REST API Reference for CreateSolution Operation</seealso>
        public virtual CreateSolutionResponse CreateSolution(CreateSolutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSolutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSolutionResponseUnmarshaller.Instance;

            return Invoke<CreateSolutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSolution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSolution operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSolution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateSolution">REST API Reference for CreateSolution Operation</seealso>
        public virtual IAsyncResult BeginCreateSolution(CreateSolutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSolutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSolutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSolution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSolution.</param>
        /// 
        /// <returns>Returns a  CreateSolutionResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateSolution">REST API Reference for CreateSolution Operation</seealso>
        public virtual CreateSolutionResponse EndCreateSolution(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSolutionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSolutionVersion

        /// <summary>
        /// Trains or retrains an active solution. A solution is created using the <a>CreateSolution</a>
        /// operation and must be in the ACTIVE state before calling <code>CreateSolutionVersion</code>.
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
        /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the status of the version, call <a>DescribeSolutionVersion</a>. Wait until
        /// the status shows as ACTIVE before calling <code>CreateCampaign</code>.
        /// </para>
        ///  
        /// <para>
        /// If the status shows as CREATE FAILED, the response includes a <code>failureReason</code>
        /// key, which describes why the job failed.
        /// </para>
        ///  <p class="title"> <b>Related APIs</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListSolutionVersions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeSolutionVersion</a> 
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        ///  <a>ListSolutions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateSolution</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeSolution</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteSolution</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSolutionVersion service method.</param>
        /// 
        /// <returns>The response from the CreateSolutionVersion service method, as returned by Personalize.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateSolutionVersion">REST API Reference for CreateSolutionVersion Operation</seealso>
        public virtual CreateSolutionVersionResponse CreateSolutionVersion(CreateSolutionVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSolutionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSolutionVersionResponseUnmarshaller.Instance;

            return Invoke<CreateSolutionVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSolutionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSolutionVersion operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSolutionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateSolutionVersion">REST API Reference for CreateSolutionVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateSolutionVersion(CreateSolutionVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSolutionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSolutionVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSolutionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSolutionVersion.</param>
        /// 
        /// <returns>Returns a  CreateSolutionVersionResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateSolutionVersion">REST API Reference for CreateSolutionVersion Operation</seealso>
        public virtual CreateSolutionVersionResponse EndCreateSolutionVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSolutionVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCampaign

        /// <summary>
        /// Removes a campaign by deleting the solution deployment. The solution that the campaign
        /// is based on is not deleted and can be redeployed when needed. A deleted campaign can
        /// no longer be specified in a <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetRecommendations.html">GetRecommendations</a>
        /// request. For more information on campaigns, see <a>CreateCampaign</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign service method.</param>
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
        public virtual DeleteCampaignResponse DeleteCampaign(DeleteCampaignRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return Invoke<DeleteCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        public virtual IAsyncResult BeginDeleteCampaign(DeleteCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCampaign.</param>
        /// 
        /// <returns>Returns a  DeleteCampaignResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        public virtual DeleteCampaignResponse EndDeleteCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCampaignResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataset

        /// <summary>
        /// Deletes a dataset. You can't delete a dataset if an associated <code>DatasetImportJob</code>
        /// or <code>SolutionVersion</code> is in the CREATE PENDING or IN PROGRESS state. For
        /// more information on datasets, see <a>CreateDataset</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
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
        public virtual DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataset(DeleteDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataset.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual DeleteDatasetResponse EndDeleteDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDatasetGroup

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
        public virtual DeleteDatasetGroupResponse DeleteDatasetGroup(DeleteDatasetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetGroup operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDatasetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteDatasetGroup">REST API Reference for DeleteDatasetGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteDatasetGroup(DeleteDatasetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDatasetGroup.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetGroupResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteDatasetGroup">REST API Reference for DeleteDatasetGroup Operation</seealso>
        public virtual DeleteDatasetGroupResponse EndDeleteDatasetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDatasetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEventTracker

        /// <summary>
        /// Deletes the event tracker. Does not delete the event-interactions dataset from the
        /// associated dataset group. For more information on event trackers, see <a>CreateEventTracker</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventTracker service method.</param>
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
        public virtual DeleteEventTrackerResponse DeleteEventTracker(DeleteEventTrackerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventTrackerResponseUnmarshaller.Instance;

            return Invoke<DeleteEventTrackerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventTracker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventTracker operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventTracker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteEventTracker">REST API Reference for DeleteEventTracker Operation</seealso>
        public virtual IAsyncResult BeginDeleteEventTracker(DeleteEventTrackerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventTrackerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventTracker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventTracker.</param>
        /// 
        /// <returns>Returns a  DeleteEventTrackerResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteEventTracker">REST API Reference for DeleteEventTracker Operation</seealso>
        public virtual DeleteEventTrackerResponse EndDeleteEventTracker(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEventTrackerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFilter

        /// <summary>
        /// Deletes a filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFilter service method.</param>
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
        public virtual DeleteFilterResponse DeleteFilter(DeleteFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFilterResponseUnmarshaller.Instance;

            return Invoke<DeleteFilterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFilter operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteFilter">REST API Reference for DeleteFilter Operation</seealso>
        public virtual IAsyncResult BeginDeleteFilter(DeleteFilterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFilterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFilter.</param>
        /// 
        /// <returns>Returns a  DeleteFilterResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteFilter">REST API Reference for DeleteFilter Operation</seealso>
        public virtual DeleteFilterResponse EndDeleteFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFilterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSchema

        /// <summary>
        /// Deletes a schema. Before deleting a schema, you must delete all datasets referencing
        /// the schema. For more information on schemas, see <a>CreateSchema</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchema service method.</param>
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
        public virtual DeleteSchemaResponse DeleteSchema(DeleteSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return Invoke<DeleteSchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchema operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        public virtual IAsyncResult BeginDeleteSchema(DeleteSchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSchema.</param>
        /// 
        /// <returns>Returns a  DeleteSchemaResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        public virtual DeleteSchemaResponse EndDeleteSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSchemaResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSolution

        /// <summary>
        /// Deletes all versions of a solution and the <code>Solution</code> object itself. Before
        /// deleting a solution, you must delete all campaigns based on the solution. To determine
        /// what campaigns are using the solution, call <a>ListCampaigns</a> and supply the Amazon
        /// Resource Name (ARN) of the solution. You can't delete a solution if an associated
        /// <code>SolutionVersion</code> is in the CREATE PENDING or IN PROGRESS state. For more
        /// information on solutions, see <a>CreateSolution</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSolution service method.</param>
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
        public virtual DeleteSolutionResponse DeleteSolution(DeleteSolutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSolutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSolutionResponseUnmarshaller.Instance;

            return Invoke<DeleteSolutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSolution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSolution operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSolution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteSolution">REST API Reference for DeleteSolution Operation</seealso>
        public virtual IAsyncResult BeginDeleteSolution(DeleteSolutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSolutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSolutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSolution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSolution.</param>
        /// 
        /// <returns>Returns a  DeleteSolutionResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteSolution">REST API Reference for DeleteSolution Operation</seealso>
        public virtual DeleteSolutionResponse EndDeleteSolution(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSolutionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAlgorithm

        /// <summary>
        /// Describes the given algorithm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlgorithm service method.</param>
        /// 
        /// <returns>The response from the DescribeAlgorithm service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeAlgorithm">REST API Reference for DescribeAlgorithm Operation</seealso>
        public virtual DescribeAlgorithmResponse DescribeAlgorithm(DescribeAlgorithmRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlgorithmResponseUnmarshaller.Instance;

            return Invoke<DescribeAlgorithmResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlgorithm operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlgorithm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeAlgorithm">REST API Reference for DescribeAlgorithm Operation</seealso>
        public virtual IAsyncResult BeginDescribeAlgorithm(DescribeAlgorithmRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlgorithmResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlgorithm.</param>
        /// 
        /// <returns>Returns a  DescribeAlgorithmResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeAlgorithm">REST API Reference for DescribeAlgorithm Operation</seealso>
        public virtual DescribeAlgorithmResponse EndDescribeAlgorithm(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAlgorithmResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeBatchInferenceJob

        /// <summary>
        /// Gets the properties of a batch inference job including name, Amazon Resource Name
        /// (ARN), status, input and output configurations, and the ARN of the solution version
        /// used to generate the recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBatchInferenceJob service method.</param>
        /// 
        /// <returns>The response from the DescribeBatchInferenceJob service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeBatchInferenceJob">REST API Reference for DescribeBatchInferenceJob Operation</seealso>
        public virtual DescribeBatchInferenceJobResponse DescribeBatchInferenceJob(DescribeBatchInferenceJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBatchInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBatchInferenceJobResponseUnmarshaller.Instance;

            return Invoke<DescribeBatchInferenceJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBatchInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBatchInferenceJob operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBatchInferenceJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeBatchInferenceJob">REST API Reference for DescribeBatchInferenceJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeBatchInferenceJob(DescribeBatchInferenceJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBatchInferenceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBatchInferenceJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBatchInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBatchInferenceJob.</param>
        /// 
        /// <returns>Returns a  DescribeBatchInferenceJobResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeBatchInferenceJob">REST API Reference for DescribeBatchInferenceJob Operation</seealso>
        public virtual DescribeBatchInferenceJobResponse EndDescribeBatchInferenceJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBatchInferenceJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCampaign

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
        /// When the <code>status</code> is <code>CREATE FAILED</code>, the response includes
        /// the <code>failureReason</code> key, which describes why.
        /// </para>
        ///  
        /// <para>
        /// For more information on campaigns, see <a>CreateCampaign</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCampaign service method.</param>
        /// 
        /// <returns>The response from the DescribeCampaign service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeCampaign">REST API Reference for DescribeCampaign Operation</seealso>
        public virtual DescribeCampaignResponse DescribeCampaign(DescribeCampaignRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCampaignResponseUnmarshaller.Instance;

            return Invoke<DescribeCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCampaign operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeCampaign">REST API Reference for DescribeCampaign Operation</seealso>
        public virtual IAsyncResult BeginDescribeCampaign(DescribeCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCampaign.</param>
        /// 
        /// <returns>Returns a  DescribeCampaignResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeCampaign">REST API Reference for DescribeCampaign Operation</seealso>
        public virtual DescribeCampaignResponse EndDescribeCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCampaignResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDataset

        /// <summary>
        /// Describes the given dataset. For more information on datasets, see <a>CreateDataset</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual IAsyncResult BeginDescribeDataset(DescribeDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataset.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual DescribeDatasetResponse EndDescribeDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDatasetGroup

        /// <summary>
        /// Describes the given dataset group. For more information on dataset groups, see <a>CreateDatasetGroup</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeDatasetGroup service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDatasetGroup">REST API Reference for DescribeDatasetGroup Operation</seealso>
        public virtual DescribeDatasetGroupResponse DescribeDatasetGroup(DescribeDatasetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetGroup operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDatasetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDatasetGroup">REST API Reference for DescribeDatasetGroup Operation</seealso>
        public virtual IAsyncResult BeginDescribeDatasetGroup(DescribeDatasetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDatasetGroup.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetGroupResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDatasetGroup">REST API Reference for DescribeDatasetGroup Operation</seealso>
        public virtual DescribeDatasetGroupResponse EndDescribeDatasetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDatasetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDatasetImportJob

        /// <summary>
        /// Describes the dataset import job created by <a>CreateDatasetImportJob</a>, including
        /// the import job status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetImportJob service method.</param>
        /// 
        /// <returns>The response from the DescribeDatasetImportJob service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDatasetImportJob">REST API Reference for DescribeDatasetImportJob Operation</seealso>
        public virtual DescribeDatasetImportJobResponse DescribeDatasetImportJob(DescribeDatasetImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetImportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetImportJob operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDatasetImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDatasetImportJob">REST API Reference for DescribeDatasetImportJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeDatasetImportJob(DescribeDatasetImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDatasetImportJob.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetImportJobResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDatasetImportJob">REST API Reference for DescribeDatasetImportJob Operation</seealso>
        public virtual DescribeDatasetImportJobResponse EndDescribeDatasetImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDatasetImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEventTracker

        /// <summary>
        /// Describes an event tracker. The response includes the <code>trackingId</code> and
        /// <code>status</code> of the event tracker. For more information on event trackers,
        /// see <a>CreateEventTracker</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventTracker service method.</param>
        /// 
        /// <returns>The response from the DescribeEventTracker service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeEventTracker">REST API Reference for DescribeEventTracker Operation</seealso>
        public virtual DescribeEventTrackerResponse DescribeEventTracker(DescribeEventTrackerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventTrackerResponseUnmarshaller.Instance;

            return Invoke<DescribeEventTrackerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventTracker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventTracker operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventTracker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeEventTracker">REST API Reference for DescribeEventTracker Operation</seealso>
        public virtual IAsyncResult BeginDescribeEventTracker(DescribeEventTrackerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventTrackerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventTrackerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventTracker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventTracker.</param>
        /// 
        /// <returns>Returns a  DescribeEventTrackerResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeEventTracker">REST API Reference for DescribeEventTracker Operation</seealso>
        public virtual DescribeEventTrackerResponse EndDescribeEventTracker(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventTrackerResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFeatureTransformation

        /// <summary>
        /// Describes the given feature transformation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFeatureTransformation service method.</param>
        /// 
        /// <returns>The response from the DescribeFeatureTransformation service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeFeatureTransformation">REST API Reference for DescribeFeatureTransformation Operation</seealso>
        public virtual DescribeFeatureTransformationResponse DescribeFeatureTransformation(DescribeFeatureTransformationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFeatureTransformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFeatureTransformationResponseUnmarshaller.Instance;

            return Invoke<DescribeFeatureTransformationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFeatureTransformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFeatureTransformation operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFeatureTransformation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeFeatureTransformation">REST API Reference for DescribeFeatureTransformation Operation</seealso>
        public virtual IAsyncResult BeginDescribeFeatureTransformation(DescribeFeatureTransformationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFeatureTransformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFeatureTransformationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFeatureTransformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFeatureTransformation.</param>
        /// 
        /// <returns>Returns a  DescribeFeatureTransformationResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeFeatureTransformation">REST API Reference for DescribeFeatureTransformation Operation</seealso>
        public virtual DescribeFeatureTransformationResponse EndDescribeFeatureTransformation(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFeatureTransformationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFilter

        /// <summary>
        /// Describes a filter's properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFilter service method.</param>
        /// 
        /// <returns>The response from the DescribeFilter service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeFilter">REST API Reference for DescribeFilter Operation</seealso>
        public virtual DescribeFilterResponse DescribeFilter(DescribeFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFilterResponseUnmarshaller.Instance;

            return Invoke<DescribeFilterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFilter operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeFilter">REST API Reference for DescribeFilter Operation</seealso>
        public virtual IAsyncResult BeginDescribeFilter(DescribeFilterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFilterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFilter.</param>
        /// 
        /// <returns>Returns a  DescribeFilterResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeFilter">REST API Reference for DescribeFilter Operation</seealso>
        public virtual DescribeFilterResponse EndDescribeFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFilterResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRecipe

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
        /// you create a solution with the <a>CreateSolution</a> API. <code>CreateSolution</code>
        /// trains a model by using the algorithm in the specified recipe and a training dataset.
        /// The solution, when deployed as a campaign, can provide recommendations using the <a
        /// href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetRecommendations.html">GetRecommendations</a>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecipe service method.</param>
        /// 
        /// <returns>The response from the DescribeRecipe service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeRecipe">REST API Reference for DescribeRecipe Operation</seealso>
        public virtual DescribeRecipeResponse DescribeRecipe(DescribeRecipeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecipeResponseUnmarshaller.Instance;

            return Invoke<DescribeRecipeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRecipe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecipe operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRecipe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeRecipe">REST API Reference for DescribeRecipe Operation</seealso>
        public virtual IAsyncResult BeginDescribeRecipe(DescribeRecipeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecipeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRecipe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRecipe.</param>
        /// 
        /// <returns>Returns a  DescribeRecipeResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeRecipe">REST API Reference for DescribeRecipe Operation</seealso>
        public virtual DescribeRecipeResponse EndDescribeRecipe(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRecipeResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSchema

        /// <summary>
        /// Describes a schema. For more information on schemas, see <a>CreateSchema</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchema service method.</param>
        /// 
        /// <returns>The response from the DescribeSchema service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeSchema">REST API Reference for DescribeSchema Operation</seealso>
        public virtual DescribeSchemaResponse DescribeSchema(DescribeSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSchemaResponseUnmarshaller.Instance;

            return Invoke<DescribeSchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchema operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeSchema">REST API Reference for DescribeSchema Operation</seealso>
        public virtual IAsyncResult BeginDescribeSchema(DescribeSchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSchema.</param>
        /// 
        /// <returns>Returns a  DescribeSchemaResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeSchema">REST API Reference for DescribeSchema Operation</seealso>
        public virtual DescribeSchemaResponse EndDescribeSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSchemaResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSolution

        /// <summary>
        /// Describes a solution. For more information on solutions, see <a>CreateSolution</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSolution service method.</param>
        /// 
        /// <returns>The response from the DescribeSolution service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeSolution">REST API Reference for DescribeSolution Operation</seealso>
        public virtual DescribeSolutionResponse DescribeSolution(DescribeSolutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSolutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSolutionResponseUnmarshaller.Instance;

            return Invoke<DescribeSolutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSolution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSolution operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSolution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeSolution">REST API Reference for DescribeSolution Operation</seealso>
        public virtual IAsyncResult BeginDescribeSolution(DescribeSolutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSolutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSolutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSolution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSolution.</param>
        /// 
        /// <returns>Returns a  DescribeSolutionResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeSolution">REST API Reference for DescribeSolution Operation</seealso>
        public virtual DescribeSolutionResponse EndDescribeSolution(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSolutionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSolutionVersion

        /// <summary>
        /// Describes a specific version of a solution. For more information on solutions, see
        /// <a>CreateSolution</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSolutionVersion service method.</param>
        /// 
        /// <returns>The response from the DescribeSolutionVersion service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeSolutionVersion">REST API Reference for DescribeSolutionVersion Operation</seealso>
        public virtual DescribeSolutionVersionResponse DescribeSolutionVersion(DescribeSolutionVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSolutionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSolutionVersionResponseUnmarshaller.Instance;

            return Invoke<DescribeSolutionVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSolutionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSolutionVersion operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSolutionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeSolutionVersion">REST API Reference for DescribeSolutionVersion Operation</seealso>
        public virtual IAsyncResult BeginDescribeSolutionVersion(DescribeSolutionVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSolutionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSolutionVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSolutionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSolutionVersion.</param>
        /// 
        /// <returns>Returns a  DescribeSolutionVersionResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeSolutionVersion">REST API Reference for DescribeSolutionVersion Operation</seealso>
        public virtual DescribeSolutionVersionResponse EndDescribeSolutionVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSolutionVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSolutionMetrics

        /// <summary>
        /// Gets the metrics for the specified solution version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSolutionMetrics service method.</param>
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
        public virtual GetSolutionMetricsResponse GetSolutionMetrics(GetSolutionMetricsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolutionMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolutionMetricsResponseUnmarshaller.Instance;

            return Invoke<GetSolutionMetricsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSolutionMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSolutionMetrics operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSolutionMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/GetSolutionMetrics">REST API Reference for GetSolutionMetrics Operation</seealso>
        public virtual IAsyncResult BeginGetSolutionMetrics(GetSolutionMetricsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolutionMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolutionMetricsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSolutionMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSolutionMetrics.</param>
        /// 
        /// <returns>Returns a  GetSolutionMetricsResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/GetSolutionMetrics">REST API Reference for GetSolutionMetrics Operation</seealso>
        public virtual GetSolutionMetricsResponse EndGetSolutionMetrics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSolutionMetricsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBatchInferenceJobs

        /// <summary>
        /// Gets a list of the batch inference jobs that have been performed off of a solution
        /// version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBatchInferenceJobs service method.</param>
        /// 
        /// <returns>The response from the ListBatchInferenceJobs service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListBatchInferenceJobs">REST API Reference for ListBatchInferenceJobs Operation</seealso>
        public virtual ListBatchInferenceJobsResponse ListBatchInferenceJobs(ListBatchInferenceJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBatchInferenceJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBatchInferenceJobsResponseUnmarshaller.Instance;

            return Invoke<ListBatchInferenceJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBatchInferenceJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBatchInferenceJobs operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBatchInferenceJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListBatchInferenceJobs">REST API Reference for ListBatchInferenceJobs Operation</seealso>
        public virtual IAsyncResult BeginListBatchInferenceJobs(ListBatchInferenceJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBatchInferenceJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBatchInferenceJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBatchInferenceJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBatchInferenceJobs.</param>
        /// 
        /// <returns>Returns a  ListBatchInferenceJobsResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListBatchInferenceJobs">REST API Reference for ListBatchInferenceJobs Operation</seealso>
        public virtual ListBatchInferenceJobsResponse EndListBatchInferenceJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBatchInferenceJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCampaigns

        /// <summary>
        /// Returns a list of campaigns that use the given solution. When a solution is not specified,
        /// all the campaigns associated with the account are listed. The response provides the
        /// properties for each campaign, including the Amazon Resource Name (ARN). For more information
        /// on campaigns, see <a>CreateCampaign</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCampaigns service method.</param>
        /// 
        /// <returns>The response from the ListCampaigns service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        public virtual ListCampaignsResponse ListCampaigns(ListCampaignsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCampaignsResponseUnmarshaller.Instance;

            return Invoke<ListCampaignsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCampaigns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCampaigns operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCampaigns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        public virtual IAsyncResult BeginListCampaigns(ListCampaignsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCampaignsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCampaigns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCampaigns.</param>
        /// 
        /// <returns>Returns a  ListCampaignsResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        public virtual ListCampaignsResponse EndListCampaigns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCampaignsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDatasetGroups

        /// <summary>
        /// Returns a list of dataset groups. The response provides the properties for each dataset
        /// group, including the Amazon Resource Name (ARN). For more information on dataset groups,
        /// see <a>CreateDatasetGroup</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetGroups service method.</param>
        /// 
        /// <returns>The response from the ListDatasetGroups service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDatasetGroups">REST API Reference for ListDatasetGroups Operation</seealso>
        public virtual ListDatasetGroupsResponse ListDatasetGroups(ListDatasetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetGroupsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetGroups operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasetGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDatasetGroups">REST API Reference for ListDatasetGroups Operation</seealso>
        public virtual IAsyncResult BeginListDatasetGroups(ListDatasetGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasetGroups.</param>
        /// 
        /// <returns>Returns a  ListDatasetGroupsResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDatasetGroups">REST API Reference for ListDatasetGroups Operation</seealso>
        public virtual ListDatasetGroupsResponse EndListDatasetGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDatasetGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDatasetImportJobs

        /// <summary>
        /// Returns a list of dataset import jobs that use the given dataset. When a dataset is
        /// not specified, all the dataset import jobs associated with the account are listed.
        /// The response provides the properties for each dataset import job, including the Amazon
        /// Resource Name (ARN). For more information on dataset import jobs, see <a>CreateDatasetImportJob</a>.
        /// For more information on datasets, see <a>CreateDataset</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListDatasetImportJobs service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDatasetImportJobs">REST API Reference for ListDatasetImportJobs Operation</seealso>
        public virtual ListDatasetImportJobsResponse ListDatasetImportJobs(ListDatasetImportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetImportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetImportJobs operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasetImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDatasetImportJobs">REST API Reference for ListDatasetImportJobs Operation</seealso>
        public virtual IAsyncResult BeginListDatasetImportJobs(ListDatasetImportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetImportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasetImportJobs.</param>
        /// 
        /// <returns>Returns a  ListDatasetImportJobsResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDatasetImportJobs">REST API Reference for ListDatasetImportJobs Operation</seealso>
        public virtual ListDatasetImportJobsResponse EndListDatasetImportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDatasetImportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDatasets

        /// <summary>
        /// Returns the list of datasets contained in the given dataset group. The response provides
        /// the properties for each dataset, including the Amazon Resource Name (ARN). For more
        /// information on datasets, see <a>CreateDataset</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual IAsyncResult BeginListDatasets(ListDatasetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasets.</param>
        /// 
        /// <returns>Returns a  ListDatasetsResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual ListDatasetsResponse EndListDatasets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDatasetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEventTrackers

        /// <summary>
        /// Returns the list of event trackers associated with the account. The response provides
        /// the properties for each event tracker, including the Amazon Resource Name (ARN) and
        /// tracking ID. For more information on event trackers, see <a>CreateEventTracker</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventTrackers service method.</param>
        /// 
        /// <returns>The response from the ListEventTrackers service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListEventTrackers">REST API Reference for ListEventTrackers Operation</seealso>
        public virtual ListEventTrackersResponse ListEventTrackers(ListEventTrackersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventTrackersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventTrackersResponseUnmarshaller.Instance;

            return Invoke<ListEventTrackersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventTrackers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventTrackers operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventTrackers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListEventTrackers">REST API Reference for ListEventTrackers Operation</seealso>
        public virtual IAsyncResult BeginListEventTrackers(ListEventTrackersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventTrackersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventTrackersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventTrackers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventTrackers.</param>
        /// 
        /// <returns>Returns a  ListEventTrackersResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListEventTrackers">REST API Reference for ListEventTrackers Operation</seealso>
        public virtual ListEventTrackersResponse EndListEventTrackers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEventTrackersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFilters

        /// <summary>
        /// Lists all filters that belong to a given dataset group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFilters service method.</param>
        /// 
        /// <returns>The response from the ListFilters service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListFilters">REST API Reference for ListFilters Operation</seealso>
        public virtual ListFiltersResponse ListFilters(ListFiltersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFiltersResponseUnmarshaller.Instance;

            return Invoke<ListFiltersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFilters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFilters operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFilters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListFilters">REST API Reference for ListFilters Operation</seealso>
        public virtual IAsyncResult BeginListFilters(ListFiltersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFiltersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFilters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFilters.</param>
        /// 
        /// <returns>Returns a  ListFiltersResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListFilters">REST API Reference for ListFilters Operation</seealso>
        public virtual ListFiltersResponse EndListFilters(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFiltersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRecipes

        /// <summary>
        /// Returns a list of available recipes. The response provides the properties for each
        /// recipe, including the recipe's Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecipes service method.</param>
        /// 
        /// <returns>The response from the ListRecipes service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListRecipes">REST API Reference for ListRecipes Operation</seealso>
        public virtual ListRecipesResponse ListRecipes(ListRecipesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecipesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecipesResponseUnmarshaller.Instance;

            return Invoke<ListRecipesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecipes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecipes operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecipes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListRecipes">REST API Reference for ListRecipes Operation</seealso>
        public virtual IAsyncResult BeginListRecipes(ListRecipesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecipesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecipesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecipes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecipes.</param>
        /// 
        /// <returns>Returns a  ListRecipesResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListRecipes">REST API Reference for ListRecipes Operation</seealso>
        public virtual ListRecipesResponse EndListRecipes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRecipesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSchemas

        /// <summary>
        /// Returns the list of schemas associated with the account. The response provides the
        /// properties for each schema, including the Amazon Resource Name (ARN). For more information
        /// on schemas, see <a>CreateSchema</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas service method.</param>
        /// 
        /// <returns>The response from the ListSchemas service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        public virtual ListSchemasResponse ListSchemas(ListSchemasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemasResponseUnmarshaller.Instance;

            return Invoke<ListSchemasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSchemas
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        public virtual IAsyncResult BeginListSchemas(ListSchemasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSchemas operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSchemas.</param>
        /// 
        /// <returns>Returns a  ListSchemasResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        public virtual ListSchemasResponse EndListSchemas(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSchemasResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSolutions

        /// <summary>
        /// Returns a list of solutions that use the given dataset group. When a dataset group
        /// is not specified, all the solutions associated with the account are listed. The response
        /// provides the properties for each solution, including the Amazon Resource Name (ARN).
        /// For more information on solutions, see <a>CreateSolution</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSolutions service method.</param>
        /// 
        /// <returns>The response from the ListSolutions service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListSolutions">REST API Reference for ListSolutions Operation</seealso>
        public virtual ListSolutionsResponse ListSolutions(ListSolutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolutionsResponseUnmarshaller.Instance;

            return Invoke<ListSolutionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSolutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSolutions operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSolutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListSolutions">REST API Reference for ListSolutions Operation</seealso>
        public virtual IAsyncResult BeginListSolutions(ListSolutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSolutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSolutions.</param>
        /// 
        /// <returns>Returns a  ListSolutionsResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListSolutions">REST API Reference for ListSolutions Operation</seealso>
        public virtual ListSolutionsResponse EndListSolutions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSolutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSolutionVersions

        /// <summary>
        /// Returns a list of solution versions for the given solution. When a solution is not
        /// specified, all the solution versions associated with the account are listed. The response
        /// provides the properties for each solution version, including the Amazon Resource Name
        /// (ARN). For more information on solutions, see <a>CreateSolution</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSolutionVersions service method.</param>
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
        public virtual ListSolutionVersionsResponse ListSolutionVersions(ListSolutionVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolutionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolutionVersionsResponseUnmarshaller.Instance;

            return Invoke<ListSolutionVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSolutionVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSolutionVersions operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSolutionVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListSolutionVersions">REST API Reference for ListSolutionVersions Operation</seealso>
        public virtual IAsyncResult BeginListSolutionVersions(ListSolutionVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolutionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolutionVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSolutionVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSolutionVersions.</param>
        /// 
        /// <returns>Returns a  ListSolutionVersionsResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListSolutionVersions">REST API Reference for ListSolutionVersions Operation</seealso>
        public virtual ListSolutionVersionsResponse EndListSolutionVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSolutionVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCampaign

        /// <summary>
        /// Updates a campaign by either deploying a new solution or changing the value of the
        /// campaign's <code>minProvisionedTPS</code> parameter.
        /// 
        ///  
        /// <para>
        /// To update a campaign, the campaign status must be ACTIVE or CREATE FAILED. Check the
        /// campaign status using the <a>DescribeCampaign</a> API.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must wait until the <code>status</code> of the updated campaign is <code>ACTIVE</code>
        /// before asking the campaign for recommendations.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on campaigns, see <a>CreateCampaign</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaign service method.</param>
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
        public virtual UpdateCampaignResponse UpdateCampaign(UpdateCampaignRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignResponseUnmarshaller.Instance;

            return Invoke<UpdateCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaign operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/UpdateCampaign">REST API Reference for UpdateCampaign Operation</seealso>
        public virtual IAsyncResult BeginUpdateCampaign(UpdateCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaign.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/UpdateCampaign">REST API Reference for UpdateCampaign Operation</seealso>
        public virtual UpdateCampaignResponse EndUpdateCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCampaignResponse>(asyncResult);
        }

        #endregion
        
    }
}