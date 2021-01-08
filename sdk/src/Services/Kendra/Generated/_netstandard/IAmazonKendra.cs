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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Kendra.Model;

namespace Amazon.Kendra
{
    /// <summary>
    /// Interface for accessing Kendra
    ///
    /// Amazon Kendra is a service for indexing large document sets.
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial interface IAmazonKendra : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IKendraPaginatorFactory Paginators { get; }
#endif
                
        #region  BatchDeleteDocument



        /// <summary>
        /// Removes one or more documents from an index. The documents must have been added with
        /// the <a>BatchPutDocument</a> operation.
        /// 
        ///  
        /// <para>
        /// The documents are deleted asynchronously. You can see the progress of the deletion
        /// by using AWS CloudWatch. Any error messages releated to the processing of the batch
        /// are sent to you CloudWatch log.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteDocument service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/BatchDeleteDocument">REST API Reference for BatchDeleteDocument Operation</seealso>
        Task<BatchDeleteDocumentResponse> BatchDeleteDocumentAsync(BatchDeleteDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchPutDocument



        /// <summary>
        /// Adds one or more documents to an index.
        /// 
        ///  
        /// <para>
        /// The <code>BatchPutDocument</code> operation enables you to ingest inline documents
        /// or a set of documents stored in an Amazon S3 bucket. Use this operation to ingest
        /// your text and unstructured text into an index, add custom attributes to the documents,
        /// and to attach an access control list to the documents added to the index.
        /// </para>
        ///  
        /// <para>
        /// The documents are indexed asynchronously. You can see the progress of the batch using
        /// AWS CloudWatch. Any error messages related to processing the batch are sent to your
        /// AWS CloudWatch log.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchPutDocument service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/BatchPutDocument">REST API Reference for BatchPutDocument Operation</seealso>
        Task<BatchPutDocumentResponse> BatchPutDocumentAsync(BatchPutDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDataSource



        /// <summary>
        /// Creates a data source that you use to with an Amazon Kendra index. 
        /// 
        ///  
        /// <para>
        /// You specify a name, data source connector type and description for your data source.
        /// You also specify configuration information such as document metadata (author, source
        /// URI, and so on) and user context information.
        /// </para>
        ///  
        /// <para>
        ///  <code>CreateDataSource</code> is a synchronous operation. The operation returns 200
        /// if the data source was successfully created. Otherwise, an exception is raised.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceAlreadyExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        Task<CreateDataSourceResponse> CreateDataSourceAsync(CreateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFaq



        /// <summary>
        /// Creates an new set of frequently asked question (FAQ) questions and answers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFaq service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFaq service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateFaq">REST API Reference for CreateFaq Operation</seealso>
        Task<CreateFaqResponse> CreateFaqAsync(CreateFaqRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateIndex



        /// <summary>
        /// Creates a new Amazon Kendra index. Index creation is an asynchronous operation. To
        /// determine if index creation has completed, check the <code>Status</code> field returned
        /// from a call to . The <code>Status</code> field is set to <code>ACTIVE</code> when
        /// the index is ready to use.
        /// 
        ///  
        /// <para>
        /// Once the index is active you can index your documents using the operation or using
        /// one of the supported data sources. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIndex service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceAlreadyExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        Task<CreateIndexResponse> CreateIndexAsync(CreateIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateThesaurus



        /// <summary>
        /// Creates a thesaurus for an index. The thesaurus contains a list of synonyms in Solr
        /// format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThesaurus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateThesaurus service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateThesaurus">REST API Reference for CreateThesaurus Operation</seealso>
        Task<CreateThesaurusResponse> CreateThesaurusAsync(CreateThesaurusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDataSource



        /// <summary>
        /// Deletes an Amazon Kendra data source. An exception is not thrown if the data source
        /// is already being deleted. While the data source is being deleted, the <code>Status</code>
        /// field returned by a call to the operation is set to <code>DELETING</code>. For more
        /// information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/delete-data-source.html">Deleting
        /// Data Sources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFaq



        /// <summary>
        /// Removes an FAQ from an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFaq service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFaq service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteFaq">REST API Reference for DeleteFaq Operation</seealso>
        Task<DeleteFaqResponse> DeleteFaqAsync(DeleteFaqRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteIndex



        /// <summary>
        /// Deletes an existing Amazon Kendra index. An exception is not thrown if the index is
        /// already being deleted. While the index is being deleted, the <code>Status</code> field
        /// returned by a call to the <a>DescribeIndex</a> operation is set to <code>DELETING</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIndex service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteIndex">REST API Reference for DeleteIndex Operation</seealso>
        Task<DeleteIndexResponse> DeleteIndexAsync(DeleteIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteThesaurus



        /// <summary>
        /// Deletes an existing Amazon Kendra thesaurus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThesaurus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteThesaurus service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteThesaurus">REST API Reference for DeleteThesaurus Operation</seealso>
        Task<DeleteThesaurusResponse> DeleteThesaurusAsync(DeleteThesaurusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDataSource



        /// <summary>
        /// Gets information about a Amazon Kendra data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataSource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeDataSource">REST API Reference for DescribeDataSource Operation</seealso>
        Task<DescribeDataSourceResponse> DescribeDataSourceAsync(DescribeDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFaq



        /// <summary>
        /// Gets information about an FAQ list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFaq service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFaq service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeFaq">REST API Reference for DescribeFaq Operation</seealso>
        Task<DescribeFaqResponse> DescribeFaqAsync(DescribeFaqRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeIndex



        /// <summary>
        /// Describes an existing Amazon Kendra index
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIndex service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeIndex">REST API Reference for DescribeIndex Operation</seealso>
        Task<DescribeIndexResponse> DescribeIndexAsync(DescribeIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeThesaurus



        /// <summary>
        /// Describes an existing Amazon Kendra thesaurus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThesaurus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeThesaurus service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeThesaurus">REST API Reference for DescribeThesaurus Operation</seealso>
        Task<DescribeThesaurusResponse> DescribeThesaurusAsync(DescribeThesaurusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDataSources



        /// <summary>
        /// Lists the data sources that you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        Task<ListDataSourcesResponse> ListDataSourcesAsync(ListDataSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDataSourceSyncJobs



        /// <summary>
        /// Gets statistics about synchronizing Amazon Kendra with a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceSyncJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSourceSyncJobs service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListDataSourceSyncJobs">REST API Reference for ListDataSourceSyncJobs Operation</seealso>
        Task<ListDataSourceSyncJobsResponse> ListDataSourceSyncJobsAsync(ListDataSourceSyncJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFaqs



        /// <summary>
        /// Gets a list of FAQ lists associated with an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFaqs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFaqs service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListFaqs">REST API Reference for ListFaqs Operation</seealso>
        Task<ListFaqsResponse> ListFaqsAsync(ListFaqsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListIndices



        /// <summary>
        /// Lists the Amazon Kendra indexes that you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIndices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIndices service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListIndices">REST API Reference for ListIndices Operation</seealso>
        Task<ListIndicesResponse> ListIndicesAsync(ListIndicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Gets a list of tags associated with a specified resource. Indexes, FAQs, and data
        /// sources can have tags associated with them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListThesauri



        /// <summary>
        /// Lists the Amazon Kendra thesauri associated with an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThesauri service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThesauri service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListThesauri">REST API Reference for ListThesauri Operation</seealso>
        Task<ListThesauriResponse> ListThesauriAsync(ListThesauriRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  Query



        /// <summary>
        /// Searches an active index. Use this API to search your documents using query. The <code>Query</code>
        /// operation enables to do faceted search and to filter results based on document attributes.
        /// 
        ///  
        /// <para>
        /// It also enables you to provide user context that Amazon Kendra uses to enforce document
        /// access control in the search results. 
        /// </para>
        ///  
        /// <para>
        /// Amazon Kendra searches your index for text content and question and answer (FAQ) content.
        /// By default the response contains three types of results.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Relevant passages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Matching FAQs
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Relevant documents
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can specify that the query return only one type of result using the <code>QueryResultTypeConfig</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// Each query returns the 100 most relevant results. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Query service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Query service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/Query">REST API Reference for Query Operation</seealso>
        Task<QueryResponse> QueryAsync(QueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartDataSourceSyncJob



        /// <summary>
        /// Starts a synchronization job for a data source. If a synchronization job is already
        /// in progress, Amazon Kendra returns a <code>ResourceInUseException</code> exception.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataSourceSyncJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDataSourceSyncJob service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/StartDataSourceSyncJob">REST API Reference for StartDataSourceSyncJob Operation</seealso>
        Task<StartDataSourceSyncJobResponse> StartDataSourceSyncJobAsync(StartDataSourceSyncJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopDataSourceSyncJob



        /// <summary>
        /// Stops a running synchronization job. You can't stop a scheduled synchronization job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDataSourceSyncJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopDataSourceSyncJob service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/StopDataSourceSyncJob">REST API Reference for StopDataSourceSyncJob Operation</seealso>
        Task<StopDataSourceSyncJobResponse> StopDataSourceSyncJobAsync(StopDataSourceSyncJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SubmitFeedback



        /// <summary>
        /// Enables you to provide feedback to Amazon Kendra to improve the performance of the
        /// service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SubmitFeedback service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/SubmitFeedback">REST API Reference for SubmitFeedback Operation</seealso>
        Task<SubmitFeedbackResponse> SubmitFeedbackAsync(SubmitFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds the specified tag to the specified index, FAQ, or data source resource. If the
        /// tag already exists, the existing value is replaced with the new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes a tag from an index, FAQ, or a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDataSource



        /// <summary>
        /// Updates an existing Amazon Kendra data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateIndex



        /// <summary>
        /// Updates an existing Amazon Kendra index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIndex service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateIndex">REST API Reference for UpdateIndex Operation</seealso>
        Task<UpdateIndexResponse> UpdateIndexAsync(UpdateIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateThesaurus



        /// <summary>
        /// Updates a thesaurus file associated with an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThesaurus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateThesaurus service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateThesaurus">REST API Reference for UpdateThesaurus Operation</seealso>
        Task<UpdateThesaurusResponse> UpdateThesaurusAsync(UpdateThesaurusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}