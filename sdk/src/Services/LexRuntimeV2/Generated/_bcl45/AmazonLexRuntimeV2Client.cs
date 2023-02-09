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
 * Do not modify this file. This file is generated from the runtime.lex.v2-2020-08-07.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.LexRuntimeV2.Model;
using Amazon.LexRuntimeV2.Model.Internal.MarshallTransformations;
using Amazon.LexRuntimeV2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.LexRuntimeV2
{
    /// <summary>
    /// Implementation for accessing LexRuntimeV2
    ///
    /// This section contains documentation for the Amazon Lex V2 Runtime V2 API operations.
    /// </summary>
    public partial class AmazonLexRuntimeV2Client : AmazonServiceClient, IAmazonLexRuntimeV2
    {
        private static IServiceMetadata serviceMetadata = new AmazonLexRuntimeV2Metadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonLexRuntimeV2Client with the credentials loaded from the application's
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
        public AmazonLexRuntimeV2Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLexRuntimeV2Config()) { }

        /// <summary>
        /// Constructs AmazonLexRuntimeV2Client with the credentials loaded from the application's
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
        public AmazonLexRuntimeV2Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLexRuntimeV2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLexRuntimeV2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonLexRuntimeV2Client Configuration Object</param>
        public AmazonLexRuntimeV2Client(AmazonLexRuntimeV2Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonLexRuntimeV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLexRuntimeV2Client(AWSCredentials credentials)
            : this(credentials, new AmazonLexRuntimeV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonLexRuntimeV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLexRuntimeV2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLexRuntimeV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLexRuntimeV2Client with AWS Credentials and an
        /// AmazonLexRuntimeV2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLexRuntimeV2Client Configuration Object</param>
        public AmazonLexRuntimeV2Client(AWSCredentials credentials, AmazonLexRuntimeV2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLexRuntimeV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLexRuntimeV2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLexRuntimeV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonLexRuntimeV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLexRuntimeV2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLexRuntimeV2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLexRuntimeV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLexRuntimeV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLexRuntimeV2Client Configuration Object</param>
        public AmazonLexRuntimeV2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonLexRuntimeV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLexRuntimeV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLexRuntimeV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLexRuntimeV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonLexRuntimeV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLexRuntimeV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLexRuntimeV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLexRuntimeV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLexRuntimeV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLexRuntimeV2Client Configuration Object</param>
        public AmazonLexRuntimeV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLexRuntimeV2Config clientConfig)
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLexRuntimeV2EndpointResolver());
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


        #region  DeleteSession


        /// <summary>
        /// Removes session information for a specified bot, alias, and user ID. 
        /// 
        ///  
        /// <para>
        /// You can use this operation to restart a conversation with a bot. When you remove a
        /// session, the entire history of the session is removed so that you can start again.
        /// </para>
        ///  
        /// <para>
        /// You don't need to delete a session. Sessions have a time limit and will expire. Set
        /// the session time limit when you create the bot. The default is 5 minutes, but you
        /// can specify anything between 1 minute and 24 hours.
        /// </para>
        ///  
        /// <para>
        /// If you specify a bot or alias ID that doesn't exist, you receive a <code>BadRequestException.</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// If the locale doesn't exist in the bot, or if the locale hasn't been enables for the
        /// alias, you receive a <code>BadRequestException</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSession service method.</param>
        /// 
        /// <returns>The response from the DeleteSession service method, as returned by LexRuntimeV2.</returns>
        /// <exception cref="Amazon.LexRuntimeV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/DeleteSession">REST API Reference for DeleteSession Operation</seealso>
        public virtual DeleteSessionResponse DeleteSession(DeleteSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSessionResponseUnmarshaller.Instance;

            return Invoke<DeleteSessionResponse>(request, options);
        }


        /// <summary>
        /// Removes session information for a specified bot, alias, and user ID. 
        /// 
        ///  
        /// <para>
        /// You can use this operation to restart a conversation with a bot. When you remove a
        /// session, the entire history of the session is removed so that you can start again.
        /// </para>
        ///  
        /// <para>
        /// You don't need to delete a session. Sessions have a time limit and will expire. Set
        /// the session time limit when you create the bot. The default is 5 minutes, but you
        /// can specify anything between 1 minute and 24 hours.
        /// </para>
        ///  
        /// <para>
        /// If you specify a bot or alias ID that doesn't exist, you receive a <code>BadRequestException.</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// If the locale doesn't exist in the bot, or if the locale hasn't been enables for the
        /// alias, you receive a <code>BadRequestException</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSession service method, as returned by LexRuntimeV2.</returns>
        /// <exception cref="Amazon.LexRuntimeV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/DeleteSession">REST API Reference for DeleteSession Operation</seealso>
        public virtual Task<DeleteSessionResponse> DeleteSessionAsync(DeleteSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSession


        /// <summary>
        /// Returns session information for a specified bot, alias, and user.
        /// 
        ///  
        /// <para>
        /// For example, you can use this operation to retrieve session information for a user
        /// that has left a long-running session in use.
        /// </para>
        ///  
        /// <para>
        /// If the bot, alias, or session identifier doesn't exist, Amazon Lex V2 returns a <code>BadRequestException</code>.
        /// If the locale doesn't exist or is not enabled for the alias, you receive a <code>BadRequestException</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
        /// 
        /// <returns>The response from the GetSession service method, as returned by LexRuntimeV2.</returns>
        /// <exception cref="Amazon.LexRuntimeV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual GetSessionResponse GetSession(GetSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;

            return Invoke<GetSessionResponse>(request, options);
        }


        /// <summary>
        /// Returns session information for a specified bot, alias, and user.
        /// 
        ///  
        /// <para>
        /// For example, you can use this operation to retrieve session information for a user
        /// that has left a long-running session in use.
        /// </para>
        ///  
        /// <para>
        /// If the bot, alias, or session identifier doesn't exist, Amazon Lex V2 returns a <code>BadRequestException</code>.
        /// If the locale doesn't exist or is not enabled for the alias, you receive a <code>BadRequestException</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSession service method, as returned by LexRuntimeV2.</returns>
        /// <exception cref="Amazon.LexRuntimeV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual Task<GetSessionResponse> GetSessionAsync(GetSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutSession


        /// <summary>
        /// Creates a new session or modifies an existing session with an Amazon Lex V2 bot. Use
        /// this operation to enable your application to set the state of the bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSession service method.</param>
        /// 
        /// <returns>The response from the PutSession service method, as returned by LexRuntimeV2.</returns>
        /// <exception cref="Amazon.LexRuntimeV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.BadGatewayException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.DependencyFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/PutSession">REST API Reference for PutSession Operation</seealso>
        public virtual PutSessionResponse PutSession(PutSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSessionResponseUnmarshaller.Instance;

            return Invoke<PutSessionResponse>(request, options);
        }


        /// <summary>
        /// Creates a new session or modifies an existing session with an Amazon Lex V2 bot. Use
        /// this operation to enable your application to set the state of the bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSession service method, as returned by LexRuntimeV2.</returns>
        /// <exception cref="Amazon.LexRuntimeV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.BadGatewayException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.DependencyFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/PutSession">REST API Reference for PutSession Operation</seealso>
        public virtual Task<PutSessionResponse> PutSessionAsync(PutSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RecognizeText


        /// <summary>
        /// Sends user input to Amazon Lex V2. Client applications use this API to send requests
        /// to Amazon Lex V2 at runtime. Amazon Lex V2 then interprets the user input using the
        /// machine learning model that it build for the bot.
        /// 
        ///  
        /// <para>
        /// In response, Amazon Lex V2 returns the next message to convey to the user and an optional
        /// response card to display.
        /// </para>
        ///  
        /// <para>
        /// If the optional post-fulfillment response is specified, the messages are returned
        /// as follows. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/API_PostFulfillmentStatusSpecification.html">PostFulfillmentStatusSpecification</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Success message</b> - Returned if the Lambda function completes successfully and
        /// the intent state is fulfilled or ready fulfillment if the message is present.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Failed message</b> - The failed message is returned if the Lambda function throws
        /// an exception or if the Lambda function returns a failed intent state without a message.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Timeout message</b> - If you don't configure a timeout message and a timeout,
        /// and the Lambda function doesn't return within 30 seconds, the timeout message is returned.
        /// If you configure a timeout, the timeout message is returned when the period times
        /// out. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/streaming-progress.html#progress-complete.html">Completion
        /// message</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecognizeText service method.</param>
        /// 
        /// <returns>The response from the RecognizeText service method, as returned by LexRuntimeV2.</returns>
        /// <exception cref="Amazon.LexRuntimeV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.BadGatewayException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.DependencyFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/RecognizeText">REST API Reference for RecognizeText Operation</seealso>
        public virtual RecognizeTextResponse RecognizeText(RecognizeTextRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RecognizeTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecognizeTextResponseUnmarshaller.Instance;

            return Invoke<RecognizeTextResponse>(request, options);
        }


        /// <summary>
        /// Sends user input to Amazon Lex V2. Client applications use this API to send requests
        /// to Amazon Lex V2 at runtime. Amazon Lex V2 then interprets the user input using the
        /// machine learning model that it build for the bot.
        /// 
        ///  
        /// <para>
        /// In response, Amazon Lex V2 returns the next message to convey to the user and an optional
        /// response card to display.
        /// </para>
        ///  
        /// <para>
        /// If the optional post-fulfillment response is specified, the messages are returned
        /// as follows. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/API_PostFulfillmentStatusSpecification.html">PostFulfillmentStatusSpecification</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Success message</b> - Returned if the Lambda function completes successfully and
        /// the intent state is fulfilled or ready fulfillment if the message is present.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Failed message</b> - The failed message is returned if the Lambda function throws
        /// an exception or if the Lambda function returns a failed intent state without a message.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Timeout message</b> - If you don't configure a timeout message and a timeout,
        /// and the Lambda function doesn't return within 30 seconds, the timeout message is returned.
        /// If you configure a timeout, the timeout message is returned when the period times
        /// out. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/streaming-progress.html#progress-complete.html">Completion
        /// message</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecognizeText service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RecognizeText service method, as returned by LexRuntimeV2.</returns>
        /// <exception cref="Amazon.LexRuntimeV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.BadGatewayException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.DependencyFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/RecognizeText">REST API Reference for RecognizeText Operation</seealso>
        public virtual Task<RecognizeTextResponse> RecognizeTextAsync(RecognizeTextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RecognizeTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecognizeTextResponseUnmarshaller.Instance;
            
            return InvokeAsync<RecognizeTextResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RecognizeUtterance


        /// <summary>
        /// Sends user input to Amazon Lex V2. You can send text or speech. Clients use this API
        /// to send text and audio requests to Amazon Lex V2 at runtime. Amazon Lex V2 interprets
        /// the user input using the machine learning model built for the bot.
        /// 
        ///  
        /// <para>
        /// The following request fields must be compressed with gzip and then base64 encoded
        /// before you send them to Amazon Lex V2. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// requestAttributes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// sessionState
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following response fields are compressed using gzip and then base64 encoded by
        /// Amazon Lex V2. Before you can use these fields, you must decode and decompress them.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// inputTranscript
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// interpretations
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// requestAttributes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// sessionState
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The example contains a Java application that compresses and encodes a Java object
        /// to send to Amazon Lex V2, and a second that decodes and decompresses a response from
        /// Amazon Lex V2.
        /// </para>
        ///  
        /// <para>
        /// If the optional post-fulfillment response is specified, the messages are returned
        /// as follows. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/API_PostFulfillmentStatusSpecification.html">PostFulfillmentStatusSpecification</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Success message</b> - Returned if the Lambda function completes successfully and
        /// the intent state is fulfilled or ready fulfillment if the message is present.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Failed message</b> - The failed message is returned if the Lambda function throws
        /// an exception or if the Lambda function returns a failed intent state without a message.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Timeout message</b> - If you don't configure a timeout message and a timeout,
        /// and the Lambda function doesn't return within 30 seconds, the timeout message is returned.
        /// If you configure a timeout, the timeout message is returned when the period times
        /// out. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/streaming-progress.html#progress-complete.html">Completion
        /// message</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecognizeUtterance service method.</param>
        /// 
        /// <returns>The response from the RecognizeUtterance service method, as returned by LexRuntimeV2.</returns>
        /// <exception cref="Amazon.LexRuntimeV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.BadGatewayException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.DependencyFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/RecognizeUtterance">REST API Reference for RecognizeUtterance Operation</seealso>
        public virtual RecognizeUtteranceResponse RecognizeUtterance(RecognizeUtteranceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RecognizeUtteranceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecognizeUtteranceResponseUnmarshaller.Instance;

            return Invoke<RecognizeUtteranceResponse>(request, options);
        }


        /// <summary>
        /// Sends user input to Amazon Lex V2. You can send text or speech. Clients use this API
        /// to send text and audio requests to Amazon Lex V2 at runtime. Amazon Lex V2 interprets
        /// the user input using the machine learning model built for the bot.
        /// 
        ///  
        /// <para>
        /// The following request fields must be compressed with gzip and then base64 encoded
        /// before you send them to Amazon Lex V2. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// requestAttributes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// sessionState
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following response fields are compressed using gzip and then base64 encoded by
        /// Amazon Lex V2. Before you can use these fields, you must decode and decompress them.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// inputTranscript
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// interpretations
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// requestAttributes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// sessionState
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The example contains a Java application that compresses and encodes a Java object
        /// to send to Amazon Lex V2, and a second that decodes and decompresses a response from
        /// Amazon Lex V2.
        /// </para>
        ///  
        /// <para>
        /// If the optional post-fulfillment response is specified, the messages are returned
        /// as follows. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/API_PostFulfillmentStatusSpecification.html">PostFulfillmentStatusSpecification</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Success message</b> - Returned if the Lambda function completes successfully and
        /// the intent state is fulfilled or ready fulfillment if the message is present.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Failed message</b> - The failed message is returned if the Lambda function throws
        /// an exception or if the Lambda function returns a failed intent state without a message.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Timeout message</b> - If you don't configure a timeout message and a timeout,
        /// and the Lambda function doesn't return within 30 seconds, the timeout message is returned.
        /// If you configure a timeout, the timeout message is returned when the period times
        /// out. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/streaming-progress.html#progress-complete.html">Completion
        /// message</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecognizeUtterance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RecognizeUtterance service method, as returned by LexRuntimeV2.</returns>
        /// <exception cref="Amazon.LexRuntimeV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.BadGatewayException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.DependencyFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/RecognizeUtterance">REST API Reference for RecognizeUtterance Operation</seealso>
        public virtual Task<RecognizeUtteranceResponse> RecognizeUtteranceAsync(RecognizeUtteranceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RecognizeUtteranceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecognizeUtteranceResponseUnmarshaller.Instance;
            
            return InvokeAsync<RecognizeUtteranceResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}