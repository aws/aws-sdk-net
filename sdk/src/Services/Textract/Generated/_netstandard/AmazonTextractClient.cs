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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Textract.Model;
using Amazon.Textract.Model.Internal.MarshallTransformations;
using Amazon.Textract.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Textract
{
    /// <summary>
    /// <para>Implementation for accessing Textract</para>
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
            : base(new AmazonTextractConfig()) { }

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
            : base(new AmazonTextractConfig{RegionEndpoint = region}) { }

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
            : base(config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
        private ITextractPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ITextractPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new TextractPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonTextractEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonTextractAuthSchemeHandler());
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

        internal virtual AnalyzeDocumentResponse AnalyzeDocument(AnalyzeDocumentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AnalyzeDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AnalyzeDocumentResponseUnmarshaller.Instance;

            return Invoke<AnalyzeDocumentResponse>(request, options);
        }



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
        /// objects, each of type <c>KEY_VALUE_SET</c>: a KEY <c>Block</c> object and a VALUE
        /// <c>Block</c> object. For example, <i>Name: Ana Silva Carolina</i> contains a key and
        /// value. <i>Name:</i> is the key. <i>Ana Silva Carolina</i> is the value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Table and table cell data. A TABLE <c>Block</c> object contains information about
        /// a detected table. A CELL <c>Block</c> object is returned for each cell in a table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Lines and words of text. A LINE <c>Block</c> object contains one or more WORD <c>Block</c>
        /// objects. All lines and words that are detected in the document are returned (including
        /// text that doesn't have a relationship with the value of <c>FeatureTypes</c>). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Signatures. A SIGNATURE <c>Block</c> object contains the location information of a
        /// signature in a document. If used in conjunction with forms or tables, a signature
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
        /// in form data and in tables. A SELECTION_ELEMENT <c>Block</c> object contains information
        /// about a selection element, including the selection status.
        /// </para>
        ///  
        /// <para>
        /// You can choose which type of analysis to perform by specifying the <c>FeatureTypes</c>
        /// list. 
        /// </para>
        ///  
        /// <para>
        /// The output is returned in a list of <c>Block</c> objects.
        /// </para>
        ///  
        /// <para>
        ///  <c>AnalyzeDocument</c> is a synchronous operation. To analyze documents asynchronously,
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
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
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
        public virtual Task<AnalyzeDocumentResponse> AnalyzeDocumentAsync(AnalyzeDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AnalyzeDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AnalyzeDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<AnalyzeDocumentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AnalyzeExpense

        internal virtual AnalyzeExpenseResponse AnalyzeExpense(AnalyzeExpenseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AnalyzeExpenseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AnalyzeExpenseResponseUnmarshaller.Instance;

            return Invoke<AnalyzeExpenseResponse>(request, options);
        }



        /// <summary>
        /// <c>AnalyzeExpense</c> synchronously analyzes an input document for financially related
        /// relationships between text.
        /// 
        ///  
        /// <para>
        /// Information is returned as <c>ExpenseDocuments</c> and seperated as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LineItemGroups</c>- A data set containing <c>LineItems</c> which store information
        /// about the lines of text, such as an item purchased and its price on a receipt.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SummaryFields</c>- Contains all other information a receipt, such as header information
        /// or the vendors name.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AnalyzeExpense service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
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
        public virtual Task<AnalyzeExpenseResponse> AnalyzeExpenseAsync(AnalyzeExpenseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AnalyzeExpenseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AnalyzeExpenseResponseUnmarshaller.Instance;

            return InvokeAsync<AnalyzeExpenseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AnalyzeID

        internal virtual AnalyzeIDResponse AnalyzeID(AnalyzeIDRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AnalyzeIDRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AnalyzeIDResponseUnmarshaller.Instance;

            return Invoke<AnalyzeIDResponse>(request, options);
        }



        /// <summary>
        /// Analyzes identity documents for relevant information. This information is extracted
        /// and returned as <c>IdentityDocumentFields</c>, which records both the normalized field
        /// and value of the extracted text. Unlike other Amazon Textract operations, <c>AnalyzeID</c>
        /// doesn't return any Geometry data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AnalyzeID service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
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
        public virtual Task<AnalyzeIDResponse> AnalyzeIDAsync(AnalyzeIDRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AnalyzeIDRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AnalyzeIDResponseUnmarshaller.Instance;

            return InvokeAsync<AnalyzeIDResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAdapter

        internal virtual CreateAdapterResponse CreateAdapter(CreateAdapterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAdapterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAdapterResponseUnmarshaller.Instance;

            return Invoke<CreateAdapterResponse>(request, options);
        }



        /// <summary>
        /// Creates an adapter, which can be fine-tuned for enhanced performance on user provided
        /// documents. Takes an AdapterName and FeatureType. Currently the only supported feature
        /// type is <c>QUERIES</c>. You can also provide a Description, Tags, and a ClientRequestToken.
        /// You can choose whether or not the adapter should be AutoUpdated with the AutoUpdate
        /// argument. By default, AutoUpdate is set to DISABLED.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAdapter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAdapter service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action. Use the Amazon Resource Name (ARN) of
        /// an authorized user or IAM role to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.IdempotentParameterMismatchException">
        /// A <c>ClientRequestToken</c> input parameter was reused with an operation, but at least
        /// one of the other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InternalServerErrorException">
        /// Amazon Textract experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidParameterException">
        /// An input parameter violated a constraint. For example, in synchronous operations,
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.LimitExceededException">
        /// An Amazon Textract service limit was exceeded. For example, if you start too many
        /// asynchronous jobs concurrently, calls to start operations (<c>StartDocumentTextDetection</c>,
        /// for example) raise a LimitExceededException exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Textract service limit.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ServiceQuotaExceededException">
        /// Returned when a request cannot be completed as it would exceed a maximum service quota.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ValidationException">
        /// Indicates that a request was not valid. Check request for proper formatting.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/CreateAdapter">REST API Reference for CreateAdapter Operation</seealso>
        public virtual Task<CreateAdapterResponse> CreateAdapterAsync(CreateAdapterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAdapterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAdapterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAdapterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAdapterVersion

        internal virtual CreateAdapterVersionResponse CreateAdapterVersion(CreateAdapterVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAdapterVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAdapterVersionResponseUnmarshaller.Instance;

            return Invoke<CreateAdapterVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new version of an adapter. Operates on a provided AdapterId and a specified
        /// dataset provided via the DatasetConfig argument. Requires that you specify an Amazon
        /// S3 bucket with the OutputConfig argument. You can provide an optional KMSKeyId, an
        /// optional ClientRequestToken, and optional tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAdapterVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAdapterVersion service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action. Use the Amazon Resource Name (ARN) of
        /// an authorized user or IAM role to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.IdempotentParameterMismatchException">
        /// A <c>ClientRequestToken</c> input parameter was reused with an operation, but at least
        /// one of the other input parameters is different from the previous call to the operation.
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
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidS3ObjectException">
        /// Amazon Textract is unable to access the S3 object that's specified in the request.
        /// for more information, <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Configure
        /// Access to Amazon S3</a> For troubleshooting information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/troubleshooting.html">Troubleshooting
        /// Amazon S3</a>
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.LimitExceededException">
        /// An Amazon Textract service limit was exceeded. For example, if you start too many
        /// asynchronous jobs concurrently, calls to start operations (<c>StartDocumentTextDetection</c>,
        /// for example) raise a LimitExceededException exception (HTTP status code: 400) until
        /// the number of concurrently running jobs is below the Amazon Textract service limit.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ResourceNotFoundException">
        /// Returned when an operation tried to access a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ServiceQuotaExceededException">
        /// Returned when a request cannot be completed as it would exceed a maximum service quota.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ValidationException">
        /// Indicates that a request was not valid. Check request for proper formatting.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/CreateAdapterVersion">REST API Reference for CreateAdapterVersion Operation</seealso>
        public virtual Task<CreateAdapterVersionResponse> CreateAdapterVersionAsync(CreateAdapterVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAdapterVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAdapterVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAdapterVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAdapter

        internal virtual DeleteAdapterResponse DeleteAdapter(DeleteAdapterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAdapterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAdapterResponseUnmarshaller.Instance;

            return Invoke<DeleteAdapterResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon Textract adapter. Takes an AdapterId and deletes the adapter specified
        /// by the ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAdapter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAdapter service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action. Use the Amazon Resource Name (ARN) of
        /// an authorized user or IAM role to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InternalServerErrorException">
        /// Amazon Textract experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidParameterException">
        /// An input parameter violated a constraint. For example, in synchronous operations,
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ResourceNotFoundException">
        /// Returned when an operation tried to access a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ValidationException">
        /// Indicates that a request was not valid. Check request for proper formatting.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/DeleteAdapter">REST API Reference for DeleteAdapter Operation</seealso>
        public virtual Task<DeleteAdapterResponse> DeleteAdapterAsync(DeleteAdapterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAdapterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAdapterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAdapterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAdapterVersion

        internal virtual DeleteAdapterVersionResponse DeleteAdapterVersion(DeleteAdapterVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAdapterVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAdapterVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteAdapterVersionResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon Textract adapter version. Requires that you specify both an AdapterId
        /// and a AdapterVersion. Deletes the adapter version specified by the AdapterId and the
        /// AdapterVersion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAdapterVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAdapterVersion service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action. Use the Amazon Resource Name (ARN) of
        /// an authorized user or IAM role to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InternalServerErrorException">
        /// Amazon Textract experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidParameterException">
        /// An input parameter violated a constraint. For example, in synchronous operations,
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ResourceNotFoundException">
        /// Returned when an operation tried to access a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ValidationException">
        /// Indicates that a request was not valid. Check request for proper formatting.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/DeleteAdapterVersion">REST API Reference for DeleteAdapterVersion Operation</seealso>
        public virtual Task<DeleteAdapterVersionResponse> DeleteAdapterVersionAsync(DeleteAdapterVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAdapterVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAdapterVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAdapterVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DetectDocumentText

        internal virtual DetectDocumentTextResponse DetectDocumentText(DetectDocumentTextRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectDocumentTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectDocumentTextResponseUnmarshaller.Instance;

            return Invoke<DetectDocumentTextResponse>(request, options);
        }



        /// <summary>
        /// Detects text in the input document. Amazon Textract can detect lines of text and the
        /// words that make up a line of text. The input document must be in one of the following
        /// image formats: JPEG, PNG, PDF, or TIFF. <c>DetectDocumentText</c> returns the detected
        /// text in an array of <a>Block</a> objects. 
        /// 
        ///  
        /// <para>
        /// Each document page has as an associated <c>Block</c> of type PAGE. Each PAGE <c>Block</c>
        /// object is the parent of LINE <c>Block</c> objects that represent the lines of detected
        /// text on a page. A LINE <c>Block</c> object is a parent for each word that makes up
        /// the line. Words are represented by <c>Block</c> objects of type WORD.
        /// </para>
        ///  
        /// <para>
        ///  <c>DetectDocumentText</c> is a synchronous operation. To analyze documents asynchronously,
        /// use <a>StartDocumentTextDetection</a>.
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
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
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
        public virtual Task<DetectDocumentTextResponse> DetectDocumentTextAsync(DetectDocumentTextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectDocumentTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectDocumentTextResponseUnmarshaller.Instance;

            return InvokeAsync<DetectDocumentTextResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAdapter

        internal virtual GetAdapterResponse GetAdapter(GetAdapterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAdapterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdapterResponseUnmarshaller.Instance;

            return Invoke<GetAdapterResponse>(request, options);
        }



        /// <summary>
        /// Gets configuration information for an adapter specified by an AdapterId, returning
        /// information on AdapterName, Description, CreationTime, AutoUpdate status, and FeatureTypes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdapter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAdapter service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action. Use the Amazon Resource Name (ARN) of
        /// an authorized user or IAM role to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InternalServerErrorException">
        /// Amazon Textract experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidParameterException">
        /// An input parameter violated a constraint. For example, in synchronous operations,
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ResourceNotFoundException">
        /// Returned when an operation tried to access a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ValidationException">
        /// Indicates that a request was not valid. Check request for proper formatting.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/GetAdapter">REST API Reference for GetAdapter Operation</seealso>
        public virtual Task<GetAdapterResponse> GetAdapterAsync(GetAdapterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAdapterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdapterResponseUnmarshaller.Instance;

            return InvokeAsync<GetAdapterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAdapterVersion

        internal virtual GetAdapterVersionResponse GetAdapterVersion(GetAdapterVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAdapterVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdapterVersionResponseUnmarshaller.Instance;

            return Invoke<GetAdapterVersionResponse>(request, options);
        }



        /// <summary>
        /// Gets configuration information for the specified adapter version, including: AdapterId,
        /// AdapterVersion, FeatureTypes, Status, StatusMessage, DatasetConfig, KMSKeyId, OutputConfig,
        /// Tags and EvaluationMetrics.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdapterVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAdapterVersion service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action. Use the Amazon Resource Name (ARN) of
        /// an authorized user or IAM role to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InternalServerErrorException">
        /// Amazon Textract experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidParameterException">
        /// An input parameter violated a constraint. For example, in synchronous operations,
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ResourceNotFoundException">
        /// Returned when an operation tried to access a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ValidationException">
        /// Indicates that a request was not valid. Check request for proper formatting.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/GetAdapterVersion">REST API Reference for GetAdapterVersion Operation</seealso>
        public virtual Task<GetAdapterVersionResponse> GetAdapterVersionAsync(GetAdapterVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAdapterVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdapterVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetAdapterVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDocumentAnalysis

        internal virtual GetDocumentAnalysisResponse GetDocumentAnalysis(GetDocumentAnalysisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDocumentAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentAnalysisResponseUnmarshaller.Instance;

            return Invoke<GetDocumentAnalysisResponse>(request, options);
        }



        /// <summary>
        /// Gets the results for an Amazon Textract asynchronous operation that analyzes text
        /// in a document.
        /// 
        ///  
        /// <para>
        /// You start asynchronous text analysis by calling <a>StartDocumentAnalysis</a>, which
        /// returns a job identifier (<c>JobId</c>). When the text analysis operation finishes,
        /// Amazon Textract publishes a completion status to the Amazon Simple Notification Service
        /// (Amazon SNS) topic that's registered in the initial call to <c>StartDocumentAnalysis</c>.
        /// To get the results of the text-detection operation, first check that the status value
        /// published to the Amazon SNS topic is <c>SUCCEEDED</c>. If so, call <c>GetDocumentAnalysis</c>,
        /// and pass the job identifier (<c>JobId</c>) from the initial call to <c>StartDocumentAnalysis</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>GetDocumentAnalysis</c> returns an array of <a>Block</a> objects. The following
        /// types of information are returned: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Form data (key-value pairs). The related information is returned in two <a>Block</a>
        /// objects, each of type <c>KEY_VALUE_SET</c>: a KEY <c>Block</c> object and a VALUE
        /// <c>Block</c> object. For example, <i>Name: Ana Silva Carolina</i> contains a key and
        /// value. <i>Name:</i> is the key. <i>Ana Silva Carolina</i> is the value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Table and table cell data. A TABLE <c>Block</c> object contains information about
        /// a detected table. A CELL <c>Block</c> object is returned for each cell in a table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Lines and words of text. A LINE <c>Block</c> object contains one or more WORD <c>Block</c>
        /// objects. All lines and words that are detected in the document are returned (including
        /// text that doesn't have a relationship with the value of the <c>StartDocumentAnalysis</c>
        /// <c>FeatureTypes</c> input parameter). 
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
        /// While processing a document with queries, look out for <c>INVALID_REQUEST_PARAMETERS</c>
        /// output. This indicates that either the per page query limit has been exceeded or that
        /// the operation is trying to query a page in the document which doesn’t exist. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Selection elements such as check boxes and option buttons (radio buttons) can be detected
        /// in form data and in tables. A SELECTION_ELEMENT <c>Block</c> object contains information
        /// about a selection element, including the selection status.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>MaxResults</c> parameter to limit the number of blocks that are returned.
        /// If there are more results than specified in <c>MaxResults</c>, the value of <c>NextToken</c>
        /// in the operation response contains a pagination token for getting the next set of
        /// results. To get the next page of results, call <c>GetDocumentAnalysis</c>, and populate
        /// the <c>NextToken</c> request parameter with the token value that's returned from the
        /// previous call to <c>GetDocumentAnalysis</c>.
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
        /// An invalid job identifier was passed to an asynchronous analysis operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidKMSKeyException">
        /// Indicates you do not have decrypt permissions with the KMS key entered, or the KMS
        /// key was entered incorrectly.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidParameterException">
        /// An input parameter violated a constraint. For example, in synchronous operations,
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
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
        public virtual Task<GetDocumentAnalysisResponse> GetDocumentAnalysisAsync(GetDocumentAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDocumentAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentAnalysisResponseUnmarshaller.Instance;

            return InvokeAsync<GetDocumentAnalysisResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDocumentTextDetection

        internal virtual GetDocumentTextDetectionResponse GetDocumentTextDetection(GetDocumentTextDetectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDocumentTextDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentTextDetectionResponseUnmarshaller.Instance;

            return Invoke<GetDocumentTextDetectionResponse>(request, options);
        }



        /// <summary>
        /// Gets the results for an Amazon Textract asynchronous operation that detects text in
        /// a document. Amazon Textract can detect lines of text and the words that make up a
        /// line of text.
        /// 
        ///  
        /// <para>
        /// You start asynchronous text detection by calling <a>StartDocumentTextDetection</a>,
        /// which returns a job identifier (<c>JobId</c>). When the text detection operation finishes,
        /// Amazon Textract publishes a completion status to the Amazon Simple Notification Service
        /// (Amazon SNS) topic that's registered in the initial call to <c>StartDocumentTextDetection</c>.
        /// To get the results of the text-detection operation, first check that the status value
        /// published to the Amazon SNS topic is <c>SUCCEEDED</c>. If so, call <c>GetDocumentTextDetection</c>,
        /// and pass the job identifier (<c>JobId</c>) from the initial call to <c>StartDocumentTextDetection</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>GetDocumentTextDetection</c> returns an array of <a>Block</a> objects. 
        /// </para>
        ///  
        /// <para>
        /// Each document page has as an associated <c>Block</c> of type PAGE. Each PAGE <c>Block</c>
        /// object is the parent of LINE <c>Block</c> objects that represent the lines of detected
        /// text on a page. A LINE <c>Block</c> object is a parent for each word that makes up
        /// the line. Words are represented by <c>Block</c> objects of type WORD.
        /// </para>
        ///  
        /// <para>
        /// Use the MaxResults parameter to limit the number of blocks that are returned. If there
        /// are more results than specified in <c>MaxResults</c>, the value of <c>NextToken</c>
        /// in the operation response contains a pagination token for getting the next set of
        /// results. To get the next page of results, call <c>GetDocumentTextDetection</c>, and
        /// populate the <c>NextToken</c> request parameter with the token value that's returned
        /// from the previous call to <c>GetDocumentTextDetection</c>.
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
        /// An invalid job identifier was passed to an asynchronous analysis operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidKMSKeyException">
        /// Indicates you do not have decrypt permissions with the KMS key entered, or the KMS
        /// key was entered incorrectly.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidParameterException">
        /// An input parameter violated a constraint. For example, in synchronous operations,
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
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
        public virtual Task<GetDocumentTextDetectionResponse> GetDocumentTextDetectionAsync(GetDocumentTextDetectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDocumentTextDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentTextDetectionResponseUnmarshaller.Instance;

            return InvokeAsync<GetDocumentTextDetectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetExpenseAnalysis

        internal virtual GetExpenseAnalysisResponse GetExpenseAnalysis(GetExpenseAnalysisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExpenseAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExpenseAnalysisResponseUnmarshaller.Instance;

            return Invoke<GetExpenseAnalysisResponse>(request, options);
        }



        /// <summary>
        /// Gets the results for an Amazon Textract asynchronous operation that analyzes invoices
        /// and receipts. Amazon Textract finds contact information, items purchased, and vendor
        /// name, from input invoices and receipts.
        /// 
        ///  
        /// <para>
        /// You start asynchronous invoice/receipt analysis by calling <a>StartExpenseAnalysis</a>,
        /// which returns a job identifier (<c>JobId</c>). Upon completion of the invoice/receipt
        /// analysis, Amazon Textract publishes the completion status to the Amazon Simple Notification
        /// Service (Amazon SNS) topic. This topic must be registered in the initial call to <c>StartExpenseAnalysis</c>.
        /// To get the results of the invoice/receipt analysis operation, first ensure that the
        /// status value published to the Amazon SNS topic is <c>SUCCEEDED</c>. If so, call <c>GetExpenseAnalysis</c>,
        /// and pass the job identifier (<c>JobId</c>) from the initial call to <c>StartExpenseAnalysis</c>.
        /// </para>
        ///  
        /// <para>
        /// Use the MaxResults parameter to limit the number of blocks that are returned. If there
        /// are more results than specified in <c>MaxResults</c>, the value of <c>NextToken</c>
        /// in the operation response contains a pagination token for getting the next set of
        /// results. To get the next page of results, call <c>GetExpenseAnalysis</c>, and populate
        /// the <c>NextToken</c> request parameter with the token value that's returned from the
        /// previous call to <c>GetExpenseAnalysis</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/invoices-receipts.html">Analyzing
        /// Invoices and Receipts</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExpenseAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
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
        public virtual Task<GetExpenseAnalysisResponse> GetExpenseAnalysisAsync(GetExpenseAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExpenseAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExpenseAnalysisResponseUnmarshaller.Instance;

            return InvokeAsync<GetExpenseAnalysisResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetLendingAnalysis

        internal virtual GetLendingAnalysisResponse GetLendingAnalysis(GetLendingAnalysisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLendingAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLendingAnalysisResponseUnmarshaller.Instance;

            return Invoke<GetLendingAnalysisResponse>(request, options);
        }



        /// <summary>
        /// Gets the results for an Amazon Textract asynchronous operation that analyzes text
        /// in a lending document. 
        /// 
        ///  
        /// <para>
        /// You start asynchronous text analysis by calling <c>StartLendingAnalysis</c>, which
        /// returns a job identifier (<c>JobId</c>). When the text analysis operation finishes,
        /// Amazon Textract publishes a completion status to the Amazon Simple Notification Service
        /// (Amazon SNS) topic that's registered in the initial call to <c>StartLendingAnalysis</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To get the results of the text analysis operation, first check that the status value
        /// published to the Amazon SNS topic is SUCCEEDED. If so, call GetLendingAnalysis, and
        /// pass the job identifier (<c>JobId</c>) from the initial call to <c>StartLendingAnalysis</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLendingAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
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
        public virtual Task<GetLendingAnalysisResponse> GetLendingAnalysisAsync(GetLendingAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLendingAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLendingAnalysisResponseUnmarshaller.Instance;

            return InvokeAsync<GetLendingAnalysisResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetLendingAnalysisSummary

        internal virtual GetLendingAnalysisSummaryResponse GetLendingAnalysisSummary(GetLendingAnalysisSummaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLendingAnalysisSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLendingAnalysisSummaryResponseUnmarshaller.Instance;

            return Invoke<GetLendingAnalysisSummaryResponse>(request, options);
        }



        /// <summary>
        /// Gets summarized results for the <c>StartLendingAnalysis</c> operation, which analyzes
        /// text in a lending document. The returned summary consists of information about documents
        /// grouped together by a common document type. Information like detected signatures,
        /// page numbers, and split documents is returned with respect to the type of grouped
        /// document. 
        /// 
        ///  
        /// <para>
        /// You start asynchronous text analysis by calling <c>StartLendingAnalysis</c>, which
        /// returns a job identifier (<c>JobId</c>). When the text analysis operation finishes,
        /// Amazon Textract publishes a completion status to the Amazon Simple Notification Service
        /// (Amazon SNS) topic that's registered in the initial call to <c>StartLendingAnalysis</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To get the results of the text analysis operation, first check that the status value
        /// published to the Amazon SNS topic is SUCCEEDED. If so, call <c>GetLendingAnalysisSummary</c>,
        /// and pass the job identifier (<c>JobId</c>) from the initial call to <c>StartLendingAnalysis</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLendingAnalysisSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
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
        public virtual Task<GetLendingAnalysisSummaryResponse> GetLendingAnalysisSummaryAsync(GetLendingAnalysisSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLendingAnalysisSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLendingAnalysisSummaryResponseUnmarshaller.Instance;

            return InvokeAsync<GetLendingAnalysisSummaryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAdapters

        internal virtual ListAdaptersResponse ListAdapters(ListAdaptersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAdaptersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAdaptersResponseUnmarshaller.Instance;

            return Invoke<ListAdaptersResponse>(request, options);
        }



        /// <summary>
        /// Lists all adapters that match the specified filtration criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAdapters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAdapters service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action. Use the Amazon Resource Name (ARN) of
        /// an authorized user or IAM role to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InternalServerErrorException">
        /// Amazon Textract experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidParameterException">
        /// An input parameter violated a constraint. For example, in synchronous operations,
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ValidationException">
        /// Indicates that a request was not valid. Check request for proper formatting.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/ListAdapters">REST API Reference for ListAdapters Operation</seealso>
        public virtual Task<ListAdaptersResponse> ListAdaptersAsync(ListAdaptersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAdaptersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAdaptersResponseUnmarshaller.Instance;

            return InvokeAsync<ListAdaptersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAdapterVersions

        internal virtual ListAdapterVersionsResponse ListAdapterVersions(ListAdapterVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAdapterVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAdapterVersionsResponseUnmarshaller.Instance;

            return Invoke<ListAdapterVersionsResponse>(request, options);
        }



        /// <summary>
        /// List all version of an adapter that meet the specified filtration criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAdapterVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAdapterVersions service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action. Use the Amazon Resource Name (ARN) of
        /// an authorized user or IAM role to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InternalServerErrorException">
        /// Amazon Textract experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidParameterException">
        /// An input parameter violated a constraint. For example, in synchronous operations,
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ResourceNotFoundException">
        /// Returned when an operation tried to access a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ValidationException">
        /// Indicates that a request was not valid. Check request for proper formatting.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/ListAdapterVersions">REST API Reference for ListAdapterVersions Operation</seealso>
        public virtual Task<ListAdapterVersionsResponse> ListAdapterVersionsAsync(ListAdapterVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAdapterVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAdapterVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAdapterVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists all tags for an Amazon Textract resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action. Use the Amazon Resource Name (ARN) of
        /// an authorized user or IAM role to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InternalServerErrorException">
        /// Amazon Textract experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidParameterException">
        /// An input parameter violated a constraint. For example, in synchronous operations,
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ResourceNotFoundException">
        /// Returned when an operation tried to access a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ValidationException">
        /// Indicates that a request was not valid. Check request for proper formatting.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartDocumentAnalysis

        internal virtual StartDocumentAnalysisResponse StartDocumentAnalysis(StartDocumentAnalysisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDocumentAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDocumentAnalysisResponseUnmarshaller.Instance;

            return Invoke<StartDocumentAnalysisResponse>(request, options);
        }



        /// <summary>
        /// Starts the asynchronous analysis of an input document for relationships between detected
        /// items such as key-value pairs, tables, and selection elements.
        /// 
        ///  
        /// <para>
        ///  <c>StartDocumentAnalysis</c> can analyze text in documents that are in JPEG, PNG,
        /// TIFF, and PDF format. The documents are stored in an Amazon S3 bucket. Use <a>DocumentLocation</a>
        /// to specify the bucket name and file name of the document. 
        /// </para>
        ///  
        /// <para>
        ///  <c>StartDocumentAnalysis</c> returns a job identifier (<c>JobId</c>) that you use
        /// to get the results of the operation. When text analysis is finished, Amazon Textract
        /// publishes a completion status to the Amazon Simple Notification Service (Amazon SNS)
        /// topic that you specify in <c>NotificationChannel</c>. To get the results of the text
        /// analysis operation, first check that the status value published to the Amazon SNS
        /// topic is <c>SUCCEEDED</c>. If so, call <a>GetDocumentAnalysis</a>, and pass the job
        /// identifier (<c>JobId</c>) from the initial call to <c>StartDocumentAnalysis</c>.
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
        /// A <c>ClientRequestToken</c> input parameter was reused with an operation, but at least
        /// one of the other input parameters is different from the previous call to the operation.
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
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidS3ObjectException">
        /// Amazon Textract is unable to access the S3 object that's specified in the request.
        /// for more information, <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Configure
        /// Access to Amazon S3</a> For troubleshooting information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/troubleshooting.html">Troubleshooting
        /// Amazon S3</a>
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.LimitExceededException">
        /// An Amazon Textract service limit was exceeded. For example, if you start too many
        /// asynchronous jobs concurrently, calls to start operations (<c>StartDocumentTextDetection</c>,
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
        public virtual Task<StartDocumentAnalysisResponse> StartDocumentAnalysisAsync(StartDocumentAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDocumentAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDocumentAnalysisResponseUnmarshaller.Instance;

            return InvokeAsync<StartDocumentAnalysisResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartDocumentTextDetection

        internal virtual StartDocumentTextDetectionResponse StartDocumentTextDetection(StartDocumentTextDetectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDocumentTextDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDocumentTextDetectionResponseUnmarshaller.Instance;

            return Invoke<StartDocumentTextDetectionResponse>(request, options);
        }



        /// <summary>
        /// Starts the asynchronous detection of text in a document. Amazon Textract can detect
        /// lines of text and the words that make up a line of text.
        /// 
        ///  
        /// <para>
        ///  <c>StartDocumentTextDetection</c> can analyze text in documents that are in JPEG,
        /// PNG, TIFF, and PDF format. The documents are stored in an Amazon S3 bucket. Use <a>DocumentLocation</a>
        /// to specify the bucket name and file name of the document. 
        /// </para>
        ///  
        /// <para>
        ///  <c>StartDocumentTextDetection</c> returns a job identifier (<c>JobId</c>) that you
        /// use to get the results of the operation. When text detection is finished, Amazon Textract
        /// publishes a completion status to the Amazon Simple Notification Service (Amazon SNS)
        /// topic that you specify in <c>NotificationChannel</c>. To get the results of the text
        /// detection operation, first check that the status value published to the Amazon SNS
        /// topic is <c>SUCCEEDED</c>. If so, call <a>GetDocumentTextDetection</a>, and pass the
        /// job identifier (<c>JobId</c>) from the initial call to <c>StartDocumentTextDetection</c>.
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
        /// A <c>ClientRequestToken</c> input parameter was reused with an operation, but at least
        /// one of the other input parameters is different from the previous call to the operation.
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
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidS3ObjectException">
        /// Amazon Textract is unable to access the S3 object that's specified in the request.
        /// for more information, <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Configure
        /// Access to Amazon S3</a> For troubleshooting information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/troubleshooting.html">Troubleshooting
        /// Amazon S3</a>
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.LimitExceededException">
        /// An Amazon Textract service limit was exceeded. For example, if you start too many
        /// asynchronous jobs concurrently, calls to start operations (<c>StartDocumentTextDetection</c>,
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
        public virtual Task<StartDocumentTextDetectionResponse> StartDocumentTextDetectionAsync(StartDocumentTextDetectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDocumentTextDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDocumentTextDetectionResponseUnmarshaller.Instance;

            return InvokeAsync<StartDocumentTextDetectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartExpenseAnalysis

        internal virtual StartExpenseAnalysisResponse StartExpenseAnalysis(StartExpenseAnalysisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartExpenseAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExpenseAnalysisResponseUnmarshaller.Instance;

            return Invoke<StartExpenseAnalysisResponse>(request, options);
        }



        /// <summary>
        /// Starts the asynchronous analysis of invoices or receipts for data like contact information,
        /// items purchased, and vendor names.
        /// 
        ///  
        /// <para>
        ///  <c>StartExpenseAnalysis</c> can analyze text in documents that are in JPEG, PNG,
        /// and PDF format. The documents must be stored in an Amazon S3 bucket. Use the <a>DocumentLocation</a>
        /// parameter to specify the name of your S3 bucket and the name of the document in that
        /// bucket. 
        /// </para>
        ///  
        /// <para>
        ///  <c>StartExpenseAnalysis</c> returns a job identifier (<c>JobId</c>) that you will
        /// provide to <c>GetExpenseAnalysis</c> to retrieve the results of the operation. When
        /// the analysis of the input invoices/receipts is finished, Amazon Textract publishes
        /// a completion status to the Amazon Simple Notification Service (Amazon SNS) topic that
        /// you provide to the <c>NotificationChannel</c>. To obtain the results of the invoice
        /// and receipt analysis operation, ensure that the status value published to the Amazon
        /// SNS topic is <c>SUCCEEDED</c>. If so, call <a>GetExpenseAnalysis</a>, and pass the
        /// job identifier (<c>JobId</c>) that was returned by your call to <c>StartExpenseAnalysis</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/invoice-receipts.html">Analyzing
        /// Invoices and Receipts</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExpenseAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// A <c>ClientRequestToken</c> input parameter was reused with an operation, but at least
        /// one of the other input parameters is different from the previous call to the operation.
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
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidS3ObjectException">
        /// Amazon Textract is unable to access the S3 object that's specified in the request.
        /// for more information, <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Configure
        /// Access to Amazon S3</a> For troubleshooting information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/troubleshooting.html">Troubleshooting
        /// Amazon S3</a>
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.LimitExceededException">
        /// An Amazon Textract service limit was exceeded. For example, if you start too many
        /// asynchronous jobs concurrently, calls to start operations (<c>StartDocumentTextDetection</c>,
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
        public virtual Task<StartExpenseAnalysisResponse> StartExpenseAnalysisAsync(StartExpenseAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartExpenseAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExpenseAnalysisResponseUnmarshaller.Instance;

            return InvokeAsync<StartExpenseAnalysisResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartLendingAnalysis

        internal virtual StartLendingAnalysisResponse StartLendingAnalysis(StartLendingAnalysisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartLendingAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLendingAnalysisResponseUnmarshaller.Instance;

            return Invoke<StartLendingAnalysisResponse>(request, options);
        }



        /// <summary>
        /// Starts the classification and analysis of an input document. <c>StartLendingAnalysis</c>
        /// initiates the classification and analysis of a packet of lending documents. <c>StartLendingAnalysis</c>
        /// operates on a document file located in an Amazon S3 bucket.
        /// 
        ///  
        /// <para>
        ///  <c>StartLendingAnalysis</c> can analyze text in documents that are in one of the
        /// following formats: JPEG, PNG, TIFF, PDF. Use <c>DocumentLocation</c> to specify the
        /// bucket name and the file name of the document. 
        /// </para>
        ///  
        /// <para>
        ///  <c>StartLendingAnalysis</c> returns a job identifier (<c>JobId</c>) that you use
        /// to get the results of the operation. When the text analysis is finished, Amazon Textract
        /// publishes a completion status to the Amazon Simple Notification Service (Amazon SNS)
        /// topic that you specify in <c>NotificationChannel</c>. To get the results of the text
        /// analysis operation, first check that the status value published to the Amazon SNS
        /// topic is SUCCEEDED. If the status is SUCCEEDED you can call either <c>GetLendingAnalysis</c>
        /// or <c>GetLendingAnalysisSummary</c> and provide the <c>JobId</c> to obtain the results
        /// of the analysis.
        /// </para>
        ///  
        /// <para>
        /// If using <c>OutputConfig</c> to specify an Amazon S3 bucket, the output will be contained
        /// within the specified prefix in a directory labeled with the job-id. In the directory
        /// there are 3 sub-directories: 
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// A <c>ClientRequestToken</c> input parameter was reused with an operation, but at least
        /// one of the other input parameters is different from the previous call to the operation.
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
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidS3ObjectException">
        /// Amazon Textract is unable to access the S3 object that's specified in the request.
        /// for more information, <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Configure
        /// Access to Amazon S3</a> For troubleshooting information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/troubleshooting.html">Troubleshooting
        /// Amazon S3</a>
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.LimitExceededException">
        /// An Amazon Textract service limit was exceeded. For example, if you start too many
        /// asynchronous jobs concurrently, calls to start operations (<c>StartDocumentTextDetection</c>,
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
        public virtual Task<StartLendingAnalysisResponse> StartLendingAnalysisAsync(StartLendingAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartLendingAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLendingAnalysisResponseUnmarshaller.Instance;

            return InvokeAsync<StartLendingAnalysisResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds one or more tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action. Use the Amazon Resource Name (ARN) of
        /// an authorized user or IAM role to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InternalServerErrorException">
        /// Amazon Textract experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidParameterException">
        /// An input parameter violated a constraint. For example, in synchronous operations,
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ResourceNotFoundException">
        /// Returned when an operation tried to access a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ServiceQuotaExceededException">
        /// Returned when a request cannot be completed as it would exceed a maximum service quota.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ValidationException">
        /// Indicates that a request was not valid. Check request for proper formatting.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes any tags with the specified keys from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action. Use the Amazon Resource Name (ARN) of
        /// an authorized user or IAM role to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InternalServerErrorException">
        /// Amazon Textract experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidParameterException">
        /// An input parameter violated a constraint. For example, in synchronous operations,
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ResourceNotFoundException">
        /// Returned when an operation tried to access a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ValidationException">
        /// Indicates that a request was not valid. Check request for proper formatting.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAdapter

        internal virtual UpdateAdapterResponse UpdateAdapter(UpdateAdapterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAdapterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAdapterResponseUnmarshaller.Instance;

            return Invoke<UpdateAdapterResponse>(request, options);
        }



        /// <summary>
        /// Update the configuration for an adapter. FeatureTypes configurations cannot be updated.
        /// At least one new parameter must be specified as an argument.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAdapter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAdapter service method, as returned by Textract.</returns>
        /// <exception cref="Amazon.Textract.Model.AccessDeniedException">
        /// You aren't authorized to perform the action. Use the Amazon Resource Name (ARN) of
        /// an authorized user or IAM role to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InternalServerErrorException">
        /// Amazon Textract experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.InvalidParameterException">
        /// An input parameter violated a constraint. For example, in synchronous operations,
        /// an <c>InvalidParameterException</c> exception occurs when neither of the <c>S3Object</c>
        /// or <c>Bytes</c> values are supplied in the <c>Document</c> request parameter. Validate
        /// your parameter before calling the API operation again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Textract.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ResourceNotFoundException">
        /// Returned when an operation tried to access a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ThrottlingException">
        /// Amazon Textract is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Textract.Model.ValidationException">
        /// Indicates that a request was not valid. Check request for proper formatting.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/textract-2018-06-27/UpdateAdapter">REST API Reference for UpdateAdapter Operation</seealso>
        public virtual Task<UpdateAdapterResponse> UpdateAdapterAsync(UpdateAdapterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAdapterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAdapterResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAdapterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}