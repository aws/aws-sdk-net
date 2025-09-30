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
using System.Collections.Generic;
using System.Net;

using Amazon.QLDB.Model;
using Amazon.QLDB.Model.Internal.MarshallTransformations;
using Amazon.QLDB.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonQLDBConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonQLDBConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonQLDBEndpointResolver());
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
        public virtual CancelJournalKinesisStreamResponse CancelJournalKinesisStream(CancelJournalKinesisStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelJournalKinesisStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJournalKinesisStreamResponseUnmarshaller.Instance;

            return Invoke<CancelJournalKinesisStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelJournalKinesisStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJournalKinesisStream operation on AmazonQLDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelJournalKinesisStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/CancelJournalKinesisStream">REST API Reference for CancelJournalKinesisStream Operation</seealso>
        public virtual IAsyncResult BeginCancelJournalKinesisStream(CancelJournalKinesisStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelJournalKinesisStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJournalKinesisStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelJournalKinesisStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelJournalKinesisStream.</param>
        /// 
        /// <returns>Returns a  CancelJournalKinesisStreamResult from QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/CancelJournalKinesisStream">REST API Reference for CancelJournalKinesisStream Operation</seealso>
        public virtual CancelJournalKinesisStreamResponse EndCancelJournalKinesisStream(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelJournalKinesisStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLedger

        /// <summary>
        /// Creates a new ledger in your Amazon Web Services account in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLedger service method.</param>
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
        public virtual CreateLedgerResponse CreateLedger(CreateLedgerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLedgerResponseUnmarshaller.Instance;

            return Invoke<CreateLedgerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLedger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLedger operation on AmazonQLDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLedger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/CreateLedger">REST API Reference for CreateLedger Operation</seealso>
        public virtual IAsyncResult BeginCreateLedger(CreateLedgerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLedgerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLedger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLedger.</param>
        /// 
        /// <returns>Returns a  CreateLedgerResult from QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/CreateLedger">REST API Reference for CreateLedger Operation</seealso>
        public virtual CreateLedgerResponse EndCreateLedger(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLedgerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLedger

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
        public virtual DeleteLedgerResponse DeleteLedger(DeleteLedgerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLedgerResponseUnmarshaller.Instance;

            return Invoke<DeleteLedgerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLedger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLedger operation on AmazonQLDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLedger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/DeleteLedger">REST API Reference for DeleteLedger Operation</seealso>
        public virtual IAsyncResult BeginDeleteLedger(DeleteLedgerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLedgerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLedger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLedger.</param>
        /// 
        /// <returns>Returns a  DeleteLedgerResult from QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/DeleteLedger">REST API Reference for DeleteLedger Operation</seealso>
        public virtual DeleteLedgerResponse EndDeleteLedger(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLedgerResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeJournalKinesisStream

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
        public virtual DescribeJournalKinesisStreamResponse DescribeJournalKinesisStream(DescribeJournalKinesisStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeJournalKinesisStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJournalKinesisStreamResponseUnmarshaller.Instance;

            return Invoke<DescribeJournalKinesisStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJournalKinesisStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJournalKinesisStream operation on AmazonQLDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJournalKinesisStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/DescribeJournalKinesisStream">REST API Reference for DescribeJournalKinesisStream Operation</seealso>
        public virtual IAsyncResult BeginDescribeJournalKinesisStream(DescribeJournalKinesisStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeJournalKinesisStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJournalKinesisStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJournalKinesisStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJournalKinesisStream.</param>
        /// 
        /// <returns>Returns a  DescribeJournalKinesisStreamResult from QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/DescribeJournalKinesisStream">REST API Reference for DescribeJournalKinesisStream Operation</seealso>
        public virtual DescribeJournalKinesisStreamResponse EndDescribeJournalKinesisStream(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeJournalKinesisStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeJournalS3Export

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
        /// 
        /// <returns>The response from the DescribeJournalS3Export service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/DescribeJournalS3Export">REST API Reference for DescribeJournalS3Export Operation</seealso>
        public virtual DescribeJournalS3ExportResponse DescribeJournalS3Export(DescribeJournalS3ExportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeJournalS3ExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJournalS3ExportResponseUnmarshaller.Instance;

            return Invoke<DescribeJournalS3ExportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJournalS3Export operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJournalS3Export operation on AmazonQLDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJournalS3Export
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/DescribeJournalS3Export">REST API Reference for DescribeJournalS3Export Operation</seealso>
        public virtual IAsyncResult BeginDescribeJournalS3Export(DescribeJournalS3ExportRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeJournalS3ExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJournalS3ExportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJournalS3Export operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJournalS3Export.</param>
        /// 
        /// <returns>Returns a  DescribeJournalS3ExportResult from QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/DescribeJournalS3Export">REST API Reference for DescribeJournalS3Export Operation</seealso>
        public virtual DescribeJournalS3ExportResponse EndDescribeJournalS3Export(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeJournalS3ExportResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLedger

        /// <summary>
        /// Returns information about a ledger, including its state, permissions mode, encryption
        /// at rest settings, and when it was created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLedger service method.</param>
        /// 
        /// <returns>The response from the DescribeLedger service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.InvalidParameterException">
        /// One or more parameters in the request aren't valid.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/DescribeLedger">REST API Reference for DescribeLedger Operation</seealso>
        public virtual DescribeLedgerResponse DescribeLedger(DescribeLedgerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLedgerResponseUnmarshaller.Instance;

            return Invoke<DescribeLedgerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLedger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLedger operation on AmazonQLDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLedger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/DescribeLedger">REST API Reference for DescribeLedger Operation</seealso>
        public virtual IAsyncResult BeginDescribeLedger(DescribeLedgerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLedgerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLedger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLedger.</param>
        /// 
        /// <returns>Returns a  DescribeLedgerResult from QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/DescribeLedger">REST API Reference for DescribeLedger Operation</seealso>
        public virtual DescribeLedgerResponse EndDescribeLedger(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLedgerResponse>(asyncResult);
        }

        #endregion
        
        #region  ExportJournalToS3

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
        /// 
        /// <returns>The response from the ExportJournalToS3 service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourcePreconditionNotMetException">
        /// The operation failed because a condition wasn't satisfied in advance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ExportJournalToS3">REST API Reference for ExportJournalToS3 Operation</seealso>
        public virtual ExportJournalToS3Response ExportJournalToS3(ExportJournalToS3Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportJournalToS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportJournalToS3ResponseUnmarshaller.Instance;

            return Invoke<ExportJournalToS3Response>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportJournalToS3 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportJournalToS3 operation on AmazonQLDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportJournalToS3
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ExportJournalToS3">REST API Reference for ExportJournalToS3 Operation</seealso>
        public virtual IAsyncResult BeginExportJournalToS3(ExportJournalToS3Request request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportJournalToS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportJournalToS3ResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExportJournalToS3 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportJournalToS3.</param>
        /// 
        /// <returns>Returns a  ExportJournalToS3Result from QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ExportJournalToS3">REST API Reference for ExportJournalToS3 Operation</seealso>
        public virtual ExportJournalToS3Response EndExportJournalToS3(IAsyncResult asyncResult)
        {
            return EndInvoke<ExportJournalToS3Response>(asyncResult);
        }

        #endregion
        
        #region  GetBlock

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
        public virtual GetBlockResponse GetBlock(GetBlockRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlockResponseUnmarshaller.Instance;

            return Invoke<GetBlockResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBlock operation on AmazonQLDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBlock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/GetBlock">REST API Reference for GetBlock Operation</seealso>
        public virtual IAsyncResult BeginGetBlock(GetBlockRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlockResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBlock.</param>
        /// 
        /// <returns>Returns a  GetBlockResult from QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/GetBlock">REST API Reference for GetBlock Operation</seealso>
        public virtual GetBlockResponse EndGetBlock(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBlockResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDigest

        /// <summary>
        /// Returns the digest of a ledger at the latest committed block in the journal. The response
        /// includes a 256-bit hash value and a block address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDigest service method.</param>
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
        public virtual GetDigestResponse GetDigest(GetDigestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDigestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDigestResponseUnmarshaller.Instance;

            return Invoke<GetDigestResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDigest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDigest operation on AmazonQLDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDigest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/GetDigest">REST API Reference for GetDigest Operation</seealso>
        public virtual IAsyncResult BeginGetDigest(GetDigestRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDigestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDigestResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDigest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDigest.</param>
        /// 
        /// <returns>Returns a  GetDigestResult from QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/GetDigest">REST API Reference for GetDigest Operation</seealso>
        public virtual GetDigestResponse EndGetDigest(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDigestResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRevision

        /// <summary>
        /// Returns a revision data object for a specified document ID and block address. Also
        /// returns a proof of the specified revision for verification if <c>DigestTipAddress</c>
        /// is provided.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRevision service method.</param>
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
        public virtual GetRevisionResponse GetRevision(GetRevisionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRevisionResponseUnmarshaller.Instance;

            return Invoke<GetRevisionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRevision operation on AmazonQLDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRevision
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/GetRevision">REST API Reference for GetRevision Operation</seealso>
        public virtual IAsyncResult BeginGetRevision(GetRevisionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRevisionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRevision operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRevision.</param>
        /// 
        /// <returns>Returns a  GetRevisionResult from QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/GetRevision">REST API Reference for GetRevision Operation</seealso>
        public virtual GetRevisionResponse EndGetRevision(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRevisionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListJournalKinesisStreamsForLedger

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
        public virtual ListJournalKinesisStreamsForLedgerResponse ListJournalKinesisStreamsForLedger(ListJournalKinesisStreamsForLedgerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJournalKinesisStreamsForLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJournalKinesisStreamsForLedgerResponseUnmarshaller.Instance;

            return Invoke<ListJournalKinesisStreamsForLedgerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJournalKinesisStreamsForLedger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJournalKinesisStreamsForLedger operation on AmazonQLDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJournalKinesisStreamsForLedger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ListJournalKinesisStreamsForLedger">REST API Reference for ListJournalKinesisStreamsForLedger Operation</seealso>
        public virtual IAsyncResult BeginListJournalKinesisStreamsForLedger(ListJournalKinesisStreamsForLedgerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJournalKinesisStreamsForLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJournalKinesisStreamsForLedgerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListJournalKinesisStreamsForLedger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJournalKinesisStreamsForLedger.</param>
        /// 
        /// <returns>Returns a  ListJournalKinesisStreamsForLedgerResult from QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ListJournalKinesisStreamsForLedger">REST API Reference for ListJournalKinesisStreamsForLedger Operation</seealso>
        public virtual ListJournalKinesisStreamsForLedgerResponse EndListJournalKinesisStreamsForLedger(IAsyncResult asyncResult)
        {
            return EndInvoke<ListJournalKinesisStreamsForLedgerResponse>(asyncResult);
        }

        #endregion
        
        #region  ListJournalS3Exports

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
        /// 
        /// <returns>The response from the ListJournalS3Exports service method, as returned by QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ListJournalS3Exports">REST API Reference for ListJournalS3Exports Operation</seealso>
        public virtual ListJournalS3ExportsResponse ListJournalS3Exports(ListJournalS3ExportsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJournalS3ExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJournalS3ExportsResponseUnmarshaller.Instance;

            return Invoke<ListJournalS3ExportsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJournalS3Exports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJournalS3Exports operation on AmazonQLDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJournalS3Exports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ListJournalS3Exports">REST API Reference for ListJournalS3Exports Operation</seealso>
        public virtual IAsyncResult BeginListJournalS3Exports(ListJournalS3ExportsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJournalS3ExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJournalS3ExportsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListJournalS3Exports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJournalS3Exports.</param>
        /// 
        /// <returns>Returns a  ListJournalS3ExportsResult from QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ListJournalS3Exports">REST API Reference for ListJournalS3Exports Operation</seealso>
        public virtual ListJournalS3ExportsResponse EndListJournalS3Exports(IAsyncResult asyncResult)
        {
            return EndInvoke<ListJournalS3ExportsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListJournalS3ExportsForLedger

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
        /// 
        /// <returns>The response from the ListJournalS3ExportsForLedger service method, as returned by QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ListJournalS3ExportsForLedger">REST API Reference for ListJournalS3ExportsForLedger Operation</seealso>
        public virtual ListJournalS3ExportsForLedgerResponse ListJournalS3ExportsForLedger(ListJournalS3ExportsForLedgerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJournalS3ExportsForLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJournalS3ExportsForLedgerResponseUnmarshaller.Instance;

            return Invoke<ListJournalS3ExportsForLedgerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJournalS3ExportsForLedger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJournalS3ExportsForLedger operation on AmazonQLDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJournalS3ExportsForLedger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ListJournalS3ExportsForLedger">REST API Reference for ListJournalS3ExportsForLedger Operation</seealso>
        public virtual IAsyncResult BeginListJournalS3ExportsForLedger(ListJournalS3ExportsForLedgerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJournalS3ExportsForLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJournalS3ExportsForLedgerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListJournalS3ExportsForLedger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJournalS3ExportsForLedger.</param>
        /// 
        /// <returns>Returns a  ListJournalS3ExportsForLedgerResult from QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ListJournalS3ExportsForLedger">REST API Reference for ListJournalS3ExportsForLedger Operation</seealso>
        public virtual ListJournalS3ExportsForLedgerResponse EndListJournalS3ExportsForLedger(IAsyncResult asyncResult)
        {
            return EndInvoke<ListJournalS3ExportsForLedgerResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLedgers

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
        /// 
        /// <returns>The response from the ListLedgers service method, as returned by QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ListLedgers">REST API Reference for ListLedgers Operation</seealso>
        public virtual ListLedgersResponse ListLedgers(ListLedgersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLedgersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLedgersResponseUnmarshaller.Instance;

            return Invoke<ListLedgersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLedgers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLedgers operation on AmazonQLDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLedgers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ListLedgers">REST API Reference for ListLedgers Operation</seealso>
        public virtual IAsyncResult BeginListLedgers(ListLedgersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLedgersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLedgersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLedgers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLedgers.</param>
        /// 
        /// <returns>Returns a  ListLedgersResult from QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ListLedgers">REST API Reference for ListLedgers Operation</seealso>
        public virtual ListLedgersResponse EndListLedgers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLedgersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns all tags for a specified Amazon QLDB resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.InvalidParameterException">
        /// One or more parameters in the request aren't valid.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonQLDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  StreamJournalToKinesis

        /// <summary>
        /// Creates a journal stream for a given Amazon QLDB ledger. The stream captures every
        /// document revision that is committed to the ledger's journal and delivers the data
        /// to a specified Amazon Kinesis Data Streams resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StreamJournalToKinesis service method.</param>
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
        public virtual StreamJournalToKinesisResponse StreamJournalToKinesis(StreamJournalToKinesisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StreamJournalToKinesisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StreamJournalToKinesisResponseUnmarshaller.Instance;

            return Invoke<StreamJournalToKinesisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StreamJournalToKinesis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StreamJournalToKinesis operation on AmazonQLDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStreamJournalToKinesis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/StreamJournalToKinesis">REST API Reference for StreamJournalToKinesis Operation</seealso>
        public virtual IAsyncResult BeginStreamJournalToKinesis(StreamJournalToKinesisRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StreamJournalToKinesisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StreamJournalToKinesisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StreamJournalToKinesis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStreamJournalToKinesis.</param>
        /// 
        /// <returns>Returns a  StreamJournalToKinesisResult from QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/StreamJournalToKinesis">REST API Reference for StreamJournalToKinesis Operation</seealso>
        public virtual StreamJournalToKinesisResponse EndStreamJournalToKinesis(IAsyncResult asyncResult)
        {
            return EndInvoke<StreamJournalToKinesisResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

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
        /// 
        /// <returns>The response from the TagResource service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.InvalidParameterException">
        /// One or more parameters in the request aren't valid.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonQLDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes one or more tags from a specified Amazon QLDB resource. You can specify up
        /// to 50 tag keys to remove.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.InvalidParameterException">
        /// One or more parameters in the request aren't valid.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonQLDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLedger

        /// <summary>
        /// Updates properties on a ledger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLedger service method.</param>
        /// 
        /// <returns>The response from the UpdateLedger service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.InvalidParameterException">
        /// One or more parameters in the request aren't valid.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/UpdateLedger">REST API Reference for UpdateLedger Operation</seealso>
        public virtual UpdateLedgerResponse UpdateLedger(UpdateLedgerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLedgerResponseUnmarshaller.Instance;

            return Invoke<UpdateLedgerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLedger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLedger operation on AmazonQLDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLedger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/UpdateLedger">REST API Reference for UpdateLedger Operation</seealso>
        public virtual IAsyncResult BeginUpdateLedger(UpdateLedgerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLedgerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLedgerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLedger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLedger.</param>
        /// 
        /// <returns>Returns a  UpdateLedgerResult from QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/UpdateLedger">REST API Reference for UpdateLedger Operation</seealso>
        public virtual UpdateLedgerResponse EndUpdateLedger(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLedgerResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLedgerPermissionsMode

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
        /// 
        /// <returns>The response from the UpdateLedgerPermissionsMode service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.InvalidParameterException">
        /// One or more parameters in the request aren't valid.
        /// </exception>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/UpdateLedgerPermissionsMode">REST API Reference for UpdateLedgerPermissionsMode Operation</seealso>
        public virtual UpdateLedgerPermissionsModeResponse UpdateLedgerPermissionsMode(UpdateLedgerPermissionsModeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLedgerPermissionsModeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLedgerPermissionsModeResponseUnmarshaller.Instance;

            return Invoke<UpdateLedgerPermissionsModeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLedgerPermissionsMode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLedgerPermissionsMode operation on AmazonQLDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLedgerPermissionsMode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/UpdateLedgerPermissionsMode">REST API Reference for UpdateLedgerPermissionsMode Operation</seealso>
        public virtual IAsyncResult BeginUpdateLedgerPermissionsMode(UpdateLedgerPermissionsModeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLedgerPermissionsModeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLedgerPermissionsModeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLedgerPermissionsMode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLedgerPermissionsMode.</param>
        /// 
        /// <returns>Returns a  UpdateLedgerPermissionsModeResult from QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/UpdateLedgerPermissionsMode">REST API Reference for UpdateLedgerPermissionsMode Operation</seealso>
        public virtual UpdateLedgerPermissionsModeResponse EndUpdateLedgerPermissionsMode(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLedgerPermissionsModeResponse>(asyncResult);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonQLDBEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}