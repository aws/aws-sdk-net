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
        /// Initiates the asynchronous execution of the PostText operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PostText operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex-2016-11-28/PostText">REST API Reference for PostText Operation</seealso>
        Task<PostTextResponse> PostTextAsync(PostTextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}