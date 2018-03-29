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
 * Do not modify this file. This file is generated from the runtime.lex-2016-11-28.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Lex.Model;
using Amazon.Lex.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Lex
{
    /// <summary>
    /// Implementation for accessing Lex
    ///
    /// Amazon Lex provides both build and runtime endpoints. Each endpoint provides a set
    /// of operations (API). Your conversational bot uses the runtime API to understand user
    /// utterances (user input text or voice). For example, suppose a user says "I want pizza",
    /// your bot sends this input to Amazon Lex using the runtime API. Amazon Lex recognizes
    /// that the user request is for the OrderPizza intent (one of the intents defined in
    /// the bot). Then Amazon Lex engages in user conversation on behalf of the bot to elicit
    /// required information (slot values, such as pizza size and crust type), and then performs
    /// fulfillment activity (that you configured when you created the bot). You use the build-time
    /// API to create and manage your Amazon Lex bot. For a list of build-time operations,
    /// see the build-time API, .
    /// </summary>
    public partial class AmazonLexClient : AmazonServiceClient, IAmazonLex
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonLexClient with the credentials loaded from the application's
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
        public AmazonLexClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLexConfig()) { }

        /// <summary>
        /// Constructs AmazonLexClient with the credentials loaded from the application's
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
        public AmazonLexClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLexConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLexClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonLexClient Configuration Object</param>
        public AmazonLexClient(AmazonLexConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonLexClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLexClient(AWSCredentials credentials)
            : this(credentials, new AmazonLexConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLexClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLexClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLexConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLexClient with AWS Credentials and an
        /// AmazonLexClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLexClient Configuration Object</param>
        public AmazonLexClient(AWSCredentials credentials, AmazonLexConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLexClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLexClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLexConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLexClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLexClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLexConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLexClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLexClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLexClient Configuration Object</param>
        public AmazonLexClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLexConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLexClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLexClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLexConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLexClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLexClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLexConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLexClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLexClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLexClient Configuration Object</param>
        public AmazonLexClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLexConfig clientConfig)
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

        
        #region  PostContent

        internal virtual PostContentResponse PostContent(PostContentRequest request)
        {
            var marshaller = PostContentRequestMarshaller.Instance;
            var unmarshaller = PostContentResponseUnmarshaller.Instance;

            return Invoke<PostContentRequest,PostContentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PostContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PostContent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex-2016-11-28/PostContent">REST API Reference for PostContent Operation</seealso>
        public virtual Task<PostContentResponse> PostContentAsync(PostContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PostContentRequestMarshaller.Instance;
            var unmarshaller = PostContentResponseUnmarshaller.Instance;

            return InvokeAsync<PostContentRequest,PostContentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PostText

        internal virtual PostTextResponse PostText(PostTextRequest request)
        {
            var marshaller = PostTextRequestMarshaller.Instance;
            var unmarshaller = PostTextResponseUnmarshaller.Instance;

            return Invoke<PostTextRequest,PostTextResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PostText operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PostText operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex-2016-11-28/PostText">REST API Reference for PostText Operation</seealso>
        public virtual Task<PostTextResponse> PostTextAsync(PostTextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PostTextRequestMarshaller.Instance;
            var unmarshaller = PostTextResponseUnmarshaller.Instance;

            return InvokeAsync<PostTextRequest,PostTextResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}