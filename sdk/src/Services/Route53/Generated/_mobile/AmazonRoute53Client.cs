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

using Amazon.Route53.Model;
using Amazon.Route53.Model.Internal.MarshallTransformations;
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

        internal AssociateVPCWithHostedZoneResponse AssociateVPCWithHostedZone(AssociateVPCWithHostedZoneRequest request)
        {
            var marshaller = new AssociateVPCWithHostedZoneRequestMarshaller();
            var unmarshaller = AssociateVPCWithHostedZoneResponseUnmarshaller.Instance;

            return Invoke<AssociateVPCWithHostedZoneRequest,AssociateVPCWithHostedZoneResponse>(request, marshaller, unmarshaller);
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
        public Task<AssociateVPCWithHostedZoneResponse> AssociateVPCWithHostedZoneAsync(AssociateVPCWithHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateVPCWithHostedZoneRequestMarshaller();
            var unmarshaller = AssociateVPCWithHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateVPCWithHostedZoneRequest,AssociateVPCWithHostedZoneResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ChangeResourceRecordSets

        internal ChangeResourceRecordSetsResponse ChangeResourceRecordSets(ChangeResourceRecordSetsRequest request)
        {
            var marshaller = new ChangeResourceRecordSetsRequestMarshaller();
            var unmarshaller = ChangeResourceRecordSetsResponseUnmarshaller.Instance;

            return Invoke<ChangeResourceRecordSetsRequest,ChangeResourceRecordSetsResponse>(request, marshaller, unmarshaller);
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
        public Task<ChangeResourceRecordSetsResponse> ChangeResourceRecordSetsAsync(ChangeResourceRecordSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ChangeResourceRecordSetsRequestMarshaller();
            var unmarshaller = ChangeResourceRecordSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ChangeResourceRecordSetsRequest,ChangeResourceRecordSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ChangeTagsForResource

        internal ChangeTagsForResourceResponse ChangeTagsForResource(ChangeTagsForResourceRequest request)
        {
            var marshaller = new ChangeTagsForResourceRequestMarshaller();
            var unmarshaller = ChangeTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ChangeTagsForResourceRequest,ChangeTagsForResourceResponse>(request, marshaller, unmarshaller);
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
        public Task<ChangeTagsForResourceResponse> ChangeTagsForResourceAsync(ChangeTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ChangeTagsForResourceRequestMarshaller();
            var unmarshaller = ChangeTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ChangeTagsForResourceRequest,ChangeTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateHealthCheck

        internal CreateHealthCheckResponse CreateHealthCheck(CreateHealthCheckRequest request)
        {
            var marshaller = new CreateHealthCheckRequestMarshaller();
            var unmarshaller = CreateHealthCheckResponseUnmarshaller.Instance;

            return Invoke<CreateHealthCheckRequest,CreateHealthCheckResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateHealthCheckResponse> CreateHealthCheckAsync(CreateHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateHealthCheckRequestMarshaller();
            var unmarshaller = CreateHealthCheckResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHealthCheckRequest,CreateHealthCheckResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateHostedZone

        internal CreateHostedZoneResponse CreateHostedZone(CreateHostedZoneRequest request)
        {
            var marshaller = new CreateHostedZoneRequestMarshaller();
            var unmarshaller = CreateHostedZoneResponseUnmarshaller.Instance;

            return Invoke<CreateHostedZoneRequest,CreateHostedZoneResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateHostedZoneResponse> CreateHostedZoneAsync(CreateHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateHostedZoneRequestMarshaller();
            var unmarshaller = CreateHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHostedZoneRequest,CreateHostedZoneResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateReusableDelegationSet

        internal CreateReusableDelegationSetResponse CreateReusableDelegationSet(CreateReusableDelegationSetRequest request)
        {
            var marshaller = new CreateReusableDelegationSetRequestMarshaller();
            var unmarshaller = CreateReusableDelegationSetResponseUnmarshaller.Instance;

            return Invoke<CreateReusableDelegationSetRequest,CreateReusableDelegationSetResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateReusableDelegationSetResponse> CreateReusableDelegationSetAsync(CreateReusableDelegationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateReusableDelegationSetRequestMarshaller();
            var unmarshaller = CreateReusableDelegationSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReusableDelegationSetRequest,CreateReusableDelegationSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTrafficPolicy

        internal CreateTrafficPolicyResponse CreateTrafficPolicy(CreateTrafficPolicyRequest request)
        {
            var marshaller = new CreateTrafficPolicyRequestMarshaller();
            var unmarshaller = CreateTrafficPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateTrafficPolicyRequest,CreateTrafficPolicyResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateTrafficPolicyResponse> CreateTrafficPolicyAsync(CreateTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTrafficPolicyRequestMarshaller();
            var unmarshaller = CreateTrafficPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrafficPolicyRequest,CreateTrafficPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTrafficPolicyInstance

        internal CreateTrafficPolicyInstanceResponse CreateTrafficPolicyInstance(CreateTrafficPolicyInstanceRequest request)
        {
            var marshaller = new CreateTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = CreateTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateTrafficPolicyInstanceRequest,CreateTrafficPolicyInstanceResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateTrafficPolicyInstanceResponse> CreateTrafficPolicyInstanceAsync(CreateTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = CreateTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrafficPolicyInstanceRequest,CreateTrafficPolicyInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTrafficPolicyVersion

        internal CreateTrafficPolicyVersionResponse CreateTrafficPolicyVersion(CreateTrafficPolicyVersionRequest request)
        {
            var marshaller = new CreateTrafficPolicyVersionRequestMarshaller();
            var unmarshaller = CreateTrafficPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<CreateTrafficPolicyVersionRequest,CreateTrafficPolicyVersionResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateTrafficPolicyVersionResponse> CreateTrafficPolicyVersionAsync(CreateTrafficPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTrafficPolicyVersionRequestMarshaller();
            var unmarshaller = CreateTrafficPolicyVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrafficPolicyVersionRequest,CreateTrafficPolicyVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteHealthCheck

        internal DeleteHealthCheckResponse DeleteHealthCheck(DeleteHealthCheckRequest request)
        {
            var marshaller = new DeleteHealthCheckRequestMarshaller();
            var unmarshaller = DeleteHealthCheckResponseUnmarshaller.Instance;

            return Invoke<DeleteHealthCheckRequest,DeleteHealthCheckResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteHealthCheckResponse> DeleteHealthCheckAsync(DeleteHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteHealthCheckRequestMarshaller();
            var unmarshaller = DeleteHealthCheckResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHealthCheckRequest,DeleteHealthCheckResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteHostedZone

        internal DeleteHostedZoneResponse DeleteHostedZone(DeleteHostedZoneRequest request)
        {
            var marshaller = new DeleteHostedZoneRequestMarshaller();
            var unmarshaller = DeleteHostedZoneResponseUnmarshaller.Instance;

            return Invoke<DeleteHostedZoneRequest,DeleteHostedZoneResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteHostedZoneResponse> DeleteHostedZoneAsync(DeleteHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteHostedZoneRequestMarshaller();
            var unmarshaller = DeleteHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHostedZoneRequest,DeleteHostedZoneResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteReusableDelegationSet

        internal DeleteReusableDelegationSetResponse DeleteReusableDelegationSet(DeleteReusableDelegationSetRequest request)
        {
            var marshaller = new DeleteReusableDelegationSetRequestMarshaller();
            var unmarshaller = DeleteReusableDelegationSetResponseUnmarshaller.Instance;

            return Invoke<DeleteReusableDelegationSetRequest,DeleteReusableDelegationSetResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteReusableDelegationSetResponse> DeleteReusableDelegationSetAsync(DeleteReusableDelegationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteReusableDelegationSetRequestMarshaller();
            var unmarshaller = DeleteReusableDelegationSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReusableDelegationSetRequest,DeleteReusableDelegationSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTrafficPolicy

        internal DeleteTrafficPolicyResponse DeleteTrafficPolicy(DeleteTrafficPolicyRequest request)
        {
            var marshaller = new DeleteTrafficPolicyRequestMarshaller();
            var unmarshaller = DeleteTrafficPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteTrafficPolicyRequest,DeleteTrafficPolicyResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteTrafficPolicyResponse> DeleteTrafficPolicyAsync(DeleteTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTrafficPolicyRequestMarshaller();
            var unmarshaller = DeleteTrafficPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrafficPolicyRequest,DeleteTrafficPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTrafficPolicyInstance

        internal DeleteTrafficPolicyInstanceResponse DeleteTrafficPolicyInstance(DeleteTrafficPolicyInstanceRequest request)
        {
            var marshaller = new DeleteTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = DeleteTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteTrafficPolicyInstanceRequest,DeleteTrafficPolicyInstanceResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteTrafficPolicyInstanceResponse> DeleteTrafficPolicyInstanceAsync(DeleteTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = DeleteTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrafficPolicyInstanceRequest,DeleteTrafficPolicyInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateVPCFromHostedZone

        internal DisassociateVPCFromHostedZoneResponse DisassociateVPCFromHostedZone(DisassociateVPCFromHostedZoneRequest request)
        {
            var marshaller = new DisassociateVPCFromHostedZoneRequestMarshaller();
            var unmarshaller = DisassociateVPCFromHostedZoneResponseUnmarshaller.Instance;

            return Invoke<DisassociateVPCFromHostedZoneRequest,DisassociateVPCFromHostedZoneResponse>(request, marshaller, unmarshaller);
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
        public Task<DisassociateVPCFromHostedZoneResponse> DisassociateVPCFromHostedZoneAsync(DisassociateVPCFromHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisassociateVPCFromHostedZoneRequestMarshaller();
            var unmarshaller = DisassociateVPCFromHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateVPCFromHostedZoneRequest,DisassociateVPCFromHostedZoneResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetChange

        internal GetChangeResponse GetChange(GetChangeRequest request)
        {
            var marshaller = new GetChangeRequestMarshaller();
            var unmarshaller = GetChangeResponseUnmarshaller.Instance;

            return Invoke<GetChangeRequest,GetChangeResponse>(request, marshaller, unmarshaller);
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
        public Task<GetChangeResponse> GetChangeAsync(GetChangeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetChangeRequestMarshaller();
            var unmarshaller = GetChangeResponseUnmarshaller.Instance;

            return InvokeAsync<GetChangeRequest,GetChangeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetChangeDetails

        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        internal GetChangeDetailsResponse GetChangeDetails(GetChangeDetailsRequest request)
        {
            var marshaller = new GetChangeDetailsRequestMarshaller();
            var unmarshaller = GetChangeDetailsResponseUnmarshaller.Instance;

            return Invoke<GetChangeDetailsRequest,GetChangeDetailsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetChangeDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChangeDetails operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        public Task<GetChangeDetailsResponse> GetChangeDetailsAsync(GetChangeDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetChangeDetailsRequestMarshaller();
            var unmarshaller = GetChangeDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetChangeDetailsRequest,GetChangeDetailsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCheckerIpRanges

        internal GetCheckerIpRangesResponse GetCheckerIpRanges(GetCheckerIpRangesRequest request)
        {
            var marshaller = new GetCheckerIpRangesRequestMarshaller();
            var unmarshaller = GetCheckerIpRangesResponseUnmarshaller.Instance;

            return Invoke<GetCheckerIpRangesRequest,GetCheckerIpRangesResponse>(request, marshaller, unmarshaller);
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
        public Task<GetCheckerIpRangesResponse> GetCheckerIpRangesAsync(GetCheckerIpRangesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCheckerIpRangesRequestMarshaller();
            var unmarshaller = GetCheckerIpRangesResponseUnmarshaller.Instance;

            return InvokeAsync<GetCheckerIpRangesRequest,GetCheckerIpRangesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetGeoLocation

        internal GetGeoLocationResponse GetGeoLocation(GetGeoLocationRequest request)
        {
            var marshaller = new GetGeoLocationRequestMarshaller();
            var unmarshaller = GetGeoLocationResponseUnmarshaller.Instance;

            return Invoke<GetGeoLocationRequest,GetGeoLocationResponse>(request, marshaller, unmarshaller);
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
        public Task<GetGeoLocationResponse> GetGeoLocationAsync(GetGeoLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetGeoLocationRequestMarshaller();
            var unmarshaller = GetGeoLocationResponseUnmarshaller.Instance;

            return InvokeAsync<GetGeoLocationRequest,GetGeoLocationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetHealthCheck

        internal GetHealthCheckResponse GetHealthCheck(GetHealthCheckRequest request)
        {
            var marshaller = new GetHealthCheckRequestMarshaller();
            var unmarshaller = GetHealthCheckResponseUnmarshaller.Instance;

            return Invoke<GetHealthCheckRequest,GetHealthCheckResponse>(request, marshaller, unmarshaller);
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
        public Task<GetHealthCheckResponse> GetHealthCheckAsync(GetHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetHealthCheckRequestMarshaller();
            var unmarshaller = GetHealthCheckResponseUnmarshaller.Instance;

            return InvokeAsync<GetHealthCheckRequest,GetHealthCheckResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetHealthCheckCount

        internal GetHealthCheckCountResponse GetHealthCheckCount(GetHealthCheckCountRequest request)
        {
            var marshaller = new GetHealthCheckCountRequestMarshaller();
            var unmarshaller = GetHealthCheckCountResponseUnmarshaller.Instance;

            return Invoke<GetHealthCheckCountRequest,GetHealthCheckCountResponse>(request, marshaller, unmarshaller);
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
        public Task<GetHealthCheckCountResponse> GetHealthCheckCountAsync(GetHealthCheckCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetHealthCheckCountRequestMarshaller();
            var unmarshaller = GetHealthCheckCountResponseUnmarshaller.Instance;

            return InvokeAsync<GetHealthCheckCountRequest,GetHealthCheckCountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetHealthCheckLastFailureReason

        internal GetHealthCheckLastFailureReasonResponse GetHealthCheckLastFailureReason(GetHealthCheckLastFailureReasonRequest request)
        {
            var marshaller = new GetHealthCheckLastFailureReasonRequestMarshaller();
            var unmarshaller = GetHealthCheckLastFailureReasonResponseUnmarshaller.Instance;

            return Invoke<GetHealthCheckLastFailureReasonRequest,GetHealthCheckLastFailureReasonResponse>(request, marshaller, unmarshaller);
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
        public Task<GetHealthCheckLastFailureReasonResponse> GetHealthCheckLastFailureReasonAsync(GetHealthCheckLastFailureReasonRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetHealthCheckLastFailureReasonRequestMarshaller();
            var unmarshaller = GetHealthCheckLastFailureReasonResponseUnmarshaller.Instance;

            return InvokeAsync<GetHealthCheckLastFailureReasonRequest,GetHealthCheckLastFailureReasonResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetHealthCheckStatus

        internal GetHealthCheckStatusResponse GetHealthCheckStatus(GetHealthCheckStatusRequest request)
        {
            var marshaller = new GetHealthCheckStatusRequestMarshaller();
            var unmarshaller = GetHealthCheckStatusResponseUnmarshaller.Instance;

            return Invoke<GetHealthCheckStatusRequest,GetHealthCheckStatusResponse>(request, marshaller, unmarshaller);
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
        public Task<GetHealthCheckStatusResponse> GetHealthCheckStatusAsync(GetHealthCheckStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetHealthCheckStatusRequestMarshaller();
            var unmarshaller = GetHealthCheckStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetHealthCheckStatusRequest,GetHealthCheckStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetHostedZone

        internal GetHostedZoneResponse GetHostedZone(GetHostedZoneRequest request)
        {
            var marshaller = new GetHostedZoneRequestMarshaller();
            var unmarshaller = GetHostedZoneResponseUnmarshaller.Instance;

            return Invoke<GetHostedZoneRequest,GetHostedZoneResponse>(request, marshaller, unmarshaller);
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
        public Task<GetHostedZoneResponse> GetHostedZoneAsync(GetHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetHostedZoneRequestMarshaller();
            var unmarshaller = GetHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<GetHostedZoneRequest,GetHostedZoneResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetHostedZoneCount

        internal GetHostedZoneCountResponse GetHostedZoneCount()
        {
            return GetHostedZoneCount(new GetHostedZoneCountRequest());
        }
        internal GetHostedZoneCountResponse GetHostedZoneCount(GetHostedZoneCountRequest request)
        {
            var marshaller = new GetHostedZoneCountRequestMarshaller();
            var unmarshaller = GetHostedZoneCountResponseUnmarshaller.Instance;

            return Invoke<GetHostedZoneCountRequest,GetHostedZoneCountResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieves a count of all your hosted zones. Send a <code>GET</code> request to the
        /// <code>/2013-04-01/hostedzonecount</code> resource.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHostedZoneCount service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        public Task<GetHostedZoneCountResponse> GetHostedZoneCountAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<GetHostedZoneCountResponse> GetHostedZoneCountAsync(GetHostedZoneCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetHostedZoneCountRequestMarshaller();
            var unmarshaller = GetHostedZoneCountResponseUnmarshaller.Instance;

            return InvokeAsync<GetHostedZoneCountRequest,GetHostedZoneCountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetReusableDelegationSet

        internal GetReusableDelegationSetResponse GetReusableDelegationSet(GetReusableDelegationSetRequest request)
        {
            var marshaller = new GetReusableDelegationSetRequestMarshaller();
            var unmarshaller = GetReusableDelegationSetResponseUnmarshaller.Instance;

            return Invoke<GetReusableDelegationSetRequest,GetReusableDelegationSetResponse>(request, marshaller, unmarshaller);
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
        public Task<GetReusableDelegationSetResponse> GetReusableDelegationSetAsync(GetReusableDelegationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetReusableDelegationSetRequestMarshaller();
            var unmarshaller = GetReusableDelegationSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetReusableDelegationSetRequest,GetReusableDelegationSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTrafficPolicy

        internal GetTrafficPolicyResponse GetTrafficPolicy(GetTrafficPolicyRequest request)
        {
            var marshaller = new GetTrafficPolicyRequestMarshaller();
            var unmarshaller = GetTrafficPolicyResponseUnmarshaller.Instance;

            return Invoke<GetTrafficPolicyRequest,GetTrafficPolicyResponse>(request, marshaller, unmarshaller);
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
        public Task<GetTrafficPolicyResponse> GetTrafficPolicyAsync(GetTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTrafficPolicyRequestMarshaller();
            var unmarshaller = GetTrafficPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrafficPolicyRequest,GetTrafficPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTrafficPolicyInstance

        internal GetTrafficPolicyInstanceResponse GetTrafficPolicyInstance(GetTrafficPolicyInstanceRequest request)
        {
            var marshaller = new GetTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = GetTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return Invoke<GetTrafficPolicyInstanceRequest,GetTrafficPolicyInstanceResponse>(request, marshaller, unmarshaller);
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
        public Task<GetTrafficPolicyInstanceResponse> GetTrafficPolicyInstanceAsync(GetTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = GetTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrafficPolicyInstanceRequest,GetTrafficPolicyInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTrafficPolicyInstanceCount

        internal GetTrafficPolicyInstanceCountResponse GetTrafficPolicyInstanceCount(GetTrafficPolicyInstanceCountRequest request)
        {
            var marshaller = new GetTrafficPolicyInstanceCountRequestMarshaller();
            var unmarshaller = GetTrafficPolicyInstanceCountResponseUnmarshaller.Instance;

            return Invoke<GetTrafficPolicyInstanceCountRequest,GetTrafficPolicyInstanceCountResponse>(request, marshaller, unmarshaller);
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
        public Task<GetTrafficPolicyInstanceCountResponse> GetTrafficPolicyInstanceCountAsync(GetTrafficPolicyInstanceCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTrafficPolicyInstanceCountRequestMarshaller();
            var unmarshaller = GetTrafficPolicyInstanceCountResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrafficPolicyInstanceCountRequest,GetTrafficPolicyInstanceCountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListChangeBatchesByHostedZone

        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        internal ListChangeBatchesByHostedZoneResponse ListChangeBatchesByHostedZone(ListChangeBatchesByHostedZoneRequest request)
        {
            var marshaller = new ListChangeBatchesByHostedZoneRequestMarshaller();
            var unmarshaller = ListChangeBatchesByHostedZoneResponseUnmarshaller.Instance;

            return Invoke<ListChangeBatchesByHostedZoneRequest,ListChangeBatchesByHostedZoneResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListChangeBatchesByHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChangeBatchesByHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        public Task<ListChangeBatchesByHostedZoneResponse> ListChangeBatchesByHostedZoneAsync(ListChangeBatchesByHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListChangeBatchesByHostedZoneRequestMarshaller();
            var unmarshaller = ListChangeBatchesByHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<ListChangeBatchesByHostedZoneRequest,ListChangeBatchesByHostedZoneResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListChangeBatchesByRRSet

        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        internal ListChangeBatchesByRRSetResponse ListChangeBatchesByRRSet(ListChangeBatchesByRRSetRequest request)
        {
            var marshaller = new ListChangeBatchesByRRSetRequestMarshaller();
            var unmarshaller = ListChangeBatchesByRRSetResponseUnmarshaller.Instance;

            return Invoke<ListChangeBatchesByRRSetRequest,ListChangeBatchesByRRSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListChangeBatchesByRRSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChangeBatchesByRRSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        public Task<ListChangeBatchesByRRSetResponse> ListChangeBatchesByRRSetAsync(ListChangeBatchesByRRSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListChangeBatchesByRRSetRequestMarshaller();
            var unmarshaller = ListChangeBatchesByRRSetResponseUnmarshaller.Instance;

            return InvokeAsync<ListChangeBatchesByRRSetRequest,ListChangeBatchesByRRSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListGeoLocations

        internal ListGeoLocationsResponse ListGeoLocations()
        {
            return ListGeoLocations(new ListGeoLocationsRequest());
        }
        internal ListGeoLocationsResponse ListGeoLocations(ListGeoLocationsRequest request)
        {
            var marshaller = new ListGeoLocationsRequestMarshaller();
            var unmarshaller = ListGeoLocationsResponseUnmarshaller.Instance;

            return Invoke<ListGeoLocationsRequest,ListGeoLocationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieves a list of supported geo locations. Send a <code>GET</code> request to the
        /// <code>/2013-04-01/geolocations</code> resource. The response to this request includes
        /// a <code>GeoLocationDetailsList</code> element for each location that Amazon Route
        /// 53 supports.
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
        public Task<ListGeoLocationsResponse> ListGeoLocationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<ListGeoLocationsResponse> ListGeoLocationsAsync(ListGeoLocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListGeoLocationsRequestMarshaller();
            var unmarshaller = ListGeoLocationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGeoLocationsRequest,ListGeoLocationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListHealthChecks

        internal ListHealthChecksResponse ListHealthChecks()
        {
            return ListHealthChecks(new ListHealthChecksRequest());
        }
        internal ListHealthChecksResponse ListHealthChecks(ListHealthChecksRequest request)
        {
            var marshaller = new ListHealthChecksRequestMarshaller();
            var unmarshaller = ListHealthChecksResponseUnmarshaller.Instance;

            return Invoke<ListHealthChecksRequest,ListHealthChecksResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieve a list of your health checks. Send a <code>GET</code> request to the <code>/2013-04-01/healthcheck</code>
        /// resource. The response to this request includes a <code>HealthChecks</code> element
        /// with zero or more <code>HealthCheck</code> child elements. By default, the list of
        /// health checks is displayed on a single page. You can control the length of the page
        /// that is displayed by using the <code>MaxItems</code> parameter. You can use the <code>Marker</code>
        /// parameter to control the health check that the list begins with.
        /// 
        ///  
        /// <para>
        /// For information about listing health checks using the Amazon Route 53 console, see
        /// <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover.html">Amazon
        /// Route 53 Health Checks and DNS Failover</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHealthChecks service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.IncompatibleVersionException">
        /// The resource you are trying to access is unsupported on this Amazon Route 53 endpoint.
        /// Please consider using a newer endpoint or a tool that does so.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        public Task<ListHealthChecksResponse> ListHealthChecksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<ListHealthChecksResponse> ListHealthChecksAsync(ListHealthChecksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListHealthChecksRequestMarshaller();
            var unmarshaller = ListHealthChecksResponseUnmarshaller.Instance;

            return InvokeAsync<ListHealthChecksRequest,ListHealthChecksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListHostedZones

        internal ListHostedZonesResponse ListHostedZones()
        {
            return ListHostedZones(new ListHostedZonesRequest());
        }
        internal ListHostedZonesResponse ListHostedZones(ListHostedZonesRequest request)
        {
            var marshaller = new ListHostedZonesRequestMarshaller();
            var unmarshaller = ListHostedZonesResponseUnmarshaller.Instance;

            return Invoke<ListHostedZonesRequest,ListHostedZonesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// To retrieve a list of your public and private hosted zones, send a <code>GET</code>
        /// request to the <code>/2013-04-01/hostedzone</code> resource. The response to this
        /// request includes a <code>HostedZones</code> child element for each hosted zone created
        /// by the current AWS account.
        /// 
        ///  
        /// <para>
        /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
        /// of hosted zones, you can use the <code>maxitems</code> parameter to list them in groups
        /// of up to 100. The response includes four values that help navigate from one group
        /// of <code>maxitems</code> hosted zones to the next:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>MaxItems</code>is the value specified for the <code>maxitems</code> parameter
        /// in the request that produced the current response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value of <code>IsTruncated</code> in the response is true, there are more hosted
        /// zones associated with the current AWS account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NextMarker</code>is the hosted zone ID of the next hosted zone that is associated
        /// with the current AWS account. If you want to list more hosted zones, make another
        /// call to <code>ListHostedZones</code>, and specify the value of the <code>NextMarker</code>
        /// element in the marker parameter. 
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is false, the <code>NextMarker</code> element is omitted
        /// from the response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you're making the second or subsequent call to <code>ListHostedZones</code>, the
        /// <code>Marker</code> element matches the value that you specified in the <code>marker</code>
        /// parameter in the previous request.
        /// </para>
        ///  </li> </ul>
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
        public Task<ListHostedZonesResponse> ListHostedZonesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<ListHostedZonesResponse> ListHostedZonesAsync(ListHostedZonesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListHostedZonesRequestMarshaller();
            var unmarshaller = ListHostedZonesResponseUnmarshaller.Instance;

            return InvokeAsync<ListHostedZonesRequest,ListHostedZonesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListHostedZonesByName

        internal ListHostedZonesByNameResponse ListHostedZonesByName(ListHostedZonesByNameRequest request)
        {
            var marshaller = new ListHostedZonesByNameRequestMarshaller();
            var unmarshaller = ListHostedZonesByNameResponseUnmarshaller.Instance;

            return Invoke<ListHostedZonesByNameRequest,ListHostedZonesByNameResponse>(request, marshaller, unmarshaller);
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
        public Task<ListHostedZonesByNameResponse> ListHostedZonesByNameAsync(ListHostedZonesByNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListHostedZonesByNameRequestMarshaller();
            var unmarshaller = ListHostedZonesByNameResponseUnmarshaller.Instance;

            return InvokeAsync<ListHostedZonesByNameRequest,ListHostedZonesByNameResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListResourceRecordSets

        internal ListResourceRecordSetsResponse ListResourceRecordSets(ListResourceRecordSetsRequest request)
        {
            var marshaller = new ListResourceRecordSetsRequestMarshaller();
            var unmarshaller = ListResourceRecordSetsResponseUnmarshaller.Instance;

            return Invoke<ListResourceRecordSetsRequest,ListResourceRecordSetsResponse>(request, marshaller, unmarshaller);
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
        public Task<ListResourceRecordSetsResponse> ListResourceRecordSetsAsync(ListResourceRecordSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListResourceRecordSetsRequestMarshaller();
            var unmarshaller = ListResourceRecordSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceRecordSetsRequest,ListResourceRecordSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListReusableDelegationSets

        internal ListReusableDelegationSetsResponse ListReusableDelegationSets()
        {
            return ListReusableDelegationSets(new ListReusableDelegationSetsRequest());
        }
        internal ListReusableDelegationSetsResponse ListReusableDelegationSets(ListReusableDelegationSetsRequest request)
        {
            var marshaller = new ListReusableDelegationSetsRequestMarshaller();
            var unmarshaller = ListReusableDelegationSetsResponseUnmarshaller.Instance;

            return Invoke<ListReusableDelegationSetsRequest,ListReusableDelegationSetsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// To retrieve a list of your reusable delegation sets, send a <code>GET</code> request
        /// to the <code>/2013-04-01/delegationset</code> resource. The response to this request
        /// includes a <code>DelegationSets</code> element with zero, one, or multiple <code>DelegationSet</code>
        /// child elements. By default, the list of delegation sets is displayed on a single page.
        /// You can control the length of the page that is displayed by using the <code>MaxItems</code>
        /// parameter. You can use the <code>Marker</code> parameter to control the delegation
        /// set that the list begins with. 
        /// 
        ///  <note> 
        /// <para>
        ///  Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value greater
        /// than 100, Amazon Route 53 returns only the first 100.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReusableDelegationSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        public Task<ListReusableDelegationSetsResponse> ListReusableDelegationSetsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<ListReusableDelegationSetsResponse> ListReusableDelegationSetsAsync(ListReusableDelegationSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListReusableDelegationSetsRequestMarshaller();
            var unmarshaller = ListReusableDelegationSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReusableDelegationSetsRequest,ListReusableDelegationSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
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
        public Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResources

        internal ListTagsForResourcesResponse ListTagsForResources(ListTagsForResourcesRequest request)
        {
            var marshaller = new ListTagsForResourcesRequestMarshaller();
            var unmarshaller = ListTagsForResourcesResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourcesRequest,ListTagsForResourcesResponse>(request, marshaller, unmarshaller);
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
        public Task<ListTagsForResourcesResponse> ListTagsForResourcesAsync(ListTagsForResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTagsForResourcesRequestMarshaller();
            var unmarshaller = ListTagsForResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourcesRequest,ListTagsForResourcesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTrafficPolicies

        internal ListTrafficPoliciesResponse ListTrafficPolicies(ListTrafficPoliciesRequest request)
        {
            var marshaller = new ListTrafficPoliciesRequestMarshaller();
            var unmarshaller = ListTrafficPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListTrafficPoliciesRequest,ListTrafficPoliciesResponse>(request, marshaller, unmarshaller);
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
        public Task<ListTrafficPoliciesResponse> ListTrafficPoliciesAsync(ListTrafficPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTrafficPoliciesRequestMarshaller();
            var unmarshaller = ListTrafficPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrafficPoliciesRequest,ListTrafficPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTrafficPolicyInstances

        internal ListTrafficPolicyInstancesResponse ListTrafficPolicyInstances(ListTrafficPolicyInstancesRequest request)
        {
            var marshaller = new ListTrafficPolicyInstancesRequestMarshaller();
            var unmarshaller = ListTrafficPolicyInstancesResponseUnmarshaller.Instance;

            return Invoke<ListTrafficPolicyInstancesRequest,ListTrafficPolicyInstancesResponse>(request, marshaller, unmarshaller);
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
        public Task<ListTrafficPolicyInstancesResponse> ListTrafficPolicyInstancesAsync(ListTrafficPolicyInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTrafficPolicyInstancesRequestMarshaller();
            var unmarshaller = ListTrafficPolicyInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrafficPolicyInstancesRequest,ListTrafficPolicyInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTrafficPolicyInstancesByHostedZone

        internal ListTrafficPolicyInstancesByHostedZoneResponse ListTrafficPolicyInstancesByHostedZone(ListTrafficPolicyInstancesByHostedZoneRequest request)
        {
            var marshaller = new ListTrafficPolicyInstancesByHostedZoneRequestMarshaller();
            var unmarshaller = ListTrafficPolicyInstancesByHostedZoneResponseUnmarshaller.Instance;

            return Invoke<ListTrafficPolicyInstancesByHostedZoneRequest,ListTrafficPolicyInstancesByHostedZoneResponse>(request, marshaller, unmarshaller);
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
        public Task<ListTrafficPolicyInstancesByHostedZoneResponse> ListTrafficPolicyInstancesByHostedZoneAsync(ListTrafficPolicyInstancesByHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTrafficPolicyInstancesByHostedZoneRequestMarshaller();
            var unmarshaller = ListTrafficPolicyInstancesByHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrafficPolicyInstancesByHostedZoneRequest,ListTrafficPolicyInstancesByHostedZoneResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTrafficPolicyInstancesByPolicy

        internal ListTrafficPolicyInstancesByPolicyResponse ListTrafficPolicyInstancesByPolicy(ListTrafficPolicyInstancesByPolicyRequest request)
        {
            var marshaller = new ListTrafficPolicyInstancesByPolicyRequestMarshaller();
            var unmarshaller = ListTrafficPolicyInstancesByPolicyResponseUnmarshaller.Instance;

            return Invoke<ListTrafficPolicyInstancesByPolicyRequest,ListTrafficPolicyInstancesByPolicyResponse>(request, marshaller, unmarshaller);
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
        public Task<ListTrafficPolicyInstancesByPolicyResponse> ListTrafficPolicyInstancesByPolicyAsync(ListTrafficPolicyInstancesByPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTrafficPolicyInstancesByPolicyRequestMarshaller();
            var unmarshaller = ListTrafficPolicyInstancesByPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrafficPolicyInstancesByPolicyRequest,ListTrafficPolicyInstancesByPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTrafficPolicyVersions

        internal ListTrafficPolicyVersionsResponse ListTrafficPolicyVersions(ListTrafficPolicyVersionsRequest request)
        {
            var marshaller = new ListTrafficPolicyVersionsRequestMarshaller();
            var unmarshaller = ListTrafficPolicyVersionsResponseUnmarshaller.Instance;

            return Invoke<ListTrafficPolicyVersionsRequest,ListTrafficPolicyVersionsResponse>(request, marshaller, unmarshaller);
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
        public Task<ListTrafficPolicyVersionsResponse> ListTrafficPolicyVersionsAsync(ListTrafficPolicyVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTrafficPolicyVersionsRequestMarshaller();
            var unmarshaller = ListTrafficPolicyVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrafficPolicyVersionsRequest,ListTrafficPolicyVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TestDNSAnswer

        internal TestDNSAnswerResponse TestDNSAnswer(TestDNSAnswerRequest request)
        {
            var marshaller = new TestDNSAnswerRequestMarshaller();
            var unmarshaller = TestDNSAnswerResponseUnmarshaller.Instance;

            return Invoke<TestDNSAnswerRequest,TestDNSAnswerResponse>(request, marshaller, unmarshaller);
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
        public Task<TestDNSAnswerResponse> TestDNSAnswerAsync(TestDNSAnswerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TestDNSAnswerRequestMarshaller();
            var unmarshaller = TestDNSAnswerResponseUnmarshaller.Instance;

            return InvokeAsync<TestDNSAnswerRequest,TestDNSAnswerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateHealthCheck

        internal UpdateHealthCheckResponse UpdateHealthCheck(UpdateHealthCheckRequest request)
        {
            var marshaller = new UpdateHealthCheckRequestMarshaller();
            var unmarshaller = UpdateHealthCheckResponseUnmarshaller.Instance;

            return Invoke<UpdateHealthCheckRequest,UpdateHealthCheckResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateHealthCheckResponse> UpdateHealthCheckAsync(UpdateHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateHealthCheckRequestMarshaller();
            var unmarshaller = UpdateHealthCheckResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateHealthCheckRequest,UpdateHealthCheckResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateHostedZoneComment

        internal UpdateHostedZoneCommentResponse UpdateHostedZoneComment(UpdateHostedZoneCommentRequest request)
        {
            var marshaller = new UpdateHostedZoneCommentRequestMarshaller();
            var unmarshaller = UpdateHostedZoneCommentResponseUnmarshaller.Instance;

            return Invoke<UpdateHostedZoneCommentRequest,UpdateHostedZoneCommentResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateHostedZoneCommentResponse> UpdateHostedZoneCommentAsync(UpdateHostedZoneCommentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateHostedZoneCommentRequestMarshaller();
            var unmarshaller = UpdateHostedZoneCommentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateHostedZoneCommentRequest,UpdateHostedZoneCommentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateTrafficPolicyComment

        internal UpdateTrafficPolicyCommentResponse UpdateTrafficPolicyComment(UpdateTrafficPolicyCommentRequest request)
        {
            var marshaller = new UpdateTrafficPolicyCommentRequestMarshaller();
            var unmarshaller = UpdateTrafficPolicyCommentResponseUnmarshaller.Instance;

            return Invoke<UpdateTrafficPolicyCommentRequest,UpdateTrafficPolicyCommentResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateTrafficPolicyCommentResponse> UpdateTrafficPolicyCommentAsync(UpdateTrafficPolicyCommentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateTrafficPolicyCommentRequestMarshaller();
            var unmarshaller = UpdateTrafficPolicyCommentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTrafficPolicyCommentRequest,UpdateTrafficPolicyCommentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateTrafficPolicyInstance

        internal UpdateTrafficPolicyInstanceResponse UpdateTrafficPolicyInstance(UpdateTrafficPolicyInstanceRequest request)
        {
            var marshaller = new UpdateTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = UpdateTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateTrafficPolicyInstanceRequest,UpdateTrafficPolicyInstanceResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateTrafficPolicyInstanceResponse> UpdateTrafficPolicyInstanceAsync(UpdateTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = UpdateTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTrafficPolicyInstanceRequest,UpdateTrafficPolicyInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}