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

using Amazon.Runtime;
using Amazon.Personalize.Model;

#pragma warning disable CS1570
namespace Amazon.Personalize
{
    /// <summary>
    /// <para>Interface for accessing Personalize</para>
    ///
    /// Amazon Personalize is a machine learning service that makes it easy to add individualized
    /// recommendations to customers.
    /// </summary>
    public partial interface IAmazonPersonalize : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPersonalizePaginatorFactory Paginators { get; }
#endif


        
        #region  CreateBatchInferenceJob


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
        CreateBatchInferenceJobResponse CreateBatchInferenceJob(CreateBatchInferenceJobRequest request);

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
        IAsyncResult BeginCreateBatchInferenceJob(CreateBatchInferenceJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBatchInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBatchInferenceJob.</param>
        /// 
        /// <returns>Returns a  CreateBatchInferenceJobResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateBatchInferenceJob">REST API Reference for CreateBatchInferenceJob Operation</seealso>
        CreateBatchInferenceJobResponse EndCreateBatchInferenceJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBatchSegmentJob


        /// <summary>
        /// Creates a batch segment job. The operation can handle up to 50 million records and
        /// the input file must be in JSON format. For more information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/recommendations-batch.html">Getting
        /// batch recommendations and user segments</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchSegmentJob service method.</param>
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
        CreateBatchSegmentJobResponse CreateBatchSegmentJob(CreateBatchSegmentJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBatchSegmentJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchSegmentJob operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBatchSegmentJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateBatchSegmentJob">REST API Reference for CreateBatchSegmentJob Operation</seealso>
        IAsyncResult BeginCreateBatchSegmentJob(CreateBatchSegmentJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBatchSegmentJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBatchSegmentJob.</param>
        /// 
        /// <returns>Returns a  CreateBatchSegmentJobResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateBatchSegmentJob">REST API Reference for CreateBatchSegmentJob Operation</seealso>
        CreateBatchSegmentJobResponse EndCreateBatchSegmentJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCampaign


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
        CreateCampaignResponse CreateCampaign(CreateCampaignRequest request);

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
        IAsyncResult BeginCreateCampaign(CreateCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCampaign.</param>
        /// 
        /// <returns>Returns a  CreateCampaignResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        CreateCampaignResponse EndCreateCampaign(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataDeletionJob


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
        CreateDataDeletionJobResponse CreateDataDeletionJob(CreateDataDeletionJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataDeletionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataDeletionJob operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataDeletionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateDataDeletionJob">REST API Reference for CreateDataDeletionJob Operation</seealso>
        IAsyncResult BeginCreateDataDeletionJob(CreateDataDeletionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataDeletionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataDeletionJob.</param>
        /// 
        /// <returns>Returns a  CreateDataDeletionJobResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateDataDeletionJob">REST API Reference for CreateDataDeletionJob Operation</seealso>
        CreateDataDeletionJobResponse EndCreateDataDeletionJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataset


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
        CreateDatasetResponse CreateDataset(CreateDatasetRequest request);

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
        IAsyncResult BeginCreateDataset(CreateDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataset.</param>
        /// 
        /// <returns>Returns a  CreateDatasetResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        CreateDatasetResponse EndCreateDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDatasetExportJob


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
        CreateDatasetExportJobResponse CreateDatasetExportJob(CreateDatasetExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDatasetExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetExportJob operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDatasetExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateDatasetExportJob">REST API Reference for CreateDatasetExportJob Operation</seealso>
        IAsyncResult BeginCreateDatasetExportJob(CreateDatasetExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatasetExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatasetExportJob.</param>
        /// 
        /// <returns>Returns a  CreateDatasetExportJobResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateDatasetExportJob">REST API Reference for CreateDatasetExportJob Operation</seealso>
        CreateDatasetExportJobResponse EndCreateDatasetExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDatasetGroup


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
        CreateDatasetGroupResponse CreateDatasetGroup(CreateDatasetGroupRequest request);

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
        IAsyncResult BeginCreateDatasetGroup(CreateDatasetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatasetGroup.</param>
        /// 
        /// <returns>Returns a  CreateDatasetGroupResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateDatasetGroup">REST API Reference for CreateDatasetGroup Operation</seealso>
        CreateDatasetGroupResponse EndCreateDatasetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDatasetImportJob


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
        CreateDatasetImportJobResponse CreateDatasetImportJob(CreateDatasetImportJobRequest request);

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
        IAsyncResult BeginCreateDatasetImportJob(CreateDatasetImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatasetImportJob.</param>
        /// 
        /// <returns>Returns a  CreateDatasetImportJobResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateDatasetImportJob">REST API Reference for CreateDatasetImportJob Operation</seealso>
        CreateDatasetImportJobResponse EndCreateDatasetImportJob(IAsyncResult asyncResult);

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
        CreateEventTrackerResponse CreateEventTracker(CreateEventTrackerRequest request);

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
        IAsyncResult BeginCreateEventTracker(CreateEventTrackerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventTracker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventTracker.</param>
        /// 
        /// <returns>Returns a  CreateEventTrackerResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateEventTracker">REST API Reference for CreateEventTracker Operation</seealso>
        CreateEventTrackerResponse EndCreateEventTracker(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFilter


        /// <summary>
        /// Creates a recommendation filter. For more information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/filter.html">Filtering
        /// recommendations and user segments</a>.
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
        /// <exception cref="Amazon.Personalize.Model.TooManyTagsException">
        /// You have exceeded the maximum number of tags you can apply to this resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        CreateFilterResponse CreateFilter(CreateFilterRequest request);

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
        IAsyncResult BeginCreateFilter(CreateFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFilter.</param>
        /// 
        /// <returns>Returns a  CreateFilterResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        CreateFilterResponse EndCreateFilter(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMetricAttribution


        /// <summary>
        /// Creates a metric attribution. A metric attribution creates reports on the data that
        /// you import into Amazon Personalize. Depending on how you imported the data, you can
        /// view reports in Amazon CloudWatch or Amazon S3. For more information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/measuring-recommendation-impact.html">Measuring
        /// impact of recommendations</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMetricAttribution service method.</param>
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
        CreateMetricAttributionResponse CreateMetricAttribution(CreateMetricAttributionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMetricAttribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMetricAttribution operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMetricAttribution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateMetricAttribution">REST API Reference for CreateMetricAttribution Operation</seealso>
        IAsyncResult BeginCreateMetricAttribution(CreateMetricAttributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMetricAttribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMetricAttribution.</param>
        /// 
        /// <returns>Returns a  CreateMetricAttributionResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateMetricAttribution">REST API Reference for CreateMetricAttribution Operation</seealso>
        CreateMetricAttributionResponse EndCreateMetricAttribution(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRecommender


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
        CreateRecommenderResponse CreateRecommender(CreateRecommenderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRecommender operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRecommender operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRecommender
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateRecommender">REST API Reference for CreateRecommender Operation</seealso>
        IAsyncResult BeginCreateRecommender(CreateRecommenderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRecommender operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRecommender.</param>
        /// 
        /// <returns>Returns a  CreateRecommenderResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateRecommender">REST API Reference for CreateRecommender Operation</seealso>
        CreateRecommenderResponse EndCreateRecommender(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSchema


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
        CreateSchemaResponse CreateSchema(CreateSchemaRequest request);

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
        IAsyncResult BeginCreateSchema(CreateSchemaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSchema.</param>
        /// 
        /// <returns>Returns a  CreateSchemaResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        CreateSchemaResponse EndCreateSchema(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSolution


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
        CreateSolutionResponse CreateSolution(CreateSolutionRequest request);

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
        IAsyncResult BeginCreateSolution(CreateSolutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSolution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSolution.</param>
        /// 
        /// <returns>Returns a  CreateSolutionResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateSolution">REST API Reference for CreateSolution Operation</seealso>
        CreateSolutionResponse EndCreateSolution(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSolutionVersion


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
        CreateSolutionVersionResponse CreateSolutionVersion(CreateSolutionVersionRequest request);

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
        IAsyncResult BeginCreateSolutionVersion(CreateSolutionVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSolutionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSolutionVersion.</param>
        /// 
        /// <returns>Returns a  CreateSolutionVersionResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/CreateSolutionVersion">REST API Reference for CreateSolutionVersion Operation</seealso>
        CreateSolutionVersionResponse EndCreateSolutionVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCampaign


        /// <summary>
        /// Removes a campaign by deleting the solution deployment. The solution that the campaign
        /// is based on is not deleted and can be redeployed when needed. A deleted campaign can
        /// no longer be specified in a <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetRecommendations.html">GetRecommendations</a>
        /// request. For information on creating campaigns, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateCampaign.html">CreateCampaign</a>.
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
        DeleteCampaignResponse DeleteCampaign(DeleteCampaignRequest request);

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
        IAsyncResult BeginDeleteCampaign(DeleteCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCampaign.</param>
        /// 
        /// <returns>Returns a  DeleteCampaignResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        DeleteCampaignResponse EndDeleteCampaign(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataset


        /// <summary>
        /// Deletes a dataset. You can't delete a dataset if an associated <c>DatasetImportJob</c>
        /// or <c>SolutionVersion</c> is in the CREATE PENDING or IN PROGRESS state. For more
        /// information on datasets, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDataset.html">CreateDataset</a>.
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
        DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request);

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
        IAsyncResult BeginDeleteDataset(DeleteDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataset.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        DeleteDatasetResponse EndDeleteDataset(IAsyncResult asyncResult);

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
        DeleteDatasetGroupResponse DeleteDatasetGroup(DeleteDatasetGroupRequest request);

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
        IAsyncResult BeginDeleteDatasetGroup(DeleteDatasetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDatasetGroup.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetGroupResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteDatasetGroup">REST API Reference for DeleteDatasetGroup Operation</seealso>
        DeleteDatasetGroupResponse EndDeleteDatasetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEventTracker


        /// <summary>
        /// Deletes the event tracker. Does not delete the dataset from the dataset group. For
        /// more information on event trackers, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateEventTracker.html">CreateEventTracker</a>.
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
        DeleteEventTrackerResponse DeleteEventTracker(DeleteEventTrackerRequest request);

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
        IAsyncResult BeginDeleteEventTracker(DeleteEventTrackerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventTracker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventTracker.</param>
        /// 
        /// <returns>Returns a  DeleteEventTrackerResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteEventTracker">REST API Reference for DeleteEventTracker Operation</seealso>
        DeleteEventTrackerResponse EndDeleteEventTracker(IAsyncResult asyncResult);

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
        DeleteFilterResponse DeleteFilter(DeleteFilterRequest request);

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
        IAsyncResult BeginDeleteFilter(DeleteFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFilter.</param>
        /// 
        /// <returns>Returns a  DeleteFilterResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteFilter">REST API Reference for DeleteFilter Operation</seealso>
        DeleteFilterResponse EndDeleteFilter(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMetricAttribution


        /// <summary>
        /// Deletes a metric attribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMetricAttribution service method.</param>
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
        DeleteMetricAttributionResponse DeleteMetricAttribution(DeleteMetricAttributionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMetricAttribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMetricAttribution operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMetricAttribution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteMetricAttribution">REST API Reference for DeleteMetricAttribution Operation</seealso>
        IAsyncResult BeginDeleteMetricAttribution(DeleteMetricAttributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMetricAttribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMetricAttribution.</param>
        /// 
        /// <returns>Returns a  DeleteMetricAttributionResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteMetricAttribution">REST API Reference for DeleteMetricAttribution Operation</seealso>
        DeleteMetricAttributionResponse EndDeleteMetricAttribution(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRecommender


        /// <summary>
        /// Deactivates and removes a recommender. A deleted recommender can no longer be specified
        /// in a <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetRecommendations.html">GetRecommendations</a>
        /// request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecommender service method.</param>
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
        DeleteRecommenderResponse DeleteRecommender(DeleteRecommenderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRecommender operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecommender operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRecommender
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteRecommender">REST API Reference for DeleteRecommender Operation</seealso>
        IAsyncResult BeginDeleteRecommender(DeleteRecommenderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRecommender operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRecommender.</param>
        /// 
        /// <returns>Returns a  DeleteRecommenderResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteRecommender">REST API Reference for DeleteRecommender Operation</seealso>
        DeleteRecommenderResponse EndDeleteRecommender(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSchema


        /// <summary>
        /// Deletes a schema. Before deleting a schema, you must delete all datasets referencing
        /// the schema. For more information on schemas, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSchema.html">CreateSchema</a>.
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
        DeleteSchemaResponse DeleteSchema(DeleteSchemaRequest request);

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
        IAsyncResult BeginDeleteSchema(DeleteSchemaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSchema.</param>
        /// 
        /// <returns>Returns a  DeleteSchemaResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        DeleteSchemaResponse EndDeleteSchema(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSolution


        /// <summary>
        /// Deletes all versions of a solution and the <c>Solution</c> object itself. Before deleting
        /// a solution, you must delete all campaigns based on the solution. To determine what
        /// campaigns are using the solution, call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListCampaigns.html">ListCampaigns</a>
        /// and supply the Amazon Resource Name (ARN) of the solution. You can't delete a solution
        /// if an associated <c>SolutionVersion</c> is in the CREATE PENDING or IN PROGRESS state.
        /// For more information on solutions, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSolution.html">CreateSolution</a>.
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
        DeleteSolutionResponse DeleteSolution(DeleteSolutionRequest request);

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
        IAsyncResult BeginDeleteSolution(DeleteSolutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSolution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSolution.</param>
        /// 
        /// <returns>Returns a  DeleteSolutionResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DeleteSolution">REST API Reference for DeleteSolution Operation</seealso>
        DeleteSolutionResponse EndDeleteSolution(IAsyncResult asyncResult);

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
        DescribeAlgorithmResponse DescribeAlgorithm(DescribeAlgorithmRequest request);

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
        IAsyncResult BeginDescribeAlgorithm(DescribeAlgorithmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlgorithm.</param>
        /// 
        /// <returns>Returns a  DescribeAlgorithmResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeAlgorithm">REST API Reference for DescribeAlgorithm Operation</seealso>
        DescribeAlgorithmResponse EndDescribeAlgorithm(IAsyncResult asyncResult);

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
        DescribeBatchInferenceJobResponse DescribeBatchInferenceJob(DescribeBatchInferenceJobRequest request);

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
        IAsyncResult BeginDescribeBatchInferenceJob(DescribeBatchInferenceJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBatchInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBatchInferenceJob.</param>
        /// 
        /// <returns>Returns a  DescribeBatchInferenceJobResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeBatchInferenceJob">REST API Reference for DescribeBatchInferenceJob Operation</seealso>
        DescribeBatchInferenceJobResponse EndDescribeBatchInferenceJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBatchSegmentJob


        /// <summary>
        /// Gets the properties of a batch segment job including name, Amazon Resource Name (ARN),
        /// status, input and output configurations, and the ARN of the solution version used
        /// to generate segments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBatchSegmentJob service method.</param>
        /// 
        /// <returns>The response from the DescribeBatchSegmentJob service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeBatchSegmentJob">REST API Reference for DescribeBatchSegmentJob Operation</seealso>
        DescribeBatchSegmentJobResponse DescribeBatchSegmentJob(DescribeBatchSegmentJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBatchSegmentJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBatchSegmentJob operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBatchSegmentJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeBatchSegmentJob">REST API Reference for DescribeBatchSegmentJob Operation</seealso>
        IAsyncResult BeginDescribeBatchSegmentJob(DescribeBatchSegmentJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBatchSegmentJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBatchSegmentJob.</param>
        /// 
        /// <returns>Returns a  DescribeBatchSegmentJobResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeBatchSegmentJob">REST API Reference for DescribeBatchSegmentJob Operation</seealso>
        DescribeBatchSegmentJobResponse EndDescribeBatchSegmentJob(IAsyncResult asyncResult);

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
        /// When the <c>status</c> is <c>CREATE FAILED</c>, the response includes the <c>failureReason</c>
        /// key, which describes why.
        /// </para>
        ///  
        /// <para>
        /// For more information on campaigns, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateCampaign.html">CreateCampaign</a>.
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
        DescribeCampaignResponse DescribeCampaign(DescribeCampaignRequest request);

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
        IAsyncResult BeginDescribeCampaign(DescribeCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCampaign.</param>
        /// 
        /// <returns>Returns a  DescribeCampaignResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeCampaign">REST API Reference for DescribeCampaign Operation</seealso>
        DescribeCampaignResponse EndDescribeCampaign(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDataDeletionJob


        /// <summary>
        /// Describes the data deletion job created by <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDataDeletionJob.html">CreateDataDeletionJob</a>,
        /// including the job status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataDeletionJob service method.</param>
        /// 
        /// <returns>The response from the DescribeDataDeletionJob service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDataDeletionJob">REST API Reference for DescribeDataDeletionJob Operation</seealso>
        DescribeDataDeletionJobResponse DescribeDataDeletionJob(DescribeDataDeletionJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataDeletionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataDeletionJob operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataDeletionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDataDeletionJob">REST API Reference for DescribeDataDeletionJob Operation</seealso>
        IAsyncResult BeginDescribeDataDeletionJob(DescribeDataDeletionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataDeletionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataDeletionJob.</param>
        /// 
        /// <returns>Returns a  DescribeDataDeletionJobResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDataDeletionJob">REST API Reference for DescribeDataDeletionJob Operation</seealso>
        DescribeDataDeletionJobResponse EndDescribeDataDeletionJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDataset


        /// <summary>
        /// Describes the given dataset. For more information on datasets, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDataset.html">CreateDataset</a>.
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
        DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request);

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
        IAsyncResult BeginDescribeDataset(DescribeDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataset.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        DescribeDatasetResponse EndDescribeDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDatasetExportJob


        /// <summary>
        /// Describes the dataset export job created by <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDatasetExportJob.html">CreateDatasetExportJob</a>,
        /// including the export job status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetExportJob service method.</param>
        /// 
        /// <returns>The response from the DescribeDatasetExportJob service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDatasetExportJob">REST API Reference for DescribeDatasetExportJob Operation</seealso>
        DescribeDatasetExportJobResponse DescribeDatasetExportJob(DescribeDatasetExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDatasetExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetExportJob operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDatasetExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDatasetExportJob">REST API Reference for DescribeDatasetExportJob Operation</seealso>
        IAsyncResult BeginDescribeDatasetExportJob(DescribeDatasetExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDatasetExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDatasetExportJob.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetExportJobResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDatasetExportJob">REST API Reference for DescribeDatasetExportJob Operation</seealso>
        DescribeDatasetExportJobResponse EndDescribeDatasetExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDatasetGroup


        /// <summary>
        /// Describes the given dataset group. For more information on dataset groups, see <a
        /// href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDatasetGroup.html">CreateDatasetGroup</a>.
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
        DescribeDatasetGroupResponse DescribeDatasetGroup(DescribeDatasetGroupRequest request);

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
        IAsyncResult BeginDescribeDatasetGroup(DescribeDatasetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDatasetGroup.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetGroupResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDatasetGroup">REST API Reference for DescribeDatasetGroup Operation</seealso>
        DescribeDatasetGroupResponse EndDescribeDatasetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDatasetImportJob


        /// <summary>
        /// Describes the dataset import job created by <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDatasetImportJob.html">CreateDatasetImportJob</a>,
        /// including the import job status.
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
        DescribeDatasetImportJobResponse DescribeDatasetImportJob(DescribeDatasetImportJobRequest request);

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
        IAsyncResult BeginDescribeDatasetImportJob(DescribeDatasetImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDatasetImportJob.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetImportJobResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeDatasetImportJob">REST API Reference for DescribeDatasetImportJob Operation</seealso>
        DescribeDatasetImportJobResponse EndDescribeDatasetImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEventTracker


        /// <summary>
        /// Describes an event tracker. The response includes the <c>trackingId</c> and <c>status</c>
        /// of the event tracker. For more information on event trackers, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateEventTracker.html">CreateEventTracker</a>.
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
        DescribeEventTrackerResponse DescribeEventTracker(DescribeEventTrackerRequest request);

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
        IAsyncResult BeginDescribeEventTracker(DescribeEventTrackerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventTracker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventTracker.</param>
        /// 
        /// <returns>Returns a  DescribeEventTrackerResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeEventTracker">REST API Reference for DescribeEventTracker Operation</seealso>
        DescribeEventTrackerResponse EndDescribeEventTracker(IAsyncResult asyncResult);

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
        DescribeFeatureTransformationResponse DescribeFeatureTransformation(DescribeFeatureTransformationRequest request);

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
        IAsyncResult BeginDescribeFeatureTransformation(DescribeFeatureTransformationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFeatureTransformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFeatureTransformation.</param>
        /// 
        /// <returns>Returns a  DescribeFeatureTransformationResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeFeatureTransformation">REST API Reference for DescribeFeatureTransformation Operation</seealso>
        DescribeFeatureTransformationResponse EndDescribeFeatureTransformation(IAsyncResult asyncResult);

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
        DescribeFilterResponse DescribeFilter(DescribeFilterRequest request);

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
        IAsyncResult BeginDescribeFilter(DescribeFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFilter.</param>
        /// 
        /// <returns>Returns a  DescribeFilterResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeFilter">REST API Reference for DescribeFilter Operation</seealso>
        DescribeFilterResponse EndDescribeFilter(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeMetricAttribution


        /// <summary>
        /// Describes a metric attribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricAttribution service method.</param>
        /// 
        /// <returns>The response from the DescribeMetricAttribution service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeMetricAttribution">REST API Reference for DescribeMetricAttribution Operation</seealso>
        DescribeMetricAttributionResponse DescribeMetricAttribution(DescribeMetricAttributionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMetricAttribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricAttribution operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMetricAttribution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeMetricAttribution">REST API Reference for DescribeMetricAttribution Operation</seealso>
        IAsyncResult BeginDescribeMetricAttribution(DescribeMetricAttributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMetricAttribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMetricAttribution.</param>
        /// 
        /// <returns>Returns a  DescribeMetricAttributionResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeMetricAttribution">REST API Reference for DescribeMetricAttribution Operation</seealso>
        DescribeMetricAttributionResponse EndDescribeMetricAttribution(IAsyncResult asyncResult);

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
        /// you create a solution with the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSolution.html">CreateSolution</a>
        /// API. <c>CreateSolution</c> trains a model by using the algorithm in the specified
        /// recipe and a training dataset. The solution, when deployed as a campaign, can provide
        /// recommendations using the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetRecommendations.html">GetRecommendations</a>
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
        DescribeRecipeResponse DescribeRecipe(DescribeRecipeRequest request);

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
        IAsyncResult BeginDescribeRecipe(DescribeRecipeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRecipe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRecipe.</param>
        /// 
        /// <returns>Returns a  DescribeRecipeResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeRecipe">REST API Reference for DescribeRecipe Operation</seealso>
        DescribeRecipeResponse EndDescribeRecipe(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRecommender


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
        /// 
        /// <returns>The response from the DescribeRecommender service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeRecommender">REST API Reference for DescribeRecommender Operation</seealso>
        DescribeRecommenderResponse DescribeRecommender(DescribeRecommenderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRecommender operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecommender operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRecommender
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeRecommender">REST API Reference for DescribeRecommender Operation</seealso>
        IAsyncResult BeginDescribeRecommender(DescribeRecommenderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRecommender operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRecommender.</param>
        /// 
        /// <returns>Returns a  DescribeRecommenderResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeRecommender">REST API Reference for DescribeRecommender Operation</seealso>
        DescribeRecommenderResponse EndDescribeRecommender(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSchema


        /// <summary>
        /// Describes a schema. For more information on schemas, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSchema.html">CreateSchema</a>.
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
        DescribeSchemaResponse DescribeSchema(DescribeSchemaRequest request);

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
        IAsyncResult BeginDescribeSchema(DescribeSchemaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSchema.</param>
        /// 
        /// <returns>Returns a  DescribeSchemaResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeSchema">REST API Reference for DescribeSchema Operation</seealso>
        DescribeSchemaResponse EndDescribeSchema(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSolution


        /// <summary>
        /// Describes a solution. For more information on solutions, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSolution.html">CreateSolution</a>.
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
        DescribeSolutionResponse DescribeSolution(DescribeSolutionRequest request);

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
        IAsyncResult BeginDescribeSolution(DescribeSolutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSolution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSolution.</param>
        /// 
        /// <returns>Returns a  DescribeSolutionResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeSolution">REST API Reference for DescribeSolution Operation</seealso>
        DescribeSolutionResponse EndDescribeSolution(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSolutionVersion


        /// <summary>
        /// Describes a specific version of a solution. For more information on solutions, see
        /// <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSolution.html">CreateSolution</a>
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
        DescribeSolutionVersionResponse DescribeSolutionVersion(DescribeSolutionVersionRequest request);

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
        IAsyncResult BeginDescribeSolutionVersion(DescribeSolutionVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSolutionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSolutionVersion.</param>
        /// 
        /// <returns>Returns a  DescribeSolutionVersionResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/DescribeSolutionVersion">REST API Reference for DescribeSolutionVersion Operation</seealso>
        DescribeSolutionVersionResponse EndDescribeSolutionVersion(IAsyncResult asyncResult);

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
        GetSolutionMetricsResponse GetSolutionMetrics(GetSolutionMetricsRequest request);

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
        IAsyncResult BeginGetSolutionMetrics(GetSolutionMetricsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSolutionMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSolutionMetrics.</param>
        /// 
        /// <returns>Returns a  GetSolutionMetricsResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/GetSolutionMetrics">REST API Reference for GetSolutionMetrics Operation</seealso>
        GetSolutionMetricsResponse EndGetSolutionMetrics(IAsyncResult asyncResult);

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
        ListBatchInferenceJobsResponse ListBatchInferenceJobs(ListBatchInferenceJobsRequest request);

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
        IAsyncResult BeginListBatchInferenceJobs(ListBatchInferenceJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBatchInferenceJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBatchInferenceJobs.</param>
        /// 
        /// <returns>Returns a  ListBatchInferenceJobsResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListBatchInferenceJobs">REST API Reference for ListBatchInferenceJobs Operation</seealso>
        ListBatchInferenceJobsResponse EndListBatchInferenceJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBatchSegmentJobs


        /// <summary>
        /// Gets a list of the batch segment jobs that have been performed off of a solution version
        /// that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBatchSegmentJobs service method.</param>
        /// 
        /// <returns>The response from the ListBatchSegmentJobs service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListBatchSegmentJobs">REST API Reference for ListBatchSegmentJobs Operation</seealso>
        ListBatchSegmentJobsResponse ListBatchSegmentJobs(ListBatchSegmentJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBatchSegmentJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBatchSegmentJobs operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBatchSegmentJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListBatchSegmentJobs">REST API Reference for ListBatchSegmentJobs Operation</seealso>
        IAsyncResult BeginListBatchSegmentJobs(ListBatchSegmentJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBatchSegmentJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBatchSegmentJobs.</param>
        /// 
        /// <returns>Returns a  ListBatchSegmentJobsResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListBatchSegmentJobs">REST API Reference for ListBatchSegmentJobs Operation</seealso>
        ListBatchSegmentJobsResponse EndListBatchSegmentJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCampaigns


        /// <summary>
        /// Returns a list of campaigns that use the given solution. When a solution is not specified,
        /// all the campaigns associated with the account are listed. The response provides the
        /// properties for each campaign, including the Amazon Resource Name (ARN). For more information
        /// on campaigns, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateCampaign.html">CreateCampaign</a>.
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
        ListCampaignsResponse ListCampaigns(ListCampaignsRequest request);

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
        IAsyncResult BeginListCampaigns(ListCampaignsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCampaigns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCampaigns.</param>
        /// 
        /// <returns>Returns a  ListCampaignsResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        ListCampaignsResponse EndListCampaigns(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataDeletionJobs


        /// <summary>
        /// Returns a list of data deletion jobs for a dataset group ordered by creation time,
        /// with the most recent first. When a dataset group is not specified, all the data deletion
        /// jobs associated with the account are listed. The response provides the properties
        /// for each job, including the Amazon Resource Name (ARN). For more information on data
        /// deletion jobs, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/delete-records.html">Deleting
        /// users</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataDeletionJobs service method.</param>
        /// 
        /// <returns>The response from the ListDataDeletionJobs service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDataDeletionJobs">REST API Reference for ListDataDeletionJobs Operation</seealso>
        ListDataDeletionJobsResponse ListDataDeletionJobs(ListDataDeletionJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataDeletionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataDeletionJobs operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataDeletionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDataDeletionJobs">REST API Reference for ListDataDeletionJobs Operation</seealso>
        IAsyncResult BeginListDataDeletionJobs(ListDataDeletionJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataDeletionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataDeletionJobs.</param>
        /// 
        /// <returns>Returns a  ListDataDeletionJobsResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDataDeletionJobs">REST API Reference for ListDataDeletionJobs Operation</seealso>
        ListDataDeletionJobsResponse EndListDataDeletionJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDatasetExportJobs


        /// <summary>
        /// Returns a list of dataset export jobs that use the given dataset. When a dataset is
        /// not specified, all the dataset export jobs associated with the account are listed.
        /// The response provides the properties for each dataset export job, including the Amazon
        /// Resource Name (ARN). For more information on dataset export jobs, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDatasetExportJob.html">CreateDatasetExportJob</a>.
        /// For more information on datasets, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDataset.html">CreateDataset</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetExportJobs service method.</param>
        /// 
        /// <returns>The response from the ListDatasetExportJobs service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDatasetExportJobs">REST API Reference for ListDatasetExportJobs Operation</seealso>
        ListDatasetExportJobsResponse ListDatasetExportJobs(ListDatasetExportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasetExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetExportJobs operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasetExportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDatasetExportJobs">REST API Reference for ListDatasetExportJobs Operation</seealso>
        IAsyncResult BeginListDatasetExportJobs(ListDatasetExportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasetExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasetExportJobs.</param>
        /// 
        /// <returns>Returns a  ListDatasetExportJobsResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDatasetExportJobs">REST API Reference for ListDatasetExportJobs Operation</seealso>
        ListDatasetExportJobsResponse EndListDatasetExportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDatasetGroups


        /// <summary>
        /// Returns a list of dataset groups. The response provides the properties for each dataset
        /// group, including the Amazon Resource Name (ARN). For more information on dataset groups,
        /// see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDatasetGroup.html">CreateDatasetGroup</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetGroups service method.</param>
        /// 
        /// <returns>The response from the ListDatasetGroups service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDatasetGroups">REST API Reference for ListDatasetGroups Operation</seealso>
        ListDatasetGroupsResponse ListDatasetGroups(ListDatasetGroupsRequest request);

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
        IAsyncResult BeginListDatasetGroups(ListDatasetGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasetGroups.</param>
        /// 
        /// <returns>Returns a  ListDatasetGroupsResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDatasetGroups">REST API Reference for ListDatasetGroups Operation</seealso>
        ListDatasetGroupsResponse EndListDatasetGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDatasetImportJobs


        /// <summary>
        /// Returns a list of dataset import jobs that use the given dataset. When a dataset is
        /// not specified, all the dataset import jobs associated with the account are listed.
        /// The response provides the properties for each dataset import job, including the Amazon
        /// Resource Name (ARN). For more information on dataset import jobs, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDatasetImportJob.html">CreateDatasetImportJob</a>.
        /// For more information on datasets, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDataset.html">CreateDataset</a>.
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
        ListDatasetImportJobsResponse ListDatasetImportJobs(ListDatasetImportJobsRequest request);

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
        IAsyncResult BeginListDatasetImportJobs(ListDatasetImportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasetImportJobs.</param>
        /// 
        /// <returns>Returns a  ListDatasetImportJobsResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDatasetImportJobs">REST API Reference for ListDatasetImportJobs Operation</seealso>
        ListDatasetImportJobsResponse EndListDatasetImportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDatasets


        /// <summary>
        /// Returns the list of datasets contained in the given dataset group. The response provides
        /// the properties for each dataset, including the Amazon Resource Name (ARN). For more
        /// information on datasets, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDataset.html">CreateDataset</a>.
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
        ListDatasetsResponse ListDatasets(ListDatasetsRequest request);

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
        IAsyncResult BeginListDatasets(ListDatasetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasets.</param>
        /// 
        /// <returns>Returns a  ListDatasetsResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        ListDatasetsResponse EndListDatasets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEventTrackers


        /// <summary>
        /// Returns the list of event trackers associated with the account. The response provides
        /// the properties for each event tracker, including the Amazon Resource Name (ARN) and
        /// tracking ID. For more information on event trackers, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateEventTracker.html">CreateEventTracker</a>.
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
        ListEventTrackersResponse ListEventTrackers(ListEventTrackersRequest request);

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
        IAsyncResult BeginListEventTrackers(ListEventTrackersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventTrackers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventTrackers.</param>
        /// 
        /// <returns>Returns a  ListEventTrackersResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListEventTrackers">REST API Reference for ListEventTrackers Operation</seealso>
        ListEventTrackersResponse EndListEventTrackers(IAsyncResult asyncResult);

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
        ListFiltersResponse ListFilters(ListFiltersRequest request);

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
        IAsyncResult BeginListFilters(ListFiltersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFilters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFilters.</param>
        /// 
        /// <returns>Returns a  ListFiltersResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListFilters">REST API Reference for ListFilters Operation</seealso>
        ListFiltersResponse EndListFilters(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMetricAttributionMetrics


        /// <summary>
        /// Lists the metrics for the metric attribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMetricAttributionMetrics service method.</param>
        /// 
        /// <returns>The response from the ListMetricAttributionMetrics service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListMetricAttributionMetrics">REST API Reference for ListMetricAttributionMetrics Operation</seealso>
        ListMetricAttributionMetricsResponse ListMetricAttributionMetrics(ListMetricAttributionMetricsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMetricAttributionMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMetricAttributionMetrics operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMetricAttributionMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListMetricAttributionMetrics">REST API Reference for ListMetricAttributionMetrics Operation</seealso>
        IAsyncResult BeginListMetricAttributionMetrics(ListMetricAttributionMetricsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMetricAttributionMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMetricAttributionMetrics.</param>
        /// 
        /// <returns>Returns a  ListMetricAttributionMetricsResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListMetricAttributionMetrics">REST API Reference for ListMetricAttributionMetrics Operation</seealso>
        ListMetricAttributionMetricsResponse EndListMetricAttributionMetrics(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMetricAttributions


        /// <summary>
        /// Lists metric attributions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMetricAttributions service method.</param>
        /// 
        /// <returns>The response from the ListMetricAttributions service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListMetricAttributions">REST API Reference for ListMetricAttributions Operation</seealso>
        ListMetricAttributionsResponse ListMetricAttributions(ListMetricAttributionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMetricAttributions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMetricAttributions operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMetricAttributions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListMetricAttributions">REST API Reference for ListMetricAttributions Operation</seealso>
        IAsyncResult BeginListMetricAttributions(ListMetricAttributionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMetricAttributions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMetricAttributions.</param>
        /// 
        /// <returns>Returns a  ListMetricAttributionsResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListMetricAttributions">REST API Reference for ListMetricAttributions Operation</seealso>
        ListMetricAttributionsResponse EndListMetricAttributions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRecipes


        /// <summary>
        /// Returns a list of available recipes. The response provides the properties for each
        /// recipe, including the recipe's Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecipes service method.</param>
        /// 
        /// <returns>The response from the ListRecipes service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListRecipes">REST API Reference for ListRecipes Operation</seealso>
        ListRecipesResponse ListRecipes(ListRecipesRequest request);

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
        IAsyncResult BeginListRecipes(ListRecipesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecipes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecipes.</param>
        /// 
        /// <returns>Returns a  ListRecipesResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListRecipes">REST API Reference for ListRecipes Operation</seealso>
        ListRecipesResponse EndListRecipes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRecommenders


        /// <summary>
        /// Returns a list of recommenders in a given Domain dataset group. When a Domain dataset
        /// group is not specified, all the recommenders associated with the account are listed.
        /// The response provides the properties for each recommender, including the Amazon Resource
        /// Name (ARN). For more information on recommenders, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateRecommender.html">CreateRecommender</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommenders service method.</param>
        /// 
        /// <returns>The response from the ListRecommenders service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListRecommenders">REST API Reference for ListRecommenders Operation</seealso>
        ListRecommendersResponse ListRecommenders(ListRecommendersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecommenders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecommenders operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecommenders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListRecommenders">REST API Reference for ListRecommenders Operation</seealso>
        IAsyncResult BeginListRecommenders(ListRecommendersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecommenders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecommenders.</param>
        /// 
        /// <returns>Returns a  ListRecommendersResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListRecommenders">REST API Reference for ListRecommenders Operation</seealso>
        ListRecommendersResponse EndListRecommenders(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSchemas


        /// <summary>
        /// Returns the list of schemas associated with the account. The response provides the
        /// properties for each schema, including the Amazon Resource Name (ARN). For more information
        /// on schemas, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSchema.html">CreateSchema</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas service method.</param>
        /// 
        /// <returns>The response from the ListSchemas service method, as returned by Personalize.</returns>
        /// <exception cref="Amazon.Personalize.Model.InvalidNextTokenException">
        /// The token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        ListSchemasResponse ListSchemas(ListSchemasRequest request);

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
        IAsyncResult BeginListSchemas(ListSchemasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSchemas operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSchemas.</param>
        /// 
        /// <returns>Returns a  ListSchemasResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        ListSchemasResponse EndListSchemas(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSolutions


        /// <summary>
        /// Returns a list of solutions in a given dataset group. When a dataset group is not
        /// specified, all the solutions associated with the account are listed. The response
        /// provides the properties for each solution, including the Amazon Resource Name (ARN).
        /// For more information on solutions, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSolution.html">CreateSolution</a>.
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
        ListSolutionsResponse ListSolutions(ListSolutionsRequest request);

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
        IAsyncResult BeginListSolutions(ListSolutionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSolutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSolutions.</param>
        /// 
        /// <returns>Returns a  ListSolutionsResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListSolutions">REST API Reference for ListSolutions Operation</seealso>
        ListSolutionsResponse EndListSolutions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSolutionVersions


        /// <summary>
        /// Returns a list of solution versions for the given solution. When a solution is not
        /// specified, all the solution versions associated with the account are listed. The response
        /// provides the properties for each solution version, including the Amazon Resource Name
        /// (ARN).
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
        ListSolutionVersionsResponse ListSolutionVersions(ListSolutionVersionsRequest request);

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
        IAsyncResult BeginListSolutionVersions(ListSolutionVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSolutionVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSolutionVersions.</param>
        /// 
        /// <returns>Returns a  ListSolutionVersionsResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListSolutionVersions">REST API Reference for ListSolutionVersions Operation</seealso>
        ListSolutionVersionsResponse EndListSolutionVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Get a list of <a href="https://docs.aws.amazon.com/personalize/latest/dg/tagging-resources.html">tags</a>
        /// attached to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  StartRecommender


        /// <summary>
        /// Starts a recommender that is INACTIVE. Starting a recommender does not create any
        /// new models, but resumes billing and automatic retraining for the recommender.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRecommender service method.</param>
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
        StartRecommenderResponse StartRecommender(StartRecommenderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartRecommender operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartRecommender operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartRecommender
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/StartRecommender">REST API Reference for StartRecommender Operation</seealso>
        IAsyncResult BeginStartRecommender(StartRecommenderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartRecommender operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartRecommender.</param>
        /// 
        /// <returns>Returns a  StartRecommenderResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/StartRecommender">REST API Reference for StartRecommender Operation</seealso>
        StartRecommenderResponse EndStartRecommender(IAsyncResult asyncResult);

        #endregion
        
        #region  StopRecommender


        /// <summary>
        /// Stops a recommender that is ACTIVE. Stopping a recommender halts billing and automatic
        /// retraining for the recommender.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopRecommender service method.</param>
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
        StopRecommenderResponse StopRecommender(StopRecommenderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopRecommender operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopRecommender operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopRecommender
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/StopRecommender">REST API Reference for StopRecommender Operation</seealso>
        IAsyncResult BeginStopRecommender(StopRecommenderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopRecommender operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopRecommender.</param>
        /// 
        /// <returns>Returns a  StopRecommenderResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/StopRecommender">REST API Reference for StopRecommender Operation</seealso>
        StopRecommenderResponse EndStopRecommender(IAsyncResult asyncResult);

        #endregion
        
        #region  StopSolutionVersionCreation


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
        StopSolutionVersionCreationResponse StopSolutionVersionCreation(StopSolutionVersionCreationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopSolutionVersionCreation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopSolutionVersionCreation operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopSolutionVersionCreation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/StopSolutionVersionCreation">REST API Reference for StopSolutionVersionCreation Operation</seealso>
        IAsyncResult BeginStopSolutionVersionCreation(StopSolutionVersionCreationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopSolutionVersionCreation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopSolutionVersionCreation.</param>
        /// 
        /// <returns>Returns a  StopSolutionVersionCreationResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/StopSolutionVersionCreation">REST API Reference for StopSolutionVersionCreation Operation</seealso>
        StopSolutionVersionCreationResponse EndStopSolutionVersionCreation(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Add a list of tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags that are attached to a resource. For more information,
        /// see <a href="https://docs.aws.amazon.com/personalize/latest/dg/tags-remove.html">Removing
        /// tags from Amazon Personalize resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCampaign


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
        UpdateCampaignResponse UpdateCampaign(UpdateCampaignRequest request);

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
        IAsyncResult BeginUpdateCampaign(UpdateCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaign.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/UpdateCampaign">REST API Reference for UpdateCampaign Operation</seealso>
        UpdateCampaignResponse EndUpdateCampaign(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDataset


        /// <summary>
        /// Update a dataset to replace its schema with a new or existing one. For more information,
        /// see <a href="https://docs.aws.amazon.com/personalize/latest/dg/updating-dataset-schema.html">Replacing
        /// a dataset's schema</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataset service method.</param>
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
        UpdateDatasetResponse UpdateDataset(UpdateDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataset operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        IAsyncResult BeginUpdateDataset(UpdateDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataset.</param>
        /// 
        /// <returns>Returns a  UpdateDatasetResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        UpdateDatasetResponse EndUpdateDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMetricAttribution


        /// <summary>
        /// Updates a metric attribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMetricAttribution service method.</param>
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
        UpdateMetricAttributionResponse UpdateMetricAttribution(UpdateMetricAttributionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMetricAttribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMetricAttribution operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMetricAttribution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/UpdateMetricAttribution">REST API Reference for UpdateMetricAttribution Operation</seealso>
        IAsyncResult BeginUpdateMetricAttribution(UpdateMetricAttributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMetricAttribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMetricAttribution.</param>
        /// 
        /// <returns>Returns a  UpdateMetricAttributionResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/UpdateMetricAttribution">REST API Reference for UpdateMetricAttribution Operation</seealso>
        UpdateMetricAttributionResponse EndUpdateMetricAttribution(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRecommender


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
        UpdateRecommenderResponse UpdateRecommender(UpdateRecommenderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRecommender operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecommender operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRecommender
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/UpdateRecommender">REST API Reference for UpdateRecommender Operation</seealso>
        IAsyncResult BeginUpdateRecommender(UpdateRecommenderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRecommender operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRecommender.</param>
        /// 
        /// <returns>Returns a  UpdateRecommenderResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/UpdateRecommender">REST API Reference for UpdateRecommender Operation</seealso>
        UpdateRecommenderResponse EndUpdateRecommender(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSolution


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
        UpdateSolutionResponse UpdateSolution(UpdateSolutionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSolution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSolution operation on AmazonPersonalizeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSolution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/UpdateSolution">REST API Reference for UpdateSolution Operation</seealso>
        IAsyncResult BeginUpdateSolution(UpdateSolutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSolution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSolution.</param>
        /// 
        /// <returns>Returns a  UpdateSolutionResult from Personalize.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-2018-05-22/UpdateSolution">REST API Reference for UpdateSolution Operation</seealso>
        UpdateSolutionResponse EndUpdateSolution(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}