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
 * Do not modify this file. This file is generated from the route53globalresolver-2022-09-27.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Route53GlobalResolver.Model;
using Amazon.Route53GlobalResolver.Model.Internal.MarshallTransformations;
using Amazon.Route53GlobalResolver.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.Route53GlobalResolver
{
    /// <summary>
    /// <para>Implementation for accessing Route53GlobalResolver</para>
    ///
    /// Amazon Route 53 Global Resolver is a global, internet-accessible DNS resolver that
    /// enables customers to resolve and forward traffic for both public and private domains
    /// while ensuring security and authenticity of queries over the internet. Route 53 Global
    /// Resolver supports DNS-over-port 53 (Do53), DNS-over-TLS (DoT), and DNS-over-HTTPS
    /// (DoH) protocols through global anycast IP addresses.
    /// </summary>
    public partial class AmazonRoute53GlobalResolverClient : AmazonServiceClient, IAmazonRoute53GlobalResolver
    {
        private static IServiceMetadata serviceMetadata = new AmazonRoute53GlobalResolverMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonRoute53GlobalResolverClient with the credentials loaded from the application's
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
        public AmazonRoute53GlobalResolverClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53GlobalResolverConfig()) { }

        /// <summary>
        /// Constructs AmazonRoute53GlobalResolverClient with the credentials loaded from the application's
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
        public AmazonRoute53GlobalResolverClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53GlobalResolverConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRoute53GlobalResolverClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRoute53GlobalResolverClient Configuration Object</param>
        public AmazonRoute53GlobalResolverClient(AmazonRoute53GlobalResolverConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonRoute53GlobalResolverClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRoute53GlobalResolverClient(AWSCredentials credentials)
            : this(credentials, new AmazonRoute53GlobalResolverConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53GlobalResolverClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53GlobalResolverClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRoute53GlobalResolverConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53GlobalResolverClient with AWS Credentials and an
        /// AmazonRoute53GlobalResolverClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRoute53GlobalResolverClient Configuration Object</param>
        public AmazonRoute53GlobalResolverClient(AWSCredentials credentials, AmazonRoute53GlobalResolverConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53GlobalResolverClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRoute53GlobalResolverClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53GlobalResolverConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53GlobalResolverClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53GlobalResolverClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53GlobalResolverConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53GlobalResolverClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53GlobalResolverClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRoute53GlobalResolverClient Configuration Object</param>
        public AmazonRoute53GlobalResolverClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRoute53GlobalResolverConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53GlobalResolverClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRoute53GlobalResolverClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53GlobalResolverConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53GlobalResolverClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53GlobalResolverClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53GlobalResolverConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53GlobalResolverClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53GlobalResolverClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRoute53GlobalResolverClient Configuration Object</param>
        public AmazonRoute53GlobalResolverClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRoute53GlobalResolverConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IRoute53GlobalResolverPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IRoute53GlobalResolverPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new Route53GlobalResolverPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

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
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRoute53GlobalResolverEndpointResolver());
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


        #region  AssociateHostedZone

        internal virtual AssociateHostedZoneResponse AssociateHostedZone(AssociateHostedZoneRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateHostedZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateHostedZoneResponseUnmarshaller.Instance;

            return Invoke<AssociateHostedZoneResponse>(request, options);
        }



        /// <summary>
        /// Associates a Route 53 private hosted zone with a Route 53 Global Resolver resource.
        /// This allows the resolver to resolve DNS queries for the private hosted zone from anywhere
        /// globally.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateHostedZone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateHostedZone service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ServiceQuotaExceededException">
        /// The request would exceed one or more service quotas. Check your current usage and
        /// quotas, then try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/AssociateHostedZone">REST API Reference for AssociateHostedZone Operation</seealso>
        public virtual Task<AssociateHostedZoneResponse> AssociateHostedZoneAsync(AssociateHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateHostedZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateHostedZoneResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchCreateFirewallRule

        internal virtual BatchCreateFirewallRuleResponse BatchCreateFirewallRule(BatchCreateFirewallRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateFirewallRuleResponseUnmarshaller.Instance;

            return Invoke<BatchCreateFirewallRuleResponse>(request, options);
        }



        /// <summary>
        /// Creates multiple DNS firewall rules in a single operation. This is more efficient
        /// than creating rules individually when you need to set up multiple rules at once.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateFirewallRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchCreateFirewallRule service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/BatchCreateFirewallRule">REST API Reference for BatchCreateFirewallRule Operation</seealso>
        public virtual Task<BatchCreateFirewallRuleResponse> BatchCreateFirewallRuleAsync(BatchCreateFirewallRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateFirewallRuleResponseUnmarshaller.Instance;

            return InvokeAsync<BatchCreateFirewallRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDeleteFirewallRule

        internal virtual BatchDeleteFirewallRuleResponse BatchDeleteFirewallRule(BatchDeleteFirewallRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteFirewallRuleResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteFirewallRuleResponse>(request, options);
        }



        /// <summary>
        /// Deletes multiple DNS firewall rules in a single operation. This is more efficient
        /// than deleting rules individually.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteFirewallRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteFirewallRule service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/BatchDeleteFirewallRule">REST API Reference for BatchDeleteFirewallRule Operation</seealso>
        public virtual Task<BatchDeleteFirewallRuleResponse> BatchDeleteFirewallRuleAsync(BatchDeleteFirewallRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteFirewallRuleResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteFirewallRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchUpdateFirewallRule

        internal virtual BatchUpdateFirewallRuleResponse BatchUpdateFirewallRule(BatchUpdateFirewallRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateFirewallRuleResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateFirewallRuleResponse>(request, options);
        }



        /// <summary>
        /// Updates multiple DNS firewall rules in a single operation. This is more efficient
        /// than updating rules individually.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateFirewallRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateFirewallRule service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/BatchUpdateFirewallRule">REST API Reference for BatchUpdateFirewallRule Operation</seealso>
        public virtual Task<BatchUpdateFirewallRuleResponse> BatchUpdateFirewallRuleAsync(BatchUpdateFirewallRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateFirewallRuleResponseUnmarshaller.Instance;

            return InvokeAsync<BatchUpdateFirewallRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAccessSource

        internal virtual CreateAccessSourceResponse CreateAccessSource(CreateAccessSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccessSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessSourceResponseUnmarshaller.Instance;

            return Invoke<CreateAccessSourceResponse>(request, options);
        }



        /// <summary>
        /// Creates an access source for a DNS view. Access sources define IP addresses or CIDR
        /// ranges that are allowed to send DNS queries to the Route 53 Global Resolver, along
        /// with the permitted DNS protocols.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessSource service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ServiceQuotaExceededException">
        /// The request would exceed one or more service quotas. Check your current usage and
        /// quotas, then try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateAccessSource">REST API Reference for CreateAccessSource Operation</seealso>
        public virtual Task<CreateAccessSourceResponse> CreateAccessSourceAsync(CreateAccessSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccessSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessSourceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAccessSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAccessToken

        internal virtual CreateAccessTokenResponse CreateAccessToken(CreateAccessTokenRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessTokenResponseUnmarshaller.Instance;

            return Invoke<CreateAccessTokenResponse>(request, options);
        }



        /// <summary>
        /// Creates an access token for a DNS view. Access tokens provide token-based authentication
        /// for DNS-over-HTTPS (DoH) and DNS-over-TLS (DoT) connections to the Route 53 Global
        /// Resolver.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessToken service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ServiceQuotaExceededException">
        /// The request would exceed one or more service quotas. Check your current usage and
        /// quotas, then try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateAccessToken">REST API Reference for CreateAccessToken Operation</seealso>
        public virtual Task<CreateAccessTokenResponse> CreateAccessTokenAsync(CreateAccessTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessTokenResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAccessTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDNSView

        internal virtual CreateDNSViewResponse CreateDNSView(CreateDNSViewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDNSViewResponseUnmarshaller.Instance;

            return Invoke<CreateDNSViewResponse>(request, options);
        }



        /// <summary>
        /// Creates a DNS view within a Route 53 Global Resolver. A DNS view models end users,
        /// user groups, networks, and devices, and serves as a parent resource that holds configurations
        /// controlling access, authorization, DNS firewall rules, and forwarding rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDNSView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDNSView service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ServiceQuotaExceededException">
        /// The request would exceed one or more service quotas. Check your current usage and
        /// quotas, then try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateDNSView">REST API Reference for CreateDNSView Operation</seealso>
        public virtual Task<CreateDNSViewResponse> CreateDNSViewAsync(CreateDNSViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDNSViewResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDNSViewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFirewallDomainList

        internal virtual CreateFirewallDomainListResponse CreateFirewallDomainList(CreateFirewallDomainListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFirewallDomainListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallDomainListResponseUnmarshaller.Instance;

            return Invoke<CreateFirewallDomainListResponse>(request, options);
        }



        /// <summary>
        /// Creates a firewall domain list. Domain lists are reusable sets of domain specifications
        /// that you use in DNS firewall rules to allow, block, or alert on DNS queries to specific
        /// domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewallDomainList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFirewallDomainList service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ServiceQuotaExceededException">
        /// The request would exceed one or more service quotas. Check your current usage and
        /// quotas, then try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateFirewallDomainList">REST API Reference for CreateFirewallDomainList Operation</seealso>
        public virtual Task<CreateFirewallDomainListResponse> CreateFirewallDomainListAsync(CreateFirewallDomainListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFirewallDomainListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallDomainListResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFirewallDomainListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFirewallRule

        internal virtual CreateFirewallRuleResponse CreateFirewallRule(CreateFirewallRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallRuleResponseUnmarshaller.Instance;

            return Invoke<CreateFirewallRuleResponse>(request, options);
        }



        /// <summary>
        /// Creates a DNS firewall rule. Firewall rules define actions (ALLOW, BLOCK, or ALERT)
        /// to take on DNS queries that match specified domain lists, managed domain lists, or
        /// advanced threat protections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewallRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFirewallRule service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ServiceQuotaExceededException">
        /// The request would exceed one or more service quotas. Check your current usage and
        /// quotas, then try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateFirewallRule">REST API Reference for CreateFirewallRule Operation</seealso>
        public virtual Task<CreateFirewallRuleResponse> CreateFirewallRuleAsync(CreateFirewallRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFirewallRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGlobalResolver

        internal virtual CreateGlobalResolverResponse CreateGlobalResolver(CreateGlobalResolverRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGlobalResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlobalResolverResponseUnmarshaller.Instance;

            return Invoke<CreateGlobalResolverResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Route 53 Global Resolver instance. A Route 53 Global Resolver is a global,
        /// internet-accessible DNS resolver that provides secure DNS resolution for both public
        /// and private domains through global anycast IP addresses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlobalResolver service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGlobalResolver service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ServiceQuotaExceededException">
        /// The request would exceed one or more service quotas. Check your current usage and
        /// quotas, then try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateGlobalResolver">REST API Reference for CreateGlobalResolver Operation</seealso>
        public virtual Task<CreateGlobalResolverResponse> CreateGlobalResolverAsync(CreateGlobalResolverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGlobalResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlobalResolverResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGlobalResolverResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccessSource

        internal virtual DeleteAccessSourceResponse DeleteAccessSource(DeleteAccessSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessSourceResponse>(request, options);
        }



        /// <summary>
        /// Deletes an access source. This operation cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessSource service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteAccessSource">REST API Reference for DeleteAccessSource Operation</seealso>
        public virtual Task<DeleteAccessSourceResponse> DeleteAccessSourceAsync(DeleteAccessSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessSourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAccessSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccessToken

        internal virtual DeleteAccessTokenResponse DeleteAccessToken(DeleteAccessTokenRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessTokenResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessTokenResponse>(request, options);
        }



        /// <summary>
        /// Deletes an access token. This operation cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessToken service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteAccessToken">REST API Reference for DeleteAccessToken Operation</seealso>
        public virtual Task<DeleteAccessTokenResponse> DeleteAccessTokenAsync(DeleteAccessTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessTokenResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAccessTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDNSView

        internal virtual DeleteDNSViewResponse DeleteDNSView(DeleteDNSViewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDNSViewResponseUnmarshaller.Instance;

            return Invoke<DeleteDNSViewResponse>(request, options);
        }



        /// <summary>
        /// Deletes a DNS view. This operation cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDNSView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDNSView service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteDNSView">REST API Reference for DeleteDNSView Operation</seealso>
        public virtual Task<DeleteDNSViewResponse> DeleteDNSViewAsync(DeleteDNSViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDNSViewResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDNSViewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFirewallDomainList

        internal virtual DeleteFirewallDomainListResponse DeleteFirewallDomainList(DeleteFirewallDomainListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFirewallDomainListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallDomainListResponseUnmarshaller.Instance;

            return Invoke<DeleteFirewallDomainListResponse>(request, options);
        }



        /// <summary>
        /// Deletes a firewall domain list. This operation cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallDomainList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFirewallDomainList service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteFirewallDomainList">REST API Reference for DeleteFirewallDomainList Operation</seealso>
        public virtual Task<DeleteFirewallDomainListResponse> DeleteFirewallDomainListAsync(DeleteFirewallDomainListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFirewallDomainListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallDomainListResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFirewallDomainListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFirewallRule

        internal virtual DeleteFirewallRuleResponse DeleteFirewallRule(DeleteFirewallRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteFirewallRuleResponse>(request, options);
        }



        /// <summary>
        /// Deletes a DNS firewall rule. This operation cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFirewallRule service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteFirewallRule">REST API Reference for DeleteFirewallRule Operation</seealso>
        public virtual Task<DeleteFirewallRuleResponse> DeleteFirewallRuleAsync(DeleteFirewallRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFirewallRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGlobalResolver

        internal virtual DeleteGlobalResolverResponse DeleteGlobalResolver(DeleteGlobalResolverRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGlobalResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlobalResolverResponseUnmarshaller.Instance;

            return Invoke<DeleteGlobalResolverResponse>(request, options);
        }



        /// <summary>
        /// Deletes a Route 53 Global Resolver instance. This operation cannot be undone. All
        /// associated DNS views, access sources, tokens, and firewall rules are also deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlobalResolver service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGlobalResolver service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteGlobalResolver">REST API Reference for DeleteGlobalResolver Operation</seealso>
        public virtual Task<DeleteGlobalResolverResponse> DeleteGlobalResolverAsync(DeleteGlobalResolverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGlobalResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlobalResolverResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGlobalResolverResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableDNSView

        internal virtual DisableDNSViewResponse DisableDNSView(DisableDNSViewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableDNSViewResponseUnmarshaller.Instance;

            return Invoke<DisableDNSViewResponse>(request, options);
        }



        /// <summary>
        /// Disables a DNS view, preventing it from serving DNS queries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDNSView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableDNSView service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DisableDNSView">REST API Reference for DisableDNSView Operation</seealso>
        public virtual Task<DisableDNSViewResponse> DisableDNSViewAsync(DisableDNSViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableDNSViewResponseUnmarshaller.Instance;

            return InvokeAsync<DisableDNSViewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateHostedZone

        internal virtual DisassociateHostedZoneResponse DisassociateHostedZone(DisassociateHostedZoneRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateHostedZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateHostedZoneResponseUnmarshaller.Instance;

            return Invoke<DisassociateHostedZoneResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a Route 53 private hosted zone from a Route 53 Global Resolver resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateHostedZone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateHostedZone service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DisassociateHostedZone">REST API Reference for DisassociateHostedZone Operation</seealso>
        public virtual Task<DisassociateHostedZoneResponse> DisassociateHostedZoneAsync(DisassociateHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateHostedZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateHostedZoneResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableDNSView

        internal virtual EnableDNSViewResponse EnableDNSView(EnableDNSViewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableDNSViewResponseUnmarshaller.Instance;

            return Invoke<EnableDNSViewResponse>(request, options);
        }



        /// <summary>
        /// Enables a disabled DNS view, allowing it to serve DNS queries again.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDNSView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableDNSView service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/EnableDNSView">REST API Reference for EnableDNSView Operation</seealso>
        public virtual Task<EnableDNSViewResponse> EnableDNSViewAsync(EnableDNSViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableDNSViewResponseUnmarshaller.Instance;

            return InvokeAsync<EnableDNSViewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccessSource

        internal virtual GetAccessSourceResponse GetAccessSource(GetAccessSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccessSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessSourceResponseUnmarshaller.Instance;

            return Invoke<GetAccessSourceResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about an access source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessSource service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetAccessSource">REST API Reference for GetAccessSource Operation</seealso>
        public virtual Task<GetAccessSourceResponse> GetAccessSourceAsync(GetAccessSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccessSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessSourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccessSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccessToken

        internal virtual GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessTokenResponseUnmarshaller.Instance;

            return Invoke<GetAccessTokenResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about an access token.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessToken service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetAccessToken">REST API Reference for GetAccessToken Operation</seealso>
        public virtual Task<GetAccessTokenResponse> GetAccessTokenAsync(GetAccessTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessTokenResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccessTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDNSView

        internal virtual GetDNSViewResponse GetDNSView(GetDNSViewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDNSViewResponseUnmarshaller.Instance;

            return Invoke<GetDNSViewResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a DNS view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDNSView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDNSView service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetDNSView">REST API Reference for GetDNSView Operation</seealso>
        public virtual Task<GetDNSViewResponse> GetDNSViewAsync(GetDNSViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDNSViewResponseUnmarshaller.Instance;

            return InvokeAsync<GetDNSViewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFirewallDomainList

        internal virtual GetFirewallDomainListResponse GetFirewallDomainList(GetFirewallDomainListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFirewallDomainListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFirewallDomainListResponseUnmarshaller.Instance;

            return Invoke<GetFirewallDomainListResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a firewall domain list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallDomainList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFirewallDomainList service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetFirewallDomainList">REST API Reference for GetFirewallDomainList Operation</seealso>
        public virtual Task<GetFirewallDomainListResponse> GetFirewallDomainListAsync(GetFirewallDomainListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFirewallDomainListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFirewallDomainListResponseUnmarshaller.Instance;

            return InvokeAsync<GetFirewallDomainListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFirewallRule

        internal virtual GetFirewallRuleResponse GetFirewallRule(GetFirewallRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFirewallRuleResponseUnmarshaller.Instance;

            return Invoke<GetFirewallRuleResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a DNS firewall rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFirewallRule service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetFirewallRule">REST API Reference for GetFirewallRule Operation</seealso>
        public virtual Task<GetFirewallRuleResponse> GetFirewallRuleAsync(GetFirewallRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFirewallRuleResponseUnmarshaller.Instance;

            return InvokeAsync<GetFirewallRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGlobalResolver

        internal virtual GetGlobalResolverResponse GetGlobalResolver(GetGlobalResolverRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGlobalResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlobalResolverResponseUnmarshaller.Instance;

            return Invoke<GetGlobalResolverResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a Route 53 Global Resolver instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlobalResolver service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGlobalResolver service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetGlobalResolver">REST API Reference for GetGlobalResolver Operation</seealso>
        public virtual Task<GetGlobalResolverResponse> GetGlobalResolverAsync(GetGlobalResolverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGlobalResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlobalResolverResponseUnmarshaller.Instance;

            return InvokeAsync<GetGlobalResolverResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetHostedZoneAssociation

        internal virtual GetHostedZoneAssociationResponse GetHostedZoneAssociation(GetHostedZoneAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetHostedZoneAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHostedZoneAssociationResponseUnmarshaller.Instance;

            return Invoke<GetHostedZoneAssociationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a hosted zone association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZoneAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHostedZoneAssociation service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetHostedZoneAssociation">REST API Reference for GetHostedZoneAssociation Operation</seealso>
        public virtual Task<GetHostedZoneAssociationResponse> GetHostedZoneAssociationAsync(GetHostedZoneAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetHostedZoneAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHostedZoneAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetHostedZoneAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetManagedFirewallDomainList

        internal virtual GetManagedFirewallDomainListResponse GetManagedFirewallDomainList(GetManagedFirewallDomainListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedFirewallDomainListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedFirewallDomainListResponseUnmarshaller.Instance;

            return Invoke<GetManagedFirewallDomainListResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about an AWS-managed firewall domain list. Managed domain lists
        /// contain domains associated with malicious activity, content categories, or specific
        /// threats.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedFirewallDomainList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetManagedFirewallDomainList service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetManagedFirewallDomainList">REST API Reference for GetManagedFirewallDomainList Operation</seealso>
        public virtual Task<GetManagedFirewallDomainListResponse> GetManagedFirewallDomainListAsync(GetManagedFirewallDomainListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedFirewallDomainListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedFirewallDomainListResponseUnmarshaller.Instance;

            return InvokeAsync<GetManagedFirewallDomainListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportFirewallDomains

        internal virtual ImportFirewallDomainsResponse ImportFirewallDomains(ImportFirewallDomainsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportFirewallDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportFirewallDomainsResponseUnmarshaller.Instance;

            return Invoke<ImportFirewallDomainsResponse>(request, options);
        }



        /// <summary>
        /// Imports a list of domains from an Amazon S3 file into a firewall domain list. The
        /// file should contain one domain per line.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportFirewallDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportFirewallDomains service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ImportFirewallDomains">REST API Reference for ImportFirewallDomains Operation</seealso>
        public virtual Task<ImportFirewallDomainsResponse> ImportFirewallDomainsAsync(ImportFirewallDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportFirewallDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportFirewallDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<ImportFirewallDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccessSources

        internal virtual ListAccessSourcesResponse ListAccessSources(ListAccessSourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessSourcesResponseUnmarshaller.Instance;

            return Invoke<ListAccessSourcesResponse>(request, options);
        }



        /// <summary>
        /// Lists all access sources with pagination support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessSources service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListAccessSources">REST API Reference for ListAccessSources Operation</seealso>
        public virtual Task<ListAccessSourcesResponse> ListAccessSourcesAsync(ListAccessSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessSourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccessSourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccessTokens

        internal virtual ListAccessTokensResponse ListAccessTokens(ListAccessTokensRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessTokensRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessTokensResponseUnmarshaller.Instance;

            return Invoke<ListAccessTokensResponse>(request, options);
        }



        /// <summary>
        /// Lists all access tokens for a DNS view with pagination support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessTokens service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessTokens service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListAccessTokens">REST API Reference for ListAccessTokens Operation</seealso>
        public virtual Task<ListAccessTokensResponse> ListAccessTokensAsync(ListAccessTokensRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessTokensRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessTokensResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccessTokensResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDNSViews

        internal virtual ListDNSViewsResponse ListDNSViews(ListDNSViewsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDNSViewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDNSViewsResponseUnmarshaller.Instance;

            return Invoke<ListDNSViewsResponse>(request, options);
        }



        /// <summary>
        /// Lists all DNS views for a Route 53 Global Resolver with pagination support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDNSViews service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDNSViews service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListDNSViews">REST API Reference for ListDNSViews Operation</seealso>
        public virtual Task<ListDNSViewsResponse> ListDNSViewsAsync(ListDNSViewsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDNSViewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDNSViewsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDNSViewsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFirewallDomainLists

        internal virtual ListFirewallDomainListsResponse ListFirewallDomainLists(ListFirewallDomainListsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFirewallDomainListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallDomainListsResponseUnmarshaller.Instance;

            return Invoke<ListFirewallDomainListsResponse>(request, options);
        }



        /// <summary>
        /// Lists all firewall domain lists for a Route 53 Global Resolver with pagination support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallDomainLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFirewallDomainLists service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListFirewallDomainLists">REST API Reference for ListFirewallDomainLists Operation</seealso>
        public virtual Task<ListFirewallDomainListsResponse> ListFirewallDomainListsAsync(ListFirewallDomainListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFirewallDomainListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallDomainListsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFirewallDomainListsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFirewallDomains

        internal virtual ListFirewallDomainsResponse ListFirewallDomains(ListFirewallDomainsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFirewallDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallDomainsResponseUnmarshaller.Instance;

            return Invoke<ListFirewallDomainsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the domains in DNS Firewall domain list you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFirewallDomains service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListFirewallDomains">REST API Reference for ListFirewallDomains Operation</seealso>
        public virtual Task<ListFirewallDomainsResponse> ListFirewallDomainsAsync(ListFirewallDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFirewallDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFirewallDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFirewallRules

        internal virtual ListFirewallRulesResponse ListFirewallRules(ListFirewallRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFirewallRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallRulesResponseUnmarshaller.Instance;

            return Invoke<ListFirewallRulesResponse>(request, options);
        }



        /// <summary>
        /// Lists all DNS firewall rules for a DNS view with pagination support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFirewallRules service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListFirewallRules">REST API Reference for ListFirewallRules Operation</seealso>
        public virtual Task<ListFirewallRulesResponse> ListFirewallRulesAsync(ListFirewallRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFirewallRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallRulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFirewallRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGlobalResolvers

        internal virtual ListGlobalResolversResponse ListGlobalResolvers(ListGlobalResolversRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGlobalResolversRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGlobalResolversResponseUnmarshaller.Instance;

            return Invoke<ListGlobalResolversResponse>(request, options);
        }



        /// <summary>
        /// Lists all Route 53 Global Resolver instances in your account with pagination support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGlobalResolvers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGlobalResolvers service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListGlobalResolvers">REST API Reference for ListGlobalResolvers Operation</seealso>
        public virtual Task<ListGlobalResolversResponse> ListGlobalResolversAsync(ListGlobalResolversRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGlobalResolversRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGlobalResolversResponseUnmarshaller.Instance;

            return InvokeAsync<ListGlobalResolversResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHostedZoneAssociations

        internal virtual ListHostedZoneAssociationsResponse ListHostedZoneAssociations(ListHostedZoneAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListHostedZoneAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHostedZoneAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListHostedZoneAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Lists all hosted zone associations for a Route 53 Global Resolver resource with pagination
        /// support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZoneAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHostedZoneAssociations service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListHostedZoneAssociations">REST API Reference for ListHostedZoneAssociations Operation</seealso>
        public virtual Task<ListHostedZoneAssociationsResponse> ListHostedZoneAssociationsAsync(ListHostedZoneAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListHostedZoneAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHostedZoneAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListHostedZoneAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListManagedFirewallDomainLists

        internal virtual ListManagedFirewallDomainListsResponse ListManagedFirewallDomainLists(ListManagedFirewallDomainListsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedFirewallDomainListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedFirewallDomainListsResponseUnmarshaller.Instance;

            return Invoke<ListManagedFirewallDomainListsResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of the AWS Managed DNS Lists and the categories for DNS Firewall.
        /// The categories are either <c>THREAT</c> or <c>CONTENT</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedFirewallDomainLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedFirewallDomainLists service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListManagedFirewallDomainLists">REST API Reference for ListManagedFirewallDomainLists Operation</seealso>
        public virtual Task<ListManagedFirewallDomainListsResponse> ListManagedFirewallDomainListsAsync(ListManagedFirewallDomainListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedFirewallDomainListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedFirewallDomainListsResponseUnmarshaller.Instance;

            return InvokeAsync<ListManagedFirewallDomainListsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags associated with a Route 53 Global Resolver resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds or updates tags for a Route 53 Global Resolver resource. Tags are key-value pairs
        /// that help you organize and identify your resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ServiceQuotaExceededException">
        /// The request would exceed one or more service quotas. Check your current usage and
        /// quotas, then try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes tags from a Route 53 Global Resolver resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAccessSource

        internal virtual UpdateAccessSourceResponse UpdateAccessSource(UpdateAccessSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccessSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateAccessSourceResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of an access source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccessSource service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ServiceQuotaExceededException">
        /// The request would exceed one or more service quotas. Check your current usage and
        /// quotas, then try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateAccessSource">REST API Reference for UpdateAccessSource Operation</seealso>
        public virtual Task<UpdateAccessSourceResponse> UpdateAccessSourceAsync(UpdateAccessSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccessSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessSourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAccessSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAccessToken

        internal virtual UpdateAccessTokenResponse UpdateAccessToken(UpdateAccessTokenRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessTokenResponseUnmarshaller.Instance;

            return Invoke<UpdateAccessTokenResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of an access token.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccessToken service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateAccessToken">REST API Reference for UpdateAccessToken Operation</seealso>
        public virtual Task<UpdateAccessTokenResponse> UpdateAccessTokenAsync(UpdateAccessTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessTokenResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAccessTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDNSView

        internal virtual UpdateDNSViewResponse UpdateDNSView(UpdateDNSViewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDNSViewResponseUnmarshaller.Instance;

            return Invoke<UpdateDNSViewResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of a DNS view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDNSView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDNSView service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateDNSView">REST API Reference for UpdateDNSView Operation</seealso>
        public virtual Task<UpdateDNSViewResponse> UpdateDNSViewAsync(UpdateDNSViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDNSViewResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDNSViewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFirewallDomains

        internal virtual UpdateFirewallDomainsResponse UpdateFirewallDomains(UpdateFirewallDomainsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallDomainsResponseUnmarshaller.Instance;

            return Invoke<UpdateFirewallDomainsResponse>(request, options);
        }



        /// <summary>
        /// Updates a DNS Firewall domain list from an array of specified domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFirewallDomains service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateFirewallDomains">REST API Reference for UpdateFirewallDomains Operation</seealso>
        public virtual Task<UpdateFirewallDomainsResponse> UpdateFirewallDomainsAsync(UpdateFirewallDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFirewallDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFirewallRule

        internal virtual UpdateFirewallRuleResponse UpdateFirewallRule(UpdateFirewallRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateFirewallRuleResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of a DNS firewall rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFirewallRule service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateFirewallRule">REST API Reference for UpdateFirewallRule Operation</seealso>
        public virtual Task<UpdateFirewallRuleResponse> UpdateFirewallRuleAsync(UpdateFirewallRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallRuleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFirewallRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGlobalResolver

        internal virtual UpdateGlobalResolverResponse UpdateGlobalResolver(UpdateGlobalResolverRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGlobalResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalResolverResponseUnmarshaller.Instance;

            return Invoke<UpdateGlobalResolverResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of a Route 53 Global Resolver instance. You can modify the
        /// name, description, and observability region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalResolver service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGlobalResolver service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateGlobalResolver">REST API Reference for UpdateGlobalResolver Operation</seealso>
        public virtual Task<UpdateGlobalResolverResponse> UpdateGlobalResolverAsync(UpdateGlobalResolverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGlobalResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalResolverResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGlobalResolverResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateHostedZoneAssociation

        internal virtual UpdateHostedZoneAssociationResponse UpdateHostedZoneAssociation(UpdateHostedZoneAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateHostedZoneAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHostedZoneAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateHostedZoneAssociationResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of a hosted zone association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHostedZoneAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateHostedZoneAssociation service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateHostedZoneAssociation">REST API Reference for UpdateHostedZoneAssociation Operation</seealso>
        public virtual Task<UpdateHostedZoneAssociationResponse> UpdateHostedZoneAssociationAsync(UpdateHostedZoneAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateHostedZoneAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHostedZoneAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateHostedZoneAssociationResponse>(request, options, cancellationToken);
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
            var resolver = new AmazonRoute53GlobalResolverEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}