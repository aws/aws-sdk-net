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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.VPCLattice.Model;
using Amazon.VPCLattice.Model.Internal.MarshallTransformations;
using Amazon.VPCLattice.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.VPCLattice
{
    /// <summary>
    /// Implementation for accessing VPCLattice
    ///
    /// Amazon VPC Lattice is a fully managed application networking service that you use
    /// to connect, secure, and monitor all of your services across multiple accounts and
    /// virtual private clouds (VPCs). Amazon VPC Lattice interconnects your microservices
    /// and legacy services within a logical boundary, so that you can discover and manage
    /// them more efficiently. For more information, see the <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/">Amazon
    /// VPC Lattice User Guide</a>
    /// </summary>
    public partial class AmazonVPCLatticeClient : AmazonServiceClient, IAmazonVPCLattice
    {
        private static IServiceMetadata serviceMetadata = new AmazonVPCLatticeMetadata();
        private IVPCLatticePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IVPCLatticePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new VPCLatticePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonVPCLatticeClient with the credentials loaded from the application's
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
        public AmazonVPCLatticeClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonVPCLatticeConfig()) { }

        /// <summary>
        /// Constructs AmazonVPCLatticeClient with the credentials loaded from the application's
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
        public AmazonVPCLatticeClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonVPCLatticeConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonVPCLatticeClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonVPCLatticeClient Configuration Object</param>
        public AmazonVPCLatticeClient(AmazonVPCLatticeConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonVPCLatticeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonVPCLatticeClient(AWSCredentials credentials)
            : this(credentials, new AmazonVPCLatticeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonVPCLatticeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonVPCLatticeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonVPCLatticeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonVPCLatticeClient with AWS Credentials and an
        /// AmazonVPCLatticeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonVPCLatticeClient Configuration Object</param>
        public AmazonVPCLatticeClient(AWSCredentials credentials, AmazonVPCLatticeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonVPCLatticeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonVPCLatticeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonVPCLatticeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonVPCLatticeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonVPCLatticeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonVPCLatticeConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonVPCLatticeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonVPCLatticeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonVPCLatticeClient Configuration Object</param>
        public AmazonVPCLatticeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonVPCLatticeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonVPCLatticeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonVPCLatticeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonVPCLatticeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonVPCLatticeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonVPCLatticeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonVPCLatticeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonVPCLatticeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonVPCLatticeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonVPCLatticeClient Configuration Object</param>
        public AmazonVPCLatticeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonVPCLatticeConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonVPCLatticeEndpointResolver());
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


        #region  BatchUpdateRule


        /// <summary>
        /// Updates the listener rules in a batch. You can use this operation to change the priority
        /// of listener rules. This can be useful when bulk updating or swapping rule priority.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateRule service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateRule service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/BatchUpdateRule">REST API Reference for BatchUpdateRule Operation</seealso>
        public virtual BatchUpdateRuleResponse BatchUpdateRule(BatchUpdateRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateRuleResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateRuleResponse>(request, options);
        }


        /// <summary>
        /// Updates the listener rules in a batch. You can use this operation to change the priority
        /// of listener rules. This can be useful when bulk updating or swapping rule priority.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateRule service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/BatchUpdateRule">REST API Reference for BatchUpdateRule Operation</seealso>
        public virtual Task<BatchUpdateRuleResponse> BatchUpdateRuleAsync(BatchUpdateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchUpdateRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAccessLogSubscription


        /// <summary>
        /// Enables access logs to be sent to Amazon CloudWatch, Amazon S3, and Amazon Kinesis
        /// Data Firehose. The service network owner can use the access logs to audit the services
        /// in the network. The service network owner will only see access logs from clients and
        /// services that are associated with their service network. Access log entries represent
        /// traffic originated from VPCs associated with that network. For more information, see
        /// <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/monitoring-access-logs.html">Access
        /// logs</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessLogSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateAccessLogSubscription service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateAccessLogSubscription">REST API Reference for CreateAccessLogSubscription Operation</seealso>
        public virtual CreateAccessLogSubscriptionResponse CreateAccessLogSubscription(CreateAccessLogSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessLogSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessLogSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateAccessLogSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Enables access logs to be sent to Amazon CloudWatch, Amazon S3, and Amazon Kinesis
        /// Data Firehose. The service network owner can use the access logs to audit the services
        /// in the network. The service network owner will only see access logs from clients and
        /// services that are associated with their service network. Access log entries represent
        /// traffic originated from VPCs associated with that network. For more information, see
        /// <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/monitoring-access-logs.html">Access
        /// logs</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessLogSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessLogSubscription service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateAccessLogSubscription">REST API Reference for CreateAccessLogSubscription Operation</seealso>
        public virtual Task<CreateAccessLogSubscriptionResponse> CreateAccessLogSubscriptionAsync(CreateAccessLogSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessLogSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessLogSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAccessLogSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateListener


        /// <summary>
        /// Creates a listener for a service. Before you start using your Amazon VPC Lattice service,
        /// you must add one or more listeners. A listener is a process that checks for connection
        /// requests to your services. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/listeners.html">Listeners</a>
        /// in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateListener service method.</param>
        /// 
        /// <returns>The response from the CreateListener service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateListener">REST API Reference for CreateListener Operation</seealso>
        public virtual CreateListenerResponse CreateListener(CreateListenerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateListenerResponseUnmarshaller.Instance;

            return Invoke<CreateListenerResponse>(request, options);
        }


        /// <summary>
        /// Creates a listener for a service. Before you start using your Amazon VPC Lattice service,
        /// you must add one or more listeners. A listener is a process that checks for connection
        /// requests to your services. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/listeners.html">Listeners</a>
        /// in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateListener service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateListener">REST API Reference for CreateListener Operation</seealso>
        public virtual Task<CreateListenerResponse> CreateListenerAsync(CreateListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateListenerResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateListenerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRule


        /// <summary>
        /// Creates a listener rule. Each listener has a default rule for checking connection
        /// requests, but you can define additional rules. Each rule consists of a priority, one
        /// or more actions, and one or more conditions. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/listeners.html#listener-rules">Listener
        /// rules</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return Invoke<CreateRuleResponse>(request, options);
        }


        /// <summary>
        /// Creates a listener rule. Each listener has a default rule for checking connection
        /// requests, but you can define additional rules. Each rule consists of a priority, one
        /// or more actions, and one or more conditions. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/listeners.html#listener-rules">Listener
        /// rules</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateService


        /// <summary>
        /// Creates a service. A service is any software application that can run on instances
        /// containers, or serverless functions within an account or virtual private cloud (VPC).
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/services.html">Services</a>
        /// in the <i>Amazon VPC Lattice User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateService service method.</param>
        /// 
        /// <returns>The response from the CreateService service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateService">REST API Reference for CreateService Operation</seealso>
        public virtual CreateServiceResponse CreateService(CreateServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceResponseUnmarshaller.Instance;

            return Invoke<CreateServiceResponse>(request, options);
        }


        /// <summary>
        /// Creates a service. A service is any software application that can run on instances
        /// containers, or serverless functions within an account or virtual private cloud (VPC).
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/services.html">Services</a>
        /// in the <i>Amazon VPC Lattice User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateService service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateService">REST API Reference for CreateService Operation</seealso>
        public virtual Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateServiceNetwork


        /// <summary>
        /// Creates a service network. A service network is a logical boundary for a collection
        /// of services. You can associate services and VPCs with a service network.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/service-networks.html">Service
        /// networks</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceNetwork service method.</param>
        /// 
        /// <returns>The response from the CreateServiceNetwork service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateServiceNetwork">REST API Reference for CreateServiceNetwork Operation</seealso>
        public virtual CreateServiceNetworkResponse CreateServiceNetwork(CreateServiceNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceNetworkResponseUnmarshaller.Instance;

            return Invoke<CreateServiceNetworkResponse>(request, options);
        }


        /// <summary>
        /// Creates a service network. A service network is a logical boundary for a collection
        /// of services. You can associate services and VPCs with a service network.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/service-networks.html">Service
        /// networks</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateServiceNetwork service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateServiceNetwork">REST API Reference for CreateServiceNetwork Operation</seealso>
        public virtual Task<CreateServiceNetworkResponse> CreateServiceNetworkAsync(CreateServiceNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceNetworkResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateServiceNetworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateServiceNetworkServiceAssociation


        /// <summary>
        /// Associates a service with a service network.
        /// 
        ///  
        /// <para>
        /// You can't use this operation if the service and service network are already associated
        /// or if there is a disassociation or deletion in progress. If the association fails,
        /// you can retry the operation by deleting the association and recreating it.
        /// </para>
        ///  
        /// <para>
        /// You cannot associate a service and service network that are shared with a caller.
        /// The caller must own either the service or the service network.
        /// </para>
        ///  
        /// <para>
        /// As a result of this operation, the association is created in the service network account
        /// and the association owner account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceNetworkServiceAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateServiceNetworkServiceAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateServiceNetworkServiceAssociation">REST API Reference for CreateServiceNetworkServiceAssociation Operation</seealso>
        public virtual CreateServiceNetworkServiceAssociationResponse CreateServiceNetworkServiceAssociation(CreateServiceNetworkServiceAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceNetworkServiceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceNetworkServiceAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateServiceNetworkServiceAssociationResponse>(request, options);
        }


        /// <summary>
        /// Associates a service with a service network.
        /// 
        ///  
        /// <para>
        /// You can't use this operation if the service and service network are already associated
        /// or if there is a disassociation or deletion in progress. If the association fails,
        /// you can retry the operation by deleting the association and recreating it.
        /// </para>
        ///  
        /// <para>
        /// You cannot associate a service and service network that are shared with a caller.
        /// The caller must own either the service or the service network.
        /// </para>
        ///  
        /// <para>
        /// As a result of this operation, the association is created in the service network account
        /// and the association owner account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceNetworkServiceAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateServiceNetworkServiceAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateServiceNetworkServiceAssociation">REST API Reference for CreateServiceNetworkServiceAssociation Operation</seealso>
        public virtual Task<CreateServiceNetworkServiceAssociationResponse> CreateServiceNetworkServiceAssociationAsync(CreateServiceNetworkServiceAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceNetworkServiceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceNetworkServiceAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateServiceNetworkServiceAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateServiceNetworkVpcAssociation


        /// <summary>
        /// Associates a VPC with a service network. When you associate a VPC with the service
        /// network, it enables all the resources within that VPC to be clients and communicate
        /// with other services in the service network. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/service-network-associations.html#service-network-vpc-associations">Manage
        /// VPC associations</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can't use this operation if there is a disassociation in progress. If the association
        /// fails, retry by deleting the association and recreating it.
        /// </para>
        ///  
        /// <para>
        /// As a result of this operation, the association gets created in the service network
        /// account and the VPC owner account.
        /// </para>
        ///  
        /// <para>
        /// If you add a security group to the service network and VPC association, the association
        /// must continue to always have at least one security group. You can add or edit security
        /// groups at any time. However, to remove all security groups, you must first delete
        /// the association and recreate it without security groups.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceNetworkVpcAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateServiceNetworkVpcAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateServiceNetworkVpcAssociation">REST API Reference for CreateServiceNetworkVpcAssociation Operation</seealso>
        public virtual CreateServiceNetworkVpcAssociationResponse CreateServiceNetworkVpcAssociation(CreateServiceNetworkVpcAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceNetworkVpcAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceNetworkVpcAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateServiceNetworkVpcAssociationResponse>(request, options);
        }


        /// <summary>
        /// Associates a VPC with a service network. When you associate a VPC with the service
        /// network, it enables all the resources within that VPC to be clients and communicate
        /// with other services in the service network. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/service-network-associations.html#service-network-vpc-associations">Manage
        /// VPC associations</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can't use this operation if there is a disassociation in progress. If the association
        /// fails, retry by deleting the association and recreating it.
        /// </para>
        ///  
        /// <para>
        /// As a result of this operation, the association gets created in the service network
        /// account and the VPC owner account.
        /// </para>
        ///  
        /// <para>
        /// If you add a security group to the service network and VPC association, the association
        /// must continue to always have at least one security group. You can add or edit security
        /// groups at any time. However, to remove all security groups, you must first delete
        /// the association and recreate it without security groups.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceNetworkVpcAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateServiceNetworkVpcAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateServiceNetworkVpcAssociation">REST API Reference for CreateServiceNetworkVpcAssociation Operation</seealso>
        public virtual Task<CreateServiceNetworkVpcAssociationResponse> CreateServiceNetworkVpcAssociationAsync(CreateServiceNetworkVpcAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceNetworkVpcAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceNetworkVpcAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateServiceNetworkVpcAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTargetGroup


        /// <summary>
        /// Creates a target group. A target group is a collection of targets, or compute resources,
        /// that run your application or service. A target group can only be used by a single
        /// service.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/target-groups.html">Target
        /// groups</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTargetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateTargetGroup service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateTargetGroup">REST API Reference for CreateTargetGroup Operation</seealso>
        public virtual CreateTargetGroupResponse CreateTargetGroup(CreateTargetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTargetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTargetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateTargetGroupResponse>(request, options);
        }


        /// <summary>
        /// Creates a target group. A target group is a collection of targets, or compute resources,
        /// that run your application or service. A target group can only be used by a single
        /// service.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/target-groups.html">Target
        /// groups</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTargetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTargetGroup service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateTargetGroup">REST API Reference for CreateTargetGroup Operation</seealso>
        public virtual Task<CreateTargetGroupResponse> CreateTargetGroupAsync(CreateTargetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTargetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTargetGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateTargetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccessLogSubscription


        /// <summary>
        /// Deletes the specified access log subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessLogSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessLogSubscription service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteAccessLogSubscription">REST API Reference for DeleteAccessLogSubscription Operation</seealso>
        public virtual DeleteAccessLogSubscriptionResponse DeleteAccessLogSubscription(DeleteAccessLogSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessLogSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessLogSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessLogSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified access log subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessLogSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessLogSubscription service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteAccessLogSubscription">REST API Reference for DeleteAccessLogSubscription Operation</seealso>
        public virtual Task<DeleteAccessLogSubscriptionResponse> DeleteAccessLogSubscriptionAsync(DeleteAccessLogSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessLogSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessLogSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAccessLogSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAuthPolicy


        /// <summary>
        /// Deletes the specified auth policy. If an auth is set to <code>AWS_IAM</code> and the
        /// auth policy is deleted, all requests will be denied by default. If you are trying
        /// to remove the auth policy completely, you must set the auth_type to <code>NONE</code>.
        /// If auth is enabled on the resource, but no auth policy is set, all requests will be
        /// denied.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteAuthPolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteAuthPolicy">REST API Reference for DeleteAuthPolicy Operation</seealso>
        public virtual DeleteAuthPolicyResponse DeleteAuthPolicy(DeleteAuthPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAuthPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuthPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteAuthPolicyResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified auth policy. If an auth is set to <code>AWS_IAM</code> and the
        /// auth policy is deleted, all requests will be denied by default. If you are trying
        /// to remove the auth policy completely, you must set the auth_type to <code>NONE</code>.
        /// If auth is enabled on the resource, but no auth policy is set, all requests will be
        /// denied.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAuthPolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteAuthPolicy">REST API Reference for DeleteAuthPolicy Operation</seealso>
        public virtual Task<DeleteAuthPolicyResponse> DeleteAuthPolicyAsync(DeleteAuthPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAuthPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuthPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAuthPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteListener


        /// <summary>
        /// Deletes the specified listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteListener service method.</param>
        /// 
        /// <returns>The response from the DeleteListener service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteListener">REST API Reference for DeleteListener Operation</seealso>
        public virtual DeleteListenerResponse DeleteListener(DeleteListenerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteListenerResponseUnmarshaller.Instance;

            return Invoke<DeleteListenerResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteListener service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteListener">REST API Reference for DeleteListener Operation</seealso>
        public virtual Task<DeleteListenerResponse> DeleteListenerAsync(DeleteListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteListenerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteListenerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Deletes the specified resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRule


        /// <summary>
        /// Deletes a listener rule. Each listener has a default rule for checking connection
        /// requests, but you can define additional rules. Each rule consists of a priority, one
        /// or more actions, and one or more conditions. You can delete additional listener rules,
        /// but you cannot delete the default rule.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/listeners.html#listener-rules">Listener
        /// rules</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleResponse>(request, options);
        }


        /// <summary>
        /// Deletes a listener rule. Each listener has a default rule for checking connection
        /// requests, but you can define additional rules. Each rule consists of a priority, one
        /// or more actions, and one or more conditions. You can delete additional listener rules,
        /// but you cannot delete the default rule.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/listeners.html#listener-rules">Listener
        /// rules</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteService


        /// <summary>
        /// Deletes a service. A service can't be deleted if it's associated with a service network.
        /// If you delete a service, all resources related to the service, such as the resource
        /// policy, auth policy, listeners, listener rules, and access log subscriptions, are
        /// also deleted. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/services.html#delete-service">Delete
        /// a service</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteService service method.</param>
        /// 
        /// <returns>The response from the DeleteService service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteService">REST API Reference for DeleteService Operation</seealso>
        public virtual DeleteServiceResponse DeleteService(DeleteServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceResponse>(request, options);
        }


        /// <summary>
        /// Deletes a service. A service can't be deleted if it's associated with a service network.
        /// If you delete a service, all resources related to the service, such as the resource
        /// policy, auth policy, listeners, listener rules, and access log subscriptions, are
        /// also deleted. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/services.html#delete-service">Delete
        /// a service</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteService service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteService">REST API Reference for DeleteService Operation</seealso>
        public virtual Task<DeleteServiceResponse> DeleteServiceAsync(DeleteServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteServiceNetwork


        /// <summary>
        /// Deletes a service network. You can only delete the service network if there is no
        /// service or VPC associated with it. If you delete a service network, all resources
        /// related to the service network, such as the resource policy, auth policy, and access
        /// log subscriptions, are also deleted. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/service-networks.html#delete-service-network">Delete
        /// a service network</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceNetwork service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceNetwork service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteServiceNetwork">REST API Reference for DeleteServiceNetwork Operation</seealso>
        public virtual DeleteServiceNetworkResponse DeleteServiceNetwork(DeleteServiceNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceNetworkResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceNetworkResponse>(request, options);
        }


        /// <summary>
        /// Deletes a service network. You can only delete the service network if there is no
        /// service or VPC associated with it. If you delete a service network, all resources
        /// related to the service network, such as the resource policy, auth policy, and access
        /// log subscriptions, are also deleted. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/service-networks.html#delete-service-network">Delete
        /// a service network</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServiceNetwork service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteServiceNetwork">REST API Reference for DeleteServiceNetwork Operation</seealso>
        public virtual Task<DeleteServiceNetworkResponse> DeleteServiceNetworkAsync(DeleteServiceNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceNetworkResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteServiceNetworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteServiceNetworkServiceAssociation


        /// <summary>
        /// Deletes the association between a specified service and the specific service network.
        /// This request will fail if an association is still in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceNetworkServiceAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceNetworkServiceAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteServiceNetworkServiceAssociation">REST API Reference for DeleteServiceNetworkServiceAssociation Operation</seealso>
        public virtual DeleteServiceNetworkServiceAssociationResponse DeleteServiceNetworkServiceAssociation(DeleteServiceNetworkServiceAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceNetworkServiceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceNetworkServiceAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceNetworkServiceAssociationResponse>(request, options);
        }


        /// <summary>
        /// Deletes the association between a specified service and the specific service network.
        /// This request will fail if an association is still in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceNetworkServiceAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServiceNetworkServiceAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteServiceNetworkServiceAssociation">REST API Reference for DeleteServiceNetworkServiceAssociation Operation</seealso>
        public virtual Task<DeleteServiceNetworkServiceAssociationResponse> DeleteServiceNetworkServiceAssociationAsync(DeleteServiceNetworkServiceAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceNetworkServiceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceNetworkServiceAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteServiceNetworkServiceAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteServiceNetworkVpcAssociation


        /// <summary>
        /// Disassociates the VPC from the service network. You can't disassociate the VPC if
        /// there is a create or update association in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceNetworkVpcAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceNetworkVpcAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteServiceNetworkVpcAssociation">REST API Reference for DeleteServiceNetworkVpcAssociation Operation</seealso>
        public virtual DeleteServiceNetworkVpcAssociationResponse DeleteServiceNetworkVpcAssociation(DeleteServiceNetworkVpcAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceNetworkVpcAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceNetworkVpcAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceNetworkVpcAssociationResponse>(request, options);
        }


        /// <summary>
        /// Disassociates the VPC from the service network. You can't disassociate the VPC if
        /// there is a create or update association in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceNetworkVpcAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServiceNetworkVpcAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteServiceNetworkVpcAssociation">REST API Reference for DeleteServiceNetworkVpcAssociation Operation</seealso>
        public virtual Task<DeleteServiceNetworkVpcAssociationResponse> DeleteServiceNetworkVpcAssociationAsync(DeleteServiceNetworkVpcAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceNetworkVpcAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceNetworkVpcAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteServiceNetworkVpcAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTargetGroup


        /// <summary>
        /// Deletes a target group. You can't delete a target group if it is used in a listener
        /// rule or if the target group creation is in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteTargetGroup service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteTargetGroup">REST API Reference for DeleteTargetGroup Operation</seealso>
        public virtual DeleteTargetGroupResponse DeleteTargetGroup(DeleteTargetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTargetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTargetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteTargetGroupResponse>(request, options);
        }


        /// <summary>
        /// Deletes a target group. You can't delete a target group if it is used in a listener
        /// rule or if the target group creation is in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTargetGroup service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteTargetGroup">REST API Reference for DeleteTargetGroup Operation</seealso>
        public virtual Task<DeleteTargetGroupResponse> DeleteTargetGroupAsync(DeleteTargetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTargetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTargetGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteTargetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterTargets


        /// <summary>
        /// Deregisters the specified targets from the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargets service method.</param>
        /// 
        /// <returns>The response from the DeregisterTargets service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeregisterTargets">REST API Reference for DeregisterTargets Operation</seealso>
        public virtual DeregisterTargetsResponse DeregisterTargets(DeregisterTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterTargetsResponseUnmarshaller.Instance;

            return Invoke<DeregisterTargetsResponse>(request, options);
        }


        /// <summary>
        /// Deregisters the specified targets from the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterTargets service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeregisterTargets">REST API Reference for DeregisterTargets Operation</seealso>
        public virtual Task<DeregisterTargetsResponse> DeregisterTargetsAsync(DeregisterTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterTargetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeregisterTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccessLogSubscription


        /// <summary>
        /// Retrieves information about the specified access log subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessLogSubscription service method.</param>
        /// 
        /// <returns>The response from the GetAccessLogSubscription service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetAccessLogSubscription">REST API Reference for GetAccessLogSubscription Operation</seealso>
        public virtual GetAccessLogSubscriptionResponse GetAccessLogSubscription(GetAccessLogSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessLogSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessLogSubscriptionResponseUnmarshaller.Instance;

            return Invoke<GetAccessLogSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the specified access log subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessLogSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessLogSubscription service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetAccessLogSubscription">REST API Reference for GetAccessLogSubscription Operation</seealso>
        public virtual Task<GetAccessLogSubscriptionResponse> GetAccessLogSubscriptionAsync(GetAccessLogSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessLogSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessLogSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAccessLogSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAuthPolicy


        /// <summary>
        /// Retrieves information about the auth policy for the specified service or service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthPolicy service method.</param>
        /// 
        /// <returns>The response from the GetAuthPolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetAuthPolicy">REST API Reference for GetAuthPolicy Operation</seealso>
        public virtual GetAuthPolicyResponse GetAuthPolicy(GetAuthPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAuthPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthPolicyResponseUnmarshaller.Instance;

            return Invoke<GetAuthPolicyResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the auth policy for the specified service or service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAuthPolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetAuthPolicy">REST API Reference for GetAuthPolicy Operation</seealso>
        public virtual Task<GetAuthPolicyResponse> GetAuthPolicyAsync(GetAuthPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAuthPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAuthPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetListener


        /// <summary>
        /// Retrieves information about the specified listener for the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetListener service method.</param>
        /// 
        /// <returns>The response from the GetListener service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetListener">REST API Reference for GetListener Operation</seealso>
        public virtual GetListenerResponse GetListener(GetListenerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetListenerResponseUnmarshaller.Instance;

            return Invoke<GetListenerResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the specified listener for the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetListener service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetListener">REST API Reference for GetListener Operation</seealso>
        public virtual Task<GetListenerResponse> GetListenerAsync(GetListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetListenerResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetListenerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Retrieves information about the resource policy. The resource policy is an IAM policy
        /// created on behalf of the resource owner when they share a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the resource policy. The resource policy is an IAM policy
        /// created on behalf of the resource owner when they share a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRule


        /// <summary>
        /// Retrieves information about listener rules. You can also retrieve information about
        /// the default listener rule. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/listeners.html#listener-rules">Listener
        /// rules</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRule service method.</param>
        /// 
        /// <returns>The response from the GetRule service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetRule">REST API Reference for GetRule Operation</seealso>
        public virtual GetRuleResponse GetRule(GetRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuleResponseUnmarshaller.Instance;

            return Invoke<GetRuleResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about listener rules. You can also retrieve information about
        /// the default listener rule. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/listeners.html#listener-rules">Listener
        /// rules</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRule service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetRule">REST API Reference for GetRule Operation</seealso>
        public virtual Task<GetRuleResponse> GetRuleAsync(GetRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetService


        /// <summary>
        /// Retrieves information about the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetService service method.</param>
        /// 
        /// <returns>The response from the GetService service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetService">REST API Reference for GetService Operation</seealso>
        public virtual GetServiceResponse GetService(GetServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceResponseUnmarshaller.Instance;

            return Invoke<GetServiceResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetService service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetService">REST API Reference for GetService Operation</seealso>
        public virtual Task<GetServiceResponse> GetServiceAsync(GetServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServiceNetwork


        /// <summary>
        /// Retrieves information about the specified service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetwork service method.</param>
        /// 
        /// <returns>The response from the GetServiceNetwork service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetServiceNetwork">REST API Reference for GetServiceNetwork Operation</seealso>
        public virtual GetServiceNetworkResponse GetServiceNetwork(GetServiceNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceNetworkResponseUnmarshaller.Instance;

            return Invoke<GetServiceNetworkResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the specified service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceNetwork service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetServiceNetwork">REST API Reference for GetServiceNetwork Operation</seealso>
        public virtual Task<GetServiceNetworkResponse> GetServiceNetworkAsync(GetServiceNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceNetworkResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetServiceNetworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServiceNetworkServiceAssociation


        /// <summary>
        /// Retrieves information about the specified association between a service network and
        /// a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetworkServiceAssociation service method.</param>
        /// 
        /// <returns>The response from the GetServiceNetworkServiceAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetServiceNetworkServiceAssociation">REST API Reference for GetServiceNetworkServiceAssociation Operation</seealso>
        public virtual GetServiceNetworkServiceAssociationResponse GetServiceNetworkServiceAssociation(GetServiceNetworkServiceAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceNetworkServiceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceNetworkServiceAssociationResponseUnmarshaller.Instance;

            return Invoke<GetServiceNetworkServiceAssociationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the specified association between a service network and
        /// a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetworkServiceAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceNetworkServiceAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetServiceNetworkServiceAssociation">REST API Reference for GetServiceNetworkServiceAssociation Operation</seealso>
        public virtual Task<GetServiceNetworkServiceAssociationResponse> GetServiceNetworkServiceAssociationAsync(GetServiceNetworkServiceAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceNetworkServiceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceNetworkServiceAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetServiceNetworkServiceAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServiceNetworkVpcAssociation


        /// <summary>
        /// Retrieves information about the association between a service network and a VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetworkVpcAssociation service method.</param>
        /// 
        /// <returns>The response from the GetServiceNetworkVpcAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetServiceNetworkVpcAssociation">REST API Reference for GetServiceNetworkVpcAssociation Operation</seealso>
        public virtual GetServiceNetworkVpcAssociationResponse GetServiceNetworkVpcAssociation(GetServiceNetworkVpcAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceNetworkVpcAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceNetworkVpcAssociationResponseUnmarshaller.Instance;

            return Invoke<GetServiceNetworkVpcAssociationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the association between a service network and a VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetworkVpcAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceNetworkVpcAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetServiceNetworkVpcAssociation">REST API Reference for GetServiceNetworkVpcAssociation Operation</seealso>
        public virtual Task<GetServiceNetworkVpcAssociationResponse> GetServiceNetworkVpcAssociationAsync(GetServiceNetworkVpcAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceNetworkVpcAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceNetworkVpcAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetServiceNetworkVpcAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTargetGroup


        /// <summary>
        /// Retrieves information about the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTargetGroup service method.</param>
        /// 
        /// <returns>The response from the GetTargetGroup service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetTargetGroup">REST API Reference for GetTargetGroup Operation</seealso>
        public virtual GetTargetGroupResponse GetTargetGroup(GetTargetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTargetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTargetGroupResponseUnmarshaller.Instance;

            return Invoke<GetTargetGroupResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTargetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTargetGroup service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetTargetGroup">REST API Reference for GetTargetGroup Operation</seealso>
        public virtual Task<GetTargetGroupResponse> GetTargetGroupAsync(GetTargetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTargetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTargetGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTargetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccessLogSubscriptions


        /// <summary>
        /// Lists all access log subscriptions for the specified service network or service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessLogSubscriptions service method.</param>
        /// 
        /// <returns>The response from the ListAccessLogSubscriptions service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListAccessLogSubscriptions">REST API Reference for ListAccessLogSubscriptions Operation</seealso>
        public virtual ListAccessLogSubscriptionsResponse ListAccessLogSubscriptions(ListAccessLogSubscriptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessLogSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessLogSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListAccessLogSubscriptionsResponse>(request, options);
        }


        /// <summary>
        /// Lists all access log subscriptions for the specified service network or service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessLogSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessLogSubscriptions service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListAccessLogSubscriptions">REST API Reference for ListAccessLogSubscriptions Operation</seealso>
        public virtual Task<ListAccessLogSubscriptionsResponse> ListAccessLogSubscriptionsAsync(ListAccessLogSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessLogSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessLogSubscriptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAccessLogSubscriptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListListeners


        /// <summary>
        /// Lists the listeners for the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListListeners service method.</param>
        /// 
        /// <returns>The response from the ListListeners service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListListeners">REST API Reference for ListListeners Operation</seealso>
        public virtual ListListenersResponse ListListeners(ListListenersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListListenersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListListenersResponseUnmarshaller.Instance;

            return Invoke<ListListenersResponse>(request, options);
        }


        /// <summary>
        /// Lists the listeners for the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListListeners service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListListeners service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListListeners">REST API Reference for ListListeners Operation</seealso>
        public virtual Task<ListListenersResponse> ListListenersAsync(ListListenersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListListenersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListListenersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListListenersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRules


        /// <summary>
        /// Lists the rules for the listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual ListRulesResponse ListRules(ListRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesResponseUnmarshaller.Instance;

            return Invoke<ListRulesResponse>(request, options);
        }


        /// <summary>
        /// Lists the rules for the listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceNetworks


        /// <summary>
        /// Lists the service networks owned by the caller account or shared with the caller account.
        /// Also includes the account ID in the ARN to show which account owns the service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworks service method.</param>
        /// 
        /// <returns>The response from the ListServiceNetworks service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServiceNetworks">REST API Reference for ListServiceNetworks Operation</seealso>
        public virtual ListServiceNetworksResponse ListServiceNetworks(ListServiceNetworksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceNetworksResponseUnmarshaller.Instance;

            return Invoke<ListServiceNetworksResponse>(request, options);
        }


        /// <summary>
        /// Lists the service networks owned by the caller account or shared with the caller account.
        /// Also includes the account ID in the ARN to show which account owns the service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceNetworks service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServiceNetworks">REST API Reference for ListServiceNetworks Operation</seealso>
        public virtual Task<ListServiceNetworksResponse> ListServiceNetworksAsync(ListServiceNetworksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceNetworksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListServiceNetworksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceNetworkServiceAssociations


        /// <summary>
        /// Lists the associations between the service network and the service. You can filter
        /// the list either by service or service network. You must provide either the service
        /// network identifier or the service identifier.
        /// 
        ///  
        /// <para>
        /// Every association in Amazon VPC Lattice is given a unique Amazon Resource Name (ARN),
        /// such as when a service network is associated with a VPC or when a service is associated
        /// with a service network. If the association is for a resource that is shared with another
        /// account, the association will include the local account ID as the prefix in the ARN
        /// for each account the resource is shared with.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworkServiceAssociations service method.</param>
        /// 
        /// <returns>The response from the ListServiceNetworkServiceAssociations service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServiceNetworkServiceAssociations">REST API Reference for ListServiceNetworkServiceAssociations Operation</seealso>
        public virtual ListServiceNetworkServiceAssociationsResponse ListServiceNetworkServiceAssociations(ListServiceNetworkServiceAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceNetworkServiceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceNetworkServiceAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListServiceNetworkServiceAssociationsResponse>(request, options);
        }


        /// <summary>
        /// Lists the associations between the service network and the service. You can filter
        /// the list either by service or service network. You must provide either the service
        /// network identifier or the service identifier.
        /// 
        ///  
        /// <para>
        /// Every association in Amazon VPC Lattice is given a unique Amazon Resource Name (ARN),
        /// such as when a service network is associated with a VPC or when a service is associated
        /// with a service network. If the association is for a resource that is shared with another
        /// account, the association will include the local account ID as the prefix in the ARN
        /// for each account the resource is shared with.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworkServiceAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceNetworkServiceAssociations service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServiceNetworkServiceAssociations">REST API Reference for ListServiceNetworkServiceAssociations Operation</seealso>
        public virtual Task<ListServiceNetworkServiceAssociationsResponse> ListServiceNetworkServiceAssociationsAsync(ListServiceNetworkServiceAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceNetworkServiceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceNetworkServiceAssociationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListServiceNetworkServiceAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceNetworkVpcAssociations


        /// <summary>
        /// Lists the service network and VPC associations. You can filter the list either by
        /// VPC or service network. You must provide either the service network identifier or
        /// the VPC identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworkVpcAssociations service method.</param>
        /// 
        /// <returns>The response from the ListServiceNetworkVpcAssociations service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServiceNetworkVpcAssociations">REST API Reference for ListServiceNetworkVpcAssociations Operation</seealso>
        public virtual ListServiceNetworkVpcAssociationsResponse ListServiceNetworkVpcAssociations(ListServiceNetworkVpcAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceNetworkVpcAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceNetworkVpcAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListServiceNetworkVpcAssociationsResponse>(request, options);
        }


        /// <summary>
        /// Lists the service network and VPC associations. You can filter the list either by
        /// VPC or service network. You must provide either the service network identifier or
        /// the VPC identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworkVpcAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceNetworkVpcAssociations service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServiceNetworkVpcAssociations">REST API Reference for ListServiceNetworkVpcAssociations Operation</seealso>
        public virtual Task<ListServiceNetworkVpcAssociationsResponse> ListServiceNetworkVpcAssociationsAsync(ListServiceNetworkVpcAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceNetworkVpcAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceNetworkVpcAssociationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListServiceNetworkVpcAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServices


        /// <summary>
        /// Lists the services owned by the caller account or shared with the caller account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual ListServicesResponse ListServices(ListServicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesResponseUnmarshaller.Instance;

            return Invoke<ListServicesResponse>(request, options);
        }


        /// <summary>
        /// Lists the services owned by the caller account or shared with the caller account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListServicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTargetGroups


        /// <summary>
        /// Lists your target groups. You can narrow your search by using the filters below in
        /// your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetGroups service method.</param>
        /// 
        /// <returns>The response from the ListTargetGroups service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListTargetGroups">REST API Reference for ListTargetGroups Operation</seealso>
        public virtual ListTargetGroupsResponse ListTargetGroups(ListTargetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetGroupsResponseUnmarshaller.Instance;

            return Invoke<ListTargetGroupsResponse>(request, options);
        }


        /// <summary>
        /// Lists your target groups. You can narrow your search by using the filters below in
        /// your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTargetGroups service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListTargetGroups">REST API Reference for ListTargetGroups Operation</seealso>
        public virtual Task<ListTargetGroupsResponse> ListTargetGroupsAsync(ListTargetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTargetGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTargets


        /// <summary>
        /// Lists the targets for the target group. By default, all targets are included. You
        /// can use this API to check the health status of targets. You can also ﬁlter the results
        /// by target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargets service method.</param>
        /// 
        /// <returns>The response from the ListTargets service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListTargets">REST API Reference for ListTargets Operation</seealso>
        public virtual ListTargetsResponse ListTargets(ListTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetsResponseUnmarshaller.Instance;

            return Invoke<ListTargetsResponse>(request, options);
        }


        /// <summary>
        /// Lists the targets for the target group. By default, all targets are included. You
        /// can use this API to check the health status of targets. You can also ﬁlter the results
        /// by target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTargets service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListTargets">REST API Reference for ListTargets Operation</seealso>
        public virtual Task<ListTargetsResponse> ListTargetsAsync(ListTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAuthPolicy


        /// <summary>
        /// Creates or updates the auth policy. The policy string in JSON must not contain newlines
        /// or blank lines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAuthPolicy service method.</param>
        /// 
        /// <returns>The response from the PutAuthPolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/PutAuthPolicy">REST API Reference for PutAuthPolicy Operation</seealso>
        public virtual PutAuthPolicyResponse PutAuthPolicy(PutAuthPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAuthPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAuthPolicyResponseUnmarshaller.Instance;

            return Invoke<PutAuthPolicyResponse>(request, options);
        }


        /// <summary>
        /// Creates or updates the auth policy. The policy string in JSON must not contain newlines
        /// or blank lines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAuthPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAuthPolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/PutAuthPolicy">REST API Reference for PutAuthPolicy Operation</seealso>
        public virtual Task<PutAuthPolicyResponse> PutAuthPolicyAsync(PutAuthPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAuthPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAuthPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutAuthPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Attaches a resource-based permission policy to a service or service network. The policy
        /// must contain the same actions and condition statements as the Amazon Web Services
        /// Resource Access Manager permission for sharing services and service networks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }


        /// <summary>
        /// Attaches a resource-based permission policy to a service or service network. The policy
        /// must contain the same actions and condition statements as the Amazon Web Services
        /// Resource Access Manager permission for sharing services and service networks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterTargets


        /// <summary>
        /// Registers the targets with the target group. If it's a Lambda target, you can only
        /// have one target in a target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargets service method.</param>
        /// 
        /// <returns>The response from the RegisterTargets service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/RegisterTargets">REST API Reference for RegisterTargets Operation</seealso>
        public virtual RegisterTargetsResponse RegisterTargets(RegisterTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterTargetsResponseUnmarshaller.Instance;

            return Invoke<RegisterTargetsResponse>(request, options);
        }


        /// <summary>
        /// Registers the targets with the target group. If it's a Lambda target, you can only
        /// have one target in a target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterTargets service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/RegisterTargets">REST API Reference for RegisterTargets Operation</seealso>
        public virtual Task<RegisterTargetsResponse> RegisterTargetsAsync(RegisterTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterTargetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAccessLogSubscription


        /// <summary>
        /// Updates the specified access log subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessLogSubscription service method.</param>
        /// 
        /// <returns>The response from the UpdateAccessLogSubscription service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateAccessLogSubscription">REST API Reference for UpdateAccessLogSubscription Operation</seealso>
        public virtual UpdateAccessLogSubscriptionResponse UpdateAccessLogSubscription(UpdateAccessLogSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccessLogSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessLogSubscriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateAccessLogSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified access log subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessLogSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccessLogSubscription service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateAccessLogSubscription">REST API Reference for UpdateAccessLogSubscription Operation</seealso>
        public virtual Task<UpdateAccessLogSubscriptionResponse> UpdateAccessLogSubscriptionAsync(UpdateAccessLogSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccessLogSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessLogSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAccessLogSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateListener


        /// <summary>
        /// Updates the specified listener for the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateListener service method.</param>
        /// 
        /// <returns>The response from the UpdateListener service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateListener">REST API Reference for UpdateListener Operation</seealso>
        public virtual UpdateListenerResponse UpdateListener(UpdateListenerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateListenerResponseUnmarshaller.Instance;

            return Invoke<UpdateListenerResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified listener for the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateListener service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateListener">REST API Reference for UpdateListener Operation</seealso>
        public virtual Task<UpdateListenerResponse> UpdateListenerAsync(UpdateListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateListenerResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateListenerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRule


        /// <summary>
        /// Updates a rule for the listener. You can't modify a default listener rule. To modify
        /// a default listener rule, use <code>UpdateListener</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule service method.</param>
        /// 
        /// <returns>The response from the UpdateRule service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        public virtual UpdateRuleResponse UpdateRule(UpdateRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateRuleResponse>(request, options);
        }


        /// <summary>
        /// Updates a rule for the listener. You can't modify a default listener rule. To modify
        /// a default listener rule, use <code>UpdateListener</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRule service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        public virtual Task<UpdateRuleResponse> UpdateRuleAsync(UpdateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateService


        /// <summary>
        /// Updates the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateService service method.</param>
        /// 
        /// <returns>The response from the UpdateService service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateService">REST API Reference for UpdateService Operation</seealso>
        public virtual UpdateServiceResponse UpdateService(UpdateServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateService service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateService">REST API Reference for UpdateService Operation</seealso>
        public virtual Task<UpdateServiceResponse> UpdateServiceAsync(UpdateServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateServiceNetwork


        /// <summary>
        /// Updates the specified service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceNetwork service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceNetwork service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateServiceNetwork">REST API Reference for UpdateServiceNetwork Operation</seealso>
        public virtual UpdateServiceNetworkResponse UpdateServiceNetwork(UpdateServiceNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceNetworkResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceNetworkResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServiceNetwork service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateServiceNetwork">REST API Reference for UpdateServiceNetwork Operation</seealso>
        public virtual Task<UpdateServiceNetworkResponse> UpdateServiceNetworkAsync(UpdateServiceNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceNetworkResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateServiceNetworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateServiceNetworkVpcAssociation


        /// <summary>
        /// Updates the service network and VPC association. If you add a security group to the
        /// service network and VPC association, the association must continue to always have
        /// at least one security group. You can add or edit security groups at any time. However,
        /// to remove all security groups, you must first delete the association and recreate
        /// it without security groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceNetworkVpcAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceNetworkVpcAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateServiceNetworkVpcAssociation">REST API Reference for UpdateServiceNetworkVpcAssociation Operation</seealso>
        public virtual UpdateServiceNetworkVpcAssociationResponse UpdateServiceNetworkVpcAssociation(UpdateServiceNetworkVpcAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceNetworkVpcAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceNetworkVpcAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceNetworkVpcAssociationResponse>(request, options);
        }


        /// <summary>
        /// Updates the service network and VPC association. If you add a security group to the
        /// service network and VPC association, the association must continue to always have
        /// at least one security group. You can add or edit security groups at any time. However,
        /// to remove all security groups, you must first delete the association and recreate
        /// it without security groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceNetworkVpcAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServiceNetworkVpcAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateServiceNetworkVpcAssociation">REST API Reference for UpdateServiceNetworkVpcAssociation Operation</seealso>
        public virtual Task<UpdateServiceNetworkVpcAssociationResponse> UpdateServiceNetworkVpcAssociationAsync(UpdateServiceNetworkVpcAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceNetworkVpcAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceNetworkVpcAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateServiceNetworkVpcAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTargetGroup


        /// <summary>
        /// Updates the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTargetGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateTargetGroup service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateTargetGroup">REST API Reference for UpdateTargetGroup Operation</seealso>
        public virtual UpdateTargetGroupResponse UpdateTargetGroup(UpdateTargetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTargetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTargetGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateTargetGroupResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTargetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTargetGroup service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateTargetGroup">REST API Reference for UpdateTargetGroup Operation</seealso>
        public virtual Task<UpdateTargetGroupResponse> UpdateTargetGroupAsync(UpdateTargetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTargetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTargetGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateTargetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}