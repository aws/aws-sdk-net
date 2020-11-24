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
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial interface IAmazonTextract : IAmazonService, IDisposable
    {
                
        #region  AnalyzeDocument



        /// <summary>
        /// Analyzes an input document for relationships between detected items. 
        /// 
        ///  
        /// <para>
        /// The types of information returned are as follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Form data (key-value pairs). The related information is returned in two <a>Block</a>
        /// objects, each of type <code>KEY_VALUE_SET</code>: a KEY <code>Block</code> object
        /// and a VALUE <code>Block</code> object. For example, <i>Name: Ana Silva Carolina</i>
        /// contains a key and value. <i>Name:</i> is the key. <i>Ana Silva Carolina</i> is the
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Table and table cell data. A TABLE <code>Block</code> object contains information
        /// about a detected table. A CELL <code>Block</code> object is returned for each cell
        /// in a table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Lines and words of text. A LINE <code>Block</code> object contains one or more WORD
        /// <code>Block</code> objects. All lines and words that are detected in the document
        /// are returned (including text that doesn't have a relationship with the value of <code>FeatureTypes</code>).
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Selection elements such as check boxes and option buttons (radio buttons) can be detected
        /// in form data and in tables. A SELECTION_ELEMENT <code>Block</code> object contains
        /// information about a selection element, including the selection status.
        /// </para>
        ///  
        /// <para>
        /// You can choose which type of analysis to perform by specifying the <code>FeatureTypes</code>
        /// list. 
        /// </para>
        ///  
        /// <para>
        /// The output is returned in a list of <code>Block</code> objects.
        /// </para>
        ///  
        /// <para>
        ///  <code>AnalyzeDocument</code> is a synchronous operation. To analyze documents asynchronously,
        /// use <a>StartDocumentAnalysis</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/how-it-works-analyzing.html">Document
        /// Text Analysis</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AnalyzeDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AnalyzeDocument service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action. Use the Amazon Resource Name (ARN) of
        /// an authorized user or IAM role to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.BadDocumentException">
        /// Amazon Textract isn't able to read the document. For more information on the document
        /// limits in Amazon Textract, see <a>limits</a>.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.DocumentTooLargeException">
        /// The document can't be processed because it's too large. The maximum document size
        /// for synchronous operations 10 MB. The maximum document size for asynchronous operations
        /// is 500 MB for PDF files.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.HumanLoopQuotaExceededException">
        /// Indicates you have exceeded the maximum number of active human in the loop workflows
        /// available
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InternalServerErrorException">
        /// Amazon Textract experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidParameterException">
        /// An input parameter violated a constraint. For example, in synchronous operations,
        /// an <code>InvalidParameterException</code> exception occurs when neither of the <code>S3Object</code>
        /// or <code>Bytes</code> values are supplied in the <code>Document</code> request parameter.
        /// Validate your parameter before calling the API operation again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidS3ObjectException">
        /// Amazon Textract is unable to access the S3 object that's specified in the request.
        /// for more information, <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Configure
        /// Access to Amazon S3</a> For troubleshooting information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/troubleshooting.html">Troubleshooting
        /// Amazon S3</a>
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.UnsupportedDocumentException">
        /// The format of the input document isn't supported. Documents for synchronous operations
        /// can be in PNG or JPEG format. Documents for asynchronous operations can also be in
        /// PDF format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/AnalyzeDocument">REST API Reference for AnalyzeDocument Operation</seealso>
        Task<AnalyzeDocumentResponse> AnalyzeDocumentAsync(AnalyzeDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DetectDocumentText



        /// <summary>
        /// Detects text in the input document. Amazon Textract can detect lines of text and the
        /// words that make up a line of text. The input document must be an image in JPEG or
        /// PNG format. <code>DetectDocumentText</code> returns the detected text in an array
        /// of <a>Block</a> objects. 
        /// 
        ///  
        /// <para>
        /// Each document page has as an associated <code>Block</code> of type PAGE. Each PAGE
        /// <code>Block</code> object is the parent of LINE <code>Block</code> objects that represent
        /// the lines of detected text on a page. A LINE <code>Block</code> object is a parent
        /// for each word that makes up the line. Words are represented by <code>Block</code>
        /// objects of type WORD.
        /// </para>
        ///  
        /// <para>
        ///  <code>DetectDocumentText</code> is a synchronous operation. To analyze documents
        /// asynchronously, use <a>StartDocumentTextDetection</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/how-it-works-detecting.html">Document
        /// Text Detection</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectDocumentText service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectDocumentText service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action. Use the Amazon Resource Name (ARN) of
        /// an authorized user or IAM role to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.BadDocumentException">
        /// Amazon Textract isn't able to read the document. For more information on the document
        /// limits in Amazon Textract, see <a>limits</a>.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.DocumentTooLargeException">
        /// The document can't be processed because it's too large. The maximum document size
        /// for synchronous operations 10 MB. The maximum document size for asynchronous operations
        /// is 500 MB for PDF files.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InternalServerErrorException">
        /// Amazon Textract experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidParameterException">
        /// An input parameter violated a constraint. For example, in synchronous operations,
        /// an <code>InvalidParameterException</code> exception occurs when neither of the <code>S3Object</code>
        /// or <code>Bytes</code> values are supplied in the <code>Document</code> request parameter.
        /// Validate your parameter before calling the API operation again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidS3ObjectException">
        /// Amazon Textract is unable to access the S3 object that's specified in the request.
        /// for more information, <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Configure
        /// Access to Amazon S3</a> For troubleshooting information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/troubleshooting.html">Troubleshooting
        /// Amazon S3</a>
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.UnsupportedDocumentException">
        /// The format of the input document isn't supported. Documents for synchronous operations
        /// can be in PNG or JPEG format. Documents for asynchronous operations can also be in
        /// PDF format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/DetectDocumentText">REST API Reference for DetectDocumentText Operation</seealso>
        Task<DetectDocumentTextResponse> DetectDocumentTextAsync(DetectDocumentTextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDocumentAnalysis



        /// <summary>
        /// Gets the results for an Amazon Textract asynchronous operation that analyzes text
        /// in a document.
        /// 
        ///  
        /// <para>
        /// You start asynchronous text analysis by calling <a>StartDocumentAnalysis</a>, which
        /// returns a job identifier (<code>JobId</code>). When the text analysis operation finishes,
        /// Amazon Textract publishes a completion status to the Amazon Simple Notification Service
        /// (Amazon SNS) topic that's registered in the initial call to <code>StartDocumentAnalysis</code>.
        /// To get the results of the text-detection operation, first check that the status value
        /// published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <code>GetDocumentAnalysis</code>,
        /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartDocumentAnalysis</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetDocumentAnalysis</code> returns an array of <a>Block</a> objects. The following
        /// types of information are returned: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Form data (key-value pairs). The related information is returned in two <a>Block</a>
        /// objects, each of type <code>KEY_VALUE_SET</code>: a KEY <code>Block</code> object
        /// and a VALUE <code>Block</code> object. For example, <i>Name: Ana Silva Carolina</i>
        /// contains a key and value. <i>Name:</i> is the key. <i>Ana Silva Carolina</i> is the
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Table and table cell data. A TABLE <code>Block</code> object contains information
        /// about a detected table. A CELL <code>Block</code> object is returned for each cell
        /// in a table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Lines and words of text. A LINE <code>Block</code> object contains one or more WORD
        /// <code>Block</code> objects. All lines and words that are detected in the document
        /// are returned (including text that doesn't have a relationship with the value of the
        /// <code>StartDocumentAnalysis</code> <code>FeatureTypes</code> input parameter). 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Selection elements such as check boxes and option buttons (radio buttons) can be detected
        /// in form data and in tables. A SELECTION_ELEMENT <code>Block</code> object contains
        /// information about a selection element, including the selection status.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>MaxResults</code> parameter to limit the number of blocks that are returned.
        /// If there are more results than specified in <code>MaxResults</code>, the value of
        /// <code>NextToken</code> in the operation response contains a pagination token for getting
        /// the next set of results. To get the next page of results, call <code>GetDocumentAnalysis</code>,
        /// and populate the <code>NextToken</code> request parameter with the token value that's
        /// returned from the previous call to <code>GetDocumentAnalysis</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/how-it-works-analyzing.html">Document
        /// Text Analysis</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDocumentAnalysis service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action. Use the Amazon Resource Name (ARN) of
        /// an authorized user or IAM role to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InternalServerErrorException">
        /// Amazon Textract experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidJobIdException">
        /// An invalid job identifier was passed to <a>GetDocumentAnalysis</a> or to <a>GetDocumentAnalysis</a>.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidParameterException">
        /// An input parameter violated a constraint. For example, in synchronous operations,
        /// an <code>InvalidParameterException</code> exception occurs when neither of the <code>S3Object</code>
        /// or <code>Bytes</code> values are supplied in the <code>Document</code> request parameter.
        /// Validate your parameter before calling the API operation again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidS3ObjectException">
        /// Amazon Textract is unable to access the S3 object that's specified in the request.
        /// for more information, <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Configure
        /// Access to Amazon S3</a> For troubleshooting information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/troubleshooting.html">Troubleshooting
        /// Amazon S3</a>
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/GetDocumentAnalysis">REST API Reference for GetDocumentAnalysis Operation</seealso>
        Task<GetDocumentAnalysisResponse> GetDocumentAnalysisAsync(GetDocumentAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDocumentTextDetection



        /// <summary>
        /// Gets the results for an Amazon Textract asynchronous operation that detects text in
        /// a document. Amazon Textract can detect lines of text and the words that make up a
        /// line of text.
        /// 
        ///  
        /// <para>
        /// You start asynchronous text detection by calling <a>StartDocumentTextDetection</a>,
        /// which returns a job identifier (<code>JobId</code>). When the text detection operation
        /// finishes, Amazon Textract publishes a completion status to the Amazon Simple Notification
        /// Service (Amazon SNS) topic that's registered in the initial call to <code>StartDocumentTextDetection</code>.
        /// To get the results of the text-detection operation, first check that the status value
        /// published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <code>GetDocumentTextDetection</code>,
        /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartDocumentTextDetection</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetDocumentTextDetection</code> returns an array of <a>Block</a> objects. 
        /// </para>
        ///  
        /// <para>
        /// Each document page has as an associated <code>Block</code> of type PAGE. Each PAGE
        /// <code>Block</code> object is the parent of LINE <code>Block</code> objects that represent
        /// the lines of detected text on a page. A LINE <code>Block</code> object is a parent
        /// for each word that makes up the line. Words are represented by <code>Block</code>
        /// objects of type WORD.
        /// </para>
        ///  
        /// <para>
        /// Use the MaxResults parameter to limit the number of blocks that are returned. If there
        /// are more results than specified in <code>MaxResults</code>, the value of <code>NextToken</code>
        /// in the operation response contains a pagination token for getting the next set of
        /// results. To get the next page of results, call <code>GetDocumentTextDetection</code>,
        /// and populate the <code>NextToken</code> request parameter with the token value that's
        /// returned from the previous call to <code>GetDocumentTextDetection</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/how-it-works-detecting.html">Document
        /// Text Detection</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentTextDetection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDocumentTextDetection service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action. Use the Amazon Resource Name (ARN) of
        /// an authorized user or IAM role to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InternalServerErrorException">
        /// Amazon Textract experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidJobIdException">
        /// An invalid job identifier was passed to <a>GetDocumentAnalysis</a> or to <a>GetDocumentAnalysis</a>.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidParameterException">
        /// An input parameter violated a constraint. For example, in synchronous operations,
        /// an <code>InvalidParameterException</code> exception occurs when neither of the <code>S3Object</code>
        /// or <code>Bytes</code> values are supplied in the <code>Document</code> request parameter.
        /// Validate your parameter before calling the API operation again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidS3ObjectException">
        /// Amazon Textract is unable to access the S3 object that's specified in the request.
        /// for more information, <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Configure
        /// Access to Amazon S3</a> For troubleshooting information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/troubleshooting.html">Troubleshooting
        /// Amazon S3</a>
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/GetDocumentTextDetection">REST API Reference for GetDocumentTextDetection Operation</seealso>
        Task<GetDocumentTextDetectionResponse> GetDocumentTextDetectionAsync(GetDocumentTextDetectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartDocumentAnalysis



        /// <summary>
        /// Starts the asynchronous analysis of an input document for relationships between detected
        /// items such as key-value pairs, tables, and selection elements.
        /// 
        ///  
        /// <para>
        ///  <code>StartDocumentAnalysis</code> can analyze text in documents that are in JPEG,
        /// PNG, and PDF format. The documents are stored in an Amazon S3 bucket. Use <a>DocumentLocation</a>
        /// to specify the bucket name and file name of the document. 
        /// </para>
        ///  
        /// <para>
        ///  <code>StartDocumentAnalysis</code> returns a job identifier (<code>JobId</code>)
        /// that you use to get the results of the operation. When text analysis is finished,
        /// Amazon Textract publishes a completion status to the Amazon Simple Notification Service
        /// (Amazon SNS) topic that you specify in <code>NotificationChannel</code>. To get the
        /// results of the text analysis operation, first check that the status value published
        /// to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <a>GetDocumentAnalysis</a>,
        /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartDocumentAnalysis</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/how-it-works-analyzing.html">Document
        /// Text Analysis</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDocumentAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDocumentAnalysis service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action. Use the Amazon Resource Name (ARN) of
        /// an authorized user or IAM role to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.BadDocumentException">
        /// Amazon Textract isn't able to read the document. For more information on the document
        /// limits in Amazon Textract, see <a>limits</a>.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.DocumentTooLargeException">
        /// The document can't be processed because it's too large. The maximum document size
        /// for synchronous operations 10 MB. The maximum document size for asynchronous operations
        /// is 500 MB for PDF files.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.IdempotentParameterMismatchException">
        /// A <code>ClientRequestToken</code> input parameter was reused with an operation, but
        /// at least one of the other input parameters is different from the previous call to
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InternalServerErrorException">
        /// Amazon Textract experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidKMSKeyException">
        /// Indicates you do not have decrypt permissions with the KMS key entered, or the KMS
        /// key was entered incorrectly.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidParameterException">
        /// An input parameter violated a constraint. For example, in synchronous operations,
        /// an <code>InvalidParameterException</code> exception occurs when neither of the <code>S3Object</code>
        /// or <code>Bytes</code> values are supplied in the <code>Document</code> request parameter.
        /// Validate your parameter before calling the API operation again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidS3ObjectException">
        /// Amazon Textract is unable to access the S3 object that's specified in the request.
        /// for more information, <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Configure
        /// Access to Amazon S3</a> For troubleshooting information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/troubleshooting.html">Troubleshooting
        /// Amazon S3</a>
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.LimitExceededException">
        /// An Amazon Textract service limit was exceeded. For example, if you start too many
        /// asynchronous jobs concurrently, calls to start operations (<code>StartDocumentTextDetection</code>,
        /// for example) raise a LimitExceededException exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Textract service limit.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.UnsupportedDocumentException">
        /// The format of the input document isn't supported. Documents for synchronous operations
        /// can be in PNG or JPEG format. Documents for asynchronous operations can also be in
        /// PDF format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/StartDocumentAnalysis">REST API Reference for StartDocumentAnalysis Operation</seealso>
        Task<StartDocumentAnalysisResponse> StartDocumentAnalysisAsync(StartDocumentAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartDocumentTextDetection



        /// <summary>
        /// Starts the asynchronous detection of text in a document. Amazon Textract can detect
        /// lines of text and the words that make up a line of text.
        /// 
        ///  
        /// <para>
        ///  <code>StartDocumentTextDetection</code> can analyze text in documents that are in
        /// JPEG, PNG, and PDF format. The documents are stored in an Amazon S3 bucket. Use <a>DocumentLocation</a>
        /// to specify the bucket name and file name of the document. 
        /// </para>
        ///  
        /// <para>
        ///  <code>StartTextDetection</code> returns a job identifier (<code>JobId</code>) that
        /// you use to get the results of the operation. When text detection is finished, Amazon
        /// Textract publishes a completion status to the Amazon Simple Notification Service (Amazon
        /// SNS) topic that you specify in <code>NotificationChannel</code>. To get the results
        /// of the text detection operation, first check that the status value published to the
        /// Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <a>GetDocumentTextDetection</a>,
        /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartDocumentTextDetection</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/how-it-works-detecting.html">Document
        /// Text Detection</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDocumentTextDetection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDocumentTextDetection service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action. Use the Amazon Resource Name (ARN) of
        /// an authorized user or IAM role to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.BadDocumentException">
        /// Amazon Textract isn't able to read the document. For more information on the document
        /// limits in Amazon Textract, see <a>limits</a>.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.DocumentTooLargeException">
        /// The document can't be processed because it's too large. The maximum document size
        /// for synchronous operations 10 MB. The maximum document size for asynchronous operations
        /// is 500 MB for PDF files.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.IdempotentParameterMismatchException">
        /// A <code>ClientRequestToken</code> input parameter was reused with an operation, but
        /// at least one of the other input parameters is different from the previous call to
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InternalServerErrorException">
        /// Amazon Textract experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidKMSKeyException">
        /// Indicates you do not have decrypt permissions with the KMS key entered, or the KMS
        /// key was entered incorrectly.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidParameterException">
        /// An input parameter violated a constraint. For example, in synchronous operations,
        /// an <code>InvalidParameterException</code> exception occurs when neither of the <code>S3Object</code>
        /// or <code>Bytes</code> values are supplied in the <code>Document</code> request parameter.
        /// Validate your parameter before calling the API operation again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidS3ObjectException">
        /// Amazon Textract is unable to access the S3 object that's specified in the request.
        /// for more information, <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Configure
        /// Access to Amazon S3</a> For troubleshooting information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/troubleshooting.html">Troubleshooting
        /// Amazon S3</a>
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.LimitExceededException">
        /// An Amazon Textract service limit was exceeded. For example, if you start too many
        /// asynchronous jobs concurrently, calls to start operations (<code>StartDocumentTextDetection</code>,
        /// for example) raise a LimitExceededException exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Textract service limit.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.UnsupportedDocumentException">
        /// The format of the input document isn't supported. Documents for synchronous operations
        /// can be in PNG or JPEG format. Documents for asynchronous operations can also be in
        /// PDF format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/StartDocumentTextDetection">REST API Reference for StartDocumentTextDetection Operation</seealso>
        Task<StartDocumentTextDetectionResponse> StartDocumentTextDetectionAsync(StartDocumentTextDetectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}