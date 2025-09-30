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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.QLDB.Model;
using Amazon.QLDB.Model.Internal.MarshallTransformations;
using Amazon.QLDB.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.QLDB
{
    /// <summary>
    /// <para>Implementation for accessing QLDB</para>
    ///
    /// The resource management API for Amazon QLDB
    /// </summary>
    public partial class AmazonQLDBClient : AmazonServiceClient, IAmazonQLDB
    {
        private static IServiceMetadata serviceMetadata = new AmazonQLDBMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonQLDBClient with the credentials loaded from the application's
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
        public AmazonQLDBClient()
            : base(new AmazonQLDBConfig()) { }

        /// <summary>
        /// Constructs AmazonQLDBClient with the credentials loaded from the application's
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
        public AmazonQLDBClient(RegionEndpoint region)
            : base(new AmazonQLDBConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonQLDBClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonQLDBClient Configuration Object</param>
        public AmazonQLDBClient(AmazonQLDBConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonQLDBClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonQLDBClient(AWSCredentials credentials)
            : this(credentials, new AmazonQLDBConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQLDBClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonQLDBConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBClient with AWS Credentials and an
        /// AmazonQLDBClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonQLDBClient Configuration Object</param>
        public AmazonQLDBClient(AWSCredentials credentials, AmazonQLDBConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonQLDBClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQLDBConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQLDBClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQLDBConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQLDBClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonQLDBClient Configuration Object</param>
        public AmazonQLDBClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonQLDBConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonQLDBClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQLDBConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQLDBClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQLDBConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQLDBClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQLDBClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonQLDBClient Configuration Object</param>
        public AmazonQLDBClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonQLDBConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IQLDBPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IQLDBPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new QLDBPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonQLDBEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonQLDBAuthSchemeHandler());
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


        #region  CancelJournalKinesisStream

        internal virtual CancelJournalKinesisStreamResponse CancelJournalKinesisStream(CancelJournalKinesisStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelJournalKinesisStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJournalKinesisStreamResponseUnmarshaller.Instance;

            return Invoke<CancelJournalKinesisStreamResponse>(request, options);
        }



        /// <summary>
        /// Ends a given Amazon QLDB journal stream. Before a stream can be canceled, its current
        /// status must be <c>ACTIVE</c>.
        /// 
        ///  
        /// <para>
        /// You can't restart a stream after you cancel it. Canceled QLDB stream resources are
        /// subject to a 7-day retention period, so they are automatically deleted after this
        /// limit expires.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJournalKinesisStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelJournalKinesisStream service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.InvalidParameterException">
        /// One or more parameters in the request aren't valid.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourcePreconditionNotMetException">
        /// The operation failed because a condition wasn't satisfied in advance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/CancelJournalKinesisStream">REST API Reference for CancelJournalKinesisStream Operation</seealso>
        public virtual Task<CancelJournalKinesisStreamResponse> CancelJournalKinesisStreamAsync(CancelJournalKinesisStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelJournalKinesisStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJournalKinesisStreamResponseUnmarshaller.Instance;

            return InvokeAsync<CancelJournalKinesisStreamResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateLedger

        internal virtual CreateLedgerResponse CreateLedger(CreateLedgerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLedgerResponseUnmarshaller.Instance;

            return Invoke<CreateLedgerResponse>(request, options);
        }



        /// <summary>
        /// Creates a new ledger in your Amazon Web Services account in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLedger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLedger service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.InvalidParameterException">
        /// One or more parameters in the request aren't valid.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.LimitExceededException">
        /// You have reached the limit on the maximum number of resources allowed.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceInUseException">
        /// The specified resource can't be modified at this time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/CreateLedger">REST API Reference for CreateLedger Operation</seealso>
        public virtual Task<CreateLedgerResponse> CreateLedgerAsync(CreateLedgerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLedgerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLedgerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteLedger

        internal virtual DeleteLedgerResponse DeleteLedger(DeleteLedgerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLedgerResponseUnmarshaller.Instance;

            return Invoke<DeleteLedgerResponse>(request, options);
        }



        /// <summary>
        /// Deletes a ledger and all of its contents. This action is irreversible.
        /// 
        ///  
        /// <para>
        /// If deletion protection is enabled, you must first disable it before you can delete
        /// the ledger. You can disable it by calling the <c>UpdateLedger</c> operation to set
        /// this parameter to <c>false</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLedger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLedger service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.InvalidParameterException">
        /// One or more parameters in the request aren't valid.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceInUseException">
        /// The specified resource can't be modified at this time.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourcePreconditionNotMetException">
        /// The operation failed because a condition wasn't satisfied in advance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/DeleteLedger">REST API Reference for DeleteLedger Operation</seealso>
        public virtual Task<DeleteLedgerResponse> DeleteLedgerAsync(DeleteLedgerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLedgerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLedgerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeJournalKinesisStream

        internal virtual DescribeJournalKinesisStreamResponse DescribeJournalKinesisStream(DescribeJournalKinesisStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeJournalKinesisStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJournalKinesisStreamResponseUnmarshaller.Instance;

            return Invoke<DescribeJournalKinesisStreamResponse>(request, options);
        }



        /// <summary>
        /// Returns detailed information about a given Amazon QLDB journal stream. The output
        /// includes the Amazon Resource Name (ARN), stream name, current status, creation time,
        /// and the parameters of the original stream creation request.
        /// 
        ///  
        /// <para>
        /// This action does not return any expired journal streams. For more information, see
        /// <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/streams.create.html#streams.create.states.expiration">Expiration
        /// for terminal streams</a> in the <i>Amazon QLDB Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJournalKinesisStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJournalKinesisStream service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.InvalidParameterException">
        /// One or more parameters in the request aren't valid.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourcePreconditionNotMetException">
        /// The operation failed because a condition wasn't satisfied in advance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/DescribeJournalKinesisStream">REST API Reference for DescribeJournalKinesisStream Operation</seealso>
        public virtual Task<DescribeJournalKinesisStreamResponse> DescribeJournalKinesisStreamAsync(DescribeJournalKinesisStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeJournalKinesisStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJournalKinesisStreamResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeJournalKinesisStreamResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeJournalS3Export

        internal virtual DescribeJournalS3ExportResponse DescribeJournalS3Export(DescribeJournalS3ExportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeJournalS3ExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJournalS3ExportResponseUnmarshaller.Instance;

            return Invoke<DescribeJournalS3ExportResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a journal export job, including the ledger name, export
        /// ID, creation time, current status, and the parameters of the original export creation
        /// request.
        /// 
        ///  
        /// <para>
        /// This action does not return any expired export jobs. For more information, see <a
        /// href="https://docs.aws.amazon.com/qldb/latest/developerguide/export-journal.request.html#export-journal.request.expiration">Export
        /// job expiration</a> in the <i>Amazon QLDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the export job with the given <c>ExportId</c> doesn't exist, then throws <c>ResourceNotFoundException</c>.
        /// </para>
        ///  
        /// <para>
        /// If the ledger with the given <c>Name</c> doesn't exist, then throws <c>ResourceNotFoundException</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJournalS3Export service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJournalS3Export service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/DescribeJournalS3Export">REST API Reference for DescribeJournalS3Export Operation</seealso>
        public virtual Task<DescribeJournalS3ExportResponse> DescribeJournalS3ExportAsync(DescribeJournalS3ExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeJournalS3ExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJournalS3ExportResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeJournalS3ExportResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeLedger

        internal virtual DescribeLedgerResponse DescribeLedger(DescribeLedgerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLedgerResponseUnmarshaller.Instance;

            return Invoke<DescribeLedgerResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a ledger, including its state, permissions mode, encryption
        /// at rest settings, and when it was created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLedger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLedger service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.InvalidParameterException">
        /// One or more parameters in the request aren't valid.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/DescribeLedger">REST API Reference for DescribeLedger Operation</seealso>
        public virtual Task<DescribeLedgerResponse> DescribeLedgerAsync(DescribeLedgerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLedgerResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLedgerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExportJournalToS3

        internal virtual ExportJournalToS3Response ExportJournalToS3(ExportJournalToS3Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportJournalToS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportJournalToS3ResponseUnmarshaller.Instance;

            return Invoke<ExportJournalToS3Response>(request, options);
        }



        /// <summary>
        /// Exports journal contents within a date and time range from a ledger into a specified
        /// Amazon Simple Storage Service (Amazon S3) bucket. A journal export job can write the
        /// data objects in either the text or binary representation of Amazon Ion format, or
        /// in <i>JSON Lines</i> text format.
        /// 
        ///  
        /// <para>
        /// If the ledger with the given <c>Name</c> doesn't exist, then throws <c>ResourceNotFoundException</c>.
        /// </para>
        ///  
        /// <para>
        /// If the ledger with the given <c>Name</c> is in <c>CREATING</c> status, then throws
        /// <c>ResourcePreconditionNotMetException</c>.
        /// </para>
        ///  
        /// <para>
        /// You can initiate up to two concurrent journal export requests for each ledger. Beyond
        /// this limit, journal export requests throw <c>LimitExceededException</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportJournalToS3 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportJournalToS3 service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourcePreconditionNotMetException">
        /// The operation failed because a condition wasn't satisfied in advance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ExportJournalToS3">REST API Reference for ExportJournalToS3 Operation</seealso>
        public virtual Task<ExportJournalToS3Response> ExportJournalToS3Async(ExportJournalToS3Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportJournalToS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportJournalToS3ResponseUnmarshaller.Instance;

            return InvokeAsync<ExportJournalToS3Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetBlock

        internal virtual GetBlockResponse GetBlock(GetBlockRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlockResponseUnmarshaller.Instance;

            return Invoke<GetBlockResponse>(request, options);
        }



        /// <summary>
        /// Returns a block object at a specified address in a journal. Also returns a proof of
        /// the specified block for verification if <c>DigestTipAddress</c> is provided.
        /// 
        ///  
        /// <para>
        /// For information about the data contents in a block, see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/journal-contents.html">Journal
        /// contents</a> in the <i>Amazon QLDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the specified ledger doesn't exist or is in <c>DELETING</c> status, then throws
        /// <c>ResourceNotFoundException</c>.
        /// </para>
        ///  
        /// <para>
        /// If the specified ledger is in <c>CREATING</c> status, then throws <c>ResourcePreconditionNotMetException</c>.
        /// </para>
        ///  
        /// <para>
        /// If no block exists with the specified address, then throws <c>InvalidParameterException</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBlock service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.InvalidParameterException">
        /// One or more parameters in the request aren't valid.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourcePreconditionNotMetException">
        /// The operation failed because a condition wasn't satisfied in advance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/GetBlock">REST API Reference for GetBlock Operation</seealso>
        public virtual Task<GetBlockResponse> GetBlockAsync(GetBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlockResponseUnmarshaller.Instance;

            return InvokeAsync<GetBlockResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDigest

        internal virtual GetDigestResponse GetDigest(GetDigestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDigestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDigestResponseUnmarshaller.Instance;

            return Invoke<GetDigestResponse>(request, options);
        }



        /// <summary>
        /// Returns the digest of a ledger at the latest committed block in the journal. The response
        /// includes a 256-bit hash value and a block address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDigest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDigest service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.InvalidParameterException">
        /// One or more parameters in the request aren't valid.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourcePreconditionNotMetException">
        /// The operation failed because a condition wasn't satisfied in advance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/GetDigest">REST API Reference for GetDigest Operation</seealso>
        public virtual Task<GetDigestResponse> GetDigestAsync(GetDigestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDigestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDigestResponseUnmarshaller.Instance;

            return InvokeAsync<GetDigestResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRevision

        internal virtual GetRevisionResponse GetRevision(GetRevisionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRevisionResponseUnmarshaller.Instance;

            return Invoke<GetRevisionResponse>(request, options);
        }



        /// <summary>
        /// Returns a revision data object for a specified document ID and block address. Also
        /// returns a proof of the specified revision for verification if <c>DigestTipAddress</c>
        /// is provided.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRevision service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.InvalidParameterException">
        /// One or more parameters in the request aren't valid.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourcePreconditionNotMetException">
        /// The operation failed because a condition wasn't satisfied in advance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/GetRevision">REST API Reference for GetRevision Operation</seealso>
        public virtual Task<GetRevisionResponse> GetRevisionAsync(GetRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRevisionResponseUnmarshaller.Instance;

            return InvokeAsync<GetRevisionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListJournalKinesisStreamsForLedger

        internal virtual ListJournalKinesisStreamsForLedgerResponse ListJournalKinesisStreamsForLedger(ListJournalKinesisStreamsForLedgerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJournalKinesisStreamsForLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJournalKinesisStreamsForLedgerResponseUnmarshaller.Instance;

            return Invoke<ListJournalKinesisStreamsForLedgerResponse>(request, options);
        }



        /// <summary>
        /// Returns all Amazon QLDB journal streams for a given ledger.
        /// 
        ///  
        /// <para>
        /// This action does not return any expired journal streams. For more information, see
        /// <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/streams.create.html#streams.create.states.expiration">Expiration
        /// for terminal streams</a> in the <i>Amazon QLDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This action returns a maximum of <c>MaxResults</c> items. It is paginated so that
        /// you can retrieve all the items by calling <c>ListJournalKinesisStreamsForLedger</c>
        /// multiple times.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJournalKinesisStreamsForLedger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJournalKinesisStreamsForLedger service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.InvalidParameterException">
        /// One or more parameters in the request aren't valid.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourcePreconditionNotMetException">
        /// The operation failed because a condition wasn't satisfied in advance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ListJournalKinesisStreamsForLedger">REST API Reference for ListJournalKinesisStreamsForLedger Operation</seealso>
        public virtual Task<ListJournalKinesisStreamsForLedgerResponse> ListJournalKinesisStreamsForLedgerAsync(ListJournalKinesisStreamsForLedgerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJournalKinesisStreamsForLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJournalKinesisStreamsForLedgerResponseUnmarshaller.Instance;

            return InvokeAsync<ListJournalKinesisStreamsForLedgerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListJournalS3Exports

        internal virtual ListJournalS3ExportsResponse ListJournalS3Exports(ListJournalS3ExportsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJournalS3ExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJournalS3ExportsResponseUnmarshaller.Instance;

            return Invoke<ListJournalS3ExportsResponse>(request, options);
        }



        /// <summary>
        /// Returns all journal export jobs for all ledgers that are associated with the current
        /// Amazon Web Services account and Region.
        /// 
        ///  
        /// <para>
        /// This action returns a maximum of <c>MaxResults</c> items, and is paginated so that
        /// you can retrieve all the items by calling <c>ListJournalS3Exports</c> multiple times.
        /// </para>
        ///  
        /// <para>
        /// This action does not return any expired export jobs. For more information, see <a
        /// href="https://docs.aws.amazon.com/qldb/latest/developerguide/export-journal.request.html#export-journal.request.expiration">Export
        /// job expiration</a> in the <i>Amazon QLDB Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJournalS3Exports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJournalS3Exports service method, as returned by QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ListJournalS3Exports">REST API Reference for ListJournalS3Exports Operation</seealso>
        public virtual Task<ListJournalS3ExportsResponse> ListJournalS3ExportsAsync(ListJournalS3ExportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJournalS3ExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJournalS3ExportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListJournalS3ExportsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListJournalS3ExportsForLedger

        internal virtual ListJournalS3ExportsForLedgerResponse ListJournalS3ExportsForLedger(ListJournalS3ExportsForLedgerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJournalS3ExportsForLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJournalS3ExportsForLedgerResponseUnmarshaller.Instance;

            return Invoke<ListJournalS3ExportsForLedgerResponse>(request, options);
        }



        /// <summary>
        /// Returns all journal export jobs for a specified ledger.
        /// 
        ///  
        /// <para>
        /// This action returns a maximum of <c>MaxResults</c> items, and is paginated so that
        /// you can retrieve all the items by calling <c>ListJournalS3ExportsForLedger</c> multiple
        /// times.
        /// </para>
        ///  
        /// <para>
        /// This action does not return any expired export jobs. For more information, see <a
        /// href="https://docs.aws.amazon.com/qldb/latest/developerguide/export-journal.request.html#export-journal.request.expiration">Export
        /// job expiration</a> in the <i>Amazon QLDB Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJournalS3ExportsForLedger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJournalS3ExportsForLedger service method, as returned by QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ListJournalS3ExportsForLedger">REST API Reference for ListJournalS3ExportsForLedger Operation</seealso>
        public virtual Task<ListJournalS3ExportsForLedgerResponse> ListJournalS3ExportsForLedgerAsync(ListJournalS3ExportsForLedgerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJournalS3ExportsForLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJournalS3ExportsForLedgerResponseUnmarshaller.Instance;

            return InvokeAsync<ListJournalS3ExportsForLedgerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListLedgers

        internal virtual ListLedgersResponse ListLedgers(ListLedgersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLedgersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLedgersResponseUnmarshaller.Instance;

            return Invoke<ListLedgersResponse>(request, options);
        }



        /// <summary>
        /// Returns all ledgers that are associated with the current Amazon Web Services account
        /// and Region.
        /// 
        ///  
        /// <para>
        /// This action returns a maximum of <c>MaxResults</c> items and is paginated so that
        /// you can retrieve all the items by calling <c>ListLedgers</c> multiple times.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLedgers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLedgers service method, as returned by QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ListLedgers">REST API Reference for ListLedgers Operation</seealso>
        public virtual Task<ListLedgersResponse> ListLedgersAsync(ListLedgersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLedgersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLedgersResponseUnmarshaller.Instance;

            return InvokeAsync<ListLedgersResponse>(request, options, cancellationToken);
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
        /// Returns all tags for a specified Amazon QLDB resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.InvalidParameterException">
        /// One or more parameters in the request aren't valid.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StreamJournalToKinesis

        internal virtual StreamJournalToKinesisResponse StreamJournalToKinesis(StreamJournalToKinesisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StreamJournalToKinesisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StreamJournalToKinesisResponseUnmarshaller.Instance;

            return Invoke<StreamJournalToKinesisResponse>(request, options);
        }



        /// <summary>
        /// Creates a journal stream for a given Amazon QLDB ledger. The stream captures every
        /// document revision that is committed to the ledger's journal and delivers the data
        /// to a specified Amazon Kinesis Data Streams resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StreamJournalToKinesis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StreamJournalToKinesis service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.InvalidParameterException">
        /// One or more parameters in the request aren't valid.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourcePreconditionNotMetException">
        /// The operation failed because a condition wasn't satisfied in advance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/StreamJournalToKinesis">REST API Reference for StreamJournalToKinesis Operation</seealso>
        public virtual Task<StreamJournalToKinesisResponse> StreamJournalToKinesisAsync(StreamJournalToKinesisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StreamJournalToKinesisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StreamJournalToKinesisResponseUnmarshaller.Instance;

            return InvokeAsync<StreamJournalToKinesisResponse>(request, options, cancellationToken);
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
        /// Adds one or more tags to a specified Amazon QLDB resource.
        /// 
        ///  
        /// <para>
        /// A resource can have up to 50 tags. If you try to create more than 50 tags for a resource,
        /// your request fails and returns an error.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.InvalidParameterException">
        /// One or more parameters in the request aren't valid.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes one or more tags from a specified Amazon QLDB resource. You can specify up
        /// to 50 tag keys to remove.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.InvalidParameterException">
        /// One or more parameters in the request aren't valid.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateLedger

        internal virtual UpdateLedgerResponse UpdateLedger(UpdateLedgerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLedgerResponseUnmarshaller.Instance;

            return Invoke<UpdateLedgerResponse>(request, options);
        }



        /// <summary>
        /// Updates properties on a ledger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLedger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLedger service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.InvalidParameterException">
        /// One or more parameters in the request aren't valid.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/UpdateLedger">REST API Reference for UpdateLedger Operation</seealso>
        public virtual Task<UpdateLedgerResponse> UpdateLedgerAsync(UpdateLedgerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLedgerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLedgerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateLedgerPermissionsMode

        internal virtual UpdateLedgerPermissionsModeResponse UpdateLedgerPermissionsMode(UpdateLedgerPermissionsModeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLedgerPermissionsModeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLedgerPermissionsModeResponseUnmarshaller.Instance;

            return Invoke<UpdateLedgerPermissionsModeResponse>(request, options);
        }



        /// <summary>
        /// Updates the permissions mode of a ledger.
        /// 
        ///  <important> 
        /// <para>
        /// Before you switch to the <c>STANDARD</c> permissions mode, you must first create all
        /// required IAM policies and table tags to avoid disruption to your users. To learn more,
        /// see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/ledger-management.basics.html#ledger-mgmt.basics.update-permissions.migrating">Migrating
        /// to the standard permissions mode</a> in the <i>Amazon QLDB Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLedgerPermissionsMode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLedgerPermissionsMode service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.InvalidParameterException">
        /// One or more parameters in the request aren't valid.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/UpdateLedgerPermissionsMode">REST API Reference for UpdateLedgerPermissionsMode Operation</seealso>
        public virtual Task<UpdateLedgerPermissionsModeResponse> UpdateLedgerPermissionsModeAsync(UpdateLedgerPermissionsModeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLedgerPermissionsModeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLedgerPermissionsModeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLedgerPermissionsModeResponse>(request, options, cancellationToken);
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