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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.BedrockAgent.Model;
using Amazon.BedrockAgent.Model.Internal.MarshallTransformations;
using Amazon.BedrockAgent.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.BedrockAgent
{
    /// <summary>
    /// Implementation for accessing BedrockAgent
    ///
    /// An example service, deployed with the Octane Service creator, which will echo the
    /// string
    /// </summary>
    public partial class AmazonBedrockAgentClient : AmazonServiceClient, IAmazonBedrockAgent
    {
        private static IServiceMetadata serviceMetadata = new AmazonBedrockAgentMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IBedrockAgentPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IBedrockAgentPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new BedrockAgentPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonBedrockAgentClient with the credentials loaded from the application's
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
        public AmazonBedrockAgentClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBedrockAgentConfig()) { }

        /// <summary>
        /// Constructs AmazonBedrockAgentClient with the credentials loaded from the application's
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
        public AmazonBedrockAgentClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBedrockAgentConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBedrockAgentClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBedrockAgentClient Configuration Object</param>
        public AmazonBedrockAgentClient(AmazonBedrockAgentConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonBedrockAgentClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBedrockAgentClient(AWSCredentials credentials)
            : this(credentials, new AmazonBedrockAgentConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockAgentClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBedrockAgentConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentClient with AWS Credentials and an
        /// AmazonBedrockAgentClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBedrockAgentClient Configuration Object</param>
        public AmazonBedrockAgentClient(AWSCredentials credentials, AmazonBedrockAgentConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBedrockAgentClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBedrockAgentConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockAgentClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBedrockAgentConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBedrockAgentClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBedrockAgentClient Configuration Object</param>
        public AmazonBedrockAgentClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBedrockAgentConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBedrockAgentClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBedrockAgentConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockAgentClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBedrockAgentConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBedrockAgentClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBedrockAgentClient Configuration Object</param>
        public AmazonBedrockAgentClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBedrockAgentConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBedrockAgentEndpointResolver());
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


        #region  AssociateAgentKnowledgeBase

        /// <summary>
        /// Associate a Knowledge Base to an existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAgentKnowledgeBase service method.</param>
        /// 
        /// <returns>The response from the AssociateAgentKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/AssociateAgentKnowledgeBase">REST API Reference for AssociateAgentKnowledgeBase Operation</seealso>
        public virtual AssociateAgentKnowledgeBaseResponse AssociateAgentKnowledgeBase(AssociateAgentKnowledgeBaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAgentKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAgentKnowledgeBaseResponseUnmarshaller.Instance;

            return Invoke<AssociateAgentKnowledgeBaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAgentKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAgentKnowledgeBase operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateAgentKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/AssociateAgentKnowledgeBase">REST API Reference for AssociateAgentKnowledgeBase Operation</seealso>
        public virtual IAsyncResult BeginAssociateAgentKnowledgeBase(AssociateAgentKnowledgeBaseRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAgentKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAgentKnowledgeBaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateAgentKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAgentKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  AssociateAgentKnowledgeBaseResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/AssociateAgentKnowledgeBase">REST API Reference for AssociateAgentKnowledgeBase Operation</seealso>
        public virtual AssociateAgentKnowledgeBaseResponse EndAssociateAgentKnowledgeBase(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateAgentKnowledgeBaseResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAgent

        /// <summary>
        /// Creates an Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgent service method.</param>
        /// 
        /// <returns>The response from the CreateAgent service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgent">REST API Reference for CreateAgent Operation</seealso>
        public virtual CreateAgentResponse CreateAgent(CreateAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentResponseUnmarshaller.Instance;

            return Invoke<CreateAgentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAgent operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgent">REST API Reference for CreateAgent Operation</seealso>
        public virtual IAsyncResult BeginCreateAgent(CreateAgentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  CreateAgentResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgent">REST API Reference for CreateAgent Operation</seealso>
        public virtual CreateAgentResponse EndCreateAgent(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAgentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAgentActionGroup

        /// <summary>
        /// Creates an Action Group for existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentActionGroup service method.</param>
        /// 
        /// <returns>The response from the CreateAgentActionGroup service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgentActionGroup">REST API Reference for CreateAgentActionGroup Operation</seealso>
        public virtual CreateAgentActionGroupResponse CreateAgentActionGroup(CreateAgentActionGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAgentActionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentActionGroupResponseUnmarshaller.Instance;

            return Invoke<CreateAgentActionGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAgentActionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentActionGroup operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAgentActionGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgentActionGroup">REST API Reference for CreateAgentActionGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateAgentActionGroup(CreateAgentActionGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAgentActionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentActionGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAgentActionGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAgentActionGroup.</param>
        /// 
        /// <returns>Returns a  CreateAgentActionGroupResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgentActionGroup">REST API Reference for CreateAgentActionGroup Operation</seealso>
        public virtual CreateAgentActionGroupResponse EndCreateAgentActionGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAgentActionGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAgentAlias

        /// <summary>
        /// Creates an Alias for an existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAgentAlias service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgentAlias">REST API Reference for CreateAgentAlias Operation</seealso>
        public virtual CreateAgentAliasResponse CreateAgentAlias(CreateAgentAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAgentAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAgentAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAgentAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentAlias operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAgentAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgentAlias">REST API Reference for CreateAgentAlias Operation</seealso>
        public virtual IAsyncResult BeginCreateAgentAlias(CreateAgentAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAgentAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAgentAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAgentAlias.</param>
        /// 
        /// <returns>Returns a  CreateAgentAliasResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateAgentAlias">REST API Reference for CreateAgentAlias Operation</seealso>
        public virtual CreateAgentAliasResponse EndCreateAgentAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAgentAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataSource

        /// <summary>
        /// Create a new data source
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return Invoke<CreateDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual IAsyncResult BeginCreateDataSource(CreateDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataSource.</param>
        /// 
        /// <returns>Returns a  CreateDataSourceResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual CreateDataSourceResponse EndCreateDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateKnowledgeBase

        /// <summary>
        /// Create a new knowledge base
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKnowledgeBase service method.</param>
        /// 
        /// <returns>The response from the CreateKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateKnowledgeBase">REST API Reference for CreateKnowledgeBase Operation</seealso>
        public virtual CreateKnowledgeBaseResponse CreateKnowledgeBase(CreateKnowledgeBaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKnowledgeBaseResponseUnmarshaller.Instance;

            return Invoke<CreateKnowledgeBaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKnowledgeBase operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateKnowledgeBase">REST API Reference for CreateKnowledgeBase Operation</seealso>
        public virtual IAsyncResult BeginCreateKnowledgeBase(CreateKnowledgeBaseRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKnowledgeBaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  CreateKnowledgeBaseResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/CreateKnowledgeBase">REST API Reference for CreateKnowledgeBase Operation</seealso>
        public virtual CreateKnowledgeBaseResponse EndCreateKnowledgeBase(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateKnowledgeBaseResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAgent

        /// <summary>
        /// Deletes an Agent for existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgent service method.</param>
        /// 
        /// <returns>The response from the DeleteAgent service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgent">REST API Reference for DeleteAgent Operation</seealso>
        public virtual DeleteAgentResponse DeleteAgent(DeleteAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentResponseUnmarshaller.Instance;

            return Invoke<DeleteAgentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgent operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgent">REST API Reference for DeleteAgent Operation</seealso>
        public virtual IAsyncResult BeginDeleteAgent(DeleteAgentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DeleteAgentResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgent">REST API Reference for DeleteAgent Operation</seealso>
        public virtual DeleteAgentResponse EndDeleteAgent(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAgentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAgentActionGroup

        /// <summary>
        /// Deletes an Action Group for existing Amazon Bedrock Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentActionGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteAgentActionGroup service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentActionGroup">REST API Reference for DeleteAgentActionGroup Operation</seealso>
        public virtual DeleteAgentActionGroupResponse DeleteAgentActionGroup(DeleteAgentActionGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAgentActionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentActionGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteAgentActionGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAgentActionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentActionGroup operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAgentActionGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentActionGroup">REST API Reference for DeleteAgentActionGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteAgentActionGroup(DeleteAgentActionGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAgentActionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentActionGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAgentActionGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAgentActionGroup.</param>
        /// 
        /// <returns>Returns a  DeleteAgentActionGroupResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentActionGroup">REST API Reference for DeleteAgentActionGroup Operation</seealso>
        public virtual DeleteAgentActionGroupResponse EndDeleteAgentActionGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAgentActionGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAgentAlias

        /// <summary>
        /// Deletes an Alias for a Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAgentAlias service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentAlias">REST API Reference for DeleteAgentAlias Operation</seealso>
        public virtual DeleteAgentAliasResponse DeleteAgentAlias(DeleteAgentAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAgentAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAgentAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAgentAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentAlias operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAgentAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentAlias">REST API Reference for DeleteAgentAlias Operation</seealso>
        public virtual IAsyncResult BeginDeleteAgentAlias(DeleteAgentAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAgentAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAgentAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAgentAlias.</param>
        /// 
        /// <returns>Returns a  DeleteAgentAliasResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentAlias">REST API Reference for DeleteAgentAlias Operation</seealso>
        public virtual DeleteAgentAliasResponse EndDeleteAgentAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAgentAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAgentVersion

        /// <summary>
        /// Deletes an Agent version for existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteAgentVersion service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentVersion">REST API Reference for DeleteAgentVersion Operation</seealso>
        public virtual DeleteAgentVersionResponse DeleteAgentVersion(DeleteAgentVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAgentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteAgentVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAgentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentVersion operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAgentVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentVersion">REST API Reference for DeleteAgentVersion Operation</seealso>
        public virtual IAsyncResult BeginDeleteAgentVersion(DeleteAgentVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAgentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAgentVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAgentVersion.</param>
        /// 
        /// <returns>Returns a  DeleteAgentVersionResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteAgentVersion">REST API Reference for DeleteAgentVersion Operation</seealso>
        public virtual DeleteAgentVersionResponse EndDeleteAgentVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAgentVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataSource

        /// <summary>
        /// Delete an existing data source
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataSource(DeleteDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataSource.</param>
        /// 
        /// <returns>Returns a  DeleteDataSourceResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual DeleteDataSourceResponse EndDeleteDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteKnowledgeBase

        /// <summary>
        /// Delete an existing knowledge base
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKnowledgeBase service method.</param>
        /// 
        /// <returns>The response from the DeleteKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteKnowledgeBase">REST API Reference for DeleteKnowledgeBase Operation</seealso>
        public virtual DeleteKnowledgeBaseResponse DeleteKnowledgeBase(DeleteKnowledgeBaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKnowledgeBaseResponseUnmarshaller.Instance;

            return Invoke<DeleteKnowledgeBaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKnowledgeBase operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteKnowledgeBase">REST API Reference for DeleteKnowledgeBase Operation</seealso>
        public virtual IAsyncResult BeginDeleteKnowledgeBase(DeleteKnowledgeBaseRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKnowledgeBaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  DeleteKnowledgeBaseResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DeleteKnowledgeBase">REST API Reference for DeleteKnowledgeBase Operation</seealso>
        public virtual DeleteKnowledgeBaseResponse EndDeleteKnowledgeBase(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteKnowledgeBaseResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateAgentKnowledgeBase

        /// <summary>
        /// Disassociate an existing Knowledge Base from an Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAgentKnowledgeBase service method.</param>
        /// 
        /// <returns>The response from the DisassociateAgentKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DisassociateAgentKnowledgeBase">REST API Reference for DisassociateAgentKnowledgeBase Operation</seealso>
        public virtual DisassociateAgentKnowledgeBaseResponse DisassociateAgentKnowledgeBase(DisassociateAgentKnowledgeBaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAgentKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAgentKnowledgeBaseResponseUnmarshaller.Instance;

            return Invoke<DisassociateAgentKnowledgeBaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAgentKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAgentKnowledgeBase operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateAgentKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DisassociateAgentKnowledgeBase">REST API Reference for DisassociateAgentKnowledgeBase Operation</seealso>
        public virtual IAsyncResult BeginDisassociateAgentKnowledgeBase(DisassociateAgentKnowledgeBaseRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAgentKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAgentKnowledgeBaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateAgentKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateAgentKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  DisassociateAgentKnowledgeBaseResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/DisassociateAgentKnowledgeBase">REST API Reference for DisassociateAgentKnowledgeBase Operation</seealso>
        public virtual DisassociateAgentKnowledgeBaseResponse EndDisassociateAgentKnowledgeBase(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateAgentKnowledgeBaseResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAgent

        /// <summary>
        /// Gets an Agent for existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgent service method.</param>
        /// 
        /// <returns>The response from the GetAgent service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgent">REST API Reference for GetAgent Operation</seealso>
        public virtual GetAgentResponse GetAgent(GetAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentResponseUnmarshaller.Instance;

            return Invoke<GetAgentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAgent operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgent">REST API Reference for GetAgent Operation</seealso>
        public virtual IAsyncResult BeginGetAgent(GetAgentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAgent.</param>
        /// 
        /// <returns>Returns a  GetAgentResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgent">REST API Reference for GetAgent Operation</seealso>
        public virtual GetAgentResponse EndGetAgent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAgentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAgentActionGroup

        /// <summary>
        /// Gets an Action Group for existing Amazon Bedrock Agent Version
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentActionGroup service method.</param>
        /// 
        /// <returns>The response from the GetAgentActionGroup service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentActionGroup">REST API Reference for GetAgentActionGroup Operation</seealso>
        public virtual GetAgentActionGroupResponse GetAgentActionGroup(GetAgentActionGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAgentActionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentActionGroupResponseUnmarshaller.Instance;

            return Invoke<GetAgentActionGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAgentActionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAgentActionGroup operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAgentActionGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentActionGroup">REST API Reference for GetAgentActionGroup Operation</seealso>
        public virtual IAsyncResult BeginGetAgentActionGroup(GetAgentActionGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAgentActionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentActionGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAgentActionGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAgentActionGroup.</param>
        /// 
        /// <returns>Returns a  GetAgentActionGroupResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentActionGroup">REST API Reference for GetAgentActionGroup Operation</seealso>
        public virtual GetAgentActionGroupResponse EndGetAgentActionGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAgentActionGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAgentAlias

        /// <summary>
        /// Describes an Alias for a Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentAlias service method.</param>
        /// 
        /// <returns>The response from the GetAgentAlias service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentAlias">REST API Reference for GetAgentAlias Operation</seealso>
        public virtual GetAgentAliasResponse GetAgentAlias(GetAgentAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAgentAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentAliasResponseUnmarshaller.Instance;

            return Invoke<GetAgentAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAgentAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAgentAlias operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAgentAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentAlias">REST API Reference for GetAgentAlias Operation</seealso>
        public virtual IAsyncResult BeginGetAgentAlias(GetAgentAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAgentAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAgentAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAgentAlias.</param>
        /// 
        /// <returns>Returns a  GetAgentAliasResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentAlias">REST API Reference for GetAgentAlias Operation</seealso>
        public virtual GetAgentAliasResponse EndGetAgentAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAgentAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAgentKnowledgeBase

        /// <summary>
        /// Gets a knowledge base associated to an existing Amazon Bedrock Agent Version
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentKnowledgeBase service method.</param>
        /// 
        /// <returns>The response from the GetAgentKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentKnowledgeBase">REST API Reference for GetAgentKnowledgeBase Operation</seealso>
        public virtual GetAgentKnowledgeBaseResponse GetAgentKnowledgeBase(GetAgentKnowledgeBaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAgentKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentKnowledgeBaseResponseUnmarshaller.Instance;

            return Invoke<GetAgentKnowledgeBaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAgentKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAgentKnowledgeBase operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAgentKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentKnowledgeBase">REST API Reference for GetAgentKnowledgeBase Operation</seealso>
        public virtual IAsyncResult BeginGetAgentKnowledgeBase(GetAgentKnowledgeBaseRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAgentKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentKnowledgeBaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAgentKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAgentKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  GetAgentKnowledgeBaseResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentKnowledgeBase">REST API Reference for GetAgentKnowledgeBase Operation</seealso>
        public virtual GetAgentKnowledgeBaseResponse EndGetAgentKnowledgeBase(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAgentKnowledgeBaseResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAgentVersion

        /// <summary>
        /// Gets an Agent version for existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentVersion service method.</param>
        /// 
        /// <returns>The response from the GetAgentVersion service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentVersion">REST API Reference for GetAgentVersion Operation</seealso>
        public virtual GetAgentVersionResponse GetAgentVersion(GetAgentVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAgentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentVersionResponseUnmarshaller.Instance;

            return Invoke<GetAgentVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAgentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAgentVersion operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAgentVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentVersion">REST API Reference for GetAgentVersion Operation</seealso>
        public virtual IAsyncResult BeginGetAgentVersion(GetAgentVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAgentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgentVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAgentVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAgentVersion.</param>
        /// 
        /// <returns>Returns a  GetAgentVersionResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetAgentVersion">REST API Reference for GetAgentVersion Operation</seealso>
        public virtual GetAgentVersionResponse EndGetAgentVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAgentVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataSource

        /// <summary>
        /// Get an existing data source
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource service method.</param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual GetDataSourceResponse GetDataSource(GetDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return Invoke<GetDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual IAsyncResult BeginGetDataSource(GetDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataSource.</param>
        /// 
        /// <returns>Returns a  GetDataSourceResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual GetDataSourceResponse EndGetDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIngestionJob

        /// <summary>
        /// Get an ingestion job
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIngestionJob service method.</param>
        /// 
        /// <returns>The response from the GetIngestionJob service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetIngestionJob">REST API Reference for GetIngestionJob Operation</seealso>
        public virtual GetIngestionJobResponse GetIngestionJob(GetIngestionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIngestionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIngestionJobResponseUnmarshaller.Instance;

            return Invoke<GetIngestionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIngestionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIngestionJob operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIngestionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetIngestionJob">REST API Reference for GetIngestionJob Operation</seealso>
        public virtual IAsyncResult BeginGetIngestionJob(GetIngestionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIngestionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIngestionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIngestionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIngestionJob.</param>
        /// 
        /// <returns>Returns a  GetIngestionJobResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetIngestionJob">REST API Reference for GetIngestionJob Operation</seealso>
        public virtual GetIngestionJobResponse EndGetIngestionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIngestionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetKnowledgeBase

        /// <summary>
        /// Get an existing knowledge base
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKnowledgeBase service method.</param>
        /// 
        /// <returns>The response from the GetKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetKnowledgeBase">REST API Reference for GetKnowledgeBase Operation</seealso>
        public virtual GetKnowledgeBaseResponse GetKnowledgeBase(GetKnowledgeBaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKnowledgeBaseResponseUnmarshaller.Instance;

            return Invoke<GetKnowledgeBaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKnowledgeBase operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetKnowledgeBase">REST API Reference for GetKnowledgeBase Operation</seealso>
        public virtual IAsyncResult BeginGetKnowledgeBase(GetKnowledgeBaseRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKnowledgeBaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  GetKnowledgeBaseResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/GetKnowledgeBase">REST API Reference for GetKnowledgeBase Operation</seealso>
        public virtual GetKnowledgeBaseResponse EndGetKnowledgeBase(IAsyncResult asyncResult)
        {
            return EndInvoke<GetKnowledgeBaseResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAgentActionGroups

        /// <summary>
        /// Lists an Action Group for existing Amazon Bedrock Agent Version
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentActionGroups service method.</param>
        /// 
        /// <returns>The response from the ListAgentActionGroups service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentActionGroups">REST API Reference for ListAgentActionGroups Operation</seealso>
        public virtual ListAgentActionGroupsResponse ListAgentActionGroups(ListAgentActionGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAgentActionGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentActionGroupsResponseUnmarshaller.Instance;

            return Invoke<ListAgentActionGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAgentActionGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAgentActionGroups operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAgentActionGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentActionGroups">REST API Reference for ListAgentActionGroups Operation</seealso>
        public virtual IAsyncResult BeginListAgentActionGroups(ListAgentActionGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAgentActionGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentActionGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAgentActionGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAgentActionGroups.</param>
        /// 
        /// <returns>Returns a  ListAgentActionGroupsResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentActionGroups">REST API Reference for ListAgentActionGroups Operation</seealso>
        public virtual ListAgentActionGroupsResponse EndListAgentActionGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAgentActionGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAgentAliases

        /// <summary>
        /// Lists all the Aliases for an Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentAliases service method.</param>
        /// 
        /// <returns>The response from the ListAgentAliases service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentAliases">REST API Reference for ListAgentAliases Operation</seealso>
        public virtual ListAgentAliasesResponse ListAgentAliases(ListAgentAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAgentAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAgentAliasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAgentAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAgentAliases operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAgentAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentAliases">REST API Reference for ListAgentAliases Operation</seealso>
        public virtual IAsyncResult BeginListAgentAliases(ListAgentAliasesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAgentAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentAliasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAgentAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAgentAliases.</param>
        /// 
        /// <returns>Returns a  ListAgentAliasesResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentAliases">REST API Reference for ListAgentAliases Operation</seealso>
        public virtual ListAgentAliasesResponse EndListAgentAliases(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAgentAliasesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAgentKnowledgeBases

        /// <summary>
        /// List of Knowledge Bases associated to an existing Amazon Bedrock Agent Version
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentKnowledgeBases service method.</param>
        /// 
        /// <returns>The response from the ListAgentKnowledgeBases service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentKnowledgeBases">REST API Reference for ListAgentKnowledgeBases Operation</seealso>
        public virtual ListAgentKnowledgeBasesResponse ListAgentKnowledgeBases(ListAgentKnowledgeBasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAgentKnowledgeBasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentKnowledgeBasesResponseUnmarshaller.Instance;

            return Invoke<ListAgentKnowledgeBasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAgentKnowledgeBases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAgentKnowledgeBases operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAgentKnowledgeBases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentKnowledgeBases">REST API Reference for ListAgentKnowledgeBases Operation</seealso>
        public virtual IAsyncResult BeginListAgentKnowledgeBases(ListAgentKnowledgeBasesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAgentKnowledgeBasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentKnowledgeBasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAgentKnowledgeBases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAgentKnowledgeBases.</param>
        /// 
        /// <returns>Returns a  ListAgentKnowledgeBasesResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentKnowledgeBases">REST API Reference for ListAgentKnowledgeBases Operation</seealso>
        public virtual ListAgentKnowledgeBasesResponse EndListAgentKnowledgeBases(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAgentKnowledgeBasesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAgents

        /// <summary>
        /// Lists Agents
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgents service method.</param>
        /// 
        /// <returns>The response from the ListAgents service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgents">REST API Reference for ListAgents Operation</seealso>
        public virtual ListAgentsResponse ListAgents(ListAgentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentsResponseUnmarshaller.Instance;

            return Invoke<ListAgentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAgents operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAgents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgents">REST API Reference for ListAgents Operation</seealso>
        public virtual IAsyncResult BeginListAgents(ListAgentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ListAgentsResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgents">REST API Reference for ListAgents Operation</seealso>
        public virtual ListAgentsResponse EndListAgents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAgentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAgentVersions

        /// <summary>
        /// Lists Agent Versions
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentVersions service method.</param>
        /// 
        /// <returns>The response from the ListAgentVersions service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentVersions">REST API Reference for ListAgentVersions Operation</seealso>
        public virtual ListAgentVersionsResponse ListAgentVersions(ListAgentVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAgentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentVersionsResponseUnmarshaller.Instance;

            return Invoke<ListAgentVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAgentVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAgentVersions operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAgentVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentVersions">REST API Reference for ListAgentVersions Operation</seealso>
        public virtual IAsyncResult BeginListAgentVersions(ListAgentVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAgentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAgentVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAgentVersions.</param>
        /// 
        /// <returns>Returns a  ListAgentVersionsResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListAgentVersions">REST API Reference for ListAgentVersions Operation</seealso>
        public virtual ListAgentVersionsResponse EndListAgentVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAgentVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataSources

        /// <summary>
        /// List data sources
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return Invoke<ListDataSourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual IAsyncResult BeginListDataSources(ListDataSourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataSources.</param>
        /// 
        /// <returns>Returns a  ListDataSourcesResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual ListDataSourcesResponse EndListDataSources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataSourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIngestionJobs

        /// <summary>
        /// List ingestion jobs
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIngestionJobs service method.</param>
        /// 
        /// <returns>The response from the ListIngestionJobs service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListIngestionJobs">REST API Reference for ListIngestionJobs Operation</seealso>
        public virtual ListIngestionJobsResponse ListIngestionJobs(ListIngestionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIngestionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIngestionJobsResponseUnmarshaller.Instance;

            return Invoke<ListIngestionJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIngestionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIngestionJobs operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIngestionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListIngestionJobs">REST API Reference for ListIngestionJobs Operation</seealso>
        public virtual IAsyncResult BeginListIngestionJobs(ListIngestionJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIngestionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIngestionJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIngestionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIngestionJobs.</param>
        /// 
        /// <returns>Returns a  ListIngestionJobsResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListIngestionJobs">REST API Reference for ListIngestionJobs Operation</seealso>
        public virtual ListIngestionJobsResponse EndListIngestionJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIngestionJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListKnowledgeBases

        /// <summary>
        /// List Knowledge Bases
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKnowledgeBases service method.</param>
        /// 
        /// <returns>The response from the ListKnowledgeBases service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListKnowledgeBases">REST API Reference for ListKnowledgeBases Operation</seealso>
        public virtual ListKnowledgeBasesResponse ListKnowledgeBases(ListKnowledgeBasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKnowledgeBasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKnowledgeBasesResponseUnmarshaller.Instance;

            return Invoke<ListKnowledgeBasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListKnowledgeBases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKnowledgeBases operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKnowledgeBases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListKnowledgeBases">REST API Reference for ListKnowledgeBases Operation</seealso>
        public virtual IAsyncResult BeginListKnowledgeBases(ListKnowledgeBasesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKnowledgeBasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKnowledgeBasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListKnowledgeBases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKnowledgeBases.</param>
        /// 
        /// <returns>Returns a  ListKnowledgeBasesResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListKnowledgeBases">REST API Reference for ListKnowledgeBases Operation</seealso>
        public virtual ListKnowledgeBasesResponse EndListKnowledgeBases(IAsyncResult asyncResult)
        {
            return EndInvoke<ListKnowledgeBasesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// List tags for a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PrepareAgent

        /// <summary>
        /// Prepares an existing Amazon Bedrock Agent to receive runtime requests
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PrepareAgent service method.</param>
        /// 
        /// <returns>The response from the PrepareAgent service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/PrepareAgent">REST API Reference for PrepareAgent Operation</seealso>
        public virtual PrepareAgentResponse PrepareAgent(PrepareAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PrepareAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PrepareAgentResponseUnmarshaller.Instance;

            return Invoke<PrepareAgentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PrepareAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PrepareAgent operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPrepareAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/PrepareAgent">REST API Reference for PrepareAgent Operation</seealso>
        public virtual IAsyncResult BeginPrepareAgent(PrepareAgentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PrepareAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PrepareAgentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PrepareAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPrepareAgent.</param>
        /// 
        /// <returns>Returns a  PrepareAgentResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/PrepareAgent">REST API Reference for PrepareAgent Operation</seealso>
        public virtual PrepareAgentResponse EndPrepareAgent(IAsyncResult asyncResult)
        {
            return EndInvoke<PrepareAgentResponse>(asyncResult);
        }

        #endregion
        
        #region  StartIngestionJob

        /// <summary>
        /// Start a new ingestion job
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartIngestionJob service method.</param>
        /// 
        /// <returns>The response from the StartIngestionJob service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/StartIngestionJob">REST API Reference for StartIngestionJob Operation</seealso>
        public virtual StartIngestionJobResponse StartIngestionJob(StartIngestionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartIngestionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartIngestionJobResponseUnmarshaller.Instance;

            return Invoke<StartIngestionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartIngestionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartIngestionJob operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartIngestionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/StartIngestionJob">REST API Reference for StartIngestionJob Operation</seealso>
        public virtual IAsyncResult BeginStartIngestionJob(StartIngestionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartIngestionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartIngestionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartIngestionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartIngestionJob.</param>
        /// 
        /// <returns>Returns a  StartIngestionJobResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/StartIngestionJob">REST API Reference for StartIngestionJob Operation</seealso>
        public virtual StartIngestionJobResponse EndStartIngestionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartIngestionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Tag a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Untag a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAgent

        /// <summary>
        /// Updates an existing Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgent service method.</param>
        /// 
        /// <returns>The response from the UpdateAgent service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgent">REST API Reference for UpdateAgent Operation</seealso>
        public virtual UpdateAgentResponse UpdateAgent(UpdateAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentResponseUnmarshaller.Instance;

            return Invoke<UpdateAgentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgent operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgent">REST API Reference for UpdateAgent Operation</seealso>
        public virtual IAsyncResult BeginUpdateAgent(UpdateAgentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  UpdateAgentResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgent">REST API Reference for UpdateAgent Operation</seealso>
        public virtual UpdateAgentResponse EndUpdateAgent(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAgentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAgentActionGroup

        /// <summary>
        /// Updates an existing Action Group for Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentActionGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateAgentActionGroup service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentActionGroup">REST API Reference for UpdateAgentActionGroup Operation</seealso>
        public virtual UpdateAgentActionGroupResponse UpdateAgentActionGroup(UpdateAgentActionGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAgentActionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentActionGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateAgentActionGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAgentActionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentActionGroup operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAgentActionGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentActionGroup">REST API Reference for UpdateAgentActionGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateAgentActionGroup(UpdateAgentActionGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAgentActionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentActionGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAgentActionGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAgentActionGroup.</param>
        /// 
        /// <returns>Returns a  UpdateAgentActionGroupResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentActionGroup">REST API Reference for UpdateAgentActionGroup Operation</seealso>
        public virtual UpdateAgentActionGroupResponse EndUpdateAgentActionGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAgentActionGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAgentAlias

        /// <summary>
        /// Updates an existing Alias for an Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateAgentAlias service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentAlias">REST API Reference for UpdateAgentAlias Operation</seealso>
        public virtual UpdateAgentAliasResponse UpdateAgentAlias(UpdateAgentAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAgentAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateAgentAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAgentAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentAlias operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAgentAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentAlias">REST API Reference for UpdateAgentAlias Operation</seealso>
        public virtual IAsyncResult BeginUpdateAgentAlias(UpdateAgentAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAgentAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAgentAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAgentAlias.</param>
        /// 
        /// <returns>Returns a  UpdateAgentAliasResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentAlias">REST API Reference for UpdateAgentAlias Operation</seealso>
        public virtual UpdateAgentAliasResponse EndUpdateAgentAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAgentAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAgentKnowledgeBase

        /// <summary>
        /// Updates an existing Knowledge Base associated to an Amazon Bedrock Agent
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentKnowledgeBase service method.</param>
        /// 
        /// <returns>The response from the UpdateAgentKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentKnowledgeBase">REST API Reference for UpdateAgentKnowledgeBase Operation</seealso>
        public virtual UpdateAgentKnowledgeBaseResponse UpdateAgentKnowledgeBase(UpdateAgentKnowledgeBaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAgentKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentKnowledgeBaseResponseUnmarshaller.Instance;

            return Invoke<UpdateAgentKnowledgeBaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAgentKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentKnowledgeBase operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAgentKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentKnowledgeBase">REST API Reference for UpdateAgentKnowledgeBase Operation</seealso>
        public virtual IAsyncResult BeginUpdateAgentKnowledgeBase(UpdateAgentKnowledgeBaseRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAgentKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentKnowledgeBaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAgentKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAgentKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  UpdateAgentKnowledgeBaseResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateAgentKnowledgeBase">REST API Reference for UpdateAgentKnowledgeBase Operation</seealso>
        public virtual UpdateAgentKnowledgeBaseResponse EndUpdateAgentKnowledgeBase(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAgentKnowledgeBaseResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataSource

        /// <summary>
        /// Update an existing data source
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataSource(UpdateDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataSource.</param>
        /// 
        /// <returns>Returns a  UpdateDataSourceResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual UpdateDataSourceResponse EndUpdateDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateKnowledgeBase

        /// <summary>
        /// Update an existing knowledge base
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKnowledgeBase service method.</param>
        /// 
        /// <returns>The response from the UpdateKnowledgeBase service method, as returned by BedrockAgent.</returns>
        /// <exception cref="Amazon.BedrockAgent.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockAgent.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateKnowledgeBase">REST API Reference for UpdateKnowledgeBase Operation</seealso>
        public virtual UpdateKnowledgeBaseResponse UpdateKnowledgeBase(UpdateKnowledgeBaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKnowledgeBaseResponseUnmarshaller.Instance;

            return Invoke<UpdateKnowledgeBaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKnowledgeBase operation on AmazonBedrockAgentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKnowledgeBase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateKnowledgeBase">REST API Reference for UpdateKnowledgeBase Operation</seealso>
        public virtual IAsyncResult BeginUpdateKnowledgeBase(UpdateKnowledgeBaseRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateKnowledgeBaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKnowledgeBaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKnowledgeBase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKnowledgeBase.</param>
        /// 
        /// <returns>Returns a  UpdateKnowledgeBaseResult from BedrockAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-2023-06-05/UpdateKnowledgeBase">REST API Reference for UpdateKnowledgeBase Operation</seealso>
        public virtual UpdateKnowledgeBaseResponse EndUpdateKnowledgeBase(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateKnowledgeBaseResponse>(asyncResult);
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
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonBedrockAgentEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}