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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Glue.Model;

namespace Amazon.Glue
{
    /// <summary>
    /// Interface for accessing Glue
    ///
    /// AWS Glue 
    /// <para>
    /// Defines the public endpoint for the AWS Glue service.
    /// </para>
    /// </summary>
    public partial interface IAmazonGlue : IAmazonService, IDisposable
    {

        
        #region  BatchCreatePartition


        /// <summary>
        /// Creates one or more partitions in a batch operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreatePartition service method.</param>
        /// 
        /// <returns>The response from the BatchCreatePartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchCreatePartition">REST API Reference for BatchCreatePartition Operation</seealso>
        BatchCreatePartitionResponse BatchCreatePartition(BatchCreatePartitionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreatePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreatePartition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchCreatePartition">REST API Reference for BatchCreatePartition Operation</seealso>
        Task<BatchCreatePartitionResponse> BatchCreatePartitionAsync(BatchCreatePartitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDeleteConnection


        /// <summary>
        /// Deletes a list of connection definitions from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteConnection service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteConnection service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteConnection">REST API Reference for BatchDeleteConnection Operation</seealso>
        BatchDeleteConnectionResponse BatchDeleteConnection(BatchDeleteConnectionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteConnection">REST API Reference for BatchDeleteConnection Operation</seealso>
        Task<BatchDeleteConnectionResponse> BatchDeleteConnectionAsync(BatchDeleteConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDeletePartition


        /// <summary>
        /// Deletes one or more partitions in a batch operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePartition service method.</param>
        /// 
        /// <returns>The response from the BatchDeletePartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeletePartition">REST API Reference for BatchDeletePartition Operation</seealso>
        BatchDeletePartitionResponse BatchDeletePartition(BatchDeletePartitionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeletePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePartition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeletePartition">REST API Reference for BatchDeletePartition Operation</seealso>
        Task<BatchDeletePartitionResponse> BatchDeletePartitionAsync(BatchDeletePartitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDeleteTable


        /// <summary>
        /// Deletes multiple tables at once.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTable service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteTable">REST API Reference for BatchDeleteTable Operation</seealso>
        BatchDeleteTableResponse BatchDeleteTable(BatchDeleteTableRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteTable">REST API Reference for BatchDeleteTable Operation</seealso>
        Task<BatchDeleteTableResponse> BatchDeleteTableAsync(BatchDeleteTableRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDeleteTableVersion


        /// <summary>
        /// Deletes a specified batch of versions of a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTableVersion service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteTableVersion service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteTableVersion">REST API Reference for BatchDeleteTableVersion Operation</seealso>
        BatchDeleteTableVersionResponse BatchDeleteTableVersion(BatchDeleteTableVersionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteTableVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTableVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteTableVersion">REST API Reference for BatchDeleteTableVersion Operation</seealso>
        Task<BatchDeleteTableVersionResponse> BatchDeleteTableVersionAsync(BatchDeleteTableVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetPartition


        /// <summary>
        /// Retrieves partitions in a batch request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPartition service method.</param>
        /// 
        /// <returns>The response from the BatchGetPartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetPartition">REST API Reference for BatchGetPartition Operation</seealso>
        BatchGetPartitionResponse BatchGetPartition(BatchGetPartitionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetPartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPartition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetPartition">REST API Reference for BatchGetPartition Operation</seealso>
        Task<BatchGetPartitionResponse> BatchGetPartitionAsync(BatchGetPartitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchStopJobRun


        /// <summary>
        /// Stops one or more job runs for a specified job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchStopJobRun service method.</param>
        /// 
        /// <returns>The response from the BatchStopJobRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchStopJobRun">REST API Reference for BatchStopJobRun Operation</seealso>
        BatchStopJobRunResponse BatchStopJobRun(BatchStopJobRunRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the BatchStopJobRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchStopJobRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchStopJobRun">REST API Reference for BatchStopJobRun Operation</seealso>
        Task<BatchStopJobRunResponse> BatchStopJobRunAsync(BatchStopJobRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateClassifier


        /// <summary>
        /// Creates a classifier in the user's account. This may be a <code>GrokClassifier</code>,
        /// an <code>XMLClassifier</code>, or abbrev <code>JsonClassifier</code>, depending on
        /// which field of the request is present.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClassifier service method.</param>
        /// 
        /// <returns>The response from the CreateClassifier service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateClassifier">REST API Reference for CreateClassifier Operation</seealso>
        CreateClassifierResponse CreateClassifier(CreateClassifierRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClassifier operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateClassifier">REST API Reference for CreateClassifier Operation</seealso>
        Task<CreateClassifierResponse> CreateClassifierAsync(CreateClassifierRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateConnection


        /// <summary>
        /// Creates a connection definition in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        CreateConnectionResponse CreateConnection(CreateConnectionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCrawler


        /// <summary>
        /// Creates a new crawler with specified targets, role, configuration, and optional schedule.
        /// At least one crawl target must be specified, in either the <i>s3Targets</i> or the
        /// <i>jdbcTargets</i> field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCrawler service method.</param>
        /// 
        /// <returns>The response from the CreateCrawler service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateCrawler">REST API Reference for CreateCrawler Operation</seealso>
        CreateCrawlerResponse CreateCrawler(CreateCrawlerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCrawler operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateCrawler">REST API Reference for CreateCrawler Operation</seealso>
        Task<CreateCrawlerResponse> CreateCrawlerAsync(CreateCrawlerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDatabase


        /// <summary>
        /// Creates a new database in a Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatabase service method.</param>
        /// 
        /// <returns>The response from the CreateDatabase service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDatabase">REST API Reference for CreateDatabase Operation</seealso>
        CreateDatabaseResponse CreateDatabase(CreateDatabaseRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatabase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDatabase">REST API Reference for CreateDatabase Operation</seealso>
        Task<CreateDatabaseResponse> CreateDatabaseAsync(CreateDatabaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDevEndpoint


        /// <summary>
        /// Creates a new DevEndpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDevEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateDevEndpoint service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IdempotentParameterMismatchException">
        /// The same unique identifier was associated with two different records.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ValidationException">
        /// A value could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDevEndpoint">REST API Reference for CreateDevEndpoint Operation</seealso>
        CreateDevEndpointResponse CreateDevEndpoint(CreateDevEndpointRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDevEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDevEndpoint">REST API Reference for CreateDevEndpoint Operation</seealso>
        Task<CreateDevEndpointResponse> CreateDevEndpointAsync(CreateDevEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateJob


        /// <summary>
        /// Creates a new job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IdempotentParameterMismatchException">
        /// The same unique identifier was associated with two different records.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateJob">REST API Reference for CreateJob Operation</seealso>
        CreateJobResponse CreateJob(CreateJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateJob">REST API Reference for CreateJob Operation</seealso>
        Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePartition


        /// <summary>
        /// Creates a new partition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePartition service method.</param>
        /// 
        /// <returns>The response from the CreatePartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreatePartition">REST API Reference for CreatePartition Operation</seealso>
        CreatePartitionResponse CreatePartition(CreatePartitionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePartition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreatePartition">REST API Reference for CreatePartition Operation</seealso>
        Task<CreatePartitionResponse> CreatePartitionAsync(CreatePartitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateScript


        /// <summary>
        /// Transforms a directed acyclic graph (DAG) into code.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScript service method.</param>
        /// 
        /// <returns>The response from the CreateScript service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateScript">REST API Reference for CreateScript Operation</seealso>
        CreateScriptResponse CreateScript(CreateScriptRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateScript operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateScript operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateScript">REST API Reference for CreateScript Operation</seealso>
        Task<CreateScriptResponse> CreateScriptAsync(CreateScriptRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTable


        /// <summary>
        /// Creates a new table definition in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTable service method.</param>
        /// 
        /// <returns>The response from the CreateTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateTable">REST API Reference for CreateTable Operation</seealso>
        CreateTableResponse CreateTable(CreateTableRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateTable">REST API Reference for CreateTable Operation</seealso>
        Task<CreateTableResponse> CreateTableAsync(CreateTableRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTrigger


        /// <summary>
        /// Creates a new trigger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrigger service method.</param>
        /// 
        /// <returns>The response from the CreateTrigger service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IdempotentParameterMismatchException">
        /// The same unique identifier was associated with two different records.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateTrigger">REST API Reference for CreateTrigger Operation</seealso>
        CreateTriggerResponse CreateTrigger(CreateTriggerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrigger operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateTrigger">REST API Reference for CreateTrigger Operation</seealso>
        Task<CreateTriggerResponse> CreateTriggerAsync(CreateTriggerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateUserDefinedFunction


        /// <summary>
        /// Creates a new function definition in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserDefinedFunction service method.</param>
        /// 
        /// <returns>The response from the CreateUserDefinedFunction service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateUserDefinedFunction">REST API Reference for CreateUserDefinedFunction Operation</seealso>
        CreateUserDefinedFunctionResponse CreateUserDefinedFunction(CreateUserDefinedFunctionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserDefinedFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateUserDefinedFunction">REST API Reference for CreateUserDefinedFunction Operation</seealso>
        Task<CreateUserDefinedFunctionResponse> CreateUserDefinedFunctionAsync(CreateUserDefinedFunctionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteClassifier


        /// <summary>
        /// Removes a classifier from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClassifier service method.</param>
        /// 
        /// <returns>The response from the DeleteClassifier service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteClassifier">REST API Reference for DeleteClassifier Operation</seealso>
        DeleteClassifierResponse DeleteClassifier(DeleteClassifierRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClassifier operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteClassifier">REST API Reference for DeleteClassifier Operation</seealso>
        Task<DeleteClassifierResponse> DeleteClassifierAsync(DeleteClassifierRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteConnection


        /// <summary>
        /// Deletes a connection from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCrawler


        /// <summary>
        /// Removes a specified crawler from the Data Catalog, unless the crawler state is <code>RUNNING</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCrawler service method.</param>
        /// 
        /// <returns>The response from the DeleteCrawler service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.CrawlerRunningException">
        /// The operation cannot be performed because the crawler is already running.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.SchedulerTransitioningException">
        /// The specified scheduler is transitioning.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteCrawler">REST API Reference for DeleteCrawler Operation</seealso>
        DeleteCrawlerResponse DeleteCrawler(DeleteCrawlerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCrawler operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteCrawler">REST API Reference for DeleteCrawler Operation</seealso>
        Task<DeleteCrawlerResponse> DeleteCrawlerAsync(DeleteCrawlerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDatabase


        /// <summary>
        /// Removes a specified Database from a Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatabase service method.</param>
        /// 
        /// <returns>The response from the DeleteDatabase service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDatabase">REST API Reference for DeleteDatabase Operation</seealso>
        DeleteDatabaseResponse DeleteDatabase(DeleteDatabaseRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatabase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDatabase">REST API Reference for DeleteDatabase Operation</seealso>
        Task<DeleteDatabaseResponse> DeleteDatabaseAsync(DeleteDatabaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDevEndpoint


        /// <summary>
        /// Deletes a specified DevEndpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteDevEndpoint service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDevEndpoint">REST API Reference for DeleteDevEndpoint Operation</seealso>
        DeleteDevEndpointResponse DeleteDevEndpoint(DeleteDevEndpointRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDevEndpoint">REST API Reference for DeleteDevEndpoint Operation</seealso>
        Task<DeleteDevEndpointResponse> DeleteDevEndpointAsync(DeleteDevEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteJob


        /// <summary>
        /// Deletes a specified job definition. If the job definition is not found, no exception
        /// is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// 
        /// <returns>The response from the DeleteJob service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        DeleteJobResponse DeleteJob(DeleteJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePartition


        /// <summary>
        /// Deletes a specified partition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePartition service method.</param>
        /// 
        /// <returns>The response from the DeletePartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeletePartition">REST API Reference for DeletePartition Operation</seealso>
        DeletePartitionResponse DeletePartition(DeletePartitionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePartition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeletePartition">REST API Reference for DeletePartition Operation</seealso>
        Task<DeletePartitionResponse> DeletePartitionAsync(DeletePartitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTable


        /// <summary>
        /// Removes a table definition from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable service method.</param>
        /// 
        /// <returns>The response from the DeleteTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        DeleteTableResponse DeleteTable(DeleteTableRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        Task<DeleteTableResponse> DeleteTableAsync(DeleteTableRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTableVersion


        /// <summary>
        /// Deletes a specified version of a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteTableVersion service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTableVersion">REST API Reference for DeleteTableVersion Operation</seealso>
        DeleteTableVersionResponse DeleteTableVersion(DeleteTableVersionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTableVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTableVersion">REST API Reference for DeleteTableVersion Operation</seealso>
        Task<DeleteTableVersionResponse> DeleteTableVersionAsync(DeleteTableVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTrigger


        /// <summary>
        /// Deletes a specified trigger. If the trigger is not found, no exception is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrigger service method.</param>
        /// 
        /// <returns>The response from the DeleteTrigger service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTrigger">REST API Reference for DeleteTrigger Operation</seealso>
        DeleteTriggerResponse DeleteTrigger(DeleteTriggerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrigger operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTrigger">REST API Reference for DeleteTrigger Operation</seealso>
        Task<DeleteTriggerResponse> DeleteTriggerAsync(DeleteTriggerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUserDefinedFunction


        /// <summary>
        /// Deletes an existing function definition from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserDefinedFunction service method.</param>
        /// 
        /// <returns>The response from the DeleteUserDefinedFunction service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteUserDefinedFunction">REST API Reference for DeleteUserDefinedFunction Operation</seealso>
        DeleteUserDefinedFunctionResponse DeleteUserDefinedFunction(DeleteUserDefinedFunctionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserDefinedFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteUserDefinedFunction">REST API Reference for DeleteUserDefinedFunction Operation</seealso>
        Task<DeleteUserDefinedFunctionResponse> DeleteUserDefinedFunctionAsync(DeleteUserDefinedFunctionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCatalogImportStatus


        /// <summary>
        /// Retrieves the status of a migration operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCatalogImportStatus service method.</param>
        /// 
        /// <returns>The response from the GetCatalogImportStatus service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCatalogImportStatus">REST API Reference for GetCatalogImportStatus Operation</seealso>
        GetCatalogImportStatusResponse GetCatalogImportStatus(GetCatalogImportStatusRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetCatalogImportStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCatalogImportStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCatalogImportStatus">REST API Reference for GetCatalogImportStatus Operation</seealso>
        Task<GetCatalogImportStatusResponse> GetCatalogImportStatusAsync(GetCatalogImportStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetClassifier


        /// <summary>
        /// Retrieve a classifier by name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClassifier service method.</param>
        /// 
        /// <returns>The response from the GetClassifier service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetClassifier">REST API Reference for GetClassifier Operation</seealso>
        GetClassifierResponse GetClassifier(GetClassifierRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClassifier operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetClassifier">REST API Reference for GetClassifier Operation</seealso>
        Task<GetClassifierResponse> GetClassifierAsync(GetClassifierRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetClassifiers


        /// <summary>
        /// Lists all classifier objects in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClassifiers service method.</param>
        /// 
        /// <returns>The response from the GetClassifiers service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetClassifiers">REST API Reference for GetClassifiers Operation</seealso>
        GetClassifiersResponse GetClassifiers(GetClassifiersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetClassifiers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClassifiers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetClassifiers">REST API Reference for GetClassifiers Operation</seealso>
        Task<GetClassifiersResponse> GetClassifiersAsync(GetClassifiersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetConnection


        /// <summary>
        /// Retrieves a connection definition from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
        /// 
        /// <returns>The response from the GetConnection service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetConnection">REST API Reference for GetConnection Operation</seealso>
        GetConnectionResponse GetConnection(GetConnectionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetConnection">REST API Reference for GetConnection Operation</seealso>
        Task<GetConnectionResponse> GetConnectionAsync(GetConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetConnections


        /// <summary>
        /// Retrieves a list of connection definitions from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnections service method.</param>
        /// 
        /// <returns>The response from the GetConnections service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetConnections">REST API Reference for GetConnections Operation</seealso>
        GetConnectionsResponse GetConnections(GetConnectionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetConnections">REST API Reference for GetConnections Operation</seealso>
        Task<GetConnectionsResponse> GetConnectionsAsync(GetConnectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCrawler


        /// <summary>
        /// Retrieves metadata for a specified crawler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCrawler service method.</param>
        /// 
        /// <returns>The response from the GetCrawler service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawler">REST API Reference for GetCrawler Operation</seealso>
        GetCrawlerResponse GetCrawler(GetCrawlerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCrawler operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawler">REST API Reference for GetCrawler Operation</seealso>
        Task<GetCrawlerResponse> GetCrawlerAsync(GetCrawlerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCrawlerMetrics


        /// <summary>
        /// Retrieves metrics about specified crawlers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCrawlerMetrics service method.</param>
        /// 
        /// <returns>The response from the GetCrawlerMetrics service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawlerMetrics">REST API Reference for GetCrawlerMetrics Operation</seealso>
        GetCrawlerMetricsResponse GetCrawlerMetrics(GetCrawlerMetricsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetCrawlerMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCrawlerMetrics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawlerMetrics">REST API Reference for GetCrawlerMetrics Operation</seealso>
        Task<GetCrawlerMetricsResponse> GetCrawlerMetricsAsync(GetCrawlerMetricsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCrawlers


        /// <summary>
        /// Retrieves metadata for all crawlers defined in the customer account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCrawlers service method.</param>
        /// 
        /// <returns>The response from the GetCrawlers service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawlers">REST API Reference for GetCrawlers Operation</seealso>
        GetCrawlersResponse GetCrawlers(GetCrawlersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetCrawlers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCrawlers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawlers">REST API Reference for GetCrawlers Operation</seealso>
        Task<GetCrawlersResponse> GetCrawlersAsync(GetCrawlersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDatabase


        /// <summary>
        /// Retrieves the definition of a specified database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatabase service method.</param>
        /// 
        /// <returns>The response from the GetDatabase service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
        GetDatabaseResponse GetDatabase(GetDatabaseRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDatabase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
        Task<GetDatabaseResponse> GetDatabaseAsync(GetDatabaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDatabases


        /// <summary>
        /// Retrieves all Databases defined in a given Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatabases service method.</param>
        /// 
        /// <returns>The response from the GetDatabases service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDatabases">REST API Reference for GetDatabases Operation</seealso>
        GetDatabasesResponse GetDatabases(GetDatabasesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDatabases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDatabases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDatabases">REST API Reference for GetDatabases Operation</seealso>
        Task<GetDatabasesResponse> GetDatabasesAsync(GetDatabasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDataflowGraph


        /// <summary>
        /// Transforms a Python script into a directed acyclic graph (DAG).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataflowGraph service method.</param>
        /// 
        /// <returns>The response from the GetDataflowGraph service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataflowGraph">REST API Reference for GetDataflowGraph Operation</seealso>
        GetDataflowGraphResponse GetDataflowGraph(GetDataflowGraphRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDataflowGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataflowGraph operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataflowGraph">REST API Reference for GetDataflowGraph Operation</seealso>
        Task<GetDataflowGraphResponse> GetDataflowGraphAsync(GetDataflowGraphRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDevEndpoint


        /// <summary>
        /// Retrieves information about a specified DevEndpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetDevEndpoint service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDevEndpoint">REST API Reference for GetDevEndpoint Operation</seealso>
        GetDevEndpointResponse GetDevEndpoint(GetDevEndpointRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDevEndpoint">REST API Reference for GetDevEndpoint Operation</seealso>
        Task<GetDevEndpointResponse> GetDevEndpointAsync(GetDevEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDevEndpoints


        /// <summary>
        /// Retrieves all the DevEndpoints in this AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevEndpoints service method.</param>
        /// 
        /// <returns>The response from the GetDevEndpoints service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDevEndpoints">REST API Reference for GetDevEndpoints Operation</seealso>
        GetDevEndpointsResponse GetDevEndpoints(GetDevEndpointsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDevEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevEndpoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDevEndpoints">REST API Reference for GetDevEndpoints Operation</seealso>
        Task<GetDevEndpointsResponse> GetDevEndpointsAsync(GetDevEndpointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetJob


        /// <summary>
        /// Retrieves an existing job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJob">REST API Reference for GetJob Operation</seealso>
        GetJobResponse GetJob(GetJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJob">REST API Reference for GetJob Operation</seealso>
        Task<GetJobResponse> GetJobAsync(GetJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetJobRun


        /// <summary>
        /// Retrieves the metadata for a given job run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobRun service method.</param>
        /// 
        /// <returns>The response from the GetJobRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobRun">REST API Reference for GetJobRun Operation</seealso>
        GetJobRunResponse GetJobRun(GetJobRunRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetJobRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobRun">REST API Reference for GetJobRun Operation</seealso>
        Task<GetJobRunResponse> GetJobRunAsync(GetJobRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetJobRuns


        /// <summary>
        /// Retrieves metadata for all runs of a given job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobRuns service method.</param>
        /// 
        /// <returns>The response from the GetJobRuns service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobRuns">REST API Reference for GetJobRuns Operation</seealso>
        GetJobRunsResponse GetJobRuns(GetJobRunsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetJobRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobRuns operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobRuns">REST API Reference for GetJobRuns Operation</seealso>
        Task<GetJobRunsResponse> GetJobRunsAsync(GetJobRunsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetJobs


        /// <summary>
        /// Retrieves all current job definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobs service method.</param>
        /// 
        /// <returns>The response from the GetJobs service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobs">REST API Reference for GetJobs Operation</seealso>
        GetJobsResponse GetJobs(GetJobsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobs">REST API Reference for GetJobs Operation</seealso>
        Task<GetJobsResponse> GetJobsAsync(GetJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMapping


        /// <summary>
        /// Creates mappings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMapping service method.</param>
        /// 
        /// <returns>The response from the GetMapping service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMapping">REST API Reference for GetMapping Operation</seealso>
        GetMappingResponse GetMapping(GetMappingRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMapping">REST API Reference for GetMapping Operation</seealso>
        Task<GetMappingResponse> GetMappingAsync(GetMappingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPartition


        /// <summary>
        /// Retrieves information about a specified partition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartition service method.</param>
        /// 
        /// <returns>The response from the GetPartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartition">REST API Reference for GetPartition Operation</seealso>
        GetPartitionResponse GetPartition(GetPartitionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetPartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPartition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartition">REST API Reference for GetPartition Operation</seealso>
        Task<GetPartitionResponse> GetPartitionAsync(GetPartitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPartitions


        /// <summary>
        /// Retrieves information about the partitions in a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartitions service method.</param>
        /// 
        /// <returns>The response from the GetPartitions service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartitions">REST API Reference for GetPartitions Operation</seealso>
        GetPartitionsResponse GetPartitions(GetPartitionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetPartitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPartitions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartitions">REST API Reference for GetPartitions Operation</seealso>
        Task<GetPartitionsResponse> GetPartitionsAsync(GetPartitionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPlan


        /// <summary>
        /// Gets code to perform a specified mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlan service method.</param>
        /// 
        /// <returns>The response from the GetPlan service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPlan">REST API Reference for GetPlan Operation</seealso>
        GetPlanResponse GetPlan(GetPlanRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPlan">REST API Reference for GetPlan Operation</seealso>
        Task<GetPlanResponse> GetPlanAsync(GetPlanRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTable


        /// <summary>
        /// Retrieves the <code>Table</code> definition in a Data Catalog for a specified table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTable service method.</param>
        /// 
        /// <returns>The response from the GetTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTable">REST API Reference for GetTable Operation</seealso>
        GetTableResponse GetTable(GetTableRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTable">REST API Reference for GetTable Operation</seealso>
        Task<GetTableResponse> GetTableAsync(GetTableRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTables


        /// <summary>
        /// Retrieves the definitions of some or all of the tables in a given <code>Database</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTables service method.</param>
        /// 
        /// <returns>The response from the GetTables service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTables">REST API Reference for GetTables Operation</seealso>
        GetTablesResponse GetTables(GetTablesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTables operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTables">REST API Reference for GetTables Operation</seealso>
        Task<GetTablesResponse> GetTablesAsync(GetTablesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTableVersion


        /// <summary>
        /// Retrieves a specified version of a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableVersion service method.</param>
        /// 
        /// <returns>The response from the GetTableVersion service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTableVersion">REST API Reference for GetTableVersion Operation</seealso>
        GetTableVersionResponse GetTableVersion(GetTableVersionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetTableVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTableVersion">REST API Reference for GetTableVersion Operation</seealso>
        Task<GetTableVersionResponse> GetTableVersionAsync(GetTableVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTableVersions


        /// <summary>
        /// Retrieves a list of strings that identify available versions of a specified table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableVersions service method.</param>
        /// 
        /// <returns>The response from the GetTableVersions service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTableVersions">REST API Reference for GetTableVersions Operation</seealso>
        GetTableVersionsResponse GetTableVersions(GetTableVersionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetTableVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTableVersions">REST API Reference for GetTableVersions Operation</seealso>
        Task<GetTableVersionsResponse> GetTableVersionsAsync(GetTableVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTrigger


        /// <summary>
        /// Retrieves the definition of a trigger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrigger service method.</param>
        /// 
        /// <returns>The response from the GetTrigger service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTrigger">REST API Reference for GetTrigger Operation</seealso>
        GetTriggerResponse GetTrigger(GetTriggerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrigger operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTrigger">REST API Reference for GetTrigger Operation</seealso>
        Task<GetTriggerResponse> GetTriggerAsync(GetTriggerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTriggers


        /// <summary>
        /// Gets all the triggers associated with a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTriggers service method.</param>
        /// 
        /// <returns>The response from the GetTriggers service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTriggers">REST API Reference for GetTriggers Operation</seealso>
        GetTriggersResponse GetTriggers(GetTriggersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetTriggers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTriggers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTriggers">REST API Reference for GetTriggers Operation</seealso>
        Task<GetTriggersResponse> GetTriggersAsync(GetTriggersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetUserDefinedFunction


        /// <summary>
        /// Retrieves a specified function definition from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserDefinedFunction service method.</param>
        /// 
        /// <returns>The response from the GetUserDefinedFunction service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUserDefinedFunction">REST API Reference for GetUserDefinedFunction Operation</seealso>
        GetUserDefinedFunctionResponse GetUserDefinedFunction(GetUserDefinedFunctionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserDefinedFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUserDefinedFunction">REST API Reference for GetUserDefinedFunction Operation</seealso>
        Task<GetUserDefinedFunctionResponse> GetUserDefinedFunctionAsync(GetUserDefinedFunctionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetUserDefinedFunctions


        /// <summary>
        /// Retrieves a multiple function definitions from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserDefinedFunctions service method.</param>
        /// 
        /// <returns>The response from the GetUserDefinedFunctions service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUserDefinedFunctions">REST API Reference for GetUserDefinedFunctions Operation</seealso>
        GetUserDefinedFunctionsResponse GetUserDefinedFunctions(GetUserDefinedFunctionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetUserDefinedFunctions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserDefinedFunctions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUserDefinedFunctions">REST API Reference for GetUserDefinedFunctions Operation</seealso>
        Task<GetUserDefinedFunctionsResponse> GetUserDefinedFunctionsAsync(GetUserDefinedFunctionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ImportCatalogToGlue


        /// <summary>
        /// Imports an existing Athena Data Catalog to AWS Glue
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCatalogToGlue service method.</param>
        /// 
        /// <returns>The response from the ImportCatalogToGlue service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ImportCatalogToGlue">REST API Reference for ImportCatalogToGlue Operation</seealso>
        ImportCatalogToGlueResponse ImportCatalogToGlue(ImportCatalogToGlueRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ImportCatalogToGlue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportCatalogToGlue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ImportCatalogToGlue">REST API Reference for ImportCatalogToGlue Operation</seealso>
        Task<ImportCatalogToGlueResponse> ImportCatalogToGlueAsync(ImportCatalogToGlueRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResetJobBookmark


        /// <summary>
        /// Resets a bookmark entry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetJobBookmark service method.</param>
        /// 
        /// <returns>The response from the ResetJobBookmark service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ResetJobBookmark">REST API Reference for ResetJobBookmark Operation</seealso>
        ResetJobBookmarkResponse ResetJobBookmark(ResetJobBookmarkRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ResetJobBookmark operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetJobBookmark operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ResetJobBookmark">REST API Reference for ResetJobBookmark Operation</seealso>
        Task<ResetJobBookmarkResponse> ResetJobBookmarkAsync(ResetJobBookmarkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartCrawler


        /// <summary>
        /// Starts a crawl using the specified crawler, regardless of what is scheduled. If the
        /// crawler is already running, does nothing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCrawler service method.</param>
        /// 
        /// <returns>The response from the StartCrawler service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.CrawlerRunningException">
        /// The operation cannot be performed because the crawler is already running.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartCrawler">REST API Reference for StartCrawler Operation</seealso>
        StartCrawlerResponse StartCrawler(StartCrawlerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCrawler operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartCrawler">REST API Reference for StartCrawler Operation</seealso>
        Task<StartCrawlerResponse> StartCrawlerAsync(StartCrawlerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartCrawlerSchedule


        /// <summary>
        /// Changes the schedule state of the specified crawler to <code>SCHEDULED</code>, unless
        /// the crawler is already running or the schedule state is already <code>SCHEDULED</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCrawlerSchedule service method.</param>
        /// 
        /// <returns>The response from the StartCrawlerSchedule service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.NoScheduleException">
        /// There is no applicable schedule.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.SchedulerRunningException">
        /// The specified scheduler is already running.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.SchedulerTransitioningException">
        /// The specified scheduler is transitioning.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartCrawlerSchedule">REST API Reference for StartCrawlerSchedule Operation</seealso>
        StartCrawlerScheduleResponse StartCrawlerSchedule(StartCrawlerScheduleRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartCrawlerSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCrawlerSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartCrawlerSchedule">REST API Reference for StartCrawlerSchedule Operation</seealso>
        Task<StartCrawlerScheduleResponse> StartCrawlerScheduleAsync(StartCrawlerScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartJobRun


        /// <summary>
        /// Starts a job run using a job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartJobRun service method.</param>
        /// 
        /// <returns>The response from the StartJobRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentRunsExceededException">
        /// Too many jobs are being run concurrently.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartJobRun">REST API Reference for StartJobRun Operation</seealso>
        StartJobRunResponse StartJobRun(StartJobRunRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartJobRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartJobRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartJobRun">REST API Reference for StartJobRun Operation</seealso>
        Task<StartJobRunResponse> StartJobRunAsync(StartJobRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartTrigger


        /// <summary>
        /// Starts an existing trigger. See <a href="http://docs.aws.amazon.com/glue/latest/dg/trigger-job.html">Triggering
        /// Jobs</a> for information about how different types of trigger are started.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTrigger service method.</param>
        /// 
        /// <returns>The response from the StartTrigger service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentRunsExceededException">
        /// Too many jobs are being run concurrently.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartTrigger">REST API Reference for StartTrigger Operation</seealso>
        StartTriggerResponse StartTrigger(StartTriggerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTrigger operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartTrigger">REST API Reference for StartTrigger Operation</seealso>
        Task<StartTriggerResponse> StartTriggerAsync(StartTriggerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopCrawler


        /// <summary>
        /// If the specified crawler is running, stops the crawl.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCrawler service method.</param>
        /// 
        /// <returns>The response from the StopCrawler service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.CrawlerNotRunningException">
        /// The specified crawler is not running.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.CrawlerStoppingException">
        /// The specified crawler is stopping.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopCrawler">REST API Reference for StopCrawler Operation</seealso>
        StopCrawlerResponse StopCrawler(StopCrawlerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StopCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopCrawler operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopCrawler">REST API Reference for StopCrawler Operation</seealso>
        Task<StopCrawlerResponse> StopCrawlerAsync(StopCrawlerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopCrawlerSchedule


        /// <summary>
        /// Sets the schedule state of the specified crawler to <code>NOT_SCHEDULED</code>, but
        /// does not stop the crawler if it is already running.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCrawlerSchedule service method.</param>
        /// 
        /// <returns>The response from the StopCrawlerSchedule service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.SchedulerNotRunningException">
        /// The specified scheduler is not running.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.SchedulerTransitioningException">
        /// The specified scheduler is transitioning.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopCrawlerSchedule">REST API Reference for StopCrawlerSchedule Operation</seealso>
        StopCrawlerScheduleResponse StopCrawlerSchedule(StopCrawlerScheduleRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StopCrawlerSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopCrawlerSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopCrawlerSchedule">REST API Reference for StopCrawlerSchedule Operation</seealso>
        Task<StopCrawlerScheduleResponse> StopCrawlerScheduleAsync(StopCrawlerScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopTrigger


        /// <summary>
        /// Stops a specified trigger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTrigger service method.</param>
        /// 
        /// <returns>The response from the StopTrigger service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopTrigger">REST API Reference for StopTrigger Operation</seealso>
        StopTriggerResponse StopTrigger(StopTriggerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StopTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTrigger operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopTrigger">REST API Reference for StopTrigger Operation</seealso>
        Task<StopTriggerResponse> StopTriggerAsync(StopTriggerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateClassifier


        /// <summary>
        /// Modifies an existing classifier (a <code>GrokClassifier</code>, <code>XMLClassifier</code>,
        /// or <code>JsonClassifier</code>, depending on which field is present).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClassifier service method.</param>
        /// 
        /// <returns>The response from the UpdateClassifier service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.VersionMismatchException">
        /// There was a version conflict.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateClassifier">REST API Reference for UpdateClassifier Operation</seealso>
        UpdateClassifierResponse UpdateClassifier(UpdateClassifierRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateClassifier operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateClassifier">REST API Reference for UpdateClassifier Operation</seealso>
        Task<UpdateClassifierResponse> UpdateClassifierAsync(UpdateClassifierRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateConnection


        /// <summary>
        /// Updates a connection definition in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection service method.</param>
        /// 
        /// <returns>The response from the UpdateConnection service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        UpdateConnectionResponse UpdateConnection(UpdateConnectionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        Task<UpdateConnectionResponse> UpdateConnectionAsync(UpdateConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCrawler


        /// <summary>
        /// Updates a crawler. If a crawler is running, you must stop it using <code>StopCrawler</code>
        /// before updating it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrawler service method.</param>
        /// 
        /// <returns>The response from the UpdateCrawler service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.CrawlerRunningException">
        /// The operation cannot be performed because the crawler is already running.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.VersionMismatchException">
        /// There was a version conflict.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateCrawler">REST API Reference for UpdateCrawler Operation</seealso>
        UpdateCrawlerResponse UpdateCrawler(UpdateCrawlerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrawler operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateCrawler">REST API Reference for UpdateCrawler Operation</seealso>
        Task<UpdateCrawlerResponse> UpdateCrawlerAsync(UpdateCrawlerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCrawlerSchedule


        /// <summary>
        /// Updates the schedule of a crawler using a <code>cron</code> expression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrawlerSchedule service method.</param>
        /// 
        /// <returns>The response from the UpdateCrawlerSchedule service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.SchedulerTransitioningException">
        /// The specified scheduler is transitioning.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.VersionMismatchException">
        /// There was a version conflict.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateCrawlerSchedule">REST API Reference for UpdateCrawlerSchedule Operation</seealso>
        UpdateCrawlerScheduleResponse UpdateCrawlerSchedule(UpdateCrawlerScheduleRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCrawlerSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrawlerSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateCrawlerSchedule">REST API Reference for UpdateCrawlerSchedule Operation</seealso>
        Task<UpdateCrawlerScheduleResponse> UpdateCrawlerScheduleAsync(UpdateCrawlerScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDatabase


        /// <summary>
        /// Updates an existing database definition in a Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatabase service method.</param>
        /// 
        /// <returns>The response from the UpdateDatabase service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDatabase">REST API Reference for UpdateDatabase Operation</seealso>
        UpdateDatabaseResponse UpdateDatabase(UpdateDatabaseRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatabase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDatabase">REST API Reference for UpdateDatabase Operation</seealso>
        Task<UpdateDatabaseResponse> UpdateDatabaseAsync(UpdateDatabaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDevEndpoint


        /// <summary>
        /// Updates a specified DevEndpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateDevEndpoint service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ValidationException">
        /// A value could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDevEndpoint">REST API Reference for UpdateDevEndpoint Operation</seealso>
        UpdateDevEndpointResponse UpdateDevEndpoint(UpdateDevEndpointRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDevEndpoint">REST API Reference for UpdateDevEndpoint Operation</seealso>
        Task<UpdateDevEndpointResponse> UpdateDevEndpointAsync(UpdateDevEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateJob


        /// <summary>
        /// Updates an existing job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob service method.</param>
        /// 
        /// <returns>The response from the UpdateJob service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        UpdateJobResponse UpdateJob(UpdateJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePartition


        /// <summary>
        /// Updates a partition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartition service method.</param>
        /// 
        /// <returns>The response from the UpdatePartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdatePartition">REST API Reference for UpdatePartition Operation</seealso>
        UpdatePartitionResponse UpdatePartition(UpdatePartitionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdatePartition">REST API Reference for UpdatePartition Operation</seealso>
        Task<UpdatePartitionResponse> UpdatePartitionAsync(UpdatePartitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTable


        /// <summary>
        /// Updates a metadata table in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTable service method.</param>
        /// 
        /// <returns>The response from the UpdateTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        UpdateTableResponse UpdateTable(UpdateTableRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        Task<UpdateTableResponse> UpdateTableAsync(UpdateTableRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTrigger


        /// <summary>
        /// Updates a trigger definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrigger service method.</param>
        /// 
        /// <returns>The response from the UpdateTrigger service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateTrigger">REST API Reference for UpdateTrigger Operation</seealso>
        UpdateTriggerResponse UpdateTrigger(UpdateTriggerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrigger operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateTrigger">REST API Reference for UpdateTrigger Operation</seealso>
        Task<UpdateTriggerResponse> UpdateTriggerAsync(UpdateTriggerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUserDefinedFunction


        /// <summary>
        /// Updates an existing function definition in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserDefinedFunction service method.</param>
        /// 
        /// <returns>The response from the UpdateUserDefinedFunction service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateUserDefinedFunction">REST API Reference for UpdateUserDefinedFunction Operation</seealso>
        UpdateUserDefinedFunctionResponse UpdateUserDefinedFunction(UpdateUserDefinedFunctionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserDefinedFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateUserDefinedFunction">REST API Reference for UpdateUserDefinedFunction Operation</seealso>
        Task<UpdateUserDefinedFunctionResponse> UpdateUserDefinedFunctionAsync(UpdateUserDefinedFunctionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}