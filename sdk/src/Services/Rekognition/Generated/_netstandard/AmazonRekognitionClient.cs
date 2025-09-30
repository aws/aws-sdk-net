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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Rekognition.Model;
using Amazon.Rekognition.Model.Internal.MarshallTransformations;
using Amazon.Rekognition.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Rekognition
{
    /// <summary>
    /// <para>Implementation for accessing Rekognition</para>
    ///
    /// This is the API Reference for <a href="https://docs.aws.amazon.com/rekognition/latest/dg/images.html">Amazon
    /// Rekognition Image</a>, <a href="https://docs.aws.amazon.com/rekognition/latest/customlabels-dg/what-is.html">Amazon
    /// Rekognition Custom Labels</a>, <a href="https://docs.aws.amazon.com/rekognition/latest/dg/video.html">Amazon
    /// Rekognition Stored Video</a>, <a href="https://docs.aws.amazon.com/rekognition/latest/dg/streaming-video.html">Amazon
    /// Rekognition Streaming Video</a>. It provides descriptions of actions, data types,
    /// common parameters, and common errors.
    /// 
    ///  
    /// <para>
    ///  <b>Amazon Rekognition Image</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_AssociateFaces.html">AssociateFaces</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_CompareFaces.html">CompareFaces</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_CreateCollection.html">CreateCollection</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_CreateUser.html">CreateUser</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_DeleteCollection.html">DeleteCollection</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_DeleteFaces.html">DeleteFaces</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_DeleteUser.html">DeleteUser</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_DescribeCollection.html">DescribeCollection</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_DetectFaces.html">DetectFaces</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_DetectLabels.html">DetectLabels</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_DetectModerationLabels.html">DetectModerationLabels</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_DetectProtectiveEquipment.html">DetectProtectiveEquipment</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_DetectText.html">DetectText</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_DisassociateFaces.html">DisassociateFaces</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_GetCelebrityInfo.html">GetCelebrityInfo</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_GetMediaAnalysisJob.html">GetMediaAnalysisJob</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_IndexFaces.html">IndexFaces</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_ListCollections.html">ListCollections</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_ListMediaAnalysisJob.html">ListMediaAnalysisJob</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_ListFaces.html">ListFaces</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_ListFaces.html">ListUsers</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_RecognizeCelebrities.html">RecognizeCelebrities</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_SearchFaces.html">SearchFaces</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_SearchFacesByImage.html">SearchFacesByImage</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_SearchUsers.html">SearchUsers</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_SearchUsersByImage.html">SearchUsersByImage</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_StartMediaAnalysisJob.html">StartMediaAnalysisJob</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Amazon Rekognition Custom Labels</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_CopyProjectVersion.html">CopyProjectVersion</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_CreateDataset.html">CreateDataset</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_CreateProject.html">CreateProject</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_CreateProjectVersion.html">CreateProjectVersion</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_DeleteDataset.html">DeleteDataset</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_DeleteProject.html">DeleteProject</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_DeleteProjectPolicy.html">DeleteProjectPolicy</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_DeleteProjectVersion.html">DeleteProjectVersion</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_DescribeDataset.html">DescribeDataset</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_DescribeProjects.html">DescribeProjects</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_DescribeProjectVersions.html">DescribeProjectVersions</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_DetectCustomLabels.html">DetectCustomLabels</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_DistributeDatasetEntries.html">DistributeDatasetEntries</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_ListDatasetEntries.html">ListDatasetEntries</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_ListDatasetLabels.html">ListDatasetLabels</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_ListProjectPolicies.html">ListProjectPolicies</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_PutProjectPolicy.html">PutProjectPolicy</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_StartProjectVersion.html">StartProjectVersion</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_StopProjectVersion.html">StopProjectVersion</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_UpdateDatasetEntries.html">UpdateDatasetEntries</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Amazon Rekognition Video Stored Video</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_GetCelebrityRecognition.html">GetCelebrityRecognition</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_GetContentModeration.html">GetContentModeration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_GetFaceDetection.html">GetFaceDetection</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_GetFaceSearch.html">GetFaceSearch</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_GetLabelDetection.html">GetLabelDetection</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_GetPersonTracking.html">GetPersonTracking</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_GetSegmentDetection.html">GetSegmentDetection</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_GetTextDetection.html">GetTextDetection</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_StartCelebrityRecognition.html">StartCelebrityRecognition</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_StartContentModeration.html">StartContentModeration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_StartFaceDetection.html">StartFaceDetection</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_StartFaceSearch.html">StartFaceSearch</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_StartLabelDetection.html">StartLabelDetection</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_StartPersonTracking.html">StartPersonTracking</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_StartSegmentDetection.html">StartSegmentDetection</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_StartTextDetection.html">StartTextDetection</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Amazon Rekognition Video Streaming Video</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_CreateStreamProcessor.html">CreateStreamProcessor</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_DeleteStreamProcessor.html">DeleteStreamProcessor</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_DescribeStreamProcessor.html">DescribeStreamProcessor</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_ListStreamProcessors.html">ListStreamProcessors</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_StartStreamProcessor.html">StartStreamProcessor</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_StopStreamProcessor.html">StopStreamProcessor</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rekognition/latest/APIReference/API_UpdateStreamProcessor.html">UpdateStreamProcessor</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonRekognitionClient : AmazonServiceClient, IAmazonRekognition
    {
        private static IServiceMetadata serviceMetadata = new AmazonRekognitionMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonRekognitionClient with the credentials loaded from the application's
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
        public AmazonRekognitionClient()
            : base(new AmazonRekognitionConfig()) { }

        /// <summary>
        /// Constructs AmazonRekognitionClient with the credentials loaded from the application's
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
        public AmazonRekognitionClient(RegionEndpoint region)
            : base(new AmazonRekognitionConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRekognitionClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRekognitionClient Configuration Object</param>
        public AmazonRekognitionClient(AmazonRekognitionConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRekognitionClient(AWSCredentials credentials)
            : this(credentials, new AmazonRekognitionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRekognitionClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRekognitionConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Credentials and an
        /// AmazonRekognitionClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRekognitionClient Configuration Object</param>
        public AmazonRekognitionClient(AWSCredentials credentials, AmazonRekognitionConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRekognitionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRekognitionConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRekognitionClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRekognitionClient Configuration Object</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRekognitionConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRekognitionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRekognitionConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRekognitionClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRekognitionClient Configuration Object</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRekognitionConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IRekognitionPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IRekognitionPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new RekognitionPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRekognitionEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRekognitionAuthSchemeHandler());
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


        #region  AssociateFaces

        internal virtual AssociateFacesResponse AssociateFaces(AssociateFacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateFacesResponseUnmarshaller.Instance;

            return Invoke<AssociateFacesResponse>(request, options);
        }



        /// <summary>
        /// Associates one or more faces with an existing UserID. Takes an array of <c>FaceIds</c>.
        /// Each <c>FaceId</c> that are present in the <c>FaceIds</c> list is associated with
        /// the provided UserID. The number of FaceIds that can be used as input in a single request
        /// is limited to 100.
        /// 
        ///  
        /// <para>
        /// Note that the total number of faces that can be associated with a single <c>UserID</c>
        /// is also limited to 100. Once a <c>UserID</c> has 100 faces associated with it, no
        /// additional faces can be added. If more API calls are made after the limit is reached,
        /// a <c>ServiceQuotaExceededException</c> will result.
        /// </para>
        ///  
        /// <para>
        /// The <c>UserMatchThreshold</c> parameter specifies the minimum user match confidence
        /// required for the face to be associated with a UserID that has at least one <c>FaceID</c>
        /// already associated. This ensures that the <c>FaceIds</c> are associated with the right
        /// UserID. The value ranges from 0-100 and default value is 75. 
        /// </para>
        ///  
        /// <para>
        /// If successful, an array of <c>AssociatedFace</c> objects containing the associated
        /// <c>FaceIds</c> is returned. If a given face is already associated with the given <c>UserID</c>,
        /// it will be ignored and will not be returned in the response. If a given face is already
        /// associated to a different <c>UserID</c>, isn't found in the collection, doesn’t meet
        /// the <c>UserMatchThreshold</c>, or there are already 100 faces associated with the
        /// <c>UserID</c>, it will be returned as part of an array of <c>UnsuccessfulFaceAssociations.</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The <c>UserStatus</c> reflects the status of an operation which updates a UserID representation
        /// with a list of given faces. The <c>UserStatus</c> can be: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ACTIVE - All associations or disassociations of FaceID(s) for a UserID are complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATED - A UserID has been created, but has no FaceID(s) associated with it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UPDATING - A UserID is being updated and there are current associations or disassociations
        /// of FaceID(s) taking place.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateFaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateFaces service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ConflictException">
        /// A User with the same Id already exists within the collection, or the update or deletion
        /// of the User caused an inconsistent state. **
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <c>ClientRequestToken</c> input parameter was reused with an operation, but at least
        /// one of the other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ServiceQuotaExceededException">
        /// The size of the collection exceeds the allowed limit. For more information, see Guidelines
        /// and quotas in Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/AssociateFaces">REST API Reference for AssociateFaces Operation</seealso>
        public virtual Task<AssociateFacesResponse> AssociateFacesAsync(AssociateFacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateFacesResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateFacesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CompareFaces

        internal virtual CompareFacesResponse CompareFaces(CompareFacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CompareFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompareFacesResponseUnmarshaller.Instance;

            return Invoke<CompareFacesResponse>(request, options);
        }



        /// <summary>
        /// Compares a face in the <i>source</i> input image with each of the 100 largest faces
        /// detected in the <i>target</i> input image. 
        /// 
        ///  
        /// <para>
        ///  If the source image contains multiple faces, the service detects the largest face
        /// and compares it with each face detected in the target image. 
        /// </para>
        ///  <note> 
        /// <para>
        /// CompareFaces uses machine learning algorithms, which are probabilistic. A false negative
        /// is an incorrect prediction that a face in the target image has a low similarity confidence
        /// score when compared to the face in the source image. To reduce the probability of
        /// false negatives, we recommend that you compare the target image against multiple source
        /// images. If you plan to use <c>CompareFaces</c> to make a decision that impacts an
        /// individual's rights, privacy, or access to services, we recommend that you pass the
        /// result to a human for review and further validation before taking action.
        /// </para>
        ///  </note> 
        /// <para>
        /// You pass the input and target images either as base64-encoded image bytes or as references
        /// to images in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition
        /// operations, passing image bytes isn't supported. The image must be formatted as a
        /// PNG or JPEG file. 
        /// </para>
        ///  
        /// <para>
        /// In response, the operation returns an array of face matches ordered by similarity
        /// score in descending order. For each face match, the response provides a bounding box
        /// of the face, facial landmarks, pose details (pitch, roll, and yaw), quality (brightness
        /// and sharpness), and confidence value (indicating the level of confidence that the
        /// bounding box contains a face). The response also provides a similarity score, which
        /// indicates how closely the faces match. 
        /// </para>
        ///  <note> 
        /// <para>
        /// By default, only faces with a similarity score of greater than or equal to 80% are
        /// returned in the response. You can change this value by specifying the <c>SimilarityThreshold</c>
        /// parameter.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <c>CompareFaces</c> also returns an array of faces that don't match the source image.
        /// For each face, it returns a bounding box, confidence value, landmarks, pose details,
        /// and quality. The response also returns information about the face in the source image,
        /// including the bounding box of the face and confidence value.
        /// </para>
        ///  
        /// <para>
        /// The <c>QualityFilter</c> input parameter allows you to filter out detected faces that
        /// don’t meet a required quality bar. The quality bar is based on a variety of common
        /// use cases. Use <c>QualityFilter</c> to set the quality bar by specifying <c>LOW</c>,
        /// <c>MEDIUM</c>, or <c>HIGH</c>. If you do not want to filter detected faces, specify
        /// <c>NONE</c>. The default value is <c>NONE</c>. 
        /// </para>
        ///  
        /// <para>
        /// If the image doesn't contain Exif metadata, <c>CompareFaces</c> returns orientation
        /// information for the source and target images. Use these values to display the images
        /// with the correct image orientation.
        /// </para>
        ///  
        /// <para>
        /// If no faces are detected in the source or target images, <c>CompareFaces</c> returns
        /// an <c>InvalidParameterException</c> error. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  This is a stateless API operation. That is, data returned by this operation doesn't
        /// persist.
        /// </para>
        ///  </note> 
        /// <para>
        /// For an example, see Comparing Faces in Images in the Amazon Rekognition Developer
        /// Guide.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:CompareFaces</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompareFaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CompareFaces service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. If you are calling DetectProtectiveEquipment,
        /// the image size or resolution exceeds the allowed limit. For more information, see
        /// Guidelines and quotas in Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CompareFaces">REST API Reference for CompareFaces Operation</seealso>
        public virtual Task<CompareFacesResponse> CompareFacesAsync(CompareFacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CompareFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompareFacesResponseUnmarshaller.Instance;

            return InvokeAsync<CompareFacesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CopyProjectVersion

        internal virtual CopyProjectVersionResponse CopyProjectVersion(CopyProjectVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyProjectVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyProjectVersionResponseUnmarshaller.Instance;

            return Invoke<CopyProjectVersionResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This operation applies only to Amazon Rekognition Custom Labels.
        /// </para>
        ///  </note> 
        /// <para>
        /// Copies a version of an Amazon Rekognition Custom Labels model from a source project
        /// to a destination project. The source and destination projects can be in different
        /// AWS accounts but must be in the same AWS Region. You can't copy a model to another
        /// AWS service. 
        /// </para>
        ///  
        /// <para>
        /// To copy a model version to a different AWS account, you need to create a resource-based
        /// policy known as a <i>project policy</i>. You attach the project policy to the source
        /// project by calling <a>PutProjectPolicy</a>. The project policy gives permission to
        /// copy the model version from a trusting AWS account to a trusted account.
        /// </para>
        ///  
        /// <para>
        /// For more information creating and attaching a project policy, see Attaching a project
        /// policy (SDK) in the <i>Amazon Rekognition Custom Labels Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// If you are copying a model version to a project in the same AWS account, you don't
        /// need to create a project policy.
        /// </para>
        ///  <note> 
        /// <para>
        /// Copying project versions is supported only for Custom Labels models. 
        /// </para>
        ///  
        /// <para>
        /// To copy a model, the destination project, source project, and source model version
        /// must already exist.
        /// </para>
        ///  </note> 
        /// <para>
        /// Copying a model version takes a while to complete. To get the current status, call
        /// <a>DescribeProjectVersions</a> and check the value of <c>Status</c> in the <a>ProjectVersionDescription</a>
        /// object. The copy operation has finished when the value of <c>Status</c> is <c>COPYING_COMPLETED</c>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:CopyProjectVersion</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyProjectVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyProjectVersion service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// jobs concurrently, subsequent calls to start operations (ex: <c>StartLabelDetection</c>)
        /// will raise a <c>LimitExceededException</c> exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Rekognition service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ServiceQuotaExceededException">
        /// The size of the collection exceeds the allowed limit. For more information, see Guidelines
        /// and quotas in Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CopyProjectVersion">REST API Reference for CopyProjectVersion Operation</seealso>
        public virtual Task<CopyProjectVersionResponse> CopyProjectVersionAsync(CopyProjectVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyProjectVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyProjectVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CopyProjectVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCollection

        internal virtual CreateCollectionResponse CreateCollection(CreateCollectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCollectionResponseUnmarshaller.Instance;

            return Invoke<CreateCollectionResponse>(request, options);
        }



        /// <summary>
        /// Creates a collection in an AWS Region. You can add faces to the collection using the
        /// <a>IndexFaces</a> operation. 
        /// 
        ///  
        /// <para>
        /// For example, you might create collections, one for each of your application users.
        /// A user can then index faces using the <c>IndexFaces</c> operation and persist results
        /// in a specific collection. Then, a user can search the collection for faces in the
        /// user-specific container. 
        /// </para>
        ///  
        /// <para>
        /// When you create a collection, it is associated with the latest version of the face
        /// model version.
        /// </para>
        ///  <note> 
        /// <para>
        /// Collection names are case-sensitive.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:CreateCollection</c>
        /// action. If you want to tag your collection, you also require permission to perform
        /// the <c>rekognition:TagResource</c> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCollection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceAlreadyExistsException">
        /// A resource with the specified ID already exists.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ServiceQuotaExceededException">
        /// The size of the collection exceeds the allowed limit. For more information, see Guidelines
        /// and quotas in Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateCollection">REST API Reference for CreateCollection Operation</seealso>
        public virtual Task<CreateCollectionResponse> CreateCollectionAsync(CreateCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCollectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCollectionResponse>(request, options, cancellationToken);
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
        /// <note> 
        /// <para>
        /// This operation applies only to Amazon Rekognition Custom Labels.
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a new Amazon Rekognition Custom Labels dataset. You can create a dataset by
        /// using an Amazon Sagemaker format manifest file or by copying an existing Amazon Rekognition
        /// Custom Labels dataset.
        /// </para>
        ///  
        /// <para>
        /// To create a training dataset for a project, specify <c>TRAIN</c> for the value of
        /// <c>DatasetType</c>. To create the test dataset for a project, specify <c>TEST</c>
        /// for the value of <c>DatasetType</c>. 
        /// </para>
        ///  
        /// <para>
        /// The response from <c>CreateDataset</c> is the Amazon Resource Name (ARN) for the dataset.
        /// Creating a dataset takes a while to complete. Use <a>DescribeDataset</a> to check
        /// the current status. The dataset created successfully if the value of <c>Status</c>
        /// is <c>CREATE_COMPLETE</c>. 
        /// </para>
        ///  
        /// <para>
        /// To check if any non-terminal errors occurred, call <a>ListDatasetEntries</a> and check
        /// for the presence of <c>errors</c> lists in the JSON Lines.
        /// </para>
        ///  
        /// <para>
        /// Dataset creation fails if a terminal error occurs (<c>Status</c> = <c>CREATE_FAILED</c>).
        /// Currently, you can't access the terminal error information. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see Creating dataset in the <i>Amazon Rekognition Custom Labels
        /// Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:CreateDataset</c>
        /// action. If you want to copy an existing dataset, you also require permission to perform
        /// the <c>rekognition:ListDatasetEntries</c> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataset service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// jobs concurrently, subsequent calls to start operations (ex: <c>StartLabelDetection</c>)
        /// will raise a <c>LimitExceededException</c> exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Rekognition service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceAlreadyExistsException">
        /// A resource with the specified ID already exists.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual Task<CreateDatasetResponse> CreateDatasetAsync(CreateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatasetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFaceLivenessSession

        internal virtual CreateFaceLivenessSessionResponse CreateFaceLivenessSession(CreateFaceLivenessSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFaceLivenessSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFaceLivenessSessionResponseUnmarshaller.Instance;

            return Invoke<CreateFaceLivenessSessionResponse>(request, options);
        }



        /// <summary>
        /// This API operation initiates a Face Liveness session. It returns a <c>SessionId</c>,
        /// which you can use to start streaming Face Liveness video and get the results for a
        /// Face Liveness session. 
        /// 
        ///  
        /// <para>
        /// You can use the <c>OutputConfig</c> option in the Settings parameter to provide an
        /// Amazon S3 bucket location. The Amazon S3 bucket stores reference images and audit
        /// images. If no Amazon S3 bucket is defined, raw bytes are sent instead. 
        /// </para>
        ///  
        /// <para>
        /// You can use <c>AuditImagesLimit</c> to limit the number of audit images returned when
        /// <c>GetFaceLivenessSessionResults</c> is called. This number is between 0 and 4. By
        /// default, it is set to 0. The limit is best effort and based on the duration of the
        /// selfie-video. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFaceLivenessSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFaceLivenessSession service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateFaceLivenessSession">REST API Reference for CreateFaceLivenessSession Operation</seealso>
        public virtual Task<CreateFaceLivenessSessionResponse> CreateFaceLivenessSessionAsync(CreateFaceLivenessSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFaceLivenessSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFaceLivenessSessionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFaceLivenessSessionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateProject

        internal virtual CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return Invoke<CreateProjectResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Amazon Rekognition project. A project is a group of resources (datasets,
        /// model versions) that you use to create and manage a Amazon Rekognition Custom Labels
        /// Model or custom adapter. You can specify a feature to create the project with, if
        /// no feature is specified then Custom Labels is used by default. For adapters, you can
        /// also choose whether or not to have the project auto update by using the AutoUpdate
        /// argument. This operation requires permissions to perform the <c>rekognition:CreateProject</c>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// jobs concurrently, subsequent calls to start operations (ex: <c>StartLabelDetection</c>)
        /// will raise a <c>LimitExceededException</c> exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Rekognition service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateProjectVersion

        internal virtual CreateProjectVersionResponse CreateProjectVersion(CreateProjectVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProjectVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectVersionResponseUnmarshaller.Instance;

            return Invoke<CreateProjectVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new version of Amazon Rekognition project (like a Custom Labels model or
        /// a custom adapter) and begins training. Models and adapters are managed as part of
        /// a Rekognition project. The response from <c>CreateProjectVersion</c> is an Amazon
        /// Resource Name (ARN) for the project version. 
        /// 
        ///  
        /// <para>
        /// The FeatureConfig operation argument allows you to configure specific model or adapter
        /// settings. You can provide a description to the project version by using the VersionDescription
        /// argment. Training can take a while to complete. You can get the current status by
        /// calling <a>DescribeProjectVersions</a>. Training completed successfully if the value
        /// of the <c>Status</c> field is <c>TRAINING_COMPLETED</c>. Once training has successfully
        /// completed, call <a>DescribeProjectVersions</a> to get the training results and evaluate
        /// the model.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:CreateProjectVersion</c>
        /// action.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <i>The following applies only to projects with Amazon Rekognition Custom Labels as
        /// the chosen feature:</i> 
        /// </para>
        ///  
        /// <para>
        /// You can train a model in a project that doesn't have associated datasets by specifying
        /// manifest files in the <c>TrainingData</c> and <c>TestingData</c> fields. 
        /// </para>
        ///  
        /// <para>
        /// If you open the console after training a model with manifest files, Amazon Rekognition
        /// Custom Labels creates the datasets for you using the most recent manifest files. You
        /// can no longer train a model version for the project by specifying manifest files.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Instead of training with a project without associated datasets, we recommend that
        /// you use the manifest files to create training and test datasets for the project.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProjectVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProjectVersion service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// jobs concurrently, subsequent calls to start operations (ex: <c>StartLabelDetection</c>)
        /// will raise a <c>LimitExceededException</c> exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Rekognition service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ServiceQuotaExceededException">
        /// The size of the collection exceeds the allowed limit. For more information, see Guidelines
        /// and quotas in Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateProjectVersion">REST API Reference for CreateProjectVersion Operation</seealso>
        public virtual Task<CreateProjectVersionResponse> CreateProjectVersionAsync(CreateProjectVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProjectVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProjectVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateStreamProcessor

        internal virtual CreateStreamProcessorResponse CreateStreamProcessor(CreateStreamProcessorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamProcessorResponseUnmarshaller.Instance;

            return Invoke<CreateStreamProcessorResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Rekognition stream processor that you can use to detect and recognize
        /// faces or to detect labels in a streaming video.
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition Video is a consumer of live video from Amazon Kinesis Video Streams.
        /// There are two different settings for stream processors in Amazon Rekognition: detecting
        /// faces and detecting labels.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are creating a stream processor for detecting faces, you provide as input a
        /// Kinesis video stream (<c>Input</c>) and a Kinesis data stream (<c>Output</c>) stream
        /// for receiving the output. You must use the <c>FaceSearch</c> option in <c>Settings</c>,
        /// specifying the collection that contains the faces you want to recognize. After you
        /// have finished analyzing a streaming video, use <a>StopStreamProcessor</a> to stop
        /// processing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are creating a stream processor to detect labels, you provide as input a Kinesis
        /// video stream (<c>Input</c>), Amazon S3 bucket information (<c>Output</c>), and an
        /// Amazon SNS topic ARN (<c>NotificationChannel</c>). You can also provide a KMS key
        /// ID to encrypt the data sent to your Amazon S3 bucket. You specify what you want to
        /// detect by using the <c>ConnectedHome</c> option in settings, and selecting one of
        /// the following: <c>PERSON</c>, <c>PET</c>, <c>PACKAGE</c>, <c>ALL</c> You can also
        /// specify where in the frame you want Amazon Rekognition to monitor with <c>RegionsOfInterest</c>.
        /// When you run the <a>StartStreamProcessor</a> operation on a label detection stream
        /// processor, you input start and stop information to determine the length of the processing
        /// time.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Use <c>Name</c> to assign an identifier for the stream processor. You use <c>Name</c>
        /// to manage the stream processor. For example, you can start processing the source video
        /// by calling <a>StartStreamProcessor</a> with the <c>Name</c> field. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:CreateStreamProcessor</c>
        /// action. If you want to tag your stream processor, you also require permission to perform
        /// the <c>rekognition:TagResource</c> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamProcessor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStreamProcessor service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// jobs concurrently, subsequent calls to start operations (ex: <c>StartLabelDetection</c>)
        /// will raise a <c>LimitExceededException</c> exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Rekognition service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ServiceQuotaExceededException">
        /// The size of the collection exceeds the allowed limit. For more information, see Guidelines
        /// and quotas in Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateStreamProcessor">REST API Reference for CreateStreamProcessor Operation</seealso>
        public virtual Task<CreateStreamProcessorResponse> CreateStreamProcessorAsync(CreateStreamProcessorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamProcessorResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStreamProcessorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateUser

        internal virtual CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserResponse>(request, options);
        }



        /// <summary>
        /// Creates a new User within a collection specified by <c>CollectionId</c>. Takes <c>UserId</c>
        /// as a parameter, which is a user provided ID which should be unique within the collection.
        /// The provided <c>UserId</c> will alias the system generated UUID to make the <c>UserId</c>
        /// more user friendly. 
        /// 
        ///  
        /// <para>
        /// Uses a <c>ClientToken</c>, an idempotency token that ensures a call to <c>CreateUser</c>
        /// completes only once. If the value is not supplied, the AWS SDK generates an idempotency
        /// token for the requests. This prevents retries after a network error results from making
        /// multiple <c>CreateUser</c> calls. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ConflictException">
        /// A User with the same Id already exists within the collection, or the update or deletion
        /// of the User caused an inconsistent state. **
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <c>ClientRequestToken</c> input parameter was reused with an operation, but at least
        /// one of the other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ServiceQuotaExceededException">
        /// The size of the collection exceeds the allowed limit. For more information, see Guidelines
        /// and quotas in Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCollection

        internal virtual DeleteCollectionResponse DeleteCollection(DeleteCollectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCollectionResponseUnmarshaller.Instance;

            return Invoke<DeleteCollectionResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified collection. Note that this operation removes all faces in the
        /// collection. For an example, see <a href="https://docs.aws.amazon.com/rekognition/latest/dg/delete-collection-procedure.html">Deleting
        /// a collection</a>.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:DeleteCollection</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCollection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteCollection">REST API Reference for DeleteCollection Operation</seealso>
        public virtual Task<DeleteCollectionResponse> DeleteCollectionAsync(DeleteCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCollectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCollectionResponse>(request, options, cancellationToken);
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
        /// <note> 
        /// <para>
        /// This operation applies only to Amazon Rekognition Custom Labels.
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes an existing Amazon Rekognition Custom Labels dataset. Deleting a dataset might
        /// take while. Use <a>DescribeDataset</a> to check the current status. The dataset is
        /// still deleting if the value of <c>Status</c> is <c>DELETE_IN_PROGRESS</c>. If you
        /// try to access the dataset after it is deleted, you get a <c>ResourceNotFoundException</c>
        /// exception. 
        /// </para>
        ///  
        /// <para>
        /// You can't delete a dataset while it is creating (<c>Status</c> = <c>CREATE_IN_PROGRESS</c>)
        /// or if the dataset is updating (<c>Status</c> = <c>UPDATE_IN_PROGRESS</c>).
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:DeleteDataset</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// jobs concurrently, subsequent calls to start operations (ex: <c>StartLabelDetection</c>)
        /// will raise a <c>LimitExceededException</c> exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Rekognition service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatasetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFaces

        internal virtual DeleteFacesResponse DeleteFaces(DeleteFacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFacesResponseUnmarshaller.Instance;

            return Invoke<DeleteFacesResponse>(request, options);
        }



        /// <summary>
        /// Deletes faces from a collection. You specify a collection ID and an array of face
        /// IDs to remove from the collection.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:DeleteFaces</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFaces service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteFaces">REST API Reference for DeleteFaces Operation</seealso>
        public virtual Task<DeleteFacesResponse> DeleteFacesAsync(DeleteFacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFacesResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFacesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteProject

        internal virtual DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectResponse>(request, options);
        }



        /// <summary>
        /// Deletes a Amazon Rekognition project. To delete a project you must first delete all
        /// models or adapters associated with the project. To delete a model or adapter, see
        /// <a>DeleteProjectVersion</a>.
        /// 
        ///  
        /// <para>
        ///  <c>DeleteProject</c> is an asynchronous operation. To check if the project is deleted,
        /// call <a>DescribeProjects</a>. The project is deleted when the project no longer appears
        /// in the response. Be aware that deleting a given project will also delete any <c>ProjectPolicies</c>
        /// associated with that project.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:DeleteProject</c>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteProjectPolicy

        internal virtual DeleteProjectPolicyResponse DeleteProjectPolicy(DeleteProjectPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectPolicyResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This operation applies only to Amazon Rekognition Custom Labels.
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes an existing project policy.
        /// </para>
        ///  
        /// <para>
        /// To get a list of project policies attached to a project, call <a>ListProjectPolicies</a>.
        /// To attach a project policy to a project, call <a>PutProjectPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:DeleteProjectPolicy</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProjectPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProjectPolicy service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPolicyRevisionIdException">
        /// The supplied revision id for the project policy is invalid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteProjectPolicy">REST API Reference for DeleteProjectPolicy Operation</seealso>
        public virtual Task<DeleteProjectPolicyResponse> DeleteProjectPolicyAsync(DeleteProjectPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProjectPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteProjectVersion

        internal virtual DeleteProjectVersionResponse DeleteProjectVersion(DeleteProjectVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectVersionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a Rekognition project model or project version, like a Amazon Rekognition
        /// Custom Labels model or a custom adapter.
        /// 
        ///  
        /// <para>
        /// You can't delete a project version if it is running or if it is training. To check
        /// the status of a project version, use the Status field returned from <a>DescribeProjectVersions</a>.
        /// To stop a project version call <a>StopProjectVersion</a>. If the project version is
        /// training, wait until it finishes.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:DeleteProjectVersion</c>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProjectVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProjectVersion service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteProjectVersion">REST API Reference for DeleteProjectVersion Operation</seealso>
        public virtual Task<DeleteProjectVersionResponse> DeleteProjectVersionAsync(DeleteProjectVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProjectVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteStreamProcessor

        internal virtual DeleteStreamProcessorResponse DeleteStreamProcessor(DeleteStreamProcessorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamProcessorResponseUnmarshaller.Instance;

            return Invoke<DeleteStreamProcessorResponse>(request, options);
        }



        /// <summary>
        /// Deletes the stream processor identified by <c>Name</c>. You assign the value for <c>Name</c>
        /// when you create the stream processor with <a>CreateStreamProcessor</a>. You might
        /// not be able to use the same name for a stream processor for a few seconds after calling
        /// <c>DeleteStreamProcessor</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamProcessor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStreamProcessor service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteStreamProcessor">REST API Reference for DeleteStreamProcessor Operation</seealso>
        public virtual Task<DeleteStreamProcessorResponse> DeleteStreamProcessorAsync(DeleteStreamProcessorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamProcessorResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStreamProcessorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteUser

        internal virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified UserID within the collection. Faces that are associated with
        /// the UserID are disassociated from the UserID before deleting the specified UserID.
        /// If the specified <c>Collection</c> or <c>UserID</c> is already deleted or not found,
        /// a <c>ResourceNotFoundException</c> will be thrown. If the action is successful with
        /// a 200 response, an empty HTTP body is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ConflictException">
        /// A User with the same Id already exists within the collection, or the update or deletion
        /// of the User caused an inconsistent state. **
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <c>ClientRequestToken</c> input parameter was reused with an operation, but at least
        /// one of the other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeCollection

        internal virtual DescribeCollectionResponse DescribeCollection(DescribeCollectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCollectionResponseUnmarshaller.Instance;

            return Invoke<DescribeCollectionResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified collection. You can use <c>DescribeCollection</c> to get information,
        /// such as the number of faces indexed into a collection and the version of the model
        /// used by the collection for face detection.
        /// 
        ///  
        /// <para>
        /// For more information, see Describing a Collection in the Amazon Rekognition Developer
        /// Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCollection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeCollection">REST API Reference for DescribeCollection Operation</seealso>
        public virtual Task<DescribeCollectionResponse> DescribeCollectionAsync(DescribeCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCollectionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCollectionResponse>(request, options, cancellationToken);
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
        /// <note> 
        /// <para>
        /// This operation applies only to Amazon Rekognition Custom Labels.
        /// </para>
        ///  </note> 
        /// <para>
        ///  Describes an Amazon Rekognition Custom Labels dataset. You can get information such
        /// as the current status of a dataset and statistics about the images and labels in a
        /// dataset. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:DescribeDataset</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual Task<DescribeDatasetResponse> DescribeDatasetAsync(DescribeDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDatasetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeProjects

        internal virtual DescribeProjectsResponse DescribeProjects(DescribeProjectsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProjectsResponseUnmarshaller.Instance;

            return Invoke<DescribeProjectsResponse>(request, options);
        }



        /// <summary>
        /// Gets information about your Rekognition projects.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:DescribeProjects</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProjects service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeProjects">REST API Reference for DescribeProjects Operation</seealso>
        public virtual Task<DescribeProjectsResponse> DescribeProjectsAsync(DescribeProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProjectsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProjectsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeProjectVersions

        internal virtual DescribeProjectVersionsResponse DescribeProjectVersions(DescribeProjectVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProjectVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProjectVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeProjectVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists and describes the versions of an Amazon Rekognition project. You can specify
        /// up to 10 model or adapter versions in <c>ProjectVersionArns</c>. If you don't specify
        /// a value, descriptions for all model/adapter versions in the project are returned.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:DescribeProjectVersions</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProjectVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProjectVersions service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeProjectVersions">REST API Reference for DescribeProjectVersions Operation</seealso>
        public virtual Task<DescribeProjectVersionsResponse> DescribeProjectVersionsAsync(DescribeProjectVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProjectVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProjectVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProjectVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeStreamProcessor

        internal virtual DescribeStreamProcessorResponse DescribeStreamProcessor(DescribeStreamProcessorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamProcessorResponseUnmarshaller.Instance;

            return Invoke<DescribeStreamProcessorResponse>(request, options);
        }



        /// <summary>
        /// Provides information about a stream processor created by <a>CreateStreamProcessor</a>.
        /// You can get information about the input and output streams, the input parameters for
        /// the face recognition being performed, and the current status of the stream processor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStreamProcessor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStreamProcessor service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeStreamProcessor">REST API Reference for DescribeStreamProcessor Operation</seealso>
        public virtual Task<DescribeStreamProcessorResponse> DescribeStreamProcessorAsync(DescribeStreamProcessorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamProcessorResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStreamProcessorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DetectCustomLabels

        internal virtual DetectCustomLabelsResponse DetectCustomLabels(DetectCustomLabelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectCustomLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectCustomLabelsResponseUnmarshaller.Instance;

            return Invoke<DetectCustomLabelsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This operation applies only to Amazon Rekognition Custom Labels.
        /// </para>
        ///  </note> 
        /// <para>
        /// Detects custom labels in a supplied image by using an Amazon Rekognition Custom Labels
        /// model. 
        /// </para>
        ///  
        /// <para>
        /// You specify which version of a model version to use by using the <c>ProjectVersionArn</c>
        /// input parameter. 
        /// </para>
        ///  
        /// <para>
        /// You pass the input image as base64-encoded image bytes or as a reference to an image
        /// in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition operations,
        /// passing image bytes is not supported. The image must be either a PNG or JPEG formatted
        /// file. 
        /// </para>
        ///  
        /// <para>
        ///  For each object that the model version detects on an image, the API returns a (<c>CustomLabel</c>)
        /// object in an array (<c>CustomLabels</c>). Each <c>CustomLabel</c> object provides
        /// the label name (<c>Name</c>), the level of confidence that the image contains the
        /// object (<c>Confidence</c>), and object location information, if it exists, for the
        /// label on the image (<c>Geometry</c>). 
        /// </para>
        ///  
        /// <para>
        /// To filter labels that are returned, specify a value for <c>MinConfidence</c>. <c>DetectCustomLabelsLabels</c>
        /// only returns labels with a confidence that's higher than the specified value. The
        /// value of <c>MinConfidence</c> maps to the assumed threshold values created during
        /// training. For more information, see <i>Assumed threshold</i> in the Amazon Rekognition
        /// Custom Labels Developer Guide. Amazon Rekognition Custom Labels metrics expresses
        /// an assumed threshold as a floating point value between 0-1. The range of <c>MinConfidence</c>
        /// normalizes the threshold value to a percentage value (0-100). Confidence responses
        /// from <c>DetectCustomLabels</c> are also returned as a percentage. You can use <c>MinConfidence</c>
        /// to change the precision and recall or your model. For more information, see <i>Analyzing
        /// an image</i> in the Amazon Rekognition Custom Labels Developer Guide. 
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for <c>MinConfidence</c>, <c>DetectCustomLabels</c> returns
        /// labels based on the assumed threshold of each label.
        /// </para>
        ///  
        /// <para>
        /// This is a stateless API operation. That is, the operation does not persist any data.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:DetectCustomLabels</c>
        /// action. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <i>Analyzing an image</i> in the Amazon Rekognition Custom
        /// Labels Developer Guide. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectCustomLabels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectCustomLabels service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. If you are calling DetectProtectiveEquipment,
        /// the image size or resolution exceeds the allowed limit. For more information, see
        /// Guidelines and quotas in Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// jobs concurrently, subsequent calls to start operations (ex: <c>StartLabelDetection</c>)
        /// will raise a <c>LimitExceededException</c> exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Rekognition service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotReadyException">
        /// The requested resource isn't ready. For example, this exception occurs when you call
        /// <c>DetectCustomLabels</c> with a model version that isn't deployed.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectCustomLabels">REST API Reference for DetectCustomLabels Operation</seealso>
        public virtual Task<DetectCustomLabelsResponse> DetectCustomLabelsAsync(DetectCustomLabelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectCustomLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectCustomLabelsResponseUnmarshaller.Instance;

            return InvokeAsync<DetectCustomLabelsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DetectFaces

        internal virtual DetectFacesResponse DetectFaces(DetectFacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectFacesResponseUnmarshaller.Instance;

            return Invoke<DetectFacesResponse>(request, options);
        }



        /// <summary>
        /// Detects faces within an image that is provided as input.
        /// 
        ///  
        /// <para>
        ///  <c>DetectFaces</c> detects the 100 largest faces in the image. For each face detected,
        /// the operation returns face details. These details include a bounding box of the face,
        /// a confidence value (that the bounding box contains a face), and a fixed set of attributes
        /// such as facial landmarks (for example, coordinates of eye and mouth), pose, presence
        /// of facial occlusion, and so on.
        /// </para>
        ///  
        /// <para>
        /// The face-detection algorithm is most effective on frontal faces. For non-frontal or
        /// obscured faces, the algorithm might not detect the faces or might detect faces with
        /// lower confidence. 
        /// </para>
        ///  
        /// <para>
        /// You pass the input image either as base64-encoded image bytes or as a reference to
        /// an image in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition
        /// operations, passing image bytes is not supported. The image must be either a PNG or
        /// JPEG formatted file. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This is a stateless API operation. That is, the operation does not persist any data.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:DetectFaces</c>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectFaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectFaces service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. If you are calling DetectProtectiveEquipment,
        /// the image size or resolution exceeds the allowed limit. For more information, see
        /// Guidelines and quotas in Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectFaces">REST API Reference for DetectFaces Operation</seealso>
        public virtual Task<DetectFacesResponse> DetectFacesAsync(DetectFacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectFacesResponseUnmarshaller.Instance;

            return InvokeAsync<DetectFacesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DetectLabels

        internal virtual DetectLabelsResponse DetectLabels(DetectLabelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectLabelsResponseUnmarshaller.Instance;

            return Invoke<DetectLabelsResponse>(request, options);
        }



        /// <summary>
        /// Detects instances of real-world entities within an image (JPEG or PNG) provided as
        /// input. This includes objects like flower, tree, and table; events like wedding, graduation,
        /// and birthday party; and concepts like landscape, evening, and nature. 
        /// 
        ///  
        /// <para>
        /// For an example, see Analyzing images stored in an Amazon S3 bucket in the Amazon Rekognition
        /// Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// You pass the input image as base64-encoded image bytes or as a reference to an image
        /// in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition operations,
        /// passing image bytes is not supported. The image must be either a PNG or JPEG formatted
        /// file. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Optional Parameters</b> 
        /// </para>
        ///  
        /// <para>
        /// You can specify one or both of the <c>GENERAL_LABELS</c> and <c>IMAGE_PROPERTIES</c>
        /// feature types when calling the DetectLabels API. Including <c>GENERAL_LABELS</c> will
        /// ensure the response includes the labels detected in the input image, while including
        /// <c>IMAGE_PROPERTIES </c>will ensure the response includes information about the image
        /// quality and color.
        /// </para>
        ///  
        /// <para>
        /// When using <c>GENERAL_LABELS</c> and/or <c>IMAGE_PROPERTIES</c> you can provide filtering
        /// criteria to the Settings parameter. You can filter with sets of individual labels
        /// or with label categories. You can specify inclusive filters, exclusive filters, or
        /// a combination of inclusive and exclusive filters. For more information on filtering
        /// see <a href="https://docs.aws.amazon.com/rekognition/latest/dg/labels-detect-labels-image.html">Detecting
        /// Labels in an Image</a>.
        /// </para>
        ///  
        /// <para>
        /// When getting labels, you can specify <c>MinConfidence</c> to control the confidence
        /// threshold for the labels returned. The default is 55%. You can also add the <c>MaxLabels</c>
        /// parameter to limit the number of labels returned. The default and upper limit is 1000
        /// labels. These arguments are only valid when supplying GENERAL_LABELS as a feature
        /// type.
        /// </para>
        ///  
        /// <para>
        ///  <b>Response Elements</b> 
        /// </para>
        ///  
        /// <para>
        ///  For each object, scene, and concept the API returns one or more labels. The API returns
        /// the following types of information about labels:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Name - The name of the detected label. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Confidence - The level of confidence in the label assigned to a detected object.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Parents - The ancestor labels for a detected label. DetectLabels returns a hierarchical
        /// taxonomy of detected labels. For example, a detected car might be assigned the label
        /// car. The label car has two parent labels: Vehicle (its parent) and Transportation
        /// (its grandparent). The response includes the all ancestors for a label, where every
        /// ancestor is a unique label. In the previous example, Car, Vehicle, and Transportation
        /// are returned as unique labels in the response. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Aliases - Possible Aliases for the label. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Categories - The label categories that the detected label belongs to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  BoundingBox — Bounding boxes are described for all instances of detected common object
        /// labels, returned in an array of Instance objects. An Instance object contains a BoundingBox
        /// object, describing the location of the label on the input image. It also includes
        /// the confidence for the accuracy of the detected bounding box. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  The API returns the following information regarding the image, as part of the ImageProperties
        /// structure:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Quality - Information about the Sharpness, Brightness, and Contrast of the input image,
        /// scored between 0 to 100. Image quality is returned for the entire image, as well as
        /// the background and the foreground. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Dominant Color - An array of the dominant colors in the image. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Foreground - Information about the sharpness, brightness, and dominant colors of the
        /// input image’s foreground. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Background - Information about the sharpness, brightness, and dominant colors of the
        /// input image’s background.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The list of returned labels will include at least one label for every detected object,
        /// along with information about that label. In the following example, suppose the input
        /// image has a lighthouse, the sea, and a rock. The response includes all three labels,
        /// one for each object, as well as the confidence in the label:
        /// </para>
        ///  
        /// <para>
        ///  <c>{Name: lighthouse, Confidence: 98.4629}</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>{Name: rock,Confidence: 79.2097}</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> {Name: sea,Confidence: 75.061}</c> 
        /// </para>
        ///  
        /// <para>
        /// The list of labels can include multiple labels for the same object. For example, if
        /// the input image shows a flower (for example, a tulip), the operation might return
        /// the following three labels. 
        /// </para>
        ///  
        /// <para>
        ///  <c>{Name: flower,Confidence: 99.0562}</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>{Name: plant,Confidence: 99.0562}</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>{Name: tulip,Confidence: 99.0562}</c> 
        /// </para>
        ///  
        /// <para>
        /// In this example, the detection algorithm more precisely identifies the flower as a
        /// tulip.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the object detected is a person, the operation doesn't provide the same facial
        /// details that the <a>DetectFaces</a> operation provides.
        /// </para>
        ///  </note> 
        /// <para>
        /// This is a stateless API operation that doesn't return any data.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:DetectLabels</c>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectLabels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectLabels service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. If you are calling DetectProtectiveEquipment,
        /// the image size or resolution exceeds the allowed limit. For more information, see
        /// Guidelines and quotas in Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectLabels">REST API Reference for DetectLabels Operation</seealso>
        public virtual Task<DetectLabelsResponse> DetectLabelsAsync(DetectLabelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectLabelsResponseUnmarshaller.Instance;

            return InvokeAsync<DetectLabelsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DetectModerationLabels

        internal virtual DetectModerationLabelsResponse DetectModerationLabels(DetectModerationLabelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectModerationLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectModerationLabelsResponseUnmarshaller.Instance;

            return Invoke<DetectModerationLabelsResponse>(request, options);
        }



        /// <summary>
        /// Detects unsafe content in a specified JPEG or PNG format image. Use <c>DetectModerationLabels</c>
        /// to moderate images depending on your requirements. For example, you might want to
        /// filter images that contain nudity, but not images containing suggestive content.
        /// 
        ///  
        /// <para>
        /// To filter images, use the labels returned by <c>DetectModerationLabels</c> to determine
        /// which types of content are appropriate.
        /// </para>
        ///  
        /// <para>
        /// For information about moderation labels, see Detecting Unsafe Content in the Amazon
        /// Rekognition Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// You pass the input image either as base64-encoded image bytes or as a reference to
        /// an image in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition
        /// operations, passing image bytes is not supported. The image must be either a PNG or
        /// JPEG formatted file. 
        /// </para>
        ///  
        /// <para>
        /// You can specify an adapter to use when retrieving label predictions by providing a
        /// <c>ProjectVersionArn</c> to the <c>ProjectVersion</c> argument.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectModerationLabels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectModerationLabels service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.HumanLoopQuotaExceededException">
        /// The number of in-progress human reviews you have has exceeded the number allowed.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. If you are calling DetectProtectiveEquipment,
        /// the image size or resolution exceeds the allowed limit. For more information, see
        /// Guidelines and quotas in Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotReadyException">
        /// The requested resource isn't ready. For example, this exception occurs when you call
        /// <c>DetectCustomLabels</c> with a model version that isn't deployed.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectModerationLabels">REST API Reference for DetectModerationLabels Operation</seealso>
        public virtual Task<DetectModerationLabelsResponse> DetectModerationLabelsAsync(DetectModerationLabelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectModerationLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectModerationLabelsResponseUnmarshaller.Instance;

            return InvokeAsync<DetectModerationLabelsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DetectProtectiveEquipment

        internal virtual DetectProtectiveEquipmentResponse DetectProtectiveEquipment(DetectProtectiveEquipmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectProtectiveEquipmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectProtectiveEquipmentResponseUnmarshaller.Instance;

            return Invoke<DetectProtectiveEquipmentResponse>(request, options);
        }



        /// <summary>
        /// Detects Personal Protective Equipment (PPE) worn by people detected in an image. Amazon
        /// Rekognition can detect the following types of PPE.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Face cover
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Hand cover
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Head cover
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You pass the input image as base64-encoded image bytes or as a reference to an image
        /// in an Amazon S3 bucket. The image must be either a PNG or JPG formatted file. 
        /// </para>
        ///  
        /// <para>
        ///  <c>DetectProtectiveEquipment</c> detects PPE worn by up to 15 persons detected in
        /// an image.
        /// </para>
        ///  
        /// <para>
        /// For each person detected in the image the API returns an array of body parts (face,
        /// head, left-hand, right-hand). For each body part, an array of detected items of PPE
        /// is returned, including an indicator of whether or not the PPE covers the body part.
        /// The API returns the confidence it has in each detection (person, PPE, body part and
        /// body part coverage). It also returns a bounding box (<a>BoundingBox</a>) for each
        /// detected person and each detected item of PPE. 
        /// </para>
        ///  
        /// <para>
        /// You can optionally request a summary of detected PPE items with the <c>SummarizationAttributes</c>
        /// input parameter. The summary provides the following information. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The persons detected as wearing all of the types of PPE that you specify.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The persons detected as not wearing all of the types PPE that you specify.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The persons detected where PPE adornment could not be determined. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This is a stateless API operation. That is, the operation does not persist any data.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:DetectProtectiveEquipment</c>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectProtectiveEquipment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectProtectiveEquipment service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. If you are calling DetectProtectiveEquipment,
        /// the image size or resolution exceeds the allowed limit. For more information, see
        /// Guidelines and quotas in Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectProtectiveEquipment">REST API Reference for DetectProtectiveEquipment Operation</seealso>
        public virtual Task<DetectProtectiveEquipmentResponse> DetectProtectiveEquipmentAsync(DetectProtectiveEquipmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectProtectiveEquipmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectProtectiveEquipmentResponseUnmarshaller.Instance;

            return InvokeAsync<DetectProtectiveEquipmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DetectText

        internal virtual DetectTextResponse DetectText(DetectTextRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectTextResponseUnmarshaller.Instance;

            return Invoke<DetectTextResponse>(request, options);
        }



        /// <summary>
        /// Detects text in the input image and converts it into machine-readable text.
        /// 
        ///  
        /// <para>
        /// Pass the input image as base64-encoded image bytes or as a reference to an image in
        /// an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition operations,
        /// you must pass it as a reference to an image in an Amazon S3 bucket. For the AWS CLI,
        /// passing image bytes is not supported. The image must be either a .png or .jpeg formatted
        /// file. 
        /// </para>
        ///  
        /// <para>
        /// The <c>DetectText</c> operation returns text in an array of <a>TextDetection</a> elements,
        /// <c>TextDetections</c>. Each <c>TextDetection</c> element provides information about
        /// a single word or line of text that was detected in the image. 
        /// </para>
        ///  
        /// <para>
        /// A word is one or more script characters that are not separated by spaces. <c>DetectText</c>
        /// can detect up to 100 words in an image.
        /// </para>
        ///  
        /// <para>
        /// A line is a string of equally spaced words. A line isn't necessarily a complete sentence.
        /// For example, a driver's license number is detected as a line. A line ends when there
        /// is no aligned text after it. Also, a line ends when there is a large gap between words,
        /// relative to the length of the words. This means, depending on the gap between words,
        /// Amazon Rekognition may detect multiple lines in text aligned in the same direction.
        /// Periods don't represent the end of a line. If a sentence spans multiple lines, the
        /// <c>DetectText</c> operation returns multiple lines.
        /// </para>
        ///  
        /// <para>
        /// To determine whether a <c>TextDetection</c> element is a line of text or a word, use
        /// the <c>TextDetection</c> object <c>Type</c> field. 
        /// </para>
        ///  
        /// <para>
        /// To be detected, text must be within +/- 90 degrees orientation of the horizontal axis.
        /// </para>
        ///  
        /// <para>
        /// For more information, see Detecting text in the Amazon Rekognition Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectText service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectText service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. If you are calling DetectProtectiveEquipment,
        /// the image size or resolution exceeds the allowed limit. For more information, see
        /// Guidelines and quotas in Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectText">REST API Reference for DetectText Operation</seealso>
        public virtual Task<DetectTextResponse> DetectTextAsync(DetectTextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectTextResponseUnmarshaller.Instance;

            return InvokeAsync<DetectTextResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateFaces

        internal virtual DisassociateFacesResponse DisassociateFaces(DisassociateFacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFacesResponseUnmarshaller.Instance;

            return Invoke<DisassociateFacesResponse>(request, options);
        }



        /// <summary>
        /// Removes the association between a <c>Face</c> supplied in an array of <c>FaceIds</c>
        /// and the User. If the User is not present already, then a <c>ResourceNotFound</c> exception
        /// is thrown. If successful, an array of faces that are disassociated from the User is
        /// returned. If a given face is already disassociated from the given UserID, it will
        /// be ignored and not be returned in the response. If a given face is already associated
        /// with a different User or not found in the collection it will be returned as part of
        /// <c>UnsuccessfulDisassociations</c>. You can remove 1 - 100 face IDs from a user at
        /// one time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateFaces service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ConflictException">
        /// A User with the same Id already exists within the collection, or the update or deletion
        /// of the User caused an inconsistent state. **
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <c>ClientRequestToken</c> input parameter was reused with an operation, but at least
        /// one of the other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DisassociateFaces">REST API Reference for DisassociateFaces Operation</seealso>
        public virtual Task<DisassociateFacesResponse> DisassociateFacesAsync(DisassociateFacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFacesResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateFacesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DistributeDatasetEntries

        internal virtual DistributeDatasetEntriesResponse DistributeDatasetEntries(DistributeDatasetEntriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DistributeDatasetEntriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DistributeDatasetEntriesResponseUnmarshaller.Instance;

            return Invoke<DistributeDatasetEntriesResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This operation applies only to Amazon Rekognition Custom Labels.
        /// </para>
        ///  </note> 
        /// <para>
        /// Distributes the entries (images) in a training dataset across the training dataset
        /// and the test dataset for a project. <c>DistributeDatasetEntries</c> moves 20% of the
        /// training dataset images to the test dataset. An entry is a JSON Line that describes
        /// an image. 
        /// </para>
        ///  
        /// <para>
        /// You supply the Amazon Resource Names (ARN) of a project's training dataset and test
        /// dataset. The training dataset must contain the images that you want to split. The
        /// test dataset must be empty. The datasets must belong to the same project. To create
        /// training and test datasets for a project, call <a>CreateDataset</a>.
        /// </para>
        ///  
        /// <para>
        /// Distributing a dataset takes a while to complete. To check the status call <c>DescribeDataset</c>.
        /// The operation is complete when the <c>Status</c> field for the training dataset and
        /// the test dataset is <c>UPDATE_COMPLETE</c>. If the dataset split fails, the value
        /// of <c>Status</c> is <c>UPDATE_FAILED</c>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:DistributeDatasetEntries</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DistributeDatasetEntries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DistributeDatasetEntries service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotReadyException">
        /// The requested resource isn't ready. For example, this exception occurs when you call
        /// <c>DetectCustomLabels</c> with a model version that isn't deployed.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DistributeDatasetEntries">REST API Reference for DistributeDatasetEntries Operation</seealso>
        public virtual Task<DistributeDatasetEntriesResponse> DistributeDatasetEntriesAsync(DistributeDatasetEntriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DistributeDatasetEntriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DistributeDatasetEntriesResponseUnmarshaller.Instance;

            return InvokeAsync<DistributeDatasetEntriesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCelebrityInfo

        internal virtual GetCelebrityInfoResponse GetCelebrityInfo(GetCelebrityInfoRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCelebrityInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCelebrityInfoResponseUnmarshaller.Instance;

            return Invoke<GetCelebrityInfoResponse>(request, options);
        }



        /// <summary>
        /// Gets the name and additional information about a celebrity based on their Amazon Rekognition
        /// ID. The additional information is returned as an array of URLs. If there is no additional
        /// information about the celebrity, this list is empty.
        /// 
        ///  
        /// <para>
        /// For more information, see Getting information about a celebrity in the Amazon Rekognition
        /// Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:GetCelebrityInfo</c>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCelebrityInfo service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCelebrityInfo service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetCelebrityInfo">REST API Reference for GetCelebrityInfo Operation</seealso>
        public virtual Task<GetCelebrityInfoResponse> GetCelebrityInfoAsync(GetCelebrityInfoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCelebrityInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCelebrityInfoResponseUnmarshaller.Instance;

            return InvokeAsync<GetCelebrityInfoResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCelebrityRecognition

        internal virtual GetCelebrityRecognitionResponse GetCelebrityRecognition(GetCelebrityRecognitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCelebrityRecognitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCelebrityRecognitionResponseUnmarshaller.Instance;

            return Invoke<GetCelebrityRecognitionResponse>(request, options);
        }



        /// <summary>
        /// Gets the celebrity recognition results for a Amazon Rekognition Video analysis started
        /// by <a>StartCelebrityRecognition</a>.
        /// 
        ///  
        /// <para>
        /// Celebrity recognition in a video is an asynchronous operation. Analysis is started
        /// by a call to <a>StartCelebrityRecognition</a> which returns a job identifier (<c>JobId</c>).
        /// 
        /// </para>
        ///  
        /// <para>
        /// When the celebrity recognition operation finishes, Amazon Rekognition Video publishes
        /// a completion status to the Amazon Simple Notification Service topic registered in
        /// the initial call to <c>StartCelebrityRecognition</c>. To get the results of the celebrity
        /// recognition analysis, first check that the status value published to the Amazon SNS
        /// topic is <c>SUCCEEDED</c>. If so, call <c>GetCelebrityDetection</c> and pass the job
        /// identifier (<c>JobId</c>) from the initial call to <c>StartCelebrityDetection</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information, see Working With Stored Videos in the Amazon Rekognition Developer
        /// Guide.
        /// </para>
        ///  
        /// <para>
        ///  <c>GetCelebrityRecognition</c> returns detected celebrities and the time(s) they
        /// are detected in an array (<c>Celebrities</c>) of <a>CelebrityRecognition</a> objects.
        /// Each <c>CelebrityRecognition</c> contains information about the celebrity in a <a>CelebrityDetail</a>
        /// object and the time, <c>Timestamp</c>, the celebrity was detected. This <a>CelebrityDetail</a>
        /// object stores information about the detected celebrity's face attributes, a face bounding
        /// box, known gender, the celebrity's name, and a confidence estimate.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>GetCelebrityRecognition</c> only returns the default facial attributes (<c>BoundingBox</c>,
        /// <c>Confidence</c>, <c>Landmarks</c>, <c>Pose</c>, and <c>Quality</c>). The <c>BoundingBox</c>
        /// field only applies to the detected face instance. The other facial attributes listed
        /// in the <c>Face</c> object of the following response syntax are not returned. For more
        /// information, see FaceDetail in the Amazon Rekognition Developer Guide. 
        /// </para>
        ///  </note> 
        /// <para>
        /// By default, the <c>Celebrities</c> array is sorted by time (milliseconds from the
        /// start of the video). You can also sort the array by celebrity by specifying the value
        /// <c>ID</c> in the <c>SortBy</c> input parameter.
        /// </para>
        ///  
        /// <para>
        /// The <c>CelebrityDetail</c> object includes the celebrity identifer and additional
        /// information urls. If you don't store the additional information urls, you can get
        /// them later by calling <a>GetCelebrityInfo</a> with the celebrity identifer.
        /// </para>
        ///  
        /// <para>
        /// No information is returned for faces not recognized as celebrities.
        /// </para>
        ///  
        /// <para>
        /// Use MaxResults parameter to limit the number of labels returned. If there are more
        /// results than specified in <c>MaxResults</c>, the value of <c>NextToken</c> in the
        /// operation response contains a pagination token for getting the next set of results.
        /// To get the next page of results, call <c>GetCelebrityDetection</c> and populate the
        /// <c>NextToken</c> request parameter with the token value returned from the previous
        /// call to <c>GetCelebrityRecognition</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCelebrityRecognition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCelebrityRecognition service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetCelebrityRecognition">REST API Reference for GetCelebrityRecognition Operation</seealso>
        public virtual Task<GetCelebrityRecognitionResponse> GetCelebrityRecognitionAsync(GetCelebrityRecognitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCelebrityRecognitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCelebrityRecognitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetCelebrityRecognitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetContentModeration

        internal virtual GetContentModerationResponse GetContentModeration(GetContentModerationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContentModerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContentModerationResponseUnmarshaller.Instance;

            return Invoke<GetContentModerationResponse>(request, options);
        }



        /// <summary>
        /// Gets the inappropriate, unwanted, or offensive content analysis results for a Amazon
        /// Rekognition Video analysis started by <a>StartContentModeration</a>. For a list of
        /// moderation labels in Amazon Rekognition, see <a href="https://docs.aws.amazon.com/rekognition/latest/dg/moderation.html#moderation-api">Using
        /// the image and video moderation APIs</a>.
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition Video inappropriate or offensive content detection in a stored
        /// video is an asynchronous operation. You start analysis by calling <a>StartContentModeration</a>
        /// which returns a job identifier (<c>JobId</c>). When analysis finishes, Amazon Rekognition
        /// Video publishes a completion status to the Amazon Simple Notification Service topic
        /// registered in the initial call to <c>StartContentModeration</c>. To get the results
        /// of the content analysis, first check that the status value published to the Amazon
        /// SNS topic is <c>SUCCEEDED</c>. If so, call <c>GetContentModeration</c> and pass the
        /// job identifier (<c>JobId</c>) from the initial call to <c>StartContentModeration</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information, see Working with Stored Videos in the Amazon Rekognition Devlopers
        /// Guide.
        /// </para>
        ///  
        /// <para>
        ///  <c>GetContentModeration</c> returns detected inappropriate, unwanted, or offensive
        /// content moderation labels, and the time they are detected, in an array, <c>ModerationLabels</c>,
        /// of <a>ContentModerationDetection</a> objects. 
        /// </para>
        ///  
        /// <para>
        /// By default, the moderated labels are returned sorted by time, in milliseconds from
        /// the start of the video. You can also sort them by moderated label by specifying <c>NAME</c>
        /// for the <c>SortBy</c> input parameter. 
        /// </para>
        ///  
        /// <para>
        /// Since video analysis can return a large number of results, use the <c>MaxResults</c>
        /// parameter to limit the number of labels returned in a single call to <c>GetContentModeration</c>.
        /// If there are more results than specified in <c>MaxResults</c>, the value of <c>NextToken</c>
        /// in the operation response contains a pagination token for getting the next set of
        /// results. To get the next page of results, call <c>GetContentModeration</c> and populate
        /// the <c>NextToken</c> request parameter with the value of <c>NextToken</c> returned
        /// from the previous call to <c>GetContentModeration</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see moderating content in the Amazon Rekognition Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContentModeration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContentModeration service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetContentModeration">REST API Reference for GetContentModeration Operation</seealso>
        public virtual Task<GetContentModerationResponse> GetContentModerationAsync(GetContentModerationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContentModerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContentModerationResponseUnmarshaller.Instance;

            return InvokeAsync<GetContentModerationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFaceDetection

        internal virtual GetFaceDetectionResponse GetFaceDetection(GetFaceDetectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFaceDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFaceDetectionResponseUnmarshaller.Instance;

            return Invoke<GetFaceDetectionResponse>(request, options);
        }



        /// <summary>
        /// Gets face detection results for a Amazon Rekognition Video analysis started by <a>StartFaceDetection</a>.
        /// 
        ///  
        /// <para>
        /// Face detection with Amazon Rekognition Video is an asynchronous operation. You start
        /// face detection by calling <a>StartFaceDetection</a> which returns a job identifier
        /// (<c>JobId</c>). When the face detection operation finishes, Amazon Rekognition Video
        /// publishes a completion status to the Amazon Simple Notification Service topic registered
        /// in the initial call to <c>StartFaceDetection</c>. To get the results of the face detection
        /// operation, first check that the status value published to the Amazon SNS topic is
        /// <c>SUCCEEDED</c>. If so, call <a>GetFaceDetection</a> and pass the job identifier
        /// (<c>JobId</c>) from the initial call to <c>StartFaceDetection</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>GetFaceDetection</c> returns an array of detected faces (<c>Faces</c>) sorted
        /// by the time the faces were detected. 
        /// </para>
        ///  
        /// <para>
        /// Use MaxResults parameter to limit the number of labels returned. If there are more
        /// results than specified in <c>MaxResults</c>, the value of <c>NextToken</c> in the
        /// operation response contains a pagination token for getting the next set of results.
        /// To get the next page of results, call <c>GetFaceDetection</c> and populate the <c>NextToken</c>
        /// request parameter with the token value returned from the previous call to <c>GetFaceDetection</c>.
        /// </para>
        ///  
        /// <para>
        /// Note that for the <c>GetFaceDetection</c> operation, the returned values for <c>FaceOccluded</c>
        /// and <c>EyeDirection</c> will always be "null".
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFaceDetection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFaceDetection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetFaceDetection">REST API Reference for GetFaceDetection Operation</seealso>
        public virtual Task<GetFaceDetectionResponse> GetFaceDetectionAsync(GetFaceDetectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFaceDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFaceDetectionResponseUnmarshaller.Instance;

            return InvokeAsync<GetFaceDetectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFaceLivenessSessionResults

        internal virtual GetFaceLivenessSessionResultsResponse GetFaceLivenessSessionResults(GetFaceLivenessSessionResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFaceLivenessSessionResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFaceLivenessSessionResultsResponseUnmarshaller.Instance;

            return Invoke<GetFaceLivenessSessionResultsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the results of a specific Face Liveness session. It requires the <c>sessionId</c>
        /// as input, which was created using <c>CreateFaceLivenessSession</c>. Returns the corresponding
        /// Face Liveness confidence score, a reference image that includes a face bounding box,
        /// and audit images that also contain face bounding boxes. The Face Liveness confidence
        /// score ranges from 0 to 100. 
        /// 
        ///  
        /// <para>
        /// The number of audit images returned by <c>GetFaceLivenessSessionResults</c> is defined
        /// by the <c>AuditImagesLimit</c> paramater when calling <c>CreateFaceLivenessSession</c>.
        /// Reference images are always returned when possible.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFaceLivenessSessionResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFaceLivenessSessionResults service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.SessionNotFoundException">
        /// Occurs when a given sessionId is not found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetFaceLivenessSessionResults">REST API Reference for GetFaceLivenessSessionResults Operation</seealso>
        public virtual Task<GetFaceLivenessSessionResultsResponse> GetFaceLivenessSessionResultsAsync(GetFaceLivenessSessionResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFaceLivenessSessionResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFaceLivenessSessionResultsResponseUnmarshaller.Instance;

            return InvokeAsync<GetFaceLivenessSessionResultsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFaceSearch

        internal virtual GetFaceSearchResponse GetFaceSearch(GetFaceSearchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFaceSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFaceSearchResponseUnmarshaller.Instance;

            return Invoke<GetFaceSearchResponse>(request, options);
        }



        /// <summary>
        /// Gets the face search results for Amazon Rekognition Video face search started by <a>StartFaceSearch</a>.
        /// The search returns faces in a collection that match the faces of persons detected
        /// in a video. It also includes the time(s) that faces are matched in the video.
        /// 
        ///  
        /// <para>
        /// Face search in a video is an asynchronous operation. You start face search by calling
        /// to <a>StartFaceSearch</a> which returns a job identifier (<c>JobId</c>). When the
        /// search operation finishes, Amazon Rekognition Video publishes a completion status
        /// to the Amazon Simple Notification Service topic registered in the initial call to
        /// <c>StartFaceSearch</c>. To get the search results, first check that the status value
        /// published to the Amazon SNS topic is <c>SUCCEEDED</c>. If so, call <c>GetFaceSearch</c>
        /// and pass the job identifier (<c>JobId</c>) from the initial call to <c>StartFaceSearch</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see Searching Faces in a Collection in the Amazon Rekognition
        /// Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// The search results are retured in an array, <c>Persons</c>, of <a>PersonMatch</a>
        /// objects. Each<c>PersonMatch</c> element contains details about the matching faces
        /// in the input collection, person information (facial attributes, bounding boxes, and
        /// person identifer) for the matched person, and the time the person was matched in the
        /// video.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>GetFaceSearch</c> only returns the default facial attributes (<c>BoundingBox</c>,
        /// <c>Confidence</c>, <c>Landmarks</c>, <c>Pose</c>, and <c>Quality</c>). The other facial
        /// attributes listed in the <c>Face</c> object of the following response syntax are not
        /// returned. For more information, see FaceDetail in the Amazon Rekognition Developer
        /// Guide. 
        /// </para>
        ///  </note> 
        /// <para>
        /// By default, the <c>Persons</c> array is sorted by the time, in milliseconds from the
        /// start of the video, persons are matched. You can also sort by persons by specifying
        /// <c>INDEX</c> for the <c>SORTBY</c> input parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFaceSearch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFaceSearch service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetFaceSearch">REST API Reference for GetFaceSearch Operation</seealso>
        public virtual Task<GetFaceSearchResponse> GetFaceSearchAsync(GetFaceSearchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFaceSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFaceSearchResponseUnmarshaller.Instance;

            return InvokeAsync<GetFaceSearchResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetLabelDetection

        internal virtual GetLabelDetectionResponse GetLabelDetection(GetLabelDetectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLabelDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLabelDetectionResponseUnmarshaller.Instance;

            return Invoke<GetLabelDetectionResponse>(request, options);
        }



        /// <summary>
        /// Gets the label detection results of a Amazon Rekognition Video analysis started by
        /// <a>StartLabelDetection</a>. 
        /// 
        ///  
        /// <para>
        /// The label detection operation is started by a call to <a>StartLabelDetection</a> which
        /// returns a job identifier (<c>JobId</c>). When the label detection operation finishes,
        /// Amazon Rekognition publishes a completion status to the Amazon Simple Notification
        /// Service topic registered in the initial call to <c>StartlabelDetection</c>. 
        /// </para>
        ///  
        /// <para>
        /// To get the results of the label detection operation, first check that the status value
        /// published to the Amazon SNS topic is <c>SUCCEEDED</c>. If so, call <a>GetLabelDetection</a>
        /// and pass the job identifier (<c>JobId</c>) from the initial call to <c>StartLabelDetection</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>GetLabelDetection</c> returns an array of detected labels (<c>Labels</c>) sorted
        /// by the time the labels were detected. You can also sort by the label name by specifying
        /// <c>NAME</c> for the <c>SortBy</c> input parameter. If there is no <c>NAME</c> specified,
        /// the default sort is by timestamp.
        /// </para>
        ///  
        /// <para>
        /// You can select how results are aggregated by using the <c>AggregateBy</c> input parameter.
        /// The default aggregation method is <c>TIMESTAMPS</c>. You can also aggregate by <c>SEGMENTS</c>,
        /// which aggregates all instances of labels detected in a given segment. 
        /// </para>
        ///  
        /// <para>
        /// The returned Labels array may include the following attributes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Name - The name of the detected label.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Confidence - The level of confidence in the label assigned to a detected object. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Parents - The ancestor labels for a detected label. GetLabelDetection returns a hierarchical
        /// taxonomy of detected labels. For example, a detected car might be assigned the label
        /// car. The label car has two parent labels: Vehicle (its parent) and Transportation
        /// (its grandparent). The response includes the all ancestors for a label, where every
        /// ancestor is a unique label. In the previous example, Car, Vehicle, and Transportation
        /// are returned as unique labels in the response. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Aliases - Possible Aliases for the label. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Categories - The label categories that the detected label belongs to.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BoundingBox — Bounding boxes are described for all instances of detected common object
        /// labels, returned in an array of Instance objects. An Instance object contains a BoundingBox
        /// object, describing the location of the label on the input image. It also includes
        /// the confidence for the accuracy of the detected bounding box.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Timestamp - Time, in milliseconds from the start of the video, that the label was
        /// detected. For aggregation by <c>SEGMENTS</c>, the <c>StartTimestampMillis</c>, <c>EndTimestampMillis</c>,
        /// and <c>DurationMillis</c> structures are what define a segment. Although the “Timestamp”
        /// structure is still returned with each label, its value is set to be the same as <c>StartTimestampMillis</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Timestamp and Bounding box information are returned for detected Instances, only if
        /// aggregation is done by <c>TIMESTAMPS</c>. If aggregating by <c>SEGMENTS</c>, information
        /// about detected instances isn’t returned. 
        /// </para>
        ///  
        /// <para>
        /// The version of the label model used for the detection is also returned.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note <c>DominantColors</c> isn't returned for <c>Instances</c>, although it is
        /// shown as part of the response in the sample seen below.</b> 
        /// </para>
        ///  
        /// <para>
        /// Use <c>MaxResults</c> parameter to limit the number of labels returned. If there are
        /// more results than specified in <c>MaxResults</c>, the value of <c>NextToken</c> in
        /// the operation response contains a pagination token for getting the next set of results.
        /// To get the next page of results, call <c>GetlabelDetection</c> and populate the <c>NextToken</c>
        /// request parameter with the token value returned from the previous call to <c>GetLabelDetection</c>.
        /// </para>
        ///  
        /// <para>
        /// If you are retrieving results while using the Amazon Simple Notification Service,
        /// note that you will receive an "ERROR" notification if the job encounters an issue.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLabelDetection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLabelDetection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetLabelDetection">REST API Reference for GetLabelDetection Operation</seealso>
        public virtual Task<GetLabelDetectionResponse> GetLabelDetectionAsync(GetLabelDetectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLabelDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLabelDetectionResponseUnmarshaller.Instance;

            return InvokeAsync<GetLabelDetectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMediaAnalysisJob

        internal virtual GetMediaAnalysisJobResponse GetMediaAnalysisJob(GetMediaAnalysisJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMediaAnalysisJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaAnalysisJobResponseUnmarshaller.Instance;

            return Invoke<GetMediaAnalysisJobResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the results for a given media analysis job. Takes a <c>JobId</c> returned
        /// by StartMediaAnalysisJob.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMediaAnalysisJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMediaAnalysisJob service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetMediaAnalysisJob">REST API Reference for GetMediaAnalysisJob Operation</seealso>
        public virtual Task<GetMediaAnalysisJobResponse> GetMediaAnalysisJobAsync(GetMediaAnalysisJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMediaAnalysisJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaAnalysisJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetMediaAnalysisJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetPersonTracking

        internal virtual GetPersonTrackingResponse GetPersonTracking(GetPersonTrackingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPersonTrackingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPersonTrackingResponseUnmarshaller.Instance;

            return Invoke<GetPersonTrackingResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        ///  <i>End of support notice:</i> On October 31, 2025, AWS will discontinue support for
        /// Amazon Rekognition People Pathing. After October 31, 2025, you will no longer be able
        /// to use the Rekognition People Pathing capability. For more information, visit this
        /// <a href="https://aws.amazon.com/blogs/machine-learning/transitioning-from-amazon-rekognition-people-pathing-exploring-other-alternatives/">blog
        /// post</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Gets the path tracking results of a Amazon Rekognition Video analysis started by <a>StartPersonTracking</a>.
        /// </para>
        ///  
        /// <para>
        /// The person path tracking operation is started by a call to <c>StartPersonTracking</c>
        /// which returns a job identifier (<c>JobId</c>). When the operation finishes, Amazon
        /// Rekognition Video publishes a completion status to the Amazon Simple Notification
        /// Service topic registered in the initial call to <c>StartPersonTracking</c>.
        /// </para>
        ///  
        /// <para>
        /// To get the results of the person path tracking operation, first check that the status
        /// value published to the Amazon SNS topic is <c>SUCCEEDED</c>. If so, call <a>GetPersonTracking</a>
        /// and pass the job identifier (<c>JobId</c>) from the initial call to <c>StartPersonTracking</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>GetPersonTracking</c> returns an array, <c>Persons</c>, of tracked persons and
        /// the time(s) their paths were tracked in the video. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>GetPersonTracking</c> only returns the default facial attributes (<c>BoundingBox</c>,
        /// <c>Confidence</c>, <c>Landmarks</c>, <c>Pose</c>, and <c>Quality</c>). The other facial
        /// attributes listed in the <c>Face</c> object of the following response syntax are not
        /// returned. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see FaceDetail in the Amazon Rekognition Developer Guide.
        /// </para>
        ///  </note> 
        /// <para>
        /// By default, the array is sorted by the time(s) a person's path is tracked in the video.
        /// You can sort by tracked persons by specifying <c>INDEX</c> for the <c>SortBy</c> input
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>MaxResults</c> parameter to limit the number of items returned. If there
        /// are more results than specified in <c>MaxResults</c>, the value of <c>NextToken</c>
        /// in the operation response contains a pagination token for getting the next set of
        /// results. To get the next page of results, call <c>GetPersonTracking</c> and populate
        /// the <c>NextToken</c> request parameter with the token value returned from the previous
        /// call to <c>GetPersonTracking</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPersonTracking service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPersonTracking service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetPersonTracking">REST API Reference for GetPersonTracking Operation</seealso>
        public virtual Task<GetPersonTrackingResponse> GetPersonTrackingAsync(GetPersonTrackingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPersonTrackingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPersonTrackingResponseUnmarshaller.Instance;

            return InvokeAsync<GetPersonTrackingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSegmentDetection

        internal virtual GetSegmentDetectionResponse GetSegmentDetection(GetSegmentDetectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSegmentDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentDetectionResponseUnmarshaller.Instance;

            return Invoke<GetSegmentDetectionResponse>(request, options);
        }



        /// <summary>
        /// Gets the segment detection results of a Amazon Rekognition Video analysis started
        /// by <a>StartSegmentDetection</a>.
        /// 
        ///  
        /// <para>
        /// Segment detection with Amazon Rekognition Video is an asynchronous operation. You
        /// start segment detection by calling <a>StartSegmentDetection</a> which returns a job
        /// identifier (<c>JobId</c>). When the segment detection operation finishes, Amazon Rekognition
        /// publishes a completion status to the Amazon Simple Notification Service topic registered
        /// in the initial call to <c>StartSegmentDetection</c>. To get the results of the segment
        /// detection operation, first check that the status value published to the Amazon SNS
        /// topic is <c>SUCCEEDED</c>. if so, call <c>GetSegmentDetection</c> and pass the job
        /// identifier (<c>JobId</c>) from the initial call of <c>StartSegmentDetection</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>GetSegmentDetection</c> returns detected segments in an array (<c>Segments</c>)
        /// of <a>SegmentDetection</a> objects. <c>Segments</c> is sorted by the segment types
        /// specified in the <c>SegmentTypes</c> input parameter of <c>StartSegmentDetection</c>.
        /// Each element of the array includes the detected segment, the precentage confidence
        /// in the acuracy of the detected segment, the type of the segment, and the frame in
        /// which the segment was detected.
        /// </para>
        ///  
        /// <para>
        /// Use <c>SelectedSegmentTypes</c> to find out the type of segment detection requested
        /// in the call to <c>StartSegmentDetection</c>.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>MaxResults</c> parameter to limit the number of segment detections returned.
        /// If there are more results than specified in <c>MaxResults</c>, the value of <c>NextToken</c>
        /// in the operation response contains a pagination token for getting the next set of
        /// results. To get the next page of results, call <c>GetSegmentDetection</c> and populate
        /// the <c>NextToken</c> request parameter with the token value returned from the previous
        /// call to <c>GetSegmentDetection</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see Detecting video segments in stored video in the Amazon Rekognition
        /// Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentDetection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSegmentDetection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetSegmentDetection">REST API Reference for GetSegmentDetection Operation</seealso>
        public virtual Task<GetSegmentDetectionResponse> GetSegmentDetectionAsync(GetSegmentDetectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSegmentDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentDetectionResponseUnmarshaller.Instance;

            return InvokeAsync<GetSegmentDetectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTextDetection

        internal virtual GetTextDetectionResponse GetTextDetection(GetTextDetectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTextDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTextDetectionResponseUnmarshaller.Instance;

            return Invoke<GetTextDetectionResponse>(request, options);
        }



        /// <summary>
        /// Gets the text detection results of a Amazon Rekognition Video analysis started by
        /// <a>StartTextDetection</a>.
        /// 
        ///  
        /// <para>
        /// Text detection with Amazon Rekognition Video is an asynchronous operation. You start
        /// text detection by calling <a>StartTextDetection</a> which returns a job identifier
        /// (<c>JobId</c>) When the text detection operation finishes, Amazon Rekognition publishes
        /// a completion status to the Amazon Simple Notification Service topic registered in
        /// the initial call to <c>StartTextDetection</c>. To get the results of the text detection
        /// operation, first check that the status value published to the Amazon SNS topic is
        /// <c>SUCCEEDED</c>. if so, call <c>GetTextDetection</c> and pass the job identifier
        /// (<c>JobId</c>) from the initial call of <c>StartLabelDetection</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>GetTextDetection</c> returns an array of detected text (<c>TextDetections</c>)
        /// sorted by the time the text was detected, up to 100 words per frame of video.
        /// </para>
        ///  
        /// <para>
        /// Each element of the array includes the detected text, the precentage confidence in
        /// the acuracy of the detected text, the time the text was detected, bounding box information
        /// for where the text was located, and unique identifiers for words and their lines.
        /// </para>
        ///  
        /// <para>
        /// Use MaxResults parameter to limit the number of text detections returned. If there
        /// are more results than specified in <c>MaxResults</c>, the value of <c>NextToken</c>
        /// in the operation response contains a pagination token for getting the next set of
        /// results. To get the next page of results, call <c>GetTextDetection</c> and populate
        /// the <c>NextToken</c> request parameter with the token value returned from the previous
        /// call to <c>GetTextDetection</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTextDetection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTextDetection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetTextDetection">REST API Reference for GetTextDetection Operation</seealso>
        public virtual Task<GetTextDetectionResponse> GetTextDetectionAsync(GetTextDetectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTextDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTextDetectionResponseUnmarshaller.Instance;

            return InvokeAsync<GetTextDetectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  IndexFaces

        internal virtual IndexFacesResponse IndexFaces(IndexFacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = IndexFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IndexFacesResponseUnmarshaller.Instance;

            return Invoke<IndexFacesResponse>(request, options);
        }



        /// <summary>
        /// Detects faces in the input image and adds them to the specified collection. 
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition doesn't save the actual faces that are detected. Instead, the underlying
        /// detection algorithm first detects the faces in the input image. For each face, the
        /// algorithm extracts facial features into a feature vector, and stores it in the backend
        /// database. Amazon Rekognition uses feature vectors when it performs face match and
        /// search operations using the <a>SearchFaces</a> and <a>SearchFacesByImage</a> operations.
        /// </para>
        ///  
        /// <para>
        /// For more information, see Adding faces to a collection in the Amazon Rekognition Developer
        /// Guide.
        /// </para>
        ///  
        /// <para>
        /// To get the number of faces in a collection, call <a>DescribeCollection</a>. 
        /// </para>
        ///  
        /// <para>
        /// If you're using version 1.0 of the face detection model, <c>IndexFaces</c> indexes
        /// the 15 largest faces in the input image. Later versions of the face detection model
        /// index the 100 largest faces in the input image. 
        /// </para>
        ///  
        /// <para>
        /// If you're using version 4 or later of the face model, image orientation information
        /// is not returned in the <c>OrientationCorrection</c> field. 
        /// </para>
        ///  
        /// <para>
        /// To determine which version of the model you're using, call <a>DescribeCollection</a>
        /// and supply the collection ID. You can also get the model version from the value of
        /// <c>FaceModelVersion</c> in the response from <c>IndexFaces</c> 
        /// </para>
        ///  
        /// <para>
        /// For more information, see Model Versioning in the Amazon Rekognition Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// If you provide the optional <c>ExternalImageId</c> for the input image you provided,
        /// Amazon Rekognition associates this ID with all faces that it detects. When you call
        /// the <a>ListFaces</a> operation, the response returns the external ID. You can use
        /// this external image ID to create a client-side index to associate the faces with each
        /// image. You can then use the index to find all faces in an image.
        /// </para>
        ///  
        /// <para>
        /// You can specify the maximum number of faces to index with the <c>MaxFaces</c> input
        /// parameter. This is useful when you want to index the largest faces in an image and
        /// don't want to index smaller faces, such as those belonging to people standing in the
        /// background.
        /// </para>
        ///  
        /// <para>
        /// The <c>QualityFilter</c> input parameter allows you to filter out detected faces that
        /// don’t meet a required quality bar. The quality bar is based on a variety of common
        /// use cases. By default, <c>IndexFaces</c> chooses the quality bar that's used to filter
        /// faces. You can also explicitly choose the quality bar. Use <c>QualityFilter</c>, to
        /// set the quality bar by specifying <c>LOW</c>, <c>MEDIUM</c>, or <c>HIGH</c>. If you
        /// do not want to filter detected faces, specify <c>NONE</c>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To use quality filtering, you need a collection associated with version 3 of the face
        /// model or higher. To get the version of the face model associated with a collection,
        /// call <a>DescribeCollection</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Information about faces detected in an image, but not indexed, is returned in an array
        /// of <a>UnindexedFace</a> objects, <c>UnindexedFaces</c>. Faces aren't indexed for reasons
        /// such as:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The number of faces detected exceeds the value of the <c>MaxFaces</c> request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The face is too small compared to the image dimensions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The face is too blurry.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The image is too dark.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The face has an extreme pose.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The face doesn’t have enough detail to be suitable for face search.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In response, the <c>IndexFaces</c> operation returns an array of metadata for all
        /// detected faces, <c>FaceRecords</c>. This includes: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The bounding box, <c>BoundingBox</c>, of the detected face. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A confidence value, <c>Confidence</c>, which indicates the confidence that the bounding
        /// box contains a face.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A face ID, <c>FaceId</c>, assigned by the service for each face that's detected and
        /// stored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An image ID, <c>ImageId</c>, assigned by the service for the input image.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you request <c>ALL</c> or specific facial attributes (e.g., <c>FACE_OCCLUDED</c>)
        /// by using the detectionAttributes parameter, Amazon Rekognition returns detailed facial
        /// attributes, such as facial landmarks (for example, location of eye and mouth), facial
        /// occlusion, and other facial attributes.
        /// </para>
        ///  
        /// <para>
        /// If you provide the same image, specify the same collection, and use the same external
        /// ID in the <c>IndexFaces</c> operation, Amazon Rekognition doesn't save duplicate face
        /// metadata.
        /// </para>
        ///   
        /// <para>
        /// The input image is passed either as base64-encoded image bytes, or as a reference
        /// to an image in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition
        /// operations, passing image bytes isn't supported. The image must be formatted as a
        /// PNG or JPEG file. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:IndexFaces</c> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IndexFaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the IndexFaces service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. If you are calling DetectProtectiveEquipment,
        /// the image size or resolution exceeds the allowed limit. For more information, see
        /// Guidelines and quotas in Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ServiceQuotaExceededException">
        /// The size of the collection exceeds the allowed limit. For more information, see Guidelines
        /// and quotas in Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/IndexFaces">REST API Reference for IndexFaces Operation</seealso>
        public virtual Task<IndexFacesResponse> IndexFacesAsync(IndexFacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = IndexFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IndexFacesResponseUnmarshaller.Instance;

            return InvokeAsync<IndexFacesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCollections

        internal virtual ListCollectionsResponse ListCollections(ListCollectionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollectionsResponseUnmarshaller.Instance;

            return Invoke<ListCollectionsResponse>(request, options);
        }



        /// <summary>
        /// Returns list of collection IDs in your account. If the result is truncated, the response
        /// also provides a <c>NextToken</c> that you can use in the subsequent request to fetch
        /// the next set of collection IDs.
        /// 
        ///  
        /// <para>
        /// For an example, see Listing collections in the Amazon Rekognition Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:ListCollections</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCollections service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListCollections">REST API Reference for ListCollections Operation</seealso>
        public virtual Task<ListCollectionsResponse> ListCollectionsAsync(ListCollectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCollectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollectionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCollectionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDatasetEntries

        internal virtual ListDatasetEntriesResponse ListDatasetEntries(ListDatasetEntriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetEntriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetEntriesResponseUnmarshaller.Instance;

            return Invoke<ListDatasetEntriesResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This operation applies only to Amazon Rekognition Custom Labels.
        /// </para>
        ///  </note> 
        /// <para>
        ///  Lists the entries (images) within a dataset. An entry is a JSON Line that contains
        /// the information for a single image, including the image location, assigned labels,
        /// and object location bounding boxes. For more information, see <a href="https://docs.aws.amazon.com/rekognition/latest/customlabels-dg/md-manifest-files.html">Creating
        /// a manifest file</a>.
        /// </para>
        ///  
        /// <para>
        /// JSON Lines in the response include information about non-terminal errors found in
        /// the dataset. Non terminal errors are reported in <c>errors</c> lists within each JSON
        /// Line. The same information is reported in the training and testing validation result
        /// manifests that Amazon Rekognition Custom Labels creates during model training. 
        /// </para>
        ///  
        /// <para>
        /// You can filter the response in variety of ways, such as choosing which labels to return
        /// and returning JSON Lines created after a specific date. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:ListDatasetEntries</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetEntries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasetEntries service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotReadyException">
        /// The requested resource isn't ready. For example, this exception occurs when you call
        /// <c>DetectCustomLabels</c> with a model version that isn't deployed.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListDatasetEntries">REST API Reference for ListDatasetEntries Operation</seealso>
        public virtual Task<ListDatasetEntriesResponse> ListDatasetEntriesAsync(ListDatasetEntriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetEntriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetEntriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetEntriesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDatasetLabels

        internal virtual ListDatasetLabelsResponse ListDatasetLabels(ListDatasetLabelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetLabelsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetLabelsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This operation applies only to Amazon Rekognition Custom Labels.
        /// </para>
        ///  </note> 
        /// <para>
        /// Lists the labels in a dataset. Amazon Rekognition Custom Labels uses labels to describe
        /// images. For more information, see <a href="https://docs.aws.amazon.com/rekognition/latest/customlabels-dg/md-labeling-images.html">Labeling
        /// images</a>. 
        /// </para>
        ///  
        /// <para>
        ///  Lists the labels in a dataset. Amazon Rekognition Custom Labels uses labels to describe
        /// images. For more information, see Labeling images in the <i>Amazon Rekognition Custom
        /// Labels Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetLabels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasetLabels service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotReadyException">
        /// The requested resource isn't ready. For example, this exception occurs when you call
        /// <c>DetectCustomLabels</c> with a model version that isn't deployed.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListDatasetLabels">REST API Reference for ListDatasetLabels Operation</seealso>
        public virtual Task<ListDatasetLabelsResponse> ListDatasetLabelsAsync(ListDatasetLabelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetLabelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetLabelsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFaces

        internal virtual ListFacesResponse ListFaces(ListFacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFacesResponseUnmarshaller.Instance;

            return Invoke<ListFacesResponse>(request, options);
        }



        /// <summary>
        /// Returns metadata for faces in the specified collection. This metadata includes information
        /// such as the bounding box coordinates, the confidence (that the bounding box contains
        /// a face), and face ID. For an example, see Listing Faces in a Collection in the Amazon
        /// Rekognition Developer Guide.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:ListFaces</c> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFaces service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListFaces">REST API Reference for ListFaces Operation</seealso>
        public virtual Task<ListFacesResponse> ListFacesAsync(ListFacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFacesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFacesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMediaAnalysisJobs

        internal virtual ListMediaAnalysisJobsResponse ListMediaAnalysisJobs(ListMediaAnalysisJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMediaAnalysisJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMediaAnalysisJobsResponseUnmarshaller.Instance;

            return Invoke<ListMediaAnalysisJobsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of media analysis jobs. Results are sorted by <c>CreationTimestamp</c>
        /// in descending order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMediaAnalysisJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMediaAnalysisJobs service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListMediaAnalysisJobs">REST API Reference for ListMediaAnalysisJobs Operation</seealso>
        public virtual Task<ListMediaAnalysisJobsResponse> ListMediaAnalysisJobsAsync(ListMediaAnalysisJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMediaAnalysisJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMediaAnalysisJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMediaAnalysisJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListProjectPolicies

        internal virtual ListProjectPoliciesResponse ListProjectPolicies(ListProjectPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProjectPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListProjectPoliciesResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This operation applies only to Amazon Rekognition Custom Labels.
        /// </para>
        ///  </note> 
        /// <para>
        /// Gets a list of the project policies attached to a project.
        /// </para>
        ///  
        /// <para>
        /// To attach a project policy to a project, call <a>PutProjectPolicy</a>. To remove a
        /// project policy from a project, call <a>DeleteProjectPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:ListProjectPolicies</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjectPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProjectPolicies service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListProjectPolicies">REST API Reference for ListProjectPolicies Operation</seealso>
        public virtual Task<ListProjectPoliciesResponse> ListProjectPoliciesAsync(ListProjectPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProjectPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListProjectPoliciesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListStreamProcessors

        internal virtual ListStreamProcessorsResponse ListStreamProcessors(ListStreamProcessorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStreamProcessorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamProcessorsResponseUnmarshaller.Instance;

            return Invoke<ListStreamProcessorsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of stream processors that you have created with <a>CreateStreamProcessor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamProcessors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStreamProcessors service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListStreamProcessors">REST API Reference for ListStreamProcessors Operation</seealso>
        public virtual Task<ListStreamProcessorsResponse> ListStreamProcessorsAsync(ListStreamProcessorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStreamProcessorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamProcessorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStreamProcessorsResponse>(request, options, cancellationToken);
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
        /// Returns a list of tags in an Amazon Rekognition collection, stream processor, or
        /// Custom Labels model. 
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:ListTagsForResource</c>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListUsers

        internal virtual ListUsersResponse ListUsers(ListUsersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersResponse>(request, options);
        }



        /// <summary>
        /// Returns metadata of the User such as <c>UserID</c> in the specified collection. Anonymous
        /// User (to reserve faces without any identity) is not returned as part of this request.
        /// The results are sorted by system generated primary key ID. If the response is truncated,
        /// <c>NextToken</c> is returned in the response that can be used in the subsequent request
        /// to retrieve the next set of identities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return InvokeAsync<ListUsersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutProjectPolicy

        internal virtual PutProjectPolicyResponse PutProjectPolicy(PutProjectPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutProjectPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProjectPolicyResponseUnmarshaller.Instance;

            return Invoke<PutProjectPolicyResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This operation applies only to Amazon Rekognition Custom Labels.
        /// </para>
        ///  </note> 
        /// <para>
        /// Attaches a project policy to a Amazon Rekognition Custom Labels project in a trusting
        /// AWS account. A project policy specifies that a trusted AWS account can copy a model
        /// version from a trusting AWS account to a project in the trusted AWS account. To copy
        /// a model version you use the <a>CopyProjectVersion</a> operation. Only applies to Custom
        /// Labels projects.
        /// </para>
        ///  
        /// <para>
        /// For more information about the format of a project policy document, see Attaching
        /// a project policy (SDK) in the <i>Amazon Rekognition Custom Labels Developer Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The response from <c>PutProjectPolicy</c> is a revision ID for the project policy.
        /// You can attach multiple project policies to a project. You can also update an existing
        /// project policy by specifying the policy revision ID of the existing policy.
        /// </para>
        ///  
        /// <para>
        /// To remove a project policy from a project, call <a>DeleteProjectPolicy</a>. To get
        /// a list of project policies attached to a project, call <a>ListProjectPolicies</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You copy a model version by calling <a>CopyProjectVersion</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:PutProjectPolicy</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProjectPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutProjectPolicy service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPolicyRevisionIdException">
        /// The supplied revision id for the project policy is invalid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// jobs concurrently, subsequent calls to start operations (ex: <c>StartLabelDetection</c>)
        /// will raise a <c>LimitExceededException</c> exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Rekognition service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.MalformedPolicyDocumentException">
        /// The format of the project policy document that you supplied to <c>PutProjectPolicy</c>
        /// is incorrect.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceAlreadyExistsException">
        /// A resource with the specified ID already exists.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ServiceQuotaExceededException">
        /// The size of the collection exceeds the allowed limit. For more information, see Guidelines
        /// and quotas in Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/PutProjectPolicy">REST API Reference for PutProjectPolicy Operation</seealso>
        public virtual Task<PutProjectPolicyResponse> PutProjectPolicyAsync(PutProjectPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutProjectPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProjectPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutProjectPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RecognizeCelebrities

        internal virtual RecognizeCelebritiesResponse RecognizeCelebrities(RecognizeCelebritiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RecognizeCelebritiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecognizeCelebritiesResponseUnmarshaller.Instance;

            return Invoke<RecognizeCelebritiesResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of celebrities recognized in the input image. For more information,
        /// see Recognizing celebrities in the Amazon Rekognition Developer Guide. 
        /// 
        ///  
        /// <para>
        ///  <c>RecognizeCelebrities</c> returns the 64 largest faces in the image. It lists the
        /// recognized celebrities in the <c>CelebrityFaces</c> array and any unrecognized faces
        /// in the <c>UnrecognizedFaces</c> array. <c>RecognizeCelebrities</c> doesn't return
        /// celebrities whose faces aren't among the largest 64 faces in the image.
        /// </para>
        ///  
        /// <para>
        /// For each celebrity recognized, <c>RecognizeCelebrities</c> returns a <c>Celebrity</c>
        /// object. The <c>Celebrity</c> object contains the celebrity name, ID, URL links to
        /// additional information, match confidence, and a <c>ComparedFace</c> object that you
        /// can use to locate the celebrity's face on the image.
        /// </para>
        ///  
        /// <para>
        /// Amazon Rekognition doesn't retain information about which images a celebrity has been
        /// recognized in. Your application must store this information and use the <c>Celebrity</c>
        /// ID property as a unique identifier for the celebrity. If you don't store the celebrity
        /// name or additional information URLs returned by <c>RecognizeCelebrities</c>, you will
        /// need the ID to identify the celebrity in a call to the <a>GetCelebrityInfo</a> operation.
        /// </para>
        ///  
        /// <para>
        /// You pass the input image either as base64-encoded image bytes or as a reference to
        /// an image in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition
        /// operations, passing image bytes is not supported. The image must be either a PNG or
        /// JPEG formatted file. 
        /// </para>
        ///  
        /// <para>
        /// For an example, see Recognizing celebrities in an image in the Amazon Rekognition
        /// Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:RecognizeCelebrities</c>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecognizeCelebrities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RecognizeCelebrities service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. If you are calling DetectProtectiveEquipment,
        /// the image size or resolution exceeds the allowed limit. For more information, see
        /// Guidelines and quotas in Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/RecognizeCelebrities">REST API Reference for RecognizeCelebrities Operation</seealso>
        public virtual Task<RecognizeCelebritiesResponse> RecognizeCelebritiesAsync(RecognizeCelebritiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RecognizeCelebritiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecognizeCelebritiesResponseUnmarshaller.Instance;

            return InvokeAsync<RecognizeCelebritiesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchFaces

        internal virtual SearchFacesResponse SearchFaces(SearchFacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFacesResponseUnmarshaller.Instance;

            return Invoke<SearchFacesResponse>(request, options);
        }



        /// <summary>
        /// For a given input face ID, searches for matching faces in the collection the face
        /// belongs to. You get a face ID when you add a face to the collection using the <a>IndexFaces</a>
        /// operation. The operation compares the features of the input face with faces in the
        /// specified collection. 
        /// 
        ///  <note> 
        /// <para>
        /// You can also search faces without indexing faces by using the <c>SearchFacesByImage</c>
        /// operation.
        /// </para>
        ///  </note> 
        /// <para>
        ///  The operation response returns an array of faces that match, ordered by similarity
        /// score with the highest similarity first. More specifically, it is an array of metadata
        /// for each face match that is found. Along with the metadata, the response also includes
        /// a <c>confidence</c> value for each face match, indicating the confidence that the
        /// specific face matches the input face. 
        /// </para>
        ///  
        /// <para>
        /// For an example, see Searching for a face using its face ID in the Amazon Rekognition
        /// Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:SearchFaces</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchFaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchFaces service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/SearchFaces">REST API Reference for SearchFaces Operation</seealso>
        public virtual Task<SearchFacesResponse> SearchFacesAsync(SearchFacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFacesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchFacesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchFacesByImage

        internal virtual SearchFacesByImageResponse SearchFacesByImage(SearchFacesByImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchFacesByImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFacesByImageResponseUnmarshaller.Instance;

            return Invoke<SearchFacesByImageResponse>(request, options);
        }



        /// <summary>
        /// For a given input image, first detects the largest face in the image, and then searches
        /// the specified collection for matching faces. The operation compares the features of
        /// the input face with faces in the specified collection. 
        /// 
        ///  <note> 
        /// <para>
        /// To search for all faces in an input image, you might first call the <a>IndexFaces</a>
        /// operation, and then use the face IDs returned in subsequent calls to the <a>SearchFaces</a>
        /// operation. 
        /// </para>
        ///  
        /// <para>
        ///  You can also call the <c>DetectFaces</c> operation and use the bounding boxes in
        /// the response to make face crops, which then you can pass in to the <c>SearchFacesByImage</c>
        /// operation. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You pass the input image either as base64-encoded image bytes or as a reference to
        /// an image in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition
        /// operations, passing image bytes is not supported. The image must be either a PNG or
        /// JPEG formatted file. 
        /// </para>
        ///  
        /// <para>
        ///  The response returns an array of faces that match, ordered by similarity score with
        /// the highest similarity first. More specifically, it is an array of metadata for each
        /// face match found. Along with the metadata, the response also includes a <c>similarity</c>
        /// indicating how similar the face is to the input face. In the response, the operation
        /// also returns the bounding box (and a confidence level that the bounding box contains
        /// a face) of the face that Amazon Rekognition used for the input image. 
        /// </para>
        ///  
        /// <para>
        /// If no faces are detected in the input image, <c>SearchFacesByImage</c> returns an
        /// <c>InvalidParameterException</c> error. 
        /// </para>
        ///  
        /// <para>
        /// For an example, Searching for a Face Using an Image in the Amazon Rekognition Developer
        /// Guide.
        /// </para>
        ///  
        /// <para>
        /// The <c>QualityFilter</c> input parameter allows you to filter out detected faces that
        /// don’t meet a required quality bar. The quality bar is based on a variety of common
        /// use cases. Use <c>QualityFilter</c> to set the quality bar for filtering by specifying
        /// <c>LOW</c>, <c>MEDIUM</c>, or <c>HIGH</c>. If you do not want to filter detected faces,
        /// specify <c>NONE</c>. The default value is <c>NONE</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To use quality filtering, you need a collection associated with version 3 of the face
        /// model or higher. To get the version of the face model associated with a collection,
        /// call <a>DescribeCollection</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:SearchFacesByImage</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchFacesByImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchFacesByImage service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. If you are calling DetectProtectiveEquipment,
        /// the image size or resolution exceeds the allowed limit. For more information, see
        /// Guidelines and quotas in Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/SearchFacesByImage">REST API Reference for SearchFacesByImage Operation</seealso>
        public virtual Task<SearchFacesByImageResponse> SearchFacesByImageAsync(SearchFacesByImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchFacesByImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFacesByImageResponseUnmarshaller.Instance;

            return InvokeAsync<SearchFacesByImageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchUsers

        internal virtual SearchUsersResponse SearchUsers(SearchUsersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchUsersResponseUnmarshaller.Instance;

            return Invoke<SearchUsersResponse>(request, options);
        }



        /// <summary>
        /// Searches for UserIDs within a collection based on a <c>FaceId</c> or <c>UserId</c>.
        /// This API can be used to find the closest UserID (with a highest similarity) to associate
        /// a face. The request must be provided with either <c>FaceId</c> or <c>UserId</c>. The
        /// operation returns an array of UserID that match the <c>FaceId</c> or <c>UserId</c>,
        /// ordered by similarity score with the highest similarity first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchUsers service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/SearchUsers">REST API Reference for SearchUsers Operation</seealso>
        public virtual Task<SearchUsersResponse> SearchUsersAsync(SearchUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchUsersResponseUnmarshaller.Instance;

            return InvokeAsync<SearchUsersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchUsersByImage

        internal virtual SearchUsersByImageResponse SearchUsersByImage(SearchUsersByImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchUsersByImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchUsersByImageResponseUnmarshaller.Instance;

            return Invoke<SearchUsersByImageResponse>(request, options);
        }



        /// <summary>
        /// Searches for UserIDs using a supplied image. It first detects the largest face in
        /// the image, and then searches a specified collection for matching UserIDs. 
        /// 
        ///  
        /// <para>
        /// The operation returns an array of UserIDs that match the face in the supplied image,
        /// ordered by similarity score with the highest similarity first. It also returns a bounding
        /// box for the face found in the input image. 
        /// </para>
        ///  
        /// <para>
        /// Information about faces detected in the supplied image, but not used for the search,
        /// is returned in an array of <c>UnsearchedFace</c> objects. If no valid face is detected
        /// in the image, the response will contain an empty <c>UserMatches</c> list and no <c>SearchedFace</c>
        /// object. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchUsersByImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchUsersByImage service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. If you are calling DetectProtectiveEquipment,
        /// the image size or resolution exceeds the allowed limit. For more information, see
        /// Guidelines and quotas in Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/SearchUsersByImage">REST API Reference for SearchUsersByImage Operation</seealso>
        public virtual Task<SearchUsersByImageResponse> SearchUsersByImageAsync(SearchUsersByImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchUsersByImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchUsersByImageResponseUnmarshaller.Instance;

            return InvokeAsync<SearchUsersByImageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartCelebrityRecognition

        internal virtual StartCelebrityRecognitionResponse StartCelebrityRecognition(StartCelebrityRecognitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCelebrityRecognitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCelebrityRecognitionResponseUnmarshaller.Instance;

            return Invoke<StartCelebrityRecognitionResponse>(request, options);
        }



        /// <summary>
        /// Starts asynchronous recognition of celebrities in a stored video.
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition Video can detect celebrities in a video must be stored in an Amazon
        /// S3 bucket. Use <a>Video</a> to specify the bucket name and the filename of the video.
        /// <c>StartCelebrityRecognition</c> returns a job identifier (<c>JobId</c>) which you
        /// use to get the results of the analysis. When celebrity recognition analysis is finished,
        /// Amazon Rekognition Video publishes a completion status to the Amazon Simple Notification
        /// Service topic that you specify in <c>NotificationChannel</c>. To get the results of
        /// the celebrity recognition analysis, first check that the status value published to
        /// the Amazon SNS topic is <c>SUCCEEDED</c>. If so, call <a>GetCelebrityRecognition</a>
        /// and pass the job identifier (<c>JobId</c>) from the initial call to <c>StartCelebrityRecognition</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information, see Recognizing celebrities in the Amazon Rekognition Developer
        /// Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCelebrityRecognition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCelebrityRecognition service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <c>ClientRequestToken</c> input parameter was reused with an operation, but at least
        /// one of the other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// jobs concurrently, subsequent calls to start operations (ex: <c>StartLabelDetection</c>)
        /// will raise a <c>LimitExceededException</c> exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Rekognition service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.VideoTooLargeException">
        /// The file size or duration of the supplied media is too large. The maximum file size
        /// is 10GB. The maximum duration is 6 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartCelebrityRecognition">REST API Reference for StartCelebrityRecognition Operation</seealso>
        public virtual Task<StartCelebrityRecognitionResponse> StartCelebrityRecognitionAsync(StartCelebrityRecognitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCelebrityRecognitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCelebrityRecognitionResponseUnmarshaller.Instance;

            return InvokeAsync<StartCelebrityRecognitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartContentModeration

        internal virtual StartContentModerationResponse StartContentModeration(StartContentModerationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartContentModerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartContentModerationResponseUnmarshaller.Instance;

            return Invoke<StartContentModerationResponse>(request, options);
        }



        /// <summary>
        /// Starts asynchronous detection of inappropriate, unwanted, or offensive content in
        /// a stored video. For a list of moderation labels in Amazon Rekognition, see <a href="https://docs.aws.amazon.com/rekognition/latest/dg/moderation.html#moderation-api">Using
        /// the image and video moderation APIs</a>.
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition Video can moderate content in a video stored in an Amazon S3 bucket.
        /// Use <a>Video</a> to specify the bucket name and the filename of the video. <c>StartContentModeration</c>
        /// returns a job identifier (<c>JobId</c>) which you use to get the results of the analysis.
        /// When content analysis is finished, Amazon Rekognition Video publishes a completion
        /// status to the Amazon Simple Notification Service topic that you specify in <c>NotificationChannel</c>.
        /// </para>
        ///  
        /// <para>
        /// To get the results of the content analysis, first check that the status value published
        /// to the Amazon SNS topic is <c>SUCCEEDED</c>. If so, call <a>GetContentModeration</a>
        /// and pass the job identifier (<c>JobId</c>) from the initial call to <c>StartContentModeration</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information, see Moderating content in the Amazon Rekognition Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartContentModeration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartContentModeration service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <c>ClientRequestToken</c> input parameter was reused with an operation, but at least
        /// one of the other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// jobs concurrently, subsequent calls to start operations (ex: <c>StartLabelDetection</c>)
        /// will raise a <c>LimitExceededException</c> exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Rekognition service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.VideoTooLargeException">
        /// The file size or duration of the supplied media is too large. The maximum file size
        /// is 10GB. The maximum duration is 6 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartContentModeration">REST API Reference for StartContentModeration Operation</seealso>
        public virtual Task<StartContentModerationResponse> StartContentModerationAsync(StartContentModerationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartContentModerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartContentModerationResponseUnmarshaller.Instance;

            return InvokeAsync<StartContentModerationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartFaceDetection

        internal virtual StartFaceDetectionResponse StartFaceDetection(StartFaceDetectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFaceDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFaceDetectionResponseUnmarshaller.Instance;

            return Invoke<StartFaceDetectionResponse>(request, options);
        }



        /// <summary>
        /// Starts asynchronous detection of faces in a stored video.
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition Video can detect faces in a video stored in an Amazon S3 bucket.
        /// Use <a>Video</a> to specify the bucket name and the filename of the video. <c>StartFaceDetection</c>
        /// returns a job identifier (<c>JobId</c>) that you use to get the results of the operation.
        /// When face detection is finished, Amazon Rekognition Video publishes a completion status
        /// to the Amazon Simple Notification Service topic that you specify in <c>NotificationChannel</c>.
        /// To get the results of the face detection operation, first check that the status value
        /// published to the Amazon SNS topic is <c>SUCCEEDED</c>. If so, call <a>GetFaceDetection</a>
        /// and pass the job identifier (<c>JobId</c>) from the initial call to <c>StartFaceDetection</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see Detecting faces in a stored video in the Amazon Rekognition
        /// Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFaceDetection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartFaceDetection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <c>ClientRequestToken</c> input parameter was reused with an operation, but at least
        /// one of the other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// jobs concurrently, subsequent calls to start operations (ex: <c>StartLabelDetection</c>)
        /// will raise a <c>LimitExceededException</c> exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Rekognition service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.VideoTooLargeException">
        /// The file size or duration of the supplied media is too large. The maximum file size
        /// is 10GB. The maximum duration is 6 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartFaceDetection">REST API Reference for StartFaceDetection Operation</seealso>
        public virtual Task<StartFaceDetectionResponse> StartFaceDetectionAsync(StartFaceDetectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFaceDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFaceDetectionResponseUnmarshaller.Instance;

            return InvokeAsync<StartFaceDetectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartFaceSearch

        internal virtual StartFaceSearchResponse StartFaceSearch(StartFaceSearchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFaceSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFaceSearchResponseUnmarshaller.Instance;

            return Invoke<StartFaceSearchResponse>(request, options);
        }



        /// <summary>
        /// Starts the asynchronous search for faces in a collection that match the faces of persons
        /// detected in a stored video.
        /// 
        ///  
        /// <para>
        /// The video must be stored in an Amazon S3 bucket. Use <a>Video</a> to specify the bucket
        /// name and the filename of the video. <c>StartFaceSearch</c> returns a job identifier
        /// (<c>JobId</c>) which you use to get the search results once the search has completed.
        /// When searching is finished, Amazon Rekognition Video publishes a completion status
        /// to the Amazon Simple Notification Service topic that you specify in <c>NotificationChannel</c>.
        /// To get the search results, first check that the status value published to the Amazon
        /// SNS topic is <c>SUCCEEDED</c>. If so, call <a>GetFaceSearch</a> and pass the job identifier
        /// (<c>JobId</c>) from the initial call to <c>StartFaceSearch</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/rekognition/latest/dg/procedure-person-search-videos.html">Searching
        /// stored videos for faces</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFaceSearch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartFaceSearch service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <c>ClientRequestToken</c> input parameter was reused with an operation, but at least
        /// one of the other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// jobs concurrently, subsequent calls to start operations (ex: <c>StartLabelDetection</c>)
        /// will raise a <c>LimitExceededException</c> exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Rekognition service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.VideoTooLargeException">
        /// The file size or duration of the supplied media is too large. The maximum file size
        /// is 10GB. The maximum duration is 6 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartFaceSearch">REST API Reference for StartFaceSearch Operation</seealso>
        public virtual Task<StartFaceSearchResponse> StartFaceSearchAsync(StartFaceSearchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFaceSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFaceSearchResponseUnmarshaller.Instance;

            return InvokeAsync<StartFaceSearchResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartLabelDetection

        internal virtual StartLabelDetectionResponse StartLabelDetection(StartLabelDetectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartLabelDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLabelDetectionResponseUnmarshaller.Instance;

            return Invoke<StartLabelDetectionResponse>(request, options);
        }



        /// <summary>
        /// Starts asynchronous detection of labels in a stored video.
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition Video can detect labels in a video. Labels are instances of real-world
        /// entities. This includes objects like flower, tree, and table; events like wedding,
        /// graduation, and birthday party; concepts like landscape, evening, and nature; and
        /// activities like a person getting out of a car or a person skiing.
        /// </para>
        ///  
        /// <para>
        /// The video must be stored in an Amazon S3 bucket. Use <a>Video</a> to specify the bucket
        /// name and the filename of the video. <c>StartLabelDetection</c> returns a job identifier
        /// (<c>JobId</c>) which you use to get the results of the operation. When label detection
        /// is finished, Amazon Rekognition Video publishes a completion status to the Amazon
        /// Simple Notification Service topic that you specify in <c>NotificationChannel</c>.
        /// </para>
        ///  
        /// <para>
        /// To get the results of the label detection operation, first check that the status value
        /// published to the Amazon SNS topic is <c>SUCCEEDED</c>. If so, call <a>GetLabelDetection</a>
        /// and pass the job identifier (<c>JobId</c>) from the initial call to <c>StartLabelDetection</c>.
        /// </para>
        ///  
        /// <para>
        ///  <i>Optional Parameters</i> 
        /// </para>
        ///  
        /// <para>
        ///  <c>StartLabelDetection</c> has the <c>GENERAL_LABELS</c> Feature applied by default.
        /// This feature allows you to provide filtering criteria to the <c>Settings</c> parameter.
        /// You can filter with sets of individual labels or with label categories. You can specify
        /// inclusive filters, exclusive filters, or a combination of inclusive and exclusive
        /// filters. For more information on filtering, see <a href="https://docs.aws.amazon.com/rekognition/latest/dg/labels-detecting-labels-video.html">Detecting
        /// labels in a video</a>.
        /// </para>
        ///  
        /// <para>
        /// You can specify <c>MinConfidence</c> to control the confidence threshold for the labels
        /// returned. The default is 50.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartLabelDetection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartLabelDetection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <c>ClientRequestToken</c> input parameter was reused with an operation, but at least
        /// one of the other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// jobs concurrently, subsequent calls to start operations (ex: <c>StartLabelDetection</c>)
        /// will raise a <c>LimitExceededException</c> exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Rekognition service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.VideoTooLargeException">
        /// The file size or duration of the supplied media is too large. The maximum file size
        /// is 10GB. The maximum duration is 6 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartLabelDetection">REST API Reference for StartLabelDetection Operation</seealso>
        public virtual Task<StartLabelDetectionResponse> StartLabelDetectionAsync(StartLabelDetectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartLabelDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLabelDetectionResponseUnmarshaller.Instance;

            return InvokeAsync<StartLabelDetectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartMediaAnalysisJob

        internal virtual StartMediaAnalysisJobResponse StartMediaAnalysisJob(StartMediaAnalysisJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMediaAnalysisJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMediaAnalysisJobResponseUnmarshaller.Instance;

            return Invoke<StartMediaAnalysisJobResponse>(request, options);
        }



        /// <summary>
        /// Initiates a new media analysis job. Accepts a manifest file in an Amazon S3 bucket.
        /// The output is a manifest file and a summary of the manifest stored in the Amazon S3
        /// bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMediaAnalysisJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMediaAnalysisJob service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <c>ClientRequestToken</c> input parameter was reused with an operation, but at least
        /// one of the other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidManifestException">
        /// Indicates that a provided manifest file is empty or larger than the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// jobs concurrently, subsequent calls to start operations (ex: <c>StartLabelDetection</c>)
        /// will raise a <c>LimitExceededException</c> exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Rekognition service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotReadyException">
        /// The requested resource isn't ready. For example, this exception occurs when you call
        /// <c>DetectCustomLabels</c> with a model version that isn't deployed.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartMediaAnalysisJob">REST API Reference for StartMediaAnalysisJob Operation</seealso>
        public virtual Task<StartMediaAnalysisJobResponse> StartMediaAnalysisJobAsync(StartMediaAnalysisJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMediaAnalysisJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMediaAnalysisJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartMediaAnalysisJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartPersonTracking

        internal virtual StartPersonTrackingResponse StartPersonTracking(StartPersonTrackingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartPersonTrackingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPersonTrackingResponseUnmarshaller.Instance;

            return Invoke<StartPersonTrackingResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        ///  <i>End of support notice:</i> On October 31, 2025, AWS will discontinue support for
        /// Amazon Rekognition People Pathing. After October 31, 2025, you will no longer be able
        /// to use the Rekognition People Pathing capability. For more information, visit this
        /// <a href="https://aws.amazon.com/blogs/machine-learning/transitioning-from-amazon-rekognition-people-pathing-exploring-other-alternatives/">blog
        /// post</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Starts the asynchronous tracking of a person's path in a stored video.
        /// </para>
        ///  
        /// <para>
        /// Amazon Rekognition Video can track the path of people in a video stored in an Amazon
        /// S3 bucket. Use <a>Video</a> to specify the bucket name and the filename of the video.
        /// <c>StartPersonTracking</c> returns a job identifier (<c>JobId</c>) which you use to
        /// get the results of the operation. When label detection is finished, Amazon Rekognition
        /// publishes a completion status to the Amazon Simple Notification Service topic that
        /// you specify in <c>NotificationChannel</c>. 
        /// </para>
        ///  
        /// <para>
        /// To get the results of the person detection operation, first check that the status
        /// value published to the Amazon SNS topic is <c>SUCCEEDED</c>. If so, call <a>GetPersonTracking</a>
        /// and pass the job identifier (<c>JobId</c>) from the initial call to <c>StartPersonTracking</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPersonTracking service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartPersonTracking service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <c>ClientRequestToken</c> input parameter was reused with an operation, but at least
        /// one of the other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// jobs concurrently, subsequent calls to start operations (ex: <c>StartLabelDetection</c>)
        /// will raise a <c>LimitExceededException</c> exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Rekognition service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.VideoTooLargeException">
        /// The file size or duration of the supplied media is too large. The maximum file size
        /// is 10GB. The maximum duration is 6 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartPersonTracking">REST API Reference for StartPersonTracking Operation</seealso>
        public virtual Task<StartPersonTrackingResponse> StartPersonTrackingAsync(StartPersonTrackingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartPersonTrackingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPersonTrackingResponseUnmarshaller.Instance;

            return InvokeAsync<StartPersonTrackingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartProjectVersion

        internal virtual StartProjectVersionResponse StartProjectVersion(StartProjectVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartProjectVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartProjectVersionResponseUnmarshaller.Instance;

            return Invoke<StartProjectVersionResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This operation applies only to Amazon Rekognition Custom Labels.
        /// </para>
        ///  </note> 
        /// <para>
        /// Starts the running of the version of a model. Starting a model takes a while to complete.
        /// To check the current state of the model, use <a>DescribeProjectVersions</a>. 
        /// </para>
        ///  
        /// <para>
        /// Once the model is running, you can detect custom labels in new images by calling <a>DetectCustomLabels</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You are charged for the amount of time that the model is running. To stop a running
        /// model, call <a>StopProjectVersion</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:StartProjectVersion</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartProjectVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartProjectVersion service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// jobs concurrently, subsequent calls to start operations (ex: <c>StartLabelDetection</c>)
        /// will raise a <c>LimitExceededException</c> exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Rekognition service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartProjectVersion">REST API Reference for StartProjectVersion Operation</seealso>
        public virtual Task<StartProjectVersionResponse> StartProjectVersionAsync(StartProjectVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartProjectVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartProjectVersionResponseUnmarshaller.Instance;

            return InvokeAsync<StartProjectVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartSegmentDetection

        internal virtual StartSegmentDetectionResponse StartSegmentDetection(StartSegmentDetectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSegmentDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSegmentDetectionResponseUnmarshaller.Instance;

            return Invoke<StartSegmentDetectionResponse>(request, options);
        }



        /// <summary>
        /// Starts asynchronous detection of segment detection in a stored video.
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition Video can detect segments in a video stored in an Amazon S3 bucket.
        /// Use <a>Video</a> to specify the bucket name and the filename of the video. <c>StartSegmentDetection</c>
        /// returns a job identifier (<c>JobId</c>) which you use to get the results of the operation.
        /// When segment detection is finished, Amazon Rekognition Video publishes a completion
        /// status to the Amazon Simple Notification Service topic that you specify in <c>NotificationChannel</c>.
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>Filters</c> (<a>StartSegmentDetectionFilters</a>) input parameter
        /// to specify the minimum detection confidence returned in the response. Within <c>Filters</c>,
        /// use <c>ShotFilter</c> (<a>StartShotDetectionFilter</a>) to filter detected shots.
        /// Use <c>TechnicalCueFilter</c> (<a>StartTechnicalCueDetectionFilter</a>) to filter
        /// technical cues. 
        /// </para>
        ///  
        /// <para>
        /// To get the results of the segment detection operation, first check that the status
        /// value published to the Amazon SNS topic is <c>SUCCEEDED</c>. if so, call <a>GetSegmentDetection</a>
        /// and pass the job identifier (<c>JobId</c>) from the initial call to <c>StartSegmentDetection</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information, see Detecting video segments in stored video in the Amazon Rekognition
        /// Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSegmentDetection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSegmentDetection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <c>ClientRequestToken</c> input parameter was reused with an operation, but at least
        /// one of the other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// jobs concurrently, subsequent calls to start operations (ex: <c>StartLabelDetection</c>)
        /// will raise a <c>LimitExceededException</c> exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Rekognition service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.VideoTooLargeException">
        /// The file size or duration of the supplied media is too large. The maximum file size
        /// is 10GB. The maximum duration is 6 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartSegmentDetection">REST API Reference for StartSegmentDetection Operation</seealso>
        public virtual Task<StartSegmentDetectionResponse> StartSegmentDetectionAsync(StartSegmentDetectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSegmentDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSegmentDetectionResponseUnmarshaller.Instance;

            return InvokeAsync<StartSegmentDetectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartStreamProcessor

        internal virtual StartStreamProcessorResponse StartStreamProcessor(StartStreamProcessorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartStreamProcessorResponseUnmarshaller.Instance;

            return Invoke<StartStreamProcessorResponse>(request, options);
        }



        /// <summary>
        /// Starts processing a stream processor. You create a stream processor by calling <a>CreateStreamProcessor</a>.
        /// To tell <c>StartStreamProcessor</c> which stream processor to start, use the value
        /// of the <c>Name</c> field specified in the call to <c>CreateStreamProcessor</c>.
        /// 
        ///  
        /// <para>
        /// If you are using a label detection stream processor to detect labels, you need to
        /// provide a <c>Start selector</c> and a <c>Stop selector</c> to determine the length
        /// of the stream processing time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartStreamProcessor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartStreamProcessor service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartStreamProcessor">REST API Reference for StartStreamProcessor Operation</seealso>
        public virtual Task<StartStreamProcessorResponse> StartStreamProcessorAsync(StartStreamProcessorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartStreamProcessorResponseUnmarshaller.Instance;

            return InvokeAsync<StartStreamProcessorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartTextDetection

        internal virtual StartTextDetectionResponse StartTextDetection(StartTextDetectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTextDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTextDetectionResponseUnmarshaller.Instance;

            return Invoke<StartTextDetectionResponse>(request, options);
        }



        /// <summary>
        /// Starts asynchronous detection of text in a stored video.
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition Video can detect text in a video stored in an Amazon S3 bucket.
        /// Use <a>Video</a> to specify the bucket name and the filename of the video. <c>StartTextDetection</c>
        /// returns a job identifier (<c>JobId</c>) which you use to get the results of the operation.
        /// When text detection is finished, Amazon Rekognition Video publishes a completion status
        /// to the Amazon Simple Notification Service topic that you specify in <c>NotificationChannel</c>.
        /// </para>
        ///  
        /// <para>
        /// To get the results of the text detection operation, first check that the status value
        /// published to the Amazon SNS topic is <c>SUCCEEDED</c>. if so, call <a>GetTextDetection</a>
        /// and pass the job identifier (<c>JobId</c>) from the initial call to <c>StartTextDetection</c>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTextDetection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTextDetection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <c>ClientRequestToken</c> input parameter was reused with an operation, but at least
        /// one of the other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// jobs concurrently, subsequent calls to start operations (ex: <c>StartLabelDetection</c>)
        /// will raise a <c>LimitExceededException</c> exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Rekognition service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.VideoTooLargeException">
        /// The file size or duration of the supplied media is too large. The maximum file size
        /// is 10GB. The maximum duration is 6 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartTextDetection">REST API Reference for StartTextDetection Operation</seealso>
        public virtual Task<StartTextDetectionResponse> StartTextDetectionAsync(StartTextDetectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTextDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTextDetectionResponseUnmarshaller.Instance;

            return InvokeAsync<StartTextDetectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopProjectVersion

        internal virtual StopProjectVersionResponse StopProjectVersion(StopProjectVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopProjectVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopProjectVersionResponseUnmarshaller.Instance;

            return Invoke<StopProjectVersionResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This operation applies only to Amazon Rekognition Custom Labels.
        /// </para>
        ///  </note> 
        /// <para>
        /// Stops a running model. The operation might take a while to complete. To check the
        /// current status, call <a>DescribeProjectVersions</a>. Only applies to Custom Labels
        /// projects.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:StopProjectVersion</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopProjectVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopProjectVersion service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StopProjectVersion">REST API Reference for StopProjectVersion Operation</seealso>
        public virtual Task<StopProjectVersionResponse> StopProjectVersionAsync(StopProjectVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopProjectVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopProjectVersionResponseUnmarshaller.Instance;

            return InvokeAsync<StopProjectVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopStreamProcessor

        internal virtual StopStreamProcessorResponse StopStreamProcessor(StopStreamProcessorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStreamProcessorResponseUnmarshaller.Instance;

            return Invoke<StopStreamProcessorResponse>(request, options);
        }



        /// <summary>
        /// Stops a running stream processor that was created by <a>CreateStreamProcessor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopStreamProcessor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopStreamProcessor service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StopStreamProcessor">REST API Reference for StopStreamProcessor Operation</seealso>
        public virtual Task<StopStreamProcessorResponse> StopStreamProcessorAsync(StopStreamProcessorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStreamProcessorResponseUnmarshaller.Instance;

            return InvokeAsync<StopStreamProcessorResponse>(request, options, cancellationToken);
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
        /// Adds one or more key-value tags to an Amazon Rekognition collection, stream processor,
        /// or Custom Labels model. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// AWS Resources</a>. 
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:TagResource</c>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ServiceQuotaExceededException">
        /// The size of the collection exceeds the allowed limit. For more information, see Guidelines
        /// and quotas in Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes one or more tags from an Amazon Rekognition collection, stream processor,
        /// or Custom Labels model. 
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:UntagResource</c>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDatasetEntries

        internal virtual UpdateDatasetEntriesResponse UpdateDatasetEntries(UpdateDatasetEntriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDatasetEntriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetEntriesResponseUnmarshaller.Instance;

            return Invoke<UpdateDatasetEntriesResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This operation applies only to Amazon Rekognition Custom Labels.
        /// </para>
        ///  </note> 
        /// <para>
        /// Adds or updates one or more entries (images) in a dataset. An entry is a JSON Line
        /// which contains the information for a single image, including the image location, assigned
        /// labels, and object location bounding boxes. For more information, see Image-Level
        /// labels in manifest files and Object localization in manifest files in the <i>Amazon
        /// Rekognition Custom Labels Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// If the <c>source-ref</c> field in the JSON line references an existing image, the
        /// existing image in the dataset is updated. If <c>source-ref</c> field doesn't reference
        /// an existing image, the image is added as a new image to the dataset. 
        /// </para>
        ///  
        /// <para>
        /// You specify the changes that you want to make in the <c>Changes</c> input parameter.
        /// There isn't a limit to the number JSON Lines that you can change, but the size of
        /// <c>Changes</c> must be less than 5MB.
        /// </para>
        ///  
        /// <para>
        ///  <c>UpdateDatasetEntries</c> returns immediatly, but the dataset update might take
        /// a while to complete. Use <a>DescribeDataset</a> to check the current status. The dataset
        /// updated successfully if the value of <c>Status</c> is <c>UPDATE_COMPLETE</c>. 
        /// </para>
        ///  
        /// <para>
        /// To check if any non-terminal errors occured, call <a>ListDatasetEntries</a> and check
        /// for the presence of <c>errors</c> lists in the JSON Lines.
        /// </para>
        ///  
        /// <para>
        /// Dataset update fails if a terminal error occurs (<c>Status</c> = <c>UPDATE_FAILED</c>).
        /// Currently, you can't access the terminal error information from the Amazon Rekognition
        /// Custom Labels SDK. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>rekognition:UpdateDatasetEntries</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatasetEntries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDatasetEntries service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// jobs concurrently, subsequent calls to start operations (ex: <c>StartLabelDetection</c>)
        /// will raise a <c>LimitExceededException</c> exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Rekognition service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/UpdateDatasetEntries">REST API Reference for UpdateDatasetEntries Operation</seealso>
        public virtual Task<UpdateDatasetEntriesResponse> UpdateDatasetEntriesAsync(UpdateDatasetEntriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDatasetEntriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetEntriesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDatasetEntriesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateStreamProcessor

        internal virtual UpdateStreamProcessorResponse UpdateStreamProcessor(UpdateStreamProcessorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStreamProcessorResponseUnmarshaller.Instance;

            return Invoke<UpdateStreamProcessorResponse>(request, options);
        }



        /// <summary>
        /// Allows you to update a stream processor. You can change some settings and regions
        /// of interest and delete certain parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamProcessor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStreamProcessor service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/UpdateStreamProcessor">REST API Reference for UpdateStreamProcessor Operation</seealso>
        public virtual Task<UpdateStreamProcessorResponse> UpdateStreamProcessorAsync(UpdateStreamProcessorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStreamProcessorResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStreamProcessorResponse>(request, options, cancellationToken);
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