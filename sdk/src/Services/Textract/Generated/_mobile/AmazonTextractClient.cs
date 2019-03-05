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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Textract.Model;
using Amazon.Textract.Model.Internal.MarshallTransformations;
using Amazon.Textract.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Textract
{
    /// <summary>
    /// Implementation for accessing Textract
    ///
    /// Amazon Textract detects and analyzes text in documents and converts it into machine-readable
    /// text. This is the API reference documentation for Amazon Textract.
    /// </summary>
    public partial class AmazonTextractClient : AmazonServiceClient, IAmazonTextract
    {
        private static IServiceMetadata serviceMetadata = new AmazonTextractMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonTextractClient with the credentials loaded from the application's
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
        public AmazonTextractClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTextractConfig()) { }

        /// <summary>
        /// Constructs AmazonTextractClient with the credentials loaded from the application's
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
        public AmazonTextractClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTextractConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonTextractClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonTextractClient Configuration Object</param>
        public AmazonTextractClient(AmazonTextractConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonTextractClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonTextractClient(AWSCredentials credentials)
            : this(credentials, new AmazonTextractConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTextractClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTextractClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonTextractConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTextractClient with AWS Credentials and an
        /// AmazonTextractClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonTextractClient Configuration Object</param>
        public AmazonTextractClient(AWSCredentials credentials, AmazonTextractConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTextractClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonTextractClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTextractConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTextractClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTextractClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTextractConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonTextractClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTextractClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonTextractClient Configuration Object</param>
        public AmazonTextractClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonTextractConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTextractClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonTextractClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTextractConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTextractClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTextractClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTextractConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTextractClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTextractClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonTextractClient Configuration Object</param>
        public AmazonTextractClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonTextractConfig clientConfig)
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


        #region  AnalyzeDocument

        internal virtual AnalyzeDocumentResponse AnalyzeDocument(AnalyzeDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AnalyzeDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AnalyzeDocumentResponseUnmarshaller.Instance;

            return Invoke<AnalyzeDocumentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AnalyzeDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AnalyzeDocument operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/AnalyzeDocument">REST API Reference for AnalyzeDocument Operation</seealso>
        public virtual Task<AnalyzeDocumentResponse> AnalyzeDocumentAsync(AnalyzeDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AnalyzeDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AnalyzeDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<AnalyzeDocumentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectDocumentText

        internal virtual DetectDocumentTextResponse DetectDocumentText(DetectDocumentTextRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectDocumentTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectDocumentTextResponseUnmarshaller.Instance;

            return Invoke<DetectDocumentTextResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetectDocumentText operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectDocumentText operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/DetectDocumentText">REST API Reference for DetectDocumentText Operation</seealso>
        public virtual Task<DetectDocumentTextResponse> DetectDocumentTextAsync(DetectDocumentTextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectDocumentTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectDocumentTextResponseUnmarshaller.Instance;

            return InvokeAsync<DetectDocumentTextResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDocumentAnalysis

        internal virtual GetDocumentAnalysisResponse GetDocumentAnalysis(GetDocumentAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDocumentAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentAnalysisResponseUnmarshaller.Instance;

            return Invoke<GetDocumentAnalysisResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDocumentAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentAnalysis operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/GetDocumentAnalysis">REST API Reference for GetDocumentAnalysis Operation</seealso>
        public virtual Task<GetDocumentAnalysisResponse> GetDocumentAnalysisAsync(GetDocumentAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDocumentAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentAnalysisResponseUnmarshaller.Instance;

            return InvokeAsync<GetDocumentAnalysisResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDocumentTextDetection

        internal virtual GetDocumentTextDetectionResponse GetDocumentTextDetection(GetDocumentTextDetectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDocumentTextDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentTextDetectionResponseUnmarshaller.Instance;

            return Invoke<GetDocumentTextDetectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDocumentTextDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentTextDetection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/GetDocumentTextDetection">REST API Reference for GetDocumentTextDetection Operation</seealso>
        public virtual Task<GetDocumentTextDetectionResponse> GetDocumentTextDetectionAsync(GetDocumentTextDetectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDocumentTextDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentTextDetectionResponseUnmarshaller.Instance;

            return InvokeAsync<GetDocumentTextDetectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDocumentAnalysis

        internal virtual StartDocumentAnalysisResponse StartDocumentAnalysis(StartDocumentAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDocumentAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDocumentAnalysisResponseUnmarshaller.Instance;

            return Invoke<StartDocumentAnalysisResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartDocumentAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDocumentAnalysis operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/StartDocumentAnalysis">REST API Reference for StartDocumentAnalysis Operation</seealso>
        public virtual Task<StartDocumentAnalysisResponse> StartDocumentAnalysisAsync(StartDocumentAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDocumentAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDocumentAnalysisResponseUnmarshaller.Instance;

            return InvokeAsync<StartDocumentAnalysisResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDocumentTextDetection

        internal virtual StartDocumentTextDetectionResponse StartDocumentTextDetection(StartDocumentTextDetectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDocumentTextDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDocumentTextDetectionResponseUnmarshaller.Instance;

            return Invoke<StartDocumentTextDetectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartDocumentTextDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDocumentTextDetection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/StartDocumentTextDetection">REST API Reference for StartDocumentTextDetection Operation</seealso>
        public virtual Task<StartDocumentTextDetectionResponse> StartDocumentTextDetectionAsync(StartDocumentTextDetectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDocumentTextDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDocumentTextDetectionResponseUnmarshaller.Instance;

            return InvokeAsync<StartDocumentTextDetectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}