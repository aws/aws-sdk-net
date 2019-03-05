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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Textract.Model;

namespace Amazon.Textract
{
    /// <summary>
    /// Interface for accessing Textract
    ///
    /// Amazon Textract detects and analyzes text in documents and converts it into machine-readable
    /// text. This is the API reference documentation for Amazon Textract.
    /// </summary>
    public partial interface IAmazonTextract : IAmazonService, IDisposable
    {
                
        #region  AnalyzeDocument


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
        Task<AnalyzeDocumentResponse> AnalyzeDocumentAsync(AnalyzeDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DetectDocumentText


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
        Task<DetectDocumentTextResponse> DetectDocumentTextAsync(DetectDocumentTextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDocumentAnalysis


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
        Task<GetDocumentAnalysisResponse> GetDocumentAnalysisAsync(GetDocumentAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDocumentTextDetection


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
        Task<GetDocumentTextDetectionResponse> GetDocumentTextDetectionAsync(GetDocumentTextDetectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartDocumentAnalysis


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
        Task<StartDocumentAnalysisResponse> StartDocumentAnalysisAsync(StartDocumentAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartDocumentTextDetection


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
        Task<StartDocumentTextDetectionResponse> StartDocumentTextDetectionAsync(StartDocumentTextDetectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}