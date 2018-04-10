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
using System.Collections.Generic;

using Amazon.Glue.Model;
using Amazon.Glue.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Glue
{
    /// <summary>
    /// Implementation for accessing Glue
    ///
    /// AWS Glue 
    /// <para>
    /// Defines the public endpoint for the AWS Glue service.
    /// </para>
    /// </summary>
    public partial class AmazonGlueClient : AmazonServiceClient, IAmazonGlue
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonGlueClient with the credentials loaded from the application's
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
        public AmazonGlueClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGlueConfig()) { }

        /// <summary>
        /// Constructs AmazonGlueClient with the credentials loaded from the application's
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
        public AmazonGlueClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGlueConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonGlueClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonGlueClient Configuration Object</param>
        public AmazonGlueClient(AmazonGlueConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonGlueClient(AWSCredentials credentials)
            : this(credentials, new AmazonGlueConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlueClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonGlueConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Credentials and an
        /// AmazonGlueClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonGlueClient Configuration Object</param>
        public AmazonGlueClient(AWSCredentials credentials, AmazonGlueConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonGlueClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGlueConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlueClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGlueConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGlueClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonGlueClient Configuration Object</param>
        public AmazonGlueClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonGlueConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonGlueClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGlueConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlueClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGlueConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGlueClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonGlueClient Configuration Object</param>
        public AmazonGlueClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonGlueConfig clientConfig)
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
        public virtual BatchCreatePartitionResponse BatchCreatePartition(BatchCreatePartitionRequest request)
        {
            var marshaller = BatchCreatePartitionRequestMarshaller.Instance;
            var unmarshaller = BatchCreatePartitionResponseUnmarshaller.Instance;

            return Invoke<BatchCreatePartitionRequest,BatchCreatePartitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreatePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreatePartition operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreatePartition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchCreatePartition">REST API Reference for BatchCreatePartition Operation</seealso>
        public virtual IAsyncResult BeginBatchCreatePartition(BatchCreatePartitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = BatchCreatePartitionRequestMarshaller.Instance;
            var unmarshaller = BatchCreatePartitionResponseUnmarshaller.Instance;

            return BeginInvoke<BatchCreatePartitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreatePartition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreatePartition.</param>
        /// 
        /// <returns>Returns a  BatchCreatePartitionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchCreatePartition">REST API Reference for BatchCreatePartition Operation</seealso>
        public virtual BatchCreatePartitionResponse EndBatchCreatePartition(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchCreatePartitionResponse>(asyncResult);
        }

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
        public virtual BatchDeleteConnectionResponse BatchDeleteConnection(BatchDeleteConnectionRequest request)
        {
            var marshaller = BatchDeleteConnectionRequestMarshaller.Instance;
            var unmarshaller = BatchDeleteConnectionResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteConnectionRequest,BatchDeleteConnectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteConnection operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteConnection">REST API Reference for BatchDeleteConnection Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteConnection(BatchDeleteConnectionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = BatchDeleteConnectionRequestMarshaller.Instance;
            var unmarshaller = BatchDeleteConnectionResponseUnmarshaller.Instance;

            return BeginInvoke<BatchDeleteConnectionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteConnection.</param>
        /// 
        /// <returns>Returns a  BatchDeleteConnectionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteConnection">REST API Reference for BatchDeleteConnection Operation</seealso>
        public virtual BatchDeleteConnectionResponse EndBatchDeleteConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteConnectionResponse>(asyncResult);
        }

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
        public virtual BatchDeletePartitionResponse BatchDeletePartition(BatchDeletePartitionRequest request)
        {
            var marshaller = BatchDeletePartitionRequestMarshaller.Instance;
            var unmarshaller = BatchDeletePartitionResponseUnmarshaller.Instance;

            return Invoke<BatchDeletePartitionRequest,BatchDeletePartitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeletePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePartition operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeletePartition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeletePartition">REST API Reference for BatchDeletePartition Operation</seealso>
        public virtual IAsyncResult BeginBatchDeletePartition(BatchDeletePartitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = BatchDeletePartitionRequestMarshaller.Instance;
            var unmarshaller = BatchDeletePartitionResponseUnmarshaller.Instance;

            return BeginInvoke<BatchDeletePartitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeletePartition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeletePartition.</param>
        /// 
        /// <returns>Returns a  BatchDeletePartitionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeletePartition">REST API Reference for BatchDeletePartition Operation</seealso>
        public virtual BatchDeletePartitionResponse EndBatchDeletePartition(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeletePartitionResponse>(asyncResult);
        }

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
        public virtual BatchDeleteTableResponse BatchDeleteTable(BatchDeleteTableRequest request)
        {
            var marshaller = BatchDeleteTableRequestMarshaller.Instance;
            var unmarshaller = BatchDeleteTableResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteTableRequest,BatchDeleteTableResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTable operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteTable">REST API Reference for BatchDeleteTable Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteTable(BatchDeleteTableRequest request, AsyncCallback callback, object state)
        {
            var marshaller = BatchDeleteTableRequestMarshaller.Instance;
            var unmarshaller = BatchDeleteTableResponseUnmarshaller.Instance;

            return BeginInvoke<BatchDeleteTableRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteTable.</param>
        /// 
        /// <returns>Returns a  BatchDeleteTableResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteTable">REST API Reference for BatchDeleteTable Operation</seealso>
        public virtual BatchDeleteTableResponse EndBatchDeleteTable(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteTableResponse>(asyncResult);
        }

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
        public virtual BatchDeleteTableVersionResponse BatchDeleteTableVersion(BatchDeleteTableVersionRequest request)
        {
            var marshaller = BatchDeleteTableVersionRequestMarshaller.Instance;
            var unmarshaller = BatchDeleteTableVersionResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteTableVersionRequest,BatchDeleteTableVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteTableVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTableVersion operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteTableVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteTableVersion">REST API Reference for BatchDeleteTableVersion Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteTableVersion(BatchDeleteTableVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = BatchDeleteTableVersionRequestMarshaller.Instance;
            var unmarshaller = BatchDeleteTableVersionResponseUnmarshaller.Instance;

            return BeginInvoke<BatchDeleteTableVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteTableVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteTableVersion.</param>
        /// 
        /// <returns>Returns a  BatchDeleteTableVersionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteTableVersion">REST API Reference for BatchDeleteTableVersion Operation</seealso>
        public virtual BatchDeleteTableVersionResponse EndBatchDeleteTableVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteTableVersionResponse>(asyncResult);
        }

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
        public virtual BatchGetPartitionResponse BatchGetPartition(BatchGetPartitionRequest request)
        {
            var marshaller = BatchGetPartitionRequestMarshaller.Instance;
            var unmarshaller = BatchGetPartitionResponseUnmarshaller.Instance;

            return Invoke<BatchGetPartitionRequest,BatchGetPartitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetPartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPartition operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetPartition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetPartition">REST API Reference for BatchGetPartition Operation</seealso>
        public virtual IAsyncResult BeginBatchGetPartition(BatchGetPartitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = BatchGetPartitionRequestMarshaller.Instance;
            var unmarshaller = BatchGetPartitionResponseUnmarshaller.Instance;

            return BeginInvoke<BatchGetPartitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetPartition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetPartition.</param>
        /// 
        /// <returns>Returns a  BatchGetPartitionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetPartition">REST API Reference for BatchGetPartition Operation</seealso>
        public virtual BatchGetPartitionResponse EndBatchGetPartition(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetPartitionResponse>(asyncResult);
        }

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
        public virtual BatchStopJobRunResponse BatchStopJobRun(BatchStopJobRunRequest request)
        {
            var marshaller = BatchStopJobRunRequestMarshaller.Instance;
            var unmarshaller = BatchStopJobRunResponseUnmarshaller.Instance;

            return Invoke<BatchStopJobRunRequest,BatchStopJobRunResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchStopJobRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchStopJobRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchStopJobRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchStopJobRun">REST API Reference for BatchStopJobRun Operation</seealso>
        public virtual IAsyncResult BeginBatchStopJobRun(BatchStopJobRunRequest request, AsyncCallback callback, object state)
        {
            var marshaller = BatchStopJobRunRequestMarshaller.Instance;
            var unmarshaller = BatchStopJobRunResponseUnmarshaller.Instance;

            return BeginInvoke<BatchStopJobRunRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchStopJobRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchStopJobRun.</param>
        /// 
        /// <returns>Returns a  BatchStopJobRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchStopJobRun">REST API Reference for BatchStopJobRun Operation</seealso>
        public virtual BatchStopJobRunResponse EndBatchStopJobRun(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchStopJobRunResponse>(asyncResult);
        }

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
        public virtual CreateClassifierResponse CreateClassifier(CreateClassifierRequest request)
        {
            var marshaller = CreateClassifierRequestMarshaller.Instance;
            var unmarshaller = CreateClassifierResponseUnmarshaller.Instance;

            return Invoke<CreateClassifierRequest,CreateClassifierResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClassifier operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateClassifier
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateClassifier">REST API Reference for CreateClassifier Operation</seealso>
        public virtual IAsyncResult BeginCreateClassifier(CreateClassifierRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateClassifierRequestMarshaller.Instance;
            var unmarshaller = CreateClassifierResponseUnmarshaller.Instance;

            return BeginInvoke<CreateClassifierRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateClassifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClassifier.</param>
        /// 
        /// <returns>Returns a  CreateClassifierResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateClassifier">REST API Reference for CreateClassifier Operation</seealso>
        public virtual CreateClassifierResponse EndCreateClassifier(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateClassifierResponse>(asyncResult);
        }

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
        public virtual CreateConnectionResponse CreateConnection(CreateConnectionRequest request)
        {
            var marshaller = CreateConnectionRequestMarshaller.Instance;
            var unmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateConnectionRequest,CreateConnectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        public virtual IAsyncResult BeginCreateConnection(CreateConnectionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateConnectionRequestMarshaller.Instance;
            var unmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateConnectionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnection.</param>
        /// 
        /// <returns>Returns a  CreateConnectionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        public virtual CreateConnectionResponse EndCreateConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConnectionResponse>(asyncResult);
        }

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
        public virtual CreateCrawlerResponse CreateCrawler(CreateCrawlerRequest request)
        {
            var marshaller = CreateCrawlerRequestMarshaller.Instance;
            var unmarshaller = CreateCrawlerResponseUnmarshaller.Instance;

            return Invoke<CreateCrawlerRequest,CreateCrawlerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCrawler operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCrawler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateCrawler">REST API Reference for CreateCrawler Operation</seealso>
        public virtual IAsyncResult BeginCreateCrawler(CreateCrawlerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateCrawlerRequestMarshaller.Instance;
            var unmarshaller = CreateCrawlerResponseUnmarshaller.Instance;

            return BeginInvoke<CreateCrawlerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCrawler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCrawler.</param>
        /// 
        /// <returns>Returns a  CreateCrawlerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateCrawler">REST API Reference for CreateCrawler Operation</seealso>
        public virtual CreateCrawlerResponse EndCreateCrawler(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCrawlerResponse>(asyncResult);
        }

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
        public virtual CreateDatabaseResponse CreateDatabase(CreateDatabaseRequest request)
        {
            var marshaller = CreateDatabaseRequestMarshaller.Instance;
            var unmarshaller = CreateDatabaseResponseUnmarshaller.Instance;

            return Invoke<CreateDatabaseRequest,CreateDatabaseResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatabase operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDatabase">REST API Reference for CreateDatabase Operation</seealso>
        public virtual IAsyncResult BeginCreateDatabase(CreateDatabaseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDatabaseRequestMarshaller.Instance;
            var unmarshaller = CreateDatabaseResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDatabaseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatabase.</param>
        /// 
        /// <returns>Returns a  CreateDatabaseResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDatabase">REST API Reference for CreateDatabase Operation</seealso>
        public virtual CreateDatabaseResponse EndCreateDatabase(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDatabaseResponse>(asyncResult);
        }

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
        public virtual CreateDevEndpointResponse CreateDevEndpoint(CreateDevEndpointRequest request)
        {
            var marshaller = CreateDevEndpointRequestMarshaller.Instance;
            var unmarshaller = CreateDevEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateDevEndpointRequest,CreateDevEndpointResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDevEndpoint operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDevEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDevEndpoint">REST API Reference for CreateDevEndpoint Operation</seealso>
        public virtual IAsyncResult BeginCreateDevEndpoint(CreateDevEndpointRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDevEndpointRequestMarshaller.Instance;
            var unmarshaller = CreateDevEndpointResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDevEndpointRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDevEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateDevEndpointResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDevEndpoint">REST API Reference for CreateDevEndpoint Operation</seealso>
        public virtual CreateDevEndpointResponse EndCreateDevEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDevEndpointResponse>(asyncResult);
        }

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
        public virtual CreateJobResponse CreateJob(CreateJobRequest request)
        {
            var marshaller = CreateJobRequestMarshaller.Instance;
            var unmarshaller = CreateJobResponseUnmarshaller.Instance;

            return Invoke<CreateJobRequest,CreateJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual IAsyncResult BeginCreateJob(CreateJobRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateJobRequestMarshaller.Instance;
            var unmarshaller = CreateJobResponseUnmarshaller.Instance;

            return BeginInvoke<CreateJobRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJob.</param>
        /// 
        /// <returns>Returns a  CreateJobResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual CreateJobResponse EndCreateJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateJobResponse>(asyncResult);
        }

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
        public virtual CreatePartitionResponse CreatePartition(CreatePartitionRequest request)
        {
            var marshaller = CreatePartitionRequestMarshaller.Instance;
            var unmarshaller = CreatePartitionResponseUnmarshaller.Instance;

            return Invoke<CreatePartitionRequest,CreatePartitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePartition operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePartition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreatePartition">REST API Reference for CreatePartition Operation</seealso>
        public virtual IAsyncResult BeginCreatePartition(CreatePartitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreatePartitionRequestMarshaller.Instance;
            var unmarshaller = CreatePartitionResponseUnmarshaller.Instance;

            return BeginInvoke<CreatePartitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePartition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePartition.</param>
        /// 
        /// <returns>Returns a  CreatePartitionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreatePartition">REST API Reference for CreatePartition Operation</seealso>
        public virtual CreatePartitionResponse EndCreatePartition(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePartitionResponse>(asyncResult);
        }

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
        public virtual CreateScriptResponse CreateScript(CreateScriptRequest request)
        {
            var marshaller = CreateScriptRequestMarshaller.Instance;
            var unmarshaller = CreateScriptResponseUnmarshaller.Instance;

            return Invoke<CreateScriptRequest,CreateScriptResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateScript operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateScript operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateScript
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateScript">REST API Reference for CreateScript Operation</seealso>
        public virtual IAsyncResult BeginCreateScript(CreateScriptRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateScriptRequestMarshaller.Instance;
            var unmarshaller = CreateScriptResponseUnmarshaller.Instance;

            return BeginInvoke<CreateScriptRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateScript operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateScript.</param>
        /// 
        /// <returns>Returns a  CreateScriptResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateScript">REST API Reference for CreateScript Operation</seealso>
        public virtual CreateScriptResponse EndCreateScript(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateScriptResponse>(asyncResult);
        }

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
        public virtual CreateTableResponse CreateTable(CreateTableRequest request)
        {
            var marshaller = CreateTableRequestMarshaller.Instance;
            var unmarshaller = CreateTableResponseUnmarshaller.Instance;

            return Invoke<CreateTableRequest,CreateTableResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTable operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateTable">REST API Reference for CreateTable Operation</seealso>
        public virtual IAsyncResult BeginCreateTable(CreateTableRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateTableRequestMarshaller.Instance;
            var unmarshaller = CreateTableResponseUnmarshaller.Instance;

            return BeginInvoke<CreateTableRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTable.</param>
        /// 
        /// <returns>Returns a  CreateTableResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateTable">REST API Reference for CreateTable Operation</seealso>
        public virtual CreateTableResponse EndCreateTable(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTableResponse>(asyncResult);
        }

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
        public virtual CreateTriggerResponse CreateTrigger(CreateTriggerRequest request)
        {
            var marshaller = CreateTriggerRequestMarshaller.Instance;
            var unmarshaller = CreateTriggerResponseUnmarshaller.Instance;

            return Invoke<CreateTriggerRequest,CreateTriggerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrigger operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrigger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateTrigger">REST API Reference for CreateTrigger Operation</seealso>
        public virtual IAsyncResult BeginCreateTrigger(CreateTriggerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateTriggerRequestMarshaller.Instance;
            var unmarshaller = CreateTriggerResponseUnmarshaller.Instance;

            return BeginInvoke<CreateTriggerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrigger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrigger.</param>
        /// 
        /// <returns>Returns a  CreateTriggerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateTrigger">REST API Reference for CreateTrigger Operation</seealso>
        public virtual CreateTriggerResponse EndCreateTrigger(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTriggerResponse>(asyncResult);
        }

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
        public virtual CreateUserDefinedFunctionResponse CreateUserDefinedFunction(CreateUserDefinedFunctionRequest request)
        {
            var marshaller = CreateUserDefinedFunctionRequestMarshaller.Instance;
            var unmarshaller = CreateUserDefinedFunctionResponseUnmarshaller.Instance;

            return Invoke<CreateUserDefinedFunctionRequest,CreateUserDefinedFunctionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserDefinedFunction operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUserDefinedFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateUserDefinedFunction">REST API Reference for CreateUserDefinedFunction Operation</seealso>
        public virtual IAsyncResult BeginCreateUserDefinedFunction(CreateUserDefinedFunctionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateUserDefinedFunctionRequestMarshaller.Instance;
            var unmarshaller = CreateUserDefinedFunctionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateUserDefinedFunctionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserDefinedFunction.</param>
        /// 
        /// <returns>Returns a  CreateUserDefinedFunctionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateUserDefinedFunction">REST API Reference for CreateUserDefinedFunction Operation</seealso>
        public virtual CreateUserDefinedFunctionResponse EndCreateUserDefinedFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserDefinedFunctionResponse>(asyncResult);
        }

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
        public virtual DeleteClassifierResponse DeleteClassifier(DeleteClassifierRequest request)
        {
            var marshaller = DeleteClassifierRequestMarshaller.Instance;
            var unmarshaller = DeleteClassifierResponseUnmarshaller.Instance;

            return Invoke<DeleteClassifierRequest,DeleteClassifierResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClassifier operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteClassifier
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteClassifier">REST API Reference for DeleteClassifier Operation</seealso>
        public virtual IAsyncResult BeginDeleteClassifier(DeleteClassifierRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteClassifierRequestMarshaller.Instance;
            var unmarshaller = DeleteClassifierResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteClassifierRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClassifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClassifier.</param>
        /// 
        /// <returns>Returns a  DeleteClassifierResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteClassifier">REST API Reference for DeleteClassifier Operation</seealso>
        public virtual DeleteClassifierResponse EndDeleteClassifier(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteClassifierResponse>(asyncResult);
        }

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
        public virtual DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request)
        {
            var marshaller = DeleteConnectionRequestMarshaller.Instance;
            var unmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectionRequest,DeleteConnectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual IAsyncResult BeginDeleteConnection(DeleteConnectionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteConnectionRequestMarshaller.Instance;
            var unmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteConnectionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnection.</param>
        /// 
        /// <returns>Returns a  DeleteConnectionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual DeleteConnectionResponse EndDeleteConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConnectionResponse>(asyncResult);
        }

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
        public virtual DeleteCrawlerResponse DeleteCrawler(DeleteCrawlerRequest request)
        {
            var marshaller = DeleteCrawlerRequestMarshaller.Instance;
            var unmarshaller = DeleteCrawlerResponseUnmarshaller.Instance;

            return Invoke<DeleteCrawlerRequest,DeleteCrawlerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCrawler operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCrawler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteCrawler">REST API Reference for DeleteCrawler Operation</seealso>
        public virtual IAsyncResult BeginDeleteCrawler(DeleteCrawlerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteCrawlerRequestMarshaller.Instance;
            var unmarshaller = DeleteCrawlerResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteCrawlerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCrawler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCrawler.</param>
        /// 
        /// <returns>Returns a  DeleteCrawlerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteCrawler">REST API Reference for DeleteCrawler Operation</seealso>
        public virtual DeleteCrawlerResponse EndDeleteCrawler(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCrawlerResponse>(asyncResult);
        }

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
        public virtual DeleteDatabaseResponse DeleteDatabase(DeleteDatabaseRequest request)
        {
            var marshaller = DeleteDatabaseRequestMarshaller.Instance;
            var unmarshaller = DeleteDatabaseResponseUnmarshaller.Instance;

            return Invoke<DeleteDatabaseRequest,DeleteDatabaseResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatabase operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDatabase">REST API Reference for DeleteDatabase Operation</seealso>
        public virtual IAsyncResult BeginDeleteDatabase(DeleteDatabaseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteDatabaseRequestMarshaller.Instance;
            var unmarshaller = DeleteDatabaseResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDatabaseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDatabase.</param>
        /// 
        /// <returns>Returns a  DeleteDatabaseResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDatabase">REST API Reference for DeleteDatabase Operation</seealso>
        public virtual DeleteDatabaseResponse EndDeleteDatabase(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDatabaseResponse>(asyncResult);
        }

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
        public virtual DeleteDevEndpointResponse DeleteDevEndpoint(DeleteDevEndpointRequest request)
        {
            var marshaller = DeleteDevEndpointRequestMarshaller.Instance;
            var unmarshaller = DeleteDevEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteDevEndpointRequest,DeleteDevEndpointResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevEndpoint operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDevEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDevEndpoint">REST API Reference for DeleteDevEndpoint Operation</seealso>
        public virtual IAsyncResult BeginDeleteDevEndpoint(DeleteDevEndpointRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteDevEndpointRequestMarshaller.Instance;
            var unmarshaller = DeleteDevEndpointResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDevEndpointRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDevEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteDevEndpointResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDevEndpoint">REST API Reference for DeleteDevEndpoint Operation</seealso>
        public virtual DeleteDevEndpointResponse EndDeleteDevEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDevEndpointResponse>(asyncResult);
        }

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
        public virtual DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            var marshaller = DeleteJobRequestMarshaller.Instance;
            var unmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return Invoke<DeleteJobRequest,DeleteJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual IAsyncResult BeginDeleteJob(DeleteJobRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteJobRequestMarshaller.Instance;
            var unmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteJobRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteJob.</param>
        /// 
        /// <returns>Returns a  DeleteJobResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual DeleteJobResponse EndDeleteJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteJobResponse>(asyncResult);
        }

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
        public virtual DeletePartitionResponse DeletePartition(DeletePartitionRequest request)
        {
            var marshaller = DeletePartitionRequestMarshaller.Instance;
            var unmarshaller = DeletePartitionResponseUnmarshaller.Instance;

            return Invoke<DeletePartitionRequest,DeletePartitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePartition operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePartition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeletePartition">REST API Reference for DeletePartition Operation</seealso>
        public virtual IAsyncResult BeginDeletePartition(DeletePartitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeletePartitionRequestMarshaller.Instance;
            var unmarshaller = DeletePartitionResponseUnmarshaller.Instance;

            return BeginInvoke<DeletePartitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePartition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePartition.</param>
        /// 
        /// <returns>Returns a  DeletePartitionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeletePartition">REST API Reference for DeletePartition Operation</seealso>
        public virtual DeletePartitionResponse EndDeletePartition(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePartitionResponse>(asyncResult);
        }

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
        public virtual DeleteTableResponse DeleteTable(DeleteTableRequest request)
        {
            var marshaller = DeleteTableRequestMarshaller.Instance;
            var unmarshaller = DeleteTableResponseUnmarshaller.Instance;

            return Invoke<DeleteTableRequest,DeleteTableResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        public virtual IAsyncResult BeginDeleteTable(DeleteTableRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteTableRequestMarshaller.Instance;
            var unmarshaller = DeleteTableResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteTableRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTable.</param>
        /// 
        /// <returns>Returns a  DeleteTableResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        public virtual DeleteTableResponse EndDeleteTable(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTableResponse>(asyncResult);
        }

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
        public virtual DeleteTableVersionResponse DeleteTableVersion(DeleteTableVersionRequest request)
        {
            var marshaller = DeleteTableVersionRequestMarshaller.Instance;
            var unmarshaller = DeleteTableVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteTableVersionRequest,DeleteTableVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTableVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableVersion operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTableVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTableVersion">REST API Reference for DeleteTableVersion Operation</seealso>
        public virtual IAsyncResult BeginDeleteTableVersion(DeleteTableVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteTableVersionRequestMarshaller.Instance;
            var unmarshaller = DeleteTableVersionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteTableVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTableVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTableVersion.</param>
        /// 
        /// <returns>Returns a  DeleteTableVersionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTableVersion">REST API Reference for DeleteTableVersion Operation</seealso>
        public virtual DeleteTableVersionResponse EndDeleteTableVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTableVersionResponse>(asyncResult);
        }

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
        public virtual DeleteTriggerResponse DeleteTrigger(DeleteTriggerRequest request)
        {
            var marshaller = DeleteTriggerRequestMarshaller.Instance;
            var unmarshaller = DeleteTriggerResponseUnmarshaller.Instance;

            return Invoke<DeleteTriggerRequest,DeleteTriggerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrigger operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrigger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTrigger">REST API Reference for DeleteTrigger Operation</seealso>
        public virtual IAsyncResult BeginDeleteTrigger(DeleteTriggerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteTriggerRequestMarshaller.Instance;
            var unmarshaller = DeleteTriggerResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteTriggerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrigger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrigger.</param>
        /// 
        /// <returns>Returns a  DeleteTriggerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTrigger">REST API Reference for DeleteTrigger Operation</seealso>
        public virtual DeleteTriggerResponse EndDeleteTrigger(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTriggerResponse>(asyncResult);
        }

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
        public virtual DeleteUserDefinedFunctionResponse DeleteUserDefinedFunction(DeleteUserDefinedFunctionRequest request)
        {
            var marshaller = DeleteUserDefinedFunctionRequestMarshaller.Instance;
            var unmarshaller = DeleteUserDefinedFunctionResponseUnmarshaller.Instance;

            return Invoke<DeleteUserDefinedFunctionRequest,DeleteUserDefinedFunctionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserDefinedFunction operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserDefinedFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteUserDefinedFunction">REST API Reference for DeleteUserDefinedFunction Operation</seealso>
        public virtual IAsyncResult BeginDeleteUserDefinedFunction(DeleteUserDefinedFunctionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteUserDefinedFunctionRequestMarshaller.Instance;
            var unmarshaller = DeleteUserDefinedFunctionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteUserDefinedFunctionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserDefinedFunction.</param>
        /// 
        /// <returns>Returns a  DeleteUserDefinedFunctionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteUserDefinedFunction">REST API Reference for DeleteUserDefinedFunction Operation</seealso>
        public virtual DeleteUserDefinedFunctionResponse EndDeleteUserDefinedFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserDefinedFunctionResponse>(asyncResult);
        }

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
        public virtual GetCatalogImportStatusResponse GetCatalogImportStatus(GetCatalogImportStatusRequest request)
        {
            var marshaller = GetCatalogImportStatusRequestMarshaller.Instance;
            var unmarshaller = GetCatalogImportStatusResponseUnmarshaller.Instance;

            return Invoke<GetCatalogImportStatusRequest,GetCatalogImportStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCatalogImportStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCatalogImportStatus operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCatalogImportStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCatalogImportStatus">REST API Reference for GetCatalogImportStatus Operation</seealso>
        public virtual IAsyncResult BeginGetCatalogImportStatus(GetCatalogImportStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetCatalogImportStatusRequestMarshaller.Instance;
            var unmarshaller = GetCatalogImportStatusResponseUnmarshaller.Instance;

            return BeginInvoke<GetCatalogImportStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCatalogImportStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCatalogImportStatus.</param>
        /// 
        /// <returns>Returns a  GetCatalogImportStatusResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCatalogImportStatus">REST API Reference for GetCatalogImportStatus Operation</seealso>
        public virtual GetCatalogImportStatusResponse EndGetCatalogImportStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCatalogImportStatusResponse>(asyncResult);
        }

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
        public virtual GetClassifierResponse GetClassifier(GetClassifierRequest request)
        {
            var marshaller = GetClassifierRequestMarshaller.Instance;
            var unmarshaller = GetClassifierResponseUnmarshaller.Instance;

            return Invoke<GetClassifierRequest,GetClassifierResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClassifier operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetClassifier
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetClassifier">REST API Reference for GetClassifier Operation</seealso>
        public virtual IAsyncResult BeginGetClassifier(GetClassifierRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetClassifierRequestMarshaller.Instance;
            var unmarshaller = GetClassifierResponseUnmarshaller.Instance;

            return BeginInvoke<GetClassifierRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetClassifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetClassifier.</param>
        /// 
        /// <returns>Returns a  GetClassifierResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetClassifier">REST API Reference for GetClassifier Operation</seealso>
        public virtual GetClassifierResponse EndGetClassifier(IAsyncResult asyncResult)
        {
            return EndInvoke<GetClassifierResponse>(asyncResult);
        }

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
        public virtual GetClassifiersResponse GetClassifiers(GetClassifiersRequest request)
        {
            var marshaller = GetClassifiersRequestMarshaller.Instance;
            var unmarshaller = GetClassifiersResponseUnmarshaller.Instance;

            return Invoke<GetClassifiersRequest,GetClassifiersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetClassifiers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClassifiers operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetClassifiers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetClassifiers">REST API Reference for GetClassifiers Operation</seealso>
        public virtual IAsyncResult BeginGetClassifiers(GetClassifiersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetClassifiersRequestMarshaller.Instance;
            var unmarshaller = GetClassifiersResponseUnmarshaller.Instance;

            return BeginInvoke<GetClassifiersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetClassifiers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetClassifiers.</param>
        /// 
        /// <returns>Returns a  GetClassifiersResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetClassifiers">REST API Reference for GetClassifiers Operation</seealso>
        public virtual GetClassifiersResponse EndGetClassifiers(IAsyncResult asyncResult)
        {
            return EndInvoke<GetClassifiersResponse>(asyncResult);
        }

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
        public virtual GetConnectionResponse GetConnection(GetConnectionRequest request)
        {
            var marshaller = GetConnectionRequestMarshaller.Instance;
            var unmarshaller = GetConnectionResponseUnmarshaller.Instance;

            return Invoke<GetConnectionRequest,GetConnectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnection operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetConnection">REST API Reference for GetConnection Operation</seealso>
        public virtual IAsyncResult BeginGetConnection(GetConnectionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetConnectionRequestMarshaller.Instance;
            var unmarshaller = GetConnectionResponseUnmarshaller.Instance;

            return BeginInvoke<GetConnectionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnection.</param>
        /// 
        /// <returns>Returns a  GetConnectionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetConnection">REST API Reference for GetConnection Operation</seealso>
        public virtual GetConnectionResponse EndGetConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConnectionResponse>(asyncResult);
        }

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
        public virtual GetConnectionsResponse GetConnections(GetConnectionsRequest request)
        {
            var marshaller = GetConnectionsRequestMarshaller.Instance;
            var unmarshaller = GetConnectionsResponseUnmarshaller.Instance;

            return Invoke<GetConnectionsRequest,GetConnectionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnections operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetConnections">REST API Reference for GetConnections Operation</seealso>
        public virtual IAsyncResult BeginGetConnections(GetConnectionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetConnectionsRequestMarshaller.Instance;
            var unmarshaller = GetConnectionsResponseUnmarshaller.Instance;

            return BeginInvoke<GetConnectionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnections.</param>
        /// 
        /// <returns>Returns a  GetConnectionsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetConnections">REST API Reference for GetConnections Operation</seealso>
        public virtual GetConnectionsResponse EndGetConnections(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConnectionsResponse>(asyncResult);
        }

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
        public virtual GetCrawlerResponse GetCrawler(GetCrawlerRequest request)
        {
            var marshaller = GetCrawlerRequestMarshaller.Instance;
            var unmarshaller = GetCrawlerResponseUnmarshaller.Instance;

            return Invoke<GetCrawlerRequest,GetCrawlerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCrawler operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCrawler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawler">REST API Reference for GetCrawler Operation</seealso>
        public virtual IAsyncResult BeginGetCrawler(GetCrawlerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetCrawlerRequestMarshaller.Instance;
            var unmarshaller = GetCrawlerResponseUnmarshaller.Instance;

            return BeginInvoke<GetCrawlerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCrawler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCrawler.</param>
        /// 
        /// <returns>Returns a  GetCrawlerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawler">REST API Reference for GetCrawler Operation</seealso>
        public virtual GetCrawlerResponse EndGetCrawler(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCrawlerResponse>(asyncResult);
        }

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
        public virtual GetCrawlerMetricsResponse GetCrawlerMetrics(GetCrawlerMetricsRequest request)
        {
            var marshaller = GetCrawlerMetricsRequestMarshaller.Instance;
            var unmarshaller = GetCrawlerMetricsResponseUnmarshaller.Instance;

            return Invoke<GetCrawlerMetricsRequest,GetCrawlerMetricsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCrawlerMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCrawlerMetrics operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCrawlerMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawlerMetrics">REST API Reference for GetCrawlerMetrics Operation</seealso>
        public virtual IAsyncResult BeginGetCrawlerMetrics(GetCrawlerMetricsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetCrawlerMetricsRequestMarshaller.Instance;
            var unmarshaller = GetCrawlerMetricsResponseUnmarshaller.Instance;

            return BeginInvoke<GetCrawlerMetricsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCrawlerMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCrawlerMetrics.</param>
        /// 
        /// <returns>Returns a  GetCrawlerMetricsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawlerMetrics">REST API Reference for GetCrawlerMetrics Operation</seealso>
        public virtual GetCrawlerMetricsResponse EndGetCrawlerMetrics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCrawlerMetricsResponse>(asyncResult);
        }

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
        public virtual GetCrawlersResponse GetCrawlers(GetCrawlersRequest request)
        {
            var marshaller = GetCrawlersRequestMarshaller.Instance;
            var unmarshaller = GetCrawlersResponseUnmarshaller.Instance;

            return Invoke<GetCrawlersRequest,GetCrawlersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCrawlers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCrawlers operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCrawlers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawlers">REST API Reference for GetCrawlers Operation</seealso>
        public virtual IAsyncResult BeginGetCrawlers(GetCrawlersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetCrawlersRequestMarshaller.Instance;
            var unmarshaller = GetCrawlersResponseUnmarshaller.Instance;

            return BeginInvoke<GetCrawlersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCrawlers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCrawlers.</param>
        /// 
        /// <returns>Returns a  GetCrawlersResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawlers">REST API Reference for GetCrawlers Operation</seealso>
        public virtual GetCrawlersResponse EndGetCrawlers(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCrawlersResponse>(asyncResult);
        }

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
        public virtual GetDatabaseResponse GetDatabase(GetDatabaseRequest request)
        {
            var marshaller = GetDatabaseRequestMarshaller.Instance;
            var unmarshaller = GetDatabaseResponseUnmarshaller.Instance;

            return Invoke<GetDatabaseRequest,GetDatabaseResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDatabase operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
        public virtual IAsyncResult BeginGetDatabase(GetDatabaseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDatabaseRequestMarshaller.Instance;
            var unmarshaller = GetDatabaseResponseUnmarshaller.Instance;

            return BeginInvoke<GetDatabaseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDatabase.</param>
        /// 
        /// <returns>Returns a  GetDatabaseResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
        public virtual GetDatabaseResponse EndGetDatabase(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDatabaseResponse>(asyncResult);
        }

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
        public virtual GetDatabasesResponse GetDatabases(GetDatabasesRequest request)
        {
            var marshaller = GetDatabasesRequestMarshaller.Instance;
            var unmarshaller = GetDatabasesResponseUnmarshaller.Instance;

            return Invoke<GetDatabasesRequest,GetDatabasesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDatabases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDatabases operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDatabases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDatabases">REST API Reference for GetDatabases Operation</seealso>
        public virtual IAsyncResult BeginGetDatabases(GetDatabasesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDatabasesRequestMarshaller.Instance;
            var unmarshaller = GetDatabasesResponseUnmarshaller.Instance;

            return BeginInvoke<GetDatabasesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDatabases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDatabases.</param>
        /// 
        /// <returns>Returns a  GetDatabasesResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDatabases">REST API Reference for GetDatabases Operation</seealso>
        public virtual GetDatabasesResponse EndGetDatabases(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDatabasesResponse>(asyncResult);
        }

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
        public virtual GetDataflowGraphResponse GetDataflowGraph(GetDataflowGraphRequest request)
        {
            var marshaller = GetDataflowGraphRequestMarshaller.Instance;
            var unmarshaller = GetDataflowGraphResponseUnmarshaller.Instance;

            return Invoke<GetDataflowGraphRequest,GetDataflowGraphResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataflowGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataflowGraph operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataflowGraph
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataflowGraph">REST API Reference for GetDataflowGraph Operation</seealso>
        public virtual IAsyncResult BeginGetDataflowGraph(GetDataflowGraphRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDataflowGraphRequestMarshaller.Instance;
            var unmarshaller = GetDataflowGraphResponseUnmarshaller.Instance;

            return BeginInvoke<GetDataflowGraphRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataflowGraph operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataflowGraph.</param>
        /// 
        /// <returns>Returns a  GetDataflowGraphResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataflowGraph">REST API Reference for GetDataflowGraph Operation</seealso>
        public virtual GetDataflowGraphResponse EndGetDataflowGraph(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataflowGraphResponse>(asyncResult);
        }

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
        public virtual GetDevEndpointResponse GetDevEndpoint(GetDevEndpointRequest request)
        {
            var marshaller = GetDevEndpointRequestMarshaller.Instance;
            var unmarshaller = GetDevEndpointResponseUnmarshaller.Instance;

            return Invoke<GetDevEndpointRequest,GetDevEndpointResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevEndpoint operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDevEndpoint">REST API Reference for GetDevEndpoint Operation</seealso>
        public virtual IAsyncResult BeginGetDevEndpoint(GetDevEndpointRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDevEndpointRequestMarshaller.Instance;
            var unmarshaller = GetDevEndpointResponseUnmarshaller.Instance;

            return BeginInvoke<GetDevEndpointRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevEndpoint.</param>
        /// 
        /// <returns>Returns a  GetDevEndpointResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDevEndpoint">REST API Reference for GetDevEndpoint Operation</seealso>
        public virtual GetDevEndpointResponse EndGetDevEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDevEndpointResponse>(asyncResult);
        }

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
        public virtual GetDevEndpointsResponse GetDevEndpoints(GetDevEndpointsRequest request)
        {
            var marshaller = GetDevEndpointsRequestMarshaller.Instance;
            var unmarshaller = GetDevEndpointsResponseUnmarshaller.Instance;

            return Invoke<GetDevEndpointsRequest,GetDevEndpointsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevEndpoints operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDevEndpoints">REST API Reference for GetDevEndpoints Operation</seealso>
        public virtual IAsyncResult BeginGetDevEndpoints(GetDevEndpointsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDevEndpointsRequestMarshaller.Instance;
            var unmarshaller = GetDevEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke<GetDevEndpointsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevEndpoints.</param>
        /// 
        /// <returns>Returns a  GetDevEndpointsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDevEndpoints">REST API Reference for GetDevEndpoints Operation</seealso>
        public virtual GetDevEndpointsResponse EndGetDevEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDevEndpointsResponse>(asyncResult);
        }

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
        public virtual GetJobResponse GetJob(GetJobRequest request)
        {
            var marshaller = GetJobRequestMarshaller.Instance;
            var unmarshaller = GetJobResponseUnmarshaller.Instance;

            return Invoke<GetJobRequest,GetJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJob operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual IAsyncResult BeginGetJob(GetJobRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetJobRequestMarshaller.Instance;
            var unmarshaller = GetJobResponseUnmarshaller.Instance;

            return BeginInvoke<GetJobRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJob.</param>
        /// 
        /// <returns>Returns a  GetJobResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual GetJobResponse EndGetJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJobResponse>(asyncResult);
        }

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
        public virtual GetJobRunResponse GetJobRun(GetJobRunRequest request)
        {
            var marshaller = GetJobRunRequestMarshaller.Instance;
            var unmarshaller = GetJobRunResponseUnmarshaller.Instance;

            return Invoke<GetJobRunRequest,GetJobRunResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJobRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJobRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobRun">REST API Reference for GetJobRun Operation</seealso>
        public virtual IAsyncResult BeginGetJobRun(GetJobRunRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetJobRunRequestMarshaller.Instance;
            var unmarshaller = GetJobRunResponseUnmarshaller.Instance;

            return BeginInvoke<GetJobRunRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJobRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJobRun.</param>
        /// 
        /// <returns>Returns a  GetJobRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobRun">REST API Reference for GetJobRun Operation</seealso>
        public virtual GetJobRunResponse EndGetJobRun(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJobRunResponse>(asyncResult);
        }

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
        public virtual GetJobRunsResponse GetJobRuns(GetJobRunsRequest request)
        {
            var marshaller = GetJobRunsRequestMarshaller.Instance;
            var unmarshaller = GetJobRunsResponseUnmarshaller.Instance;

            return Invoke<GetJobRunsRequest,GetJobRunsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJobRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobRuns operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJobRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobRuns">REST API Reference for GetJobRuns Operation</seealso>
        public virtual IAsyncResult BeginGetJobRuns(GetJobRunsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetJobRunsRequestMarshaller.Instance;
            var unmarshaller = GetJobRunsResponseUnmarshaller.Instance;

            return BeginInvoke<GetJobRunsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJobRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJobRuns.</param>
        /// 
        /// <returns>Returns a  GetJobRunsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobRuns">REST API Reference for GetJobRuns Operation</seealso>
        public virtual GetJobRunsResponse EndGetJobRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJobRunsResponse>(asyncResult);
        }

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
        public virtual GetJobsResponse GetJobs(GetJobsRequest request)
        {
            var marshaller = GetJobsRequestMarshaller.Instance;
            var unmarshaller = GetJobsResponseUnmarshaller.Instance;

            return Invoke<GetJobsRequest,GetJobsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobs operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobs">REST API Reference for GetJobs Operation</seealso>
        public virtual IAsyncResult BeginGetJobs(GetJobsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetJobsRequestMarshaller.Instance;
            var unmarshaller = GetJobsResponseUnmarshaller.Instance;

            return BeginInvoke<GetJobsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJobs.</param>
        /// 
        /// <returns>Returns a  GetJobsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobs">REST API Reference for GetJobs Operation</seealso>
        public virtual GetJobsResponse EndGetJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJobsResponse>(asyncResult);
        }

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
        public virtual GetMappingResponse GetMapping(GetMappingRequest request)
        {
            var marshaller = GetMappingRequestMarshaller.Instance;
            var unmarshaller = GetMappingResponseUnmarshaller.Instance;

            return Invoke<GetMappingRequest,GetMappingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMapping operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMapping">REST API Reference for GetMapping Operation</seealso>
        public virtual IAsyncResult BeginGetMapping(GetMappingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetMappingRequestMarshaller.Instance;
            var unmarshaller = GetMappingResponseUnmarshaller.Instance;

            return BeginInvoke<GetMappingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMapping.</param>
        /// 
        /// <returns>Returns a  GetMappingResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMapping">REST API Reference for GetMapping Operation</seealso>
        public virtual GetMappingResponse EndGetMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMappingResponse>(asyncResult);
        }

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
        public virtual GetPartitionResponse GetPartition(GetPartitionRequest request)
        {
            var marshaller = GetPartitionRequestMarshaller.Instance;
            var unmarshaller = GetPartitionResponseUnmarshaller.Instance;

            return Invoke<GetPartitionRequest,GetPartitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPartition operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPartition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartition">REST API Reference for GetPartition Operation</seealso>
        public virtual IAsyncResult BeginGetPartition(GetPartitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetPartitionRequestMarshaller.Instance;
            var unmarshaller = GetPartitionResponseUnmarshaller.Instance;

            return BeginInvoke<GetPartitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPartition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPartition.</param>
        /// 
        /// <returns>Returns a  GetPartitionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartition">REST API Reference for GetPartition Operation</seealso>
        public virtual GetPartitionResponse EndGetPartition(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPartitionResponse>(asyncResult);
        }

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
        public virtual GetPartitionsResponse GetPartitions(GetPartitionsRequest request)
        {
            var marshaller = GetPartitionsRequestMarshaller.Instance;
            var unmarshaller = GetPartitionsResponseUnmarshaller.Instance;

            return Invoke<GetPartitionsRequest,GetPartitionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPartitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPartitions operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPartitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartitions">REST API Reference for GetPartitions Operation</seealso>
        public virtual IAsyncResult BeginGetPartitions(GetPartitionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetPartitionsRequestMarshaller.Instance;
            var unmarshaller = GetPartitionsResponseUnmarshaller.Instance;

            return BeginInvoke<GetPartitionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPartitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPartitions.</param>
        /// 
        /// <returns>Returns a  GetPartitionsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartitions">REST API Reference for GetPartitions Operation</seealso>
        public virtual GetPartitionsResponse EndGetPartitions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPartitionsResponse>(asyncResult);
        }

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
        public virtual GetPlanResponse GetPlan(GetPlanRequest request)
        {
            var marshaller = GetPlanRequestMarshaller.Instance;
            var unmarshaller = GetPlanResponseUnmarshaller.Instance;

            return Invoke<GetPlanRequest,GetPlanResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlan operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPlan">REST API Reference for GetPlan Operation</seealso>
        public virtual IAsyncResult BeginGetPlan(GetPlanRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetPlanRequestMarshaller.Instance;
            var unmarshaller = GetPlanResponseUnmarshaller.Instance;

            return BeginInvoke<GetPlanRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPlan.</param>
        /// 
        /// <returns>Returns a  GetPlanResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPlan">REST API Reference for GetPlan Operation</seealso>
        public virtual GetPlanResponse EndGetPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPlanResponse>(asyncResult);
        }

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
        public virtual GetTableResponse GetTable(GetTableRequest request)
        {
            var marshaller = GetTableRequestMarshaller.Instance;
            var unmarshaller = GetTableResponseUnmarshaller.Instance;

            return Invoke<GetTableRequest,GetTableResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTable operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTable">REST API Reference for GetTable Operation</seealso>
        public virtual IAsyncResult BeginGetTable(GetTableRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetTableRequestMarshaller.Instance;
            var unmarshaller = GetTableResponseUnmarshaller.Instance;

            return BeginInvoke<GetTableRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTable.</param>
        /// 
        /// <returns>Returns a  GetTableResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTable">REST API Reference for GetTable Operation</seealso>
        public virtual GetTableResponse EndGetTable(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTableResponse>(asyncResult);
        }

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
        public virtual GetTablesResponse GetTables(GetTablesRequest request)
        {
            var marshaller = GetTablesRequestMarshaller.Instance;
            var unmarshaller = GetTablesResponseUnmarshaller.Instance;

            return Invoke<GetTablesRequest,GetTablesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTables operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTables
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTables">REST API Reference for GetTables Operation</seealso>
        public virtual IAsyncResult BeginGetTables(GetTablesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetTablesRequestMarshaller.Instance;
            var unmarshaller = GetTablesResponseUnmarshaller.Instance;

            return BeginInvoke<GetTablesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTables.</param>
        /// 
        /// <returns>Returns a  GetTablesResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTables">REST API Reference for GetTables Operation</seealso>
        public virtual GetTablesResponse EndGetTables(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTablesResponse>(asyncResult);
        }

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
        public virtual GetTableVersionResponse GetTableVersion(GetTableVersionRequest request)
        {
            var marshaller = GetTableVersionRequestMarshaller.Instance;
            var unmarshaller = GetTableVersionResponseUnmarshaller.Instance;

            return Invoke<GetTableVersionRequest,GetTableVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableVersion operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTableVersion">REST API Reference for GetTableVersion Operation</seealso>
        public virtual IAsyncResult BeginGetTableVersion(GetTableVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetTableVersionRequestMarshaller.Instance;
            var unmarshaller = GetTableVersionResponseUnmarshaller.Instance;

            return BeginInvoke<GetTableVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableVersion.</param>
        /// 
        /// <returns>Returns a  GetTableVersionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTableVersion">REST API Reference for GetTableVersion Operation</seealso>
        public virtual GetTableVersionResponse EndGetTableVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTableVersionResponse>(asyncResult);
        }

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
        public virtual GetTableVersionsResponse GetTableVersions(GetTableVersionsRequest request)
        {
            var marshaller = GetTableVersionsRequestMarshaller.Instance;
            var unmarshaller = GetTableVersionsResponseUnmarshaller.Instance;

            return Invoke<GetTableVersionsRequest,GetTableVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableVersions operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTableVersions">REST API Reference for GetTableVersions Operation</seealso>
        public virtual IAsyncResult BeginGetTableVersions(GetTableVersionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetTableVersionsRequestMarshaller.Instance;
            var unmarshaller = GetTableVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<GetTableVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableVersions.</param>
        /// 
        /// <returns>Returns a  GetTableVersionsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTableVersions">REST API Reference for GetTableVersions Operation</seealso>
        public virtual GetTableVersionsResponse EndGetTableVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTableVersionsResponse>(asyncResult);
        }

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
        public virtual GetTriggerResponse GetTrigger(GetTriggerRequest request)
        {
            var marshaller = GetTriggerRequestMarshaller.Instance;
            var unmarshaller = GetTriggerResponseUnmarshaller.Instance;

            return Invoke<GetTriggerRequest,GetTriggerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrigger operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrigger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTrigger">REST API Reference for GetTrigger Operation</seealso>
        public virtual IAsyncResult BeginGetTrigger(GetTriggerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetTriggerRequestMarshaller.Instance;
            var unmarshaller = GetTriggerResponseUnmarshaller.Instance;

            return BeginInvoke<GetTriggerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTrigger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrigger.</param>
        /// 
        /// <returns>Returns a  GetTriggerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTrigger">REST API Reference for GetTrigger Operation</seealso>
        public virtual GetTriggerResponse EndGetTrigger(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTriggerResponse>(asyncResult);
        }

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
        public virtual GetTriggersResponse GetTriggers(GetTriggersRequest request)
        {
            var marshaller = GetTriggersRequestMarshaller.Instance;
            var unmarshaller = GetTriggersResponseUnmarshaller.Instance;

            return Invoke<GetTriggersRequest,GetTriggersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTriggers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTriggers operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTriggers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTriggers">REST API Reference for GetTriggers Operation</seealso>
        public virtual IAsyncResult BeginGetTriggers(GetTriggersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetTriggersRequestMarshaller.Instance;
            var unmarshaller = GetTriggersResponseUnmarshaller.Instance;

            return BeginInvoke<GetTriggersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTriggers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTriggers.</param>
        /// 
        /// <returns>Returns a  GetTriggersResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTriggers">REST API Reference for GetTriggers Operation</seealso>
        public virtual GetTriggersResponse EndGetTriggers(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTriggersResponse>(asyncResult);
        }

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
        public virtual GetUserDefinedFunctionResponse GetUserDefinedFunction(GetUserDefinedFunctionRequest request)
        {
            var marshaller = GetUserDefinedFunctionRequestMarshaller.Instance;
            var unmarshaller = GetUserDefinedFunctionResponseUnmarshaller.Instance;

            return Invoke<GetUserDefinedFunctionRequest,GetUserDefinedFunctionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserDefinedFunction operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserDefinedFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUserDefinedFunction">REST API Reference for GetUserDefinedFunction Operation</seealso>
        public virtual IAsyncResult BeginGetUserDefinedFunction(GetUserDefinedFunctionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetUserDefinedFunctionRequestMarshaller.Instance;
            var unmarshaller = GetUserDefinedFunctionResponseUnmarshaller.Instance;

            return BeginInvoke<GetUserDefinedFunctionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserDefinedFunction.</param>
        /// 
        /// <returns>Returns a  GetUserDefinedFunctionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUserDefinedFunction">REST API Reference for GetUserDefinedFunction Operation</seealso>
        public virtual GetUserDefinedFunctionResponse EndGetUserDefinedFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserDefinedFunctionResponse>(asyncResult);
        }

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
        public virtual GetUserDefinedFunctionsResponse GetUserDefinedFunctions(GetUserDefinedFunctionsRequest request)
        {
            var marshaller = GetUserDefinedFunctionsRequestMarshaller.Instance;
            var unmarshaller = GetUserDefinedFunctionsResponseUnmarshaller.Instance;

            return Invoke<GetUserDefinedFunctionsRequest,GetUserDefinedFunctionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserDefinedFunctions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserDefinedFunctions operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserDefinedFunctions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUserDefinedFunctions">REST API Reference for GetUserDefinedFunctions Operation</seealso>
        public virtual IAsyncResult BeginGetUserDefinedFunctions(GetUserDefinedFunctionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetUserDefinedFunctionsRequestMarshaller.Instance;
            var unmarshaller = GetUserDefinedFunctionsResponseUnmarshaller.Instance;

            return BeginInvoke<GetUserDefinedFunctionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserDefinedFunctions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserDefinedFunctions.</param>
        /// 
        /// <returns>Returns a  GetUserDefinedFunctionsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUserDefinedFunctions">REST API Reference for GetUserDefinedFunctions Operation</seealso>
        public virtual GetUserDefinedFunctionsResponse EndGetUserDefinedFunctions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserDefinedFunctionsResponse>(asyncResult);
        }

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
        public virtual ImportCatalogToGlueResponse ImportCatalogToGlue(ImportCatalogToGlueRequest request)
        {
            var marshaller = ImportCatalogToGlueRequestMarshaller.Instance;
            var unmarshaller = ImportCatalogToGlueResponseUnmarshaller.Instance;

            return Invoke<ImportCatalogToGlueRequest,ImportCatalogToGlueResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportCatalogToGlue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportCatalogToGlue operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportCatalogToGlue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ImportCatalogToGlue">REST API Reference for ImportCatalogToGlue Operation</seealso>
        public virtual IAsyncResult BeginImportCatalogToGlue(ImportCatalogToGlueRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ImportCatalogToGlueRequestMarshaller.Instance;
            var unmarshaller = ImportCatalogToGlueResponseUnmarshaller.Instance;

            return BeginInvoke<ImportCatalogToGlueRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportCatalogToGlue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportCatalogToGlue.</param>
        /// 
        /// <returns>Returns a  ImportCatalogToGlueResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ImportCatalogToGlue">REST API Reference for ImportCatalogToGlue Operation</seealso>
        public virtual ImportCatalogToGlueResponse EndImportCatalogToGlue(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportCatalogToGlueResponse>(asyncResult);
        }

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
        public virtual ResetJobBookmarkResponse ResetJobBookmark(ResetJobBookmarkRequest request)
        {
            var marshaller = ResetJobBookmarkRequestMarshaller.Instance;
            var unmarshaller = ResetJobBookmarkResponseUnmarshaller.Instance;

            return Invoke<ResetJobBookmarkRequest,ResetJobBookmarkResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetJobBookmark operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetJobBookmark operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetJobBookmark
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ResetJobBookmark">REST API Reference for ResetJobBookmark Operation</seealso>
        public virtual IAsyncResult BeginResetJobBookmark(ResetJobBookmarkRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ResetJobBookmarkRequestMarshaller.Instance;
            var unmarshaller = ResetJobBookmarkResponseUnmarshaller.Instance;

            return BeginInvoke<ResetJobBookmarkRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResetJobBookmark operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetJobBookmark.</param>
        /// 
        /// <returns>Returns a  ResetJobBookmarkResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ResetJobBookmark">REST API Reference for ResetJobBookmark Operation</seealso>
        public virtual ResetJobBookmarkResponse EndResetJobBookmark(IAsyncResult asyncResult)
        {
            return EndInvoke<ResetJobBookmarkResponse>(asyncResult);
        }

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
        public virtual StartCrawlerResponse StartCrawler(StartCrawlerRequest request)
        {
            var marshaller = StartCrawlerRequestMarshaller.Instance;
            var unmarshaller = StartCrawlerResponseUnmarshaller.Instance;

            return Invoke<StartCrawlerRequest,StartCrawlerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCrawler operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartCrawler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartCrawler">REST API Reference for StartCrawler Operation</seealso>
        public virtual IAsyncResult BeginStartCrawler(StartCrawlerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StartCrawlerRequestMarshaller.Instance;
            var unmarshaller = StartCrawlerResponseUnmarshaller.Instance;

            return BeginInvoke<StartCrawlerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartCrawler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartCrawler.</param>
        /// 
        /// <returns>Returns a  StartCrawlerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartCrawler">REST API Reference for StartCrawler Operation</seealso>
        public virtual StartCrawlerResponse EndStartCrawler(IAsyncResult asyncResult)
        {
            return EndInvoke<StartCrawlerResponse>(asyncResult);
        }

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
        public virtual StartCrawlerScheduleResponse StartCrawlerSchedule(StartCrawlerScheduleRequest request)
        {
            var marshaller = StartCrawlerScheduleRequestMarshaller.Instance;
            var unmarshaller = StartCrawlerScheduleResponseUnmarshaller.Instance;

            return Invoke<StartCrawlerScheduleRequest,StartCrawlerScheduleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartCrawlerSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCrawlerSchedule operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartCrawlerSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartCrawlerSchedule">REST API Reference for StartCrawlerSchedule Operation</seealso>
        public virtual IAsyncResult BeginStartCrawlerSchedule(StartCrawlerScheduleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StartCrawlerScheduleRequestMarshaller.Instance;
            var unmarshaller = StartCrawlerScheduleResponseUnmarshaller.Instance;

            return BeginInvoke<StartCrawlerScheduleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartCrawlerSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartCrawlerSchedule.</param>
        /// 
        /// <returns>Returns a  StartCrawlerScheduleResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartCrawlerSchedule">REST API Reference for StartCrawlerSchedule Operation</seealso>
        public virtual StartCrawlerScheduleResponse EndStartCrawlerSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<StartCrawlerScheduleResponse>(asyncResult);
        }

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
        public virtual StartJobRunResponse StartJobRun(StartJobRunRequest request)
        {
            var marshaller = StartJobRunRequestMarshaller.Instance;
            var unmarshaller = StartJobRunResponseUnmarshaller.Instance;

            return Invoke<StartJobRunRequest,StartJobRunResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartJobRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartJobRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartJobRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartJobRun">REST API Reference for StartJobRun Operation</seealso>
        public virtual IAsyncResult BeginStartJobRun(StartJobRunRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StartJobRunRequestMarshaller.Instance;
            var unmarshaller = StartJobRunResponseUnmarshaller.Instance;

            return BeginInvoke<StartJobRunRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartJobRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartJobRun.</param>
        /// 
        /// <returns>Returns a  StartJobRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartJobRun">REST API Reference for StartJobRun Operation</seealso>
        public virtual StartJobRunResponse EndStartJobRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StartJobRunResponse>(asyncResult);
        }

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
        public virtual StartTriggerResponse StartTrigger(StartTriggerRequest request)
        {
            var marshaller = StartTriggerRequestMarshaller.Instance;
            var unmarshaller = StartTriggerResponseUnmarshaller.Instance;

            return Invoke<StartTriggerRequest,StartTriggerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTrigger operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTrigger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartTrigger">REST API Reference for StartTrigger Operation</seealso>
        public virtual IAsyncResult BeginStartTrigger(StartTriggerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StartTriggerRequestMarshaller.Instance;
            var unmarshaller = StartTriggerResponseUnmarshaller.Instance;

            return BeginInvoke<StartTriggerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTrigger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTrigger.</param>
        /// 
        /// <returns>Returns a  StartTriggerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartTrigger">REST API Reference for StartTrigger Operation</seealso>
        public virtual StartTriggerResponse EndStartTrigger(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTriggerResponse>(asyncResult);
        }

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
        public virtual StopCrawlerResponse StopCrawler(StopCrawlerRequest request)
        {
            var marshaller = StopCrawlerRequestMarshaller.Instance;
            var unmarshaller = StopCrawlerResponseUnmarshaller.Instance;

            return Invoke<StopCrawlerRequest,StopCrawlerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopCrawler operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopCrawler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopCrawler">REST API Reference for StopCrawler Operation</seealso>
        public virtual IAsyncResult BeginStopCrawler(StopCrawlerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StopCrawlerRequestMarshaller.Instance;
            var unmarshaller = StopCrawlerResponseUnmarshaller.Instance;

            return BeginInvoke<StopCrawlerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopCrawler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopCrawler.</param>
        /// 
        /// <returns>Returns a  StopCrawlerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopCrawler">REST API Reference for StopCrawler Operation</seealso>
        public virtual StopCrawlerResponse EndStopCrawler(IAsyncResult asyncResult)
        {
            return EndInvoke<StopCrawlerResponse>(asyncResult);
        }

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
        public virtual StopCrawlerScheduleResponse StopCrawlerSchedule(StopCrawlerScheduleRequest request)
        {
            var marshaller = StopCrawlerScheduleRequestMarshaller.Instance;
            var unmarshaller = StopCrawlerScheduleResponseUnmarshaller.Instance;

            return Invoke<StopCrawlerScheduleRequest,StopCrawlerScheduleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopCrawlerSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopCrawlerSchedule operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopCrawlerSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopCrawlerSchedule">REST API Reference for StopCrawlerSchedule Operation</seealso>
        public virtual IAsyncResult BeginStopCrawlerSchedule(StopCrawlerScheduleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StopCrawlerScheduleRequestMarshaller.Instance;
            var unmarshaller = StopCrawlerScheduleResponseUnmarshaller.Instance;

            return BeginInvoke<StopCrawlerScheduleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopCrawlerSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopCrawlerSchedule.</param>
        /// 
        /// <returns>Returns a  StopCrawlerScheduleResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopCrawlerSchedule">REST API Reference for StopCrawlerSchedule Operation</seealso>
        public virtual StopCrawlerScheduleResponse EndStopCrawlerSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<StopCrawlerScheduleResponse>(asyncResult);
        }

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
        public virtual StopTriggerResponse StopTrigger(StopTriggerRequest request)
        {
            var marshaller = StopTriggerRequestMarshaller.Instance;
            var unmarshaller = StopTriggerResponseUnmarshaller.Instance;

            return Invoke<StopTriggerRequest,StopTriggerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTrigger operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTrigger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopTrigger">REST API Reference for StopTrigger Operation</seealso>
        public virtual IAsyncResult BeginStopTrigger(StopTriggerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StopTriggerRequestMarshaller.Instance;
            var unmarshaller = StopTriggerResponseUnmarshaller.Instance;

            return BeginInvoke<StopTriggerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopTrigger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTrigger.</param>
        /// 
        /// <returns>Returns a  StopTriggerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopTrigger">REST API Reference for StopTrigger Operation</seealso>
        public virtual StopTriggerResponse EndStopTrigger(IAsyncResult asyncResult)
        {
            return EndInvoke<StopTriggerResponse>(asyncResult);
        }

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
        public virtual UpdateClassifierResponse UpdateClassifier(UpdateClassifierRequest request)
        {
            var marshaller = UpdateClassifierRequestMarshaller.Instance;
            var unmarshaller = UpdateClassifierResponseUnmarshaller.Instance;

            return Invoke<UpdateClassifierRequest,UpdateClassifierResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateClassifier operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateClassifier
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateClassifier">REST API Reference for UpdateClassifier Operation</seealso>
        public virtual IAsyncResult BeginUpdateClassifier(UpdateClassifierRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateClassifierRequestMarshaller.Instance;
            var unmarshaller = UpdateClassifierResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateClassifierRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateClassifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateClassifier.</param>
        /// 
        /// <returns>Returns a  UpdateClassifierResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateClassifier">REST API Reference for UpdateClassifier Operation</seealso>
        public virtual UpdateClassifierResponse EndUpdateClassifier(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateClassifierResponse>(asyncResult);
        }

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
        public virtual UpdateConnectionResponse UpdateConnection(UpdateConnectionRequest request)
        {
            var marshaller = UpdateConnectionRequestMarshaller.Instance;
            var unmarshaller = UpdateConnectionResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectionRequest,UpdateConnectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        public virtual IAsyncResult BeginUpdateConnection(UpdateConnectionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateConnectionRequestMarshaller.Instance;
            var unmarshaller = UpdateConnectionResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateConnectionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnection.</param>
        /// 
        /// <returns>Returns a  UpdateConnectionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        public virtual UpdateConnectionResponse EndUpdateConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConnectionResponse>(asyncResult);
        }

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
        public virtual UpdateCrawlerResponse UpdateCrawler(UpdateCrawlerRequest request)
        {
            var marshaller = UpdateCrawlerRequestMarshaller.Instance;
            var unmarshaller = UpdateCrawlerResponseUnmarshaller.Instance;

            return Invoke<UpdateCrawlerRequest,UpdateCrawlerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrawler operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCrawler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateCrawler">REST API Reference for UpdateCrawler Operation</seealso>
        public virtual IAsyncResult BeginUpdateCrawler(UpdateCrawlerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateCrawlerRequestMarshaller.Instance;
            var unmarshaller = UpdateCrawlerResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateCrawlerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCrawler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCrawler.</param>
        /// 
        /// <returns>Returns a  UpdateCrawlerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateCrawler">REST API Reference for UpdateCrawler Operation</seealso>
        public virtual UpdateCrawlerResponse EndUpdateCrawler(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCrawlerResponse>(asyncResult);
        }

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
        public virtual UpdateCrawlerScheduleResponse UpdateCrawlerSchedule(UpdateCrawlerScheduleRequest request)
        {
            var marshaller = UpdateCrawlerScheduleRequestMarshaller.Instance;
            var unmarshaller = UpdateCrawlerScheduleResponseUnmarshaller.Instance;

            return Invoke<UpdateCrawlerScheduleRequest,UpdateCrawlerScheduleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCrawlerSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrawlerSchedule operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCrawlerSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateCrawlerSchedule">REST API Reference for UpdateCrawlerSchedule Operation</seealso>
        public virtual IAsyncResult BeginUpdateCrawlerSchedule(UpdateCrawlerScheduleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateCrawlerScheduleRequestMarshaller.Instance;
            var unmarshaller = UpdateCrawlerScheduleResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateCrawlerScheduleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCrawlerSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCrawlerSchedule.</param>
        /// 
        /// <returns>Returns a  UpdateCrawlerScheduleResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateCrawlerSchedule">REST API Reference for UpdateCrawlerSchedule Operation</seealso>
        public virtual UpdateCrawlerScheduleResponse EndUpdateCrawlerSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCrawlerScheduleResponse>(asyncResult);
        }

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
        public virtual UpdateDatabaseResponse UpdateDatabase(UpdateDatabaseRequest request)
        {
            var marshaller = UpdateDatabaseRequestMarshaller.Instance;
            var unmarshaller = UpdateDatabaseResponseUnmarshaller.Instance;

            return Invoke<UpdateDatabaseRequest,UpdateDatabaseResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatabase operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDatabase">REST API Reference for UpdateDatabase Operation</seealso>
        public virtual IAsyncResult BeginUpdateDatabase(UpdateDatabaseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateDatabaseRequestMarshaller.Instance;
            var unmarshaller = UpdateDatabaseResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateDatabaseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDatabase.</param>
        /// 
        /// <returns>Returns a  UpdateDatabaseResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDatabase">REST API Reference for UpdateDatabase Operation</seealso>
        public virtual UpdateDatabaseResponse EndUpdateDatabase(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDatabaseResponse>(asyncResult);
        }

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
        public virtual UpdateDevEndpointResponse UpdateDevEndpoint(UpdateDevEndpointRequest request)
        {
            var marshaller = UpdateDevEndpointRequestMarshaller.Instance;
            var unmarshaller = UpdateDevEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateDevEndpointRequest,UpdateDevEndpointResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevEndpoint operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDevEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDevEndpoint">REST API Reference for UpdateDevEndpoint Operation</seealso>
        public virtual IAsyncResult BeginUpdateDevEndpoint(UpdateDevEndpointRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateDevEndpointRequestMarshaller.Instance;
            var unmarshaller = UpdateDevEndpointResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateDevEndpointRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDevEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateDevEndpointResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDevEndpoint">REST API Reference for UpdateDevEndpoint Operation</seealso>
        public virtual UpdateDevEndpointResponse EndUpdateDevEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDevEndpointResponse>(asyncResult);
        }

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
        public virtual UpdateJobResponse UpdateJob(UpdateJobRequest request)
        {
            var marshaller = UpdateJobRequestMarshaller.Instance;
            var unmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return Invoke<UpdateJobRequest,UpdateJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        public virtual IAsyncResult BeginUpdateJob(UpdateJobRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateJobRequestMarshaller.Instance;
            var unmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateJobRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJob.</param>
        /// 
        /// <returns>Returns a  UpdateJobResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        public virtual UpdateJobResponse EndUpdateJob(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateJobResponse>(asyncResult);
        }

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
        public virtual UpdatePartitionResponse UpdatePartition(UpdatePartitionRequest request)
        {
            var marshaller = UpdatePartitionRequestMarshaller.Instance;
            var unmarshaller = UpdatePartitionResponseUnmarshaller.Instance;

            return Invoke<UpdatePartitionRequest,UpdatePartitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartition operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePartition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdatePartition">REST API Reference for UpdatePartition Operation</seealso>
        public virtual IAsyncResult BeginUpdatePartition(UpdatePartitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdatePartitionRequestMarshaller.Instance;
            var unmarshaller = UpdatePartitionResponseUnmarshaller.Instance;

            return BeginInvoke<UpdatePartitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePartition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePartition.</param>
        /// 
        /// <returns>Returns a  UpdatePartitionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdatePartition">REST API Reference for UpdatePartition Operation</seealso>
        public virtual UpdatePartitionResponse EndUpdatePartition(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePartitionResponse>(asyncResult);
        }

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
        public virtual UpdateTableResponse UpdateTable(UpdateTableRequest request)
        {
            var marshaller = UpdateTableRequestMarshaller.Instance;
            var unmarshaller = UpdateTableResponseUnmarshaller.Instance;

            return Invoke<UpdateTableRequest,UpdateTableResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTable operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        public virtual IAsyncResult BeginUpdateTable(UpdateTableRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateTableRequestMarshaller.Instance;
            var unmarshaller = UpdateTableResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateTableRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTable.</param>
        /// 
        /// <returns>Returns a  UpdateTableResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        public virtual UpdateTableResponse EndUpdateTable(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTableResponse>(asyncResult);
        }

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
        public virtual UpdateTriggerResponse UpdateTrigger(UpdateTriggerRequest request)
        {
            var marshaller = UpdateTriggerRequestMarshaller.Instance;
            var unmarshaller = UpdateTriggerResponseUnmarshaller.Instance;

            return Invoke<UpdateTriggerRequest,UpdateTriggerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrigger operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTrigger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateTrigger">REST API Reference for UpdateTrigger Operation</seealso>
        public virtual IAsyncResult BeginUpdateTrigger(UpdateTriggerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateTriggerRequestMarshaller.Instance;
            var unmarshaller = UpdateTriggerResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateTriggerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTrigger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTrigger.</param>
        /// 
        /// <returns>Returns a  UpdateTriggerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateTrigger">REST API Reference for UpdateTrigger Operation</seealso>
        public virtual UpdateTriggerResponse EndUpdateTrigger(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTriggerResponse>(asyncResult);
        }

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
        public virtual UpdateUserDefinedFunctionResponse UpdateUserDefinedFunction(UpdateUserDefinedFunctionRequest request)
        {
            var marshaller = UpdateUserDefinedFunctionRequestMarshaller.Instance;
            var unmarshaller = UpdateUserDefinedFunctionResponseUnmarshaller.Instance;

            return Invoke<UpdateUserDefinedFunctionRequest,UpdateUserDefinedFunctionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserDefinedFunction operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserDefinedFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateUserDefinedFunction">REST API Reference for UpdateUserDefinedFunction Operation</seealso>
        public virtual IAsyncResult BeginUpdateUserDefinedFunction(UpdateUserDefinedFunctionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateUserDefinedFunctionRequestMarshaller.Instance;
            var unmarshaller = UpdateUserDefinedFunctionResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateUserDefinedFunctionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserDefinedFunction.</param>
        /// 
        /// <returns>Returns a  UpdateUserDefinedFunctionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateUserDefinedFunction">REST API Reference for UpdateUserDefinedFunction Operation</seealso>
        public virtual UpdateUserDefinedFunctionResponse EndUpdateUserDefinedFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserDefinedFunctionResponse>(asyncResult);
        }

        #endregion
        
    }
}