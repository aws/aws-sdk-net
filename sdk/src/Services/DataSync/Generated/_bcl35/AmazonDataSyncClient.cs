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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.DataSync.Model;
using Amazon.DataSync.Model.Internal.MarshallTransformations;
using Amazon.DataSync.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.DataSync
{
    /// <summary>
    /// <para>Implementation for accessing DataSync</para>
    ///
    /// DataSync 
    /// <para>
    /// DataSync is an online data movement service that simplifies data migration and helps
    /// you quickly, easily, and securely transfer your file or object data to, from, and
    /// between Amazon Web Services storage services.
    /// </para>
    ///  
    /// <para>
    /// This API interface reference includes documentation for using DataSync programmatically.
    /// For complete information, see the <i> <a href="https://docs.aws.amazon.com/datasync/latest/userguide/what-is-datasync.html">DataSync
    /// User Guide</a> </i>.
    /// </para>
    /// </summary>
    public partial class AmazonDataSyncClient : AmazonServiceClient, IAmazonDataSync
    {
        private static IServiceMetadata serviceMetadata = new AmazonDataSyncMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IDataSyncPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDataSyncPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DataSyncPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonDataSyncClient with the credentials loaded from the application's
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
        public AmazonDataSyncClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDataSyncConfig()) { }

        /// <summary>
        /// Constructs AmazonDataSyncClient with the credentials loaded from the application's
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
        public AmazonDataSyncClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDataSyncConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDataSyncClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDataSyncClient Configuration Object</param>
        public AmazonDataSyncClient(AmazonDataSyncConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDataSyncClient(AWSCredentials credentials)
            : this(credentials, new AmazonDataSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataSyncClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDataSyncConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Credentials and an
        /// AmazonDataSyncClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDataSyncClient Configuration Object</param>
        public AmazonDataSyncClient(AWSCredentials credentials, AmazonDataSyncConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDataSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDataSyncConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataSyncClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDataSyncClient Configuration Object</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDataSyncConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataSyncConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataSyncClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDataSyncClient Configuration Object</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDataSyncConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDataSyncEndpointResolver());
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


        #region  CancelTaskExecution

        /// <summary>
        /// Stops an DataSync task execution that's in progress. The transfer of some files are
        /// abruptly interrupted. File contents that're transferred to the destination might be
        /// incomplete or inconsistent with the source files.
        /// 
        ///  
        /// <para>
        /// However, if you start a new task execution using the same task and allow it to finish,
        /// file content on the destination will be complete and consistent. This applies to other
        /// unexpected failures that interrupt a task execution. In all of these cases, DataSync
        /// successfully completes the transfer when you start the next task execution.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelTaskExecution service method.</param>
        /// 
        /// <returns>The response from the CancelTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CancelTaskExecution">REST API Reference for CancelTaskExecution Operation</seealso>
        public virtual CancelTaskExecutionResponse CancelTaskExecution(CancelTaskExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTaskExecutionResponseUnmarshaller.Instance;

            return Invoke<CancelTaskExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelTaskExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelTaskExecution operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelTaskExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CancelTaskExecution">REST API Reference for CancelTaskExecution Operation</seealso>
        public virtual IAsyncResult BeginCancelTaskExecution(CancelTaskExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTaskExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelTaskExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelTaskExecution.</param>
        /// 
        /// <returns>Returns a  CancelTaskExecutionResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CancelTaskExecution">REST API Reference for CancelTaskExecution Operation</seealso>
        public virtual CancelTaskExecutionResponse EndCancelTaskExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelTaskExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAgent

        /// <summary>
        /// Activates an DataSync agent that you deploy in your storage environment. The activation
        /// process associates the agent with your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// If you haven't deployed an agent yet, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/do-i-need-datasync-agent.html">Do
        /// I need a DataSync agent?</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgent service method.</param>
        /// 
        /// <returns>The response from the CreateAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateAgent">REST API Reference for CreateAgent Operation</seealso>
        public virtual CreateAgentResponse CreateAgent(CreateAgentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentResponseUnmarshaller.Instance;

            return Invoke<CreateAgentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAgent operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateAgent">REST API Reference for CreateAgent Operation</seealso>
        public virtual IAsyncResult BeginCreateAgent(CreateAgentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAgent.</param>
        /// 
        /// <returns>Returns a  CreateAgentResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateAgent">REST API Reference for CreateAgent Operation</seealso>
        public virtual CreateAgentResponse EndCreateAgent(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAgentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLocationAzureBlob

        /// <summary>
        /// Creates a transfer <i>location</i> for a Microsoft Azure Blob Storage container. DataSync
        /// can use this location as a transfer source or destination. You can make transfers
        /// with or without a <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#azure-blob-creating-agent">DataSync
        /// agent</a> that connects to your container.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure you know <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#azure-blob-access">how
        /// DataSync accesses Azure Blob Storage</a> and works with <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#azure-blob-access-tiers">access
        /// tiers</a> and <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#blob-types">blob
        /// types</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationAzureBlob service method.</param>
        /// 
        /// <returns>The response from the CreateLocationAzureBlob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationAzureBlob">REST API Reference for CreateLocationAzureBlob Operation</seealso>
        public virtual CreateLocationAzureBlobResponse CreateLocationAzureBlob(CreateLocationAzureBlobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationAzureBlobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationAzureBlobResponseUnmarshaller.Instance;

            return Invoke<CreateLocationAzureBlobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLocationAzureBlob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationAzureBlob operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLocationAzureBlob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationAzureBlob">REST API Reference for CreateLocationAzureBlob Operation</seealso>
        public virtual IAsyncResult BeginCreateLocationAzureBlob(CreateLocationAzureBlobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationAzureBlobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationAzureBlobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLocationAzureBlob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLocationAzureBlob.</param>
        /// 
        /// <returns>Returns a  CreateLocationAzureBlobResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationAzureBlob">REST API Reference for CreateLocationAzureBlob Operation</seealso>
        public virtual CreateLocationAzureBlobResponse EndCreateLocationAzureBlob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLocationAzureBlobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLocationEfs

        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon EFS file system. DataSync can use
        /// this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-efs-location.html#create-efs-location-access">accesses
        /// Amazon EFS file systems</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationEfs service method.</param>
        /// 
        /// <returns>The response from the CreateLocationEfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationEfs">REST API Reference for CreateLocationEfs Operation</seealso>
        public virtual CreateLocationEfsResponse CreateLocationEfs(CreateLocationEfsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationEfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationEfsResponseUnmarshaller.Instance;

            return Invoke<CreateLocationEfsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLocationEfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationEfs operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLocationEfs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationEfs">REST API Reference for CreateLocationEfs Operation</seealso>
        public virtual IAsyncResult BeginCreateLocationEfs(CreateLocationEfsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationEfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationEfsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLocationEfs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLocationEfs.</param>
        /// 
        /// <returns>Returns a  CreateLocationEfsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationEfs">REST API Reference for CreateLocationEfs Operation</seealso>
        public virtual CreateLocationEfsResponse EndCreateLocationEfs(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLocationEfsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLocationFsxLustre

        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon FSx for Lustre file system. DataSync
        /// can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-lustre-location.html#create-lustre-location-access">accesses
        /// FSx for Lustre file systems</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxLustre service method.</param>
        /// 
        /// <returns>The response from the CreateLocationFsxLustre service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxLustre">REST API Reference for CreateLocationFsxLustre Operation</seealso>
        public virtual CreateLocationFsxLustreResponse CreateLocationFsxLustre(CreateLocationFsxLustreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationFsxLustreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationFsxLustreResponseUnmarshaller.Instance;

            return Invoke<CreateLocationFsxLustreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLocationFsxLustre operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxLustre operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLocationFsxLustre
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxLustre">REST API Reference for CreateLocationFsxLustre Operation</seealso>
        public virtual IAsyncResult BeginCreateLocationFsxLustre(CreateLocationFsxLustreRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationFsxLustreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationFsxLustreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLocationFsxLustre operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLocationFsxLustre.</param>
        /// 
        /// <returns>Returns a  CreateLocationFsxLustreResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxLustre">REST API Reference for CreateLocationFsxLustre Operation</seealso>
        public virtual CreateLocationFsxLustreResponse EndCreateLocationFsxLustre(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLocationFsxLustreResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLocationFsxOntap

        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon FSx for NetApp ONTAP file system.
        /// DataSync can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-ontap-location.html#create-ontap-location-access">accesses
        /// FSx for ONTAP file systems</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxOntap service method.</param>
        /// 
        /// <returns>The response from the CreateLocationFsxOntap service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxOntap">REST API Reference for CreateLocationFsxOntap Operation</seealso>
        public virtual CreateLocationFsxOntapResponse CreateLocationFsxOntap(CreateLocationFsxOntapRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationFsxOntapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationFsxOntapResponseUnmarshaller.Instance;

            return Invoke<CreateLocationFsxOntapResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLocationFsxOntap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxOntap operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLocationFsxOntap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxOntap">REST API Reference for CreateLocationFsxOntap Operation</seealso>
        public virtual IAsyncResult BeginCreateLocationFsxOntap(CreateLocationFsxOntapRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationFsxOntapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationFsxOntapResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLocationFsxOntap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLocationFsxOntap.</param>
        /// 
        /// <returns>Returns a  CreateLocationFsxOntapResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxOntap">REST API Reference for CreateLocationFsxOntap Operation</seealso>
        public virtual CreateLocationFsxOntapResponse EndCreateLocationFsxOntap(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLocationFsxOntapResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLocationFsxOpenZfs

        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon FSx for OpenZFS file system. DataSync
        /// can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-openzfs-location.html#create-openzfs-access">accesses
        /// FSx for OpenZFS file systems</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Request parameters related to <c>SMB</c> aren't supported with the <c>CreateLocationFsxOpenZfs</c>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxOpenZfs service method.</param>
        /// 
        /// <returns>The response from the CreateLocationFsxOpenZfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxOpenZfs">REST API Reference for CreateLocationFsxOpenZfs Operation</seealso>
        public virtual CreateLocationFsxOpenZfsResponse CreateLocationFsxOpenZfs(CreateLocationFsxOpenZfsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationFsxOpenZfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationFsxOpenZfsResponseUnmarshaller.Instance;

            return Invoke<CreateLocationFsxOpenZfsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLocationFsxOpenZfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxOpenZfs operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLocationFsxOpenZfs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxOpenZfs">REST API Reference for CreateLocationFsxOpenZfs Operation</seealso>
        public virtual IAsyncResult BeginCreateLocationFsxOpenZfs(CreateLocationFsxOpenZfsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationFsxOpenZfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationFsxOpenZfsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLocationFsxOpenZfs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLocationFsxOpenZfs.</param>
        /// 
        /// <returns>Returns a  CreateLocationFsxOpenZfsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxOpenZfs">REST API Reference for CreateLocationFsxOpenZfs Operation</seealso>
        public virtual CreateLocationFsxOpenZfsResponse EndCreateLocationFsxOpenZfs(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLocationFsxOpenZfsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLocationFsxWindows

        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon FSx for Windows File Server file
        /// system. DataSync can use this location as a source or destination for transferring
        /// data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-fsx-location.html#create-fsx-location-access">accesses
        /// FSx for Windows File Server file systems</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxWindows service method.</param>
        /// 
        /// <returns>The response from the CreateLocationFsxWindows service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxWindows">REST API Reference for CreateLocationFsxWindows Operation</seealso>
        public virtual CreateLocationFsxWindowsResponse CreateLocationFsxWindows(CreateLocationFsxWindowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationFsxWindowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationFsxWindowsResponseUnmarshaller.Instance;

            return Invoke<CreateLocationFsxWindowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLocationFsxWindows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxWindows operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLocationFsxWindows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxWindows">REST API Reference for CreateLocationFsxWindows Operation</seealso>
        public virtual IAsyncResult BeginCreateLocationFsxWindows(CreateLocationFsxWindowsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationFsxWindowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationFsxWindowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLocationFsxWindows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLocationFsxWindows.</param>
        /// 
        /// <returns>Returns a  CreateLocationFsxWindowsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxWindows">REST API Reference for CreateLocationFsxWindows Operation</seealso>
        public virtual CreateLocationFsxWindowsResponse EndCreateLocationFsxWindows(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLocationFsxWindowsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLocationHdfs

        /// <summary>
        /// Creates a transfer <i>location</i> for a Hadoop Distributed File System (HDFS). DataSync
        /// can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-hdfs-location.html#accessing-hdfs">accesses
        /// HDFS clusters</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationHdfs service method.</param>
        /// 
        /// <returns>The response from the CreateLocationHdfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationHdfs">REST API Reference for CreateLocationHdfs Operation</seealso>
        public virtual CreateLocationHdfsResponse CreateLocationHdfs(CreateLocationHdfsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationHdfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationHdfsResponseUnmarshaller.Instance;

            return Invoke<CreateLocationHdfsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLocationHdfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationHdfs operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLocationHdfs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationHdfs">REST API Reference for CreateLocationHdfs Operation</seealso>
        public virtual IAsyncResult BeginCreateLocationHdfs(CreateLocationHdfsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationHdfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationHdfsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLocationHdfs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLocationHdfs.</param>
        /// 
        /// <returns>Returns a  CreateLocationHdfsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationHdfs">REST API Reference for CreateLocationHdfs Operation</seealso>
        public virtual CreateLocationHdfsResponse EndCreateLocationHdfs(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLocationHdfsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLocationNfs

        /// <summary>
        /// Creates a transfer <i>location</i> for a Network File System (NFS) file server. DataSync
        /// can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-nfs-location.html#accessing-nfs">accesses
        /// NFS file servers</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationNfs service method.</param>
        /// 
        /// <returns>The response from the CreateLocationNfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationNfs">REST API Reference for CreateLocationNfs Operation</seealso>
        public virtual CreateLocationNfsResponse CreateLocationNfs(CreateLocationNfsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationNfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationNfsResponseUnmarshaller.Instance;

            return Invoke<CreateLocationNfsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLocationNfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationNfs operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLocationNfs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationNfs">REST API Reference for CreateLocationNfs Operation</seealso>
        public virtual IAsyncResult BeginCreateLocationNfs(CreateLocationNfsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationNfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationNfsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLocationNfs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLocationNfs.</param>
        /// 
        /// <returns>Returns a  CreateLocationNfsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationNfs">REST API Reference for CreateLocationNfs Operation</seealso>
        public virtual CreateLocationNfsResponse EndCreateLocationNfs(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLocationNfsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLocationObjectStorage

        /// <summary>
        /// Creates a transfer <i>location</i> for an object storage system. DataSync can use
        /// this location as a source or destination for transferring data. You can make transfers
        /// with or without a <a href="https://docs.aws.amazon.com/datasync/latest/userguide/do-i-need-datasync-agent.html#when-agent-required">DataSync
        /// agent</a>.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-object-location.html#create-object-location-prerequisites">prerequisites</a>
        /// for DataSync to work with object storage systems.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationObjectStorage service method.</param>
        /// 
        /// <returns>The response from the CreateLocationObjectStorage service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationObjectStorage">REST API Reference for CreateLocationObjectStorage Operation</seealso>
        public virtual CreateLocationObjectStorageResponse CreateLocationObjectStorage(CreateLocationObjectStorageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationObjectStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationObjectStorageResponseUnmarshaller.Instance;

            return Invoke<CreateLocationObjectStorageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLocationObjectStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationObjectStorage operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLocationObjectStorage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationObjectStorage">REST API Reference for CreateLocationObjectStorage Operation</seealso>
        public virtual IAsyncResult BeginCreateLocationObjectStorage(CreateLocationObjectStorageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationObjectStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationObjectStorageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLocationObjectStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLocationObjectStorage.</param>
        /// 
        /// <returns>Returns a  CreateLocationObjectStorageResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationObjectStorage">REST API Reference for CreateLocationObjectStorage Operation</seealso>
        public virtual CreateLocationObjectStorageResponse EndCreateLocationObjectStorage(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLocationObjectStorageResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLocationS3

        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon S3 bucket. DataSync can use this
        /// location as a source or destination for transferring data.
        /// 
        ///  <important> 
        /// <para>
        /// Before you begin, make sure that you read the following topics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#using-storage-classes">Storage
        /// class considerations with Amazon S3 locations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#create-s3-location-s3-requests">Evaluating
        /// S3 request costs when using DataSync</a> 
        /// </para>
        ///  </li> </ul> </important> 
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html">Configuring
        /// transfers with Amazon S3</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationS3 service method.</param>
        /// 
        /// <returns>The response from the CreateLocationS3 service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationS3">REST API Reference for CreateLocationS3 Operation</seealso>
        public virtual CreateLocationS3Response CreateLocationS3(CreateLocationS3Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationS3ResponseUnmarshaller.Instance;

            return Invoke<CreateLocationS3Response>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLocationS3 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationS3 operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLocationS3
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationS3">REST API Reference for CreateLocationS3 Operation</seealso>
        public virtual IAsyncResult BeginCreateLocationS3(CreateLocationS3Request request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationS3ResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLocationS3 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLocationS3.</param>
        /// 
        /// <returns>Returns a  CreateLocationS3Result from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationS3">REST API Reference for CreateLocationS3 Operation</seealso>
        public virtual CreateLocationS3Response EndCreateLocationS3(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLocationS3Response>(asyncResult);
        }

        #endregion
        
        #region  CreateLocationSmb

        /// <summary>
        /// Creates a transfer <i>location</i> for a Server Message Block (SMB) file server. DataSync
        /// can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync accesses SMB file servers.
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-smb-location.html#configuring-smb-permissions">Providing
        /// DataSync access to SMB file servers</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationSmb service method.</param>
        /// 
        /// <returns>The response from the CreateLocationSmb service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationSmb">REST API Reference for CreateLocationSmb Operation</seealso>
        public virtual CreateLocationSmbResponse CreateLocationSmb(CreateLocationSmbRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationSmbRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationSmbResponseUnmarshaller.Instance;

            return Invoke<CreateLocationSmbResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLocationSmb operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationSmb operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLocationSmb
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationSmb">REST API Reference for CreateLocationSmb Operation</seealso>
        public virtual IAsyncResult BeginCreateLocationSmb(CreateLocationSmbRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationSmbRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationSmbResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLocationSmb operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLocationSmb.</param>
        /// 
        /// <returns>Returns a  CreateLocationSmbResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationSmb">REST API Reference for CreateLocationSmb Operation</seealso>
        public virtual CreateLocationSmbResponse EndCreateLocationSmb(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLocationSmbResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTask

        /// <summary>
        /// Configures a <i>task</i>, which defines where and how DataSync transfers your data.
        /// 
        ///  
        /// <para>
        /// A task includes a source location, destination location, and transfer options (such
        /// as bandwidth limits, scheduling, and more).
        /// </para>
        ///  <important> 
        /// <para>
        /// If you're planning to transfer data to or from an Amazon S3 location, review <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#create-s3-location-s3-requests">how
        /// DataSync can affect your S3 request charges</a> and the <a href="http://aws.amazon.com/datasync/pricing/">DataSync
        /// pricing page</a> before you begin.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTask service method.</param>
        /// 
        /// <returns>The response from the CreateTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateTask">REST API Reference for CreateTask Operation</seealso>
        public virtual CreateTaskResponse CreateTask(CreateTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTaskResponseUnmarshaller.Instance;

            return Invoke<CreateTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTask operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateTask">REST API Reference for CreateTask Operation</seealso>
        public virtual IAsyncResult BeginCreateTask(CreateTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTask.</param>
        /// 
        /// <returns>Returns a  CreateTaskResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateTask">REST API Reference for CreateTask Operation</seealso>
        public virtual CreateTaskResponse EndCreateTask(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAgent

        /// <summary>
        /// Removes an DataSync agent resource from your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// Keep in mind that this operation (which can't be undone) doesn't remove the agent's
        /// virtual machine (VM) or Amazon EC2 instance from your storage environment. For next
        /// steps, you can delete the VM or instance from your storage environment or reuse it
        /// to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/activate-agent.html">activate
        /// a new agent</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgent service method.</param>
        /// 
        /// <returns>The response from the DeleteAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteAgent">REST API Reference for DeleteAgent Operation</seealso>
        public virtual DeleteAgentResponse DeleteAgent(DeleteAgentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentResponseUnmarshaller.Instance;

            return Invoke<DeleteAgentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgent operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteAgent">REST API Reference for DeleteAgent Operation</seealso>
        public virtual IAsyncResult BeginDeleteAgent(DeleteAgentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAgent.</param>
        /// 
        /// <returns>Returns a  DeleteAgentResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteAgent">REST API Reference for DeleteAgent Operation</seealso>
        public virtual DeleteAgentResponse EndDeleteAgent(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAgentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLocation

        /// <summary>
        /// Deletes a transfer location resource from DataSync.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLocation service method.</param>
        /// 
        /// <returns>The response from the DeleteLocation service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteLocation">REST API Reference for DeleteLocation Operation</seealso>
        public virtual DeleteLocationResponse DeleteLocation(DeleteLocationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLocationResponseUnmarshaller.Instance;

            return Invoke<DeleteLocationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLocation operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteLocation">REST API Reference for DeleteLocation Operation</seealso>
        public virtual IAsyncResult BeginDeleteLocation(DeleteLocationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLocationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLocation.</param>
        /// 
        /// <returns>Returns a  DeleteLocationResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteLocation">REST API Reference for DeleteLocation Operation</seealso>
        public virtual DeleteLocationResponse EndDeleteLocation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLocationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTask

        /// <summary>
        /// Deletes a transfer task resource from DataSync.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTask service method.</param>
        /// 
        /// <returns>The response from the DeleteTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteTask">REST API Reference for DeleteTask Operation</seealso>
        public virtual DeleteTaskResponse DeleteTask(DeleteTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTaskResponseUnmarshaller.Instance;

            return Invoke<DeleteTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTask operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteTask">REST API Reference for DeleteTask Operation</seealso>
        public virtual IAsyncResult BeginDeleteTask(DeleteTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTask.</param>
        /// 
        /// <returns>Returns a  DeleteTaskResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteTask">REST API Reference for DeleteTask Operation</seealso>
        public virtual DeleteTaskResponse EndDeleteTask(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAgent

        /// <summary>
        /// Returns information about an DataSync agent, such as its name, service endpoint type,
        /// and status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgent service method.</param>
        /// 
        /// <returns>The response from the DescribeAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeAgent">REST API Reference for DescribeAgent Operation</seealso>
        public virtual DescribeAgentResponse DescribeAgent(DescribeAgentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAgentResponseUnmarshaller.Instance;

            return Invoke<DescribeAgentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgent operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeAgent">REST API Reference for DescribeAgent Operation</seealso>
        public virtual IAsyncResult BeginDescribeAgent(DescribeAgentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAgentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAgent.</param>
        /// 
        /// <returns>Returns a  DescribeAgentResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeAgent">REST API Reference for DescribeAgent Operation</seealso>
        public virtual DescribeAgentResponse EndDescribeAgent(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAgentResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLocationAzureBlob

        /// <summary>
        /// Provides details about how an DataSync transfer location for Microsoft Azure Blob
        /// Storage is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationAzureBlob service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationAzureBlob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationAzureBlob">REST API Reference for DescribeLocationAzureBlob Operation</seealso>
        public virtual DescribeLocationAzureBlobResponse DescribeLocationAzureBlob(DescribeLocationAzureBlobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLocationAzureBlobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationAzureBlobResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationAzureBlobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocationAzureBlob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationAzureBlob operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocationAzureBlob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationAzureBlob">REST API Reference for DescribeLocationAzureBlob Operation</seealso>
        public virtual IAsyncResult BeginDescribeLocationAzureBlob(DescribeLocationAzureBlobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLocationAzureBlobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationAzureBlobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLocationAzureBlob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocationAzureBlob.</param>
        /// 
        /// <returns>Returns a  DescribeLocationAzureBlobResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationAzureBlob">REST API Reference for DescribeLocationAzureBlob Operation</seealso>
        public virtual DescribeLocationAzureBlobResponse EndDescribeLocationAzureBlob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLocationAzureBlobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLocationEfs

        /// <summary>
        /// Provides details about how an DataSync transfer location for an Amazon EFS file system
        /// is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationEfs service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationEfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationEfs">REST API Reference for DescribeLocationEfs Operation</seealso>
        public virtual DescribeLocationEfsResponse DescribeLocationEfs(DescribeLocationEfsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLocationEfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationEfsResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationEfsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocationEfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationEfs operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocationEfs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationEfs">REST API Reference for DescribeLocationEfs Operation</seealso>
        public virtual IAsyncResult BeginDescribeLocationEfs(DescribeLocationEfsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLocationEfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationEfsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLocationEfs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocationEfs.</param>
        /// 
        /// <returns>Returns a  DescribeLocationEfsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationEfs">REST API Reference for DescribeLocationEfs Operation</seealso>
        public virtual DescribeLocationEfsResponse EndDescribeLocationEfs(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLocationEfsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLocationFsxLustre

        /// <summary>
        /// Provides details about how an DataSync transfer location for an Amazon FSx for Lustre
        /// file system is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxLustre service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationFsxLustre service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxLustre">REST API Reference for DescribeLocationFsxLustre Operation</seealso>
        public virtual DescribeLocationFsxLustreResponse DescribeLocationFsxLustre(DescribeLocationFsxLustreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLocationFsxLustreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationFsxLustreResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationFsxLustreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocationFsxLustre operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxLustre operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocationFsxLustre
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxLustre">REST API Reference for DescribeLocationFsxLustre Operation</seealso>
        public virtual IAsyncResult BeginDescribeLocationFsxLustre(DescribeLocationFsxLustreRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLocationFsxLustreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationFsxLustreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLocationFsxLustre operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocationFsxLustre.</param>
        /// 
        /// <returns>Returns a  DescribeLocationFsxLustreResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxLustre">REST API Reference for DescribeLocationFsxLustre Operation</seealso>
        public virtual DescribeLocationFsxLustreResponse EndDescribeLocationFsxLustre(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLocationFsxLustreResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLocationFsxOntap

        /// <summary>
        /// Provides details about how an DataSync transfer location for an Amazon FSx for NetApp
        /// ONTAP file system is configured.
        /// 
        ///  <note> 
        /// <para>
        /// If your location uses SMB, the <c>DescribeLocationFsxOntap</c> operation doesn't actually
        /// return a <c>Password</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxOntap service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationFsxOntap service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxOntap">REST API Reference for DescribeLocationFsxOntap Operation</seealso>
        public virtual DescribeLocationFsxOntapResponse DescribeLocationFsxOntap(DescribeLocationFsxOntapRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLocationFsxOntapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationFsxOntapResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationFsxOntapResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocationFsxOntap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxOntap operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocationFsxOntap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxOntap">REST API Reference for DescribeLocationFsxOntap Operation</seealso>
        public virtual IAsyncResult BeginDescribeLocationFsxOntap(DescribeLocationFsxOntapRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLocationFsxOntapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationFsxOntapResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLocationFsxOntap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocationFsxOntap.</param>
        /// 
        /// <returns>Returns a  DescribeLocationFsxOntapResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxOntap">REST API Reference for DescribeLocationFsxOntap Operation</seealso>
        public virtual DescribeLocationFsxOntapResponse EndDescribeLocationFsxOntap(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLocationFsxOntapResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLocationFsxOpenZfs

        /// <summary>
        /// Provides details about how an DataSync transfer location for an Amazon FSx for OpenZFS
        /// file system is configured.
        /// 
        ///  <note> 
        /// <para>
        /// Response elements related to <c>SMB</c> aren't supported with the <c>DescribeLocationFsxOpenZfs</c>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxOpenZfs service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationFsxOpenZfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxOpenZfs">REST API Reference for DescribeLocationFsxOpenZfs Operation</seealso>
        public virtual DescribeLocationFsxOpenZfsResponse DescribeLocationFsxOpenZfs(DescribeLocationFsxOpenZfsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLocationFsxOpenZfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationFsxOpenZfsResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationFsxOpenZfsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocationFsxOpenZfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxOpenZfs operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocationFsxOpenZfs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxOpenZfs">REST API Reference for DescribeLocationFsxOpenZfs Operation</seealso>
        public virtual IAsyncResult BeginDescribeLocationFsxOpenZfs(DescribeLocationFsxOpenZfsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLocationFsxOpenZfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationFsxOpenZfsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLocationFsxOpenZfs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocationFsxOpenZfs.</param>
        /// 
        /// <returns>Returns a  DescribeLocationFsxOpenZfsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxOpenZfs">REST API Reference for DescribeLocationFsxOpenZfs Operation</seealso>
        public virtual DescribeLocationFsxOpenZfsResponse EndDescribeLocationFsxOpenZfs(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLocationFsxOpenZfsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLocationFsxWindows

        /// <summary>
        /// Provides details about how an DataSync transfer location for an Amazon FSx for Windows
        /// File Server file system is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxWindows service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationFsxWindows service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxWindows">REST API Reference for DescribeLocationFsxWindows Operation</seealso>
        public virtual DescribeLocationFsxWindowsResponse DescribeLocationFsxWindows(DescribeLocationFsxWindowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLocationFsxWindowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationFsxWindowsResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationFsxWindowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocationFsxWindows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxWindows operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocationFsxWindows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxWindows">REST API Reference for DescribeLocationFsxWindows Operation</seealso>
        public virtual IAsyncResult BeginDescribeLocationFsxWindows(DescribeLocationFsxWindowsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLocationFsxWindowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationFsxWindowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLocationFsxWindows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocationFsxWindows.</param>
        /// 
        /// <returns>Returns a  DescribeLocationFsxWindowsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxWindows">REST API Reference for DescribeLocationFsxWindows Operation</seealso>
        public virtual DescribeLocationFsxWindowsResponse EndDescribeLocationFsxWindows(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLocationFsxWindowsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLocationHdfs

        /// <summary>
        /// Provides details about how an DataSync transfer location for a Hadoop Distributed
        /// File System (HDFS) is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationHdfs service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationHdfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationHdfs">REST API Reference for DescribeLocationHdfs Operation</seealso>
        public virtual DescribeLocationHdfsResponse DescribeLocationHdfs(DescribeLocationHdfsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLocationHdfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationHdfsResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationHdfsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocationHdfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationHdfs operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocationHdfs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationHdfs">REST API Reference for DescribeLocationHdfs Operation</seealso>
        public virtual IAsyncResult BeginDescribeLocationHdfs(DescribeLocationHdfsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLocationHdfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationHdfsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLocationHdfs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocationHdfs.</param>
        /// 
        /// <returns>Returns a  DescribeLocationHdfsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationHdfs">REST API Reference for DescribeLocationHdfs Operation</seealso>
        public virtual DescribeLocationHdfsResponse EndDescribeLocationHdfs(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLocationHdfsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLocationNfs

        /// <summary>
        /// Provides details about how an DataSync transfer location for a Network File System
        /// (NFS) file server is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationNfs service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationNfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationNfs">REST API Reference for DescribeLocationNfs Operation</seealso>
        public virtual DescribeLocationNfsResponse DescribeLocationNfs(DescribeLocationNfsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLocationNfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationNfsResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationNfsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocationNfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationNfs operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocationNfs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationNfs">REST API Reference for DescribeLocationNfs Operation</seealso>
        public virtual IAsyncResult BeginDescribeLocationNfs(DescribeLocationNfsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLocationNfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationNfsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLocationNfs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocationNfs.</param>
        /// 
        /// <returns>Returns a  DescribeLocationNfsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationNfs">REST API Reference for DescribeLocationNfs Operation</seealso>
        public virtual DescribeLocationNfsResponse EndDescribeLocationNfs(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLocationNfsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLocationObjectStorage

        /// <summary>
        /// Provides details about how an DataSync transfer location for an object storage system
        /// is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationObjectStorage service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationObjectStorage service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationObjectStorage">REST API Reference for DescribeLocationObjectStorage Operation</seealso>
        public virtual DescribeLocationObjectStorageResponse DescribeLocationObjectStorage(DescribeLocationObjectStorageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLocationObjectStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationObjectStorageResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationObjectStorageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocationObjectStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationObjectStorage operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocationObjectStorage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationObjectStorage">REST API Reference for DescribeLocationObjectStorage Operation</seealso>
        public virtual IAsyncResult BeginDescribeLocationObjectStorage(DescribeLocationObjectStorageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLocationObjectStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationObjectStorageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLocationObjectStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocationObjectStorage.</param>
        /// 
        /// <returns>Returns a  DescribeLocationObjectStorageResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationObjectStorage">REST API Reference for DescribeLocationObjectStorage Operation</seealso>
        public virtual DescribeLocationObjectStorageResponse EndDescribeLocationObjectStorage(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLocationObjectStorageResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLocationS3

        /// <summary>
        /// Provides details about how an DataSync transfer location for an S3 bucket is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationS3 service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationS3 service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationS3">REST API Reference for DescribeLocationS3 Operation</seealso>
        public virtual DescribeLocationS3Response DescribeLocationS3(DescribeLocationS3Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLocationS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationS3ResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationS3Response>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocationS3 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationS3 operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocationS3
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationS3">REST API Reference for DescribeLocationS3 Operation</seealso>
        public virtual IAsyncResult BeginDescribeLocationS3(DescribeLocationS3Request request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLocationS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationS3ResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLocationS3 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocationS3.</param>
        /// 
        /// <returns>Returns a  DescribeLocationS3Result from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationS3">REST API Reference for DescribeLocationS3 Operation</seealso>
        public virtual DescribeLocationS3Response EndDescribeLocationS3(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLocationS3Response>(asyncResult);
        }

        #endregion
        
        #region  DescribeLocationSmb

        /// <summary>
        /// Provides details about how an DataSync transfer location for a Server Message Block
        /// (SMB) file server is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationSmb service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationSmb service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationSmb">REST API Reference for DescribeLocationSmb Operation</seealso>
        public virtual DescribeLocationSmbResponse DescribeLocationSmb(DescribeLocationSmbRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLocationSmbRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationSmbResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationSmbResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocationSmb operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationSmb operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocationSmb
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationSmb">REST API Reference for DescribeLocationSmb Operation</seealso>
        public virtual IAsyncResult BeginDescribeLocationSmb(DescribeLocationSmbRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLocationSmbRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationSmbResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLocationSmb operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocationSmb.</param>
        /// 
        /// <returns>Returns a  DescribeLocationSmbResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationSmb">REST API Reference for DescribeLocationSmb Operation</seealso>
        public virtual DescribeLocationSmbResponse EndDescribeLocationSmb(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLocationSmbResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTask

        /// <summary>
        /// Provides information about a <i>task</i>, which defines where and how DataSync transfers
        /// your data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTask service method.</param>
        /// 
        /// <returns>The response from the DescribeTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTask">REST API Reference for DescribeTask Operation</seealso>
        public virtual DescribeTaskResponse DescribeTask(DescribeTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskResponseUnmarshaller.Instance;

            return Invoke<DescribeTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTask operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTask">REST API Reference for DescribeTask Operation</seealso>
        public virtual IAsyncResult BeginDescribeTask(DescribeTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTask.</param>
        /// 
        /// <returns>Returns a  DescribeTaskResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTask">REST API Reference for DescribeTask Operation</seealso>
        public virtual DescribeTaskResponse EndDescribeTask(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTaskExecution

        /// <summary>
        /// Provides information about an execution of your DataSync task. You can use this operation
        /// to help monitor the progress of an ongoing data transfer or check the results of the
        /// transfer.
        /// 
        ///  <note> 
        /// <para>
        /// Some <c>DescribeTaskExecution</c> response elements are only relevant to a specific
        /// task mode. For information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html#task-mode-differences">Understanding
        /// task mode differences</a> and <a href="https://docs.aws.amazon.com/datasync/latest/userguide/transfer-performance-counters.html">Understanding
        /// data transfer performance counters</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTaskExecution service method.</param>
        /// 
        /// <returns>The response from the DescribeTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTaskExecution">REST API Reference for DescribeTaskExecution Operation</seealso>
        public virtual DescribeTaskExecutionResponse DescribeTaskExecution(DescribeTaskExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribeTaskExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTaskExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTaskExecution operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTaskExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTaskExecution">REST API Reference for DescribeTaskExecution Operation</seealso>
        public virtual IAsyncResult BeginDescribeTaskExecution(DescribeTaskExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTaskExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTaskExecution.</param>
        /// 
        /// <returns>Returns a  DescribeTaskExecutionResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTaskExecution">REST API Reference for DescribeTaskExecution Operation</seealso>
        public virtual DescribeTaskExecutionResponse EndDescribeTaskExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTaskExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAgents

        /// <summary>
        /// Returns a list of DataSync agents that belong to an Amazon Web Services account in
        /// the Amazon Web Services Region specified in the request.
        /// 
        ///  
        /// <para>
        /// With pagination, you can reduce the number of agents returned in a response. If you
        /// get a truncated list of agents in a response, the response contains a marker that
        /// you can specify in your next request to fetch the next page of agents.
        /// </para>
        ///  
        /// <para>
        ///  <c>ListAgents</c> is eventually consistent. This means the result of running the
        /// operation might not reflect that you just created or deleted an agent. For example,
        /// if you create an agent with <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_CreateAgent.html">CreateAgent</a>
        /// and then immediately run <c>ListAgents</c>, that agent might not show up in the list
        /// right away. In situations like this, you can always confirm whether an agent has been
        /// created (or deleted) by using <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_DescribeAgent.html">DescribeAgent</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgents service method.</param>
        /// 
        /// <returns>The response from the ListAgents service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListAgents">REST API Reference for ListAgents Operation</seealso>
        public virtual ListAgentsResponse ListAgents(ListAgentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentsResponseUnmarshaller.Instance;

            return Invoke<ListAgentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAgents operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAgents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListAgents">REST API Reference for ListAgents Operation</seealso>
        public virtual IAsyncResult BeginListAgents(ListAgentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAgents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAgents.</param>
        /// 
        /// <returns>Returns a  ListAgentsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListAgents">REST API Reference for ListAgents Operation</seealso>
        public virtual ListAgentsResponse EndListAgents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAgentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLocations

        /// <summary>
        /// Returns a list of source and destination locations.
        /// 
        ///  
        /// <para>
        /// If you have more locations than are returned in a response (that is, the response
        /// returns only a truncated list of your agents), the response contains a token that
        /// you can specify in your next request to fetch the next page of locations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLocations service method.</param>
        /// 
        /// <returns>The response from the ListLocations service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListLocations">REST API Reference for ListLocations Operation</seealso>
        public virtual ListLocationsResponse ListLocations(ListLocationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLocationsResponseUnmarshaller.Instance;

            return Invoke<ListLocationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLocations operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLocations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListLocations">REST API Reference for ListLocations Operation</seealso>
        public virtual IAsyncResult BeginListLocations(ListLocationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLocationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLocations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLocations.</param>
        /// 
        /// <returns>Returns a  ListLocationsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListLocations">REST API Reference for ListLocations Operation</seealso>
        public virtual ListLocationsResponse EndListLocations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLocationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns all the tags associated with an Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTaskExecutions

        /// <summary>
        /// Returns a list of executions for an DataSync transfer task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTaskExecutions service method.</param>
        /// 
        /// <returns>The response from the ListTaskExecutions service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTaskExecutions">REST API Reference for ListTaskExecutions Operation</seealso>
        public virtual ListTaskExecutionsResponse ListTaskExecutions(ListTaskExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTaskExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTaskExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListTaskExecutionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTaskExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTaskExecutions operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTaskExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTaskExecutions">REST API Reference for ListTaskExecutions Operation</seealso>
        public virtual IAsyncResult BeginListTaskExecutions(ListTaskExecutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTaskExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTaskExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTaskExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTaskExecutions.</param>
        /// 
        /// <returns>Returns a  ListTaskExecutionsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTaskExecutions">REST API Reference for ListTaskExecutions Operation</seealso>
        public virtual ListTaskExecutionsResponse EndListTaskExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTaskExecutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTasks

        /// <summary>
        /// Returns a list of the DataSync tasks you created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTasks service method.</param>
        /// 
        /// <returns>The response from the ListTasks service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTasks">REST API Reference for ListTasks Operation</seealso>
        public virtual ListTasksResponse ListTasks(ListTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTasksResponseUnmarshaller.Instance;

            return Invoke<ListTasksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTasks operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTasks">REST API Reference for ListTasks Operation</seealso>
        public virtual IAsyncResult BeginListTasks(ListTasksRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTasksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTasks.</param>
        /// 
        /// <returns>Returns a  ListTasksResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTasks">REST API Reference for ListTasks Operation</seealso>
        public virtual ListTasksResponse EndListTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTasksResponse>(asyncResult);
        }

        #endregion
        
        #region  StartTaskExecution

        /// <summary>
        /// Starts an DataSync transfer task. For each task, you can only run one task execution
        /// at a time.
        /// 
        ///  
        /// <para>
        /// There are several steps to a task execution. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/working-with-task-executions.html#understand-task-execution-statuses">Task
        /// execution statuses</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you're planning to transfer data to or from an Amazon S3 location, review <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#create-s3-location-s3-requests">how
        /// DataSync can affect your S3 request charges</a> and the <a href="http://aws.amazon.com/datasync/pricing/">DataSync
        /// pricing page</a> before you begin.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTaskExecution service method.</param>
        /// 
        /// <returns>The response from the StartTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/StartTaskExecution">REST API Reference for StartTaskExecution Operation</seealso>
        public virtual StartTaskExecutionResponse StartTaskExecution(StartTaskExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTaskExecutionResponseUnmarshaller.Instance;

            return Invoke<StartTaskExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTaskExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTaskExecution operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTaskExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/StartTaskExecution">REST API Reference for StartTaskExecution Operation</seealso>
        public virtual IAsyncResult BeginStartTaskExecution(StartTaskExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTaskExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTaskExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTaskExecution.</param>
        /// 
        /// <returns>Returns a  StartTaskExecutionResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/StartTaskExecution">REST API Reference for StartTaskExecution Operation</seealso>
        public virtual StartTaskExecutionResponse EndStartTaskExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTaskExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Applies a <i>tag</i> to an Amazon Web Services resource. Tags are key-value pairs
        /// that can help you manage, filter, and search for your resources.
        /// 
        ///  
        /// <para>
        /// These include DataSync resources, such as locations, tasks, and task executions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from an Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAgent

        /// <summary>
        /// Updates the name of an DataSync agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgent service method.</param>
        /// 
        /// <returns>The response from the UpdateAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateAgent">REST API Reference for UpdateAgent Operation</seealso>
        public virtual UpdateAgentResponse UpdateAgent(UpdateAgentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentResponseUnmarshaller.Instance;

            return Invoke<UpdateAgentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgent operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateAgent">REST API Reference for UpdateAgent Operation</seealso>
        public virtual IAsyncResult BeginUpdateAgent(UpdateAgentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAgent.</param>
        /// 
        /// <returns>Returns a  UpdateAgentResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateAgent">REST API Reference for UpdateAgent Operation</seealso>
        public virtual UpdateAgentResponse EndUpdateAgent(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAgentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLocationAzureBlob

        /// <summary>
        /// Modifies the following configurations of the Microsoft Azure Blob Storage transfer
        /// location that you're using with DataSync.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html">Configuring
        /// DataSync transfers with Azure Blob Storage</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationAzureBlob service method.</param>
        /// 
        /// <returns>The response from the UpdateLocationAzureBlob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationAzureBlob">REST API Reference for UpdateLocationAzureBlob Operation</seealso>
        public virtual UpdateLocationAzureBlobResponse UpdateLocationAzureBlob(UpdateLocationAzureBlobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLocationAzureBlobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationAzureBlobResponseUnmarshaller.Instance;

            return Invoke<UpdateLocationAzureBlobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLocationAzureBlob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationAzureBlob operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLocationAzureBlob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationAzureBlob">REST API Reference for UpdateLocationAzureBlob Operation</seealso>
        public virtual IAsyncResult BeginUpdateLocationAzureBlob(UpdateLocationAzureBlobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLocationAzureBlobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationAzureBlobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLocationAzureBlob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLocationAzureBlob.</param>
        /// 
        /// <returns>Returns a  UpdateLocationAzureBlobResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationAzureBlob">REST API Reference for UpdateLocationAzureBlob Operation</seealso>
        public virtual UpdateLocationAzureBlobResponse EndUpdateLocationAzureBlob(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLocationAzureBlobResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLocationEfs

        /// <summary>
        /// Modifies the following configuration parameters of the Amazon EFS transfer location
        /// that you're using with DataSync.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-efs-location.html">Configuring
        /// DataSync transfers with Amazon EFS</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationEfs service method.</param>
        /// 
        /// <returns>The response from the UpdateLocationEfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationEfs">REST API Reference for UpdateLocationEfs Operation</seealso>
        public virtual UpdateLocationEfsResponse UpdateLocationEfs(UpdateLocationEfsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLocationEfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationEfsResponseUnmarshaller.Instance;

            return Invoke<UpdateLocationEfsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLocationEfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationEfs operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLocationEfs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationEfs">REST API Reference for UpdateLocationEfs Operation</seealso>
        public virtual IAsyncResult BeginUpdateLocationEfs(UpdateLocationEfsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLocationEfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationEfsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLocationEfs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLocationEfs.</param>
        /// 
        /// <returns>Returns a  UpdateLocationEfsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationEfs">REST API Reference for UpdateLocationEfs Operation</seealso>
        public virtual UpdateLocationEfsResponse EndUpdateLocationEfs(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLocationEfsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLocationFsxLustre

        /// <summary>
        /// Modifies the following configuration parameters of the Amazon FSx for Lustre transfer
        /// location that you're using with DataSync.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-lustre-location.html">Configuring
        /// DataSync transfers with FSx for Lustre</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationFsxLustre service method.</param>
        /// 
        /// <returns>The response from the UpdateLocationFsxLustre service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationFsxLustre">REST API Reference for UpdateLocationFsxLustre Operation</seealso>
        public virtual UpdateLocationFsxLustreResponse UpdateLocationFsxLustre(UpdateLocationFsxLustreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLocationFsxLustreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationFsxLustreResponseUnmarshaller.Instance;

            return Invoke<UpdateLocationFsxLustreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLocationFsxLustre operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationFsxLustre operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLocationFsxLustre
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationFsxLustre">REST API Reference for UpdateLocationFsxLustre Operation</seealso>
        public virtual IAsyncResult BeginUpdateLocationFsxLustre(UpdateLocationFsxLustreRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLocationFsxLustreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationFsxLustreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLocationFsxLustre operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLocationFsxLustre.</param>
        /// 
        /// <returns>Returns a  UpdateLocationFsxLustreResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationFsxLustre">REST API Reference for UpdateLocationFsxLustre Operation</seealso>
        public virtual UpdateLocationFsxLustreResponse EndUpdateLocationFsxLustre(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLocationFsxLustreResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLocationFsxOntap

        /// <summary>
        /// Modifies the following configuration parameters of the Amazon FSx for NetApp ONTAP
        /// transfer location that you're using with DataSync.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-ontap-location.html">Configuring
        /// DataSync transfers with FSx for ONTAP</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationFsxOntap service method.</param>
        /// 
        /// <returns>The response from the UpdateLocationFsxOntap service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationFsxOntap">REST API Reference for UpdateLocationFsxOntap Operation</seealso>
        public virtual UpdateLocationFsxOntapResponse UpdateLocationFsxOntap(UpdateLocationFsxOntapRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLocationFsxOntapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationFsxOntapResponseUnmarshaller.Instance;

            return Invoke<UpdateLocationFsxOntapResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLocationFsxOntap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationFsxOntap operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLocationFsxOntap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationFsxOntap">REST API Reference for UpdateLocationFsxOntap Operation</seealso>
        public virtual IAsyncResult BeginUpdateLocationFsxOntap(UpdateLocationFsxOntapRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLocationFsxOntapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationFsxOntapResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLocationFsxOntap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLocationFsxOntap.</param>
        /// 
        /// <returns>Returns a  UpdateLocationFsxOntapResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationFsxOntap">REST API Reference for UpdateLocationFsxOntap Operation</seealso>
        public virtual UpdateLocationFsxOntapResponse EndUpdateLocationFsxOntap(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLocationFsxOntapResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLocationFsxOpenZfs

        /// <summary>
        /// Modifies the following configuration parameters of the Amazon FSx for OpenZFS transfer
        /// location that you're using with DataSync.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-openzfs-location.html">Configuring
        /// DataSync transfers with FSx for OpenZFS</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Request parameters related to <c>SMB</c> aren't supported with the <c>UpdateLocationFsxOpenZfs</c>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationFsxOpenZfs service method.</param>
        /// 
        /// <returns>The response from the UpdateLocationFsxOpenZfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationFsxOpenZfs">REST API Reference for UpdateLocationFsxOpenZfs Operation</seealso>
        public virtual UpdateLocationFsxOpenZfsResponse UpdateLocationFsxOpenZfs(UpdateLocationFsxOpenZfsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLocationFsxOpenZfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationFsxOpenZfsResponseUnmarshaller.Instance;

            return Invoke<UpdateLocationFsxOpenZfsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLocationFsxOpenZfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationFsxOpenZfs operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLocationFsxOpenZfs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationFsxOpenZfs">REST API Reference for UpdateLocationFsxOpenZfs Operation</seealso>
        public virtual IAsyncResult BeginUpdateLocationFsxOpenZfs(UpdateLocationFsxOpenZfsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLocationFsxOpenZfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationFsxOpenZfsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLocationFsxOpenZfs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLocationFsxOpenZfs.</param>
        /// 
        /// <returns>Returns a  UpdateLocationFsxOpenZfsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationFsxOpenZfs">REST API Reference for UpdateLocationFsxOpenZfs Operation</seealso>
        public virtual UpdateLocationFsxOpenZfsResponse EndUpdateLocationFsxOpenZfs(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLocationFsxOpenZfsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLocationFsxWindows

        /// <summary>
        /// Modifies the following configuration parameters of the Amazon FSx for Windows File
        /// Server transfer location that you're using with DataSync.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-fsx-location.html">Configuring
        /// DataSync transfers with FSx for Windows File Server</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationFsxWindows service method.</param>
        /// 
        /// <returns>The response from the UpdateLocationFsxWindows service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationFsxWindows">REST API Reference for UpdateLocationFsxWindows Operation</seealso>
        public virtual UpdateLocationFsxWindowsResponse UpdateLocationFsxWindows(UpdateLocationFsxWindowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLocationFsxWindowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationFsxWindowsResponseUnmarshaller.Instance;

            return Invoke<UpdateLocationFsxWindowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLocationFsxWindows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationFsxWindows operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLocationFsxWindows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationFsxWindows">REST API Reference for UpdateLocationFsxWindows Operation</seealso>
        public virtual IAsyncResult BeginUpdateLocationFsxWindows(UpdateLocationFsxWindowsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLocationFsxWindowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationFsxWindowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLocationFsxWindows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLocationFsxWindows.</param>
        /// 
        /// <returns>Returns a  UpdateLocationFsxWindowsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationFsxWindows">REST API Reference for UpdateLocationFsxWindows Operation</seealso>
        public virtual UpdateLocationFsxWindowsResponse EndUpdateLocationFsxWindows(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLocationFsxWindowsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLocationHdfs

        /// <summary>
        /// Modifies the following configuration parameters of the Hadoop Distributed File System
        /// (HDFS) transfer location that you're using with DataSync.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-hdfs-location.html">Configuring
        /// DataSync transfers with an HDFS cluster</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationHdfs service method.</param>
        /// 
        /// <returns>The response from the UpdateLocationHdfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationHdfs">REST API Reference for UpdateLocationHdfs Operation</seealso>
        public virtual UpdateLocationHdfsResponse UpdateLocationHdfs(UpdateLocationHdfsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLocationHdfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationHdfsResponseUnmarshaller.Instance;

            return Invoke<UpdateLocationHdfsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLocationHdfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationHdfs operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLocationHdfs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationHdfs">REST API Reference for UpdateLocationHdfs Operation</seealso>
        public virtual IAsyncResult BeginUpdateLocationHdfs(UpdateLocationHdfsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLocationHdfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationHdfsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLocationHdfs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLocationHdfs.</param>
        /// 
        /// <returns>Returns a  UpdateLocationHdfsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationHdfs">REST API Reference for UpdateLocationHdfs Operation</seealso>
        public virtual UpdateLocationHdfsResponse EndUpdateLocationHdfs(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLocationHdfsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLocationNfs

        /// <summary>
        /// Modifies the following configuration parameters of the Network File System (NFS) transfer
        /// location that you're using with DataSync.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-nfs-location.html">Configuring
        /// transfers with an NFS file server</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationNfs service method.</param>
        /// 
        /// <returns>The response from the UpdateLocationNfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationNfs">REST API Reference for UpdateLocationNfs Operation</seealso>
        public virtual UpdateLocationNfsResponse UpdateLocationNfs(UpdateLocationNfsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLocationNfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationNfsResponseUnmarshaller.Instance;

            return Invoke<UpdateLocationNfsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLocationNfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationNfs operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLocationNfs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationNfs">REST API Reference for UpdateLocationNfs Operation</seealso>
        public virtual IAsyncResult BeginUpdateLocationNfs(UpdateLocationNfsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLocationNfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationNfsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLocationNfs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLocationNfs.</param>
        /// 
        /// <returns>Returns a  UpdateLocationNfsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationNfs">REST API Reference for UpdateLocationNfs Operation</seealso>
        public virtual UpdateLocationNfsResponse EndUpdateLocationNfs(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLocationNfsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLocationObjectStorage

        /// <summary>
        /// Modifies the following configuration parameters of the object storage transfer location
        /// that you're using with DataSync.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-object-location.html">Configuring
        /// DataSync transfers with an object storage system</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationObjectStorage service method.</param>
        /// 
        /// <returns>The response from the UpdateLocationObjectStorage service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationObjectStorage">REST API Reference for UpdateLocationObjectStorage Operation</seealso>
        public virtual UpdateLocationObjectStorageResponse UpdateLocationObjectStorage(UpdateLocationObjectStorageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLocationObjectStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationObjectStorageResponseUnmarshaller.Instance;

            return Invoke<UpdateLocationObjectStorageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLocationObjectStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationObjectStorage operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLocationObjectStorage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationObjectStorage">REST API Reference for UpdateLocationObjectStorage Operation</seealso>
        public virtual IAsyncResult BeginUpdateLocationObjectStorage(UpdateLocationObjectStorageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLocationObjectStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationObjectStorageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLocationObjectStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLocationObjectStorage.</param>
        /// 
        /// <returns>Returns a  UpdateLocationObjectStorageResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationObjectStorage">REST API Reference for UpdateLocationObjectStorage Operation</seealso>
        public virtual UpdateLocationObjectStorageResponse EndUpdateLocationObjectStorage(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLocationObjectStorageResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLocationS3

        /// <summary>
        /// Modifies the following configuration parameters of the Amazon S3 transfer location
        /// that you're using with DataSync.
        /// 
        ///  <important> 
        /// <para>
        /// Before you begin, make sure that you read the following topics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#using-storage-classes">Storage
        /// class considerations with Amazon S3 locations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#create-s3-location-s3-requests">Evaluating
        /// S3 request costs when using DataSync</a> 
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationS3 service method.</param>
        /// 
        /// <returns>The response from the UpdateLocationS3 service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationS3">REST API Reference for UpdateLocationS3 Operation</seealso>
        public virtual UpdateLocationS3Response UpdateLocationS3(UpdateLocationS3Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLocationS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationS3ResponseUnmarshaller.Instance;

            return Invoke<UpdateLocationS3Response>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLocationS3 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationS3 operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLocationS3
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationS3">REST API Reference for UpdateLocationS3 Operation</seealso>
        public virtual IAsyncResult BeginUpdateLocationS3(UpdateLocationS3Request request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLocationS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationS3ResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLocationS3 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLocationS3.</param>
        /// 
        /// <returns>Returns a  UpdateLocationS3Result from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationS3">REST API Reference for UpdateLocationS3 Operation</seealso>
        public virtual UpdateLocationS3Response EndUpdateLocationS3(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLocationS3Response>(asyncResult);
        }

        #endregion
        
        #region  UpdateLocationSmb

        /// <summary>
        /// Modifies the following configuration parameters of the Server Message Block (SMB)
        /// transfer location that you're using with DataSync.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-smb-location.html">Configuring
        /// DataSync transfers with an SMB file server</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationSmb service method.</param>
        /// 
        /// <returns>The response from the UpdateLocationSmb service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationSmb">REST API Reference for UpdateLocationSmb Operation</seealso>
        public virtual UpdateLocationSmbResponse UpdateLocationSmb(UpdateLocationSmbRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLocationSmbRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationSmbResponseUnmarshaller.Instance;

            return Invoke<UpdateLocationSmbResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLocationSmb operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationSmb operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLocationSmb
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationSmb">REST API Reference for UpdateLocationSmb Operation</seealso>
        public virtual IAsyncResult BeginUpdateLocationSmb(UpdateLocationSmbRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLocationSmbRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationSmbResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLocationSmb operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLocationSmb.</param>
        /// 
        /// <returns>Returns a  UpdateLocationSmbResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationSmb">REST API Reference for UpdateLocationSmb Operation</seealso>
        public virtual UpdateLocationSmbResponse EndUpdateLocationSmb(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLocationSmbResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTask

        /// <summary>
        /// Updates the configuration of a <i>task</i>, which defines where and how DataSync transfers
        /// your data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTask service method.</param>
        /// 
        /// <returns>The response from the UpdateTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateTask">REST API Reference for UpdateTask Operation</seealso>
        public virtual UpdateTaskResponse UpdateTask(UpdateTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskResponseUnmarshaller.Instance;

            return Invoke<UpdateTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTask operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateTask">REST API Reference for UpdateTask Operation</seealso>
        public virtual IAsyncResult BeginUpdateTask(UpdateTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTask.</param>
        /// 
        /// <returns>Returns a  UpdateTaskResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateTask">REST API Reference for UpdateTask Operation</seealso>
        public virtual UpdateTaskResponse EndUpdateTask(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTaskExecution

        /// <summary>
        /// Updates the configuration of a running DataSync task execution.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, the only <c>Option</c> that you can modify with <c>UpdateTaskExecution</c>
        /// is <c> <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_Options.html#DataSync-Type-Options-BytesPerSecond">BytesPerSecond</a>
        /// </c>, which throttles bandwidth for a running or queued task execution.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTaskExecution service method.</param>
        /// 
        /// <returns>The response from the UpdateTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateTaskExecution">REST API Reference for UpdateTaskExecution Operation</seealso>
        public virtual UpdateTaskExecutionResponse UpdateTaskExecution(UpdateTaskExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskExecutionResponseUnmarshaller.Instance;

            return Invoke<UpdateTaskExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTaskExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTaskExecution operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTaskExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateTaskExecution">REST API Reference for UpdateTaskExecution Operation</seealso>
        public virtual IAsyncResult BeginUpdateTaskExecution(UpdateTaskExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTaskExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTaskExecution.</param>
        /// 
        /// <returns>Returns a  UpdateTaskExecutionResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateTaskExecution">REST API Reference for UpdateTaskExecution Operation</seealso>
        public virtual UpdateTaskExecutionResponse EndUpdateTaskExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTaskExecutionResponse>(asyncResult);
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
            var resolver = new AmazonDataSyncEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}