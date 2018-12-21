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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Route53Resolver.Model;
using Amazon.Route53Resolver.Model.Internal.MarshallTransformations;
using Amazon.Route53Resolver.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Route53Resolver
{
    /// <summary>
    /// Implementation for accessing Route53Resolver
    ///
    /// Here's how you set up to query an Amazon Route 53 private hosted zone from your network:
    /// 
    ///  <ol> <li> 
    /// <para>
    /// Connect your network to a VPC using AWS Direct Connect or a VPN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Run the following AWS CLI command to create a Resolver endpoint:
    /// </para>
    ///  
    /// <para>
    ///  <code>create-resolver-endpoint --name [endpoint_name] --direction INBOUND --creator-request-id
    /// [unique_string] --security-group-ids [security_group_with_inbound_rules] --ip-addresses
    /// SubnetId=[subnet_id] SubnetId=[subnet_id_in_different_AZ]</code> 
    /// </para>
    ///  
    /// <para>
    /// Note the resolver endpoint ID that appears in the response. You'll use it in step
    /// 3.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Get the IP addresses for the Resolver endpoints:
    /// </para>
    ///  
    /// <para>
    ///  <code>get-resolver-endpoint --resolver-endpoint-id [resolver_endpoint_id]</code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// In your network configuration, define the IP addresses that you got in step 3 as DNS
    /// servers.
    /// </para>
    ///  
    /// <para>
    /// You can now query instance names in your VPCs and the names of records in your private
    /// hosted zone.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// You can also perform the following operations using the AWS CLI:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>list-resolver-endpoints</code>: List all endpoints. The syntax includes options
    /// for pagination and filtering.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>update-resolver-endpoints</code>: Add IP addresses to an endpoint or remove
    /// IP addresses from an endpoint. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To delete an endpoint, use the following AWS CLI command:
    /// </para>
    ///  
    /// <para>
    ///  <code>delete-resolver-endpoint --resolver-endpoint-id [resolver_endpoint_id]</code>
    /// 
    /// </para>
    /// </summary>
    public partial class AmazonRoute53ResolverClient : AmazonServiceClient, IAmazonRoute53Resolver
    {
        private static IServiceMetadata serviceMetadata = new AmazonRoute53ResolverMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with the credentials loaded from the application's
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
        public AmazonRoute53ResolverClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53ResolverConfig()) { }

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with the credentials loaded from the application's
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
        public AmazonRoute53ResolverClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53ResolverConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRoute53ResolverClient Configuration Object</param>
        public AmazonRoute53ResolverClient(AmazonRoute53ResolverConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRoute53ResolverClient(AWSCredentials credentials)
            : this(credentials, new AmazonRoute53ResolverConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53ResolverClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRoute53ResolverConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with AWS Credentials and an
        /// AmazonRoute53ResolverClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRoute53ResolverClient Configuration Object</param>
        public AmazonRoute53ResolverClient(AWSCredentials credentials, AmazonRoute53ResolverConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRoute53ResolverClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53ResolverConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53ResolverClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53ResolverConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53ResolverClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRoute53ResolverClient Configuration Object</param>
        public AmazonRoute53ResolverClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRoute53ResolverConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRoute53ResolverClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53ResolverConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53ResolverClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53ResolverConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53ResolverClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRoute53ResolverClient Configuration Object</param>
        public AmazonRoute53ResolverClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRoute53ResolverConfig clientConfig)
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


        #region  AssociateResolverEndpointIpAddress


        /// <summary>
        /// Adds IP addresses to an inbound or an outbound resolver endpoint. If you want to adding
        /// more than one IP address, submit one <code>AssociateResolverEndpointIpAddress</code>
        /// request for each IP address.
        /// 
        ///  
        /// <para>
        /// To remove an IP address from an endpoint, see <a>DisassociateResolverEndpointIpAddress</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResolverEndpointIpAddress service method.</param>
        /// 
        /// <returns>The response from the AssociateResolverEndpointIpAddress service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceExistsException">
        /// The resource that you tried to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/AssociateResolverEndpointIpAddress">REST API Reference for AssociateResolverEndpointIpAddress Operation</seealso>
        public virtual AssociateResolverEndpointIpAddressResponse AssociateResolverEndpointIpAddress(AssociateResolverEndpointIpAddressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResolverEndpointIpAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResolverEndpointIpAddressResponseUnmarshaller.Instance;

            return Invoke<AssociateResolverEndpointIpAddressResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateResolverEndpointIpAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateResolverEndpointIpAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/AssociateResolverEndpointIpAddress">REST API Reference for AssociateResolverEndpointIpAddress Operation</seealso>
        public virtual Task<AssociateResolverEndpointIpAddressResponse> AssociateResolverEndpointIpAddressAsync(AssociateResolverEndpointIpAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResolverEndpointIpAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResolverEndpointIpAddressResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateResolverEndpointIpAddressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateResolverRule


        /// <summary>
        /// Associates a resolver rule with a VPC. When you associate a rule with a VPC, Resolver
        /// forwards all DNS queries for the domain name that is specified in the rule and that
        /// originate in the VPC. The queries are forwarded to the IP addresses for the DNS resolvers
        /// that are specified in the rule. For more information about rules, see <a>CreateResolverRule</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResolverRule service method.</param>
        /// 
        /// <returns>The response from the AssociateResolverRule service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceExistsException">
        /// The resource that you tried to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceUnavailableException">
        /// The specified resource isn't available.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/AssociateResolverRule">REST API Reference for AssociateResolverRule Operation</seealso>
        public virtual AssociateResolverRuleResponse AssociateResolverRule(AssociateResolverRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResolverRuleResponseUnmarshaller.Instance;

            return Invoke<AssociateResolverRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateResolverRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateResolverRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/AssociateResolverRule">REST API Reference for AssociateResolverRule Operation</seealso>
        public virtual Task<AssociateResolverRuleResponse> AssociateResolverRuleAsync(AssociateResolverRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResolverRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateResolverRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateResolverEndpoint


        /// <summary>
        /// Creates a resolver endpoint. There are two types of resolver endpoints, inbound and
        /// outbound:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// An <i>inbound resolver endpoint</i> forwards DNS queries to the DNS service for a
        /// VPC from your network or another VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An <i>outbound resolver endpoint</i> forwards DNS queries from the DNS service for
        /// a VPC to your network or another VPC.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResolverEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateResolverEndpoint service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceExistsException">
        /// The resource that you tried to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/CreateResolverEndpoint">REST API Reference for CreateResolverEndpoint Operation</seealso>
        public virtual CreateResolverEndpointResponse CreateResolverEndpoint(CreateResolverEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResolverEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResolverEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateResolverEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResolverEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResolverEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/CreateResolverEndpoint">REST API Reference for CreateResolverEndpoint Operation</seealso>
        public virtual Task<CreateResolverEndpointResponse> CreateResolverEndpointAsync(CreateResolverEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResolverEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResolverEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateResolverEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateResolverRule


        /// <summary>
        /// For DNS queries that originate in your VPCs, specifies which resolver endpoint the
        /// queries pass through, one domain name that you want to forward to your network, and
        /// the IP addresses of the DNS resolvers in your network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResolverRule service method.</param>
        /// 
        /// <returns>The response from the CreateResolverRule service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceExistsException">
        /// The resource that you tried to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceUnavailableException">
        /// The specified resource isn't available.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/CreateResolverRule">REST API Reference for CreateResolverRule Operation</seealso>
        public virtual CreateResolverRuleResponse CreateResolverRule(CreateResolverRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResolverRuleResponseUnmarshaller.Instance;

            return Invoke<CreateResolverRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResolverRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResolverRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/CreateResolverRule">REST API Reference for CreateResolverRule Operation</seealso>
        public virtual Task<CreateResolverRuleResponse> CreateResolverRuleAsync(CreateResolverRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResolverRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateResolverRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResolverEndpoint


        /// <summary>
        /// Deletes a resolver endpoint. The effect of deleting a resolver endpoint depends on
        /// whether it's an inbound or an outbound resolver endpoint:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>Inbound</b>: DNS queries from your network or another VPC are no longer routed
        /// to the DNS service for the specified VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Outbound</b>: DNS queries from a VPC are no longer routed to your network or to
        /// another VPC.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResolverEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteResolverEndpoint service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DeleteResolverEndpoint">REST API Reference for DeleteResolverEndpoint Operation</seealso>
        public virtual DeleteResolverEndpointResponse DeleteResolverEndpoint(DeleteResolverEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResolverEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResolverEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteResolverEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResolverEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResolverEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DeleteResolverEndpoint">REST API Reference for DeleteResolverEndpoint Operation</seealso>
        public virtual Task<DeleteResolverEndpointResponse> DeleteResolverEndpointAsync(DeleteResolverEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResolverEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResolverEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteResolverEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResolverRule


        /// <summary>
        /// Deletes a resolver rule. Before you can delete a resolver rule, you must disassociate
        /// it from all the VPCs that you associated the resolver rule with. For more infomation,
        /// see <a>DisassociateResolverRule</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResolverRule service method.</param>
        /// 
        /// <returns>The response from the DeleteResolverRule service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceInUseException">
        /// The resource that you tried to update or delete is currently in use.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DeleteResolverRule">REST API Reference for DeleteResolverRule Operation</seealso>
        public virtual DeleteResolverRuleResponse DeleteResolverRule(DeleteResolverRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResolverRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteResolverRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResolverRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResolverRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DeleteResolverRule">REST API Reference for DeleteResolverRule Operation</seealso>
        public virtual Task<DeleteResolverRuleResponse> DeleteResolverRuleAsync(DeleteResolverRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResolverRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteResolverRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateResolverEndpointIpAddress


        /// <summary>
        /// Removes IP addresses from an inbound or an outbound resolver endpoint. If you want
        /// to remove more than one IP address, submit one <code>DisassociateResolverEndpointIpAddress</code>
        /// request for each IP address.
        /// 
        ///  
        /// <para>
        /// To add an IP address to an endpoint, see <a>AssociateResolverEndpointIpAddress</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResolverEndpointIpAddress service method.</param>
        /// 
        /// <returns>The response from the DisassociateResolverEndpointIpAddress service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceExistsException">
        /// The resource that you tried to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DisassociateResolverEndpointIpAddress">REST API Reference for DisassociateResolverEndpointIpAddress Operation</seealso>
        public virtual DisassociateResolverEndpointIpAddressResponse DisassociateResolverEndpointIpAddress(DisassociateResolverEndpointIpAddressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResolverEndpointIpAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResolverEndpointIpAddressResponseUnmarshaller.Instance;

            return Invoke<DisassociateResolverEndpointIpAddressResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateResolverEndpointIpAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResolverEndpointIpAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DisassociateResolverEndpointIpAddress">REST API Reference for DisassociateResolverEndpointIpAddress Operation</seealso>
        public virtual Task<DisassociateResolverEndpointIpAddressResponse> DisassociateResolverEndpointIpAddressAsync(DisassociateResolverEndpointIpAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResolverEndpointIpAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResolverEndpointIpAddressResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateResolverEndpointIpAddressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateResolverRule


        /// <summary>
        /// Removes the association between a specified resolver rule and a specified VPC.
        /// 
        ///  <important> 
        /// <para>
        /// If you disassociate a resolver rule from a VPC, Resolver stops forwarding DNS queries
        /// for the domain name that you specified in the resolver rule. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResolverRule service method.</param>
        /// 
        /// <returns>The response from the DisassociateResolverRule service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DisassociateResolverRule">REST API Reference for DisassociateResolverRule Operation</seealso>
        public virtual DisassociateResolverRuleResponse DisassociateResolverRule(DisassociateResolverRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResolverRuleResponseUnmarshaller.Instance;

            return Invoke<DisassociateResolverRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateResolverRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResolverRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DisassociateResolverRule">REST API Reference for DisassociateResolverRule Operation</seealso>
        public virtual Task<DisassociateResolverRuleResponse> DisassociateResolverRuleAsync(DisassociateResolverRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResolverRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateResolverRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResolverEndpoint


        /// <summary>
        /// Gets information about a specified resolver endpoint, such as whether it's an inbound
        /// or an outbound resolver endpoint, and the current status of the endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolverEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetResolverEndpoint service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverEndpoint">REST API Reference for GetResolverEndpoint Operation</seealso>
        public virtual GetResolverEndpointResponse GetResolverEndpoint(GetResolverEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverEndpointResponseUnmarshaller.Instance;

            return Invoke<GetResolverEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResolverEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResolverEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverEndpoint">REST API Reference for GetResolverEndpoint Operation</seealso>
        public virtual Task<GetResolverEndpointResponse> GetResolverEndpointAsync(GetResolverEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetResolverEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResolverRule


        /// <summary>
        /// Gets information about a specified resolver rule, such as the domain name that the
        /// rule forwards DNS queries for and the ID of the outbound resolver endpoint that the
        /// rule is associated with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolverRule service method.</param>
        /// 
        /// <returns>The response from the GetResolverRule service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverRule">REST API Reference for GetResolverRule Operation</seealso>
        public virtual GetResolverRuleResponse GetResolverRule(GetResolverRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverRuleResponseUnmarshaller.Instance;

            return Invoke<GetResolverRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResolverRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResolverRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverRule">REST API Reference for GetResolverRule Operation</seealso>
        public virtual Task<GetResolverRuleResponse> GetResolverRuleAsync(GetResolverRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetResolverRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResolverRuleAssociation


        /// <summary>
        /// Gets information about an association between a specified resolver rule and a VPC.
        /// You associate a resolver rule and a VPC using <a>AssociateResolverRule</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolverRuleAssociation service method.</param>
        /// 
        /// <returns>The response from the GetResolverRuleAssociation service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverRuleAssociation">REST API Reference for GetResolverRuleAssociation Operation</seealso>
        public virtual GetResolverRuleAssociationResponse GetResolverRuleAssociation(GetResolverRuleAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverRuleAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverRuleAssociationResponseUnmarshaller.Instance;

            return Invoke<GetResolverRuleAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResolverRuleAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResolverRuleAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverRuleAssociation">REST API Reference for GetResolverRuleAssociation Operation</seealso>
        public virtual Task<GetResolverRuleAssociationResponse> GetResolverRuleAssociationAsync(GetResolverRuleAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverRuleAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverRuleAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetResolverRuleAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResolverRulePolicy


        /// <summary>
        /// Gets information about a resolver rule policy. A resolver rule policy specifies the
        /// Resolver operations and resources that you want to allow another AWS account to be
        /// able to use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolverRulePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResolverRulePolicy service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.UnknownResourceException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverRulePolicy">REST API Reference for GetResolverRulePolicy Operation</seealso>
        public virtual GetResolverRulePolicyResponse GetResolverRulePolicy(GetResolverRulePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverRulePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverRulePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResolverRulePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResolverRulePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResolverRulePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverRulePolicy">REST API Reference for GetResolverRulePolicy Operation</seealso>
        public virtual Task<GetResolverRulePolicyResponse> GetResolverRulePolicyAsync(GetResolverRulePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverRulePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverRulePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetResolverRulePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResolverEndpointIpAddresses


        /// <summary>
        /// Gets the IP addresses for a specified resolver endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolverEndpointIpAddresses service method.</param>
        /// 
        /// <returns>The response from the ListResolverEndpointIpAddresses service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidNextTokenException">
        /// The value that you specified for <code>NextToken</code> in a <code>List</code> request
        /// isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverEndpointIpAddresses">REST API Reference for ListResolverEndpointIpAddresses Operation</seealso>
        public virtual ListResolverEndpointIpAddressesResponse ListResolverEndpointIpAddresses(ListResolverEndpointIpAddressesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverEndpointIpAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverEndpointIpAddressesResponseUnmarshaller.Instance;

            return Invoke<ListResolverEndpointIpAddressesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResolverEndpointIpAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResolverEndpointIpAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverEndpointIpAddresses">REST API Reference for ListResolverEndpointIpAddresses Operation</seealso>
        public virtual Task<ListResolverEndpointIpAddressesResponse> ListResolverEndpointIpAddressesAsync(ListResolverEndpointIpAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverEndpointIpAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverEndpointIpAddressesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListResolverEndpointIpAddressesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResolverEndpoints


        /// <summary>
        /// Lists all the resolver endpoints that were created using the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolverEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListResolverEndpoints service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidNextTokenException">
        /// The value that you specified for <code>NextToken</code> in a <code>List</code> request
        /// isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverEndpoints">REST API Reference for ListResolverEndpoints Operation</seealso>
        public virtual ListResolverEndpointsResponse ListResolverEndpoints(ListResolverEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListResolverEndpointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResolverEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResolverEndpoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverEndpoints">REST API Reference for ListResolverEndpoints Operation</seealso>
        public virtual Task<ListResolverEndpointsResponse> ListResolverEndpointsAsync(ListResolverEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverEndpointsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListResolverEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResolverRuleAssociations


        /// <summary>
        /// Lists the associations that were created between resolver rules and VPCs using the
        /// current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolverRuleAssociations service method.</param>
        /// 
        /// <returns>The response from the ListResolverRuleAssociations service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidNextTokenException">
        /// The value that you specified for <code>NextToken</code> in a <code>List</code> request
        /// isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverRuleAssociations">REST API Reference for ListResolverRuleAssociations Operation</seealso>
        public virtual ListResolverRuleAssociationsResponse ListResolverRuleAssociations(ListResolverRuleAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverRuleAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverRuleAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListResolverRuleAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResolverRuleAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResolverRuleAssociations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverRuleAssociations">REST API Reference for ListResolverRuleAssociations Operation</seealso>
        public virtual Task<ListResolverRuleAssociationsResponse> ListResolverRuleAssociationsAsync(ListResolverRuleAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverRuleAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverRuleAssociationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListResolverRuleAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResolverRules


        /// <summary>
        /// Lists the resolver rules that were created using the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolverRules service method.</param>
        /// 
        /// <returns>The response from the ListResolverRules service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidNextTokenException">
        /// The value that you specified for <code>NextToken</code> in a <code>List</code> request
        /// isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverRules">REST API Reference for ListResolverRules Operation</seealso>
        public virtual ListResolverRulesResponse ListResolverRules(ListResolverRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverRulesResponseUnmarshaller.Instance;

            return Invoke<ListResolverRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResolverRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResolverRules operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverRules">REST API Reference for ListResolverRules Operation</seealso>
        public virtual Task<ListResolverRulesResponse> ListResolverRulesAsync(ListResolverRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverRulesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListResolverRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags that you associated with the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidNextTokenException">
        /// The value that you specified for <code>NextToken</code> in a <code>List</code> request
        /// isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutResolverRulePolicy


        /// <summary>
        /// Specifies the Resolver operations and resources that you want to allow another AWS
        /// account to be able to use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResolverRulePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResolverRulePolicy service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidPolicyDocumentException">
        /// The specified resolver rule policy is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.UnknownResourceException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/PutResolverRulePolicy">REST API Reference for PutResolverRulePolicy Operation</seealso>
        public virtual PutResolverRulePolicyResponse PutResolverRulePolicy(PutResolverRulePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResolverRulePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResolverRulePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResolverRulePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutResolverRulePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResolverRulePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/PutResolverRulePolicy">REST API Reference for PutResolverRulePolicy Operation</seealso>
        public virtual Task<PutResolverRulePolicyResponse> PutResolverRulePolicyAsync(PutResolverRulePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResolverRulePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResolverRulePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutResolverRulePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds one or more tags to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidTagException">
        /// The specified tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes one or more tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateResolverEndpoint


        /// <summary>
        /// Updates the name of an inbound or an outbound resolver endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolverEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateResolverEndpoint service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateResolverEndpoint">REST API Reference for UpdateResolverEndpoint Operation</seealso>
        public virtual UpdateResolverEndpointResponse UpdateResolverEndpoint(UpdateResolverEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResolverEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResolverEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateResolverEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResolverEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolverEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateResolverEndpoint">REST API Reference for UpdateResolverEndpoint Operation</seealso>
        public virtual Task<UpdateResolverEndpointResponse> UpdateResolverEndpointAsync(UpdateResolverEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResolverEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResolverEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateResolverEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateResolverRule


        /// <summary>
        /// Updates settings for a specified resolver rule. <code>ResolverRuleId</code> is required,
        /// and all other parameters are optional. If you don't specify a parameter, it retains
        /// its current value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolverRule service method.</param>
        /// 
        /// <returns>The response from the UpdateResolverRule service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceUnavailableException">
        /// The specified resource isn't available.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateResolverRule">REST API Reference for UpdateResolverRule Operation</seealso>
        public virtual UpdateResolverRuleResponse UpdateResolverRule(UpdateResolverRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResolverRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateResolverRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResolverRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolverRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateResolverRule">REST API Reference for UpdateResolverRule Operation</seealso>
        public virtual Task<UpdateResolverRuleResponse> UpdateResolverRuleAsync(UpdateResolverRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResolverRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateResolverRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}