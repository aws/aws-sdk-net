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
 * Do not modify this file. This file is generated from the polly-2016-06-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Polly.Model;
using Amazon.Polly.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Polly
{
    /// <summary>
    /// Implementation for accessing Polly
    ///
    /// Amazon Polly is a web service that makes it easy to synthesize speech from text.
    /// 
    ///  
    /// <para>
    /// The Amazon Polly service provides API operations for synthesizing high-quality speech
    /// from plain text and Speech Synthesis Markup Language (SSML), along with managing pronunciations
    /// lexicons that enable you to get the best results for your application domain.
    /// </para>
    /// </summary>
    public partial class AmazonPollyClient : AmazonServiceClient, IAmazonPolly
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonPollyClient with the credentials loaded from the application's
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
        public AmazonPollyClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPollyConfig()) { }

        /// <summary>
        /// Constructs AmazonPollyClient with the credentials loaded from the application's
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
        public AmazonPollyClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPollyConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPollyClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPollyClient Configuration Object</param>
        public AmazonPollyClient(AmazonPollyConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonPollyClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPollyClient(AWSCredentials credentials)
            : this(credentials, new AmazonPollyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPollyClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPollyClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPollyConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPollyClient with AWS Credentials and an
        /// AmazonPollyClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPollyClient Configuration Object</param>
        public AmazonPollyClient(AWSCredentials credentials, AmazonPollyConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPollyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPollyClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPollyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPollyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPollyClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPollyConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPollyClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPollyClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPollyClient Configuration Object</param>
        public AmazonPollyClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPollyConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPollyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPollyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPollyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPollyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPollyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPollyConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPollyClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPollyClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPollyClient Configuration Object</param>
        public AmazonPollyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPollyConfig clientConfig)
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

        
        #region  DeleteLexicon

        internal virtual DeleteLexiconResponse DeleteLexicon(DeleteLexiconRequest request)
        {
            var marshaller = DeleteLexiconRequestMarshaller.Instance;
            var unmarshaller = DeleteLexiconResponseUnmarshaller.Instance;

            return Invoke<DeleteLexiconRequest,DeleteLexiconResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLexicon operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLexicon operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/DeleteLexicon">REST API Reference for DeleteLexicon Operation</seealso>
        public virtual Task<DeleteLexiconResponse> DeleteLexiconAsync(DeleteLexiconRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteLexiconRequestMarshaller.Instance;
            var unmarshaller = DeleteLexiconResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLexiconRequest,DeleteLexiconResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVoices

        internal virtual DescribeVoicesResponse DescribeVoices(DescribeVoicesRequest request)
        {
            var marshaller = DescribeVoicesRequestMarshaller.Instance;
            var unmarshaller = DescribeVoicesResponseUnmarshaller.Instance;

            return Invoke<DescribeVoicesRequest,DescribeVoicesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVoices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVoices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/DescribeVoices">REST API Reference for DescribeVoices Operation</seealso>
        public virtual Task<DescribeVoicesResponse> DescribeVoicesAsync(DescribeVoicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeVoicesRequestMarshaller.Instance;
            var unmarshaller = DescribeVoicesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVoicesRequest,DescribeVoicesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetLexicon

        internal virtual GetLexiconResponse GetLexicon(GetLexiconRequest request)
        {
            var marshaller = GetLexiconRequestMarshaller.Instance;
            var unmarshaller = GetLexiconResponseUnmarshaller.Instance;

            return Invoke<GetLexiconRequest,GetLexiconResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetLexicon operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLexicon operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/GetLexicon">REST API Reference for GetLexicon Operation</seealso>
        public virtual Task<GetLexiconResponse> GetLexiconAsync(GetLexiconRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetLexiconRequestMarshaller.Instance;
            var unmarshaller = GetLexiconResponseUnmarshaller.Instance;

            return InvokeAsync<GetLexiconRequest,GetLexiconResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListLexicons

        internal virtual ListLexiconsResponse ListLexicons(ListLexiconsRequest request)
        {
            var marshaller = ListLexiconsRequestMarshaller.Instance;
            var unmarshaller = ListLexiconsResponseUnmarshaller.Instance;

            return Invoke<ListLexiconsRequest,ListLexiconsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListLexicons operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLexicons operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/ListLexicons">REST API Reference for ListLexicons Operation</seealso>
        public virtual Task<ListLexiconsResponse> ListLexiconsAsync(ListLexiconsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListLexiconsRequestMarshaller.Instance;
            var unmarshaller = ListLexiconsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLexiconsRequest,ListLexiconsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutLexicon

        internal virtual PutLexiconResponse PutLexicon(PutLexiconRequest request)
        {
            var marshaller = PutLexiconRequestMarshaller.Instance;
            var unmarshaller = PutLexiconResponseUnmarshaller.Instance;

            return Invoke<PutLexiconRequest,PutLexiconResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutLexicon operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLexicon operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/PutLexicon">REST API Reference for PutLexicon Operation</seealso>
        public virtual Task<PutLexiconResponse> PutLexiconAsync(PutLexiconRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutLexiconRequestMarshaller.Instance;
            var unmarshaller = PutLexiconResponseUnmarshaller.Instance;

            return InvokeAsync<PutLexiconRequest,PutLexiconResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SynthesizeSpeech

        internal virtual SynthesizeSpeechResponse SynthesizeSpeech(SynthesizeSpeechRequest request)
        {
            var marshaller = SynthesizeSpeechRequestMarshaller.Instance;
            var unmarshaller = SynthesizeSpeechResponseUnmarshaller.Instance;

            return Invoke<SynthesizeSpeechRequest,SynthesizeSpeechResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SynthesizeSpeech operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SynthesizeSpeech operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/SynthesizeSpeech">REST API Reference for SynthesizeSpeech Operation</seealso>
        public virtual Task<SynthesizeSpeechResponse> SynthesizeSpeechAsync(SynthesizeSpeechRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SynthesizeSpeechRequestMarshaller.Instance;
            var unmarshaller = SynthesizeSpeechResponseUnmarshaller.Instance;

            return InvokeAsync<SynthesizeSpeechRequest,SynthesizeSpeechResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}