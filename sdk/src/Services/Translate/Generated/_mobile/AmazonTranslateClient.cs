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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Translate.Model;
using Amazon.Translate.Model.Internal.MarshallTransformations;
using Amazon.Translate.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Translate
{
    /// <summary>
    /// Implementation for accessing Translate
    ///
    /// Provides translation between one source language and another of the same set of languages.
    /// </summary>
    public partial class AmazonTranslateClient : AmazonServiceClient, IAmazonTranslate
    {
        private static IServiceMetadata serviceMetadata = new AmazonTranslateMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonTranslateClient with the credentials loaded from the application's
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
        public AmazonTranslateClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTranslateConfig()) { }

        /// <summary>
        /// Constructs AmazonTranslateClient with the credentials loaded from the application's
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
        public AmazonTranslateClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTranslateConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonTranslateClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonTranslateClient Configuration Object</param>
        public AmazonTranslateClient(AmazonTranslateConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonTranslateClient(AWSCredentials credentials)
            : this(credentials, new AmazonTranslateConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranslateClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonTranslateConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Credentials and an
        /// AmazonTranslateClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonTranslateClient Configuration Object</param>
        public AmazonTranslateClient(AWSCredentials credentials, AmazonTranslateConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonTranslateClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTranslateConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranslateClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTranslateConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTranslateClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonTranslateClient Configuration Object</param>
        public AmazonTranslateClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonTranslateConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonTranslateClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTranslateConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranslateClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTranslateConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTranslateClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonTranslateClient Configuration Object</param>
        public AmazonTranslateClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonTranslateConfig clientConfig)
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


        #region  DeleteTerminology

        internal virtual DeleteTerminologyResponse DeleteTerminology(DeleteTerminologyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTerminologyResponseUnmarshaller.Instance;

            return Invoke<DeleteTerminologyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTerminology operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTerminology operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DeleteTerminology">REST API Reference for DeleteTerminology Operation</seealso>
        public virtual Task<DeleteTerminologyResponse> DeleteTerminologyAsync(DeleteTerminologyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTerminologyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTerminologyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTerminology

        internal virtual GetTerminologyResponse GetTerminology(GetTerminologyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTerminologyResponseUnmarshaller.Instance;

            return Invoke<GetTerminologyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTerminology operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTerminology operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/GetTerminology">REST API Reference for GetTerminology Operation</seealso>
        public virtual Task<GetTerminologyResponse> GetTerminologyAsync(GetTerminologyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTerminologyResponseUnmarshaller.Instance;

            return InvokeAsync<GetTerminologyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportTerminology

        internal virtual ImportTerminologyResponse ImportTerminology(ImportTerminologyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportTerminologyResponseUnmarshaller.Instance;

            return Invoke<ImportTerminologyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ImportTerminology operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportTerminology operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ImportTerminology">REST API Reference for ImportTerminology Operation</seealso>
        public virtual Task<ImportTerminologyResponse> ImportTerminologyAsync(ImportTerminologyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportTerminologyResponseUnmarshaller.Instance;

            return InvokeAsync<ImportTerminologyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTerminologies

        internal virtual ListTerminologiesResponse ListTerminologies(ListTerminologiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTerminologiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTerminologiesResponseUnmarshaller.Instance;

            return Invoke<ListTerminologiesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTerminologies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTerminologies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListTerminologies">REST API Reference for ListTerminologies Operation</seealso>
        public virtual Task<ListTerminologiesResponse> ListTerminologiesAsync(ListTerminologiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTerminologiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTerminologiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTerminologiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TranslateText

        internal virtual TranslateTextResponse TranslateText(TranslateTextRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TranslateTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TranslateTextResponseUnmarshaller.Instance;

            return Invoke<TranslateTextResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TranslateText operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TranslateText operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/TranslateText">REST API Reference for TranslateText Operation</seealso>
        public virtual Task<TranslateTextResponse> TranslateTextAsync(TranslateTextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TranslateTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TranslateTextResponseUnmarshaller.Instance;

            return InvokeAsync<TranslateTextResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}