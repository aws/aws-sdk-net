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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Route53.Model;
using Amazon.Route53.Model.Internal.MarshallTransformations;
using Amazon.Route53.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Route53
{
    /// <summary>
    /// Implementation for accessing Route53
    ///
    /// 
    /// </summary>
    public partial class AmazonRoute53Client : AmazonServiceClient, IAmazonRoute53
    {
        private static IServiceMetadata serviceMetadata = new AmazonRoute53Metadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonRoute53Client with the credentials loaded from the application's
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
        public AmazonRoute53Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53Config()) { }

        /// <summary>
        /// Constructs AmazonRoute53Client with the credentials loaded from the application's
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
        public AmazonRoute53Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRoute53Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRoute53Client Configuration Object</param>
        public AmazonRoute53Client(AmazonRoute53Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRoute53Client(AWSCredentials credentials)
            : this(credentials, new AmazonRoute53Config())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRoute53Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Credentials and an
        /// AmazonRoute53Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRoute53Client Configuration Object</param>
        public AmazonRoute53Client(AWSCredentials credentials, AmazonRoute53Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53Config())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRoute53Client Configuration Object</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonRoute53Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53Config())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRoute53Client Configuration Object</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRoute53Config clientConfig)
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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.Route53.Internal.AmazonRoute53PostMarshallHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.ErrorCallbackHandler>(new Amazon.Route53.Internal.AmazonRoute53PreMarshallHandler());
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


        #region  AssociateVPCWithHostedZone

        internal virtual AssociateVPCWithHostedZoneResponse AssociateVPCWithHostedZone(AssociateVPCWithHostedZoneRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateVPCWithHostedZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateVPCWithHostedZoneResponseUnmarshaller.Instance;

            return Invoke<AssociateVPCWithHostedZoneResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateVPCWithHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateVPCWithHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/AssociateVPCWithHostedZone">REST API Reference for AssociateVPCWithHostedZone Operation</seealso>
        public virtual Task<AssociateVPCWithHostedZoneResponse> AssociateVPCWithHostedZoneAsync(AssociateVPCWithHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateVPCWithHostedZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateVPCWithHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateVPCWithHostedZoneResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ChangeResourceRecordSets

        internal virtual ChangeResourceRecordSetsResponse ChangeResourceRecordSets(ChangeResourceRecordSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChangeResourceRecordSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChangeResourceRecordSetsResponseUnmarshaller.Instance;

            return Invoke<ChangeResourceRecordSetsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ChangeResourceRecordSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeResourceRecordSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ChangeResourceRecordSets">REST API Reference for ChangeResourceRecordSets Operation</seealso>
        public virtual Task<ChangeResourceRecordSetsResponse> ChangeResourceRecordSetsAsync(ChangeResourceRecordSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChangeResourceRecordSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChangeResourceRecordSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ChangeResourceRecordSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ChangeTagsForResource

        internal virtual ChangeTagsForResourceResponse ChangeTagsForResource(ChangeTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChangeTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChangeTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ChangeTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ChangeTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ChangeTagsForResource">REST API Reference for ChangeTagsForResource Operation</seealso>
        public virtual Task<ChangeTagsForResourceResponse> ChangeTagsForResourceAsync(ChangeTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChangeTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChangeTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ChangeTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateHealthCheck

        internal virtual CreateHealthCheckResponse CreateHealthCheck(CreateHealthCheckRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHealthCheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHealthCheckResponseUnmarshaller.Instance;

            return Invoke<CreateHealthCheckResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateHealthCheck">REST API Reference for CreateHealthCheck Operation</seealso>
        public virtual Task<CreateHealthCheckResponse> CreateHealthCheckAsync(CreateHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHealthCheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHealthCheckResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHealthCheckResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateHostedZone

        internal virtual CreateHostedZoneResponse CreateHostedZone(CreateHostedZoneRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHostedZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHostedZoneResponseUnmarshaller.Instance;

            return Invoke<CreateHostedZoneResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateHostedZone">REST API Reference for CreateHostedZone Operation</seealso>
        public virtual Task<CreateHostedZoneResponse> CreateHostedZoneAsync(CreateHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHostedZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHostedZoneResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateQueryLoggingConfig

        internal virtual CreateQueryLoggingConfigResponse CreateQueryLoggingConfig(CreateQueryLoggingConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateQueryLoggingConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueryLoggingConfigResponseUnmarshaller.Instance;

            return Invoke<CreateQueryLoggingConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateQueryLoggingConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQueryLoggingConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateQueryLoggingConfig">REST API Reference for CreateQueryLoggingConfig Operation</seealso>
        public virtual Task<CreateQueryLoggingConfigResponse> CreateQueryLoggingConfigAsync(CreateQueryLoggingConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateQueryLoggingConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueryLoggingConfigResponseUnmarshaller.Instance;

            return InvokeAsync<CreateQueryLoggingConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateReusableDelegationSet

        internal virtual CreateReusableDelegationSetResponse CreateReusableDelegationSet(CreateReusableDelegationSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReusableDelegationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReusableDelegationSetResponseUnmarshaller.Instance;

            return Invoke<CreateReusableDelegationSetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReusableDelegationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateReusableDelegationSet">REST API Reference for CreateReusableDelegationSet Operation</seealso>
        public virtual Task<CreateReusableDelegationSetResponse> CreateReusableDelegationSetAsync(CreateReusableDelegationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReusableDelegationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReusableDelegationSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReusableDelegationSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTrafficPolicy

        internal virtual CreateTrafficPolicyResponse CreateTrafficPolicy(CreateTrafficPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrafficPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrafficPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateTrafficPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateTrafficPolicy">REST API Reference for CreateTrafficPolicy Operation</seealso>
        public virtual Task<CreateTrafficPolicyResponse> CreateTrafficPolicyAsync(CreateTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrafficPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrafficPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrafficPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTrafficPolicyInstance

        internal virtual CreateTrafficPolicyInstanceResponse CreateTrafficPolicyInstance(CreateTrafficPolicyInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrafficPolicyInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateTrafficPolicyInstanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicyInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateTrafficPolicyInstance">REST API Reference for CreateTrafficPolicyInstance Operation</seealso>
        public virtual Task<CreateTrafficPolicyInstanceResponse> CreateTrafficPolicyInstanceAsync(CreateTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrafficPolicyInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrafficPolicyInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTrafficPolicyVersion

        internal virtual CreateTrafficPolicyVersionResponse CreateTrafficPolicyVersion(CreateTrafficPolicyVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrafficPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrafficPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<CreateTrafficPolicyVersionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrafficPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicyVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateTrafficPolicyVersion">REST API Reference for CreateTrafficPolicyVersion Operation</seealso>
        public virtual Task<CreateTrafficPolicyVersionResponse> CreateTrafficPolicyVersionAsync(CreateTrafficPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrafficPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrafficPolicyVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrafficPolicyVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVPCAssociationAuthorization

        internal virtual CreateVPCAssociationAuthorizationResponse CreateVPCAssociationAuthorization(CreateVPCAssociationAuthorizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVPCAssociationAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVPCAssociationAuthorizationResponseUnmarshaller.Instance;

            return Invoke<CreateVPCAssociationAuthorizationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVPCAssociationAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVPCAssociationAuthorization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateVPCAssociationAuthorization">REST API Reference for CreateVPCAssociationAuthorization Operation</seealso>
        public virtual Task<CreateVPCAssociationAuthorizationResponse> CreateVPCAssociationAuthorizationAsync(CreateVPCAssociationAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVPCAssociationAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVPCAssociationAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVPCAssociationAuthorizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteHealthCheck

        internal virtual DeleteHealthCheckResponse DeleteHealthCheck(DeleteHealthCheckRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHealthCheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHealthCheckResponseUnmarshaller.Instance;

            return Invoke<DeleteHealthCheckResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteHealthCheck">REST API Reference for DeleteHealthCheck Operation</seealso>
        public virtual Task<DeleteHealthCheckResponse> DeleteHealthCheckAsync(DeleteHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHealthCheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHealthCheckResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHealthCheckResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteHostedZone

        internal virtual DeleteHostedZoneResponse DeleteHostedZone(DeleteHostedZoneRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHostedZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHostedZoneResponseUnmarshaller.Instance;

            return Invoke<DeleteHostedZoneResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteHostedZone">REST API Reference for DeleteHostedZone Operation</seealso>
        public virtual Task<DeleteHostedZoneResponse> DeleteHostedZoneAsync(DeleteHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHostedZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHostedZoneResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteQueryLoggingConfig

        internal virtual DeleteQueryLoggingConfigResponse DeleteQueryLoggingConfig(DeleteQueryLoggingConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQueryLoggingConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueryLoggingConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteQueryLoggingConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQueryLoggingConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueryLoggingConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteQueryLoggingConfig">REST API Reference for DeleteQueryLoggingConfig Operation</seealso>
        public virtual Task<DeleteQueryLoggingConfigResponse> DeleteQueryLoggingConfigAsync(DeleteQueryLoggingConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQueryLoggingConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueryLoggingConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteQueryLoggingConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteReusableDelegationSet

        internal virtual DeleteReusableDelegationSetResponse DeleteReusableDelegationSet(DeleteReusableDelegationSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReusableDelegationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReusableDelegationSetResponseUnmarshaller.Instance;

            return Invoke<DeleteReusableDelegationSetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReusableDelegationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteReusableDelegationSet">REST API Reference for DeleteReusableDelegationSet Operation</seealso>
        public virtual Task<DeleteReusableDelegationSetResponse> DeleteReusableDelegationSetAsync(DeleteReusableDelegationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReusableDelegationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReusableDelegationSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReusableDelegationSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTrafficPolicy

        internal virtual DeleteTrafficPolicyResponse DeleteTrafficPolicy(DeleteTrafficPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrafficPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrafficPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteTrafficPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteTrafficPolicy">REST API Reference for DeleteTrafficPolicy Operation</seealso>
        public virtual Task<DeleteTrafficPolicyResponse> DeleteTrafficPolicyAsync(DeleteTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrafficPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrafficPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrafficPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTrafficPolicyInstance

        internal virtual DeleteTrafficPolicyInstanceResponse DeleteTrafficPolicyInstance(DeleteTrafficPolicyInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrafficPolicyInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteTrafficPolicyInstanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicyInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteTrafficPolicyInstance">REST API Reference for DeleteTrafficPolicyInstance Operation</seealso>
        public virtual Task<DeleteTrafficPolicyInstanceResponse> DeleteTrafficPolicyInstanceAsync(DeleteTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrafficPolicyInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrafficPolicyInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVPCAssociationAuthorization

        internal virtual DeleteVPCAssociationAuthorizationResponse DeleteVPCAssociationAuthorization(DeleteVPCAssociationAuthorizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVPCAssociationAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVPCAssociationAuthorizationResponseUnmarshaller.Instance;

            return Invoke<DeleteVPCAssociationAuthorizationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVPCAssociationAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVPCAssociationAuthorization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteVPCAssociationAuthorization">REST API Reference for DeleteVPCAssociationAuthorization Operation</seealso>
        public virtual Task<DeleteVPCAssociationAuthorizationResponse> DeleteVPCAssociationAuthorizationAsync(DeleteVPCAssociationAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVPCAssociationAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVPCAssociationAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVPCAssociationAuthorizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateVPCFromHostedZone

        internal virtual DisassociateVPCFromHostedZoneResponse DisassociateVPCFromHostedZone(DisassociateVPCFromHostedZoneRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateVPCFromHostedZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateVPCFromHostedZoneResponseUnmarshaller.Instance;

            return Invoke<DisassociateVPCFromHostedZoneResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateVPCFromHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVPCFromHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DisassociateVPCFromHostedZone">REST API Reference for DisassociateVPCFromHostedZone Operation</seealso>
        public virtual Task<DisassociateVPCFromHostedZoneResponse> DisassociateVPCFromHostedZoneAsync(DisassociateVPCFromHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateVPCFromHostedZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateVPCFromHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateVPCFromHostedZoneResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccountLimit

        internal virtual GetAccountLimitResponse GetAccountLimit(GetAccountLimitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountLimitResponseUnmarshaller.Instance;

            return Invoke<GetAccountLimitResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountLimit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetAccountLimit">REST API Reference for GetAccountLimit Operation</seealso>
        public virtual Task<GetAccountLimitResponse> GetAccountLimitAsync(GetAccountLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountLimitResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountLimitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetChange

        internal virtual GetChangeResponse GetChange(GetChangeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChangeResponseUnmarshaller.Instance;

            return Invoke<GetChangeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetChange operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChange operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetChange">REST API Reference for GetChange Operation</seealso>
        public virtual Task<GetChangeResponse> GetChangeAsync(GetChangeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChangeResponseUnmarshaller.Instance;

            return InvokeAsync<GetChangeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCheckerIpRanges

        internal virtual GetCheckerIpRangesResponse GetCheckerIpRanges(GetCheckerIpRangesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCheckerIpRangesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCheckerIpRangesResponseUnmarshaller.Instance;

            return Invoke<GetCheckerIpRangesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCheckerIpRanges operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCheckerIpRanges operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetCheckerIpRanges">REST API Reference for GetCheckerIpRanges Operation</seealso>
        public virtual Task<GetCheckerIpRangesResponse> GetCheckerIpRangesAsync(GetCheckerIpRangesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCheckerIpRangesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCheckerIpRangesResponseUnmarshaller.Instance;

            return InvokeAsync<GetCheckerIpRangesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGeoLocation

        internal virtual GetGeoLocationResponse GetGeoLocation(GetGeoLocationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGeoLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGeoLocationResponseUnmarshaller.Instance;

            return Invoke<GetGeoLocationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetGeoLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGeoLocation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetGeoLocation">REST API Reference for GetGeoLocation Operation</seealso>
        public virtual Task<GetGeoLocationResponse> GetGeoLocationAsync(GetGeoLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGeoLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGeoLocationResponseUnmarshaller.Instance;

            return InvokeAsync<GetGeoLocationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetHealthCheck

        internal virtual GetHealthCheckResponse GetHealthCheck(GetHealthCheckRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHealthCheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHealthCheckResponseUnmarshaller.Instance;

            return Invoke<GetHealthCheckResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHealthCheck">REST API Reference for GetHealthCheck Operation</seealso>
        public virtual Task<GetHealthCheckResponse> GetHealthCheckAsync(GetHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHealthCheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHealthCheckResponseUnmarshaller.Instance;

            return InvokeAsync<GetHealthCheckResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetHealthCheckCount

        internal virtual GetHealthCheckCountResponse GetHealthCheckCount(GetHealthCheckCountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHealthCheckCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHealthCheckCountResponseUnmarshaller.Instance;

            return Invoke<GetHealthCheckCountResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckCount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHealthCheckCount">REST API Reference for GetHealthCheckCount Operation</seealso>
        public virtual Task<GetHealthCheckCountResponse> GetHealthCheckCountAsync(GetHealthCheckCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHealthCheckCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHealthCheckCountResponseUnmarshaller.Instance;

            return InvokeAsync<GetHealthCheckCountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetHealthCheckLastFailureReason

        internal virtual GetHealthCheckLastFailureReasonResponse GetHealthCheckLastFailureReason(GetHealthCheckLastFailureReasonRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHealthCheckLastFailureReasonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHealthCheckLastFailureReasonResponseUnmarshaller.Instance;

            return Invoke<GetHealthCheckLastFailureReasonResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckLastFailureReason operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckLastFailureReason operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHealthCheckLastFailureReason">REST API Reference for GetHealthCheckLastFailureReason Operation</seealso>
        public virtual Task<GetHealthCheckLastFailureReasonResponse> GetHealthCheckLastFailureReasonAsync(GetHealthCheckLastFailureReasonRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHealthCheckLastFailureReasonRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHealthCheckLastFailureReasonResponseUnmarshaller.Instance;

            return InvokeAsync<GetHealthCheckLastFailureReasonResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetHealthCheckStatus

        internal virtual GetHealthCheckStatusResponse GetHealthCheckStatus(GetHealthCheckStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHealthCheckStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHealthCheckStatusResponseUnmarshaller.Instance;

            return Invoke<GetHealthCheckStatusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHealthCheckStatus">REST API Reference for GetHealthCheckStatus Operation</seealso>
        public virtual Task<GetHealthCheckStatusResponse> GetHealthCheckStatusAsync(GetHealthCheckStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHealthCheckStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHealthCheckStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetHealthCheckStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetHostedZone

        internal virtual GetHostedZoneResponse GetHostedZone(GetHostedZoneRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHostedZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHostedZoneResponseUnmarshaller.Instance;

            return Invoke<GetHostedZoneResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHostedZone">REST API Reference for GetHostedZone Operation</seealso>
        public virtual Task<GetHostedZoneResponse> GetHostedZoneAsync(GetHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHostedZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<GetHostedZoneResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetHostedZoneCount

        internal virtual GetHostedZoneCountResponse GetHostedZoneCount()
        {
            return GetHostedZoneCount(new GetHostedZoneCountRequest());
        }
        internal virtual GetHostedZoneCountResponse GetHostedZoneCount(GetHostedZoneCountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHostedZoneCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHostedZoneCountResponseUnmarshaller.Instance;

            return Invoke<GetHostedZoneCountResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the number of hosted zones that are associated with the current AWS account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHostedZoneCount service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHostedZoneCount">REST API Reference for GetHostedZoneCount Operation</seealso>
        public virtual Task<GetHostedZoneCountResponse> GetHostedZoneCountAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetHostedZoneCountAsync(new GetHostedZoneCountRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetHostedZoneCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZoneCount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHostedZoneCount">REST API Reference for GetHostedZoneCount Operation</seealso>
        public virtual Task<GetHostedZoneCountResponse> GetHostedZoneCountAsync(GetHostedZoneCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHostedZoneCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHostedZoneCountResponseUnmarshaller.Instance;

            return InvokeAsync<GetHostedZoneCountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetHostedZoneLimit

        internal virtual GetHostedZoneLimitResponse GetHostedZoneLimit(GetHostedZoneLimitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHostedZoneLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHostedZoneLimitResponseUnmarshaller.Instance;

            return Invoke<GetHostedZoneLimitResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetHostedZoneLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZoneLimit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHostedZoneLimit">REST API Reference for GetHostedZoneLimit Operation</seealso>
        public virtual Task<GetHostedZoneLimitResponse> GetHostedZoneLimitAsync(GetHostedZoneLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHostedZoneLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHostedZoneLimitResponseUnmarshaller.Instance;

            return InvokeAsync<GetHostedZoneLimitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetQueryLoggingConfig

        internal virtual GetQueryLoggingConfigResponse GetQueryLoggingConfig(GetQueryLoggingConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueryLoggingConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryLoggingConfigResponseUnmarshaller.Instance;

            return Invoke<GetQueryLoggingConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetQueryLoggingConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueryLoggingConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetQueryLoggingConfig">REST API Reference for GetQueryLoggingConfig Operation</seealso>
        public virtual Task<GetQueryLoggingConfigResponse> GetQueryLoggingConfigAsync(GetQueryLoggingConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueryLoggingConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryLoggingConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetQueryLoggingConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetReusableDelegationSet

        internal virtual GetReusableDelegationSetResponse GetReusableDelegationSet(GetReusableDelegationSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReusableDelegationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReusableDelegationSetResponseUnmarshaller.Instance;

            return Invoke<GetReusableDelegationSetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReusableDelegationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetReusableDelegationSet">REST API Reference for GetReusableDelegationSet Operation</seealso>
        public virtual Task<GetReusableDelegationSetResponse> GetReusableDelegationSetAsync(GetReusableDelegationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReusableDelegationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReusableDelegationSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetReusableDelegationSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetReusableDelegationSetLimit

        internal virtual GetReusableDelegationSetLimitResponse GetReusableDelegationSetLimit(GetReusableDelegationSetLimitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReusableDelegationSetLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReusableDelegationSetLimitResponseUnmarshaller.Instance;

            return Invoke<GetReusableDelegationSetLimitResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetReusableDelegationSetLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReusableDelegationSetLimit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetReusableDelegationSetLimit">REST API Reference for GetReusableDelegationSetLimit Operation</seealso>
        public virtual Task<GetReusableDelegationSetLimitResponse> GetReusableDelegationSetLimitAsync(GetReusableDelegationSetLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReusableDelegationSetLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReusableDelegationSetLimitResponseUnmarshaller.Instance;

            return InvokeAsync<GetReusableDelegationSetLimitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTrafficPolicy

        internal virtual GetTrafficPolicyResponse GetTrafficPolicy(GetTrafficPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTrafficPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrafficPolicyResponseUnmarshaller.Instance;

            return Invoke<GetTrafficPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetTrafficPolicy">REST API Reference for GetTrafficPolicy Operation</seealso>
        public virtual Task<GetTrafficPolicyResponse> GetTrafficPolicyAsync(GetTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTrafficPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrafficPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrafficPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTrafficPolicyInstance

        internal virtual GetTrafficPolicyInstanceResponse GetTrafficPolicyInstance(GetTrafficPolicyInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTrafficPolicyInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return Invoke<GetTrafficPolicyInstanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicyInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetTrafficPolicyInstance">REST API Reference for GetTrafficPolicyInstance Operation</seealso>
        public virtual Task<GetTrafficPolicyInstanceResponse> GetTrafficPolicyInstanceAsync(GetTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTrafficPolicyInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrafficPolicyInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTrafficPolicyInstanceCount

        internal virtual GetTrafficPolicyInstanceCountResponse GetTrafficPolicyInstanceCount(GetTrafficPolicyInstanceCountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTrafficPolicyInstanceCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrafficPolicyInstanceCountResponseUnmarshaller.Instance;

            return Invoke<GetTrafficPolicyInstanceCountResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTrafficPolicyInstanceCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicyInstanceCount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetTrafficPolicyInstanceCount">REST API Reference for GetTrafficPolicyInstanceCount Operation</seealso>
        public virtual Task<GetTrafficPolicyInstanceCountResponse> GetTrafficPolicyInstanceCountAsync(GetTrafficPolicyInstanceCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTrafficPolicyInstanceCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrafficPolicyInstanceCountResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrafficPolicyInstanceCountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGeoLocations

        internal virtual ListGeoLocationsResponse ListGeoLocations()
        {
            return ListGeoLocations(new ListGeoLocationsRequest());
        }
        internal virtual ListGeoLocationsResponse ListGeoLocations(ListGeoLocationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGeoLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGeoLocationsResponseUnmarshaller.Instance;

            return Invoke<ListGeoLocationsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of supported geographic locations.
        /// 
        ///  
        /// <para>
        /// Countries are listed first, and continents are listed last. If Amazon Route 53 supports
        /// subdivisions for a country (for example, states or provinces), the subdivisions for
        /// that country are listed in alphabetical order immediately after the corresponding
        /// country.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGeoLocations service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListGeoLocations">REST API Reference for ListGeoLocations Operation</seealso>
        public virtual Task<ListGeoLocationsResponse> ListGeoLocationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListGeoLocationsAsync(new ListGeoLocationsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListGeoLocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGeoLocations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListGeoLocations">REST API Reference for ListGeoLocations Operation</seealso>
        public virtual Task<ListGeoLocationsResponse> ListGeoLocationsAsync(ListGeoLocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGeoLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGeoLocationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGeoLocationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHealthChecks

        internal virtual ListHealthChecksResponse ListHealthChecks()
        {
            return ListHealthChecks(new ListHealthChecksRequest());
        }
        internal virtual ListHealthChecksResponse ListHealthChecks(ListHealthChecksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHealthChecksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHealthChecksResponseUnmarshaller.Instance;

            return Invoke<ListHealthChecksResponse>(request, options);
        }


        /// <summary>
        /// Retrieve a list of the health checks that are associated with the current AWS account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHealthChecks service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.IncompatibleVersionException">
        /// The resource you're trying to access is unsupported on this Amazon Route 53 endpoint.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListHealthChecks">REST API Reference for ListHealthChecks Operation</seealso>
        public virtual Task<ListHealthChecksResponse> ListHealthChecksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListHealthChecksAsync(new ListHealthChecksRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListHealthChecks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHealthChecks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListHealthChecks">REST API Reference for ListHealthChecks Operation</seealso>
        public virtual Task<ListHealthChecksResponse> ListHealthChecksAsync(ListHealthChecksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHealthChecksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHealthChecksResponseUnmarshaller.Instance;

            return InvokeAsync<ListHealthChecksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHostedZones

        internal virtual ListHostedZonesResponse ListHostedZones()
        {
            return ListHostedZones(new ListHostedZonesRequest());
        }
        internal virtual ListHostedZonesResponse ListHostedZones(ListHostedZonesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHostedZonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHostedZonesResponseUnmarshaller.Instance;

            return Invoke<ListHostedZonesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of the public and private hosted zones that are associated with the
        /// current AWS account. The response includes a <code>HostedZones</code> child element
        /// for each hosted zone.
        /// 
        ///  
        /// <para>
        /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
        /// of hosted zones, you can use the <code>maxitems</code> parameter to list them in groups
        /// of up to 100.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHostedZones service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// A reusable delegation set with the specified ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// A reusable delegation set with the specified ID does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListHostedZones">REST API Reference for ListHostedZones Operation</seealso>
        public virtual Task<ListHostedZonesResponse> ListHostedZonesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListHostedZonesAsync(new ListHostedZonesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListHostedZones operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZones operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListHostedZones">REST API Reference for ListHostedZones Operation</seealso>
        public virtual Task<ListHostedZonesResponse> ListHostedZonesAsync(ListHostedZonesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHostedZonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHostedZonesResponseUnmarshaller.Instance;

            return InvokeAsync<ListHostedZonesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHostedZonesByName

        internal virtual ListHostedZonesByNameResponse ListHostedZonesByName(ListHostedZonesByNameRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHostedZonesByNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHostedZonesByNameResponseUnmarshaller.Instance;

            return Invoke<ListHostedZonesByNameResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListHostedZonesByName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZonesByName operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListHostedZonesByName">REST API Reference for ListHostedZonesByName Operation</seealso>
        public virtual Task<ListHostedZonesByNameResponse> ListHostedZonesByNameAsync(ListHostedZonesByNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHostedZonesByNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHostedZonesByNameResponseUnmarshaller.Instance;

            return InvokeAsync<ListHostedZonesByNameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListQueryLoggingConfigs

        internal virtual ListQueryLoggingConfigsResponse ListQueryLoggingConfigs(ListQueryLoggingConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQueryLoggingConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueryLoggingConfigsResponseUnmarshaller.Instance;

            return Invoke<ListQueryLoggingConfigsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListQueryLoggingConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueryLoggingConfigs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListQueryLoggingConfigs">REST API Reference for ListQueryLoggingConfigs Operation</seealso>
        public virtual Task<ListQueryLoggingConfigsResponse> ListQueryLoggingConfigsAsync(ListQueryLoggingConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQueryLoggingConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueryLoggingConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<ListQueryLoggingConfigsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourceRecordSets

        internal virtual ListResourceRecordSetsResponse ListResourceRecordSets(ListResourceRecordSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceRecordSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceRecordSetsResponseUnmarshaller.Instance;

            return Invoke<ListResourceRecordSetsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceRecordSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceRecordSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListResourceRecordSets">REST API Reference for ListResourceRecordSets Operation</seealso>
        public virtual Task<ListResourceRecordSetsResponse> ListResourceRecordSetsAsync(ListResourceRecordSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceRecordSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceRecordSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceRecordSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListReusableDelegationSets

        internal virtual ListReusableDelegationSetsResponse ListReusableDelegationSets()
        {
            return ListReusableDelegationSets(new ListReusableDelegationSetsRequest());
        }
        internal virtual ListReusableDelegationSetsResponse ListReusableDelegationSets(ListReusableDelegationSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReusableDelegationSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReusableDelegationSetsResponseUnmarshaller.Instance;

            return Invoke<ListReusableDelegationSetsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of the reusable delegation sets that are associated with the current
        /// AWS account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReusableDelegationSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListReusableDelegationSets">REST API Reference for ListReusableDelegationSets Operation</seealso>
        public virtual Task<ListReusableDelegationSetsResponse> ListReusableDelegationSetsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListReusableDelegationSetsAsync(new ListReusableDelegationSetsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListReusableDelegationSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReusableDelegationSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListReusableDelegationSets">REST API Reference for ListReusableDelegationSets Operation</seealso>
        public virtual Task<ListReusableDelegationSetsResponse> ListReusableDelegationSetsAsync(ListReusableDelegationSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReusableDelegationSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReusableDelegationSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReusableDelegationSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResources

        internal virtual ListTagsForResourcesResponse ListTagsForResources(ListTagsForResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourcesResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourcesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTagsForResources">REST API Reference for ListTagsForResources Operation</seealso>
        public virtual Task<ListTagsForResourcesResponse> ListTagsForResourcesAsync(ListTagsForResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTrafficPolicies

        internal virtual ListTrafficPoliciesResponse ListTrafficPolicies(ListTrafficPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrafficPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrafficPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListTrafficPoliciesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTrafficPolicies">REST API Reference for ListTrafficPolicies Operation</seealso>
        public virtual Task<ListTrafficPoliciesResponse> ListTrafficPoliciesAsync(ListTrafficPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrafficPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrafficPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrafficPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTrafficPolicyInstances

        internal virtual ListTrafficPolicyInstancesResponse ListTrafficPolicyInstances(ListTrafficPolicyInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrafficPolicyInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrafficPolicyInstancesResponseUnmarshaller.Instance;

            return Invoke<ListTrafficPolicyInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicyInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTrafficPolicyInstances">REST API Reference for ListTrafficPolicyInstances Operation</seealso>
        public virtual Task<ListTrafficPolicyInstancesResponse> ListTrafficPolicyInstancesAsync(ListTrafficPolicyInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrafficPolicyInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrafficPolicyInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrafficPolicyInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTrafficPolicyInstancesByHostedZone

        internal virtual ListTrafficPolicyInstancesByHostedZoneResponse ListTrafficPolicyInstancesByHostedZone(ListTrafficPolicyInstancesByHostedZoneRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrafficPolicyInstancesByHostedZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrafficPolicyInstancesByHostedZoneResponseUnmarshaller.Instance;

            return Invoke<ListTrafficPolicyInstancesByHostedZoneResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicyInstancesByHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstancesByHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTrafficPolicyInstancesByHostedZone">REST API Reference for ListTrafficPolicyInstancesByHostedZone Operation</seealso>
        public virtual Task<ListTrafficPolicyInstancesByHostedZoneResponse> ListTrafficPolicyInstancesByHostedZoneAsync(ListTrafficPolicyInstancesByHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrafficPolicyInstancesByHostedZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrafficPolicyInstancesByHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrafficPolicyInstancesByHostedZoneResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTrafficPolicyInstancesByPolicy

        internal virtual ListTrafficPolicyInstancesByPolicyResponse ListTrafficPolicyInstancesByPolicy(ListTrafficPolicyInstancesByPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrafficPolicyInstancesByPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrafficPolicyInstancesByPolicyResponseUnmarshaller.Instance;

            return Invoke<ListTrafficPolicyInstancesByPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicyInstancesByPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstancesByPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTrafficPolicyInstancesByPolicy">REST API Reference for ListTrafficPolicyInstancesByPolicy Operation</seealso>
        public virtual Task<ListTrafficPolicyInstancesByPolicyResponse> ListTrafficPolicyInstancesByPolicyAsync(ListTrafficPolicyInstancesByPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrafficPolicyInstancesByPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrafficPolicyInstancesByPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrafficPolicyInstancesByPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTrafficPolicyVersions

        internal virtual ListTrafficPolicyVersionsResponse ListTrafficPolicyVersions(ListTrafficPolicyVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrafficPolicyVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrafficPolicyVersionsResponseUnmarshaller.Instance;

            return Invoke<ListTrafficPolicyVersionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTrafficPolicyVersions">REST API Reference for ListTrafficPolicyVersions Operation</seealso>
        public virtual Task<ListTrafficPolicyVersionsResponse> ListTrafficPolicyVersionsAsync(ListTrafficPolicyVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrafficPolicyVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrafficPolicyVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrafficPolicyVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVPCAssociationAuthorizations

        internal virtual ListVPCAssociationAuthorizationsResponse ListVPCAssociationAuthorizations(ListVPCAssociationAuthorizationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVPCAssociationAuthorizationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVPCAssociationAuthorizationsResponseUnmarshaller.Instance;

            return Invoke<ListVPCAssociationAuthorizationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListVPCAssociationAuthorizations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVPCAssociationAuthorizations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListVPCAssociationAuthorizations">REST API Reference for ListVPCAssociationAuthorizations Operation</seealso>
        public virtual Task<ListVPCAssociationAuthorizationsResponse> ListVPCAssociationAuthorizationsAsync(ListVPCAssociationAuthorizationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVPCAssociationAuthorizationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVPCAssociationAuthorizationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVPCAssociationAuthorizationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestDNSAnswer

        internal virtual TestDNSAnswerResponse TestDNSAnswer(TestDNSAnswerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestDNSAnswerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestDNSAnswerResponseUnmarshaller.Instance;

            return Invoke<TestDNSAnswerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TestDNSAnswer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestDNSAnswer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/TestDNSAnswer">REST API Reference for TestDNSAnswer Operation</seealso>
        public virtual Task<TestDNSAnswerResponse> TestDNSAnswerAsync(TestDNSAnswerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestDNSAnswerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestDNSAnswerResponseUnmarshaller.Instance;

            return InvokeAsync<TestDNSAnswerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateHealthCheck

        internal virtual UpdateHealthCheckResponse UpdateHealthCheck(UpdateHealthCheckRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateHealthCheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHealthCheckResponseUnmarshaller.Instance;

            return Invoke<UpdateHealthCheckResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/UpdateHealthCheck">REST API Reference for UpdateHealthCheck Operation</seealso>
        public virtual Task<UpdateHealthCheckResponse> UpdateHealthCheckAsync(UpdateHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateHealthCheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHealthCheckResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateHealthCheckResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateHostedZoneComment

        internal virtual UpdateHostedZoneCommentResponse UpdateHostedZoneComment(UpdateHostedZoneCommentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateHostedZoneCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHostedZoneCommentResponseUnmarshaller.Instance;

            return Invoke<UpdateHostedZoneCommentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHostedZoneComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHostedZoneComment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/UpdateHostedZoneComment">REST API Reference for UpdateHostedZoneComment Operation</seealso>
        public virtual Task<UpdateHostedZoneCommentResponse> UpdateHostedZoneCommentAsync(UpdateHostedZoneCommentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateHostedZoneCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHostedZoneCommentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateHostedZoneCommentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTrafficPolicyComment

        internal virtual UpdateTrafficPolicyCommentResponse UpdateTrafficPolicyComment(UpdateTrafficPolicyCommentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrafficPolicyCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrafficPolicyCommentResponseUnmarshaller.Instance;

            return Invoke<UpdateTrafficPolicyCommentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrafficPolicyComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficPolicyComment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/UpdateTrafficPolicyComment">REST API Reference for UpdateTrafficPolicyComment Operation</seealso>
        public virtual Task<UpdateTrafficPolicyCommentResponse> UpdateTrafficPolicyCommentAsync(UpdateTrafficPolicyCommentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrafficPolicyCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrafficPolicyCommentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTrafficPolicyCommentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTrafficPolicyInstance

        internal virtual UpdateTrafficPolicyInstanceResponse UpdateTrafficPolicyInstance(UpdateTrafficPolicyInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrafficPolicyInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateTrafficPolicyInstanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficPolicyInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/UpdateTrafficPolicyInstance">REST API Reference for UpdateTrafficPolicyInstance Operation</seealso>
        public virtual Task<UpdateTrafficPolicyInstanceResponse> UpdateTrafficPolicyInstanceAsync(UpdateTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrafficPolicyInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTrafficPolicyInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}