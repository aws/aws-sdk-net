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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Appflow.Model;
using Amazon.Appflow.Model.Internal.MarshallTransformations;
using Amazon.Appflow.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Appflow
{
    /// <summary>
    /// <para>Implementation for accessing Appflow</para>
    ///
    /// Welcome to the Amazon AppFlow API reference. This guide is for developers who need
    /// detailed information about the Amazon AppFlow API operations, data types, and errors.
    /// 
    /// 
    ///  
    /// <para>
    /// Amazon AppFlow is a fully managed integration service that enables you to securely
    /// transfer data between software as a service (SaaS) applications like Salesforce, Marketo,
    /// Slack, and ServiceNow, and Amazon Web Services like Amazon S3 and Amazon Redshift.
    /// 
    /// </para>
    ///  
    /// <para>
    /// Use the following links to get started on the Amazon AppFlow API:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/appflow/1.0/APIReference/API_Operations.html">Actions</a>:
    /// An alphabetical list of all Amazon AppFlow API operations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/appflow/1.0/APIReference/API_Types.html">Data
    /// types</a>: An alphabetical list of all Amazon AppFlow data types.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/appflow/1.0/APIReference/CommonParameters.html">Common
    /// parameters</a>: Parameters that all Query operations can use.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/appflow/1.0/APIReference/CommonErrors.html">Common
    /// errors</a>: Client and server errors that all operations can return.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you're new to Amazon AppFlow, we recommend that you review the <a href="https://docs.aws.amazon.com/appflow/latest/userguide/what-is-appflow.html">Amazon
    /// AppFlow User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// Amazon AppFlow API users can use vendor-specific mechanisms for OAuth, and include
    /// applicable OAuth attributes (such as <c>auth-code</c> and <c>redirecturi</c>) with
    /// the connector-specific <c>ConnectorProfileProperties</c> when creating a new connector
    /// profile using Amazon AppFlow API operations. For example, Salesforce users can refer
    /// to the <a href="https://help.salesforce.com/articleView?id=remoteaccess_authenticate.htm">
    /// <i>Authorize Apps with OAuth</i> </a> documentation.
    /// </para>
    /// </summary>
    public partial class AmazonAppflowClient : AmazonServiceClient, IAmazonAppflow
    {
        private static IServiceMetadata serviceMetadata = new AmazonAppflowMetadata();
        private IAppflowPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAppflowPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AppflowPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonAppflowClient with the credentials loaded from the application's
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
        public AmazonAppflowClient()
            : base(new AmazonAppflowConfig()) { }

        /// <summary>
        /// Constructs AmazonAppflowClient with the credentials loaded from the application's
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
        public AmazonAppflowClient(RegionEndpoint region)
            : base(new AmazonAppflowConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAppflowClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAppflowClient Configuration Object</param>
        public AmazonAppflowClient(AmazonAppflowConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonAppflowClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAppflowClient(AWSCredentials credentials)
            : this(credentials, new AmazonAppflowConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppflowClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppflowClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAppflowConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppflowClient with AWS Credentials and an
        /// AmazonAppflowClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAppflowClient Configuration Object</param>
        public AmazonAppflowClient(AWSCredentials credentials, AmazonAppflowConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppflowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAppflowClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppflowConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppflowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppflowClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppflowConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppflowClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppflowClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAppflowClient Configuration Object</param>
        public AmazonAppflowClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAppflowConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppflowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAppflowClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppflowConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppflowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppflowClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppflowConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppflowClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppflowClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAppflowClient Configuration Object</param>
        public AmazonAppflowClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAppflowConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAppflowEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAppflowAuthSchemeHandler());
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


        #region  CancelFlowExecutions


        /// <summary>
        /// Cancels active runs for a flow.
        /// 
        ///  
        /// <para>
        /// You can cancel all of the active runs for a flow, or you can cancel specific runs
        /// by providing their IDs.
        /// </para>
        ///  
        /// <para>
        /// You can cancel a flow run only when the run is in progress. You can't cancel a run
        /// that has already completed or failed. You also can't cancel a run that's scheduled
        /// to occur but hasn't started yet. To prevent a scheduled run, you can deactivate the
        /// flow with the <c>StopFlow</c> action.
        /// </para>
        ///  
        /// <para>
        /// You cannot resume a run after you cancel it.
        /// </para>
        ///  
        /// <para>
        /// When you send your request, the status for each run becomes <c>CancelStarted</c>.
        /// When the cancellation completes, the status becomes <c>Canceled</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you cancel a run, you still incur charges for any data that the run already processed
        /// before the cancellation. If the run had already written some data to the flow destination,
        /// then that data remains in the destination. If you configured the flow to use a batch
        /// API (such as the Salesforce Bulk API 2.0), then the run will finish reading or writing
        /// its entire batch of data after the cancellation. For these operations, the data processing
        /// charges for Amazon AppFlow apply. For the pricing information, see <a href="http://aws.amazon.com/appflow/pricing/">Amazon
        /// AppFlow pricing</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelFlowExecutions service method.</param>
        /// 
        /// <returns>The response from the CancelFlowExecutions service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.AccessDeniedException">
        /// AppFlow/Requester has invalid or missing permissions.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ThrottlingException">
        /// API calls have exceeded the maximum allowed API request rate per account and per Region.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/CancelFlowExecutions">REST API Reference for CancelFlowExecutions Operation</seealso>
        public virtual CancelFlowExecutionsResponse CancelFlowExecutions(CancelFlowExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelFlowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelFlowExecutionsResponseUnmarshaller.Instance;

            return Invoke<CancelFlowExecutionsResponse>(request, options);
        }


        /// <summary>
        /// Cancels active runs for a flow.
        /// 
        ///  
        /// <para>
        /// You can cancel all of the active runs for a flow, or you can cancel specific runs
        /// by providing their IDs.
        /// </para>
        ///  
        /// <para>
        /// You can cancel a flow run only when the run is in progress. You can't cancel a run
        /// that has already completed or failed. You also can't cancel a run that's scheduled
        /// to occur but hasn't started yet. To prevent a scheduled run, you can deactivate the
        /// flow with the <c>StopFlow</c> action.
        /// </para>
        ///  
        /// <para>
        /// You cannot resume a run after you cancel it.
        /// </para>
        ///  
        /// <para>
        /// When you send your request, the status for each run becomes <c>CancelStarted</c>.
        /// When the cancellation completes, the status becomes <c>Canceled</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you cancel a run, you still incur charges for any data that the run already processed
        /// before the cancellation. If the run had already written some data to the flow destination,
        /// then that data remains in the destination. If you configured the flow to use a batch
        /// API (such as the Salesforce Bulk API 2.0), then the run will finish reading or writing
        /// its entire batch of data after the cancellation. For these operations, the data processing
        /// charges for Amazon AppFlow apply. For the pricing information, see <a href="http://aws.amazon.com/appflow/pricing/">Amazon
        /// AppFlow pricing</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelFlowExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelFlowExecutions service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.AccessDeniedException">
        /// AppFlow/Requester has invalid or missing permissions.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ThrottlingException">
        /// API calls have exceeded the maximum allowed API request rate per account and per Region.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/CancelFlowExecutions">REST API Reference for CancelFlowExecutions Operation</seealso>
        public virtual Task<CancelFlowExecutionsResponse> CancelFlowExecutionsAsync(CancelFlowExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelFlowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelFlowExecutionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelFlowExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConnectorProfile


        /// <summary>
        /// Creates a new connector profile associated with your Amazon Web Services account.
        /// There is a soft quota of 100 connector profiles per Amazon Web Services account. If
        /// you need more connector profiles than this quota allows, you can submit a request
        /// to the Amazon AppFlow team through the Amazon AppFlow support channel. In each connector
        /// profile that you create, you can provide the credentials and properties for only one
        /// connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectorProfile service method.</param>
        /// 
        /// <returns>The response from the CreateConnectorProfile service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorAuthenticationException">
        /// An error occurred when authenticating with the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota (such as the number of flows) to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/CreateConnectorProfile">REST API Reference for CreateConnectorProfile Operation</seealso>
        public virtual CreateConnectorProfileResponse CreateConnectorProfile(CreateConnectorProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectorProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectorProfileResponseUnmarshaller.Instance;

            return Invoke<CreateConnectorProfileResponse>(request, options);
        }


        /// <summary>
        /// Creates a new connector profile associated with your Amazon Web Services account.
        /// There is a soft quota of 100 connector profiles per Amazon Web Services account. If
        /// you need more connector profiles than this quota allows, you can submit a request
        /// to the Amazon AppFlow team through the Amazon AppFlow support channel. In each connector
        /// profile that you create, you can provide the credentials and properties for only one
        /// connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectorProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnectorProfile service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorAuthenticationException">
        /// An error occurred when authenticating with the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota (such as the number of flows) to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/CreateConnectorProfile">REST API Reference for CreateConnectorProfile Operation</seealso>
        public virtual Task<CreateConnectorProfileResponse> CreateConnectorProfileAsync(CreateConnectorProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectorProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectorProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateConnectorProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFlow


        /// <summary>
        /// Enables your application to create a new flow using Amazon AppFlow. You must create
        /// a connector profile before calling this API. Please note that the Request Syntax below
        /// shows syntax for multiple destinations, however, you can only transfer data to one
        /// item in this list at a time. Amazon AppFlow does not currently support flows to multiple
        /// destinations at once.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlow service method.</param>
        /// 
        /// <returns>The response from the CreateFlow service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.AccessDeniedException">
        /// AppFlow/Requester has invalid or missing permissions.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorAuthenticationException">
        /// An error occurred when authenticating with the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorServerException">
        /// An error occurred when retrieving data from the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota (such as the number of flows) to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/CreateFlow">REST API Reference for CreateFlow Operation</seealso>
        public virtual CreateFlowResponse CreateFlow(CreateFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowResponseUnmarshaller.Instance;

            return Invoke<CreateFlowResponse>(request, options);
        }


        /// <summary>
        /// Enables your application to create a new flow using Amazon AppFlow. You must create
        /// a connector profile before calling this API. Please note that the Request Syntax below
        /// shows syntax for multiple destinations, however, you can only transfer data to one
        /// item in this list at a time. Amazon AppFlow does not currently support flows to multiple
        /// destinations at once.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFlow service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.AccessDeniedException">
        /// AppFlow/Requester has invalid or missing permissions.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorAuthenticationException">
        /// An error occurred when authenticating with the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorServerException">
        /// An error occurred when retrieving data from the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota (such as the number of flows) to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/CreateFlow">REST API Reference for CreateFlow Operation</seealso>
        public virtual Task<CreateFlowResponse> CreateFlowAsync(CreateFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConnectorProfile


        /// <summary>
        /// Enables you to delete an existing connector profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectorProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteConnectorProfile service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DeleteConnectorProfile">REST API Reference for DeleteConnectorProfile Operation</seealso>
        public virtual DeleteConnectorProfileResponse DeleteConnectorProfile(DeleteConnectorProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectorProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectorProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectorProfileResponse>(request, options);
        }


        /// <summary>
        /// Enables you to delete an existing connector profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectorProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnectorProfile service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DeleteConnectorProfile">REST API Reference for DeleteConnectorProfile Operation</seealso>
        public virtual Task<DeleteConnectorProfileResponse> DeleteConnectorProfileAsync(DeleteConnectorProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectorProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectorProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteConnectorProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFlow


        /// <summary>
        /// Enables your application to delete an existing flow. Before deleting the flow, Amazon
        /// AppFlow validates the request by checking the flow configuration and status. You can
        /// delete flows one at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlow service method.</param>
        /// 
        /// <returns>The response from the DeleteFlow service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DeleteFlow">REST API Reference for DeleteFlow Operation</seealso>
        public virtual DeleteFlowResponse DeleteFlow(DeleteFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowResponseUnmarshaller.Instance;

            return Invoke<DeleteFlowResponse>(request, options);
        }


        /// <summary>
        /// Enables your application to delete an existing flow. Before deleting the flow, Amazon
        /// AppFlow validates the request by checking the flow configuration and status. You can
        /// delete flows one at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFlow service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DeleteFlow">REST API Reference for DeleteFlow Operation</seealso>
        public virtual Task<DeleteFlowResponse> DeleteFlowAsync(DeleteFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConnector


        /// <summary>
        /// Describes the given custom connector registered in your Amazon Web Services account.
        /// This API can be used for custom connectors that are registered in your account and
        /// also for Amazon authored connectors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnector service method.</param>
        /// 
        /// <returns>The response from the DescribeConnector service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeConnector">REST API Reference for DescribeConnector Operation</seealso>
        public virtual DescribeConnectorResponse DescribeConnector(DescribeConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectorResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectorResponse>(request, options);
        }


        /// <summary>
        /// Describes the given custom connector registered in your Amazon Web Services account.
        /// This API can be used for custom connectors that are registered in your account and
        /// also for Amazon authored connectors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnector service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeConnector">REST API Reference for DescribeConnector Operation</seealso>
        public virtual Task<DescribeConnectorResponse> DescribeConnectorAsync(DescribeConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectorResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeConnectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConnectorEntity


        /// <summary>
        /// Provides details regarding the entity used with the connector, with a description
        /// of the data model for each field in that entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectorEntity service method.</param>
        /// 
        /// <returns>The response from the DescribeConnectorEntity service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConnectorAuthenticationException">
        /// An error occurred when authenticating with the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorServerException">
        /// An error occurred when retrieving data from the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeConnectorEntity">REST API Reference for DescribeConnectorEntity Operation</seealso>
        public virtual DescribeConnectorEntityResponse DescribeConnectorEntity(DescribeConnectorEntityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConnectorEntityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectorEntityResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectorEntityResponse>(request, options);
        }


        /// <summary>
        /// Provides details regarding the entity used with the connector, with a description
        /// of the data model for each field in that entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectorEntity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnectorEntity service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConnectorAuthenticationException">
        /// An error occurred when authenticating with the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorServerException">
        /// An error occurred when retrieving data from the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeConnectorEntity">REST API Reference for DescribeConnectorEntity Operation</seealso>
        public virtual Task<DescribeConnectorEntityResponse> DescribeConnectorEntityAsync(DescribeConnectorEntityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConnectorEntityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectorEntityResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeConnectorEntityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConnectorProfiles


        /// <summary>
        /// Returns a list of <c>connector-profile</c> details matching the provided <c>connector-profile</c>
        /// names and <c>connector-types</c>. Both input lists are optional, and you can use them
        /// to filter the result. 
        /// 
        ///  
        /// <para>
        /// If no names or <c>connector-types</c> are provided, returns all connector profiles
        /// in a paginated form. If there is no match, this operation returns an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectorProfiles service method.</param>
        /// 
        /// <returns>The response from the DescribeConnectorProfiles service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeConnectorProfiles">REST API Reference for DescribeConnectorProfiles Operation</seealso>
        public virtual DescribeConnectorProfilesResponse DescribeConnectorProfiles(DescribeConnectorProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConnectorProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectorProfilesResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectorProfilesResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of <c>connector-profile</c> details matching the provided <c>connector-profile</c>
        /// names and <c>connector-types</c>. Both input lists are optional, and you can use them
        /// to filter the result. 
        /// 
        ///  
        /// <para>
        /// If no names or <c>connector-types</c> are provided, returns all connector profiles
        /// in a paginated form. If there is no match, this operation returns an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectorProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnectorProfiles service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeConnectorProfiles">REST API Reference for DescribeConnectorProfiles Operation</seealso>
        public virtual Task<DescribeConnectorProfilesResponse> DescribeConnectorProfilesAsync(DescribeConnectorProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConnectorProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectorProfilesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeConnectorProfilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConnectors


        /// <summary>
        /// Describes the connectors vended by Amazon AppFlow for specified connector types.
        /// If you don't specify a connector type, this operation describes all connectors vended
        /// by Amazon AppFlow. If there are more connectors than can be returned in one page,
        /// the response contains a <c>nextToken</c> object, which can be be passed in to the
        /// next call to the <c>DescribeConnectors</c> API operation to retrieve the next page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectors service method.</param>
        /// 
        /// <returns>The response from the DescribeConnectors service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeConnectors">REST API Reference for DescribeConnectors Operation</seealso>
        public virtual DescribeConnectorsResponse DescribeConnectors(DescribeConnectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectorsResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectorsResponse>(request, options);
        }


        /// <summary>
        /// Describes the connectors vended by Amazon AppFlow for specified connector types.
        /// If you don't specify a connector type, this operation describes all connectors vended
        /// by Amazon AppFlow. If there are more connectors than can be returned in one page,
        /// the response contains a <c>nextToken</c> object, which can be be passed in to the
        /// next call to the <c>DescribeConnectors</c> API operation to retrieve the next page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnectors service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeConnectors">REST API Reference for DescribeConnectors Operation</seealso>
        public virtual Task<DescribeConnectorsResponse> DescribeConnectorsAsync(DescribeConnectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectorsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeConnectorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFlow


        /// <summary>
        /// Provides a description of the specified flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlow service method.</param>
        /// 
        /// <returns>The response from the DescribeFlow service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeFlow">REST API Reference for DescribeFlow Operation</seealso>
        public virtual DescribeFlowResponse DescribeFlow(DescribeFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowResponseUnmarshaller.Instance;

            return Invoke<DescribeFlowResponse>(request, options);
        }


        /// <summary>
        /// Provides a description of the specified flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFlow service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeFlow">REST API Reference for DescribeFlow Operation</seealso>
        public virtual Task<DescribeFlowResponse> DescribeFlowAsync(DescribeFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFlowExecutionRecords


        /// <summary>
        /// Fetches the execution history of the flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowExecutionRecords service method.</param>
        /// 
        /// <returns>The response from the DescribeFlowExecutionRecords service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeFlowExecutionRecords">REST API Reference for DescribeFlowExecutionRecords Operation</seealso>
        public virtual DescribeFlowExecutionRecordsResponse DescribeFlowExecutionRecords(DescribeFlowExecutionRecordsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFlowExecutionRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowExecutionRecordsResponseUnmarshaller.Instance;

            return Invoke<DescribeFlowExecutionRecordsResponse>(request, options);
        }


        /// <summary>
        /// Fetches the execution history of the flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowExecutionRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFlowExecutionRecords service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeFlowExecutionRecords">REST API Reference for DescribeFlowExecutionRecords Operation</seealso>
        public virtual Task<DescribeFlowExecutionRecordsResponse> DescribeFlowExecutionRecordsAsync(DescribeFlowExecutionRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFlowExecutionRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowExecutionRecordsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeFlowExecutionRecordsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConnectorEntities


        /// <summary>
        /// Returns the list of available connector entities supported by Amazon AppFlow. For
        /// example, you can query Salesforce for <i>Account</i> and <i>Opportunity</i> entities,
        /// or query ServiceNow for the <i>Incident</i> entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectorEntities service method.</param>
        /// 
        /// <returns>The response from the ListConnectorEntities service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConnectorAuthenticationException">
        /// An error occurred when authenticating with the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorServerException">
        /// An error occurred when retrieving data from the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/ListConnectorEntities">REST API Reference for ListConnectorEntities Operation</seealso>
        public virtual ListConnectorEntitiesResponse ListConnectorEntities(ListConnectorEntitiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectorEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorEntitiesResponseUnmarshaller.Instance;

            return Invoke<ListConnectorEntitiesResponse>(request, options);
        }


        /// <summary>
        /// Returns the list of available connector entities supported by Amazon AppFlow. For
        /// example, you can query Salesforce for <i>Account</i> and <i>Opportunity</i> entities,
        /// or query ServiceNow for the <i>Incident</i> entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectorEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnectorEntities service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConnectorAuthenticationException">
        /// An error occurred when authenticating with the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorServerException">
        /// An error occurred when retrieving data from the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/ListConnectorEntities">REST API Reference for ListConnectorEntities Operation</seealso>
        public virtual Task<ListConnectorEntitiesResponse> ListConnectorEntitiesAsync(ListConnectorEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectorEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorEntitiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListConnectorEntitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConnectors


        /// <summary>
        /// Returns the list of all registered custom connectors in your Amazon Web Services account.
        /// This API lists only custom connectors registered in this account, not the Amazon Web
        /// Services authored connectors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors service method.</param>
        /// 
        /// <returns>The response from the ListConnectors service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        public virtual ListConnectorsResponse ListConnectors(ListConnectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorsResponseUnmarshaller.Instance;

            return Invoke<ListConnectorsResponse>(request, options);
        }


        /// <summary>
        /// Returns the list of all registered custom connectors in your Amazon Web Services account.
        /// This API lists only custom connectors registered in this account, not the Amazon Web
        /// Services authored connectors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnectors service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        public virtual Task<ListConnectorsResponse> ListConnectorsAsync(ListConnectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListConnectorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFlows


        /// <summary>
        /// Lists all of the flows associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlows service method.</param>
        /// 
        /// <returns>The response from the ListFlows service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/ListFlows">REST API Reference for ListFlows Operation</seealso>
        public virtual ListFlowsResponse ListFlows(ListFlowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowsResponseUnmarshaller.Instance;

            return Invoke<ListFlowsResponse>(request, options);
        }


        /// <summary>
        /// Lists all of the flows associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFlows service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/ListFlows">REST API Reference for ListFlows Operation</seealso>
        public virtual Task<ListFlowsResponse> ListFlowsAsync(ListFlowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFlowsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves the tags that are associated with a specified flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the tags that are associated with a specified flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterConnector


        /// <summary>
        /// Registers a new custom connector with your Amazon Web Services account. Before you
        /// can register the connector, you must deploy the associated AWS lambda function in
        /// your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterConnector service method.</param>
        /// 
        /// <returns>The response from the RegisterConnector service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.AccessDeniedException">
        /// AppFlow/Requester has invalid or missing permissions.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorAuthenticationException">
        /// An error occurred when authenticating with the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorServerException">
        /// An error occurred when retrieving data from the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota (such as the number of flows) to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ThrottlingException">
        /// API calls have exceeded the maximum allowed API request rate per account and per Region.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/RegisterConnector">REST API Reference for RegisterConnector Operation</seealso>
        public virtual RegisterConnectorResponse RegisterConnector(RegisterConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterConnectorResponseUnmarshaller.Instance;

            return Invoke<RegisterConnectorResponse>(request, options);
        }


        /// <summary>
        /// Registers a new custom connector with your Amazon Web Services account. Before you
        /// can register the connector, you must deploy the associated AWS lambda function in
        /// your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterConnector service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.AccessDeniedException">
        /// AppFlow/Requester has invalid or missing permissions.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorAuthenticationException">
        /// An error occurred when authenticating with the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorServerException">
        /// An error occurred when retrieving data from the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota (such as the number of flows) to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ThrottlingException">
        /// API calls have exceeded the maximum allowed API request rate per account and per Region.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/RegisterConnector">REST API Reference for RegisterConnector Operation</seealso>
        public virtual Task<RegisterConnectorResponse> RegisterConnectorAsync(RegisterConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterConnectorResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterConnectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetConnectorMetadataCache


        /// <summary>
        /// Resets metadata about your connector entities that Amazon AppFlow stored in its cache.
        /// Use this action when you want Amazon AppFlow to return the latest information about
        /// the data that you have in a source application.
        /// 
        ///  
        /// <para>
        /// Amazon AppFlow returns metadata about your entities when you use the ListConnectorEntities
        /// or DescribeConnectorEntities actions. Following these actions, Amazon AppFlow caches
        /// the metadata to reduce the number of API requests that it must send to the source
        /// application. Amazon AppFlow automatically resets the cache once every hour, but you
        /// can use this action when you want to get the latest metadata right away.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetConnectorMetadataCache service method.</param>
        /// 
        /// <returns>The response from the ResetConnectorMetadataCache service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/ResetConnectorMetadataCache">REST API Reference for ResetConnectorMetadataCache Operation</seealso>
        public virtual ResetConnectorMetadataCacheResponse ResetConnectorMetadataCache(ResetConnectorMetadataCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetConnectorMetadataCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetConnectorMetadataCacheResponseUnmarshaller.Instance;

            return Invoke<ResetConnectorMetadataCacheResponse>(request, options);
        }


        /// <summary>
        /// Resets metadata about your connector entities that Amazon AppFlow stored in its cache.
        /// Use this action when you want Amazon AppFlow to return the latest information about
        /// the data that you have in a source application.
        /// 
        ///  
        /// <para>
        /// Amazon AppFlow returns metadata about your entities when you use the ListConnectorEntities
        /// or DescribeConnectorEntities actions. Following these actions, Amazon AppFlow caches
        /// the metadata to reduce the number of API requests that it must send to the source
        /// application. Amazon AppFlow automatically resets the cache once every hour, but you
        /// can use this action when you want to get the latest metadata right away.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetConnectorMetadataCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetConnectorMetadataCache service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/ResetConnectorMetadataCache">REST API Reference for ResetConnectorMetadataCache Operation</seealso>
        public virtual Task<ResetConnectorMetadataCacheResponse> ResetConnectorMetadataCacheAsync(ResetConnectorMetadataCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetConnectorMetadataCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetConnectorMetadataCacheResponseUnmarshaller.Instance;
            
            return InvokeAsync<ResetConnectorMetadataCacheResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartFlow


        /// <summary>
        /// Activates an existing flow. For on-demand flows, this operation runs the flow immediately.
        /// For schedule and event-triggered flows, this operation activates the flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFlow service method.</param>
        /// 
        /// <returns>The response from the StartFlow service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota (such as the number of flows) to be exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/StartFlow">REST API Reference for StartFlow Operation</seealso>
        public virtual StartFlowResponse StartFlow(StartFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFlowResponseUnmarshaller.Instance;

            return Invoke<StartFlowResponse>(request, options);
        }


        /// <summary>
        /// Activates an existing flow. For on-demand flows, this operation runs the flow immediately.
        /// For schedule and event-triggered flows, this operation activates the flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartFlow service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota (such as the number of flows) to be exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/StartFlow">REST API Reference for StartFlow Operation</seealso>
        public virtual Task<StartFlowResponse> StartFlowAsync(StartFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFlowResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopFlow


        /// <summary>
        /// Deactivates the existing flow. For on-demand flows, this operation returns an <c>unsupportedOperationException</c>
        /// error message. For schedule and event-triggered flows, this operation deactivates
        /// the flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopFlow service method.</param>
        /// 
        /// <returns>The response from the StopFlow service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.UnsupportedOperationException">
        /// The requested operation is not supported for the current flow.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/StopFlow">REST API Reference for StopFlow Operation</seealso>
        public virtual StopFlowResponse StopFlow(StopFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFlowResponseUnmarshaller.Instance;

            return Invoke<StopFlowResponse>(request, options);
        }


        /// <summary>
        /// Deactivates the existing flow. For on-demand flows, this operation returns an <c>unsupportedOperationException</c>
        /// error message. For schedule and event-triggered flows, this operation deactivates
        /// the flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopFlow service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.UnsupportedOperationException">
        /// The requested operation is not supported for the current flow.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/StopFlow">REST API Reference for StopFlow Operation</seealso>
        public virtual Task<StopFlowResponse> StopFlowAsync(StopFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFlowResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Applies a tag to the specified flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Applies a tag to the specified flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UnregisterConnector


        /// <summary>
        /// Unregisters the custom connector registered in your account that matches the connector
        /// label provided in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnregisterConnector service method.</param>
        /// 
        /// <returns>The response from the UnregisterConnector service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/UnregisterConnector">REST API Reference for UnregisterConnector Operation</seealso>
        public virtual UnregisterConnectorResponse UnregisterConnector(UnregisterConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UnregisterConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnregisterConnectorResponseUnmarshaller.Instance;

            return Invoke<UnregisterConnectorResponse>(request, options);
        }


        /// <summary>
        /// Unregisters the custom connector registered in your account that matches the connector
        /// label provided in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnregisterConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UnregisterConnector service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/UnregisterConnector">REST API Reference for UnregisterConnector Operation</seealso>
        public virtual Task<UnregisterConnectorResponse> UnregisterConnectorAsync(UnregisterConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UnregisterConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnregisterConnectorResponseUnmarshaller.Instance;
            
            return InvokeAsync<UnregisterConnectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag from the specified flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes a tag from the specified flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConnectorProfile


        /// <summary>
        /// Updates a given connector profile associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectorProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateConnectorProfile service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorAuthenticationException">
        /// An error occurred when authenticating with the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/UpdateConnectorProfile">REST API Reference for UpdateConnectorProfile Operation</seealso>
        public virtual UpdateConnectorProfileResponse UpdateConnectorProfile(UpdateConnectorProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectorProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectorProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectorProfileResponse>(request, options);
        }


        /// <summary>
        /// Updates a given connector profile associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectorProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConnectorProfile service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorAuthenticationException">
        /// An error occurred when authenticating with the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/UpdateConnectorProfile">REST API Reference for UpdateConnectorProfile Operation</seealso>
        public virtual Task<UpdateConnectorProfileResponse> UpdateConnectorProfileAsync(UpdateConnectorProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectorProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectorProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateConnectorProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConnectorRegistration


        /// <summary>
        /// Updates a custom connector that you've previously registered. This operation updates
        /// the connector with one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The latest version of the AWS Lambda function that's assigned to the connector
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A new AWS Lambda function that you specify
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectorRegistration service method.</param>
        /// 
        /// <returns>The response from the UpdateConnectorRegistration service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.AccessDeniedException">
        /// AppFlow/Requester has invalid or missing permissions.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorAuthenticationException">
        /// An error occurred when authenticating with the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorServerException">
        /// An error occurred when retrieving data from the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota (such as the number of flows) to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ThrottlingException">
        /// API calls have exceeded the maximum allowed API request rate per account and per Region.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/UpdateConnectorRegistration">REST API Reference for UpdateConnectorRegistration Operation</seealso>
        public virtual UpdateConnectorRegistrationResponse UpdateConnectorRegistration(UpdateConnectorRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectorRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectorRegistrationResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectorRegistrationResponse>(request, options);
        }


        /// <summary>
        /// Updates a custom connector that you've previously registered. This operation updates
        /// the connector with one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The latest version of the AWS Lambda function that's assigned to the connector
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A new AWS Lambda function that you specify
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectorRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConnectorRegistration service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.AccessDeniedException">
        /// AppFlow/Requester has invalid or missing permissions.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorAuthenticationException">
        /// An error occurred when authenticating with the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorServerException">
        /// An error occurred when retrieving data from the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota (such as the number of flows) to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ThrottlingException">
        /// API calls have exceeded the maximum allowed API request rate per account and per Region.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/UpdateConnectorRegistration">REST API Reference for UpdateConnectorRegistration Operation</seealso>
        public virtual Task<UpdateConnectorRegistrationResponse> UpdateConnectorRegistrationAsync(UpdateConnectorRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectorRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectorRegistrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateConnectorRegistrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFlow


        /// <summary>
        /// Updates an existing flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlow service method.</param>
        /// 
        /// <returns>The response from the UpdateFlow service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.AccessDeniedException">
        /// AppFlow/Requester has invalid or missing permissions.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorAuthenticationException">
        /// An error occurred when authenticating with the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorServerException">
        /// An error occurred when retrieving data from the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota (such as the number of flows) to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/UpdateFlow">REST API Reference for UpdateFlow Operation</seealso>
        public virtual UpdateFlowResponse UpdateFlow(UpdateFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowResponseUnmarshaller.Instance;

            return Invoke<UpdateFlowResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFlow service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.AccessDeniedException">
        /// AppFlow/Requester has invalid or missing permissions.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorAuthenticationException">
        /// An error occurred when authenticating with the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorServerException">
        /// An error occurred when retrieving data from the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota (such as the number of flows) to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/UpdateFlow">REST API Reference for UpdateFlow Operation</seealso>
        public virtual Task<UpdateFlowResponse> UpdateFlowAsync(UpdateFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateFlowResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}