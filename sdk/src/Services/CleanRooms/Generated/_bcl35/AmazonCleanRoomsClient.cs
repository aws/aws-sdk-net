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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.CleanRooms.Model;
using Amazon.CleanRooms.Model.Internal.MarshallTransformations;
using Amazon.CleanRooms.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.CleanRooms
{
    /// <summary>
    /// <para>Implementation for accessing CleanRooms</para>
    ///
    /// Welcome to the <i>Clean Rooms API Reference</i>.
    /// 
    ///  
    /// <para>
    /// Clean Rooms is an Amazon Web Services service that helps multiple parties to join
    /// their data together in a secure collaboration workspace. In the collaboration, members
    /// who can run queries and jobs and receive results can get insights into the collective
    /// datasets without either party getting access to the other party's raw data.
    /// </para>
    ///  
    /// <para>
    /// To learn more about Clean Rooms concepts, procedures, and best practices, see the
    /// <a href="https://docs.aws.amazon.com/clean-rooms/latest/userguide/what-is.html">Clean
    /// Rooms User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// To learn more about SQL commands, functions, and conditions supported in Clean Rooms,
    /// see the <a href="https://docs.aws.amazon.com/clean-rooms/latest/sql-reference/sql-reference.html">Clean
    /// Rooms SQL Reference</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCleanRoomsClient : AmazonServiceClient, IAmazonCleanRooms
    {
        private static IServiceMetadata serviceMetadata = new AmazonCleanRoomsMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ICleanRoomsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICleanRoomsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CleanRoomsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonCleanRoomsClient with the credentials loaded from the application's
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
        public AmazonCleanRoomsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCleanRoomsConfig()) { }

        /// <summary>
        /// Constructs AmazonCleanRoomsClient with the credentials loaded from the application's
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
        public AmazonCleanRoomsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCleanRoomsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCleanRoomsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCleanRoomsClient Configuration Object</param>
        public AmazonCleanRoomsClient(AmazonCleanRoomsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonCleanRoomsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCleanRoomsClient(AWSCredentials credentials)
            : this(credentials, new AmazonCleanRoomsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCleanRoomsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCleanRoomsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsClient with AWS Credentials and an
        /// AmazonCleanRoomsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCleanRoomsClient Configuration Object</param>
        public AmazonCleanRoomsClient(AWSCredentials credentials, AmazonCleanRoomsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCleanRoomsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCleanRoomsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCleanRoomsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCleanRoomsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCleanRoomsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCleanRoomsClient Configuration Object</param>
        public AmazonCleanRoomsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCleanRoomsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCleanRoomsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCleanRoomsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCleanRoomsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCleanRoomsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCleanRoomsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCleanRoomsClient Configuration Object</param>
        public AmazonCleanRoomsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCleanRoomsConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCleanRoomsEndpointResolver());
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


        #region  BatchGetCollaborationAnalysisTemplate

        /// <summary>
        /// Retrieves multiple analysis templates within a collaboration by their Amazon Resource
        /// Names (ARNs).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCollaborationAnalysisTemplate service method.</param>
        /// 
        /// <returns>The response from the BatchGetCollaborationAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/BatchGetCollaborationAnalysisTemplate">REST API Reference for BatchGetCollaborationAnalysisTemplate Operation</seealso>
        public virtual BatchGetCollaborationAnalysisTemplateResponse BatchGetCollaborationAnalysisTemplate(BatchGetCollaborationAnalysisTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetCollaborationAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCollaborationAnalysisTemplateResponseUnmarshaller.Instance;

            return Invoke<BatchGetCollaborationAnalysisTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetCollaborationAnalysisTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCollaborationAnalysisTemplate operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetCollaborationAnalysisTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/BatchGetCollaborationAnalysisTemplate">REST API Reference for BatchGetCollaborationAnalysisTemplate Operation</seealso>
        public virtual IAsyncResult BeginBatchGetCollaborationAnalysisTemplate(BatchGetCollaborationAnalysisTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetCollaborationAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCollaborationAnalysisTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetCollaborationAnalysisTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetCollaborationAnalysisTemplate.</param>
        /// 
        /// <returns>Returns a  BatchGetCollaborationAnalysisTemplateResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/BatchGetCollaborationAnalysisTemplate">REST API Reference for BatchGetCollaborationAnalysisTemplate Operation</seealso>
        public virtual BatchGetCollaborationAnalysisTemplateResponse EndBatchGetCollaborationAnalysisTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetCollaborationAnalysisTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetSchema

        /// <summary>
        /// Retrieves multiple schemas by their identifiers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetSchema service method.</param>
        /// 
        /// <returns>The response from the BatchGetSchema service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/BatchGetSchema">REST API Reference for BatchGetSchema Operation</seealso>
        public virtual BatchGetSchemaResponse BatchGetSchema(BatchGetSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetSchemaResponseUnmarshaller.Instance;

            return Invoke<BatchGetSchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetSchema operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/BatchGetSchema">REST API Reference for BatchGetSchema Operation</seealso>
        public virtual IAsyncResult BeginBatchGetSchema(BatchGetSchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetSchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetSchema.</param>
        /// 
        /// <returns>Returns a  BatchGetSchemaResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/BatchGetSchema">REST API Reference for BatchGetSchema Operation</seealso>
        public virtual BatchGetSchemaResponse EndBatchGetSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetSchemaResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetSchemaAnalysisRule

        /// <summary>
        /// Retrieves multiple analysis rule schemas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetSchemaAnalysisRule service method.</param>
        /// 
        /// <returns>The response from the BatchGetSchemaAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/BatchGetSchemaAnalysisRule">REST API Reference for BatchGetSchemaAnalysisRule Operation</seealso>
        public virtual BatchGetSchemaAnalysisRuleResponse BatchGetSchemaAnalysisRule(BatchGetSchemaAnalysisRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetSchemaAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetSchemaAnalysisRuleResponseUnmarshaller.Instance;

            return Invoke<BatchGetSchemaAnalysisRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetSchemaAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetSchemaAnalysisRule operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetSchemaAnalysisRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/BatchGetSchemaAnalysisRule">REST API Reference for BatchGetSchemaAnalysisRule Operation</seealso>
        public virtual IAsyncResult BeginBatchGetSchemaAnalysisRule(BatchGetSchemaAnalysisRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetSchemaAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetSchemaAnalysisRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetSchemaAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetSchemaAnalysisRule.</param>
        /// 
        /// <returns>Returns a  BatchGetSchemaAnalysisRuleResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/BatchGetSchemaAnalysisRule">REST API Reference for BatchGetSchemaAnalysisRule Operation</seealso>
        public virtual BatchGetSchemaAnalysisRuleResponse EndBatchGetSchemaAnalysisRule(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetSchemaAnalysisRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAnalysisTemplate

        /// <summary>
        /// Creates a new analysis template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnalysisTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateAnalysisTemplate">REST API Reference for CreateAnalysisTemplate Operation</seealso>
        public virtual CreateAnalysisTemplateResponse CreateAnalysisTemplate(CreateAnalysisTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnalysisTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateAnalysisTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAnalysisTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAnalysisTemplate operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAnalysisTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateAnalysisTemplate">REST API Reference for CreateAnalysisTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreateAnalysisTemplate(CreateAnalysisTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnalysisTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAnalysisTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAnalysisTemplate.</param>
        /// 
        /// <returns>Returns a  CreateAnalysisTemplateResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateAnalysisTemplate">REST API Reference for CreateAnalysisTemplate Operation</seealso>
        public virtual CreateAnalysisTemplateResponse EndCreateAnalysisTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAnalysisTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCollaboration

        /// <summary>
        /// Creates a new collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCollaboration service method.</param>
        /// 
        /// <returns>The response from the CreateCollaboration service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateCollaboration">REST API Reference for CreateCollaboration Operation</seealso>
        public virtual CreateCollaborationResponse CreateCollaboration(CreateCollaborationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCollaborationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCollaborationResponseUnmarshaller.Instance;

            return Invoke<CreateCollaborationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCollaboration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCollaboration operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCollaboration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateCollaboration">REST API Reference for CreateCollaboration Operation</seealso>
        public virtual IAsyncResult BeginCreateCollaboration(CreateCollaborationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCollaborationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCollaborationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCollaboration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCollaboration.</param>
        /// 
        /// <returns>Returns a  CreateCollaborationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateCollaboration">REST API Reference for CreateCollaboration Operation</seealso>
        public virtual CreateCollaborationResponse EndCreateCollaboration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCollaborationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConfiguredAudienceModelAssociation

        /// <summary>
        /// Provides the details necessary to create a configured audience model association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredAudienceModelAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateConfiguredAudienceModelAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredAudienceModelAssociation">REST API Reference for CreateConfiguredAudienceModelAssociation Operation</seealso>
        public virtual CreateConfiguredAudienceModelAssociationResponse CreateConfiguredAudienceModelAssociation(CreateConfiguredAudienceModelAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfiguredAudienceModelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredAudienceModelAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateConfiguredAudienceModelAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfiguredAudienceModelAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredAudienceModelAssociation operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfiguredAudienceModelAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredAudienceModelAssociation">REST API Reference for CreateConfiguredAudienceModelAssociation Operation</seealso>
        public virtual IAsyncResult BeginCreateConfiguredAudienceModelAssociation(CreateConfiguredAudienceModelAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfiguredAudienceModelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredAudienceModelAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfiguredAudienceModelAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfiguredAudienceModelAssociation.</param>
        /// 
        /// <returns>Returns a  CreateConfiguredAudienceModelAssociationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredAudienceModelAssociation">REST API Reference for CreateConfiguredAudienceModelAssociation Operation</seealso>
        public virtual CreateConfiguredAudienceModelAssociationResponse EndCreateConfiguredAudienceModelAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConfiguredAudienceModelAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConfiguredTable

        /// <summary>
        /// Creates a new configured table resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTable service method.</param>
        /// 
        /// <returns>The response from the CreateConfiguredTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTable">REST API Reference for CreateConfiguredTable Operation</seealso>
        public virtual CreateConfiguredTableResponse CreateConfiguredTable(CreateConfiguredTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfiguredTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredTableResponseUnmarshaller.Instance;

            return Invoke<CreateConfiguredTableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfiguredTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTable operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfiguredTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTable">REST API Reference for CreateConfiguredTable Operation</seealso>
        public virtual IAsyncResult BeginCreateConfiguredTable(CreateConfiguredTableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfiguredTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredTableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfiguredTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfiguredTable.</param>
        /// 
        /// <returns>Returns a  CreateConfiguredTableResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTable">REST API Reference for CreateConfiguredTable Operation</seealso>
        public virtual CreateConfiguredTableResponse EndCreateConfiguredTable(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConfiguredTableResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConfiguredTableAnalysisRule

        /// <summary>
        /// Creates a new analysis rule for a configured table. Currently, only one analysis rule
        /// can be created for a given configured table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTableAnalysisRule service method.</param>
        /// 
        /// <returns>The response from the CreateConfiguredTableAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTableAnalysisRule">REST API Reference for CreateConfiguredTableAnalysisRule Operation</seealso>
        public virtual CreateConfiguredTableAnalysisRuleResponse CreateConfiguredTableAnalysisRule(CreateConfiguredTableAnalysisRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfiguredTableAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredTableAnalysisRuleResponseUnmarshaller.Instance;

            return Invoke<CreateConfiguredTableAnalysisRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfiguredTableAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTableAnalysisRule operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfiguredTableAnalysisRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTableAnalysisRule">REST API Reference for CreateConfiguredTableAnalysisRule Operation</seealso>
        public virtual IAsyncResult BeginCreateConfiguredTableAnalysisRule(CreateConfiguredTableAnalysisRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfiguredTableAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredTableAnalysisRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfiguredTableAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfiguredTableAnalysisRule.</param>
        /// 
        /// <returns>Returns a  CreateConfiguredTableAnalysisRuleResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTableAnalysisRule">REST API Reference for CreateConfiguredTableAnalysisRule Operation</seealso>
        public virtual CreateConfiguredTableAnalysisRuleResponse EndCreateConfiguredTableAnalysisRule(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConfiguredTableAnalysisRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConfiguredTableAssociation

        /// <summary>
        /// Creates a configured table association. A configured table association links a configured
        /// table with a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTableAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateConfiguredTableAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTableAssociation">REST API Reference for CreateConfiguredTableAssociation Operation</seealso>
        public virtual CreateConfiguredTableAssociationResponse CreateConfiguredTableAssociation(CreateConfiguredTableAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfiguredTableAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredTableAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateConfiguredTableAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfiguredTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTableAssociation operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfiguredTableAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTableAssociation">REST API Reference for CreateConfiguredTableAssociation Operation</seealso>
        public virtual IAsyncResult BeginCreateConfiguredTableAssociation(CreateConfiguredTableAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfiguredTableAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredTableAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfiguredTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfiguredTableAssociation.</param>
        /// 
        /// <returns>Returns a  CreateConfiguredTableAssociationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTableAssociation">REST API Reference for CreateConfiguredTableAssociation Operation</seealso>
        public virtual CreateConfiguredTableAssociationResponse EndCreateConfiguredTableAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConfiguredTableAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConfiguredTableAssociationAnalysisRule

        /// <summary>
        /// Creates a new analysis rule for an associated configured table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTableAssociationAnalysisRule service method.</param>
        /// 
        /// <returns>The response from the CreateConfiguredTableAssociationAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTableAssociationAnalysisRule">REST API Reference for CreateConfiguredTableAssociationAnalysisRule Operation</seealso>
        public virtual CreateConfiguredTableAssociationAnalysisRuleResponse CreateConfiguredTableAssociationAnalysisRule(CreateConfiguredTableAssociationAnalysisRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfiguredTableAssociationAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredTableAssociationAnalysisRuleResponseUnmarshaller.Instance;

            return Invoke<CreateConfiguredTableAssociationAnalysisRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfiguredTableAssociationAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTableAssociationAnalysisRule operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfiguredTableAssociationAnalysisRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTableAssociationAnalysisRule">REST API Reference for CreateConfiguredTableAssociationAnalysisRule Operation</seealso>
        public virtual IAsyncResult BeginCreateConfiguredTableAssociationAnalysisRule(CreateConfiguredTableAssociationAnalysisRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfiguredTableAssociationAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredTableAssociationAnalysisRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfiguredTableAssociationAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfiguredTableAssociationAnalysisRule.</param>
        /// 
        /// <returns>Returns a  CreateConfiguredTableAssociationAnalysisRuleResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTableAssociationAnalysisRule">REST API Reference for CreateConfiguredTableAssociationAnalysisRule Operation</seealso>
        public virtual CreateConfiguredTableAssociationAnalysisRuleResponse EndCreateConfiguredTableAssociationAnalysisRule(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConfiguredTableAssociationAnalysisRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIdMappingTable

        /// <summary>
        /// Creates an ID mapping table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdMappingTable service method.</param>
        /// 
        /// <returns>The response from the CreateIdMappingTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateIdMappingTable">REST API Reference for CreateIdMappingTable Operation</seealso>
        public virtual CreateIdMappingTableResponse CreateIdMappingTable(CreateIdMappingTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIdMappingTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdMappingTableResponseUnmarshaller.Instance;

            return Invoke<CreateIdMappingTableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIdMappingTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIdMappingTable operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIdMappingTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateIdMappingTable">REST API Reference for CreateIdMappingTable Operation</seealso>
        public virtual IAsyncResult BeginCreateIdMappingTable(CreateIdMappingTableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIdMappingTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdMappingTableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIdMappingTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIdMappingTable.</param>
        /// 
        /// <returns>Returns a  CreateIdMappingTableResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateIdMappingTable">REST API Reference for CreateIdMappingTable Operation</seealso>
        public virtual CreateIdMappingTableResponse EndCreateIdMappingTable(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIdMappingTableResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIdNamespaceAssociation

        /// <summary>
        /// Creates an ID namespace association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdNamespaceAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateIdNamespaceAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateIdNamespaceAssociation">REST API Reference for CreateIdNamespaceAssociation Operation</seealso>
        public virtual CreateIdNamespaceAssociationResponse CreateIdNamespaceAssociation(CreateIdNamespaceAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIdNamespaceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdNamespaceAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateIdNamespaceAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIdNamespaceAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIdNamespaceAssociation operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIdNamespaceAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateIdNamespaceAssociation">REST API Reference for CreateIdNamespaceAssociation Operation</seealso>
        public virtual IAsyncResult BeginCreateIdNamespaceAssociation(CreateIdNamespaceAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIdNamespaceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdNamespaceAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIdNamespaceAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIdNamespaceAssociation.</param>
        /// 
        /// <returns>Returns a  CreateIdNamespaceAssociationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateIdNamespaceAssociation">REST API Reference for CreateIdNamespaceAssociation Operation</seealso>
        public virtual CreateIdNamespaceAssociationResponse EndCreateIdNamespaceAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIdNamespaceAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMembership

        /// <summary>
        /// Creates a membership for a specific collaboration identifier and joins the collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembership service method.</param>
        /// 
        /// <returns>The response from the CreateMembership service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateMembership">REST API Reference for CreateMembership Operation</seealso>
        public virtual CreateMembershipResponse CreateMembership(CreateMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMembershipResponseUnmarshaller.Instance;

            return Invoke<CreateMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMembership operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateMembership">REST API Reference for CreateMembership Operation</seealso>
        public virtual IAsyncResult BeginCreateMembership(CreateMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMembership.</param>
        /// 
        /// <returns>Returns a  CreateMembershipResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateMembership">REST API Reference for CreateMembership Operation</seealso>
        public virtual CreateMembershipResponse EndCreateMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePrivacyBudgetTemplate

        /// <summary>
        /// Creates a privacy budget template for a specified collaboration. Each collaboration
        /// can have only one privacy budget template. If you need to change the privacy budget
        /// template, use the <a>UpdatePrivacyBudgetTemplate</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivacyBudgetTemplate service method.</param>
        /// 
        /// <returns>The response from the CreatePrivacyBudgetTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreatePrivacyBudgetTemplate">REST API Reference for CreatePrivacyBudgetTemplate Operation</seealso>
        public virtual CreatePrivacyBudgetTemplateResponse CreatePrivacyBudgetTemplate(CreatePrivacyBudgetTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePrivacyBudgetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePrivacyBudgetTemplateResponseUnmarshaller.Instance;

            return Invoke<CreatePrivacyBudgetTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePrivacyBudgetTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivacyBudgetTemplate operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePrivacyBudgetTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreatePrivacyBudgetTemplate">REST API Reference for CreatePrivacyBudgetTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreatePrivacyBudgetTemplate(CreatePrivacyBudgetTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePrivacyBudgetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePrivacyBudgetTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePrivacyBudgetTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePrivacyBudgetTemplate.</param>
        /// 
        /// <returns>Returns a  CreatePrivacyBudgetTemplateResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreatePrivacyBudgetTemplate">REST API Reference for CreatePrivacyBudgetTemplate Operation</seealso>
        public virtual CreatePrivacyBudgetTemplateResponse EndCreatePrivacyBudgetTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePrivacyBudgetTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAnalysisTemplate

        /// <summary>
        /// Deletes an analysis template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnalysisTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteAnalysisTemplate">REST API Reference for DeleteAnalysisTemplate Operation</seealso>
        public virtual DeleteAnalysisTemplateResponse DeleteAnalysisTemplate(DeleteAnalysisTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnalysisTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteAnalysisTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAnalysisTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnalysisTemplate operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAnalysisTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteAnalysisTemplate">REST API Reference for DeleteAnalysisTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeleteAnalysisTemplate(DeleteAnalysisTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnalysisTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAnalysisTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAnalysisTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteAnalysisTemplateResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteAnalysisTemplate">REST API Reference for DeleteAnalysisTemplate Operation</seealso>
        public virtual DeleteAnalysisTemplateResponse EndDeleteAnalysisTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAnalysisTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCollaboration

        /// <summary>
        /// Deletes a collaboration. It can only be called by the collaboration owner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCollaboration service method.</param>
        /// 
        /// <returns>The response from the DeleteCollaboration service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteCollaboration">REST API Reference for DeleteCollaboration Operation</seealso>
        public virtual DeleteCollaborationResponse DeleteCollaboration(DeleteCollaborationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCollaborationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCollaborationResponseUnmarshaller.Instance;

            return Invoke<DeleteCollaborationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCollaboration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCollaboration operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCollaboration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteCollaboration">REST API Reference for DeleteCollaboration Operation</seealso>
        public virtual IAsyncResult BeginDeleteCollaboration(DeleteCollaborationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCollaborationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCollaborationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCollaboration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCollaboration.</param>
        /// 
        /// <returns>Returns a  DeleteCollaborationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteCollaboration">REST API Reference for DeleteCollaboration Operation</seealso>
        public virtual DeleteCollaborationResponse EndDeleteCollaboration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCollaborationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConfiguredAudienceModelAssociation

        /// <summary>
        /// Provides the information necessary to delete a configured audience model association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredAudienceModelAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteConfiguredAudienceModelAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredAudienceModelAssociation">REST API Reference for DeleteConfiguredAudienceModelAssociation Operation</seealso>
        public virtual DeleteConfiguredAudienceModelAssociationResponse DeleteConfiguredAudienceModelAssociation(DeleteConfiguredAudienceModelAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredAudienceModelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredAudienceModelAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteConfiguredAudienceModelAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfiguredAudienceModelAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredAudienceModelAssociation operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfiguredAudienceModelAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredAudienceModelAssociation">REST API Reference for DeleteConfiguredAudienceModelAssociation Operation</seealso>
        public virtual IAsyncResult BeginDeleteConfiguredAudienceModelAssociation(DeleteConfiguredAudienceModelAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredAudienceModelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredAudienceModelAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfiguredAudienceModelAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfiguredAudienceModelAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteConfiguredAudienceModelAssociationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredAudienceModelAssociation">REST API Reference for DeleteConfiguredAudienceModelAssociation Operation</seealso>
        public virtual DeleteConfiguredAudienceModelAssociationResponse EndDeleteConfiguredAudienceModelAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConfiguredAudienceModelAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConfiguredTable

        /// <summary>
        /// Deletes a configured table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTable service method.</param>
        /// 
        /// <returns>The response from the DeleteConfiguredTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTable">REST API Reference for DeleteConfiguredTable Operation</seealso>
        public virtual DeleteConfiguredTableResponse DeleteConfiguredTable(DeleteConfiguredTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredTableResponseUnmarshaller.Instance;

            return Invoke<DeleteConfiguredTableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfiguredTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTable operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfiguredTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTable">REST API Reference for DeleteConfiguredTable Operation</seealso>
        public virtual IAsyncResult BeginDeleteConfiguredTable(DeleteConfiguredTableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredTableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfiguredTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfiguredTable.</param>
        /// 
        /// <returns>Returns a  DeleteConfiguredTableResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTable">REST API Reference for DeleteConfiguredTable Operation</seealso>
        public virtual DeleteConfiguredTableResponse EndDeleteConfiguredTable(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConfiguredTableResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConfiguredTableAnalysisRule

        /// <summary>
        /// Deletes a configured table analysis rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTableAnalysisRule service method.</param>
        /// 
        /// <returns>The response from the DeleteConfiguredTableAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTableAnalysisRule">REST API Reference for DeleteConfiguredTableAnalysisRule Operation</seealso>
        public virtual DeleteConfiguredTableAnalysisRuleResponse DeleteConfiguredTableAnalysisRule(DeleteConfiguredTableAnalysisRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredTableAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredTableAnalysisRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteConfiguredTableAnalysisRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfiguredTableAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTableAnalysisRule operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfiguredTableAnalysisRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTableAnalysisRule">REST API Reference for DeleteConfiguredTableAnalysisRule Operation</seealso>
        public virtual IAsyncResult BeginDeleteConfiguredTableAnalysisRule(DeleteConfiguredTableAnalysisRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredTableAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredTableAnalysisRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfiguredTableAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfiguredTableAnalysisRule.</param>
        /// 
        /// <returns>Returns a  DeleteConfiguredTableAnalysisRuleResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTableAnalysisRule">REST API Reference for DeleteConfiguredTableAnalysisRule Operation</seealso>
        public virtual DeleteConfiguredTableAnalysisRuleResponse EndDeleteConfiguredTableAnalysisRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConfiguredTableAnalysisRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConfiguredTableAssociation

        /// <summary>
        /// Deletes a configured table association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTableAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteConfiguredTableAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTableAssociation">REST API Reference for DeleteConfiguredTableAssociation Operation</seealso>
        public virtual DeleteConfiguredTableAssociationResponse DeleteConfiguredTableAssociation(DeleteConfiguredTableAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredTableAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredTableAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteConfiguredTableAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfiguredTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTableAssociation operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfiguredTableAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTableAssociation">REST API Reference for DeleteConfiguredTableAssociation Operation</seealso>
        public virtual IAsyncResult BeginDeleteConfiguredTableAssociation(DeleteConfiguredTableAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredTableAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredTableAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfiguredTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfiguredTableAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteConfiguredTableAssociationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTableAssociation">REST API Reference for DeleteConfiguredTableAssociation Operation</seealso>
        public virtual DeleteConfiguredTableAssociationResponse EndDeleteConfiguredTableAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConfiguredTableAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConfiguredTableAssociationAnalysisRule

        /// <summary>
        /// Deletes an analysis rule for a configured table association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTableAssociationAnalysisRule service method.</param>
        /// 
        /// <returns>The response from the DeleteConfiguredTableAssociationAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTableAssociationAnalysisRule">REST API Reference for DeleteConfiguredTableAssociationAnalysisRule Operation</seealso>
        public virtual DeleteConfiguredTableAssociationAnalysisRuleResponse DeleteConfiguredTableAssociationAnalysisRule(DeleteConfiguredTableAssociationAnalysisRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredTableAssociationAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredTableAssociationAnalysisRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteConfiguredTableAssociationAnalysisRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfiguredTableAssociationAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTableAssociationAnalysisRule operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfiguredTableAssociationAnalysisRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTableAssociationAnalysisRule">REST API Reference for DeleteConfiguredTableAssociationAnalysisRule Operation</seealso>
        public virtual IAsyncResult BeginDeleteConfiguredTableAssociationAnalysisRule(DeleteConfiguredTableAssociationAnalysisRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredTableAssociationAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredTableAssociationAnalysisRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfiguredTableAssociationAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfiguredTableAssociationAnalysisRule.</param>
        /// 
        /// <returns>Returns a  DeleteConfiguredTableAssociationAnalysisRuleResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTableAssociationAnalysisRule">REST API Reference for DeleteConfiguredTableAssociationAnalysisRule Operation</seealso>
        public virtual DeleteConfiguredTableAssociationAnalysisRuleResponse EndDeleteConfiguredTableAssociationAnalysisRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConfiguredTableAssociationAnalysisRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIdMappingTable

        /// <summary>
        /// Deletes an ID mapping table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdMappingTable service method.</param>
        /// 
        /// <returns>The response from the DeleteIdMappingTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteIdMappingTable">REST API Reference for DeleteIdMappingTable Operation</seealso>
        public virtual DeleteIdMappingTableResponse DeleteIdMappingTable(DeleteIdMappingTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdMappingTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdMappingTableResponseUnmarshaller.Instance;

            return Invoke<DeleteIdMappingTableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdMappingTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdMappingTable operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIdMappingTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteIdMappingTable">REST API Reference for DeleteIdMappingTable Operation</seealso>
        public virtual IAsyncResult BeginDeleteIdMappingTable(DeleteIdMappingTableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdMappingTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdMappingTableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIdMappingTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdMappingTable.</param>
        /// 
        /// <returns>Returns a  DeleteIdMappingTableResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteIdMappingTable">REST API Reference for DeleteIdMappingTable Operation</seealso>
        public virtual DeleteIdMappingTableResponse EndDeleteIdMappingTable(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIdMappingTableResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIdNamespaceAssociation

        /// <summary>
        /// Deletes an ID namespace association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdNamespaceAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteIdNamespaceAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteIdNamespaceAssociation">REST API Reference for DeleteIdNamespaceAssociation Operation</seealso>
        public virtual DeleteIdNamespaceAssociationResponse DeleteIdNamespaceAssociation(DeleteIdNamespaceAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdNamespaceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdNamespaceAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteIdNamespaceAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdNamespaceAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdNamespaceAssociation operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIdNamespaceAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteIdNamespaceAssociation">REST API Reference for DeleteIdNamespaceAssociation Operation</seealso>
        public virtual IAsyncResult BeginDeleteIdNamespaceAssociation(DeleteIdNamespaceAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdNamespaceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdNamespaceAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIdNamespaceAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdNamespaceAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteIdNamespaceAssociationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteIdNamespaceAssociation">REST API Reference for DeleteIdNamespaceAssociation Operation</seealso>
        public virtual DeleteIdNamespaceAssociationResponse EndDeleteIdNamespaceAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIdNamespaceAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMember

        /// <summary>
        /// Removes the specified member from a collaboration. The removed member is placed in
        /// the Removed status and can't interact with the collaboration. The removed member's
        /// data is inaccessible to active members of the collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMember service method.</param>
        /// 
        /// <returns>The response from the DeleteMember service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteMember">REST API Reference for DeleteMember Operation</seealso>
        public virtual DeleteMemberResponse DeleteMember(DeleteMemberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMemberResponseUnmarshaller.Instance;

            return Invoke<DeleteMemberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMember operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteMember">REST API Reference for DeleteMember Operation</seealso>
        public virtual IAsyncResult BeginDeleteMember(DeleteMemberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMemberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMember.</param>
        /// 
        /// <returns>Returns a  DeleteMemberResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteMember">REST API Reference for DeleteMember Operation</seealso>
        public virtual DeleteMemberResponse EndDeleteMember(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMemberResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMembership

        /// <summary>
        /// Deletes a specified membership. All resources under a membership must be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembership service method.</param>
        /// 
        /// <returns>The response from the DeleteMembership service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteMembership">REST API Reference for DeleteMembership Operation</seealso>
        public virtual DeleteMembershipResponse DeleteMembership(DeleteMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMembershipResponseUnmarshaller.Instance;

            return Invoke<DeleteMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembership operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteMembership">REST API Reference for DeleteMembership Operation</seealso>
        public virtual IAsyncResult BeginDeleteMembership(DeleteMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMembership.</param>
        /// 
        /// <returns>Returns a  DeleteMembershipResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteMembership">REST API Reference for DeleteMembership Operation</seealso>
        public virtual DeleteMembershipResponse EndDeleteMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePrivacyBudgetTemplate

        /// <summary>
        /// Deletes a privacy budget template for a specified collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePrivacyBudgetTemplate service method.</param>
        /// 
        /// <returns>The response from the DeletePrivacyBudgetTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeletePrivacyBudgetTemplate">REST API Reference for DeletePrivacyBudgetTemplate Operation</seealso>
        public virtual DeletePrivacyBudgetTemplateResponse DeletePrivacyBudgetTemplate(DeletePrivacyBudgetTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePrivacyBudgetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePrivacyBudgetTemplateResponseUnmarshaller.Instance;

            return Invoke<DeletePrivacyBudgetTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePrivacyBudgetTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePrivacyBudgetTemplate operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePrivacyBudgetTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeletePrivacyBudgetTemplate">REST API Reference for DeletePrivacyBudgetTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeletePrivacyBudgetTemplate(DeletePrivacyBudgetTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePrivacyBudgetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePrivacyBudgetTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePrivacyBudgetTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePrivacyBudgetTemplate.</param>
        /// 
        /// <returns>Returns a  DeletePrivacyBudgetTemplateResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeletePrivacyBudgetTemplate">REST API Reference for DeletePrivacyBudgetTemplate Operation</seealso>
        public virtual DeletePrivacyBudgetTemplateResponse EndDeletePrivacyBudgetTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePrivacyBudgetTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAnalysisTemplate

        /// <summary>
        /// Retrieves an analysis template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnalysisTemplate service method.</param>
        /// 
        /// <returns>The response from the GetAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetAnalysisTemplate">REST API Reference for GetAnalysisTemplate Operation</seealso>
        public virtual GetAnalysisTemplateResponse GetAnalysisTemplate(GetAnalysisTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnalysisTemplateResponseUnmarshaller.Instance;

            return Invoke<GetAnalysisTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAnalysisTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAnalysisTemplate operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAnalysisTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetAnalysisTemplate">REST API Reference for GetAnalysisTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetAnalysisTemplate(GetAnalysisTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnalysisTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAnalysisTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAnalysisTemplate.</param>
        /// 
        /// <returns>Returns a  GetAnalysisTemplateResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetAnalysisTemplate">REST API Reference for GetAnalysisTemplate Operation</seealso>
        public virtual GetAnalysisTemplateResponse EndGetAnalysisTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAnalysisTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCollaboration

        /// <summary>
        /// Returns metadata about a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollaboration service method.</param>
        /// 
        /// <returns>The response from the GetCollaboration service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaboration">REST API Reference for GetCollaboration Operation</seealso>
        public virtual GetCollaborationResponse GetCollaboration(GetCollaborationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCollaborationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationResponseUnmarshaller.Instance;

            return Invoke<GetCollaborationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCollaboration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCollaboration operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCollaboration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaboration">REST API Reference for GetCollaboration Operation</seealso>
        public virtual IAsyncResult BeginGetCollaboration(GetCollaborationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCollaborationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCollaboration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCollaboration.</param>
        /// 
        /// <returns>Returns a  GetCollaborationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaboration">REST API Reference for GetCollaboration Operation</seealso>
        public virtual GetCollaborationResponse EndGetCollaboration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCollaborationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCollaborationAnalysisTemplate

        /// <summary>
        /// Retrieves an analysis template within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollaborationAnalysisTemplate service method.</param>
        /// 
        /// <returns>The response from the GetCollaborationAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaborationAnalysisTemplate">REST API Reference for GetCollaborationAnalysisTemplate Operation</seealso>
        public virtual GetCollaborationAnalysisTemplateResponse GetCollaborationAnalysisTemplate(GetCollaborationAnalysisTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCollaborationAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationAnalysisTemplateResponseUnmarshaller.Instance;

            return Invoke<GetCollaborationAnalysisTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCollaborationAnalysisTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCollaborationAnalysisTemplate operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCollaborationAnalysisTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaborationAnalysisTemplate">REST API Reference for GetCollaborationAnalysisTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetCollaborationAnalysisTemplate(GetCollaborationAnalysisTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCollaborationAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationAnalysisTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCollaborationAnalysisTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCollaborationAnalysisTemplate.</param>
        /// 
        /// <returns>Returns a  GetCollaborationAnalysisTemplateResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaborationAnalysisTemplate">REST API Reference for GetCollaborationAnalysisTemplate Operation</seealso>
        public virtual GetCollaborationAnalysisTemplateResponse EndGetCollaborationAnalysisTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCollaborationAnalysisTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCollaborationConfiguredAudienceModelAssociation

        /// <summary>
        /// Retrieves a configured audience model association within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollaborationConfiguredAudienceModelAssociation service method.</param>
        /// 
        /// <returns>The response from the GetCollaborationConfiguredAudienceModelAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaborationConfiguredAudienceModelAssociation">REST API Reference for GetCollaborationConfiguredAudienceModelAssociation Operation</seealso>
        public virtual GetCollaborationConfiguredAudienceModelAssociationResponse GetCollaborationConfiguredAudienceModelAssociation(GetCollaborationConfiguredAudienceModelAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCollaborationConfiguredAudienceModelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationConfiguredAudienceModelAssociationResponseUnmarshaller.Instance;

            return Invoke<GetCollaborationConfiguredAudienceModelAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCollaborationConfiguredAudienceModelAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCollaborationConfiguredAudienceModelAssociation operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCollaborationConfiguredAudienceModelAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaborationConfiguredAudienceModelAssociation">REST API Reference for GetCollaborationConfiguredAudienceModelAssociation Operation</seealso>
        public virtual IAsyncResult BeginGetCollaborationConfiguredAudienceModelAssociation(GetCollaborationConfiguredAudienceModelAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCollaborationConfiguredAudienceModelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationConfiguredAudienceModelAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCollaborationConfiguredAudienceModelAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCollaborationConfiguredAudienceModelAssociation.</param>
        /// 
        /// <returns>Returns a  GetCollaborationConfiguredAudienceModelAssociationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaborationConfiguredAudienceModelAssociation">REST API Reference for GetCollaborationConfiguredAudienceModelAssociation Operation</seealso>
        public virtual GetCollaborationConfiguredAudienceModelAssociationResponse EndGetCollaborationConfiguredAudienceModelAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCollaborationConfiguredAudienceModelAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCollaborationIdNamespaceAssociation

        /// <summary>
        /// Retrieves an ID namespace association from a specific collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollaborationIdNamespaceAssociation service method.</param>
        /// 
        /// <returns>The response from the GetCollaborationIdNamespaceAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaborationIdNamespaceAssociation">REST API Reference for GetCollaborationIdNamespaceAssociation Operation</seealso>
        public virtual GetCollaborationIdNamespaceAssociationResponse GetCollaborationIdNamespaceAssociation(GetCollaborationIdNamespaceAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCollaborationIdNamespaceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationIdNamespaceAssociationResponseUnmarshaller.Instance;

            return Invoke<GetCollaborationIdNamespaceAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCollaborationIdNamespaceAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCollaborationIdNamespaceAssociation operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCollaborationIdNamespaceAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaborationIdNamespaceAssociation">REST API Reference for GetCollaborationIdNamespaceAssociation Operation</seealso>
        public virtual IAsyncResult BeginGetCollaborationIdNamespaceAssociation(GetCollaborationIdNamespaceAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCollaborationIdNamespaceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationIdNamespaceAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCollaborationIdNamespaceAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCollaborationIdNamespaceAssociation.</param>
        /// 
        /// <returns>Returns a  GetCollaborationIdNamespaceAssociationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaborationIdNamespaceAssociation">REST API Reference for GetCollaborationIdNamespaceAssociation Operation</seealso>
        public virtual GetCollaborationIdNamespaceAssociationResponse EndGetCollaborationIdNamespaceAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCollaborationIdNamespaceAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCollaborationPrivacyBudgetTemplate

        /// <summary>
        /// Returns details about a specified privacy budget template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollaborationPrivacyBudgetTemplate service method.</param>
        /// 
        /// <returns>The response from the GetCollaborationPrivacyBudgetTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaborationPrivacyBudgetTemplate">REST API Reference for GetCollaborationPrivacyBudgetTemplate Operation</seealso>
        public virtual GetCollaborationPrivacyBudgetTemplateResponse GetCollaborationPrivacyBudgetTemplate(GetCollaborationPrivacyBudgetTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCollaborationPrivacyBudgetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationPrivacyBudgetTemplateResponseUnmarshaller.Instance;

            return Invoke<GetCollaborationPrivacyBudgetTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCollaborationPrivacyBudgetTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCollaborationPrivacyBudgetTemplate operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCollaborationPrivacyBudgetTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaborationPrivacyBudgetTemplate">REST API Reference for GetCollaborationPrivacyBudgetTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetCollaborationPrivacyBudgetTemplate(GetCollaborationPrivacyBudgetTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCollaborationPrivacyBudgetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCollaborationPrivacyBudgetTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCollaborationPrivacyBudgetTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCollaborationPrivacyBudgetTemplate.</param>
        /// 
        /// <returns>Returns a  GetCollaborationPrivacyBudgetTemplateResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaborationPrivacyBudgetTemplate">REST API Reference for GetCollaborationPrivacyBudgetTemplate Operation</seealso>
        public virtual GetCollaborationPrivacyBudgetTemplateResponse EndGetCollaborationPrivacyBudgetTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCollaborationPrivacyBudgetTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConfiguredAudienceModelAssociation

        /// <summary>
        /// Returns information about a configured audience model association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredAudienceModelAssociation service method.</param>
        /// 
        /// <returns>The response from the GetConfiguredAudienceModelAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredAudienceModelAssociation">REST API Reference for GetConfiguredAudienceModelAssociation Operation</seealso>
        public virtual GetConfiguredAudienceModelAssociationResponse GetConfiguredAudienceModelAssociation(GetConfiguredAudienceModelAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfiguredAudienceModelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredAudienceModelAssociationResponseUnmarshaller.Instance;

            return Invoke<GetConfiguredAudienceModelAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfiguredAudienceModelAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredAudienceModelAssociation operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfiguredAudienceModelAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredAudienceModelAssociation">REST API Reference for GetConfiguredAudienceModelAssociation Operation</seealso>
        public virtual IAsyncResult BeginGetConfiguredAudienceModelAssociation(GetConfiguredAudienceModelAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfiguredAudienceModelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredAudienceModelAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfiguredAudienceModelAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfiguredAudienceModelAssociation.</param>
        /// 
        /// <returns>Returns a  GetConfiguredAudienceModelAssociationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredAudienceModelAssociation">REST API Reference for GetConfiguredAudienceModelAssociation Operation</seealso>
        public virtual GetConfiguredAudienceModelAssociationResponse EndGetConfiguredAudienceModelAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConfiguredAudienceModelAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConfiguredTable

        /// <summary>
        /// Retrieves a configured table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTable service method.</param>
        /// 
        /// <returns>The response from the GetConfiguredTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTable">REST API Reference for GetConfiguredTable Operation</seealso>
        public virtual GetConfiguredTableResponse GetConfiguredTable(GetConfiguredTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfiguredTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredTableResponseUnmarshaller.Instance;

            return Invoke<GetConfiguredTableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfiguredTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTable operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfiguredTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTable">REST API Reference for GetConfiguredTable Operation</seealso>
        public virtual IAsyncResult BeginGetConfiguredTable(GetConfiguredTableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfiguredTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredTableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfiguredTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfiguredTable.</param>
        /// 
        /// <returns>Returns a  GetConfiguredTableResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTable">REST API Reference for GetConfiguredTable Operation</seealso>
        public virtual GetConfiguredTableResponse EndGetConfiguredTable(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConfiguredTableResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConfiguredTableAnalysisRule

        /// <summary>
        /// Retrieves a configured table analysis rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTableAnalysisRule service method.</param>
        /// 
        /// <returns>The response from the GetConfiguredTableAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTableAnalysisRule">REST API Reference for GetConfiguredTableAnalysisRule Operation</seealso>
        public virtual GetConfiguredTableAnalysisRuleResponse GetConfiguredTableAnalysisRule(GetConfiguredTableAnalysisRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfiguredTableAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredTableAnalysisRuleResponseUnmarshaller.Instance;

            return Invoke<GetConfiguredTableAnalysisRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfiguredTableAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTableAnalysisRule operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfiguredTableAnalysisRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTableAnalysisRule">REST API Reference for GetConfiguredTableAnalysisRule Operation</seealso>
        public virtual IAsyncResult BeginGetConfiguredTableAnalysisRule(GetConfiguredTableAnalysisRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfiguredTableAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredTableAnalysisRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfiguredTableAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfiguredTableAnalysisRule.</param>
        /// 
        /// <returns>Returns a  GetConfiguredTableAnalysisRuleResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTableAnalysisRule">REST API Reference for GetConfiguredTableAnalysisRule Operation</seealso>
        public virtual GetConfiguredTableAnalysisRuleResponse EndGetConfiguredTableAnalysisRule(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConfiguredTableAnalysisRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConfiguredTableAssociation

        /// <summary>
        /// Retrieves a configured table association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTableAssociation service method.</param>
        /// 
        /// <returns>The response from the GetConfiguredTableAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTableAssociation">REST API Reference for GetConfiguredTableAssociation Operation</seealso>
        public virtual GetConfiguredTableAssociationResponse GetConfiguredTableAssociation(GetConfiguredTableAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfiguredTableAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredTableAssociationResponseUnmarshaller.Instance;

            return Invoke<GetConfiguredTableAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfiguredTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTableAssociation operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfiguredTableAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTableAssociation">REST API Reference for GetConfiguredTableAssociation Operation</seealso>
        public virtual IAsyncResult BeginGetConfiguredTableAssociation(GetConfiguredTableAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfiguredTableAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredTableAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfiguredTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfiguredTableAssociation.</param>
        /// 
        /// <returns>Returns a  GetConfiguredTableAssociationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTableAssociation">REST API Reference for GetConfiguredTableAssociation Operation</seealso>
        public virtual GetConfiguredTableAssociationResponse EndGetConfiguredTableAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConfiguredTableAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConfiguredTableAssociationAnalysisRule

        /// <summary>
        /// Retrieves the analysis rule for a configured table association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTableAssociationAnalysisRule service method.</param>
        /// 
        /// <returns>The response from the GetConfiguredTableAssociationAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTableAssociationAnalysisRule">REST API Reference for GetConfiguredTableAssociationAnalysisRule Operation</seealso>
        public virtual GetConfiguredTableAssociationAnalysisRuleResponse GetConfiguredTableAssociationAnalysisRule(GetConfiguredTableAssociationAnalysisRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfiguredTableAssociationAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredTableAssociationAnalysisRuleResponseUnmarshaller.Instance;

            return Invoke<GetConfiguredTableAssociationAnalysisRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfiguredTableAssociationAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTableAssociationAnalysisRule operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfiguredTableAssociationAnalysisRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTableAssociationAnalysisRule">REST API Reference for GetConfiguredTableAssociationAnalysisRule Operation</seealso>
        public virtual IAsyncResult BeginGetConfiguredTableAssociationAnalysisRule(GetConfiguredTableAssociationAnalysisRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfiguredTableAssociationAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredTableAssociationAnalysisRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfiguredTableAssociationAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfiguredTableAssociationAnalysisRule.</param>
        /// 
        /// <returns>Returns a  GetConfiguredTableAssociationAnalysisRuleResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTableAssociationAnalysisRule">REST API Reference for GetConfiguredTableAssociationAnalysisRule Operation</seealso>
        public virtual GetConfiguredTableAssociationAnalysisRuleResponse EndGetConfiguredTableAssociationAnalysisRule(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConfiguredTableAssociationAnalysisRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIdMappingTable

        /// <summary>
        /// Retrieves an ID mapping table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdMappingTable service method.</param>
        /// 
        /// <returns>The response from the GetIdMappingTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetIdMappingTable">REST API Reference for GetIdMappingTable Operation</seealso>
        public virtual GetIdMappingTableResponse GetIdMappingTable(GetIdMappingTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdMappingTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdMappingTableResponseUnmarshaller.Instance;

            return Invoke<GetIdMappingTableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdMappingTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdMappingTable operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdMappingTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetIdMappingTable">REST API Reference for GetIdMappingTable Operation</seealso>
        public virtual IAsyncResult BeginGetIdMappingTable(GetIdMappingTableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdMappingTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdMappingTableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdMappingTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdMappingTable.</param>
        /// 
        /// <returns>Returns a  GetIdMappingTableResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetIdMappingTable">REST API Reference for GetIdMappingTable Operation</seealso>
        public virtual GetIdMappingTableResponse EndGetIdMappingTable(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIdMappingTableResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIdNamespaceAssociation

        /// <summary>
        /// Retrieves an ID namespace association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdNamespaceAssociation service method.</param>
        /// 
        /// <returns>The response from the GetIdNamespaceAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetIdNamespaceAssociation">REST API Reference for GetIdNamespaceAssociation Operation</seealso>
        public virtual GetIdNamespaceAssociationResponse GetIdNamespaceAssociation(GetIdNamespaceAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdNamespaceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdNamespaceAssociationResponseUnmarshaller.Instance;

            return Invoke<GetIdNamespaceAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdNamespaceAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdNamespaceAssociation operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdNamespaceAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetIdNamespaceAssociation">REST API Reference for GetIdNamespaceAssociation Operation</seealso>
        public virtual IAsyncResult BeginGetIdNamespaceAssociation(GetIdNamespaceAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdNamespaceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdNamespaceAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdNamespaceAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdNamespaceAssociation.</param>
        /// 
        /// <returns>Returns a  GetIdNamespaceAssociationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetIdNamespaceAssociation">REST API Reference for GetIdNamespaceAssociation Operation</seealso>
        public virtual GetIdNamespaceAssociationResponse EndGetIdNamespaceAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIdNamespaceAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMembership

        /// <summary>
        /// Retrieves a specified membership for an identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMembership service method.</param>
        /// 
        /// <returns>The response from the GetMembership service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetMembership">REST API Reference for GetMembership Operation</seealso>
        public virtual GetMembershipResponse GetMembership(GetMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMembershipResponseUnmarshaller.Instance;

            return Invoke<GetMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMembership operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetMembership">REST API Reference for GetMembership Operation</seealso>
        public virtual IAsyncResult BeginGetMembership(GetMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMembership.</param>
        /// 
        /// <returns>Returns a  GetMembershipResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetMembership">REST API Reference for GetMembership Operation</seealso>
        public virtual GetMembershipResponse EndGetMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPrivacyBudgetTemplate

        /// <summary>
        /// Returns details for a specified privacy budget template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPrivacyBudgetTemplate service method.</param>
        /// 
        /// <returns>The response from the GetPrivacyBudgetTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetPrivacyBudgetTemplate">REST API Reference for GetPrivacyBudgetTemplate Operation</seealso>
        public virtual GetPrivacyBudgetTemplateResponse GetPrivacyBudgetTemplate(GetPrivacyBudgetTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPrivacyBudgetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPrivacyBudgetTemplateResponseUnmarshaller.Instance;

            return Invoke<GetPrivacyBudgetTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPrivacyBudgetTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPrivacyBudgetTemplate operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPrivacyBudgetTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetPrivacyBudgetTemplate">REST API Reference for GetPrivacyBudgetTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetPrivacyBudgetTemplate(GetPrivacyBudgetTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPrivacyBudgetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPrivacyBudgetTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPrivacyBudgetTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPrivacyBudgetTemplate.</param>
        /// 
        /// <returns>Returns a  GetPrivacyBudgetTemplateResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetPrivacyBudgetTemplate">REST API Reference for GetPrivacyBudgetTemplate Operation</seealso>
        public virtual GetPrivacyBudgetTemplateResponse EndGetPrivacyBudgetTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPrivacyBudgetTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProtectedJob

        /// <summary>
        /// Returns job processing metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProtectedJob service method.</param>
        /// 
        /// <returns>The response from the GetProtectedJob service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetProtectedJob">REST API Reference for GetProtectedJob Operation</seealso>
        public virtual GetProtectedJobResponse GetProtectedJob(GetProtectedJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProtectedJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProtectedJobResponseUnmarshaller.Instance;

            return Invoke<GetProtectedJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProtectedJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProtectedJob operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProtectedJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetProtectedJob">REST API Reference for GetProtectedJob Operation</seealso>
        public virtual IAsyncResult BeginGetProtectedJob(GetProtectedJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProtectedJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProtectedJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProtectedJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProtectedJob.</param>
        /// 
        /// <returns>Returns a  GetProtectedJobResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetProtectedJob">REST API Reference for GetProtectedJob Operation</seealso>
        public virtual GetProtectedJobResponse EndGetProtectedJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProtectedJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProtectedQuery

        /// <summary>
        /// Returns query processing metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProtectedQuery service method.</param>
        /// 
        /// <returns>The response from the GetProtectedQuery service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetProtectedQuery">REST API Reference for GetProtectedQuery Operation</seealso>
        public virtual GetProtectedQueryResponse GetProtectedQuery(GetProtectedQueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProtectedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProtectedQueryResponseUnmarshaller.Instance;

            return Invoke<GetProtectedQueryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProtectedQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProtectedQuery operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProtectedQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetProtectedQuery">REST API Reference for GetProtectedQuery Operation</seealso>
        public virtual IAsyncResult BeginGetProtectedQuery(GetProtectedQueryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProtectedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProtectedQueryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProtectedQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProtectedQuery.</param>
        /// 
        /// <returns>Returns a  GetProtectedQueryResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetProtectedQuery">REST API Reference for GetProtectedQuery Operation</seealso>
        public virtual GetProtectedQueryResponse EndGetProtectedQuery(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProtectedQueryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSchema

        /// <summary>
        /// Retrieves the schema for a relation within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchema service method.</param>
        /// 
        /// <returns>The response from the GetSchema service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetSchema">REST API Reference for GetSchema Operation</seealso>
        public virtual GetSchemaResponse GetSchema(GetSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaResponseUnmarshaller.Instance;

            return Invoke<GetSchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSchema operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetSchema">REST API Reference for GetSchema Operation</seealso>
        public virtual IAsyncResult BeginGetSchema(GetSchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSchema.</param>
        /// 
        /// <returns>Returns a  GetSchemaResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetSchema">REST API Reference for GetSchema Operation</seealso>
        public virtual GetSchemaResponse EndGetSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSchemaResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSchemaAnalysisRule

        /// <summary>
        /// Retrieves a schema analysis rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaAnalysisRule service method.</param>
        /// 
        /// <returns>The response from the GetSchemaAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetSchemaAnalysisRule">REST API Reference for GetSchemaAnalysisRule Operation</seealso>
        public virtual GetSchemaAnalysisRuleResponse GetSchemaAnalysisRule(GetSchemaAnalysisRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaAnalysisRuleResponseUnmarshaller.Instance;

            return Invoke<GetSchemaAnalysisRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSchemaAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaAnalysisRule operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSchemaAnalysisRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetSchemaAnalysisRule">REST API Reference for GetSchemaAnalysisRule Operation</seealso>
        public virtual IAsyncResult BeginGetSchemaAnalysisRule(GetSchemaAnalysisRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaAnalysisRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSchemaAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSchemaAnalysisRule.</param>
        /// 
        /// <returns>Returns a  GetSchemaAnalysisRuleResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetSchemaAnalysisRule">REST API Reference for GetSchemaAnalysisRule Operation</seealso>
        public virtual GetSchemaAnalysisRuleResponse EndGetSchemaAnalysisRule(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSchemaAnalysisRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAnalysisTemplates

        /// <summary>
        /// Lists analysis templates that the caller owns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnalysisTemplates service method.</param>
        /// 
        /// <returns>The response from the ListAnalysisTemplates service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListAnalysisTemplates">REST API Reference for ListAnalysisTemplates Operation</seealso>
        public virtual ListAnalysisTemplatesResponse ListAnalysisTemplates(ListAnalysisTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAnalysisTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnalysisTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListAnalysisTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAnalysisTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAnalysisTemplates operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAnalysisTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListAnalysisTemplates">REST API Reference for ListAnalysisTemplates Operation</seealso>
        public virtual IAsyncResult BeginListAnalysisTemplates(ListAnalysisTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAnalysisTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnalysisTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAnalysisTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAnalysisTemplates.</param>
        /// 
        /// <returns>Returns a  ListAnalysisTemplatesResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListAnalysisTemplates">REST API Reference for ListAnalysisTemplates Operation</seealso>
        public virtual ListAnalysisTemplatesResponse EndListAnalysisTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAnalysisTemplatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCollaborationAnalysisTemplates

        /// <summary>
        /// Lists analysis templates within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationAnalysisTemplates service method.</param>
        /// 
        /// <returns>The response from the ListCollaborationAnalysisTemplates service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationAnalysisTemplates">REST API Reference for ListCollaborationAnalysisTemplates Operation</seealso>
        public virtual ListCollaborationAnalysisTemplatesResponse ListCollaborationAnalysisTemplates(ListCollaborationAnalysisTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollaborationAnalysisTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationAnalysisTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListCollaborationAnalysisTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCollaborationAnalysisTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationAnalysisTemplates operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCollaborationAnalysisTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationAnalysisTemplates">REST API Reference for ListCollaborationAnalysisTemplates Operation</seealso>
        public virtual IAsyncResult BeginListCollaborationAnalysisTemplates(ListCollaborationAnalysisTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollaborationAnalysisTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationAnalysisTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCollaborationAnalysisTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCollaborationAnalysisTemplates.</param>
        /// 
        /// <returns>Returns a  ListCollaborationAnalysisTemplatesResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationAnalysisTemplates">REST API Reference for ListCollaborationAnalysisTemplates Operation</seealso>
        public virtual ListCollaborationAnalysisTemplatesResponse EndListCollaborationAnalysisTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCollaborationAnalysisTemplatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCollaborationConfiguredAudienceModelAssociations

        /// <summary>
        /// Lists configured audience model associations within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationConfiguredAudienceModelAssociations service method.</param>
        /// 
        /// <returns>The response from the ListCollaborationConfiguredAudienceModelAssociations service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationConfiguredAudienceModelAssociations">REST API Reference for ListCollaborationConfiguredAudienceModelAssociations Operation</seealso>
        public virtual ListCollaborationConfiguredAudienceModelAssociationsResponse ListCollaborationConfiguredAudienceModelAssociations(ListCollaborationConfiguredAudienceModelAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollaborationConfiguredAudienceModelAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationConfiguredAudienceModelAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListCollaborationConfiguredAudienceModelAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCollaborationConfiguredAudienceModelAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationConfiguredAudienceModelAssociations operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCollaborationConfiguredAudienceModelAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationConfiguredAudienceModelAssociations">REST API Reference for ListCollaborationConfiguredAudienceModelAssociations Operation</seealso>
        public virtual IAsyncResult BeginListCollaborationConfiguredAudienceModelAssociations(ListCollaborationConfiguredAudienceModelAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollaborationConfiguredAudienceModelAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationConfiguredAudienceModelAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCollaborationConfiguredAudienceModelAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCollaborationConfiguredAudienceModelAssociations.</param>
        /// 
        /// <returns>Returns a  ListCollaborationConfiguredAudienceModelAssociationsResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationConfiguredAudienceModelAssociations">REST API Reference for ListCollaborationConfiguredAudienceModelAssociations Operation</seealso>
        public virtual ListCollaborationConfiguredAudienceModelAssociationsResponse EndListCollaborationConfiguredAudienceModelAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCollaborationConfiguredAudienceModelAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCollaborationIdNamespaceAssociations

        /// <summary>
        /// Returns a list of the ID namespace associations in a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationIdNamespaceAssociations service method.</param>
        /// 
        /// <returns>The response from the ListCollaborationIdNamespaceAssociations service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationIdNamespaceAssociations">REST API Reference for ListCollaborationIdNamespaceAssociations Operation</seealso>
        public virtual ListCollaborationIdNamespaceAssociationsResponse ListCollaborationIdNamespaceAssociations(ListCollaborationIdNamespaceAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollaborationIdNamespaceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationIdNamespaceAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListCollaborationIdNamespaceAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCollaborationIdNamespaceAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationIdNamespaceAssociations operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCollaborationIdNamespaceAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationIdNamespaceAssociations">REST API Reference for ListCollaborationIdNamespaceAssociations Operation</seealso>
        public virtual IAsyncResult BeginListCollaborationIdNamespaceAssociations(ListCollaborationIdNamespaceAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollaborationIdNamespaceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationIdNamespaceAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCollaborationIdNamespaceAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCollaborationIdNamespaceAssociations.</param>
        /// 
        /// <returns>Returns a  ListCollaborationIdNamespaceAssociationsResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationIdNamespaceAssociations">REST API Reference for ListCollaborationIdNamespaceAssociations Operation</seealso>
        public virtual ListCollaborationIdNamespaceAssociationsResponse EndListCollaborationIdNamespaceAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCollaborationIdNamespaceAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCollaborationPrivacyBudgets

        /// <summary>
        /// Returns an array that summarizes each privacy budget in a specified collaboration.
        /// The summary includes the collaboration ARN, creation time, creating account, and privacy
        /// budget details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationPrivacyBudgets service method.</param>
        /// 
        /// <returns>The response from the ListCollaborationPrivacyBudgets service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationPrivacyBudgets">REST API Reference for ListCollaborationPrivacyBudgets Operation</seealso>
        public virtual ListCollaborationPrivacyBudgetsResponse ListCollaborationPrivacyBudgets(ListCollaborationPrivacyBudgetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollaborationPrivacyBudgetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationPrivacyBudgetsResponseUnmarshaller.Instance;

            return Invoke<ListCollaborationPrivacyBudgetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCollaborationPrivacyBudgets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationPrivacyBudgets operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCollaborationPrivacyBudgets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationPrivacyBudgets">REST API Reference for ListCollaborationPrivacyBudgets Operation</seealso>
        public virtual IAsyncResult BeginListCollaborationPrivacyBudgets(ListCollaborationPrivacyBudgetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollaborationPrivacyBudgetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationPrivacyBudgetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCollaborationPrivacyBudgets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCollaborationPrivacyBudgets.</param>
        /// 
        /// <returns>Returns a  ListCollaborationPrivacyBudgetsResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationPrivacyBudgets">REST API Reference for ListCollaborationPrivacyBudgets Operation</seealso>
        public virtual ListCollaborationPrivacyBudgetsResponse EndListCollaborationPrivacyBudgets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCollaborationPrivacyBudgetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCollaborationPrivacyBudgetTemplates

        /// <summary>
        /// Returns an array that summarizes each privacy budget template in a specified collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationPrivacyBudgetTemplates service method.</param>
        /// 
        /// <returns>The response from the ListCollaborationPrivacyBudgetTemplates service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationPrivacyBudgetTemplates">REST API Reference for ListCollaborationPrivacyBudgetTemplates Operation</seealso>
        public virtual ListCollaborationPrivacyBudgetTemplatesResponse ListCollaborationPrivacyBudgetTemplates(ListCollaborationPrivacyBudgetTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollaborationPrivacyBudgetTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationPrivacyBudgetTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListCollaborationPrivacyBudgetTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCollaborationPrivacyBudgetTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborationPrivacyBudgetTemplates operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCollaborationPrivacyBudgetTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationPrivacyBudgetTemplates">REST API Reference for ListCollaborationPrivacyBudgetTemplates Operation</seealso>
        public virtual IAsyncResult BeginListCollaborationPrivacyBudgetTemplates(ListCollaborationPrivacyBudgetTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollaborationPrivacyBudgetTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationPrivacyBudgetTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCollaborationPrivacyBudgetTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCollaborationPrivacyBudgetTemplates.</param>
        /// 
        /// <returns>Returns a  ListCollaborationPrivacyBudgetTemplatesResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborationPrivacyBudgetTemplates">REST API Reference for ListCollaborationPrivacyBudgetTemplates Operation</seealso>
        public virtual ListCollaborationPrivacyBudgetTemplatesResponse EndListCollaborationPrivacyBudgetTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCollaborationPrivacyBudgetTemplatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCollaborations

        /// <summary>
        /// Lists collaborations the caller owns, is active in, or has been invited to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborations service method.</param>
        /// 
        /// <returns>The response from the ListCollaborations service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborations">REST API Reference for ListCollaborations Operation</seealso>
        public virtual ListCollaborationsResponse ListCollaborations(ListCollaborationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollaborationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationsResponseUnmarshaller.Instance;

            return Invoke<ListCollaborationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCollaborations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborations operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCollaborations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborations">REST API Reference for ListCollaborations Operation</seealso>
        public virtual IAsyncResult BeginListCollaborations(ListCollaborationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollaborationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollaborationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCollaborations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCollaborations.</param>
        /// 
        /// <returns>Returns a  ListCollaborationsResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborations">REST API Reference for ListCollaborations Operation</seealso>
        public virtual ListCollaborationsResponse EndListCollaborations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCollaborationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConfiguredAudienceModelAssociations

        /// <summary>
        /// Lists information about requested configured audience model associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredAudienceModelAssociations service method.</param>
        /// 
        /// <returns>The response from the ListConfiguredAudienceModelAssociations service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListConfiguredAudienceModelAssociations">REST API Reference for ListConfiguredAudienceModelAssociations Operation</seealso>
        public virtual ListConfiguredAudienceModelAssociationsResponse ListConfiguredAudienceModelAssociations(ListConfiguredAudienceModelAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfiguredAudienceModelAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfiguredAudienceModelAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListConfiguredAudienceModelAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfiguredAudienceModelAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredAudienceModelAssociations operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfiguredAudienceModelAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListConfiguredAudienceModelAssociations">REST API Reference for ListConfiguredAudienceModelAssociations Operation</seealso>
        public virtual IAsyncResult BeginListConfiguredAudienceModelAssociations(ListConfiguredAudienceModelAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfiguredAudienceModelAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfiguredAudienceModelAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfiguredAudienceModelAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfiguredAudienceModelAssociations.</param>
        /// 
        /// <returns>Returns a  ListConfiguredAudienceModelAssociationsResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListConfiguredAudienceModelAssociations">REST API Reference for ListConfiguredAudienceModelAssociations Operation</seealso>
        public virtual ListConfiguredAudienceModelAssociationsResponse EndListConfiguredAudienceModelAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConfiguredAudienceModelAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConfiguredTableAssociations

        /// <summary>
        /// Lists configured table associations for a membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredTableAssociations service method.</param>
        /// 
        /// <returns>The response from the ListConfiguredTableAssociations service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListConfiguredTableAssociations">REST API Reference for ListConfiguredTableAssociations Operation</seealso>
        public virtual ListConfiguredTableAssociationsResponse ListConfiguredTableAssociations(ListConfiguredTableAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfiguredTableAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfiguredTableAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListConfiguredTableAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfiguredTableAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredTableAssociations operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfiguredTableAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListConfiguredTableAssociations">REST API Reference for ListConfiguredTableAssociations Operation</seealso>
        public virtual IAsyncResult BeginListConfiguredTableAssociations(ListConfiguredTableAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfiguredTableAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfiguredTableAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfiguredTableAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfiguredTableAssociations.</param>
        /// 
        /// <returns>Returns a  ListConfiguredTableAssociationsResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListConfiguredTableAssociations">REST API Reference for ListConfiguredTableAssociations Operation</seealso>
        public virtual ListConfiguredTableAssociationsResponse EndListConfiguredTableAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConfiguredTableAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConfiguredTables

        /// <summary>
        /// Lists configured tables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredTables service method.</param>
        /// 
        /// <returns>The response from the ListConfiguredTables service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListConfiguredTables">REST API Reference for ListConfiguredTables Operation</seealso>
        public virtual ListConfiguredTablesResponse ListConfiguredTables(ListConfiguredTablesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfiguredTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfiguredTablesResponseUnmarshaller.Instance;

            return Invoke<ListConfiguredTablesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfiguredTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredTables operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfiguredTables
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListConfiguredTables">REST API Reference for ListConfiguredTables Operation</seealso>
        public virtual IAsyncResult BeginListConfiguredTables(ListConfiguredTablesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfiguredTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfiguredTablesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfiguredTables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfiguredTables.</param>
        /// 
        /// <returns>Returns a  ListConfiguredTablesResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListConfiguredTables">REST API Reference for ListConfiguredTables Operation</seealso>
        public virtual ListConfiguredTablesResponse EndListConfiguredTables(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConfiguredTablesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIdMappingTables

        /// <summary>
        /// Returns a list of ID mapping tables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdMappingTables service method.</param>
        /// 
        /// <returns>The response from the ListIdMappingTables service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListIdMappingTables">REST API Reference for ListIdMappingTables Operation</seealso>
        public virtual ListIdMappingTablesResponse ListIdMappingTables(ListIdMappingTablesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdMappingTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdMappingTablesResponseUnmarshaller.Instance;

            return Invoke<ListIdMappingTablesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdMappingTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdMappingTables operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdMappingTables
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListIdMappingTables">REST API Reference for ListIdMappingTables Operation</seealso>
        public virtual IAsyncResult BeginListIdMappingTables(ListIdMappingTablesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdMappingTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdMappingTablesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdMappingTables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdMappingTables.</param>
        /// 
        /// <returns>Returns a  ListIdMappingTablesResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListIdMappingTables">REST API Reference for ListIdMappingTables Operation</seealso>
        public virtual ListIdMappingTablesResponse EndListIdMappingTables(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIdMappingTablesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIdNamespaceAssociations

        /// <summary>
        /// Returns a list of ID namespace associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdNamespaceAssociations service method.</param>
        /// 
        /// <returns>The response from the ListIdNamespaceAssociations service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListIdNamespaceAssociations">REST API Reference for ListIdNamespaceAssociations Operation</seealso>
        public virtual ListIdNamespaceAssociationsResponse ListIdNamespaceAssociations(ListIdNamespaceAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdNamespaceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdNamespaceAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListIdNamespaceAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdNamespaceAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdNamespaceAssociations operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdNamespaceAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListIdNamespaceAssociations">REST API Reference for ListIdNamespaceAssociations Operation</seealso>
        public virtual IAsyncResult BeginListIdNamespaceAssociations(ListIdNamespaceAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdNamespaceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdNamespaceAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdNamespaceAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdNamespaceAssociations.</param>
        /// 
        /// <returns>Returns a  ListIdNamespaceAssociationsResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListIdNamespaceAssociations">REST API Reference for ListIdNamespaceAssociations Operation</seealso>
        public virtual ListIdNamespaceAssociationsResponse EndListIdNamespaceAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIdNamespaceAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMembers

        /// <summary>
        /// Lists all members within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual ListMembersResponse ListMembers(ListMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersResponseUnmarshaller.Instance;

            return Invoke<ListMembersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMembers operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual IAsyncResult BeginListMembers(ListMembersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMembers.</param>
        /// 
        /// <returns>Returns a  ListMembersResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual ListMembersResponse EndListMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMembersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMemberships

        /// <summary>
        /// Lists all memberships resources within the caller's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberships service method.</param>
        /// 
        /// <returns>The response from the ListMemberships service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListMemberships">REST API Reference for ListMemberships Operation</seealso>
        public virtual ListMembershipsResponse ListMemberships(ListMembershipsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembershipsResponseUnmarshaller.Instance;

            return Invoke<ListMembershipsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMemberships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMemberships operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMemberships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListMemberships">REST API Reference for ListMemberships Operation</seealso>
        public virtual IAsyncResult BeginListMemberships(ListMembershipsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembershipsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMemberships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMemberships.</param>
        /// 
        /// <returns>Returns a  ListMembershipsResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListMemberships">REST API Reference for ListMemberships Operation</seealso>
        public virtual ListMembershipsResponse EndListMemberships(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMembershipsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPrivacyBudgets

        /// <summary>
        /// Returns detailed information about the privacy budgets in a specified membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrivacyBudgets service method.</param>
        /// 
        /// <returns>The response from the ListPrivacyBudgets service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListPrivacyBudgets">REST API Reference for ListPrivacyBudgets Operation</seealso>
        public virtual ListPrivacyBudgetsResponse ListPrivacyBudgets(ListPrivacyBudgetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrivacyBudgetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrivacyBudgetsResponseUnmarshaller.Instance;

            return Invoke<ListPrivacyBudgetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPrivacyBudgets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPrivacyBudgets operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPrivacyBudgets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListPrivacyBudgets">REST API Reference for ListPrivacyBudgets Operation</seealso>
        public virtual IAsyncResult BeginListPrivacyBudgets(ListPrivacyBudgetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrivacyBudgetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrivacyBudgetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPrivacyBudgets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPrivacyBudgets.</param>
        /// 
        /// <returns>Returns a  ListPrivacyBudgetsResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListPrivacyBudgets">REST API Reference for ListPrivacyBudgets Operation</seealso>
        public virtual ListPrivacyBudgetsResponse EndListPrivacyBudgets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPrivacyBudgetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPrivacyBudgetTemplates

        /// <summary>
        /// Returns detailed information about the privacy budget templates in a specified membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrivacyBudgetTemplates service method.</param>
        /// 
        /// <returns>The response from the ListPrivacyBudgetTemplates service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListPrivacyBudgetTemplates">REST API Reference for ListPrivacyBudgetTemplates Operation</seealso>
        public virtual ListPrivacyBudgetTemplatesResponse ListPrivacyBudgetTemplates(ListPrivacyBudgetTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrivacyBudgetTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrivacyBudgetTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListPrivacyBudgetTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPrivacyBudgetTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPrivacyBudgetTemplates operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPrivacyBudgetTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListPrivacyBudgetTemplates">REST API Reference for ListPrivacyBudgetTemplates Operation</seealso>
        public virtual IAsyncResult BeginListPrivacyBudgetTemplates(ListPrivacyBudgetTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrivacyBudgetTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrivacyBudgetTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPrivacyBudgetTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPrivacyBudgetTemplates.</param>
        /// 
        /// <returns>Returns a  ListPrivacyBudgetTemplatesResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListPrivacyBudgetTemplates">REST API Reference for ListPrivacyBudgetTemplates Operation</seealso>
        public virtual ListPrivacyBudgetTemplatesResponse EndListPrivacyBudgetTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPrivacyBudgetTemplatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProtectedJobs

        /// <summary>
        /// Lists protected jobs, sorted by most recent job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtectedJobs service method.</param>
        /// 
        /// <returns>The response from the ListProtectedJobs service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListProtectedJobs">REST API Reference for ListProtectedJobs Operation</seealso>
        public virtual ListProtectedJobsResponse ListProtectedJobs(ListProtectedJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProtectedJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectedJobsResponseUnmarshaller.Instance;

            return Invoke<ListProtectedJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProtectedJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProtectedJobs operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProtectedJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListProtectedJobs">REST API Reference for ListProtectedJobs Operation</seealso>
        public virtual IAsyncResult BeginListProtectedJobs(ListProtectedJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProtectedJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectedJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProtectedJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProtectedJobs.</param>
        /// 
        /// <returns>Returns a  ListProtectedJobsResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListProtectedJobs">REST API Reference for ListProtectedJobs Operation</seealso>
        public virtual ListProtectedJobsResponse EndListProtectedJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProtectedJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProtectedQueries

        /// <summary>
        /// Lists protected queries, sorted by the most recent query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtectedQueries service method.</param>
        /// 
        /// <returns>The response from the ListProtectedQueries service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListProtectedQueries">REST API Reference for ListProtectedQueries Operation</seealso>
        public virtual ListProtectedQueriesResponse ListProtectedQueries(ListProtectedQueriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProtectedQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectedQueriesResponseUnmarshaller.Instance;

            return Invoke<ListProtectedQueriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProtectedQueries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProtectedQueries operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProtectedQueries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListProtectedQueries">REST API Reference for ListProtectedQueries Operation</seealso>
        public virtual IAsyncResult BeginListProtectedQueries(ListProtectedQueriesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProtectedQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectedQueriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProtectedQueries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProtectedQueries.</param>
        /// 
        /// <returns>Returns a  ListProtectedQueriesResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListProtectedQueries">REST API Reference for ListProtectedQueries Operation</seealso>
        public virtual ListProtectedQueriesResponse EndListProtectedQueries(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProtectedQueriesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSchemas

        /// <summary>
        /// Lists the schemas for relations within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas service method.</param>
        /// 
        /// <returns>The response from the ListSchemas service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        public virtual ListSchemasResponse ListSchemas(ListSchemasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemasResponseUnmarshaller.Instance;

            return Invoke<ListSchemasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSchemas
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        public virtual IAsyncResult BeginListSchemas(ListSchemasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSchemas operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSchemas.</param>
        /// 
        /// <returns>Returns a  ListSchemasResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        public virtual ListSchemasResponse EndListSchemas(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSchemasResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all of the tags that have been added to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PopulateIdMappingTable

        /// <summary>
        /// Defines the information that's necessary to populate an ID mapping table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PopulateIdMappingTable service method.</param>
        /// 
        /// <returns>The response from the PopulateIdMappingTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/PopulateIdMappingTable">REST API Reference for PopulateIdMappingTable Operation</seealso>
        public virtual PopulateIdMappingTableResponse PopulateIdMappingTable(PopulateIdMappingTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PopulateIdMappingTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PopulateIdMappingTableResponseUnmarshaller.Instance;

            return Invoke<PopulateIdMappingTableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PopulateIdMappingTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PopulateIdMappingTable operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPopulateIdMappingTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/PopulateIdMappingTable">REST API Reference for PopulateIdMappingTable Operation</seealso>
        public virtual IAsyncResult BeginPopulateIdMappingTable(PopulateIdMappingTableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PopulateIdMappingTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PopulateIdMappingTableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PopulateIdMappingTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPopulateIdMappingTable.</param>
        /// 
        /// <returns>Returns a  PopulateIdMappingTableResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/PopulateIdMappingTable">REST API Reference for PopulateIdMappingTable Operation</seealso>
        public virtual PopulateIdMappingTableResponse EndPopulateIdMappingTable(IAsyncResult asyncResult)
        {
            return EndInvoke<PopulateIdMappingTableResponse>(asyncResult);
        }

        #endregion
        
        #region  PreviewPrivacyImpact

        /// <summary>
        /// An estimate of the number of aggregation functions that the member who can query can
        /// run given epsilon and noise parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PreviewPrivacyImpact service method.</param>
        /// 
        /// <returns>The response from the PreviewPrivacyImpact service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/PreviewPrivacyImpact">REST API Reference for PreviewPrivacyImpact Operation</seealso>
        public virtual PreviewPrivacyImpactResponse PreviewPrivacyImpact(PreviewPrivacyImpactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PreviewPrivacyImpactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PreviewPrivacyImpactResponseUnmarshaller.Instance;

            return Invoke<PreviewPrivacyImpactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PreviewPrivacyImpact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PreviewPrivacyImpact operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPreviewPrivacyImpact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/PreviewPrivacyImpact">REST API Reference for PreviewPrivacyImpact Operation</seealso>
        public virtual IAsyncResult BeginPreviewPrivacyImpact(PreviewPrivacyImpactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PreviewPrivacyImpactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PreviewPrivacyImpactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PreviewPrivacyImpact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPreviewPrivacyImpact.</param>
        /// 
        /// <returns>Returns a  PreviewPrivacyImpactResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/PreviewPrivacyImpact">REST API Reference for PreviewPrivacyImpact Operation</seealso>
        public virtual PreviewPrivacyImpactResponse EndPreviewPrivacyImpact(IAsyncResult asyncResult)
        {
            return EndInvoke<PreviewPrivacyImpactResponse>(asyncResult);
        }

        #endregion
        
        #region  StartProtectedJob

        /// <summary>
        /// Creates a protected job that is started by Clean Rooms.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartProtectedJob service method.</param>
        /// 
        /// <returns>The response from the StartProtectedJob service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/StartProtectedJob">REST API Reference for StartProtectedJob Operation</seealso>
        public virtual StartProtectedJobResponse StartProtectedJob(StartProtectedJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartProtectedJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartProtectedJobResponseUnmarshaller.Instance;

            return Invoke<StartProtectedJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartProtectedJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartProtectedJob operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartProtectedJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/StartProtectedJob">REST API Reference for StartProtectedJob Operation</seealso>
        public virtual IAsyncResult BeginStartProtectedJob(StartProtectedJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartProtectedJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartProtectedJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartProtectedJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartProtectedJob.</param>
        /// 
        /// <returns>Returns a  StartProtectedJobResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/StartProtectedJob">REST API Reference for StartProtectedJob Operation</seealso>
        public virtual StartProtectedJobResponse EndStartProtectedJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartProtectedJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartProtectedQuery

        /// <summary>
        /// Creates a protected query that is started by Clean Rooms.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartProtectedQuery service method.</param>
        /// 
        /// <returns>The response from the StartProtectedQuery service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/StartProtectedQuery">REST API Reference for StartProtectedQuery Operation</seealso>
        public virtual StartProtectedQueryResponse StartProtectedQuery(StartProtectedQueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartProtectedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartProtectedQueryResponseUnmarshaller.Instance;

            return Invoke<StartProtectedQueryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartProtectedQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartProtectedQuery operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartProtectedQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/StartProtectedQuery">REST API Reference for StartProtectedQuery Operation</seealso>
        public virtual IAsyncResult BeginStartProtectedQuery(StartProtectedQueryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartProtectedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartProtectedQueryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartProtectedQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartProtectedQuery.</param>
        /// 
        /// <returns>Returns a  StartProtectedQueryResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/StartProtectedQuery">REST API Reference for StartProtectedQuery Operation</seealso>
        public virtual StartProtectedQueryResponse EndStartProtectedQuery(IAsyncResult asyncResult)
        {
            return EndInvoke<StartProtectedQueryResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Tags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a tag or list of tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAnalysisTemplate

        /// <summary>
        /// Updates the analysis template metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnalysisTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateAnalysisTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateAnalysisTemplate">REST API Reference for UpdateAnalysisTemplate Operation</seealso>
        public virtual UpdateAnalysisTemplateResponse UpdateAnalysisTemplate(UpdateAnalysisTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnalysisTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateAnalysisTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAnalysisTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnalysisTemplate operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAnalysisTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateAnalysisTemplate">REST API Reference for UpdateAnalysisTemplate Operation</seealso>
        public virtual IAsyncResult BeginUpdateAnalysisTemplate(UpdateAnalysisTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAnalysisTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnalysisTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAnalysisTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAnalysisTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateAnalysisTemplateResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateAnalysisTemplate">REST API Reference for UpdateAnalysisTemplate Operation</seealso>
        public virtual UpdateAnalysisTemplateResponse EndUpdateAnalysisTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAnalysisTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCollaboration

        /// <summary>
        /// Updates collaboration metadata and can only be called by the collaboration owner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCollaboration service method.</param>
        /// 
        /// <returns>The response from the UpdateCollaboration service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateCollaboration">REST API Reference for UpdateCollaboration Operation</seealso>
        public virtual UpdateCollaborationResponse UpdateCollaboration(UpdateCollaborationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCollaborationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCollaborationResponseUnmarshaller.Instance;

            return Invoke<UpdateCollaborationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCollaboration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCollaboration operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCollaboration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateCollaboration">REST API Reference for UpdateCollaboration Operation</seealso>
        public virtual IAsyncResult BeginUpdateCollaboration(UpdateCollaborationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCollaborationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCollaborationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCollaboration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCollaboration.</param>
        /// 
        /// <returns>Returns a  UpdateCollaborationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateCollaboration">REST API Reference for UpdateCollaboration Operation</seealso>
        public virtual UpdateCollaborationResponse EndUpdateCollaboration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCollaborationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConfiguredAudienceModelAssociation

        /// <summary>
        /// Provides the details necessary to update a configured audience model association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredAudienceModelAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateConfiguredAudienceModelAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredAudienceModelAssociation">REST API Reference for UpdateConfiguredAudienceModelAssociation Operation</seealso>
        public virtual UpdateConfiguredAudienceModelAssociationResponse UpdateConfiguredAudienceModelAssociation(UpdateConfiguredAudienceModelAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredAudienceModelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredAudienceModelAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateConfiguredAudienceModelAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfiguredAudienceModelAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredAudienceModelAssociation operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfiguredAudienceModelAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredAudienceModelAssociation">REST API Reference for UpdateConfiguredAudienceModelAssociation Operation</seealso>
        public virtual IAsyncResult BeginUpdateConfiguredAudienceModelAssociation(UpdateConfiguredAudienceModelAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredAudienceModelAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredAudienceModelAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfiguredAudienceModelAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfiguredAudienceModelAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateConfiguredAudienceModelAssociationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredAudienceModelAssociation">REST API Reference for UpdateConfiguredAudienceModelAssociation Operation</seealso>
        public virtual UpdateConfiguredAudienceModelAssociationResponse EndUpdateConfiguredAudienceModelAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConfiguredAudienceModelAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConfiguredTable

        /// <summary>
        /// Updates a configured table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTable service method.</param>
        /// 
        /// <returns>The response from the UpdateConfiguredTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTable">REST API Reference for UpdateConfiguredTable Operation</seealso>
        public virtual UpdateConfiguredTableResponse UpdateConfiguredTable(UpdateConfiguredTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredTableResponseUnmarshaller.Instance;

            return Invoke<UpdateConfiguredTableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfiguredTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTable operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfiguredTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTable">REST API Reference for UpdateConfiguredTable Operation</seealso>
        public virtual IAsyncResult BeginUpdateConfiguredTable(UpdateConfiguredTableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredTableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfiguredTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfiguredTable.</param>
        /// 
        /// <returns>Returns a  UpdateConfiguredTableResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTable">REST API Reference for UpdateConfiguredTable Operation</seealso>
        public virtual UpdateConfiguredTableResponse EndUpdateConfiguredTable(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConfiguredTableResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConfiguredTableAnalysisRule

        /// <summary>
        /// Updates a configured table analysis rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTableAnalysisRule service method.</param>
        /// 
        /// <returns>The response from the UpdateConfiguredTableAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTableAnalysisRule">REST API Reference for UpdateConfiguredTableAnalysisRule Operation</seealso>
        public virtual UpdateConfiguredTableAnalysisRuleResponse UpdateConfiguredTableAnalysisRule(UpdateConfiguredTableAnalysisRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredTableAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredTableAnalysisRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateConfiguredTableAnalysisRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfiguredTableAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTableAnalysisRule operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfiguredTableAnalysisRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTableAnalysisRule">REST API Reference for UpdateConfiguredTableAnalysisRule Operation</seealso>
        public virtual IAsyncResult BeginUpdateConfiguredTableAnalysisRule(UpdateConfiguredTableAnalysisRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredTableAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredTableAnalysisRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfiguredTableAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfiguredTableAnalysisRule.</param>
        /// 
        /// <returns>Returns a  UpdateConfiguredTableAnalysisRuleResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTableAnalysisRule">REST API Reference for UpdateConfiguredTableAnalysisRule Operation</seealso>
        public virtual UpdateConfiguredTableAnalysisRuleResponse EndUpdateConfiguredTableAnalysisRule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConfiguredTableAnalysisRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConfiguredTableAssociation

        /// <summary>
        /// Updates a configured table association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTableAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateConfiguredTableAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTableAssociation">REST API Reference for UpdateConfiguredTableAssociation Operation</seealso>
        public virtual UpdateConfiguredTableAssociationResponse UpdateConfiguredTableAssociation(UpdateConfiguredTableAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredTableAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredTableAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateConfiguredTableAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfiguredTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTableAssociation operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfiguredTableAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTableAssociation">REST API Reference for UpdateConfiguredTableAssociation Operation</seealso>
        public virtual IAsyncResult BeginUpdateConfiguredTableAssociation(UpdateConfiguredTableAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredTableAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredTableAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfiguredTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfiguredTableAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateConfiguredTableAssociationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTableAssociation">REST API Reference for UpdateConfiguredTableAssociation Operation</seealso>
        public virtual UpdateConfiguredTableAssociationResponse EndUpdateConfiguredTableAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConfiguredTableAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConfiguredTableAssociationAnalysisRule

        /// <summary>
        /// Updates the analysis rule for a configured table association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTableAssociationAnalysisRule service method.</param>
        /// 
        /// <returns>The response from the UpdateConfiguredTableAssociationAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTableAssociationAnalysisRule">REST API Reference for UpdateConfiguredTableAssociationAnalysisRule Operation</seealso>
        public virtual UpdateConfiguredTableAssociationAnalysisRuleResponse UpdateConfiguredTableAssociationAnalysisRule(UpdateConfiguredTableAssociationAnalysisRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredTableAssociationAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredTableAssociationAnalysisRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateConfiguredTableAssociationAnalysisRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfiguredTableAssociationAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTableAssociationAnalysisRule operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfiguredTableAssociationAnalysisRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTableAssociationAnalysisRule">REST API Reference for UpdateConfiguredTableAssociationAnalysisRule Operation</seealso>
        public virtual IAsyncResult BeginUpdateConfiguredTableAssociationAnalysisRule(UpdateConfiguredTableAssociationAnalysisRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredTableAssociationAnalysisRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredTableAssociationAnalysisRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfiguredTableAssociationAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfiguredTableAssociationAnalysisRule.</param>
        /// 
        /// <returns>Returns a  UpdateConfiguredTableAssociationAnalysisRuleResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTableAssociationAnalysisRule">REST API Reference for UpdateConfiguredTableAssociationAnalysisRule Operation</seealso>
        public virtual UpdateConfiguredTableAssociationAnalysisRuleResponse EndUpdateConfiguredTableAssociationAnalysisRule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConfiguredTableAssociationAnalysisRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIdMappingTable

        /// <summary>
        /// Provides the details that are necessary to update an ID mapping table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdMappingTable service method.</param>
        /// 
        /// <returns>The response from the UpdateIdMappingTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateIdMappingTable">REST API Reference for UpdateIdMappingTable Operation</seealso>
        public virtual UpdateIdMappingTableResponse UpdateIdMappingTable(UpdateIdMappingTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdMappingTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdMappingTableResponseUnmarshaller.Instance;

            return Invoke<UpdateIdMappingTableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdMappingTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdMappingTable operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIdMappingTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateIdMappingTable">REST API Reference for UpdateIdMappingTable Operation</seealso>
        public virtual IAsyncResult BeginUpdateIdMappingTable(UpdateIdMappingTableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdMappingTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdMappingTableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIdMappingTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIdMappingTable.</param>
        /// 
        /// <returns>Returns a  UpdateIdMappingTableResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateIdMappingTable">REST API Reference for UpdateIdMappingTable Operation</seealso>
        public virtual UpdateIdMappingTableResponse EndUpdateIdMappingTable(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIdMappingTableResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIdNamespaceAssociation

        /// <summary>
        /// Provides the details that are necessary to update an ID namespace association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdNamespaceAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateIdNamespaceAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateIdNamespaceAssociation">REST API Reference for UpdateIdNamespaceAssociation Operation</seealso>
        public virtual UpdateIdNamespaceAssociationResponse UpdateIdNamespaceAssociation(UpdateIdNamespaceAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdNamespaceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdNamespaceAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateIdNamespaceAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdNamespaceAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdNamespaceAssociation operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIdNamespaceAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateIdNamespaceAssociation">REST API Reference for UpdateIdNamespaceAssociation Operation</seealso>
        public virtual IAsyncResult BeginUpdateIdNamespaceAssociation(UpdateIdNamespaceAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdNamespaceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdNamespaceAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIdNamespaceAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIdNamespaceAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateIdNamespaceAssociationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateIdNamespaceAssociation">REST API Reference for UpdateIdNamespaceAssociation Operation</seealso>
        public virtual UpdateIdNamespaceAssociationResponse EndUpdateIdNamespaceAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIdNamespaceAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMembership

        /// <summary>
        /// Updates a membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMembership service method.</param>
        /// 
        /// <returns>The response from the UpdateMembership service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateMembership">REST API Reference for UpdateMembership Operation</seealso>
        public virtual UpdateMembershipResponse UpdateMembership(UpdateMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMembershipResponseUnmarshaller.Instance;

            return Invoke<UpdateMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMembership operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateMembership">REST API Reference for UpdateMembership Operation</seealso>
        public virtual IAsyncResult BeginUpdateMembership(UpdateMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMembership.</param>
        /// 
        /// <returns>Returns a  UpdateMembershipResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateMembership">REST API Reference for UpdateMembership Operation</seealso>
        public virtual UpdateMembershipResponse EndUpdateMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePrivacyBudgetTemplate

        /// <summary>
        /// Updates the privacy budget template for the specified collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrivacyBudgetTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdatePrivacyBudgetTemplate service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdatePrivacyBudgetTemplate">REST API Reference for UpdatePrivacyBudgetTemplate Operation</seealso>
        public virtual UpdatePrivacyBudgetTemplateResponse UpdatePrivacyBudgetTemplate(UpdatePrivacyBudgetTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePrivacyBudgetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePrivacyBudgetTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdatePrivacyBudgetTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePrivacyBudgetTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrivacyBudgetTemplate operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePrivacyBudgetTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdatePrivacyBudgetTemplate">REST API Reference for UpdatePrivacyBudgetTemplate Operation</seealso>
        public virtual IAsyncResult BeginUpdatePrivacyBudgetTemplate(UpdatePrivacyBudgetTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePrivacyBudgetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePrivacyBudgetTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePrivacyBudgetTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePrivacyBudgetTemplate.</param>
        /// 
        /// <returns>Returns a  UpdatePrivacyBudgetTemplateResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdatePrivacyBudgetTemplate">REST API Reference for UpdatePrivacyBudgetTemplate Operation</seealso>
        public virtual UpdatePrivacyBudgetTemplateResponse EndUpdatePrivacyBudgetTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePrivacyBudgetTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProtectedJob

        /// <summary>
        /// Updates the processing of a currently running job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProtectedJob service method.</param>
        /// 
        /// <returns>The response from the UpdateProtectedJob service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateProtectedJob">REST API Reference for UpdateProtectedJob Operation</seealso>
        public virtual UpdateProtectedJobResponse UpdateProtectedJob(UpdateProtectedJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProtectedJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProtectedJobResponseUnmarshaller.Instance;

            return Invoke<UpdateProtectedJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProtectedJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProtectedJob operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProtectedJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateProtectedJob">REST API Reference for UpdateProtectedJob Operation</seealso>
        public virtual IAsyncResult BeginUpdateProtectedJob(UpdateProtectedJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProtectedJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProtectedJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProtectedJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProtectedJob.</param>
        /// 
        /// <returns>Returns a  UpdateProtectedJobResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateProtectedJob">REST API Reference for UpdateProtectedJob Operation</seealso>
        public virtual UpdateProtectedJobResponse EndUpdateProtectedJob(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProtectedJobResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProtectedQuery

        /// <summary>
        /// Updates the processing of a currently running query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProtectedQuery service method.</param>
        /// 
        /// <returns>The response from the UpdateProtectedQuery service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateProtectedQuery">REST API Reference for UpdateProtectedQuery Operation</seealso>
        public virtual UpdateProtectedQueryResponse UpdateProtectedQuery(UpdateProtectedQueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProtectedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProtectedQueryResponseUnmarshaller.Instance;

            return Invoke<UpdateProtectedQueryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProtectedQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProtectedQuery operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProtectedQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateProtectedQuery">REST API Reference for UpdateProtectedQuery Operation</seealso>
        public virtual IAsyncResult BeginUpdateProtectedQuery(UpdateProtectedQueryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProtectedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProtectedQueryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProtectedQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProtectedQuery.</param>
        /// 
        /// <returns>Returns a  UpdateProtectedQueryResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateProtectedQuery">REST API Reference for UpdateProtectedQuery Operation</seealso>
        public virtual UpdateProtectedQueryResponse EndUpdateProtectedQuery(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProtectedQueryResponse>(asyncResult);
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
            var resolver = new AmazonCleanRoomsEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}