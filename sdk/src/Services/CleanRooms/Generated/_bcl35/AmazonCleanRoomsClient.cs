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

namespace Amazon.CleanRooms
{
    /// <summary>
    /// Implementation for accessing CleanRooms
    ///
    /// Welcome to the <i>AWS Clean Rooms API Reference</i>.
    /// 
    ///  
    /// <para>
    /// AWS Clean Rooms is an AWS service that helps multiple parties to join their data together
    /// in a secure collaboration workspace. In the collaboration, members who can query and
    /// receive results can get insights into the collective datasets without either party
    /// getting access to the other party's raw data.
    /// </para>
    ///  
    /// <para>
    /// To learn more about AWS Clean Rooms concepts, procedures, and best practices, see
    /// the <a href="https://docs.aws.amazon.com/clean-rooms/latest/userguide/what-is.html">AWS
    /// Clean Rooms User Guide</a>.
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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
        
        #region  StartProtectedQuery

        /// <summary>
        /// Creates a protected query that is started by AWS Clean Rooms.
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
        
    }
}