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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.S3Tables.Model;

#pragma warning disable CS1570
namespace Amazon.S3Tables
{
    /// <summary>
    /// <para>Interface for accessing S3Tables</para>
    ///
    /// An Amazon S3 table represents a structured dataset consisting of tabular data in <a
    /// href="https://parquet.apache.org/docs/">Apache Parquet</a> format and related metadata.
    /// This data is stored inside an S3 table as a subresource. All tables in a table bucket
    /// are stored in the <a href="https://iceberg.apache.org/docs/latest/">Apache Iceberg</a>
    /// table format. Through integration with the <a href="https://docs.aws.amazon.com/https:/docs.aws.amazon.com/glue/latest/dg/catalog-and-crawler.html">Amazon
    /// Web Services Glue Data Catalog</a> you can interact with your tables using Amazon
    /// Web Services analytics services, such as <a href="https://docs.aws.amazon.com/https:/docs.aws.amazon.com/athena/">Amazon
    /// Athena</a> and <a href="https://docs.aws.amazon.com/https:/docs.aws.amazon.com/redshift/">Amazon
    /// Redshift</a>. Amazon S3 manages maintenance of your tables through automatic file
    /// compaction and snapshot management. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-buckets.html">Amazon
    /// S3 table buckets</a>.
    /// </summary>
    public partial interface IAmazonS3Tables : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IS3TablesPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateNamespace



        /// <summary>
        /// Creates a namespace. A namespace is a logical grouping of tables within your table
        /// bucket, which you can use to organize tables. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-namespace-create.html">Create
        /// a namespace</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:CreateNamespace</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNamespace service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/CreateNamespace">REST API Reference for CreateNamespace Operation</seealso>
        Task<CreateNamespaceResponse> CreateNamespaceAsync(CreateNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTable



        /// <summary>
        /// Creates a new table associated with the given namespace in a table bucket. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-create.html">Creating
        /// an Amazon S3 table</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> <ul> <li> 
        /// <para>
        /// You must have the <c>s3tables:CreateTable</c> permission to use this operation. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use this operation with the optional <c>metadata</c> request parameter you
        /// must have the <c>s3tables:PutTableData</c> permission. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use this operation with the optional <c>encryptionConfiguration</c> request
        /// parameter you must have the <c>s3tables:PutTableEncryption</c> permission. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use this operation with the <c>storageClassConfiguration</c> request parameter,
        /// you must have the <c>s3tables:PutTableStorageClass</c> permission.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a table with tags, you must have the <c>s3tables:TagResource</c> permission
        /// in addition to <c>s3tables:CreateTable</c> permission.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Additionally, If you choose SSE-KMS encryption you must grant the S3 Tables maintenance
        /// principal access to your KMS key. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-kms-permissions.html">Permissions
        /// requirements for S3 Tables SSE-KMS encryption</a>. 
        /// </para>
        ///  </note> </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTable service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/CreateTable">REST API Reference for CreateTable Operation</seealso>
        Task<CreateTableResponse> CreateTableAsync(CreateTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTableBucket



        /// <summary>
        /// Creates a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-buckets-create.html">Creating
        /// a table bucket</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> <ul> <li> 
        /// <para>
        /// You must have the <c>s3tables:CreateTableBucket</c> permission to use this operation.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use this operation with the optional <c>encryptionConfiguration</c> parameter
        /// you must have the <c>s3tables:PutTableBucketEncryption</c> permission.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use this operation with the <c>storageClassConfiguration</c> request parameter,
        /// you must have the <c>s3tables:PutTableBucketStorageClass</c> permission.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a table bucket with tags, you must have the <c>s3tables:TagResource</c>
        /// permission in addition to <c>s3tables:CreateTableBucket</c> permission.
        /// </para>
        ///  </li> </ul> </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTableBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTableBucket service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/CreateTableBucket">REST API Reference for CreateTableBucket Operation</seealso>
        Task<CreateTableBucketResponse> CreateTableBucketAsync(CreateTableBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNamespace



        /// <summary>
        /// Deletes a namespace. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-namespace-delete.html">Delete
        /// a namespace</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:DeleteNamespace</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNamespace service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        Task<DeleteNamespaceResponse> DeleteNamespaceAsync(DeleteNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTable



        /// <summary>
        /// Deletes a table. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-delete.html">Deleting
        /// an Amazon S3 table</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:DeleteTable</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTable service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        Task<DeleteTableResponse> DeleteTableAsync(DeleteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTableBucket



        /// <summary>
        /// Deletes a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-buckets-delete.html">Deleting
        /// a table bucket</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:DeleteTableBucket</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTableBucket service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucket">REST API Reference for DeleteTableBucket Operation</seealso>
        Task<DeleteTableBucketResponse> DeleteTableBucketAsync(DeleteTableBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTableBucketEncryption



        /// <summary>
        /// Deletes the encryption configuration for a table bucket.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:DeleteTableBucketEncryption</c> permission to use this
        /// operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableBucketEncryption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTableBucketEncryption service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucketEncryption">REST API Reference for DeleteTableBucketEncryption Operation</seealso>
        Task<DeleteTableBucketEncryptionResponse> DeleteTableBucketEncryptionAsync(DeleteTableBucketEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTableBucketMetricsConfiguration



        /// <summary>
        /// Deletes the metrics configuration for a table bucket.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:DeleteTableBucketMetricsConfiguration</c> permission
        /// to use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableBucketMetricsConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTableBucketMetricsConfiguration service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucketMetricsConfiguration">REST API Reference for DeleteTableBucketMetricsConfiguration Operation</seealso>
        Task<DeleteTableBucketMetricsConfigurationResponse> DeleteTableBucketMetricsConfigurationAsync(DeleteTableBucketMetricsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTableBucketPolicy



        /// <summary>
        /// Deletes a table bucket policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-bucket-policy.html#table-bucket-policy-delete">Deleting
        /// a table bucket policy</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:DeleteTableBucketPolicy</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableBucketPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTableBucketPolicy service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucketPolicy">REST API Reference for DeleteTableBucketPolicy Operation</seealso>
        Task<DeleteTableBucketPolicyResponse> DeleteTableBucketPolicyAsync(DeleteTableBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTableBucketReplication



        /// <summary>
        /// Deletes the replication configuration for a table bucket. After deletion, new table
        /// updates will no longer be replicated to destination buckets, though existing replicated
        /// tables will remain in destination buckets.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:DeleteTableBucketReplication</c> permission to use this
        /// operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableBucketReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTableBucketReplication service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucketReplication">REST API Reference for DeleteTableBucketReplication Operation</seealso>
        Task<DeleteTableBucketReplicationResponse> DeleteTableBucketReplicationAsync(DeleteTableBucketReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTablePolicy



        /// <summary>
        /// Deletes a table policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-table-policy.html#table-policy-delete">Deleting
        /// a table policy</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:DeleteTablePolicy</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTablePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTablePolicy service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTablePolicy">REST API Reference for DeleteTablePolicy Operation</seealso>
        Task<DeleteTablePolicyResponse> DeleteTablePolicyAsync(DeleteTablePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTableReplication



        /// <summary>
        /// Deletes the replication configuration for a specific table. After deletion, new updates
        /// to this table will no longer be replicated to destination tables, though existing
        /// replicated copies will remain in destination buckets.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:DeleteTableReplication</c> permission to use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTableReplication service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableReplication">REST API Reference for DeleteTableReplication Operation</seealso>
        Task<DeleteTableReplicationResponse> DeleteTableReplicationAsync(DeleteTableReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetNamespace



        /// <summary>
        /// Gets details about a namespace. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-namespace.html">Table
        /// namespaces</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetNamespace</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNamespace service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        Task<GetNamespaceResponse> GetNamespaceAsync(GetNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTable



        /// <summary>
        /// Gets details about a table. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-tables.html">S3
        /// Tables</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTable</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTable service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTable">REST API Reference for GetTable Operation</seealso>
        Task<GetTableResponse> GetTableAsync(GetTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTableBucket



        /// <summary>
        /// Gets details on a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-buckets-details.html">Viewing
        /// details about an Amazon S3 table bucket</a> in the <i>Amazon Simple Storage Service
        /// User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableBucket</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableBucket service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucket">REST API Reference for GetTableBucket Operation</seealso>
        Task<GetTableBucketResponse> GetTableBucketAsync(GetTableBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTableBucketEncryption



        /// <summary>
        /// Gets the encryption configuration for a table bucket.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableBucketEncryption</c> permission to use this
        /// operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucketEncryption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableBucketEncryption service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketEncryption">REST API Reference for GetTableBucketEncryption Operation</seealso>
        Task<GetTableBucketEncryptionResponse> GetTableBucketEncryptionAsync(GetTableBucketEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTableBucketMaintenanceConfiguration



        /// <summary>
        /// Gets details about a maintenance configuration for a given table bucket. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-table-buckets-maintenance.html">Amazon
        /// S3 table bucket maintenance</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableBucketMaintenanceConfiguration</c> permission
        /// to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucketMaintenanceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableBucketMaintenanceConfiguration service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketMaintenanceConfiguration">REST API Reference for GetTableBucketMaintenanceConfiguration Operation</seealso>
        Task<GetTableBucketMaintenanceConfigurationResponse> GetTableBucketMaintenanceConfigurationAsync(GetTableBucketMaintenanceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTableBucketMetricsConfiguration



        /// <summary>
        /// Gets the metrics configuration for a table bucket.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableBucketMetricsConfiguration</c> permission to
        /// use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucketMetricsConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableBucketMetricsConfiguration service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketMetricsConfiguration">REST API Reference for GetTableBucketMetricsConfiguration Operation</seealso>
        Task<GetTableBucketMetricsConfigurationResponse> GetTableBucketMetricsConfigurationAsync(GetTableBucketMetricsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTableBucketPolicy



        /// <summary>
        /// Gets details about a table bucket policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-bucket-policy.html#table-bucket-policy-get">Viewing
        /// a table bucket policy</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableBucketPolicy</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucketPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableBucketPolicy service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketPolicy">REST API Reference for GetTableBucketPolicy Operation</seealso>
        Task<GetTableBucketPolicyResponse> GetTableBucketPolicyAsync(GetTableBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTableBucketReplication



        /// <summary>
        /// Retrieves the replication configuration for a table bucket.This operation returns
        /// the IAM role, <c>versionToken</c>, and replication rules that define how tables in
        /// this bucket are replicated to other buckets.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableBucketReplication</c> permission to use this
        /// operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucketReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableBucketReplication service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketReplication">REST API Reference for GetTableBucketReplication Operation</seealso>
        Task<GetTableBucketReplicationResponse> GetTableBucketReplicationAsync(GetTableBucketReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTableBucketStorageClass



        /// <summary>
        /// Retrieves the storage class configuration for a specific table. This allows you to
        /// view the storage class settings that apply to an individual table, which may differ
        /// from the table bucket's default configuration.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableBucketStorageClass</c> permission to use this
        /// operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucketStorageClass service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableBucketStorageClass service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketStorageClass">REST API Reference for GetTableBucketStorageClass Operation</seealso>
        Task<GetTableBucketStorageClassResponse> GetTableBucketStorageClassAsync(GetTableBucketStorageClassRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTableEncryption



        /// <summary>
        /// Gets the encryption configuration for a table.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableEncryption</c> permission to use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableEncryption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableEncryption service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableEncryption">REST API Reference for GetTableEncryption Operation</seealso>
        Task<GetTableEncryptionResponse> GetTableEncryptionAsync(GetTableEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTableMaintenanceConfiguration



        /// <summary>
        /// Gets details about the maintenance configuration of a table. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-maintenance.html">S3
        /// Tables maintenance</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> <ul> <li> 
        /// <para>
        /// You must have the <c>s3tables:GetTableMaintenanceConfiguration</c> permission to use
        /// this operation. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have the <c>s3tables:GetTableData</c> permission to use set the compaction
        /// strategy to <c>sort</c> or <c>zorder</c>.
        /// </para>
        ///  </li> </ul> </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableMaintenanceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableMaintenanceConfiguration service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableMaintenanceConfiguration">REST API Reference for GetTableMaintenanceConfiguration Operation</seealso>
        Task<GetTableMaintenanceConfigurationResponse> GetTableMaintenanceConfigurationAsync(GetTableMaintenanceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTableMaintenanceJobStatus



        /// <summary>
        /// Gets the status of a maintenance job for a table. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-maintenance.html">S3
        /// Tables maintenance</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableMaintenanceJobStatus</c> permission to use this
        /// operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableMaintenanceJobStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableMaintenanceJobStatus service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableMaintenanceJobStatus">REST API Reference for GetTableMaintenanceJobStatus Operation</seealso>
        Task<GetTableMaintenanceJobStatusResponse> GetTableMaintenanceJobStatusAsync(GetTableMaintenanceJobStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTableMetadataLocation



        /// <summary>
        /// Gets the location of the table metadata.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableMetadataLocation</c> permission to use this
        /// operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableMetadataLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableMetadataLocation service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableMetadataLocation">REST API Reference for GetTableMetadataLocation Operation</seealso>
        Task<GetTableMetadataLocationResponse> GetTableMetadataLocationAsync(GetTableMetadataLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTablePolicy



        /// <summary>
        /// Gets details about a table policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-table-policy.html#table-policy-get">Viewing
        /// a table policy</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTablePolicy</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTablePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTablePolicy service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTablePolicy">REST API Reference for GetTablePolicy Operation</seealso>
        Task<GetTablePolicyResponse> GetTablePolicyAsync(GetTablePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTableRecordExpirationConfiguration



        /// <summary>
        /// Retrieves the expiration configuration settings for records in a table, and the status
        /// of the configuration. If the status of the configuration is <c>enabled</c>, records
        /// expire and are automatically removed from the table after the specified number of
        /// days.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableRecordExpirationConfiguration</c> permission
        /// to use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableRecordExpirationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableRecordExpirationConfiguration service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.MethodNotAllowedException">
        /// The requested operation is not allowed on this resource. This may occur when attempting
        /// to modify a resource that is managed by a service or has restrictions that prevent
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableRecordExpirationConfiguration">REST API Reference for GetTableRecordExpirationConfiguration Operation</seealso>
        Task<GetTableRecordExpirationConfigurationResponse> GetTableRecordExpirationConfigurationAsync(GetTableRecordExpirationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTableRecordExpirationJobStatus



        /// <summary>
        /// Retrieves the status, metrics, and details of the latest record expiration job for
        /// a table. This includes when the job ran, and whether it succeeded or failed. If the
        /// job ran successfully, this also includes statistics about the records that were removed.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableRecordExpirationJobStatus</c> permission to
        /// use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableRecordExpirationJobStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableRecordExpirationJobStatus service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.MethodNotAllowedException">
        /// The requested operation is not allowed on this resource. This may occur when attempting
        /// to modify a resource that is managed by a service or has restrictions that prevent
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableRecordExpirationJobStatus">REST API Reference for GetTableRecordExpirationJobStatus Operation</seealso>
        Task<GetTableRecordExpirationJobStatusResponse> GetTableRecordExpirationJobStatusAsync(GetTableRecordExpirationJobStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTableReplication



        /// <summary>
        /// Retrieves the replication configuration for a specific table.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableReplication</c> permission to use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableReplication service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableReplication">REST API Reference for GetTableReplication Operation</seealso>
        Task<GetTableReplicationResponse> GetTableReplicationAsync(GetTableReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTableReplicationStatus



        /// <summary>
        /// Retrieves the replication status for a table, including the status of replication
        /// to each destination. This operation provides visibility into replication health and
        /// progress.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableReplicationStatus</c> permission to use this
        /// operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableReplicationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableReplicationStatus service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableReplicationStatus">REST API Reference for GetTableReplicationStatus Operation</seealso>
        Task<GetTableReplicationStatusResponse> GetTableReplicationStatusAsync(GetTableReplicationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTableStorageClass



        /// <summary>
        /// Retrieves the storage class configuration for a specific table. This allows you to
        /// view the storage class settings that apply to an individual table, which may differ
        /// from the table bucket's default configuration.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableStorageClass</c> permission to use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableStorageClass service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableStorageClass service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableStorageClass">REST API Reference for GetTableStorageClass Operation</seealso>
        Task<GetTableStorageClassResponse> GetTableStorageClassAsync(GetTableStorageClassRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNamespaces



        /// <summary>
        /// Lists the namespaces within a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-namespace.html">Table
        /// namespaces</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:ListNamespaces</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNamespaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNamespaces service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        Task<ListNamespacesResponse> ListNamespacesAsync(ListNamespacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTableBuckets



        /// <summary>
        /// Lists table buckets for your account. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-buckets.html">S3
        /// Table buckets</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:ListTableBuckets</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTableBuckets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTableBuckets service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListTableBuckets">REST API Reference for ListTableBuckets Operation</seealso>
        Task<ListTableBucketsResponse> ListTableBucketsAsync(ListTableBucketsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTables



        /// <summary>
        /// List tables in the given table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-tables.html">S3
        /// Tables</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:ListTables</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListTables">REST API Reference for ListTables Operation</seealso>
        Task<ListTablesResponse> ListTablesAsync(ListTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists all of the tags applied to a specified Amazon S3 Tables resource. Each tag is
        /// a label consisting of a key and value pair. Tags can help you organize, track costs
        /// for, and control access to resources. 
        /// 
        ///  <note> 
        /// <para>
        /// For a list of S3 resources that support tagging, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/tagging.html#manage-tags">Managing
        /// tags for Amazon S3 resources</a>.
        /// </para>
        ///  </note> <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// For tables and table buckets, you must have the <c>s3tables:ListTagsForResource</c>
        /// permission to use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutTableBucketEncryption



        /// <summary>
        /// Sets the encryption configuration for a table bucket.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:PutTableBucketEncryption</c> permission to use this
        /// operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you choose SSE-KMS encryption you must grant the S3 Tables maintenance principal
        /// access to your KMS key. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-kms-permissions.html">Permissions
        /// requirements for S3 Tables SSE-KMS encryption</a> in the <i>Amazon Simple Storage
        /// Service User Guide</i>.
        /// </para>
        ///  </note> </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTableBucketEncryption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTableBucketEncryption service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketEncryption">REST API Reference for PutTableBucketEncryption Operation</seealso>
        Task<PutTableBucketEncryptionResponse> PutTableBucketEncryptionAsync(PutTableBucketEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutTableBucketMaintenanceConfiguration



        /// <summary>
        /// Creates a new maintenance configuration or replaces an existing maintenance configuration
        /// for a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-table-buckets-maintenance.html">Amazon
        /// S3 table bucket maintenance</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:PutTableBucketMaintenanceConfiguration</c> permission
        /// to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTableBucketMaintenanceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTableBucketMaintenanceConfiguration service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketMaintenanceConfiguration">REST API Reference for PutTableBucketMaintenanceConfiguration Operation</seealso>
        Task<PutTableBucketMaintenanceConfigurationResponse> PutTableBucketMaintenanceConfigurationAsync(PutTableBucketMaintenanceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutTableBucketMetricsConfiguration



        /// <summary>
        /// Sets the metrics configuration for a table bucket.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:PutTableBucketMetricsConfiguration</c> permission to
        /// use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTableBucketMetricsConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTableBucketMetricsConfiguration service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketMetricsConfiguration">REST API Reference for PutTableBucketMetricsConfiguration Operation</seealso>
        Task<PutTableBucketMetricsConfigurationResponse> PutTableBucketMetricsConfigurationAsync(PutTableBucketMetricsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutTableBucketPolicy



        /// <summary>
        /// Creates a new table bucket policy or replaces an existing table bucket policy for
        /// a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-bucket-policy.html#table-bucket-policy-add">Adding
        /// a table bucket policy</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:PutTableBucketPolicy</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTableBucketPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTableBucketPolicy service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketPolicy">REST API Reference for PutTableBucketPolicy Operation</seealso>
        Task<PutTableBucketPolicyResponse> PutTableBucketPolicyAsync(PutTableBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutTableBucketReplication



        /// <summary>
        /// Creates or updates the replication configuration for a table bucket. This operation
        /// defines how tables in the source bucket are replicated to destination buckets. Replication
        /// helps ensure data availability and disaster recovery across regions or accounts.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> <ul> <li> 
        /// <para>
        /// You must have the <c>s3tables:PutTableBucketReplication</c> permission to use this
        /// operation. The IAM role specified in the configuration must have permissions to read
        /// from the source bucket and write permissions to all destination buckets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must also have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>s3tables:GetTable</c> permission on the source table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3tables:ListTables</c> permission on the bucket containing the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3tables:CreateTable</c> permission for the destination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3tables:CreateNamespace</c> permission for the destination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3tables:GetTableMaintenanceConfig</c> permission for the source bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3tables:PutTableMaintenanceConfig</c> permission for the destination bucket.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// You must have <c>iam:PassRole</c> permission with condition allowing roles to be passed
        /// to <c>replication.s3tables.amazonaws.com</c>.
        /// </para>
        ///  </li> </ul> </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTableBucketReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTableBucketReplication service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketReplication">REST API Reference for PutTableBucketReplication Operation</seealso>
        Task<PutTableBucketReplicationResponse> PutTableBucketReplicationAsync(PutTableBucketReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutTableBucketStorageClass



        /// <summary>
        /// Sets or updates the storage class configuration for a table bucket. This configuration
        /// serves as the default storage class for all new tables created in the bucket, allowing
        /// you to optimize storage costs at the bucket level.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:PutTableBucketStorageClass</c> permission to use this
        /// operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTableBucketStorageClass service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTableBucketStorageClass service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketStorageClass">REST API Reference for PutTableBucketStorageClass Operation</seealso>
        Task<PutTableBucketStorageClassResponse> PutTableBucketStorageClassAsync(PutTableBucketStorageClassRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutTableMaintenanceConfiguration



        /// <summary>
        /// Creates a new maintenance configuration or replaces an existing maintenance configuration
        /// for a table. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-maintenance.html">S3
        /// Tables maintenance</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:PutTableMaintenanceConfiguration</c> permission to use
        /// this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTableMaintenanceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTableMaintenanceConfiguration service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableMaintenanceConfiguration">REST API Reference for PutTableMaintenanceConfiguration Operation</seealso>
        Task<PutTableMaintenanceConfigurationResponse> PutTableMaintenanceConfigurationAsync(PutTableMaintenanceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutTablePolicy



        /// <summary>
        /// Creates a new table policy or replaces an existing table policy for a table. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-table-policy.html#table-policy-add">Adding
        /// a table policy</a> in the <i>Amazon Simple Storage Service User Guide</i>. 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:PutTablePolicy</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTablePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTablePolicy service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTablePolicy">REST API Reference for PutTablePolicy Operation</seealso>
        Task<PutTablePolicyResponse> PutTablePolicyAsync(PutTablePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutTableRecordExpirationConfiguration



        /// <summary>
        /// Creates or updates the expiration configuration settings for records in a table, including
        /// the status of the configuration. If you enable record expiration for a table, records
        /// expire and are automatically removed from the table after the number of days that
        /// you specify.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:PutTableRecordExpirationConfiguration</c> permission
        /// to use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTableRecordExpirationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTableRecordExpirationConfiguration service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.MethodNotAllowedException">
        /// The requested operation is not allowed on this resource. This may occur when attempting
        /// to modify a resource that is managed by a service or has restrictions that prevent
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableRecordExpirationConfiguration">REST API Reference for PutTableRecordExpirationConfiguration Operation</seealso>
        Task<PutTableRecordExpirationConfigurationResponse> PutTableRecordExpirationConfigurationAsync(PutTableRecordExpirationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutTableReplication



        /// <summary>
        /// Creates or updates the replication configuration for a specific table. This operation
        /// allows you to define table-level replication independently of bucket-level replication,
        /// providing granular control over which tables are replicated and where.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> <ul> <li> 
        /// <para>
        /// You must have the <c>s3tables:PutTableReplication</c> permission to use this operation.
        /// The IAM role specified in the configuration must have permissions to read from the
        /// source table and write to all destination tables.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must also have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>s3tables:GetTable</c> permission on the source table being replicated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3tables:CreateTable</c> permission for the destination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3tables:CreateNamespace</c> permission for the destination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3tables:GetTableMaintenanceConfig</c> permission for the source table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3tables:PutTableMaintenanceConfig</c> permission for the destination table.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// You must have <c>iam:PassRole</c> permission with condition allowing roles to be passed
        /// to <c>replication.s3tables.amazonaws.com</c>.
        /// </para>
        ///  </li> </ul> </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTableReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTableReplication service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableReplication">REST API Reference for PutTableReplication Operation</seealso>
        Task<PutTableReplicationResponse> PutTableReplicationAsync(PutTableReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RenameTable



        /// <summary>
        /// Renames a table or a namespace. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-tables.html">S3
        /// Tables</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:RenameTable</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenameTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RenameTable service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/RenameTable">REST API Reference for RenameTable Operation</seealso>
        Task<RenameTableResponse> RenameTableAsync(RenameTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Applies one or more user-defined tags to an Amazon S3 Tables resource or updates existing
        /// tags. Each tag is a label consisting of a key and value pair. Tags can help you organize,
        /// track costs for, and control access to your resources. You can add up to 50 tags for
        /// each S3 resource. 
        /// 
        ///  <note> 
        /// <para>
        /// For a list of S3 resources that support tagging, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/tagging.html#manage-tags">Managing
        /// tags for Amazon S3 resources</a>.
        /// </para>
        ///  </note> <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// For tables and table buckets, you must have the <c>s3tables:TagResource</c> permission
        /// to use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes the specified user-defined tags from an Amazon S3 Tables resource. You can
        /// pass one or more tag keys. 
        /// 
        ///  <note> 
        /// <para>
        /// For a list of S3 resources that support tagging, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/tagging.html#manage-tags">Managing
        /// tags for Amazon S3 resources</a>.
        /// </para>
        ///  </note> <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// For tables and table buckets, you must have the <c>s3tables:UntagResource</c> permission
        /// to use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTableMetadataLocation



        /// <summary>
        /// Updates the metadata location for a table. The metadata location of a table must be
        /// an S3 URI that begins with the table's warehouse location. The metadata location for
        /// an Apache Iceberg table must end with <c>.metadata.json</c>, or if the metadata file
        /// is Gzip-compressed, <c>.metadata.json.gz</c>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:UpdateTableMetadataLocation</c> permission to use this
        /// operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTableMetadataLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTableMetadataLocation service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/UpdateTableMetadataLocation">REST API Reference for UpdateTableMetadataLocation Operation</seealso>
        Task<UpdateTableMetadataLocationResponse> UpdateTableMetadataLocationAsync(UpdateTableMetadataLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}