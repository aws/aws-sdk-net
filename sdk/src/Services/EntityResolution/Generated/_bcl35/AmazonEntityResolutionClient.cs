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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.EntityResolution.Model;
using Amazon.EntityResolution.Model.Internal.MarshallTransformations;
using Amazon.EntityResolution.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.EntityResolution
{
    /// <summary>
    /// <para>Implementation for accessing EntityResolution</para>
    ///
    /// Welcome to the <i>Entity Resolution API Reference</i>.
    /// 
    ///  
    /// <para>
    /// Entity Resolution is an Amazon Web Services service that provides pre-configured entity
    /// resolution capabilities that enable developers and analysts at advertising and marketing
    /// companies to build an accurate and complete view of their consumers.
    /// </para>
    ///  
    /// <para>
    ///  With Entity Resolution, you can match source records containing consumer identifiers,
    /// such as name, email address, and phone number. This is true even when these records
    /// have incomplete or conflicting identifiers. For example, Entity Resolution can effectively
    /// match a source record from a customer relationship management (CRM) system with a
    /// source record from a marketing system containing campaign information.
    /// </para>
    ///  
    /// <para>
    /// To learn more about Entity Resolution concepts, procedures, and best practices, see
    /// the <a href="https://docs.aws.amazon.com/entityresolution/latest/userguide/what-is-service.html">Entity
    /// Resolution User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonEntityResolutionClient : AmazonServiceClient, IAmazonEntityResolution
    {
        private static IServiceMetadata serviceMetadata = new AmazonEntityResolutionMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IEntityResolutionPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IEntityResolutionPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new EntityResolutionPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonEntityResolutionClient with the credentials loaded from the application's
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
        public AmazonEntityResolutionClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEntityResolutionConfig()) { }

        /// <summary>
        /// Constructs AmazonEntityResolutionClient with the credentials loaded from the application's
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
        public AmazonEntityResolutionClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEntityResolutionConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonEntityResolutionClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonEntityResolutionClient Configuration Object</param>
        public AmazonEntityResolutionClient(AmazonEntityResolutionConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonEntityResolutionClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonEntityResolutionClient(AWSCredentials credentials)
            : this(credentials, new AmazonEntityResolutionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEntityResolutionClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEntityResolutionClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonEntityResolutionConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEntityResolutionClient with AWS Credentials and an
        /// AmazonEntityResolutionClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonEntityResolutionClient Configuration Object</param>
        public AmazonEntityResolutionClient(AWSCredentials credentials, AmazonEntityResolutionConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEntityResolutionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEntityResolutionClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEntityResolutionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEntityResolutionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEntityResolutionClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEntityResolutionConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonEntityResolutionClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEntityResolutionClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonEntityResolutionClient Configuration Object</param>
        public AmazonEntityResolutionClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonEntityResolutionConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEntityResolutionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonEntityResolutionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEntityResolutionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEntityResolutionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEntityResolutionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEntityResolutionConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEntityResolutionClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEntityResolutionClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonEntityResolutionClient Configuration Object</param>
        public AmazonEntityResolutionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonEntityResolutionConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEntityResolutionEndpointResolver());
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


        #region  AddPolicyStatement

        /// <summary>
        /// Adds a policy statement object. To retrieve a list of existing policy statements,
        /// use the <c>GetPolicy</c> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddPolicyStatement service method.</param>
        /// 
        /// <returns>The response from the AddPolicyStatement service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/AddPolicyStatement">REST API Reference for AddPolicyStatement Operation</seealso>
        public virtual AddPolicyStatementResponse AddPolicyStatement(AddPolicyStatementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddPolicyStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddPolicyStatementResponseUnmarshaller.Instance;

            return Invoke<AddPolicyStatementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddPolicyStatement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddPolicyStatement operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddPolicyStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/AddPolicyStatement">REST API Reference for AddPolicyStatement Operation</seealso>
        public virtual IAsyncResult BeginAddPolicyStatement(AddPolicyStatementRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddPolicyStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddPolicyStatementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddPolicyStatement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddPolicyStatement.</param>
        /// 
        /// <returns>Returns a  AddPolicyStatementResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/AddPolicyStatement">REST API Reference for AddPolicyStatement Operation</seealso>
        public virtual AddPolicyStatementResponse EndAddPolicyStatement(IAsyncResult asyncResult)
        {
            return EndInvoke<AddPolicyStatementResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDeleteUniqueId

        /// <summary>
        /// Deletes multiple unique IDs in a matching workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteUniqueId service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteUniqueId service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/BatchDeleteUniqueId">REST API Reference for BatchDeleteUniqueId Operation</seealso>
        public virtual BatchDeleteUniqueIdResponse BatchDeleteUniqueId(BatchDeleteUniqueIdRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteUniqueIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteUniqueIdResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteUniqueIdResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteUniqueId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteUniqueId operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteUniqueId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/BatchDeleteUniqueId">REST API Reference for BatchDeleteUniqueId Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteUniqueId(BatchDeleteUniqueIdRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteUniqueIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteUniqueIdResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteUniqueId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteUniqueId.</param>
        /// 
        /// <returns>Returns a  BatchDeleteUniqueIdResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/BatchDeleteUniqueId">REST API Reference for BatchDeleteUniqueId Operation</seealso>
        public virtual BatchDeleteUniqueIdResponse EndBatchDeleteUniqueId(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteUniqueIdResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIdMappingWorkflow

        /// <summary>
        /// Creates an <c>IdMappingWorkflow</c> object which stores the configuration of the data
        /// processing job to be run. Each <c>IdMappingWorkflow</c> must have a unique workflow
        /// name. To modify an existing workflow, use the UpdateIdMappingWorkflow API.
        /// 
        ///  <important> 
        /// <para>
        /// Incremental processing is not supported for ID mapping workflows. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdMappingWorkflow service method.</param>
        /// 
        /// <returns>The response from the CreateIdMappingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateIdMappingWorkflow">REST API Reference for CreateIdMappingWorkflow Operation</seealso>
        public virtual CreateIdMappingWorkflowResponse CreateIdMappingWorkflow(CreateIdMappingWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIdMappingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdMappingWorkflowResponseUnmarshaller.Instance;

            return Invoke<CreateIdMappingWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIdMappingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIdMappingWorkflow operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIdMappingWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateIdMappingWorkflow">REST API Reference for CreateIdMappingWorkflow Operation</seealso>
        public virtual IAsyncResult BeginCreateIdMappingWorkflow(CreateIdMappingWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIdMappingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdMappingWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIdMappingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIdMappingWorkflow.</param>
        /// 
        /// <returns>Returns a  CreateIdMappingWorkflowResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateIdMappingWorkflow">REST API Reference for CreateIdMappingWorkflow Operation</seealso>
        public virtual CreateIdMappingWorkflowResponse EndCreateIdMappingWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIdMappingWorkflowResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIdNamespace

        /// <summary>
        /// Creates an ID namespace object which will help customers provide metadata explaining
        /// their dataset and how to use it. Each ID namespace must have a unique name. To modify
        /// an existing ID namespace, use the UpdateIdNamespace API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdNamespace service method.</param>
        /// 
        /// <returns>The response from the CreateIdNamespace service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateIdNamespace">REST API Reference for CreateIdNamespace Operation</seealso>
        public virtual CreateIdNamespaceResponse CreateIdNamespace(CreateIdNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIdNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdNamespaceResponseUnmarshaller.Instance;

            return Invoke<CreateIdNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIdNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIdNamespace operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIdNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateIdNamespace">REST API Reference for CreateIdNamespace Operation</seealso>
        public virtual IAsyncResult BeginCreateIdNamespace(CreateIdNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIdNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIdNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIdNamespace.</param>
        /// 
        /// <returns>Returns a  CreateIdNamespaceResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateIdNamespace">REST API Reference for CreateIdNamespace Operation</seealso>
        public virtual CreateIdNamespaceResponse EndCreateIdNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIdNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMatchingWorkflow

        /// <summary>
        /// Creates a matching workflow that defines the configuration for a data processing job.
        /// The workflow name must be unique. To modify an existing workflow, use <c>UpdateMatchingWorkflow</c>.
        /// 
        /// 
        ///  <important> 
        /// <para>
        /// For workflows where <c>resolutionType</c> is <c>ML_MATCHING</c> or <c>PROVIDER</c>,
        /// incremental processing is not supported. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchingWorkflow service method.</param>
        /// 
        /// <returns>The response from the CreateMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateMatchingWorkflow">REST API Reference for CreateMatchingWorkflow Operation</seealso>
        public virtual CreateMatchingWorkflowResponse CreateMatchingWorkflow(CreateMatchingWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMatchingWorkflowResponseUnmarshaller.Instance;

            return Invoke<CreateMatchingWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMatchingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchingWorkflow operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMatchingWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateMatchingWorkflow">REST API Reference for CreateMatchingWorkflow Operation</seealso>
        public virtual IAsyncResult BeginCreateMatchingWorkflow(CreateMatchingWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMatchingWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMatchingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMatchingWorkflow.</param>
        /// 
        /// <returns>Returns a  CreateMatchingWorkflowResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateMatchingWorkflow">REST API Reference for CreateMatchingWorkflow Operation</seealso>
        public virtual CreateMatchingWorkflowResponse EndCreateMatchingWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMatchingWorkflowResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSchemaMapping

        /// <summary>
        /// Creates a schema mapping, which defines the schema of the input customer records table.
        /// The <c>SchemaMapping</c> also provides Entity Resolution with some metadata about
        /// the table, such as the attribute types of the columns and which columns to match on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchemaMapping service method.</param>
        /// 
        /// <returns>The response from the CreateSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateSchemaMapping">REST API Reference for CreateSchemaMapping Operation</seealso>
        public virtual CreateSchemaMappingResponse CreateSchemaMapping(CreateSchemaMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSchemaMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaMappingResponseUnmarshaller.Instance;

            return Invoke<CreateSchemaMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSchemaMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSchemaMapping operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSchemaMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateSchemaMapping">REST API Reference for CreateSchemaMapping Operation</seealso>
        public virtual IAsyncResult BeginCreateSchemaMapping(CreateSchemaMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSchemaMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSchemaMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSchemaMapping.</param>
        /// 
        /// <returns>Returns a  CreateSchemaMappingResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateSchemaMapping">REST API Reference for CreateSchemaMapping Operation</seealso>
        public virtual CreateSchemaMappingResponse EndCreateSchemaMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSchemaMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIdMappingWorkflow

        /// <summary>
        /// Deletes the <c>IdMappingWorkflow</c> with a given name. This operation will succeed
        /// even if a workflow with the given name does not exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdMappingWorkflow service method.</param>
        /// 
        /// <returns>The response from the DeleteIdMappingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteIdMappingWorkflow">REST API Reference for DeleteIdMappingWorkflow Operation</seealso>
        public virtual DeleteIdMappingWorkflowResponse DeleteIdMappingWorkflow(DeleteIdMappingWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIdMappingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdMappingWorkflowResponseUnmarshaller.Instance;

            return Invoke<DeleteIdMappingWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdMappingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdMappingWorkflow operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIdMappingWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteIdMappingWorkflow">REST API Reference for DeleteIdMappingWorkflow Operation</seealso>
        public virtual IAsyncResult BeginDeleteIdMappingWorkflow(DeleteIdMappingWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIdMappingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdMappingWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIdMappingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdMappingWorkflow.</param>
        /// 
        /// <returns>Returns a  DeleteIdMappingWorkflowResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteIdMappingWorkflow">REST API Reference for DeleteIdMappingWorkflow Operation</seealso>
        public virtual DeleteIdMappingWorkflowResponse EndDeleteIdMappingWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIdMappingWorkflowResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIdNamespace

        /// <summary>
        /// Deletes the <c>IdNamespace</c> with a given name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdNamespace service method.</param>
        /// 
        /// <returns>The response from the DeleteIdNamespace service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteIdNamespace">REST API Reference for DeleteIdNamespace Operation</seealso>
        public virtual DeleteIdNamespaceResponse DeleteIdNamespace(DeleteIdNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIdNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdNamespaceResponseUnmarshaller.Instance;

            return Invoke<DeleteIdNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdNamespace operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIdNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteIdNamespace">REST API Reference for DeleteIdNamespace Operation</seealso>
        public virtual IAsyncResult BeginDeleteIdNamespace(DeleteIdNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIdNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIdNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdNamespace.</param>
        /// 
        /// <returns>Returns a  DeleteIdNamespaceResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteIdNamespace">REST API Reference for DeleteIdNamespace Operation</seealso>
        public virtual DeleteIdNamespaceResponse EndDeleteIdNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIdNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMatchingWorkflow

        /// <summary>
        /// Deletes the <c>MatchingWorkflow</c> with a given name. This operation will succeed
        /// even if a workflow with the given name does not exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMatchingWorkflow service method.</param>
        /// 
        /// <returns>The response from the DeleteMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteMatchingWorkflow">REST API Reference for DeleteMatchingWorkflow Operation</seealso>
        public virtual DeleteMatchingWorkflowResponse DeleteMatchingWorkflow(DeleteMatchingWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMatchingWorkflowResponseUnmarshaller.Instance;

            return Invoke<DeleteMatchingWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMatchingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMatchingWorkflow operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMatchingWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteMatchingWorkflow">REST API Reference for DeleteMatchingWorkflow Operation</seealso>
        public virtual IAsyncResult BeginDeleteMatchingWorkflow(DeleteMatchingWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMatchingWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMatchingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMatchingWorkflow.</param>
        /// 
        /// <returns>Returns a  DeleteMatchingWorkflowResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteMatchingWorkflow">REST API Reference for DeleteMatchingWorkflow Operation</seealso>
        public virtual DeleteMatchingWorkflowResponse EndDeleteMatchingWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMatchingWorkflowResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePolicyStatement

        /// <summary>
        /// Deletes the policy statement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyStatement service method.</param>
        /// 
        /// <returns>The response from the DeletePolicyStatement service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeletePolicyStatement">REST API Reference for DeletePolicyStatement Operation</seealso>
        public virtual DeletePolicyStatementResponse DeletePolicyStatement(DeletePolicyStatementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePolicyStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyStatementResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyStatementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicyStatement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyStatement operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePolicyStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeletePolicyStatement">REST API Reference for DeletePolicyStatement Operation</seealso>
        public virtual IAsyncResult BeginDeletePolicyStatement(DeletePolicyStatementRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePolicyStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyStatementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePolicyStatement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePolicyStatement.</param>
        /// 
        /// <returns>Returns a  DeletePolicyStatementResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeletePolicyStatement">REST API Reference for DeletePolicyStatement Operation</seealso>
        public virtual DeletePolicyStatementResponse EndDeletePolicyStatement(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePolicyStatementResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSchemaMapping

        /// <summary>
        /// Deletes the <c>SchemaMapping</c> with a given name. This operation will succeed even
        /// if a schema with the given name does not exist. This operation will fail if there
        /// is a <c>MatchingWorkflow</c> object that references the <c>SchemaMapping</c> in the
        /// workflow's <c>InputSourceConfig</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchemaMapping service method.</param>
        /// 
        /// <returns>The response from the DeleteSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteSchemaMapping">REST API Reference for DeleteSchemaMapping Operation</seealso>
        public virtual DeleteSchemaMappingResponse DeleteSchemaMapping(DeleteSchemaMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSchemaMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaMappingResponseUnmarshaller.Instance;

            return Invoke<DeleteSchemaMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSchemaMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchemaMapping operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSchemaMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteSchemaMapping">REST API Reference for DeleteSchemaMapping Operation</seealso>
        public virtual IAsyncResult BeginDeleteSchemaMapping(DeleteSchemaMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSchemaMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSchemaMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSchemaMapping.</param>
        /// 
        /// <returns>Returns a  DeleteSchemaMappingResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteSchemaMapping">REST API Reference for DeleteSchemaMapping Operation</seealso>
        public virtual DeleteSchemaMappingResponse EndDeleteSchemaMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSchemaMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  GenerateMatchId

        /// <summary>
        /// Generates or retrieves Match IDs for records using a rule-based matching workflow.
        /// When you call this operation, it processes your records against the workflow's matching
        /// rules to identify potential matches. For existing records, it retrieves their Match
        /// IDs and associated rules. For records without matches, it generates new Match IDs.
        /// The operation saves results to Amazon S3. 
        /// 
        ///  
        /// <para>
        /// The processing type (<c>processingType</c>) you choose affects both the accuracy and
        /// response time of the operation. Additional charges apply for each API call, whether
        /// made through the Entity Resolution console or directly via the API. The rule-based
        /// matching workflow must exist and be active before calling this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateMatchId service method.</param>
        /// 
        /// <returns>The response from the GenerateMatchId service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GenerateMatchId">REST API Reference for GenerateMatchId Operation</seealso>
        public virtual GenerateMatchIdResponse GenerateMatchId(GenerateMatchIdRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GenerateMatchIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateMatchIdResponseUnmarshaller.Instance;

            return Invoke<GenerateMatchIdResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateMatchId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateMatchId operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateMatchId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GenerateMatchId">REST API Reference for GenerateMatchId Operation</seealso>
        public virtual IAsyncResult BeginGenerateMatchId(GenerateMatchIdRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GenerateMatchIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateMatchIdResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateMatchId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateMatchId.</param>
        /// 
        /// <returns>Returns a  GenerateMatchIdResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GenerateMatchId">REST API Reference for GenerateMatchId Operation</seealso>
        public virtual GenerateMatchIdResponse EndGenerateMatchId(IAsyncResult asyncResult)
        {
            return EndInvoke<GenerateMatchIdResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIdMappingJob

        /// <summary>
        /// Returns the status, metrics, and errors (if there are any) that are associated with
        /// a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdMappingJob service method.</param>
        /// 
        /// <returns>The response from the GetIdMappingJob service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdMappingJob">REST API Reference for GetIdMappingJob Operation</seealso>
        public virtual GetIdMappingJobResponse GetIdMappingJob(GetIdMappingJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdMappingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdMappingJobResponseUnmarshaller.Instance;

            return Invoke<GetIdMappingJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdMappingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdMappingJob operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdMappingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdMappingJob">REST API Reference for GetIdMappingJob Operation</seealso>
        public virtual IAsyncResult BeginGetIdMappingJob(GetIdMappingJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdMappingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdMappingJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdMappingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdMappingJob.</param>
        /// 
        /// <returns>Returns a  GetIdMappingJobResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdMappingJob">REST API Reference for GetIdMappingJob Operation</seealso>
        public virtual GetIdMappingJobResponse EndGetIdMappingJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIdMappingJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIdMappingWorkflow

        /// <summary>
        /// Returns the <c>IdMappingWorkflow</c> with a given name, if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdMappingWorkflow service method.</param>
        /// 
        /// <returns>The response from the GetIdMappingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdMappingWorkflow">REST API Reference for GetIdMappingWorkflow Operation</seealso>
        public virtual GetIdMappingWorkflowResponse GetIdMappingWorkflow(GetIdMappingWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdMappingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdMappingWorkflowResponseUnmarshaller.Instance;

            return Invoke<GetIdMappingWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdMappingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdMappingWorkflow operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdMappingWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdMappingWorkflow">REST API Reference for GetIdMappingWorkflow Operation</seealso>
        public virtual IAsyncResult BeginGetIdMappingWorkflow(GetIdMappingWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdMappingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdMappingWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdMappingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdMappingWorkflow.</param>
        /// 
        /// <returns>Returns a  GetIdMappingWorkflowResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdMappingWorkflow">REST API Reference for GetIdMappingWorkflow Operation</seealso>
        public virtual GetIdMappingWorkflowResponse EndGetIdMappingWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIdMappingWorkflowResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIdNamespace

        /// <summary>
        /// Returns the <c>IdNamespace</c> with a given name, if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdNamespace service method.</param>
        /// 
        /// <returns>The response from the GetIdNamespace service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdNamespace">REST API Reference for GetIdNamespace Operation</seealso>
        public virtual GetIdNamespaceResponse GetIdNamespace(GetIdNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdNamespaceResponseUnmarshaller.Instance;

            return Invoke<GetIdNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdNamespace operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdNamespace">REST API Reference for GetIdNamespace Operation</seealso>
        public virtual IAsyncResult BeginGetIdNamespace(GetIdNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdNamespace.</param>
        /// 
        /// <returns>Returns a  GetIdNamespaceResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdNamespace">REST API Reference for GetIdNamespace Operation</seealso>
        public virtual GetIdNamespaceResponse EndGetIdNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIdNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMatchId

        /// <summary>
        /// Returns the corresponding Match ID of a customer record if the record has been processed
        /// in a rule-based matching workflow.
        /// 
        ///  
        /// <para>
        /// You can call this API as a dry run of an incremental load on the rule-based matching
        /// workflow.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatchId service method.</param>
        /// 
        /// <returns>The response from the GetMatchId service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchId">REST API Reference for GetMatchId Operation</seealso>
        public virtual GetMatchIdResponse GetMatchId(GetMatchIdRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMatchIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMatchIdResponseUnmarshaller.Instance;

            return Invoke<GetMatchIdResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMatchId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMatchId operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMatchId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchId">REST API Reference for GetMatchId Operation</seealso>
        public virtual IAsyncResult BeginGetMatchId(GetMatchIdRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMatchIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMatchIdResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMatchId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMatchId.</param>
        /// 
        /// <returns>Returns a  GetMatchIdResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchId">REST API Reference for GetMatchId Operation</seealso>
        public virtual GetMatchIdResponse EndGetMatchId(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMatchIdResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMatchingJob

        /// <summary>
        /// Returns the status, metrics, and errors (if there are any) that are associated with
        /// a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatchingJob service method.</param>
        /// 
        /// <returns>The response from the GetMatchingJob service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchingJob">REST API Reference for GetMatchingJob Operation</seealso>
        public virtual GetMatchingJobResponse GetMatchingJob(GetMatchingJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMatchingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMatchingJobResponseUnmarshaller.Instance;

            return Invoke<GetMatchingJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMatchingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMatchingJob operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMatchingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchingJob">REST API Reference for GetMatchingJob Operation</seealso>
        public virtual IAsyncResult BeginGetMatchingJob(GetMatchingJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMatchingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMatchingJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMatchingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMatchingJob.</param>
        /// 
        /// <returns>Returns a  GetMatchingJobResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchingJob">REST API Reference for GetMatchingJob Operation</seealso>
        public virtual GetMatchingJobResponse EndGetMatchingJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMatchingJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMatchingWorkflow

        /// <summary>
        /// Returns the <c>MatchingWorkflow</c> with a given name, if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatchingWorkflow service method.</param>
        /// 
        /// <returns>The response from the GetMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchingWorkflow">REST API Reference for GetMatchingWorkflow Operation</seealso>
        public virtual GetMatchingWorkflowResponse GetMatchingWorkflow(GetMatchingWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMatchingWorkflowResponseUnmarshaller.Instance;

            return Invoke<GetMatchingWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMatchingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMatchingWorkflow operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMatchingWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchingWorkflow">REST API Reference for GetMatchingWorkflow Operation</seealso>
        public virtual IAsyncResult BeginGetMatchingWorkflow(GetMatchingWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMatchingWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMatchingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMatchingWorkflow.</param>
        /// 
        /// <returns>Returns a  GetMatchingWorkflowResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchingWorkflow">REST API Reference for GetMatchingWorkflow Operation</seealso>
        public virtual GetMatchingWorkflowResponse EndGetMatchingWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMatchingWorkflowResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPolicy

        /// <summary>
        /// Returns the resource-based policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetPolicy(GetPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicy.</param>
        /// 
        /// <returns>Returns a  GetPolicyResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual GetPolicyResponse EndGetPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProviderService

        /// <summary>
        /// Returns the <c>ProviderService</c> of a given name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProviderService service method.</param>
        /// 
        /// <returns>The response from the GetProviderService service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetProviderService">REST API Reference for GetProviderService Operation</seealso>
        public virtual GetProviderServiceResponse GetProviderService(GetProviderServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProviderServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProviderServiceResponseUnmarshaller.Instance;

            return Invoke<GetProviderServiceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProviderService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProviderService operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProviderService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetProviderService">REST API Reference for GetProviderService Operation</seealso>
        public virtual IAsyncResult BeginGetProviderService(GetProviderServiceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProviderServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProviderServiceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProviderService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProviderService.</param>
        /// 
        /// <returns>Returns a  GetProviderServiceResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetProviderService">REST API Reference for GetProviderService Operation</seealso>
        public virtual GetProviderServiceResponse EndGetProviderService(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProviderServiceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSchemaMapping

        /// <summary>
        /// Returns the SchemaMapping of a given name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaMapping service method.</param>
        /// 
        /// <returns>The response from the GetSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetSchemaMapping">REST API Reference for GetSchemaMapping Operation</seealso>
        public virtual GetSchemaMappingResponse GetSchemaMapping(GetSchemaMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSchemaMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaMappingResponseUnmarshaller.Instance;

            return Invoke<GetSchemaMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSchemaMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaMapping operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSchemaMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetSchemaMapping">REST API Reference for GetSchemaMapping Operation</seealso>
        public virtual IAsyncResult BeginGetSchemaMapping(GetSchemaMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSchemaMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSchemaMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSchemaMapping.</param>
        /// 
        /// <returns>Returns a  GetSchemaMappingResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetSchemaMapping">REST API Reference for GetSchemaMapping Operation</seealso>
        public virtual GetSchemaMappingResponse EndGetSchemaMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSchemaMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIdMappingJobs

        /// <summary>
        /// Lists all ID mapping jobs for a given workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdMappingJobs service method.</param>
        /// 
        /// <returns>The response from the ListIdMappingJobs service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdMappingJobs">REST API Reference for ListIdMappingJobs Operation</seealso>
        public virtual ListIdMappingJobsResponse ListIdMappingJobs(ListIdMappingJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdMappingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdMappingJobsResponseUnmarshaller.Instance;

            return Invoke<ListIdMappingJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdMappingJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdMappingJobs operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdMappingJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdMappingJobs">REST API Reference for ListIdMappingJobs Operation</seealso>
        public virtual IAsyncResult BeginListIdMappingJobs(ListIdMappingJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdMappingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdMappingJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdMappingJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdMappingJobs.</param>
        /// 
        /// <returns>Returns a  ListIdMappingJobsResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdMappingJobs">REST API Reference for ListIdMappingJobs Operation</seealso>
        public virtual ListIdMappingJobsResponse EndListIdMappingJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIdMappingJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIdMappingWorkflows

        /// <summary>
        /// Returns a list of all the <c>IdMappingWorkflows</c> that have been created for an
        /// Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdMappingWorkflows service method.</param>
        /// 
        /// <returns>The response from the ListIdMappingWorkflows service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdMappingWorkflows">REST API Reference for ListIdMappingWorkflows Operation</seealso>
        public virtual ListIdMappingWorkflowsResponse ListIdMappingWorkflows(ListIdMappingWorkflowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdMappingWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdMappingWorkflowsResponseUnmarshaller.Instance;

            return Invoke<ListIdMappingWorkflowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdMappingWorkflows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdMappingWorkflows operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdMappingWorkflows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdMappingWorkflows">REST API Reference for ListIdMappingWorkflows Operation</seealso>
        public virtual IAsyncResult BeginListIdMappingWorkflows(ListIdMappingWorkflowsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdMappingWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdMappingWorkflowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdMappingWorkflows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdMappingWorkflows.</param>
        /// 
        /// <returns>Returns a  ListIdMappingWorkflowsResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdMappingWorkflows">REST API Reference for ListIdMappingWorkflows Operation</seealso>
        public virtual ListIdMappingWorkflowsResponse EndListIdMappingWorkflows(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIdMappingWorkflowsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIdNamespaces

        /// <summary>
        /// Returns a list of all ID namespaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdNamespaces service method.</param>
        /// 
        /// <returns>The response from the ListIdNamespaces service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdNamespaces">REST API Reference for ListIdNamespaces Operation</seealso>
        public virtual ListIdNamespacesResponse ListIdNamespaces(ListIdNamespacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdNamespacesResponseUnmarshaller.Instance;

            return Invoke<ListIdNamespacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdNamespaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdNamespaces operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdNamespaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdNamespaces">REST API Reference for ListIdNamespaces Operation</seealso>
        public virtual IAsyncResult BeginListIdNamespaces(ListIdNamespacesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdNamespacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdNamespaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdNamespaces.</param>
        /// 
        /// <returns>Returns a  ListIdNamespacesResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdNamespaces">REST API Reference for ListIdNamespaces Operation</seealso>
        public virtual ListIdNamespacesResponse EndListIdNamespaces(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIdNamespacesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMatchingJobs

        /// <summary>
        /// Lists all jobs for a given workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMatchingJobs service method.</param>
        /// 
        /// <returns>The response from the ListMatchingJobs service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListMatchingJobs">REST API Reference for ListMatchingJobs Operation</seealso>
        public virtual ListMatchingJobsResponse ListMatchingJobs(ListMatchingJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMatchingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMatchingJobsResponseUnmarshaller.Instance;

            return Invoke<ListMatchingJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMatchingJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMatchingJobs operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMatchingJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListMatchingJobs">REST API Reference for ListMatchingJobs Operation</seealso>
        public virtual IAsyncResult BeginListMatchingJobs(ListMatchingJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMatchingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMatchingJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMatchingJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMatchingJobs.</param>
        /// 
        /// <returns>Returns a  ListMatchingJobsResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListMatchingJobs">REST API Reference for ListMatchingJobs Operation</seealso>
        public virtual ListMatchingJobsResponse EndListMatchingJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMatchingJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMatchingWorkflows

        /// <summary>
        /// Returns a list of all the <c>MatchingWorkflows</c> that have been created for an Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMatchingWorkflows service method.</param>
        /// 
        /// <returns>The response from the ListMatchingWorkflows service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListMatchingWorkflows">REST API Reference for ListMatchingWorkflows Operation</seealso>
        public virtual ListMatchingWorkflowsResponse ListMatchingWorkflows(ListMatchingWorkflowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMatchingWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMatchingWorkflowsResponseUnmarshaller.Instance;

            return Invoke<ListMatchingWorkflowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMatchingWorkflows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMatchingWorkflows operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMatchingWorkflows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListMatchingWorkflows">REST API Reference for ListMatchingWorkflows Operation</seealso>
        public virtual IAsyncResult BeginListMatchingWorkflows(ListMatchingWorkflowsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMatchingWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMatchingWorkflowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMatchingWorkflows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMatchingWorkflows.</param>
        /// 
        /// <returns>Returns a  ListMatchingWorkflowsResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListMatchingWorkflows">REST API Reference for ListMatchingWorkflows Operation</seealso>
        public virtual ListMatchingWorkflowsResponse EndListMatchingWorkflows(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMatchingWorkflowsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProviderServices

        /// <summary>
        /// Returns a list of all the <c>ProviderServices</c> that are available in this Amazon
        /// Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProviderServices service method.</param>
        /// 
        /// <returns>The response from the ListProviderServices service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListProviderServices">REST API Reference for ListProviderServices Operation</seealso>
        public virtual ListProviderServicesResponse ListProviderServices(ListProviderServicesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProviderServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProviderServicesResponseUnmarshaller.Instance;

            return Invoke<ListProviderServicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProviderServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProviderServices operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProviderServices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListProviderServices">REST API Reference for ListProviderServices Operation</seealso>
        public virtual IAsyncResult BeginListProviderServices(ListProviderServicesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProviderServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProviderServicesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProviderServices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProviderServices.</param>
        /// 
        /// <returns>Returns a  ListProviderServicesResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListProviderServices">REST API Reference for ListProviderServices Operation</seealso>
        public virtual ListProviderServicesResponse EndListProviderServices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProviderServicesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSchemaMappings

        /// <summary>
        /// Returns a list of all the <c>SchemaMappings</c> that have been created for an Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaMappings service method.</param>
        /// 
        /// <returns>The response from the ListSchemaMappings service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListSchemaMappings">REST API Reference for ListSchemaMappings Operation</seealso>
        public virtual ListSchemaMappingsResponse ListSchemaMappings(ListSchemaMappingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSchemaMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaMappingsResponseUnmarshaller.Instance;

            return Invoke<ListSchemaMappingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSchemaMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaMappings operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSchemaMappings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListSchemaMappings">REST API Reference for ListSchemaMappings Operation</seealso>
        public virtual IAsyncResult BeginListSchemaMappings(ListSchemaMappingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSchemaMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaMappingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSchemaMappings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSchemaMappings.</param>
        /// 
        /// <returns>Returns a  ListSchemaMappingsResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListSchemaMappings">REST API Reference for ListSchemaMappings Operation</seealso>
        public virtual ListSchemaMappingsResponse EndListSchemaMappings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSchemaMappingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Displays the tags associated with an Entity Resolution resource. In Entity Resolution,
        /// <c>SchemaMapping</c>, and <c>MatchingWorkflow</c> can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutPolicy

        /// <summary>
        /// Updates the resource-based policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPolicy service method.</param>
        /// 
        /// <returns>The response from the PutPolicy service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        public virtual PutPolicyResponse PutPolicy(PutPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPolicyResponseUnmarshaller.Instance;

            return Invoke<PutPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPolicy operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutPolicy(PutPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPolicy.</param>
        /// 
        /// <returns>Returns a  PutPolicyResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        public virtual PutPolicyResponse EndPutPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  StartIdMappingJob

        /// <summary>
        /// Starts the <c>IdMappingJob</c> of a workflow. The workflow must have previously been
        /// created using the <c>CreateIdMappingWorkflow</c> endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartIdMappingJob service method.</param>
        /// 
        /// <returns>The response from the StartIdMappingJob service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/StartIdMappingJob">REST API Reference for StartIdMappingJob Operation</seealso>
        public virtual StartIdMappingJobResponse StartIdMappingJob(StartIdMappingJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartIdMappingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartIdMappingJobResponseUnmarshaller.Instance;

            return Invoke<StartIdMappingJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartIdMappingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartIdMappingJob operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartIdMappingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/StartIdMappingJob">REST API Reference for StartIdMappingJob Operation</seealso>
        public virtual IAsyncResult BeginStartIdMappingJob(StartIdMappingJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartIdMappingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartIdMappingJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartIdMappingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartIdMappingJob.</param>
        /// 
        /// <returns>Returns a  StartIdMappingJobResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/StartIdMappingJob">REST API Reference for StartIdMappingJob Operation</seealso>
        public virtual StartIdMappingJobResponse EndStartIdMappingJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartIdMappingJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartMatchingJob

        /// <summary>
        /// Starts the <c>MatchingJob</c> of a workflow. The workflow must have previously been
        /// created using the <c>CreateMatchingWorkflow</c> endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMatchingJob service method.</param>
        /// 
        /// <returns>The response from the StartMatchingJob service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/StartMatchingJob">REST API Reference for StartMatchingJob Operation</seealso>
        public virtual StartMatchingJobResponse StartMatchingJob(StartMatchingJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMatchingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMatchingJobResponseUnmarshaller.Instance;

            return Invoke<StartMatchingJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartMatchingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMatchingJob operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMatchingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/StartMatchingJob">REST API Reference for StartMatchingJob Operation</seealso>
        public virtual IAsyncResult BeginStartMatchingJob(StartMatchingJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMatchingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMatchingJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartMatchingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMatchingJob.</param>
        /// 
        /// <returns>Returns a  StartMatchingJobResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/StartMatchingJob">REST API Reference for StartMatchingJob Operation</seealso>
        public virtual StartMatchingJobResponse EndStartMatchingJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartMatchingJobResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified Entity Resolution resource.
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values. In Entity Resolution, <c>SchemaMapping</c> and <c>MatchingWorkflow</c>
        /// can be tagged. Tags don't have any semantic meaning to Amazon Web Services and are
        /// interpreted strictly as strings of characters. You can use the <c>TagResource</c>
        /// action with a resource that already has tags. If you specify a new tag key, this tag
        /// is appended to the list of tags associated with the resource. If you specify a tag
        /// key that is already associated with the resource, the new tag value that you specify
        /// replaces the previous value for that tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes one or more tags from the specified Entity Resolution resource. In Entity
        /// Resolution, <c>SchemaMapping</c>, and <c>MatchingWorkflow</c> can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIdMappingWorkflow

        /// <summary>
        /// Updates an existing <c>IdMappingWorkflow</c>. This method is identical to CreateIdMappingWorkflow,
        /// except it uses an HTTP <c>PUT</c> request instead of a <c>POST</c> request, and the
        /// <c>IdMappingWorkflow</c> must already exist for the method to succeed.
        /// 
        ///  <important> 
        /// <para>
        /// Incremental processing is not supported for ID mapping workflows. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdMappingWorkflow service method.</param>
        /// 
        /// <returns>The response from the UpdateIdMappingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateIdMappingWorkflow">REST API Reference for UpdateIdMappingWorkflow Operation</seealso>
        public virtual UpdateIdMappingWorkflowResponse UpdateIdMappingWorkflow(UpdateIdMappingWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIdMappingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdMappingWorkflowResponseUnmarshaller.Instance;

            return Invoke<UpdateIdMappingWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdMappingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdMappingWorkflow operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIdMappingWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateIdMappingWorkflow">REST API Reference for UpdateIdMappingWorkflow Operation</seealso>
        public virtual IAsyncResult BeginUpdateIdMappingWorkflow(UpdateIdMappingWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIdMappingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdMappingWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIdMappingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIdMappingWorkflow.</param>
        /// 
        /// <returns>Returns a  UpdateIdMappingWorkflowResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateIdMappingWorkflow">REST API Reference for UpdateIdMappingWorkflow Operation</seealso>
        public virtual UpdateIdMappingWorkflowResponse EndUpdateIdMappingWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIdMappingWorkflowResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIdNamespace

        /// <summary>
        /// Updates an existing ID namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdNamespace service method.</param>
        /// 
        /// <returns>The response from the UpdateIdNamespace service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateIdNamespace">REST API Reference for UpdateIdNamespace Operation</seealso>
        public virtual UpdateIdNamespaceResponse UpdateIdNamespace(UpdateIdNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIdNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdNamespaceResponseUnmarshaller.Instance;

            return Invoke<UpdateIdNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdNamespace operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIdNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateIdNamespace">REST API Reference for UpdateIdNamespace Operation</seealso>
        public virtual IAsyncResult BeginUpdateIdNamespace(UpdateIdNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIdNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIdNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIdNamespace.</param>
        /// 
        /// <returns>Returns a  UpdateIdNamespaceResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateIdNamespace">REST API Reference for UpdateIdNamespace Operation</seealso>
        public virtual UpdateIdNamespaceResponse EndUpdateIdNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIdNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMatchingWorkflow

        /// <summary>
        /// Updates an existing matching workflow. The workflow must already exist for this operation
        /// to succeed.
        /// 
        ///  <important> 
        /// <para>
        /// For workflows where <c>resolutionType</c> is <c>ML_MATCHING</c> or <c>PROVIDER</c>,
        /// incremental processing is not supported. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMatchingWorkflow service method.</param>
        /// 
        /// <returns>The response from the UpdateMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateMatchingWorkflow">REST API Reference for UpdateMatchingWorkflow Operation</seealso>
        public virtual UpdateMatchingWorkflowResponse UpdateMatchingWorkflow(UpdateMatchingWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMatchingWorkflowResponseUnmarshaller.Instance;

            return Invoke<UpdateMatchingWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMatchingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMatchingWorkflow operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMatchingWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateMatchingWorkflow">REST API Reference for UpdateMatchingWorkflow Operation</seealso>
        public virtual IAsyncResult BeginUpdateMatchingWorkflow(UpdateMatchingWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMatchingWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMatchingWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMatchingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMatchingWorkflow.</param>
        /// 
        /// <returns>Returns a  UpdateMatchingWorkflowResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateMatchingWorkflow">REST API Reference for UpdateMatchingWorkflow Operation</seealso>
        public virtual UpdateMatchingWorkflowResponse EndUpdateMatchingWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMatchingWorkflowResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSchemaMapping

        /// <summary>
        /// Updates a schema mapping.
        /// 
        ///  <note> 
        /// <para>
        /// A schema is immutable if it is being used by a workflow. Therefore, you can't update
        /// a schema mapping if it's associated with a workflow. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchemaMapping service method.</param>
        /// 
        /// <returns>The response from the UpdateSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateSchemaMapping">REST API Reference for UpdateSchemaMapping Operation</seealso>
        public virtual UpdateSchemaMappingResponse UpdateSchemaMapping(UpdateSchemaMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSchemaMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSchemaMappingResponseUnmarshaller.Instance;

            return Invoke<UpdateSchemaMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSchemaMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchemaMapping operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSchemaMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateSchemaMapping">REST API Reference for UpdateSchemaMapping Operation</seealso>
        public virtual IAsyncResult BeginUpdateSchemaMapping(UpdateSchemaMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSchemaMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSchemaMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSchemaMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSchemaMapping.</param>
        /// 
        /// <returns>Returns a  UpdateSchemaMappingResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateSchemaMapping">REST API Reference for UpdateSchemaMapping Operation</seealso>
        public virtual UpdateSchemaMappingResponse EndUpdateSchemaMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSchemaMappingResponse>(asyncResult);
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
            var resolver = new AmazonEntityResolutionEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}