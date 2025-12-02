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
 * Do not modify this file. This file is generated from the nova-act-2025-08-22.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.NovaAct.Model;
using Amazon.NovaAct.Model.Internal.MarshallTransformations;
using Amazon.NovaAct.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.NovaAct
{
    /// <summary>
    /// <para>Implementation for accessing NovaAct</para>
    ///
    /// The Nova Act service provides a REST API for managing AI-powered workflow automation.
    /// It enables users to create workflow definitions, execute workflow runs, manage sessions,
    /// and orchestrate acts (individual AI tasks) with tool integrations.
    /// </summary>
    public partial class AmazonNovaActClient : AmazonServiceClient, IAmazonNovaAct
    {
        private static IServiceMetadata serviceMetadata = new AmazonNovaActMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private INovaActPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public INovaActPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new NovaActPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonNovaActClient with the credentials loaded from the application's
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
        public AmazonNovaActClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonNovaActConfig()) { }

        /// <summary>
        /// Constructs AmazonNovaActClient with the credentials loaded from the application's
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
        public AmazonNovaActClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonNovaActConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonNovaActClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonNovaActClient Configuration Object</param>
        public AmazonNovaActClient(AmazonNovaActConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonNovaActClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonNovaActClient(AWSCredentials credentials)
            : this(credentials, new AmazonNovaActConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNovaActClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNovaActClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonNovaActConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNovaActClient with AWS Credentials and an
        /// AmazonNovaActClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonNovaActClient Configuration Object</param>
        public AmazonNovaActClient(AWSCredentials credentials, AmazonNovaActConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNovaActClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonNovaActClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNovaActConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNovaActClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNovaActClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNovaActConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonNovaActClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNovaActClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonNovaActClient Configuration Object</param>
        public AmazonNovaActClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonNovaActConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNovaActClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonNovaActClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNovaActConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNovaActClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNovaActClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNovaActConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNovaActClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNovaActClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonNovaActClient Configuration Object</param>
        public AmazonNovaActClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonNovaActConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNovaActEndpointResolver());
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


        #region  CreateAct

        /// <summary>
        /// Creates a new AI task (act) within a session that can interact with tools and perform
        /// specific actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAct service method.</param>
        /// 
        /// <returns>The response from the CreateAct service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateAct">REST API Reference for CreateAct Operation</seealso>
        public virtual CreateActResponse CreateAct(CreateActRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateActRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateActResponseUnmarshaller.Instance;

            return Invoke<CreateActResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAct operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateAct">REST API Reference for CreateAct Operation</seealso>
        public virtual IAsyncResult BeginCreateAct(CreateActRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateActRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateActResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAct.</param>
        /// 
        /// <returns>Returns a  CreateActResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateAct">REST API Reference for CreateAct Operation</seealso>
        public virtual CreateActResponse EndCreateAct(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateActResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSession

        /// <summary>
        /// Creates a new session context within a workflow run to manage conversation state and
        /// acts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSession service method.</param>
        /// 
        /// <returns>The response from the CreateSession service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateSession">REST API Reference for CreateSession Operation</seealso>
        public virtual CreateSessionResponse CreateSession(CreateSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSessionResponseUnmarshaller.Instance;

            return Invoke<CreateSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSession operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateSession">REST API Reference for CreateSession Operation</seealso>
        public virtual IAsyncResult BeginCreateSession(CreateSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSession.</param>
        /// 
        /// <returns>Returns a  CreateSessionResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateSession">REST API Reference for CreateSession Operation</seealso>
        public virtual CreateSessionResponse EndCreateSession(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWorkflowDefinition

        /// <summary>
        /// Creates a new workflow definition template that can be used to execute multiple workflow
        /// runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateWorkflowDefinition service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateWorkflowDefinition">REST API Reference for CreateWorkflowDefinition Operation</seealso>
        public virtual CreateWorkflowDefinitionResponse CreateWorkflowDefinition(CreateWorkflowDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkflowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateWorkflowDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkflowDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowDefinition operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkflowDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateWorkflowDefinition">REST API Reference for CreateWorkflowDefinition Operation</seealso>
        public virtual IAsyncResult BeginCreateWorkflowDefinition(CreateWorkflowDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkflowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkflowDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkflowDefinition.</param>
        /// 
        /// <returns>Returns a  CreateWorkflowDefinitionResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateWorkflowDefinition">REST API Reference for CreateWorkflowDefinition Operation</seealso>
        public virtual CreateWorkflowDefinitionResponse EndCreateWorkflowDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWorkflowDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWorkflowRun

        /// <summary>
        /// Creates a new execution instance of a workflow definition with specified parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowRun service method.</param>
        /// 
        /// <returns>The response from the CreateWorkflowRun service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateWorkflowRun">REST API Reference for CreateWorkflowRun Operation</seealso>
        public virtual CreateWorkflowRunResponse CreateWorkflowRun(CreateWorkflowRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowRunResponseUnmarshaller.Instance;

            return Invoke<CreateWorkflowRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowRun operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkflowRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateWorkflowRun">REST API Reference for CreateWorkflowRun Operation</seealso>
        public virtual IAsyncResult BeginCreateWorkflowRun(CreateWorkflowRunRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkflowRun.</param>
        /// 
        /// <returns>Returns a  CreateWorkflowRunResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateWorkflowRun">REST API Reference for CreateWorkflowRun Operation</seealso>
        public virtual CreateWorkflowRunResponse EndCreateWorkflowRun(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWorkflowRunResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWorkflowDefinition

        /// <summary>
        /// Deletes a workflow definition and all associated resources. This operation cannot
        /// be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkflowDefinition service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/DeleteWorkflowDefinition">REST API Reference for DeleteWorkflowDefinition Operation</seealso>
        public virtual DeleteWorkflowDefinitionResponse DeleteWorkflowDefinition(DeleteWorkflowDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkflowDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkflowDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowDefinition operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkflowDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/DeleteWorkflowDefinition">REST API Reference for DeleteWorkflowDefinition Operation</seealso>
        public virtual IAsyncResult BeginDeleteWorkflowDefinition(DeleteWorkflowDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkflowDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkflowDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteWorkflowDefinitionResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/DeleteWorkflowDefinition">REST API Reference for DeleteWorkflowDefinition Operation</seealso>
        public virtual DeleteWorkflowDefinitionResponse EndDeleteWorkflowDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWorkflowDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWorkflowRun

        /// <summary>
        /// Terminates and cleans up a workflow run, stopping all associated acts and sessions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowRun service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkflowRun service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/DeleteWorkflowRun">REST API Reference for DeleteWorkflowRun Operation</seealso>
        public virtual DeleteWorkflowRunResponse DeleteWorkflowRun(DeleteWorkflowRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowRunResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkflowRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowRun operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkflowRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/DeleteWorkflowRun">REST API Reference for DeleteWorkflowRun Operation</seealso>
        public virtual IAsyncResult BeginDeleteWorkflowRun(DeleteWorkflowRunRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkflowRun.</param>
        /// 
        /// <returns>Returns a  DeleteWorkflowRunResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/DeleteWorkflowRun">REST API Reference for DeleteWorkflowRun Operation</seealso>
        public virtual DeleteWorkflowRunResponse EndDeleteWorkflowRun(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWorkflowRunResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWorkflowDefinition

        /// <summary>
        /// Retrieves the details and configuration of a specific workflow definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowDefinition service method.</param>
        /// 
        /// <returns>The response from the GetWorkflowDefinition service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/GetWorkflowDefinition">REST API Reference for GetWorkflowDefinition Operation</seealso>
        public virtual GetWorkflowDefinitionResponse GetWorkflowDefinition(GetWorkflowDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkflowDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowDefinition operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkflowDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/GetWorkflowDefinition">REST API Reference for GetWorkflowDefinition Operation</seealso>
        public virtual IAsyncResult BeginGetWorkflowDefinition(GetWorkflowDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkflowDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkflowDefinition.</param>
        /// 
        /// <returns>Returns a  GetWorkflowDefinitionResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/GetWorkflowDefinition">REST API Reference for GetWorkflowDefinition Operation</seealso>
        public virtual GetWorkflowDefinitionResponse EndGetWorkflowDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWorkflowDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWorkflowRun

        /// <summary>
        /// Retrieves the current state, configuration, and execution details of a workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowRun service method.</param>
        /// 
        /// <returns>The response from the GetWorkflowRun service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/GetWorkflowRun">REST API Reference for GetWorkflowRun Operation</seealso>
        public virtual GetWorkflowRunResponse GetWorkflowRun(GetWorkflowRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowRunResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowRun operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkflowRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/GetWorkflowRun">REST API Reference for GetWorkflowRun Operation</seealso>
        public virtual IAsyncResult BeginGetWorkflowRun(GetWorkflowRunRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkflowRun.</param>
        /// 
        /// <returns>Returns a  GetWorkflowRunResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/GetWorkflowRun">REST API Reference for GetWorkflowRun Operation</seealso>
        public virtual GetWorkflowRunResponse EndGetWorkflowRun(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWorkflowRunResponse>(asyncResult);
        }

        #endregion
        
        #region  InvokeActStep

        /// <summary>
        /// Executes the next step of an act, processing tool call results and returning new tool
        /// calls if needed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeActStep service method.</param>
        /// 
        /// <returns>The response from the InvokeActStep service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/InvokeActStep">REST API Reference for InvokeActStep Operation</seealso>
        public virtual InvokeActStepResponse InvokeActStep(InvokeActStepRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeActStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeActStepResponseUnmarshaller.Instance;

            return Invoke<InvokeActStepResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeActStep operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeActStep operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvokeActStep
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/InvokeActStep">REST API Reference for InvokeActStep Operation</seealso>
        public virtual IAsyncResult BeginInvokeActStep(InvokeActStepRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeActStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeActStepResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InvokeActStep operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvokeActStep.</param>
        /// 
        /// <returns>Returns a  InvokeActStepResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/InvokeActStep">REST API Reference for InvokeActStep Operation</seealso>
        public virtual InvokeActStepResponse EndInvokeActStep(IAsyncResult asyncResult)
        {
            return EndInvoke<InvokeActStepResponse>(asyncResult);
        }

        #endregion
        
        #region  ListActs

        /// <summary>
        /// Lists all acts within a specific session with their current status and execution details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActs service method.</param>
        /// 
        /// <returns>The response from the ListActs service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListActs">REST API Reference for ListActs Operation</seealso>
        public virtual ListActsResponse ListActs(ListActsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListActsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActsResponseUnmarshaller.Instance;

            return Invoke<ListActsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListActs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActs operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListActs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListActs">REST API Reference for ListActs Operation</seealso>
        public virtual IAsyncResult BeginListActs(ListActsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListActsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListActs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListActs.</param>
        /// 
        /// <returns>Returns a  ListActsResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListActs">REST API Reference for ListActs Operation</seealso>
        public virtual ListActsResponse EndListActs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListActsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListModels

        /// <summary>
        /// Lists all available AI models that can be used for workflow execution, including their
        /// status and compatibility information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModels service method.</param>
        /// 
        /// <returns>The response from the ListModels service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListModels">REST API Reference for ListModels Operation</seealso>
        public virtual ListModelsResponse ListModels(ListModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelsResponseUnmarshaller.Instance;

            return Invoke<ListModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModels operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListModels">REST API Reference for ListModels Operation</seealso>
        public virtual IAsyncResult BeginListModels(ListModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModels.</param>
        /// 
        /// <returns>Returns a  ListModelsResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListModels">REST API Reference for ListModels Operation</seealso>
        public virtual ListModelsResponse EndListModels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSessions

        /// <summary>
        /// Lists all sessions within a specific workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
        /// 
        /// <returns>The response from the ListSessions service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListSessions">REST API Reference for ListSessions Operation</seealso>
        public virtual ListSessionsResponse ListSessions(ListSessionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsResponseUnmarshaller.Instance;

            return Invoke<ListSessionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSessions operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListSessions">REST API Reference for ListSessions Operation</seealso>
        public virtual IAsyncResult BeginListSessions(ListSessionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSessions.</param>
        /// 
        /// <returns>Returns a  ListSessionsResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListSessions">REST API Reference for ListSessions Operation</seealso>
        public virtual ListSessionsResponse EndListSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWorkflowDefinitions

        /// <summary>
        /// Lists all workflow definitions in your account with optional filtering and pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListWorkflowDefinitions service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListWorkflowDefinitions">REST API Reference for ListWorkflowDefinitions Operation</seealso>
        public virtual ListWorkflowDefinitionsResponse ListWorkflowDefinitions(ListWorkflowDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowDefinitionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkflowDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowDefinitions operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkflowDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListWorkflowDefinitions">REST API Reference for ListWorkflowDefinitions Operation</seealso>
        public virtual IAsyncResult BeginListWorkflowDefinitions(ListWorkflowDefinitionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowDefinitionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkflowDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkflowDefinitions.</param>
        /// 
        /// <returns>Returns a  ListWorkflowDefinitionsResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListWorkflowDefinitions">REST API Reference for ListWorkflowDefinitions Operation</seealso>
        public virtual ListWorkflowDefinitionsResponse EndListWorkflowDefinitions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWorkflowDefinitionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWorkflowRuns

        /// <summary>
        /// Lists all workflow runs for a specific workflow definition with optional filtering
        /// and pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowRuns service method.</param>
        /// 
        /// <returns>The response from the ListWorkflowRuns service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListWorkflowRuns">REST API Reference for ListWorkflowRuns Operation</seealso>
        public virtual ListWorkflowRunsResponse ListWorkflowRuns(ListWorkflowRunsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowRunsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowRunsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkflowRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowRuns operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkflowRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListWorkflowRuns">REST API Reference for ListWorkflowRuns Operation</seealso>
        public virtual IAsyncResult BeginListWorkflowRuns(ListWorkflowRunsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowRunsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkflowRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkflowRuns.</param>
        /// 
        /// <returns>Returns a  ListWorkflowRunsResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListWorkflowRuns">REST API Reference for ListWorkflowRuns Operation</seealso>
        public virtual ListWorkflowRunsResponse EndListWorkflowRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWorkflowRunsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAct

        /// <summary>
        /// Updates an existing act's configuration, status, or error information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAct service method.</param>
        /// 
        /// <returns>The response from the UpdateAct service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/UpdateAct">REST API Reference for UpdateAct Operation</seealso>
        public virtual UpdateActResponse UpdateAct(UpdateActRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateActRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateActResponseUnmarshaller.Instance;

            return Invoke<UpdateActResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAct operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/UpdateAct">REST API Reference for UpdateAct Operation</seealso>
        public virtual IAsyncResult BeginUpdateAct(UpdateActRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateActRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateActResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAct.</param>
        /// 
        /// <returns>Returns a  UpdateActResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/UpdateAct">REST API Reference for UpdateAct Operation</seealso>
        public virtual UpdateActResponse EndUpdateAct(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateActResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWorkflowRun

        /// <summary>
        /// Updates the configuration or state of an active workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflowRun service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkflowRun service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/UpdateWorkflowRun">REST API Reference for UpdateWorkflowRun Operation</seealso>
        public virtual UpdateWorkflowRunResponse UpdateWorkflowRun(UpdateWorkflowRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkflowRunResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkflowRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflowRun operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkflowRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/UpdateWorkflowRun">REST API Reference for UpdateWorkflowRun Operation</seealso>
        public virtual IAsyncResult BeginUpdateWorkflowRun(UpdateWorkflowRunRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkflowRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkflowRun.</param>
        /// 
        /// <returns>Returns a  UpdateWorkflowRunResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/UpdateWorkflowRun">REST API Reference for UpdateWorkflowRun Operation</seealso>
        public virtual UpdateWorkflowRunResponse EndUpdateWorkflowRun(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWorkflowRunResponse>(asyncResult);
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
            var resolver = new AmazonNovaActEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}