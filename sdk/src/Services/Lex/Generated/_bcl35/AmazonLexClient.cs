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

        /// <summary>
        /// Sends user input (text or speech) to Amazon Lex. Clients use this API to send text
        /// and audio requests to Amazon Lex at runtime. Amazon Lex interprets the user input
        /// using the machine learning model that it built for the bot. 
        /// 
        ///  
        /// <para>
        /// The <code>PostContent</code> operation supports audio input at 8kHz and 16kHz. You
        /// can use 8kHz audio to achieve higher speech recognition accuracy in telephone audio
        /// applications. 
        /// </para>
        ///  
        /// <para>
        ///  In response, Amazon Lex returns the next message to convey to the user. Consider
        /// the following example messages: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For a user input "I would like a pizza," Amazon Lex might return a response with
        /// a message eliciting slot data (for example, <code>PizzaSize</code>): "What size pizza
        /// would you like?". 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  After the user provides all of the pizza order information, Amazon Lex might return
        /// a response with a message to get user confirmation: "Order the pizza?". 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  After the user replies "Yes" to the confirmation prompt, Amazon Lex might return
        /// a conclusion statement: "Thank you, your cheese pizza has been ordered.". 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Not all Amazon Lex messages require a response from the user. For example, conclusion
        /// statements do not require a response. Some messages require only a yes or no response.
        /// In addition to the <code>message</code>, Amazon Lex provides additional context about
        /// the message in the response that you can use to enhance client behavior, such as displaying
        /// the appropriate client user interface. Consider the following examples: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  If the message is to elicit slot data, Amazon Lex returns the following context information:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>x-amz-lex-dialog-state</code> header set to <code>ElicitSlot</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-lex-intent-name</code> header set to the intent name in the current context
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-lex-slot-to-elicit</code> header set to the slot name for which the <code>message</code>
        /// is eliciting information 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-lex-slots</code> header set to a map of slots configured for the intent
        /// with their current values 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  If the message is a confirmation prompt, the <code>x-amz-lex-dialog-state</code>
        /// header is set to <code>Confirmation</code> and the <code>x-amz-lex-slot-to-elicit</code>
        /// header is omitted. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If the message is a clarification prompt configured for the intent, indicating that
        /// the user intent is not understood, the <code>x-amz-dialog-state</code> header is set
        /// to <code>ElicitIntent</code> and the <code>x-amz-slot-to-elicit</code> header is omitted.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  In addition, Amazon Lex also returns your application-specific <code>sessionAttributes</code>.
        /// For more information, see <a href="http://docs.aws.amazon.com/lex/latest/dg/context-mgmt.html">Managing
        /// Conversation Context</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostContent service method.</param>
        /// 
        /// <returns>The response from the PostContent service method, as returned by Lex.</returns>
        /// <exception cref="Amazon.Lex.Model.BadGatewayException">
        /// Either the Amazon Lex bot is still building, or one of the dependent services (Amazon
        /// Polly, AWS Lambda) failed with an internal service error.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.BadRequestException">
        /// Request validation failed, there is no usable message in the context, or the bot
        /// build failed, is still in progress, or contains unbuilt changes.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.ConflictException">
        /// Two clients are using the same AWS account, Amazon Lex bot, and user ID.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.DependencyFailedException">
        /// One of the dependencies, such as AWS Lambda or Amazon Polly, threw an exception.
        /// For example, 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If Amazon Lex does not have sufficient permissions to call a Lambda function.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a Lambda function takes longer than 30 seconds to execute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a fulfillment Lambda function returns a <code>Delegate</code> dialog action without
        /// removing any slot values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.InternalFailureException">
        /// Internal service error. Retry the call.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.LimitExceededException">
        /// Exceeded a limit.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.LoopDetectedException">
        /// This exception is not used.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.NotAcceptableException">
        /// The accept header in the request does not have a valid value.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.NotFoundException">
        /// The resource (such as the Amazon Lex bot or an alias) that is referred to is not found.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.RequestTimeoutException">
        /// The input speech is too long.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.UnsupportedMediaTypeException">
        /// The Content-Type header (<code>PostContent</code> API) has an invalid value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex-2016-11-28/PostContent">REST API Reference for PostContent Operation</seealso>
        public virtual PostContentResponse PostContent(PostContentRequest request)
        {
            var marshaller = PostContentRequestMarshaller.Instance;
            var unmarshaller = PostContentResponseUnmarshaller.Instance;

            return Invoke<PostContentRequest,PostContentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PostContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PostContent operation on AmazonLexClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPostContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex-2016-11-28/PostContent">REST API Reference for PostContent Operation</seealso>
        public virtual IAsyncResult BeginPostContent(PostContentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PostContentRequestMarshaller.Instance;
            var unmarshaller = PostContentResponseUnmarshaller.Instance;

            return BeginInvoke<PostContentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PostContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPostContent.</param>
        /// 
        /// <returns>Returns a  PostContentResult from Lex.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex-2016-11-28/PostContent">REST API Reference for PostContent Operation</seealso>
        public virtual PostContentResponse EndPostContent(IAsyncResult asyncResult)
        {
            return EndInvoke<PostContentResponse>(asyncResult);
        }

        #endregion
        
        #region  PostText

        /// <summary>
        /// Sends user input (text-only) to Amazon Lex. Client applications can use this API to
        /// send requests to Amazon Lex at runtime. Amazon Lex then interprets the user input
        /// using the machine learning model it built for the bot. 
        /// 
        ///  
        /// <para>
        ///  In response, Amazon Lex returns the next <code>message</code> to convey to the user
        /// an optional <code>responseCard</code> to display. Consider the following example messages:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For a user input "I would like a pizza", Amazon Lex might return a response with
        /// a message eliciting slot data (for example, PizzaSize): "What size pizza would you
        /// like?" 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  After the user provides all of the pizza order information, Amazon Lex might return
        /// a response with a message to obtain user confirmation "Proceed with the pizza order?".
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  After the user replies to a confirmation prompt with a "yes", Amazon Lex might return
        /// a conclusion statement: "Thank you, your cheese pizza has been ordered.". 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Not all Amazon Lex messages require a user response. For example, a conclusion statement
        /// does not require a response. Some messages require only a "yes" or "no" user response.
        /// In addition to the <code>message</code>, Amazon Lex provides additional context about
        /// the message in the response that you might use to enhance client behavior, for example,
        /// to display the appropriate client user interface. These are the <code>slotToElicit</code>,
        /// <code>dialogState</code>, <code>intentName</code>, and <code>slots</code> fields in
        /// the response. Consider the following examples: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the message is to elicit slot data, Amazon Lex returns the following context information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>dialogState</code> set to ElicitSlot 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>intentName</code> set to the intent name in the current context 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>slotToElicit</code> set to the slot name for which the <code>message</code>
        /// is eliciting information 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>slots</code> set to a map of slots, configured for the intent, with currently
        /// known values 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  If the message is a confirmation prompt, the <code>dialogState</code> is set to ConfirmIntent
        /// and <code>SlotToElicit</code> is set to null. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the message is a clarification prompt (configured for the intent) that indicates
        /// that user intent is not understood, the <code>dialogState</code> is set to ElicitIntent
        /// and <code>slotToElicit</code> is set to null. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  In addition, Amazon Lex also returns your application-specific <code>sessionAttributes</code>.
        /// For more information, see <a href="http://docs.aws.amazon.com/lex/latest/dg/context-mgmt.html">Managing
        /// Conversation Context</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostText service method.</param>
        /// 
        /// <returns>The response from the PostText service method, as returned by Lex.</returns>
        /// <exception cref="Amazon.Lex.Model.BadGatewayException">
        /// Either the Amazon Lex bot is still building, or one of the dependent services (Amazon
        /// Polly, AWS Lambda) failed with an internal service error.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.BadRequestException">
        /// Request validation failed, there is no usable message in the context, or the bot
        /// build failed, is still in progress, or contains unbuilt changes.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.ConflictException">
        /// Two clients are using the same AWS account, Amazon Lex bot, and user ID.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.DependencyFailedException">
        /// One of the dependencies, such as AWS Lambda or Amazon Polly, threw an exception.
        /// For example, 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If Amazon Lex does not have sufficient permissions to call a Lambda function.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a Lambda function takes longer than 30 seconds to execute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a fulfillment Lambda function returns a <code>Delegate</code> dialog action without
        /// removing any slot values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.InternalFailureException">
        /// Internal service error. Retry the call.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.LimitExceededException">
        /// Exceeded a limit.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.LoopDetectedException">
        /// This exception is not used.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.NotFoundException">
        /// The resource (such as the Amazon Lex bot or an alias) that is referred to is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex-2016-11-28/PostText">REST API Reference for PostText Operation</seealso>
        public virtual PostTextResponse PostText(PostTextRequest request)
        {
            var marshaller = PostTextRequestMarshaller.Instance;
            var unmarshaller = PostTextResponseUnmarshaller.Instance;

            return Invoke<PostTextRequest,PostTextResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PostText operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PostText operation on AmazonLexClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPostText
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex-2016-11-28/PostText">REST API Reference for PostText Operation</seealso>
        public virtual IAsyncResult BeginPostText(PostTextRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PostTextRequestMarshaller.Instance;
            var unmarshaller = PostTextResponseUnmarshaller.Instance;

            return BeginInvoke<PostTextRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PostText operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPostText.</param>
        /// 
        /// <returns>Returns a  PostTextResult from Lex.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex-2016-11-28/PostText">REST API Reference for PostText Operation</seealso>
        public virtual PostTextResponse EndPostText(IAsyncResult asyncResult)
        {
            return EndInvoke<PostTextResponse>(asyncResult);
        }

        #endregion
        
    }
}