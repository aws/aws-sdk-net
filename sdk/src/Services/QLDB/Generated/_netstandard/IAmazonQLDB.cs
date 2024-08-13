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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.QLDB.Model;

#pragma warning disable CS1570
namespace Amazon.QLDB
{
    /// <summary>
    /// <para>Interface for accessing QLDB</para>
    ///
    /// The resource management API for Amazon QLDB
    /// </summary>
    public partial interface IAmazonQLDB : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IQLDBPaginatorFactory Paginators { get; }
#endif
                
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
        Task<CancelJournalKinesisStreamResponse> CancelJournalKinesisStreamAsync(CancelJournalKinesisStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLedger



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
        Task<CreateLedgerResponse> CreateLedgerAsync(CreateLedgerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<DeleteLedgerResponse> DeleteLedgerAsync(DeleteLedgerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<DescribeJournalKinesisStreamResponse> DescribeJournalKinesisStreamAsync(DescribeJournalKinesisStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJournalS3Export service method, as returned by QLDB.</returns>
        /// <exception cref="Amazon.QLDB.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/DescribeJournalS3Export">REST API Reference for DescribeJournalS3Export Operation</seealso>
        Task<DescribeJournalS3ExportResponse> DescribeJournalS3ExportAsync(DescribeJournalS3ExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLedger



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
        Task<DescribeLedgerResponse> DescribeLedgerAsync(DescribeLedgerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<ExportJournalToS3Response> ExportJournalToS3Async(ExportJournalToS3Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<GetBlockResponse> GetBlockAsync(GetBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDigest



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
        Task<GetDigestResponse> GetDigestAsync(GetDigestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRevision



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
        Task<GetRevisionResponse> GetRevisionAsync(GetRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<ListJournalKinesisStreamsForLedgerResponse> ListJournalKinesisStreamsForLedgerAsync(ListJournalKinesisStreamsForLedgerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJournalS3Exports service method, as returned by QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ListJournalS3Exports">REST API Reference for ListJournalS3Exports Operation</seealso>
        Task<ListJournalS3ExportsResponse> ListJournalS3ExportsAsync(ListJournalS3ExportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJournalS3ExportsForLedger service method, as returned by QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ListJournalS3ExportsForLedger">REST API Reference for ListJournalS3ExportsForLedger Operation</seealso>
        Task<ListJournalS3ExportsForLedgerResponse> ListJournalS3ExportsForLedgerAsync(ListJournalS3ExportsForLedgerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLedgers service method, as returned by QLDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-2019-01-02/ListLedgers">REST API Reference for ListLedgers Operation</seealso>
        Task<ListLedgersResponse> ListLedgersAsync(ListLedgersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StreamJournalToKinesis



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
        Task<StreamJournalToKinesisResponse> StreamJournalToKinesisAsync(StreamJournalToKinesisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateLedger



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
        Task<UpdateLedgerResponse> UpdateLedgerAsync(UpdateLedgerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<UpdateLedgerPermissionsModeResponse> UpdateLedgerPermissionsModeAsync(UpdateLedgerPermissionsModeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonQLDBConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonQLDBConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonQLDBConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonQLDBConfig to create AmazonQLDBClient");
            }

            return awsCredentials == null ? 
                    new AmazonQLDBClient(serviceClientConfig) :
                    new AmazonQLDBClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}