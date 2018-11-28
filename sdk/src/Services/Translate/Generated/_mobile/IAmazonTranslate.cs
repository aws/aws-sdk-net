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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Translate.Model;

namespace Amazon.Translate
{
    /// <summary>
    /// Interface for accessing Translate
    ///
    /// Provides translation between one source language and another of the same set of languages.
    /// </summary>
    public partial interface IAmazonTranslate : IAmazonService, IDisposable
    {
                
        #region  DeleteTerminology


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
        Task<DeleteTerminologyResponse> DeleteTerminologyAsync(DeleteTerminologyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTerminology


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
        Task<GetTerminologyResponse> GetTerminologyAsync(GetTerminologyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportTerminology


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
        Task<ImportTerminologyResponse> ImportTerminologyAsync(ImportTerminologyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTerminologies


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
        Task<ListTerminologiesResponse> ListTerminologiesAsync(ListTerminologiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TranslateText


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
        Task<TranslateTextResponse> TranslateTextAsync(TranslateTextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}