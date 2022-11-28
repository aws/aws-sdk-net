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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonTextractEndpointResolver());
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
        ///  </li> <li> 
        /// <para>
        /// Signatures. A SIGNATURE <code>Block</code> object contains the location information
        /// of a signature in a document. If used in conjunction with forms or tables, a signature
        /// can be given a Key-Value pairing or be detected in the cell of a table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Query. A QUERY Block object contains the query text, alias and link to the associated
        /// Query results block object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Query Result. A QUERY_RESULT Block object contains the answer to the query and an
        /// ID that connects it to the query asked. This Block also contains a confidence score.
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
        /// The format of the input document isn't supported. Documents for operations can be
        /// in PNG, JPEG, PDF, or TIFF format.
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
        
        #region  AnalyzeExpense

        /// <summary>
        /// <code>AnalyzeExpense</code> synchronously analyzes an input document for financially
        /// related relationships between text.
        /// 
        ///  
        /// <para>
        /// Information is returned as <code>ExpenseDocuments</code> and seperated as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>LineItemGroups</code>- A data set containing <code>LineItems</code> which store
        /// information about the lines of text, such as an item purchased and its price on a
        /// receipt.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SummaryFields</code>- Contains all other information a receipt, such as header
        /// information or the vendors name.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AnalyzeExpense service method.</param>
        /// 
        /// <returns>The response from the AnalyzeExpense service method, as returned by Textract.</returns>
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
        /// The format of the input document isn't supported. Documents for operations can be
        /// in PNG, JPEG, PDF, or TIFF format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/AnalyzeExpense">REST API Reference for AnalyzeExpense Operation</seealso>
        public virtual AnalyzeExpenseResponse AnalyzeExpense(AnalyzeExpenseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AnalyzeExpenseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AnalyzeExpenseResponseUnmarshaller.Instance;

            return Invoke<AnalyzeExpenseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AnalyzeExpense operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AnalyzeExpense operation on AmazonTextractClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAnalyzeExpense
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/AnalyzeExpense">REST API Reference for AnalyzeExpense Operation</seealso>
        public virtual IAsyncResult BeginAnalyzeExpense(AnalyzeExpenseRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AnalyzeExpenseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AnalyzeExpenseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AnalyzeExpense operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAnalyzeExpense.</param>
        /// 
        /// <returns>Returns a  AnalyzeExpenseResult from Textract.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/AnalyzeExpense">REST API Reference for AnalyzeExpense Operation</seealso>
        public virtual AnalyzeExpenseResponse EndAnalyzeExpense(IAsyncResult asyncResult)
        {
            return EndInvoke<AnalyzeExpenseResponse>(asyncResult);
        }

        #endregion
        
        #region  AnalyzeID

        /// <summary>
        /// Analyzes identity documents for relevant information. This information is extracted
        /// and returned as <code>IdentityDocumentFields</code>, which records both the normalized
        /// field and value of the extracted text.Unlike other Amazon Textract operations, <code>AnalyzeID</code>
        /// doesn't return any Geometry data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AnalyzeID service method.</param>
        /// 
        /// <returns>The response from the AnalyzeID service method, as returned by Textract.</returns>
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
        /// The format of the input document isn't supported. Documents for operations can be
        /// in PNG, JPEG, PDF, or TIFF format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/AnalyzeID">REST API Reference for AnalyzeID Operation</seealso>
        public virtual AnalyzeIDResponse AnalyzeID(AnalyzeIDRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AnalyzeIDRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AnalyzeIDResponseUnmarshaller.Instance;

            return Invoke<AnalyzeIDResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AnalyzeID operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AnalyzeID operation on AmazonTextractClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAnalyzeID
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/AnalyzeID">REST API Reference for AnalyzeID Operation</seealso>
        public virtual IAsyncResult BeginAnalyzeID(AnalyzeIDRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AnalyzeIDRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AnalyzeIDResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AnalyzeID operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAnalyzeID.</param>
        /// 
        /// <returns>Returns a  AnalyzeIDResult from Textract.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/AnalyzeID">REST API Reference for AnalyzeID Operation</seealso>
        public virtual AnalyzeIDResponse EndAnalyzeID(IAsyncResult asyncResult)
        {
            return EndInvoke<AnalyzeIDResponse>(asyncResult);
        }

        #endregion
        
        #region  DetectDocumentText

        /// <summary>
        /// Detects text in the input document. Amazon Textract can detect lines of text and the
        /// words that make up a line of text. The input document must be in one of the following
        /// image formats: JPEG, PNG, PDF, or TIFF. <code>DetectDocumentText</code> returns the
        /// detected text in an array of <a>Block</a> objects. 
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
        /// The format of the input document isn't supported. Documents for operations can be
        /// in PNG, JPEG, PDF, or TIFF format.
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
        ///  </li> <li> 
        /// <para>
        /// Query. A QUERY Block object contains the query text, alias and link to the associated
        /// Query results block object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Query Results. A QUERY_RESULT Block object contains the answer to the query and an
        /// ID that connects it to the query asked. This Block also contains a confidence score.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// While processing a document with queries, look out for <code>INVALID_REQUEST_PARAMETERS</code>
        /// output. This indicates that either the per page query limit has been exceeded or that
        /// the operation is trying to query a page in the document which doesn’t exist. 
        /// </para>
        ///  </note> 
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
        /// An invalid job identifier was passed to an asynchronous analysis operation.
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
        /// An invalid job identifier was passed to an asynchronous analysis operation.
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
        
        #region  GetExpenseAnalysis

        /// <summary>
        /// Gets the results for an Amazon Textract asynchronous operation that analyzes invoices
        /// and receipts. Amazon Textract finds contact information, items purchased, and vendor
        /// name, from input invoices and receipts.
        /// 
        ///  
        /// <para>
        /// You start asynchronous invoice/receipt analysis by calling <a>StartExpenseAnalysis</a>,
        /// which returns a job identifier (<code>JobId</code>). Upon completion of the invoice/receipt
        /// analysis, Amazon Textract publishes the completion status to the Amazon Simple Notification
        /// Service (Amazon SNS) topic. This topic must be registered in the initial call to <code>StartExpenseAnalysis</code>.
        /// To get the results of the invoice/receipt analysis operation, first ensure that the
        /// status value published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call
        /// <code>GetExpenseAnalysis</code>, and pass the job identifier (<code>JobId</code>)
        /// from the initial call to <code>StartExpenseAnalysis</code>.
        /// </para>
        ///  
        /// <para>
        /// Use the MaxResults parameter to limit the number of blocks that are returned. If there
        /// are more results than specified in <code>MaxResults</code>, the value of <code>NextToken</code>
        /// in the operation response contains a pagination token for getting the next set of
        /// results. To get the next page of results, call <code>GetExpenseAnalysis</code>, and
        /// populate the <code>NextToken</code> request parameter with the token value that's
        /// returned from the previous call to <code>GetExpenseAnalysis</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/invoices-receipts.html">Analyzing
        /// Invoices and Receipts</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExpenseAnalysis service method.</param>
        /// 
        /// <returns>The response from the GetExpenseAnalysis service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action. Use the Amazon Resource Name (ARN) of
        /// an authorized user or IAM role to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InternalServerErrorException">
        /// Amazon Textract experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidJobIdException">
        /// An invalid job identifier was passed to an asynchronous analysis operation.
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
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/GetExpenseAnalysis">REST API Reference for GetExpenseAnalysis Operation</seealso>
        public virtual GetExpenseAnalysisResponse GetExpenseAnalysis(GetExpenseAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExpenseAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExpenseAnalysisResponseUnmarshaller.Instance;

            return Invoke<GetExpenseAnalysisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetExpenseAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExpenseAnalysis operation on AmazonTextractClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExpenseAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/GetExpenseAnalysis">REST API Reference for GetExpenseAnalysis Operation</seealso>
        public virtual IAsyncResult BeginGetExpenseAnalysis(GetExpenseAnalysisRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExpenseAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExpenseAnalysisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetExpenseAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExpenseAnalysis.</param>
        /// 
        /// <returns>Returns a  GetExpenseAnalysisResult from Textract.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/GetExpenseAnalysis">REST API Reference for GetExpenseAnalysis Operation</seealso>
        public virtual GetExpenseAnalysisResponse EndGetExpenseAnalysis(IAsyncResult asyncResult)
        {
            return EndInvoke<GetExpenseAnalysisResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLendingAnalysis

        /// <summary>
        /// Gets the results for an Amazon Textract asynchronous operation that analyzes text
        /// in a lending document. 
        /// 
        ///  
        /// <para>
        /// You start asynchronous text analysis by calling <code>StartLendingAnalysis</code>,
        /// which returns a job identifier (<code>JobId</code>). When the text analysis operation
        /// finishes, Amazon Textract publishes a completion status to the Amazon Simple Notification
        /// Service (Amazon SNS) topic that's registered in the initial call to <code>StartLendingAnalysis</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To get the results of the text analysis operation, first check that the status value
        /// published to the Amazon SNS topic is SUCCEEDED. If so, call GetLendingAnalysis, and
        /// pass the job identifier (<code>JobId</code>) from the initial call to <code>StartLendingAnalysis</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLendingAnalysis service method.</param>
        /// 
        /// <returns>The response from the GetLendingAnalysis service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action. Use the Amazon Resource Name (ARN) of
        /// an authorized user or IAM role to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InternalServerErrorException">
        /// Amazon Textract experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidJobIdException">
        /// An invalid job identifier was passed to an asynchronous analysis operation.
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
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/GetLendingAnalysis">REST API Reference for GetLendingAnalysis Operation</seealso>
        public virtual GetLendingAnalysisResponse GetLendingAnalysis(GetLendingAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLendingAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLendingAnalysisResponseUnmarshaller.Instance;

            return Invoke<GetLendingAnalysisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLendingAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLendingAnalysis operation on AmazonTextractClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLendingAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/GetLendingAnalysis">REST API Reference for GetLendingAnalysis Operation</seealso>
        public virtual IAsyncResult BeginGetLendingAnalysis(GetLendingAnalysisRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLendingAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLendingAnalysisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLendingAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLendingAnalysis.</param>
        /// 
        /// <returns>Returns a  GetLendingAnalysisResult from Textract.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/GetLendingAnalysis">REST API Reference for GetLendingAnalysis Operation</seealso>
        public virtual GetLendingAnalysisResponse EndGetLendingAnalysis(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLendingAnalysisResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLendingAnalysisSummary

        /// <summary>
        /// Gets summarized results for the <code>StartLendingAnalysis</code> operation, which
        /// analyzes text in a lending document. The returned summary consists of information
        /// about documents grouped together by a common document type. Information like detected
        /// signatures, page numbers, and split documents is returned with respect to the type
        /// of grouped document. 
        /// 
        ///  
        /// <para>
        /// You start asynchronous text analysis by calling <code>StartLendingAnalysis</code>,
        /// which returns a job identifier (<code>JobId</code>). When the text analysis operation
        /// finishes, Amazon Textract publishes a completion status to the Amazon Simple Notification
        /// Service (Amazon SNS) topic that's registered in the initial call to <code>StartLendingAnalysis</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To get the results of the text analysis operation, first check that the status value
        /// published to the Amazon SNS topic is SUCCEEDED. If so, call <code>GetLendingAnalysisSummary</code>,
        /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartLendingAnalysis</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLendingAnalysisSummary service method.</param>
        /// 
        /// <returns>The response from the GetLendingAnalysisSummary service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action. Use the Amazon Resource Name (ARN) of
        /// an authorized user or IAM role to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InternalServerErrorException">
        /// Amazon Textract experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidJobIdException">
        /// An invalid job identifier was passed to an asynchronous analysis operation.
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
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/GetLendingAnalysisSummary">REST API Reference for GetLendingAnalysisSummary Operation</seealso>
        public virtual GetLendingAnalysisSummaryResponse GetLendingAnalysisSummary(GetLendingAnalysisSummaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLendingAnalysisSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLendingAnalysisSummaryResponseUnmarshaller.Instance;

            return Invoke<GetLendingAnalysisSummaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLendingAnalysisSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLendingAnalysisSummary operation on AmazonTextractClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLendingAnalysisSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/GetLendingAnalysisSummary">REST API Reference for GetLendingAnalysisSummary Operation</seealso>
        public virtual IAsyncResult BeginGetLendingAnalysisSummary(GetLendingAnalysisSummaryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLendingAnalysisSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLendingAnalysisSummaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLendingAnalysisSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLendingAnalysisSummary.</param>
        /// 
        /// <returns>Returns a  GetLendingAnalysisSummaryResult from Textract.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/GetLendingAnalysisSummary">REST API Reference for GetLendingAnalysisSummary Operation</seealso>
        public virtual GetLendingAnalysisSummaryResponse EndGetLendingAnalysisSummary(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLendingAnalysisSummaryResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDocumentAnalysis

        /// <summary>
        /// Starts the asynchronous analysis of an input document for relationships between detected
        /// items such as key-value pairs, tables, and selection elements.
        /// 
        ///  
        /// <para>
        ///  <code>StartDocumentAnalysis</code> can analyze text in documents that are in JPEG,
        /// PNG, TIFF, and PDF format. The documents are stored in an Amazon S3 bucket. Use <a>DocumentLocation</a>
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
        /// The format of the input document isn't supported. Documents for operations can be
        /// in PNG, JPEG, PDF, or TIFF format.
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
        ///  <code>StartDocumentTextDetection</code> can analyze text in documents that are in
        /// JPEG, PNG, TIFF, and PDF format. The documents are stored in an Amazon S3 bucket.
        /// Use <a>DocumentLocation</a> to specify the bucket name and file name of the document.
        /// 
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
        /// The format of the input document isn't supported. Documents for operations can be
        /// in PNG, JPEG, PDF, or TIFF format.
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
        
        #region  StartExpenseAnalysis

        /// <summary>
        /// Starts the asynchronous analysis of invoices or receipts for data like contact information,
        /// items purchased, and vendor names.
        /// 
        ///  
        /// <para>
        ///  <code>StartExpenseAnalysis</code> can analyze text in documents that are in JPEG,
        /// PNG, and PDF format. The documents must be stored in an Amazon S3 bucket. Use the
        /// <a>DocumentLocation</a> parameter to specify the name of your S3 bucket and the name
        /// of the document in that bucket. 
        /// </para>
        ///  
        /// <para>
        ///  <code>StartExpenseAnalysis</code> returns a job identifier (<code>JobId</code>) that
        /// you will provide to <code>GetExpenseAnalysis</code> to retrieve the results of the
        /// operation. When the analysis of the input invoices/receipts is finished, Amazon Textract
        /// publishes a completion status to the Amazon Simple Notification Service (Amazon SNS)
        /// topic that you provide to the <code>NotificationChannel</code>. To obtain the results
        /// of the invoice and receipt analysis operation, ensure that the status value published
        /// to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <a>GetExpenseAnalysis</a>,
        /// and pass the job identifier (<code>JobId</code>) that was returned by your call to
        /// <code>StartExpenseAnalysis</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/invoice-receipts.html">Analyzing
        /// Invoices and Receipts</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExpenseAnalysis service method.</param>
        /// 
        /// <returns>The response from the StartExpenseAnalysis service method, as returned by Textract.</returns>
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
        /// The format of the input document isn't supported. Documents for operations can be
        /// in PNG, JPEG, PDF, or TIFF format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/StartExpenseAnalysis">REST API Reference for StartExpenseAnalysis Operation</seealso>
        public virtual StartExpenseAnalysisResponse StartExpenseAnalysis(StartExpenseAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartExpenseAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExpenseAnalysisResponseUnmarshaller.Instance;

            return Invoke<StartExpenseAnalysisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartExpenseAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartExpenseAnalysis operation on AmazonTextractClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartExpenseAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/StartExpenseAnalysis">REST API Reference for StartExpenseAnalysis Operation</seealso>
        public virtual IAsyncResult BeginStartExpenseAnalysis(StartExpenseAnalysisRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartExpenseAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExpenseAnalysisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartExpenseAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartExpenseAnalysis.</param>
        /// 
        /// <returns>Returns a  StartExpenseAnalysisResult from Textract.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/StartExpenseAnalysis">REST API Reference for StartExpenseAnalysis Operation</seealso>
        public virtual StartExpenseAnalysisResponse EndStartExpenseAnalysis(IAsyncResult asyncResult)
        {
            return EndInvoke<StartExpenseAnalysisResponse>(asyncResult);
        }

        #endregion
        
        #region  StartLendingAnalysis

        /// <summary>
        /// Starts the classification and analysis of an input document. <code>StartLendingAnalysis</code>
        /// initiates the classification and analysis of a packet of lending documents. <code>StartLendingAnalysis</code>
        /// operates on a document file located in an Amazon S3 bucket.
        /// 
        ///  
        /// <para>
        ///  <code>StartLendingAnalysis</code> can analyze text in documents that are in one of
        /// the following formats: JPEG, PNG, TIFF, PDF. Use <code>DocumentLocation</code> to
        /// specify the bucket name and the file name of the document. 
        /// </para>
        ///  
        /// <para>
        ///  <code>StartLendingAnalysis</code> returns a job identifier (<code>JobId</code>) that
        /// you use to get the results of the operation. When the text analysis is finished, Amazon
        /// Textract publishes a completion status to the Amazon Simple Notification Service (Amazon
        /// SNS) topic that you specify in <code>NotificationChannel</code>. To get the results
        /// of the text analysis operation, first check that the status value published to the
        /// Amazon SNS topic is SUCCEEDED. If the status is SUCCEEDED you can call either <code>GetLendingAnalysis</code>
        /// or <code>GetLendingAnalysisSummary</code> and provide the <code>JobId</code> to obtain
        /// the results of the analysis.
        /// </para>
        ///  
        /// <para>
        /// If using <code>OutputConfig</code> to specify an Amazon S3 bucket, the output will
        /// be contained within the specified prefix in a directory labeled with the job-id. In
        /// the directory there are 3 sub-directories: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// detailedResponse (contains the GetLendingAnalysis response)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// summaryResponse (for the GetLendingAnalysisSummary response)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// splitDocuments (documents split across logical boundaries)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartLendingAnalysis service method.</param>
        /// 
        /// <returns>The response from the StartLendingAnalysis service method, as returned by Textract.</returns>
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
        /// The format of the input document isn't supported. Documents for operations can be
        /// in PNG, JPEG, PDF, or TIFF format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/StartLendingAnalysis">REST API Reference for StartLendingAnalysis Operation</seealso>
        public virtual StartLendingAnalysisResponse StartLendingAnalysis(StartLendingAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartLendingAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLendingAnalysisResponseUnmarshaller.Instance;

            return Invoke<StartLendingAnalysisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartLendingAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartLendingAnalysis operation on AmazonTextractClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartLendingAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/StartLendingAnalysis">REST API Reference for StartLendingAnalysis Operation</seealso>
        public virtual IAsyncResult BeginStartLendingAnalysis(StartLendingAnalysisRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartLendingAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLendingAnalysisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartLendingAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartLendingAnalysis.</param>
        /// 
        /// <returns>Returns a  StartLendingAnalysisResult from Textract.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/StartLendingAnalysis">REST API Reference for StartLendingAnalysis Operation</seealso>
        public virtual StartLendingAnalysisResponse EndStartLendingAnalysis(IAsyncResult asyncResult)
        {
            return EndInvoke<StartLendingAnalysisResponse>(asyncResult);
        }

        #endregion
        
    }
}