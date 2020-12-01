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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Honeycode.Model;
using Amazon.Honeycode.Model.Internal.MarshallTransformations;
using Amazon.Honeycode.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Honeycode
{
    /// <summary>
    /// Implementation for accessing Honeycode
    ///
    /// Amazon Honeycode is a fully managed service that allows you to quickly build mobile
    /// and web apps for teams—without programming. Build Honeycode apps for managing almost
    /// anything, like projects, customers, operations, approvals, resources, and even your
    /// team.
    /// </summary>
    public partial class AmazonHoneycodeClient : AmazonServiceClient, IAmazonHoneycode
    {
        private static IServiceMetadata serviceMetadata = new AmazonHoneycodeMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonHoneycodeClient with the credentials loaded from the application's
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
        public AmazonHoneycodeClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonHoneycodeConfig()) { }

        /// <summary>
        /// Constructs AmazonHoneycodeClient with the credentials loaded from the application's
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
        public AmazonHoneycodeClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonHoneycodeConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonHoneycodeClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonHoneycodeClient Configuration Object</param>
        public AmazonHoneycodeClient(AmazonHoneycodeConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonHoneycodeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonHoneycodeClient(AWSCredentials credentials)
            : this(credentials, new AmazonHoneycodeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonHoneycodeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonHoneycodeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonHoneycodeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonHoneycodeClient with AWS Credentials and an
        /// AmazonHoneycodeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonHoneycodeClient Configuration Object</param>
        public AmazonHoneycodeClient(AWSCredentials credentials, AmazonHoneycodeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonHoneycodeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonHoneycodeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonHoneycodeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonHoneycodeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonHoneycodeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonHoneycodeConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonHoneycodeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonHoneycodeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonHoneycodeClient Configuration Object</param>
        public AmazonHoneycodeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonHoneycodeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonHoneycodeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonHoneycodeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonHoneycodeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonHoneycodeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonHoneycodeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonHoneycodeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonHoneycodeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonHoneycodeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonHoneycodeClient Configuration Object</param>
        public AmazonHoneycodeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonHoneycodeConfig clientConfig)
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


        #region  BatchCreateTableRows

        /// <summary>
        /// The BatchCreateTableRows API allows you to create one or more rows at the end of
        /// a table in a workbook. The API allows you to specify the values to set in some or
        /// all of the columns in the new rows. 
        /// 
        ///  
        /// <para>
        ///  If a column is not explicitly set in a specific row, then the column level formula
        /// specified in the table will be applied to the new row. If there is no column level
        /// formula but the last row of the table has a formula, then that formula will be copied
        /// down to the new row. If there is no column level formula and no formula in the last
        /// row of the table, then that column will be left blank for the new rows. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateTableRows service method.</param>
        /// 
        /// <returns>The response from the BatchCreateTableRows service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceQuotaExceededException">
        /// The request caused service quota to be breached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchCreateTableRows">REST API Reference for BatchCreateTableRows Operation</seealso>
        public virtual BatchCreateTableRowsResponse BatchCreateTableRows(BatchCreateTableRowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateTableRowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateTableRowsResponseUnmarshaller.Instance;

            return Invoke<BatchCreateTableRowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateTableRows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateTableRows operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateTableRows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchCreateTableRows">REST API Reference for BatchCreateTableRows Operation</seealso>
        public virtual IAsyncResult BeginBatchCreateTableRows(BatchCreateTableRowsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateTableRowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateTableRowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateTableRows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateTableRows.</param>
        /// 
        /// <returns>Returns a  BatchCreateTableRowsResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchCreateTableRows">REST API Reference for BatchCreateTableRows Operation</seealso>
        public virtual BatchCreateTableRowsResponse EndBatchCreateTableRows(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchCreateTableRowsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDeleteTableRows

        /// <summary>
        /// The BatchDeleteTableRows API allows you to delete one or more rows from a table in
        /// a workbook. You need to specify the ids of the rows that you want to delete from the
        /// table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTableRows service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteTableRows service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchDeleteTableRows">REST API Reference for BatchDeleteTableRows Operation</seealso>
        public virtual BatchDeleteTableRowsResponse BatchDeleteTableRows(BatchDeleteTableRowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteTableRowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteTableRowsResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteTableRowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteTableRows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTableRows operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteTableRows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchDeleteTableRows">REST API Reference for BatchDeleteTableRows Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteTableRows(BatchDeleteTableRowsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteTableRowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteTableRowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteTableRows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteTableRows.</param>
        /// 
        /// <returns>Returns a  BatchDeleteTableRowsResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchDeleteTableRows">REST API Reference for BatchDeleteTableRows Operation</seealso>
        public virtual BatchDeleteTableRowsResponse EndBatchDeleteTableRows(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteTableRowsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchUpdateTableRows

        /// <summary>
        /// The BatchUpdateTableRows API allows you to update one or more rows in a table in
        /// a workbook. 
        /// 
        ///  
        /// <para>
        ///  You can specify the values to set in some or all of the columns in the table for
        /// the specified rows. If a column is not explicitly specified in a particular row, then
        /// that column will not be updated for that row. To clear out the data in a specific
        /// cell, you need to set the value as an empty string (""). 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateTableRows service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateTableRows service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchUpdateTableRows">REST API Reference for BatchUpdateTableRows Operation</seealso>
        public virtual BatchUpdateTableRowsResponse BatchUpdateTableRows(BatchUpdateTableRowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateTableRowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateTableRowsResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateTableRowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateTableRows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateTableRows operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateTableRows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchUpdateTableRows">REST API Reference for BatchUpdateTableRows Operation</seealso>
        public virtual IAsyncResult BeginBatchUpdateTableRows(BatchUpdateTableRowsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateTableRowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateTableRowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateTableRows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateTableRows.</param>
        /// 
        /// <returns>Returns a  BatchUpdateTableRowsResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchUpdateTableRows">REST API Reference for BatchUpdateTableRows Operation</seealso>
        public virtual BatchUpdateTableRowsResponse EndBatchUpdateTableRows(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchUpdateTableRowsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchUpsertTableRows

        /// <summary>
        /// The BatchUpsertTableRows API allows you to upsert one or more rows in a table. The
        /// upsert operation takes a filter expression as input and evaluates it to find matching
        /// rows on the destination table. If matching rows are found, it will update the cells
        /// in the matching rows to new values specified in the request. If no matching rows are
        /// found, a new row is added at the end of the table and the cells in that row are set
        /// to the new values specified in the request. 
        /// 
        ///  
        /// <para>
        ///  You can specify the values to set in some or all of the columns in the table for
        /// the matching or newly appended rows. If a column is not explicitly specified for a
        /// particular row, then that column will not be updated for that row. To clear out the
        /// data in a specific cell, you need to set the value as an empty string (""). 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpsertTableRows service method.</param>
        /// 
        /// <returns>The response from the BatchUpsertTableRows service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceQuotaExceededException">
        /// The request caused service quota to be breached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchUpsertTableRows">REST API Reference for BatchUpsertTableRows Operation</seealso>
        public virtual BatchUpsertTableRowsResponse BatchUpsertTableRows(BatchUpsertTableRowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpsertTableRowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpsertTableRowsResponseUnmarshaller.Instance;

            return Invoke<BatchUpsertTableRowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpsertTableRows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpsertTableRows operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpsertTableRows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchUpsertTableRows">REST API Reference for BatchUpsertTableRows Operation</seealso>
        public virtual IAsyncResult BeginBatchUpsertTableRows(BatchUpsertTableRowsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpsertTableRowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpsertTableRowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpsertTableRows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpsertTableRows.</param>
        /// 
        /// <returns>Returns a  BatchUpsertTableRowsResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchUpsertTableRows">REST API Reference for BatchUpsertTableRows Operation</seealso>
        public virtual BatchUpsertTableRowsResponse EndBatchUpsertTableRows(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchUpsertTableRowsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTableDataImportJob

        /// <summary>
        /// The DescribeTableDataImportJob API allows you to retrieve the status and details
        /// of a table data import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableDataImportJob service method.</param>
        /// 
        /// <returns>The response from the DescribeTableDataImportJob service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/DescribeTableDataImportJob">REST API Reference for DescribeTableDataImportJob Operation</seealso>
        public virtual DescribeTableDataImportJobResponse DescribeTableDataImportJob(DescribeTableDataImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTableDataImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTableDataImportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeTableDataImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTableDataImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableDataImportJob operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTableDataImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/DescribeTableDataImportJob">REST API Reference for DescribeTableDataImportJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeTableDataImportJob(DescribeTableDataImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTableDataImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTableDataImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTableDataImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTableDataImportJob.</param>
        /// 
        /// <returns>Returns a  DescribeTableDataImportJobResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/DescribeTableDataImportJob">REST API Reference for DescribeTableDataImportJob Operation</seealso>
        public virtual DescribeTableDataImportJobResponse EndDescribeTableDataImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTableDataImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetScreenData

        /// <summary>
        /// The GetScreenData API allows retrieval of data from a screen in a Honeycode app.
        /// The API allows setting local variables in the screen to filter, sort or otherwise
        /// affect what will be displayed on the screen.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScreenData service method.</param>
        /// 
        /// <returns>The response from the GetScreenData service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/GetScreenData">REST API Reference for GetScreenData Operation</seealso>
        public virtual GetScreenDataResponse GetScreenData(GetScreenDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetScreenDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetScreenDataResponseUnmarshaller.Instance;

            return Invoke<GetScreenDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetScreenData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetScreenData operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetScreenData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/GetScreenData">REST API Reference for GetScreenData Operation</seealso>
        public virtual IAsyncResult BeginGetScreenData(GetScreenDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetScreenDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetScreenDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetScreenData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetScreenData.</param>
        /// 
        /// <returns>Returns a  GetScreenDataResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/GetScreenData">REST API Reference for GetScreenData Operation</seealso>
        public virtual GetScreenDataResponse EndGetScreenData(IAsyncResult asyncResult)
        {
            return EndInvoke<GetScreenDataResponse>(asyncResult);
        }

        #endregion
        
        #region  InvokeScreenAutomation

        /// <summary>
        /// The InvokeScreenAutomation API allows invoking an action defined in a screen in a
        /// Honeycode app. The API allows setting local variables, which can then be used in the
        /// automation being invoked. This allows automating the Honeycode app interactions to
        /// write, update or delete data in the workbook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeScreenAutomation service method.</param>
        /// 
        /// <returns>The response from the InvokeScreenAutomation service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.AutomationExecutionException">
        /// The automation execution did not end successfully.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.AutomationExecutionTimeoutException">
        /// The automation execution timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/InvokeScreenAutomation">REST API Reference for InvokeScreenAutomation Operation</seealso>
        public virtual InvokeScreenAutomationResponse InvokeScreenAutomation(InvokeScreenAutomationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeScreenAutomationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeScreenAutomationResponseUnmarshaller.Instance;

            return Invoke<InvokeScreenAutomationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeScreenAutomation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeScreenAutomation operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvokeScreenAutomation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/InvokeScreenAutomation">REST API Reference for InvokeScreenAutomation Operation</seealso>
        public virtual IAsyncResult BeginInvokeScreenAutomation(InvokeScreenAutomationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeScreenAutomationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeScreenAutomationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InvokeScreenAutomation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvokeScreenAutomation.</param>
        /// 
        /// <returns>Returns a  InvokeScreenAutomationResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/InvokeScreenAutomation">REST API Reference for InvokeScreenAutomation Operation</seealso>
        public virtual InvokeScreenAutomationResponse EndInvokeScreenAutomation(IAsyncResult asyncResult)
        {
            return EndInvoke<InvokeScreenAutomationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTableColumns

        /// <summary>
        /// The ListTableColumns API allows you to retrieve a list of all the columns in a table
        /// in a workbook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTableColumns service method.</param>
        /// 
        /// <returns>The response from the ListTableColumns service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/ListTableColumns">REST API Reference for ListTableColumns Operation</seealso>
        public virtual ListTableColumnsResponse ListTableColumns(ListTableColumnsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTableColumnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTableColumnsResponseUnmarshaller.Instance;

            return Invoke<ListTableColumnsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTableColumns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTableColumns operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTableColumns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/ListTableColumns">REST API Reference for ListTableColumns Operation</seealso>
        public virtual IAsyncResult BeginListTableColumns(ListTableColumnsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTableColumnsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTableColumnsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTableColumns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTableColumns.</param>
        /// 
        /// <returns>Returns a  ListTableColumnsResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/ListTableColumns">REST API Reference for ListTableColumns Operation</seealso>
        public virtual ListTableColumnsResponse EndListTableColumns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTableColumnsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTableRows

        /// <summary>
        /// The ListTableRows API allows you to retrieve a list of all the rows in a table in
        /// a workbook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTableRows service method.</param>
        /// 
        /// <returns>The response from the ListTableRows service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/ListTableRows">REST API Reference for ListTableRows Operation</seealso>
        public virtual ListTableRowsResponse ListTableRows(ListTableRowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTableRowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTableRowsResponseUnmarshaller.Instance;

            return Invoke<ListTableRowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTableRows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTableRows operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTableRows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/ListTableRows">REST API Reference for ListTableRows Operation</seealso>
        public virtual IAsyncResult BeginListTableRows(ListTableRowsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTableRowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTableRowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTableRows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTableRows.</param>
        /// 
        /// <returns>Returns a  ListTableRowsResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/ListTableRows">REST API Reference for ListTableRows Operation</seealso>
        public virtual ListTableRowsResponse EndListTableRows(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTableRowsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTables

        /// <summary>
        /// The ListTables API allows you to retrieve a list of all the tables in a workbook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTables service method.</param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/ListTables">REST API Reference for ListTables Operation</seealso>
        public virtual ListTablesResponse ListTables(ListTablesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTablesResponseUnmarshaller.Instance;

            return Invoke<ListTablesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTables operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTables
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/ListTables">REST API Reference for ListTables Operation</seealso>
        public virtual IAsyncResult BeginListTables(ListTablesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTablesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTables.</param>
        /// 
        /// <returns>Returns a  ListTablesResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/ListTables">REST API Reference for ListTables Operation</seealso>
        public virtual ListTablesResponse EndListTables(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTablesResponse>(asyncResult);
        }

        #endregion
        
        #region  QueryTableRows

        /// <summary>
        /// The QueryTableRows API allows you to use a filter formula to query for specific rows
        /// in a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryTableRows service method.</param>
        /// 
        /// <returns>The response from the QueryTableRows service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/QueryTableRows">REST API Reference for QueryTableRows Operation</seealso>
        public virtual QueryTableRowsResponse QueryTableRows(QueryTableRowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QueryTableRowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryTableRowsResponseUnmarshaller.Instance;

            return Invoke<QueryTableRowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the QueryTableRows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryTableRows operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryTableRows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/QueryTableRows">REST API Reference for QueryTableRows Operation</seealso>
        public virtual IAsyncResult BeginQueryTableRows(QueryTableRowsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QueryTableRowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryTableRowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  QueryTableRows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryTableRows.</param>
        /// 
        /// <returns>Returns a  QueryTableRowsResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/QueryTableRows">REST API Reference for QueryTableRows Operation</seealso>
        public virtual QueryTableRowsResponse EndQueryTableRows(IAsyncResult asyncResult)
        {
            return EndInvoke<QueryTableRowsResponse>(asyncResult);
        }

        #endregion
        
        #region  StartTableDataImportJob

        /// <summary>
        /// The StartTableDataImportJob API allows you to start an import job on a table. This
        /// API will only return the id of the job that was started. To find out the status of
        /// the import request, you need to call the DescribeTableDataImportJob API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTableDataImportJob service method.</param>
        /// 
        /// <returns>The response from the StartTableDataImportJob service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/StartTableDataImportJob">REST API Reference for StartTableDataImportJob Operation</seealso>
        public virtual StartTableDataImportJobResponse StartTableDataImportJob(StartTableDataImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTableDataImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTableDataImportJobResponseUnmarshaller.Instance;

            return Invoke<StartTableDataImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTableDataImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTableDataImportJob operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTableDataImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/StartTableDataImportJob">REST API Reference for StartTableDataImportJob Operation</seealso>
        public virtual IAsyncResult BeginStartTableDataImportJob(StartTableDataImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTableDataImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTableDataImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTableDataImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTableDataImportJob.</param>
        /// 
        /// <returns>Returns a  StartTableDataImportJobResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/StartTableDataImportJob">REST API Reference for StartTableDataImportJob Operation</seealso>
        public virtual StartTableDataImportJobResponse EndStartTableDataImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTableDataImportJobResponse>(asyncResult);
        }

        #endregion
        
    }
}