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
using System.Collections.Generic;
using System.Net;

using Amazon.Textract.Model;
using Amazon.Textract.Model.Internal.MarshallTransformations;
using Amazon.Textract.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Textract
{
    /// <summary>
    /// Implementation for accessing Textract
    ///
    /// Amazon Textract detects and analyzes text in documents and converts it into machine-readable
    /// text. This is the API reference documentation for Amazon Textract.
    /// </summary>
    public partial class AmazonTextractClient : AmazonServiceClient, IAmazonTextract
    {
        private static IServiceMetadata serviceMetadata = new AmazonTextractMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonTextractClient with the credentials loaded from the application's
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
        public AmazonTextractClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTextractConfig()) { }

        /// <summary>
        /// Constructs AmazonTextractClient with the credentials loaded from the application's
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
        public AmazonTextractClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTextractConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonTextractClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonTextractClient Configuration Object</param>
        public AmazonTextractClient(AmazonTextractConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonTextractClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonTextractClient(AWSCredentials credentials)
            : this(credentials, new AmazonTextractConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTextractClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTextractClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonTextractConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTextractClient with AWS Credentials and an
        /// AmazonTextractClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonTextractClient Configuration Object</param>
        public AmazonTextractClient(AWSCredentials credentials, AmazonTextractConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTextractClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonTextractClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTextractConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTextractClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTextractClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTextractConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonTextractClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTextractClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonTextractClient Configuration Object</param>
        public AmazonTextractClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonTextractConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTextractClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonTextractClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTextractConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTextractClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTextractClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTextractConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTextractClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTextractClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonTextractClient Configuration Object</param>
        public AmazonTextractClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonTextractConfig clientConfig)
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


        #region  AnalyzeDocument

        /// <summary>
        /// Analyzes an input document for relationships in the detected text and tables. 
        /// 
        ///  
        /// <para>
        /// Two types of information are returned: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Words and lines that are related to nearby lines and words. The related information
        /// is returned in two <a>Block</a> objects: a KEY Block object and a VALUE Block object.
        /// For example, <i>Name: Ana Silva Carolina</i> contains a key and value. <i>Name:</i>
        /// is the key. <i>Ana Silva Carolina</i> is the value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Table and table cell data. A TABLE Block contains information about a detected table.
        /// A CELL block is returned for each cell in a table.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can choose which type of analysis to perform by specifying the <code>FeatureTypes</code>
        /// list. 
        /// </para>
        ///  
        /// <para>
        /// The output is returned in a list of <code>BLOCK</code> objects (Blocks). For more
        /// information, see <a>how-it-works-analyzing</a>.
        /// </para>
        ///  
        /// <para>
        ///  <code>AnalyzeDocument</code> is a synchronous operation. To analyze documents asynchronously,
        /// use <a>StartDocumentAnalysis</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AnalyzeDocument service method.</param>
        /// 
        /// <returns>The response from the AnalyzeDocument service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.BadDocumentException">
        /// Amazon Textract isn't able to read the document.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.DocumentTooLargeException">
        /// The document can't be processed because it's too large. The maximum document size
        /// for synchronous operations 5 MB. The maximum document size for asynchronous operations
        /// is 500 MB for PDF format files.
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
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.UnsupportedDocumentException">
        /// The format of the input document isn't supported. Amazon Textract supports documents
        /// that are .png or .jpg format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/AnalyzeDocument">REST API Reference for AnalyzeDocument Operation</seealso>
        public virtual AnalyzeDocumentResponse AnalyzeDocument(AnalyzeDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AnalyzeDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AnalyzeDocumentResponseUnmarshaller.Instance;

            return Invoke<AnalyzeDocumentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AnalyzeDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AnalyzeDocument operation on AmazonTextractClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAnalyzeDocument
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/AnalyzeDocument">REST API Reference for AnalyzeDocument Operation</seealso>
        public virtual IAsyncResult BeginAnalyzeDocument(AnalyzeDocumentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AnalyzeDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AnalyzeDocumentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AnalyzeDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAnalyzeDocument.</param>
        /// 
        /// <returns>Returns a  AnalyzeDocumentResult from Textract.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/AnalyzeDocument">REST API Reference for AnalyzeDocument Operation</seealso>
        public virtual AnalyzeDocumentResponse EndAnalyzeDocument(IAsyncResult asyncResult)
        {
            return EndInvoke<AnalyzeDocumentResponse>(asyncResult);
        }

        #endregion
        
        #region  DetectDocumentText

        /// <summary>
        /// Detects text in the input document. Amazon Textract can detect lines of text and the
        /// words that make up a line of text. The input document must be an image in JPG or PNG
        /// format. <code>DetectDocumentText</code> returns the detected text in an array of <a>Block</a>
        /// objects. For more information, see <a>how-it-works-detecting</a>.
        /// 
        ///  
        /// <para>
        ///  <code>DetectDocumentText</code> is a synchronous operation. To analyze documents
        /// asynchronously, use <a>StartDocumentTextDetection</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectDocumentText service method.</param>
        /// 
        /// <returns>The response from the DetectDocumentText service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.BadDocumentException">
        /// Amazon Textract isn't able to read the document.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.DocumentTooLargeException">
        /// The document can't be processed because it's too large. The maximum document size
        /// for synchronous operations 5 MB. The maximum document size for asynchronous operations
        /// is 500 MB for PDF format files.
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
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.UnsupportedDocumentException">
        /// The format of the input document isn't supported. Amazon Textract supports documents
        /// that are .png or .jpg format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/DetectDocumentText">REST API Reference for DetectDocumentText Operation</seealso>
        public virtual DetectDocumentTextResponse DetectDocumentText(DetectDocumentTextRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectDocumentTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectDocumentTextResponseUnmarshaller.Instance;

            return Invoke<DetectDocumentTextResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetectDocumentText operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectDocumentText operation on AmazonTextractClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectDocumentText
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/DetectDocumentText">REST API Reference for DetectDocumentText Operation</seealso>
        public virtual IAsyncResult BeginDetectDocumentText(DetectDocumentTextRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectDocumentTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectDocumentTextResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetectDocumentText operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectDocumentText.</param>
        /// 
        /// <returns>Returns a  DetectDocumentTextResult from Textract.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/DetectDocumentText">REST API Reference for DetectDocumentText Operation</seealso>
        public virtual DetectDocumentTextResponse EndDetectDocumentText(IAsyncResult asyncResult)
        {
            return EndInvoke<DetectDocumentTextResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDocumentAnalysis

        /// <summary>
        /// Gets the results for an Amazon Textract asynchronous operation that analyzes text
        /// in a document image.
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
        ///  <code>GetDocumentAnalysis</code> returns an array of <a>Block</a> objects. For more
        /// information, see <a>how-it-works-analyzing</a>.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>MaxResults</code> parameter to limit the number of blocks returned.
        /// If there are more results than specified in <code>MaxResults</code>, the value of
        /// <code>NextToken</code> in the operation response contains a pagination token for getting
        /// the next set of results. To get the next page of results, call <code>GetDocumentAnalysis</code>,
        /// and populate the <code>NextToken</code> request parameter with the token value that's
        /// returned from the previous call to <code>GetDocumentAnalysis</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentAnalysis service method.</param>
        /// 
        /// <returns>The response from the GetDocumentAnalysis service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action.
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
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/GetDocumentAnalysis">REST API Reference for GetDocumentAnalysis Operation</seealso>
        public virtual GetDocumentAnalysisResponse GetDocumentAnalysis(GetDocumentAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDocumentAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentAnalysisResponseUnmarshaller.Instance;

            return Invoke<GetDocumentAnalysisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDocumentAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentAnalysis operation on AmazonTextractClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDocumentAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/GetDocumentAnalysis">REST API Reference for GetDocumentAnalysis Operation</seealso>
        public virtual IAsyncResult BeginGetDocumentAnalysis(GetDocumentAnalysisRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDocumentAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentAnalysisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocumentAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocumentAnalysis.</param>
        /// 
        /// <returns>Returns a  GetDocumentAnalysisResult from Textract.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/GetDocumentAnalysis">REST API Reference for GetDocumentAnalysis Operation</seealso>
        public virtual GetDocumentAnalysisResponse EndGetDocumentAnalysis(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDocumentAnalysisResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDocumentTextDetection

        /// <summary>
        /// Gets the results for an Amazon Textract asynchronous operation that detects text in
        /// a document image. Amazon Textract can detect lines of text and the words that make
        /// up a line of text.
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
        ///  <code>GetDocumentTextDetection</code> returns an array of <a>Block</a> objects. For
        /// more information, see <a>how-it-works-detecting</a>.
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
        /// For more information, see Document Text Detection in the Amazon Textract Developer
        /// Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentTextDetection service method.</param>
        /// 
        /// <returns>The response from the GetDocumentTextDetection service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action.
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
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/GetDocumentTextDetection">REST API Reference for GetDocumentTextDetection Operation</seealso>
        public virtual GetDocumentTextDetectionResponse GetDocumentTextDetection(GetDocumentTextDetectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDocumentTextDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentTextDetectionResponseUnmarshaller.Instance;

            return Invoke<GetDocumentTextDetectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDocumentTextDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentTextDetection operation on AmazonTextractClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDocumentTextDetection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/GetDocumentTextDetection">REST API Reference for GetDocumentTextDetection Operation</seealso>
        public virtual IAsyncResult BeginGetDocumentTextDetection(GetDocumentTextDetectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDocumentTextDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentTextDetectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocumentTextDetection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocumentTextDetection.</param>
        /// 
        /// <returns>Returns a  GetDocumentTextDetectionResult from Textract.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/GetDocumentTextDetection">REST API Reference for GetDocumentTextDetection Operation</seealso>
        public virtual GetDocumentTextDetectionResponse EndGetDocumentTextDetection(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDocumentTextDetectionResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDocumentAnalysis

        /// <summary>
        /// Starts asynchronous analysis of text for relationships in the text and tables that
        /// are detected in a document. Amazon Textract returns for two types of information:
        /// 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Words and lines that are related to nearby lines and words. The related information
        /// is returned in two <a>Block</a> objects: A KEY Block object and a VALUE Block object.
        /// For example, <i>Name: Ana Silva Carolina</i> contains a key and value. <i>Name:</i>
        /// is the key. <i>Ana Silva Carolina</i> is the value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Table and table cell data. A TABLE block contains information about a detected table.
        /// A CELL block is returned for each cell in a table.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon Textract can analyze text in document images and PDF files that are stored
        /// in an Amazon S3 bucket. Use <a>DocumentLocation</a> to specify the bucket name and
        /// file name of the document image. 
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
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDocumentAnalysis service method.</param>
        /// 
        /// <returns>The response from the StartDocumentAnalysis service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.BadDocumentException">
        /// Amazon Textract isn't able to read the document.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.DocumentTooLargeException">
        /// The document can't be processed because it's too large. The maximum document size
        /// for synchronous operations 5 MB. The maximum document size for asynchronous operations
        /// is 500 MB for PDF format files.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.IdempotentParameterMismatchException">
        /// A <code>ClientRequestToken</code> input parameter was reused with an operation, but
        /// at least one of the other input parameters is different from the previous call to
        /// the operation.
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
        /// The format of the input document isn't supported. Amazon Textract supports documents
        /// that are .png or .jpg format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/StartDocumentAnalysis">REST API Reference for StartDocumentAnalysis Operation</seealso>
        public virtual StartDocumentAnalysisResponse StartDocumentAnalysis(StartDocumentAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDocumentAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDocumentAnalysisResponseUnmarshaller.Instance;

            return Invoke<StartDocumentAnalysisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDocumentAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDocumentAnalysis operation on AmazonTextractClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDocumentAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/StartDocumentAnalysis">REST API Reference for StartDocumentAnalysis Operation</seealso>
        public virtual IAsyncResult BeginStartDocumentAnalysis(StartDocumentAnalysisRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDocumentAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDocumentAnalysisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDocumentAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDocumentAnalysis.</param>
        /// 
        /// <returns>Returns a  StartDocumentAnalysisResult from Textract.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/StartDocumentAnalysis">REST API Reference for StartDocumentAnalysis Operation</seealso>
        public virtual StartDocumentAnalysisResponse EndStartDocumentAnalysis(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDocumentAnalysisResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDocumentTextDetection

        /// <summary>
        /// Starts the asynchronous detection of text in a document. Amazon Textract can detect
        /// lines of text and the words that make up a line of text.
        /// 
        ///  
        /// <para>
        /// Amazon Textract can detect text in document images and PDF files that are stored in
        /// an Amazon S3 bucket. Use <a>DocumentLocation</a> to specify the bucket name and the
        /// file name of the document image. 
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
        /// For more information, see Document Text Detection in the Amazon Textract Developer
        /// Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDocumentTextDetection service method.</param>
        /// 
        /// <returns>The response from the StartDocumentTextDetection service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.BadDocumentException">
        /// Amazon Textract isn't able to read the document.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.DocumentTooLargeException">
        /// The document can't be processed because it's too large. The maximum document size
        /// for synchronous operations 5 MB. The maximum document size for asynchronous operations
        /// is 500 MB for PDF format files.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.IdempotentParameterMismatchException">
        /// A <code>ClientRequestToken</code> input parameter was reused with an operation, but
        /// at least one of the other input parameters is different from the previous call to
        /// the operation.
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
        /// The format of the input document isn't supported. Amazon Textract supports documents
        /// that are .png or .jpg format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/StartDocumentTextDetection">REST API Reference for StartDocumentTextDetection Operation</seealso>
        public virtual StartDocumentTextDetectionResponse StartDocumentTextDetection(StartDocumentTextDetectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDocumentTextDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDocumentTextDetectionResponseUnmarshaller.Instance;

            return Invoke<StartDocumentTextDetectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDocumentTextDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDocumentTextDetection operation on AmazonTextractClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDocumentTextDetection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/StartDocumentTextDetection">REST API Reference for StartDocumentTextDetection Operation</seealso>
        public virtual IAsyncResult BeginStartDocumentTextDetection(StartDocumentTextDetectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDocumentTextDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDocumentTextDetectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDocumentTextDetection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDocumentTextDetection.</param>
        /// 
        /// <returns>Returns a  StartDocumentTextDetectionResult from Textract.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/StartDocumentTextDetection">REST API Reference for StartDocumentTextDetection Operation</seealso>
        public virtual StartDocumentTextDetectionResponse EndStartDocumentTextDetection(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDocumentTextDetectionResponse>(asyncResult);
        }

        #endregion
        
    }
}