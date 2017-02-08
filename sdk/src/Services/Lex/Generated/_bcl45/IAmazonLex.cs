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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Lex.Model;

namespace Amazon.Lex
{
    /// <summary>
    /// Interface for accessing Lex
    ///
    /// Amazon Lex provides both build and runtime endpoints. Each endpoint provides a set
    /// of operations (API). Your application uses the runtime API to understand user utterances
    /// (user input text or voice). For example, suppose user says "I want pizza", your application
    /// sends this input to Amazon Lex using the runtime API. Amazon Lex recognizes that the
    /// user request is for the OrderPizza intent (one of the intents defined in the application).
    /// Then Amazon Lex engages in user conversation on behalf of the application to elicit
    /// required information (slot values, such as pizza size and crust type), and then performs
    /// fulfillment activity (that you configured when you created the application). You use
    /// the build-time API to create and manage your Amazon Lex applications. For a list of
    /// build-time operations, see the build-time API. .
    /// </summary>
    public partial interface IAmazonLex : IAmazonService, IDisposable
    {

        
        #region  PostText


        /// <summary>
        /// Sends user input text to Amazon Lex at runtime. Amazon Lex uses the machine learning
        /// model that the service built for the application to interpret user input. 
        /// 
        ///  
        /// <para>
        ///  In response, Amazon Lex returns the next message to convey to the user (based on
        /// the context of the user interaction) and whether to expect a user response to the
        /// message (<code>dialogState</code>). For example, consider the following response messages:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// "What pizza toppings would you like?" – In this case, the <code>dialogState</code>
        /// would be <code>ElicitSlot</code> (that is, a user response is expected). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "Your order has been placed." – In this case, Amazon Lex returns one of the following
        /// <code>dialogState</code> values depending on how the intent fulfillment is configured
        /// (see <code>fulfillmentActivity</code> in <code>CreateIntent</code>): 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>FulFilled</code> – The intent fulfillment is configured through a Lambda function.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReadyForFulfilment</code> – The intent's <code>fulfillmentActivity</code> is
        /// to simply return the intent data back to the client application. 
        /// </para>
        ///  </li> </ul> </li> </ul>
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
        /// build failed.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.ConflictException">
        /// Two clients are using the same AWS account, Amazon Lex bot, and user ID.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.DependencyFailedException">
        /// One of the downstream dependencies, such as AWS Lambda or Amazon Polly, threw an
        /// exception. For example, if Amazon Lex does not have sufficient permissions to call
        /// a Lambda function which results in AWS Lambda throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.InternalFailureException">
        /// Internal service error. Retry the call.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.LoopDetectedException">
        /// Lambda fulfilment function returned <code>DelegateDialogAction</code> to Amazon Lex
        /// without changing any slot values.
        /// </exception>
        /// <exception cref="Amazon.Lex.Model.NotFoundException">
        /// Resource (such as the Amazon Lex bot or an alias) referred is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex-2016-11-28/PostText">REST API Reference for PostText Operation</seealso>
        PostTextResponse PostText(PostTextRequest request);


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
        Task<PostTextResponse> PostTextAsync(PostTextRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}