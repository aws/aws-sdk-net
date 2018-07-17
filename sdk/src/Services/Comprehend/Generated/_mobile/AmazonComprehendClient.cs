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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Comprehend.Model;
using Amazon.Comprehend.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Comprehend
{
    /// <summary>
    /// Implementation for accessing Comprehend
    ///
    /// Amazon Comprehend is an AWS service for gaining insight into the content of documents.
    /// Use these actions to determine the topics contained in your documents, the topics
    /// they discuss, the predominant sentiment expressed in them, the predominant language
    /// used, and more.
    /// </summary>
    public partial class AmazonComprehendClient : AmazonServiceClient, IAmazonComprehend
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonComprehendClient with the credentials loaded from the application's
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
        public AmazonComprehendClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonComprehendConfig()) { }

        /// <summary>
        /// Constructs AmazonComprehendClient with the credentials loaded from the application's
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
        public AmazonComprehendClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonComprehendConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonComprehendClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonComprehendClient Configuration Object</param>
        public AmazonComprehendClient(AmazonComprehendConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonComprehendClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonComprehendClient(AWSCredentials credentials)
            : this(credentials, new AmazonComprehendConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonComprehendClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonComprehendConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendClient with AWS Credentials and an
        /// AmazonComprehendClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonComprehendClient Configuration Object</param>
        public AmazonComprehendClient(AWSCredentials credentials, AmazonComprehendConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonComprehendClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonComprehendConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonComprehendClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonComprehendConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonComprehendClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonComprehendClient Configuration Object</param>
        public AmazonComprehendClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonComprehendConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonComprehendClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonComprehendConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonComprehendClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonComprehendConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonComprehendClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonComprehendClient Configuration Object</param>
        public AmazonComprehendClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonComprehendConfig clientConfig)
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

        
        #region  BatchDetectDominantLanguage

        internal virtual BatchDetectDominantLanguageResponse BatchDetectDominantLanguage(BatchDetectDominantLanguageRequest request)
        {
            var marshaller = BatchDetectDominantLanguageRequestMarshaller.Instance;
            var unmarshaller = BatchDetectDominantLanguageResponseUnmarshaller.Instance;

            return Invoke<BatchDetectDominantLanguageRequest,BatchDetectDominantLanguageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDetectDominantLanguage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDetectDominantLanguage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectDominantLanguage">REST API Reference for BatchDetectDominantLanguage Operation</seealso>
        public virtual Task<BatchDetectDominantLanguageResponse> BatchDetectDominantLanguageAsync(BatchDetectDominantLanguageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchDetectDominantLanguageRequestMarshaller.Instance;
            var unmarshaller = BatchDetectDominantLanguageResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDetectDominantLanguageRequest,BatchDetectDominantLanguageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchDetectEntities

        internal virtual BatchDetectEntitiesResponse BatchDetectEntities(BatchDetectEntitiesRequest request)
        {
            var marshaller = BatchDetectEntitiesRequestMarshaller.Instance;
            var unmarshaller = BatchDetectEntitiesResponseUnmarshaller.Instance;

            return Invoke<BatchDetectEntitiesRequest,BatchDetectEntitiesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDetectEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDetectEntities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectEntities">REST API Reference for BatchDetectEntities Operation</seealso>
        public virtual Task<BatchDetectEntitiesResponse> BatchDetectEntitiesAsync(BatchDetectEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchDetectEntitiesRequestMarshaller.Instance;
            var unmarshaller = BatchDetectEntitiesResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDetectEntitiesRequest,BatchDetectEntitiesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchDetectKeyPhrases

        internal virtual BatchDetectKeyPhrasesResponse BatchDetectKeyPhrases(BatchDetectKeyPhrasesRequest request)
        {
            var marshaller = BatchDetectKeyPhrasesRequestMarshaller.Instance;
            var unmarshaller = BatchDetectKeyPhrasesResponseUnmarshaller.Instance;

            return Invoke<BatchDetectKeyPhrasesRequest,BatchDetectKeyPhrasesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDetectKeyPhrases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDetectKeyPhrases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectKeyPhrases">REST API Reference for BatchDetectKeyPhrases Operation</seealso>
        public virtual Task<BatchDetectKeyPhrasesResponse> BatchDetectKeyPhrasesAsync(BatchDetectKeyPhrasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchDetectKeyPhrasesRequestMarshaller.Instance;
            var unmarshaller = BatchDetectKeyPhrasesResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDetectKeyPhrasesRequest,BatchDetectKeyPhrasesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchDetectSentiment

        internal virtual BatchDetectSentimentResponse BatchDetectSentiment(BatchDetectSentimentRequest request)
        {
            var marshaller = BatchDetectSentimentRequestMarshaller.Instance;
            var unmarshaller = BatchDetectSentimentResponseUnmarshaller.Instance;

            return Invoke<BatchDetectSentimentRequest,BatchDetectSentimentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDetectSentiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDetectSentiment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectSentiment">REST API Reference for BatchDetectSentiment Operation</seealso>
        public virtual Task<BatchDetectSentimentResponse> BatchDetectSentimentAsync(BatchDetectSentimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchDetectSentimentRequestMarshaller.Instance;
            var unmarshaller = BatchDetectSentimentResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDetectSentimentRequest,BatchDetectSentimentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchDetectSyntax

        internal virtual BatchDetectSyntaxResponse BatchDetectSyntax(BatchDetectSyntaxRequest request)
        {
            var marshaller = BatchDetectSyntaxRequestMarshaller.Instance;
            var unmarshaller = BatchDetectSyntaxResponseUnmarshaller.Instance;

            return Invoke<BatchDetectSyntaxRequest,BatchDetectSyntaxResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDetectSyntax operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDetectSyntax operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectSyntax">REST API Reference for BatchDetectSyntax Operation</seealso>
        public virtual Task<BatchDetectSyntaxResponse> BatchDetectSyntaxAsync(BatchDetectSyntaxRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchDetectSyntaxRequestMarshaller.Instance;
            var unmarshaller = BatchDetectSyntaxResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDetectSyntaxRequest,BatchDetectSyntaxResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDominantLanguageDetectionJob

        internal virtual DescribeDominantLanguageDetectionJobResponse DescribeDominantLanguageDetectionJob(DescribeDominantLanguageDetectionJobRequest request)
        {
            var marshaller = DescribeDominantLanguageDetectionJobRequestMarshaller.Instance;
            var unmarshaller = DescribeDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDominantLanguageDetectionJobRequest,DescribeDominantLanguageDetectionJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDominantLanguageDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDominantLanguageDetectionJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeDominantLanguageDetectionJob">REST API Reference for DescribeDominantLanguageDetectionJob Operation</seealso>
        public virtual Task<DescribeDominantLanguageDetectionJobResponse> DescribeDominantLanguageDetectionJobAsync(DescribeDominantLanguageDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDominantLanguageDetectionJobRequestMarshaller.Instance;
            var unmarshaller = DescribeDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDominantLanguageDetectionJobRequest,DescribeDominantLanguageDetectionJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEntitiesDetectionJob

        internal virtual DescribeEntitiesDetectionJobResponse DescribeEntitiesDetectionJob(DescribeEntitiesDetectionJobRequest request)
        {
            var marshaller = DescribeEntitiesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = DescribeEntitiesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeEntitiesDetectionJobRequest,DescribeEntitiesDetectionJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEntitiesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntitiesDetectionJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeEntitiesDetectionJob">REST API Reference for DescribeEntitiesDetectionJob Operation</seealso>
        public virtual Task<DescribeEntitiesDetectionJobResponse> DescribeEntitiesDetectionJobAsync(DescribeEntitiesDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeEntitiesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = DescribeEntitiesDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEntitiesDetectionJobRequest,DescribeEntitiesDetectionJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeKeyPhrasesDetectionJob

        internal virtual DescribeKeyPhrasesDetectionJobResponse DescribeKeyPhrasesDetectionJob(DescribeKeyPhrasesDetectionJobRequest request)
        {
            var marshaller = DescribeKeyPhrasesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = DescribeKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeKeyPhrasesDetectionJobRequest,DescribeKeyPhrasesDetectionJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKeyPhrasesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyPhrasesDetectionJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeKeyPhrasesDetectionJob">REST API Reference for DescribeKeyPhrasesDetectionJob Operation</seealso>
        public virtual Task<DescribeKeyPhrasesDetectionJobResponse> DescribeKeyPhrasesDetectionJobAsync(DescribeKeyPhrasesDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeKeyPhrasesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = DescribeKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeKeyPhrasesDetectionJobRequest,DescribeKeyPhrasesDetectionJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSentimentDetectionJob

        internal virtual DescribeSentimentDetectionJobResponse DescribeSentimentDetectionJob(DescribeSentimentDetectionJobRequest request)
        {
            var marshaller = DescribeSentimentDetectionJobRequestMarshaller.Instance;
            var unmarshaller = DescribeSentimentDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeSentimentDetectionJobRequest,DescribeSentimentDetectionJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSentimentDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSentimentDetectionJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeSentimentDetectionJob">REST API Reference for DescribeSentimentDetectionJob Operation</seealso>
        public virtual Task<DescribeSentimentDetectionJobResponse> DescribeSentimentDetectionJobAsync(DescribeSentimentDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeSentimentDetectionJobRequestMarshaller.Instance;
            var unmarshaller = DescribeSentimentDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSentimentDetectionJobRequest,DescribeSentimentDetectionJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTopicsDetectionJob

        internal virtual DescribeTopicsDetectionJobResponse DescribeTopicsDetectionJob(DescribeTopicsDetectionJobRequest request)
        {
            var marshaller = DescribeTopicsDetectionJobRequestMarshaller.Instance;
            var unmarshaller = DescribeTopicsDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeTopicsDetectionJobRequest,DescribeTopicsDetectionJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTopicsDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopicsDetectionJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeTopicsDetectionJob">REST API Reference for DescribeTopicsDetectionJob Operation</seealso>
        public virtual Task<DescribeTopicsDetectionJobResponse> DescribeTopicsDetectionJobAsync(DescribeTopicsDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeTopicsDetectionJobRequestMarshaller.Instance;
            var unmarshaller = DescribeTopicsDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTopicsDetectionJobRequest,DescribeTopicsDetectionJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetectDominantLanguage

        internal virtual DetectDominantLanguageResponse DetectDominantLanguage(DetectDominantLanguageRequest request)
        {
            var marshaller = DetectDominantLanguageRequestMarshaller.Instance;
            var unmarshaller = DetectDominantLanguageResponseUnmarshaller.Instance;

            return Invoke<DetectDominantLanguageRequest,DetectDominantLanguageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetectDominantLanguage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectDominantLanguage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectDominantLanguage">REST API Reference for DetectDominantLanguage Operation</seealso>
        public virtual Task<DetectDominantLanguageResponse> DetectDominantLanguageAsync(DetectDominantLanguageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DetectDominantLanguageRequestMarshaller.Instance;
            var unmarshaller = DetectDominantLanguageResponseUnmarshaller.Instance;

            return InvokeAsync<DetectDominantLanguageRequest,DetectDominantLanguageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetectEntities

        internal virtual DetectEntitiesResponse DetectEntities(DetectEntitiesRequest request)
        {
            var marshaller = DetectEntitiesRequestMarshaller.Instance;
            var unmarshaller = DetectEntitiesResponseUnmarshaller.Instance;

            return Invoke<DetectEntitiesRequest,DetectEntitiesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetectEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectEntities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectEntities">REST API Reference for DetectEntities Operation</seealso>
        public virtual Task<DetectEntitiesResponse> DetectEntitiesAsync(DetectEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DetectEntitiesRequestMarshaller.Instance;
            var unmarshaller = DetectEntitiesResponseUnmarshaller.Instance;

            return InvokeAsync<DetectEntitiesRequest,DetectEntitiesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetectKeyPhrases

        internal virtual DetectKeyPhrasesResponse DetectKeyPhrases(DetectKeyPhrasesRequest request)
        {
            var marshaller = DetectKeyPhrasesRequestMarshaller.Instance;
            var unmarshaller = DetectKeyPhrasesResponseUnmarshaller.Instance;

            return Invoke<DetectKeyPhrasesRequest,DetectKeyPhrasesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetectKeyPhrases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectKeyPhrases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectKeyPhrases">REST API Reference for DetectKeyPhrases Operation</seealso>
        public virtual Task<DetectKeyPhrasesResponse> DetectKeyPhrasesAsync(DetectKeyPhrasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DetectKeyPhrasesRequestMarshaller.Instance;
            var unmarshaller = DetectKeyPhrasesResponseUnmarshaller.Instance;

            return InvokeAsync<DetectKeyPhrasesRequest,DetectKeyPhrasesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetectSentiment

        internal virtual DetectSentimentResponse DetectSentiment(DetectSentimentRequest request)
        {
            var marshaller = DetectSentimentRequestMarshaller.Instance;
            var unmarshaller = DetectSentimentResponseUnmarshaller.Instance;

            return Invoke<DetectSentimentRequest,DetectSentimentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetectSentiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectSentiment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectSentiment">REST API Reference for DetectSentiment Operation</seealso>
        public virtual Task<DetectSentimentResponse> DetectSentimentAsync(DetectSentimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DetectSentimentRequestMarshaller.Instance;
            var unmarshaller = DetectSentimentResponseUnmarshaller.Instance;

            return InvokeAsync<DetectSentimentRequest,DetectSentimentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetectSyntax

        internal virtual DetectSyntaxResponse DetectSyntax(DetectSyntaxRequest request)
        {
            var marshaller = DetectSyntaxRequestMarshaller.Instance;
            var unmarshaller = DetectSyntaxResponseUnmarshaller.Instance;

            return Invoke<DetectSyntaxRequest,DetectSyntaxResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetectSyntax operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectSyntax operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectSyntax">REST API Reference for DetectSyntax Operation</seealso>
        public virtual Task<DetectSyntaxResponse> DetectSyntaxAsync(DetectSyntaxRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DetectSyntaxRequestMarshaller.Instance;
            var unmarshaller = DetectSyntaxResponseUnmarshaller.Instance;

            return InvokeAsync<DetectSyntaxRequest,DetectSyntaxResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDominantLanguageDetectionJobs

        internal virtual ListDominantLanguageDetectionJobsResponse ListDominantLanguageDetectionJobs(ListDominantLanguageDetectionJobsRequest request)
        {
            var marshaller = ListDominantLanguageDetectionJobsRequestMarshaller.Instance;
            var unmarshaller = ListDominantLanguageDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListDominantLanguageDetectionJobsRequest,ListDominantLanguageDetectionJobsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDominantLanguageDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDominantLanguageDetectionJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListDominantLanguageDetectionJobs">REST API Reference for ListDominantLanguageDetectionJobs Operation</seealso>
        public virtual Task<ListDominantLanguageDetectionJobsResponse> ListDominantLanguageDetectionJobsAsync(ListDominantLanguageDetectionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListDominantLanguageDetectionJobsRequestMarshaller.Instance;
            var unmarshaller = ListDominantLanguageDetectionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDominantLanguageDetectionJobsRequest,ListDominantLanguageDetectionJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListEntitiesDetectionJobs

        internal virtual ListEntitiesDetectionJobsResponse ListEntitiesDetectionJobs(ListEntitiesDetectionJobsRequest request)
        {
            var marshaller = ListEntitiesDetectionJobsRequestMarshaller.Instance;
            var unmarshaller = ListEntitiesDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListEntitiesDetectionJobsRequest,ListEntitiesDetectionJobsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListEntitiesDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEntitiesDetectionJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListEntitiesDetectionJobs">REST API Reference for ListEntitiesDetectionJobs Operation</seealso>
        public virtual Task<ListEntitiesDetectionJobsResponse> ListEntitiesDetectionJobsAsync(ListEntitiesDetectionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListEntitiesDetectionJobsRequestMarshaller.Instance;
            var unmarshaller = ListEntitiesDetectionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEntitiesDetectionJobsRequest,ListEntitiesDetectionJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListKeyPhrasesDetectionJobs

        internal virtual ListKeyPhrasesDetectionJobsResponse ListKeyPhrasesDetectionJobs(ListKeyPhrasesDetectionJobsRequest request)
        {
            var marshaller = ListKeyPhrasesDetectionJobsRequestMarshaller.Instance;
            var unmarshaller = ListKeyPhrasesDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListKeyPhrasesDetectionJobsRequest,ListKeyPhrasesDetectionJobsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListKeyPhrasesDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeyPhrasesDetectionJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListKeyPhrasesDetectionJobs">REST API Reference for ListKeyPhrasesDetectionJobs Operation</seealso>
        public virtual Task<ListKeyPhrasesDetectionJobsResponse> ListKeyPhrasesDetectionJobsAsync(ListKeyPhrasesDetectionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListKeyPhrasesDetectionJobsRequestMarshaller.Instance;
            var unmarshaller = ListKeyPhrasesDetectionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListKeyPhrasesDetectionJobsRequest,ListKeyPhrasesDetectionJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSentimentDetectionJobs

        internal virtual ListSentimentDetectionJobsResponse ListSentimentDetectionJobs(ListSentimentDetectionJobsRequest request)
        {
            var marshaller = ListSentimentDetectionJobsRequestMarshaller.Instance;
            var unmarshaller = ListSentimentDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListSentimentDetectionJobsRequest,ListSentimentDetectionJobsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListSentimentDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSentimentDetectionJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListSentimentDetectionJobs">REST API Reference for ListSentimentDetectionJobs Operation</seealso>
        public virtual Task<ListSentimentDetectionJobsResponse> ListSentimentDetectionJobsAsync(ListSentimentDetectionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListSentimentDetectionJobsRequestMarshaller.Instance;
            var unmarshaller = ListSentimentDetectionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSentimentDetectionJobsRequest,ListSentimentDetectionJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTopicsDetectionJobs

        internal virtual ListTopicsDetectionJobsResponse ListTopicsDetectionJobs(ListTopicsDetectionJobsRequest request)
        {
            var marshaller = ListTopicsDetectionJobsRequestMarshaller.Instance;
            var unmarshaller = ListTopicsDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListTopicsDetectionJobsRequest,ListTopicsDetectionJobsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTopicsDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTopicsDetectionJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListTopicsDetectionJobs">REST API Reference for ListTopicsDetectionJobs Operation</seealso>
        public virtual Task<ListTopicsDetectionJobsResponse> ListTopicsDetectionJobsAsync(ListTopicsDetectionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTopicsDetectionJobsRequestMarshaller.Instance;
            var unmarshaller = ListTopicsDetectionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTopicsDetectionJobsRequest,ListTopicsDetectionJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartDominantLanguageDetectionJob

        internal virtual StartDominantLanguageDetectionJobResponse StartDominantLanguageDetectionJob(StartDominantLanguageDetectionJobRequest request)
        {
            var marshaller = StartDominantLanguageDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StartDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartDominantLanguageDetectionJobRequest,StartDominantLanguageDetectionJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartDominantLanguageDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDominantLanguageDetectionJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartDominantLanguageDetectionJob">REST API Reference for StartDominantLanguageDetectionJob Operation</seealso>
        public virtual Task<StartDominantLanguageDetectionJobResponse> StartDominantLanguageDetectionJobAsync(StartDominantLanguageDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartDominantLanguageDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StartDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartDominantLanguageDetectionJobRequest,StartDominantLanguageDetectionJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartEntitiesDetectionJob

        internal virtual StartEntitiesDetectionJobResponse StartEntitiesDetectionJob(StartEntitiesDetectionJobRequest request)
        {
            var marshaller = StartEntitiesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StartEntitiesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartEntitiesDetectionJobRequest,StartEntitiesDetectionJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartEntitiesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartEntitiesDetectionJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartEntitiesDetectionJob">REST API Reference for StartEntitiesDetectionJob Operation</seealso>
        public virtual Task<StartEntitiesDetectionJobResponse> StartEntitiesDetectionJobAsync(StartEntitiesDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartEntitiesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StartEntitiesDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartEntitiesDetectionJobRequest,StartEntitiesDetectionJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartKeyPhrasesDetectionJob

        internal virtual StartKeyPhrasesDetectionJobResponse StartKeyPhrasesDetectionJob(StartKeyPhrasesDetectionJobRequest request)
        {
            var marshaller = StartKeyPhrasesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StartKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartKeyPhrasesDetectionJobRequest,StartKeyPhrasesDetectionJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartKeyPhrasesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartKeyPhrasesDetectionJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartKeyPhrasesDetectionJob">REST API Reference for StartKeyPhrasesDetectionJob Operation</seealso>
        public virtual Task<StartKeyPhrasesDetectionJobResponse> StartKeyPhrasesDetectionJobAsync(StartKeyPhrasesDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartKeyPhrasesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StartKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartKeyPhrasesDetectionJobRequest,StartKeyPhrasesDetectionJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartSentimentDetectionJob

        internal virtual StartSentimentDetectionJobResponse StartSentimentDetectionJob(StartSentimentDetectionJobRequest request)
        {
            var marshaller = StartSentimentDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StartSentimentDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartSentimentDetectionJobRequest,StartSentimentDetectionJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartSentimentDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSentimentDetectionJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartSentimentDetectionJob">REST API Reference for StartSentimentDetectionJob Operation</seealso>
        public virtual Task<StartSentimentDetectionJobResponse> StartSentimentDetectionJobAsync(StartSentimentDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartSentimentDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StartSentimentDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartSentimentDetectionJobRequest,StartSentimentDetectionJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartTopicsDetectionJob

        internal virtual StartTopicsDetectionJobResponse StartTopicsDetectionJob(StartTopicsDetectionJobRequest request)
        {
            var marshaller = StartTopicsDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StartTopicsDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartTopicsDetectionJobRequest,StartTopicsDetectionJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartTopicsDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTopicsDetectionJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartTopicsDetectionJob">REST API Reference for StartTopicsDetectionJob Operation</seealso>
        public virtual Task<StartTopicsDetectionJobResponse> StartTopicsDetectionJobAsync(StartTopicsDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartTopicsDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StartTopicsDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartTopicsDetectionJobRequest,StartTopicsDetectionJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopDominantLanguageDetectionJob

        internal virtual StopDominantLanguageDetectionJobResponse StopDominantLanguageDetectionJob(StopDominantLanguageDetectionJobRequest request)
        {
            var marshaller = StopDominantLanguageDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StopDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopDominantLanguageDetectionJobRequest,StopDominantLanguageDetectionJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopDominantLanguageDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDominantLanguageDetectionJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopDominantLanguageDetectionJob">REST API Reference for StopDominantLanguageDetectionJob Operation</seealso>
        public virtual Task<StopDominantLanguageDetectionJobResponse> StopDominantLanguageDetectionJobAsync(StopDominantLanguageDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StopDominantLanguageDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StopDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopDominantLanguageDetectionJobRequest,StopDominantLanguageDetectionJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopEntitiesDetectionJob

        internal virtual StopEntitiesDetectionJobResponse StopEntitiesDetectionJob(StopEntitiesDetectionJobRequest request)
        {
            var marshaller = StopEntitiesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StopEntitiesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopEntitiesDetectionJobRequest,StopEntitiesDetectionJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopEntitiesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopEntitiesDetectionJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopEntitiesDetectionJob">REST API Reference for StopEntitiesDetectionJob Operation</seealso>
        public virtual Task<StopEntitiesDetectionJobResponse> StopEntitiesDetectionJobAsync(StopEntitiesDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StopEntitiesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StopEntitiesDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopEntitiesDetectionJobRequest,StopEntitiesDetectionJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopKeyPhrasesDetectionJob

        internal virtual StopKeyPhrasesDetectionJobResponse StopKeyPhrasesDetectionJob(StopKeyPhrasesDetectionJobRequest request)
        {
            var marshaller = StopKeyPhrasesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StopKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopKeyPhrasesDetectionJobRequest,StopKeyPhrasesDetectionJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopKeyPhrasesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopKeyPhrasesDetectionJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopKeyPhrasesDetectionJob">REST API Reference for StopKeyPhrasesDetectionJob Operation</seealso>
        public virtual Task<StopKeyPhrasesDetectionJobResponse> StopKeyPhrasesDetectionJobAsync(StopKeyPhrasesDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StopKeyPhrasesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StopKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopKeyPhrasesDetectionJobRequest,StopKeyPhrasesDetectionJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopSentimentDetectionJob

        internal virtual StopSentimentDetectionJobResponse StopSentimentDetectionJob(StopSentimentDetectionJobRequest request)
        {
            var marshaller = StopSentimentDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StopSentimentDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopSentimentDetectionJobRequest,StopSentimentDetectionJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopSentimentDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopSentimentDetectionJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopSentimentDetectionJob">REST API Reference for StopSentimentDetectionJob Operation</seealso>
        public virtual Task<StopSentimentDetectionJobResponse> StopSentimentDetectionJobAsync(StopSentimentDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StopSentimentDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StopSentimentDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopSentimentDetectionJobRequest,StopSentimentDetectionJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}