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
using System.Net;

using Amazon.Comprehend.Model;
using Amazon.Comprehend.Model.Internal.MarshallTransformations;
using Amazon.Comprehend.Internal;
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
        private static IServiceMetadata serviceMetadata = new AmazonComprehendMetadata();
        
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


        #region  BatchDetectDominantLanguage

        internal virtual BatchDetectDominantLanguageResponse BatchDetectDominantLanguage(BatchDetectDominantLanguageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectDominantLanguageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectDominantLanguageResponseUnmarshaller.Instance;

            return Invoke<BatchDetectDominantLanguageResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectDominantLanguageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectDominantLanguageResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDetectDominantLanguageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDetectEntities

        internal virtual BatchDetectEntitiesResponse BatchDetectEntities(BatchDetectEntitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectEntitiesResponseUnmarshaller.Instance;

            return Invoke<BatchDetectEntitiesResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectEntitiesResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDetectEntitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDetectKeyPhrases

        internal virtual BatchDetectKeyPhrasesResponse BatchDetectKeyPhrases(BatchDetectKeyPhrasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectKeyPhrasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectKeyPhrasesResponseUnmarshaller.Instance;

            return Invoke<BatchDetectKeyPhrasesResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectKeyPhrasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectKeyPhrasesResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDetectKeyPhrasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDetectSentiment

        internal virtual BatchDetectSentimentResponse BatchDetectSentiment(BatchDetectSentimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectSentimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectSentimentResponseUnmarshaller.Instance;

            return Invoke<BatchDetectSentimentResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectSentimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectSentimentResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDetectSentimentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDetectSyntax

        internal virtual BatchDetectSyntaxResponse BatchDetectSyntax(BatchDetectSyntaxRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectSyntaxRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectSyntaxResponseUnmarshaller.Instance;

            return Invoke<BatchDetectSyntaxResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectSyntaxRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectSyntaxResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDetectSyntaxResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDocumentClassifier

        internal virtual CreateDocumentClassifierResponse CreateDocumentClassifier(CreateDocumentClassifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDocumentClassifierResponseUnmarshaller.Instance;

            return Invoke<CreateDocumentClassifierResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDocumentClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDocumentClassifier operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateDocumentClassifier">REST API Reference for CreateDocumentClassifier Operation</seealso>
        public virtual Task<CreateDocumentClassifierResponse> CreateDocumentClassifierAsync(CreateDocumentClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDocumentClassifierResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDocumentClassifierResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEntityRecognizer

        internal virtual CreateEntityRecognizerResponse CreateEntityRecognizer(CreateEntityRecognizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEntityRecognizerResponseUnmarshaller.Instance;

            return Invoke<CreateEntityRecognizerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEntityRecognizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEntityRecognizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateEntityRecognizer">REST API Reference for CreateEntityRecognizer Operation</seealso>
        public virtual Task<CreateEntityRecognizerResponse> CreateEntityRecognizerAsync(CreateEntityRecognizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEntityRecognizerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEntityRecognizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDocumentClassifier

        internal virtual DeleteDocumentClassifierResponse DeleteDocumentClassifier(DeleteDocumentClassifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDocumentClassifierResponseUnmarshaller.Instance;

            return Invoke<DeleteDocumentClassifierResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDocumentClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocumentClassifier operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DeleteDocumentClassifier">REST API Reference for DeleteDocumentClassifier Operation</seealso>
        public virtual Task<DeleteDocumentClassifierResponse> DeleteDocumentClassifierAsync(DeleteDocumentClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDocumentClassifierResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDocumentClassifierResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEntityRecognizer

        internal virtual DeleteEntityRecognizerResponse DeleteEntityRecognizer(DeleteEntityRecognizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEntityRecognizerResponseUnmarshaller.Instance;

            return Invoke<DeleteEntityRecognizerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEntityRecognizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEntityRecognizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DeleteEntityRecognizer">REST API Reference for DeleteEntityRecognizer Operation</seealso>
        public virtual Task<DeleteEntityRecognizerResponse> DeleteEntityRecognizerAsync(DeleteEntityRecognizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEntityRecognizerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEntityRecognizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDocumentClassificationJob

        internal virtual DescribeDocumentClassificationJobResponse DescribeDocumentClassificationJob(DescribeDocumentClassificationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDocumentClassificationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDocumentClassificationJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDocumentClassificationJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDocumentClassificationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentClassificationJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeDocumentClassificationJob">REST API Reference for DescribeDocumentClassificationJob Operation</seealso>
        public virtual Task<DescribeDocumentClassificationJobResponse> DescribeDocumentClassificationJobAsync(DescribeDocumentClassificationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDocumentClassificationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDocumentClassificationJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDocumentClassificationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDocumentClassifier

        internal virtual DescribeDocumentClassifierResponse DescribeDocumentClassifier(DescribeDocumentClassifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDocumentClassifierResponseUnmarshaller.Instance;

            return Invoke<DescribeDocumentClassifierResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDocumentClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentClassifier operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeDocumentClassifier">REST API Reference for DescribeDocumentClassifier Operation</seealso>
        public virtual Task<DescribeDocumentClassifierResponse> DescribeDocumentClassifierAsync(DescribeDocumentClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDocumentClassifierResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDocumentClassifierResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDominantLanguageDetectionJob

        internal virtual DescribeDominantLanguageDetectionJobResponse DescribeDominantLanguageDetectionJob(DescribeDominantLanguageDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDominantLanguageDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDominantLanguageDetectionJobResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDominantLanguageDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDominantLanguageDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEntitiesDetectionJob

        internal virtual DescribeEntitiesDetectionJobResponse DescribeEntitiesDetectionJob(DescribeEntitiesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntitiesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeEntitiesDetectionJobResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntitiesDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEntitiesDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEntityRecognizer

        internal virtual DescribeEntityRecognizerResponse DescribeEntityRecognizer(DescribeEntityRecognizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntityRecognizerResponseUnmarshaller.Instance;

            return Invoke<DescribeEntityRecognizerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEntityRecognizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntityRecognizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeEntityRecognizer">REST API Reference for DescribeEntityRecognizer Operation</seealso>
        public virtual Task<DescribeEntityRecognizerResponse> DescribeEntityRecognizerAsync(DescribeEntityRecognizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntityRecognizerResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEntityRecognizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeKeyPhrasesDetectionJob

        internal virtual DescribeKeyPhrasesDetectionJobResponse DescribeKeyPhrasesDetectionJob(DescribeKeyPhrasesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeKeyPhrasesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeKeyPhrasesDetectionJobResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeKeyPhrasesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeKeyPhrasesDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSentimentDetectionJob

        internal virtual DescribeSentimentDetectionJobResponse DescribeSentimentDetectionJob(DescribeSentimentDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSentimentDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeSentimentDetectionJobResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSentimentDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSentimentDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTopicsDetectionJob

        internal virtual DescribeTopicsDetectionJobResponse DescribeTopicsDetectionJob(DescribeTopicsDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTopicsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTopicsDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeTopicsDetectionJobResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTopicsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTopicsDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTopicsDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectDominantLanguage

        internal virtual DetectDominantLanguageResponse DetectDominantLanguage(DetectDominantLanguageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectDominantLanguageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectDominantLanguageResponseUnmarshaller.Instance;

            return Invoke<DetectDominantLanguageResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectDominantLanguageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectDominantLanguageResponseUnmarshaller.Instance;

            return InvokeAsync<DetectDominantLanguageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectEntities

        internal virtual DetectEntitiesResponse DetectEntities(DetectEntitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectEntitiesResponseUnmarshaller.Instance;

            return Invoke<DetectEntitiesResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectEntitiesResponseUnmarshaller.Instance;

            return InvokeAsync<DetectEntitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectKeyPhrases

        internal virtual DetectKeyPhrasesResponse DetectKeyPhrases(DetectKeyPhrasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectKeyPhrasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectKeyPhrasesResponseUnmarshaller.Instance;

            return Invoke<DetectKeyPhrasesResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectKeyPhrasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectKeyPhrasesResponseUnmarshaller.Instance;

            return InvokeAsync<DetectKeyPhrasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectSentiment

        internal virtual DetectSentimentResponse DetectSentiment(DetectSentimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectSentimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectSentimentResponseUnmarshaller.Instance;

            return Invoke<DetectSentimentResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectSentimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectSentimentResponseUnmarshaller.Instance;

            return InvokeAsync<DetectSentimentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectSyntax

        internal virtual DetectSyntaxResponse DetectSyntax(DetectSyntaxRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectSyntaxRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectSyntaxResponseUnmarshaller.Instance;

            return Invoke<DetectSyntaxResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectSyntaxRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectSyntaxResponseUnmarshaller.Instance;

            return InvokeAsync<DetectSyntaxResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDocumentClassificationJobs

        internal virtual ListDocumentClassificationJobsResponse ListDocumentClassificationJobs(ListDocumentClassificationJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentClassificationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentClassificationJobsResponseUnmarshaller.Instance;

            return Invoke<ListDocumentClassificationJobsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDocumentClassificationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentClassificationJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListDocumentClassificationJobs">REST API Reference for ListDocumentClassificationJobs Operation</seealso>
        public virtual Task<ListDocumentClassificationJobsResponse> ListDocumentClassificationJobsAsync(ListDocumentClassificationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentClassificationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentClassificationJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDocumentClassificationJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDocumentClassifiers

        internal virtual ListDocumentClassifiersResponse ListDocumentClassifiers(ListDocumentClassifiersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentClassifiersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentClassifiersResponseUnmarshaller.Instance;

            return Invoke<ListDocumentClassifiersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDocumentClassifiers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentClassifiers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListDocumentClassifiers">REST API Reference for ListDocumentClassifiers Operation</seealso>
        public virtual Task<ListDocumentClassifiersResponse> ListDocumentClassifiersAsync(ListDocumentClassifiersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentClassifiersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentClassifiersResponseUnmarshaller.Instance;

            return InvokeAsync<ListDocumentClassifiersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDominantLanguageDetectionJobs

        internal virtual ListDominantLanguageDetectionJobsResponse ListDominantLanguageDetectionJobs(ListDominantLanguageDetectionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDominantLanguageDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDominantLanguageDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListDominantLanguageDetectionJobsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDominantLanguageDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDominantLanguageDetectionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDominantLanguageDetectionJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEntitiesDetectionJobs

        internal virtual ListEntitiesDetectionJobsResponse ListEntitiesDetectionJobs(ListEntitiesDetectionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntitiesDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitiesDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListEntitiesDetectionJobsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntitiesDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitiesDetectionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEntitiesDetectionJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEntityRecognizers

        internal virtual ListEntityRecognizersResponse ListEntityRecognizers(ListEntityRecognizersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntityRecognizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntityRecognizersResponseUnmarshaller.Instance;

            return Invoke<ListEntityRecognizersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListEntityRecognizers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEntityRecognizers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListEntityRecognizers">REST API Reference for ListEntityRecognizers Operation</seealso>
        public virtual Task<ListEntityRecognizersResponse> ListEntityRecognizersAsync(ListEntityRecognizersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntityRecognizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntityRecognizersResponseUnmarshaller.Instance;

            return InvokeAsync<ListEntityRecognizersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListKeyPhrasesDetectionJobs

        internal virtual ListKeyPhrasesDetectionJobsResponse ListKeyPhrasesDetectionJobs(ListKeyPhrasesDetectionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeyPhrasesDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeyPhrasesDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListKeyPhrasesDetectionJobsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeyPhrasesDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeyPhrasesDetectionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListKeyPhrasesDetectionJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSentimentDetectionJobs

        internal virtual ListSentimentDetectionJobsResponse ListSentimentDetectionJobs(ListSentimentDetectionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSentimentDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSentimentDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListSentimentDetectionJobsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSentimentDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSentimentDetectionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSentimentDetectionJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTopicsDetectionJobs

        internal virtual ListTopicsDetectionJobsResponse ListTopicsDetectionJobs(ListTopicsDetectionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTopicsDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTopicsDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListTopicsDetectionJobsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTopicsDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTopicsDetectionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTopicsDetectionJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDocumentClassificationJob

        internal virtual StartDocumentClassificationJobResponse StartDocumentClassificationJob(StartDocumentClassificationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDocumentClassificationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDocumentClassificationJobResponseUnmarshaller.Instance;

            return Invoke<StartDocumentClassificationJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartDocumentClassificationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDocumentClassificationJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartDocumentClassificationJob">REST API Reference for StartDocumentClassificationJob Operation</seealso>
        public virtual Task<StartDocumentClassificationJobResponse> StartDocumentClassificationJobAsync(StartDocumentClassificationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDocumentClassificationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDocumentClassificationJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartDocumentClassificationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDominantLanguageDetectionJob

        internal virtual StartDominantLanguageDetectionJobResponse StartDominantLanguageDetectionJob(StartDominantLanguageDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDominantLanguageDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartDominantLanguageDetectionJobResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDominantLanguageDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartDominantLanguageDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartEntitiesDetectionJob

        internal virtual StartEntitiesDetectionJobResponse StartEntitiesDetectionJob(StartEntitiesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEntitiesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartEntitiesDetectionJobResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEntitiesDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartEntitiesDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartKeyPhrasesDetectionJob

        internal virtual StartKeyPhrasesDetectionJobResponse StartKeyPhrasesDetectionJob(StartKeyPhrasesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartKeyPhrasesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartKeyPhrasesDetectionJobResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StartKeyPhrasesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartKeyPhrasesDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartSentimentDetectionJob

        internal virtual StartSentimentDetectionJobResponse StartSentimentDetectionJob(StartSentimentDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSentimentDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartSentimentDetectionJobResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSentimentDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartSentimentDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartTopicsDetectionJob

        internal virtual StartTopicsDetectionJobResponse StartTopicsDetectionJob(StartTopicsDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTopicsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTopicsDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartTopicsDetectionJobResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTopicsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTopicsDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartTopicsDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopDominantLanguageDetectionJob

        internal virtual StopDominantLanguageDetectionJobResponse StopDominantLanguageDetectionJob(StopDominantLanguageDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDominantLanguageDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopDominantLanguageDetectionJobResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDominantLanguageDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopDominantLanguageDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopEntitiesDetectionJob

        internal virtual StopEntitiesDetectionJobResponse StopEntitiesDetectionJob(StopEntitiesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEntitiesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopEntitiesDetectionJobResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEntitiesDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopEntitiesDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopKeyPhrasesDetectionJob

        internal virtual StopKeyPhrasesDetectionJobResponse StopKeyPhrasesDetectionJob(StopKeyPhrasesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopKeyPhrasesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopKeyPhrasesDetectionJobResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StopKeyPhrasesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopKeyPhrasesDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopSentimentDetectionJob

        internal virtual StopSentimentDetectionJobResponse StopSentimentDetectionJob(StopSentimentDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopSentimentDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopSentimentDetectionJobResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StopSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopSentimentDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopSentimentDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopTrainingDocumentClassifier

        internal virtual StopTrainingDocumentClassifierResponse StopTrainingDocumentClassifier(StopTrainingDocumentClassifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTrainingDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTrainingDocumentClassifierResponseUnmarshaller.Instance;

            return Invoke<StopTrainingDocumentClassifierResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopTrainingDocumentClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTrainingDocumentClassifier operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopTrainingDocumentClassifier">REST API Reference for StopTrainingDocumentClassifier Operation</seealso>
        public virtual Task<StopTrainingDocumentClassifierResponse> StopTrainingDocumentClassifierAsync(StopTrainingDocumentClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTrainingDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTrainingDocumentClassifierResponseUnmarshaller.Instance;

            return InvokeAsync<StopTrainingDocumentClassifierResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopTrainingEntityRecognizer

        internal virtual StopTrainingEntityRecognizerResponse StopTrainingEntityRecognizer(StopTrainingEntityRecognizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTrainingEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTrainingEntityRecognizerResponseUnmarshaller.Instance;

            return Invoke<StopTrainingEntityRecognizerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopTrainingEntityRecognizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTrainingEntityRecognizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopTrainingEntityRecognizer">REST API Reference for StopTrainingEntityRecognizer Operation</seealso>
        public virtual Task<StopTrainingEntityRecognizerResponse> StopTrainingEntityRecognizerAsync(StopTrainingEntityRecognizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTrainingEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTrainingEntityRecognizerResponseUnmarshaller.Instance;

            return InvokeAsync<StopTrainingEntityRecognizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}