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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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

        /// <summary>
        /// Associates a Route 53 private hosted zone with a Route 53 Global Resolver resource.
        /// This allows the resolver to resolve DNS queries for the private hosted zone from anywhere
        /// globally.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateHostedZone service method.</param>
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
        public virtual AssociateHostedZoneResponse AssociateHostedZone(AssociateHostedZoneRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateHostedZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateHostedZoneResponseUnmarshaller.Instance;

            return Invoke<AssociateHostedZoneResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateHostedZone operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateHostedZone
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/AssociateHostedZone">REST API Reference for AssociateHostedZone Operation</seealso>
        public virtual IAsyncResult BeginAssociateHostedZone(AssociateHostedZoneRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateHostedZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateHostedZoneResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateHostedZone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateHostedZone.</param>
        /// 
        /// <returns>Returns a  AssociateHostedZoneResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/AssociateHostedZone">REST API Reference for AssociateHostedZone Operation</seealso>
        public virtual AssociateHostedZoneResponse EndAssociateHostedZone(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateHostedZoneResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchCreateFirewallRule

        /// <summary>
        /// Creates multiple DNS firewall rules in a single operation. This is more efficient
        /// than creating rules individually when you need to set up multiple rules at once.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateFirewallRule service method.</param>
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
        public virtual BatchCreateFirewallRuleResponse BatchCreateFirewallRule(BatchCreateFirewallRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateFirewallRuleResponseUnmarshaller.Instance;

            return Invoke<BatchCreateFirewallRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateFirewallRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateFirewallRule operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateFirewallRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/BatchCreateFirewallRule">REST API Reference for BatchCreateFirewallRule Operation</seealso>
        public virtual IAsyncResult BeginBatchCreateFirewallRule(BatchCreateFirewallRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateFirewallRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateFirewallRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateFirewallRule.</param>
        /// 
        /// <returns>Returns a  BatchCreateFirewallRuleResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/BatchCreateFirewallRule">REST API Reference for BatchCreateFirewallRule Operation</seealso>
        public virtual BatchCreateFirewallRuleResponse EndBatchCreateFirewallRule(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchCreateFirewallRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDeleteFirewallRule

        /// <summary>
        /// Deletes multiple DNS firewall rules in a single operation. This is more efficient
        /// than deleting rules individually.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteFirewallRule service method.</param>
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
        public virtual BatchDeleteFirewallRuleResponse BatchDeleteFirewallRule(BatchDeleteFirewallRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteFirewallRuleResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteFirewallRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteFirewallRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteFirewallRule operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteFirewallRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/BatchDeleteFirewallRule">REST API Reference for BatchDeleteFirewallRule Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteFirewallRule(BatchDeleteFirewallRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteFirewallRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteFirewallRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteFirewallRule.</param>
        /// 
        /// <returns>Returns a  BatchDeleteFirewallRuleResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/BatchDeleteFirewallRule">REST API Reference for BatchDeleteFirewallRule Operation</seealso>
        public virtual BatchDeleteFirewallRuleResponse EndBatchDeleteFirewallRule(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteFirewallRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchUpdateFirewallRule

        /// <summary>
        /// Updates multiple DNS firewall rules in a single operation. This is more efficient
        /// than updating rules individually.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateFirewallRule service method.</param>
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
        public virtual BatchUpdateFirewallRuleResponse BatchUpdateFirewallRule(BatchUpdateFirewallRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateFirewallRuleResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateFirewallRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateFirewallRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateFirewallRule operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateFirewallRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/BatchUpdateFirewallRule">REST API Reference for BatchUpdateFirewallRule Operation</seealso>
        public virtual IAsyncResult BeginBatchUpdateFirewallRule(BatchUpdateFirewallRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateFirewallRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateFirewallRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateFirewallRule.</param>
        /// 
        /// <returns>Returns a  BatchUpdateFirewallRuleResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/BatchUpdateFirewallRule">REST API Reference for BatchUpdateFirewallRule Operation</seealso>
        public virtual BatchUpdateFirewallRuleResponse EndBatchUpdateFirewallRule(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchUpdateFirewallRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAccessSource

        /// <summary>
        /// Creates an access source for a DNS view. Access sources define IP addresses or CIDR
        /// ranges that are allowed to send DNS queries to the Route 53 Global Resolver, along
        /// with the permitted DNS protocols.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessSource service method.</param>
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
        public virtual CreateAccessSourceResponse CreateAccessSource(CreateAccessSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccessSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessSourceResponseUnmarshaller.Instance;

            return Invoke<CreateAccessSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessSource operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccessSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateAccessSource">REST API Reference for CreateAccessSource Operation</seealso>
        public virtual IAsyncResult BeginCreateAccessSource(CreateAccessSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccessSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccessSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccessSource.</param>
        /// 
        /// <returns>Returns a  CreateAccessSourceResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateAccessSource">REST API Reference for CreateAccessSource Operation</seealso>
        public virtual CreateAccessSourceResponse EndCreateAccessSource(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAccessSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAccessToken

        /// <summary>
        /// Creates an access token for a DNS view. Access tokens provide token-based authentication
        /// for DNS-over-HTTPS (DoH) and DNS-over-TLS (DoT) connections to the Route 53 Global
        /// Resolver.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessToken service method.</param>
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
        public virtual CreateAccessTokenResponse CreateAccessToken(CreateAccessTokenRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessTokenResponseUnmarshaller.Instance;

            return Invoke<CreateAccessTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessToken operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccessToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateAccessToken">REST API Reference for CreateAccessToken Operation</seealso>
        public virtual IAsyncResult BeginCreateAccessToken(CreateAccessTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccessToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccessToken.</param>
        /// 
        /// <returns>Returns a  CreateAccessTokenResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateAccessToken">REST API Reference for CreateAccessToken Operation</seealso>
        public virtual CreateAccessTokenResponse EndCreateAccessToken(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAccessTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDNSView

        /// <summary>
        /// Creates a DNS view within a Route 53 Global Resolver. A DNS view models end users,
        /// user groups, networks, and devices, and serves as a parent resource that holds configurations
        /// controlling access, authorization, DNS firewall rules, and forwarding rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDNSView service method.</param>
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
        public virtual CreateDNSViewResponse CreateDNSView(CreateDNSViewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDNSViewResponseUnmarshaller.Instance;

            return Invoke<CreateDNSViewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDNSView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDNSView operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDNSView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateDNSView">REST API Reference for CreateDNSView Operation</seealso>
        public virtual IAsyncResult BeginCreateDNSView(CreateDNSViewRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDNSViewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDNSView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDNSView.</param>
        /// 
        /// <returns>Returns a  CreateDNSViewResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateDNSView">REST API Reference for CreateDNSView Operation</seealso>
        public virtual CreateDNSViewResponse EndCreateDNSView(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDNSViewResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFirewallDomainList

        /// <summary>
        /// Creates a firewall domain list. Domain lists are reusable sets of domain specifications
        /// that you use in DNS firewall rules to allow, block, or alert on DNS queries to specific
        /// domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewallDomainList service method.</param>
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
        public virtual CreateFirewallDomainListResponse CreateFirewallDomainList(CreateFirewallDomainListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFirewallDomainListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallDomainListResponseUnmarshaller.Instance;

            return Invoke<CreateFirewallDomainListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFirewallDomainList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewallDomainList operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFirewallDomainList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateFirewallDomainList">REST API Reference for CreateFirewallDomainList Operation</seealso>
        public virtual IAsyncResult BeginCreateFirewallDomainList(CreateFirewallDomainListRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFirewallDomainListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallDomainListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFirewallDomainList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFirewallDomainList.</param>
        /// 
        /// <returns>Returns a  CreateFirewallDomainListResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateFirewallDomainList">REST API Reference for CreateFirewallDomainList Operation</seealso>
        public virtual CreateFirewallDomainListResponse EndCreateFirewallDomainList(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFirewallDomainListResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFirewallRule

        /// <summary>
        /// Creates a DNS firewall rule. Firewall rules define actions (ALLOW, BLOCK, or ALERT)
        /// to take on DNS queries that match specified domain lists, managed domain lists, or
        /// advanced threat protections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewallRule service method.</param>
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
        public virtual CreateFirewallRuleResponse CreateFirewallRule(CreateFirewallRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallRuleResponseUnmarshaller.Instance;

            return Invoke<CreateFirewallRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFirewallRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewallRule operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFirewallRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateFirewallRule">REST API Reference for CreateFirewallRule Operation</seealso>
        public virtual IAsyncResult BeginCreateFirewallRule(CreateFirewallRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFirewallRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFirewallRule.</param>
        /// 
        /// <returns>Returns a  CreateFirewallRuleResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateFirewallRule">REST API Reference for CreateFirewallRule Operation</seealso>
        public virtual CreateFirewallRuleResponse EndCreateFirewallRule(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFirewallRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGlobalResolver

        /// <summary>
        /// Creates a new Route 53 Global Resolver instance. A Route 53 Global Resolver is a global,
        /// internet-accessible DNS resolver that provides secure DNS resolution for both public
        /// and private domains through global anycast IP addresses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlobalResolver service method.</param>
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
        public virtual CreateGlobalResolverResponse CreateGlobalResolver(CreateGlobalResolverRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGlobalResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlobalResolverResponseUnmarshaller.Instance;

            return Invoke<CreateGlobalResolverResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGlobalResolver operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGlobalResolver operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGlobalResolver
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateGlobalResolver">REST API Reference for CreateGlobalResolver Operation</seealso>
        public virtual IAsyncResult BeginCreateGlobalResolver(CreateGlobalResolverRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGlobalResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlobalResolverResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGlobalResolver operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGlobalResolver.</param>
        /// 
        /// <returns>Returns a  CreateGlobalResolverResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateGlobalResolver">REST API Reference for CreateGlobalResolver Operation</seealso>
        public virtual CreateGlobalResolverResponse EndCreateGlobalResolver(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGlobalResolverResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAccessSource

        /// <summary>
        /// Deletes an access source. This operation cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessSource service method.</param>
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
        public virtual DeleteAccessSourceResponse DeleteAccessSource(DeleteAccessSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessSource operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteAccessSource">REST API Reference for DeleteAccessSource Operation</seealso>
        public virtual IAsyncResult BeginDeleteAccessSource(DeleteAccessSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessSource.</param>
        /// 
        /// <returns>Returns a  DeleteAccessSourceResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteAccessSource">REST API Reference for DeleteAccessSource Operation</seealso>
        public virtual DeleteAccessSourceResponse EndDeleteAccessSource(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAccessSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAccessToken

        /// <summary>
        /// Deletes an access token. This operation cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessToken service method.</param>
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
        public virtual DeleteAccessTokenResponse DeleteAccessToken(DeleteAccessTokenRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessTokenResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessToken operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteAccessToken">REST API Reference for DeleteAccessToken Operation</seealso>
        public virtual IAsyncResult BeginDeleteAccessToken(DeleteAccessTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessToken.</param>
        /// 
        /// <returns>Returns a  DeleteAccessTokenResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteAccessToken">REST API Reference for DeleteAccessToken Operation</seealso>
        public virtual DeleteAccessTokenResponse EndDeleteAccessToken(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAccessTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDNSView

        /// <summary>
        /// Deletes a DNS view. This operation cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDNSView service method.</param>
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
        public virtual DeleteDNSViewResponse DeleteDNSView(DeleteDNSViewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDNSViewResponseUnmarshaller.Instance;

            return Invoke<DeleteDNSViewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDNSView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDNSView operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDNSView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteDNSView">REST API Reference for DeleteDNSView Operation</seealso>
        public virtual IAsyncResult BeginDeleteDNSView(DeleteDNSViewRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDNSViewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDNSView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDNSView.</param>
        /// 
        /// <returns>Returns a  DeleteDNSViewResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteDNSView">REST API Reference for DeleteDNSView Operation</seealso>
        public virtual DeleteDNSViewResponse EndDeleteDNSView(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDNSViewResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFirewallDomainList

        /// <summary>
        /// Deletes a firewall domain list. This operation cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallDomainList service method.</param>
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
        public virtual DeleteFirewallDomainListResponse DeleteFirewallDomainList(DeleteFirewallDomainListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFirewallDomainListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallDomainListResponseUnmarshaller.Instance;

            return Invoke<DeleteFirewallDomainListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFirewallDomainList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallDomainList operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFirewallDomainList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteFirewallDomainList">REST API Reference for DeleteFirewallDomainList Operation</seealso>
        public virtual IAsyncResult BeginDeleteFirewallDomainList(DeleteFirewallDomainListRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFirewallDomainListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallDomainListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFirewallDomainList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFirewallDomainList.</param>
        /// 
        /// <returns>Returns a  DeleteFirewallDomainListResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteFirewallDomainList">REST API Reference for DeleteFirewallDomainList Operation</seealso>
        public virtual DeleteFirewallDomainListResponse EndDeleteFirewallDomainList(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFirewallDomainListResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFirewallRule

        /// <summary>
        /// Deletes a DNS firewall rule. This operation cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallRule service method.</param>
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
        public virtual DeleteFirewallRuleResponse DeleteFirewallRule(DeleteFirewallRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteFirewallRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFirewallRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallRule operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFirewallRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteFirewallRule">REST API Reference for DeleteFirewallRule Operation</seealso>
        public virtual IAsyncResult BeginDeleteFirewallRule(DeleteFirewallRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFirewallRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFirewallRule.</param>
        /// 
        /// <returns>Returns a  DeleteFirewallRuleResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteFirewallRule">REST API Reference for DeleteFirewallRule Operation</seealso>
        public virtual DeleteFirewallRuleResponse EndDeleteFirewallRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFirewallRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGlobalResolver

        /// <summary>
        /// Deletes a Route 53 Global Resolver instance. This operation cannot be undone. All
        /// associated DNS views, access sources, tokens, and firewall rules are also deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlobalResolver service method.</param>
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
        public virtual DeleteGlobalResolverResponse DeleteGlobalResolver(DeleteGlobalResolverRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGlobalResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlobalResolverResponseUnmarshaller.Instance;

            return Invoke<DeleteGlobalResolverResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGlobalResolver operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlobalResolver operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGlobalResolver
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteGlobalResolver">REST API Reference for DeleteGlobalResolver Operation</seealso>
        public virtual IAsyncResult BeginDeleteGlobalResolver(DeleteGlobalResolverRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGlobalResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlobalResolverResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGlobalResolver operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGlobalResolver.</param>
        /// 
        /// <returns>Returns a  DeleteGlobalResolverResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteGlobalResolver">REST API Reference for DeleteGlobalResolver Operation</seealso>
        public virtual DeleteGlobalResolverResponse EndDeleteGlobalResolver(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGlobalResolverResponse>(asyncResult);
        }

        #endregion
        
        #region  DisableDNSView

        /// <summary>
        /// Disables a DNS view, preventing it from serving DNS queries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDNSView service method.</param>
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
        public virtual DisableDNSViewResponse DisableDNSView(DisableDNSViewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableDNSViewResponseUnmarshaller.Instance;

            return Invoke<DisableDNSViewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableDNSView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableDNSView operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableDNSView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DisableDNSView">REST API Reference for DisableDNSView Operation</seealso>
        public virtual IAsyncResult BeginDisableDNSView(DisableDNSViewRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableDNSViewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableDNSView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableDNSView.</param>
        /// 
        /// <returns>Returns a  DisableDNSViewResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DisableDNSView">REST API Reference for DisableDNSView Operation</seealso>
        public virtual DisableDNSViewResponse EndDisableDNSView(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableDNSViewResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateHostedZone

        /// <summary>
        /// Disassociates a Route 53 private hosted zone from a Route 53 Global Resolver resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateHostedZone service method.</param>
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
        public virtual DisassociateHostedZoneResponse DisassociateHostedZone(DisassociateHostedZoneRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateHostedZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateHostedZoneResponseUnmarshaller.Instance;

            return Invoke<DisassociateHostedZoneResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateHostedZone operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateHostedZone
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DisassociateHostedZone">REST API Reference for DisassociateHostedZone Operation</seealso>
        public virtual IAsyncResult BeginDisassociateHostedZone(DisassociateHostedZoneRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateHostedZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateHostedZoneResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateHostedZone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateHostedZone.</param>
        /// 
        /// <returns>Returns a  DisassociateHostedZoneResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DisassociateHostedZone">REST API Reference for DisassociateHostedZone Operation</seealso>
        public virtual DisassociateHostedZoneResponse EndDisassociateHostedZone(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateHostedZoneResponse>(asyncResult);
        }

        #endregion
        
        #region  EnableDNSView

        /// <summary>
        /// Enables a disabled DNS view, allowing it to serve DNS queries again.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDNSView service method.</param>
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
        public virtual EnableDNSViewResponse EnableDNSView(EnableDNSViewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableDNSViewResponseUnmarshaller.Instance;

            return Invoke<EnableDNSViewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableDNSView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableDNSView operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableDNSView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/EnableDNSView">REST API Reference for EnableDNSView Operation</seealso>
        public virtual IAsyncResult BeginEnableDNSView(EnableDNSViewRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableDNSViewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableDNSView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableDNSView.</param>
        /// 
        /// <returns>Returns a  EnableDNSViewResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/EnableDNSView">REST API Reference for EnableDNSView Operation</seealso>
        public virtual EnableDNSViewResponse EndEnableDNSView(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableDNSViewResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccessSource

        /// <summary>
        /// Retrieves information about an access source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessSource service method.</param>
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
        public virtual GetAccessSourceResponse GetAccessSource(GetAccessSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccessSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessSourceResponseUnmarshaller.Instance;

            return Invoke<GetAccessSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessSource operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetAccessSource">REST API Reference for GetAccessSource Operation</seealso>
        public virtual IAsyncResult BeginGetAccessSource(GetAccessSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccessSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessSource.</param>
        /// 
        /// <returns>Returns a  GetAccessSourceResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetAccessSource">REST API Reference for GetAccessSource Operation</seealso>
        public virtual GetAccessSourceResponse EndGetAccessSource(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccessSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccessToken

        /// <summary>
        /// Retrieves information about an access token.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessToken service method.</param>
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
        public virtual GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessTokenResponseUnmarshaller.Instance;

            return Invoke<GetAccessTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessToken operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetAccessToken">REST API Reference for GetAccessToken Operation</seealso>
        public virtual IAsyncResult BeginGetAccessToken(GetAccessTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessToken.</param>
        /// 
        /// <returns>Returns a  GetAccessTokenResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetAccessToken">REST API Reference for GetAccessToken Operation</seealso>
        public virtual GetAccessTokenResponse EndGetAccessToken(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccessTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDNSView

        /// <summary>
        /// Retrieves information about a DNS view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDNSView service method.</param>
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
        public virtual GetDNSViewResponse GetDNSView(GetDNSViewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDNSViewResponseUnmarshaller.Instance;

            return Invoke<GetDNSViewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDNSView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDNSView operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDNSView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetDNSView">REST API Reference for GetDNSView Operation</seealso>
        public virtual IAsyncResult BeginGetDNSView(GetDNSViewRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDNSViewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDNSView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDNSView.</param>
        /// 
        /// <returns>Returns a  GetDNSViewResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetDNSView">REST API Reference for GetDNSView Operation</seealso>
        public virtual GetDNSViewResponse EndGetDNSView(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDNSViewResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFirewallDomainList

        /// <summary>
        /// Retrieves information about a firewall domain list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallDomainList service method.</param>
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
        public virtual GetFirewallDomainListResponse GetFirewallDomainList(GetFirewallDomainListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFirewallDomainListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFirewallDomainListResponseUnmarshaller.Instance;

            return Invoke<GetFirewallDomainListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFirewallDomainList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallDomainList operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFirewallDomainList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetFirewallDomainList">REST API Reference for GetFirewallDomainList Operation</seealso>
        public virtual IAsyncResult BeginGetFirewallDomainList(GetFirewallDomainListRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFirewallDomainListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFirewallDomainListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFirewallDomainList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFirewallDomainList.</param>
        /// 
        /// <returns>Returns a  GetFirewallDomainListResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetFirewallDomainList">REST API Reference for GetFirewallDomainList Operation</seealso>
        public virtual GetFirewallDomainListResponse EndGetFirewallDomainList(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFirewallDomainListResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFirewallRule

        /// <summary>
        /// Retrieves information about a DNS firewall rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallRule service method.</param>
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
        public virtual GetFirewallRuleResponse GetFirewallRule(GetFirewallRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFirewallRuleResponseUnmarshaller.Instance;

            return Invoke<GetFirewallRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFirewallRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallRule operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFirewallRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetFirewallRule">REST API Reference for GetFirewallRule Operation</seealso>
        public virtual IAsyncResult BeginGetFirewallRule(GetFirewallRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFirewallRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFirewallRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFirewallRule.</param>
        /// 
        /// <returns>Returns a  GetFirewallRuleResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetFirewallRule">REST API Reference for GetFirewallRule Operation</seealso>
        public virtual GetFirewallRuleResponse EndGetFirewallRule(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFirewallRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGlobalResolver

        /// <summary>
        /// Retrieves information about a Route 53 Global Resolver instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlobalResolver service method.</param>
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
        public virtual GetGlobalResolverResponse GetGlobalResolver(GetGlobalResolverRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGlobalResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlobalResolverResponseUnmarshaller.Instance;

            return Invoke<GetGlobalResolverResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGlobalResolver operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGlobalResolver operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGlobalResolver
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetGlobalResolver">REST API Reference for GetGlobalResolver Operation</seealso>
        public virtual IAsyncResult BeginGetGlobalResolver(GetGlobalResolverRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGlobalResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlobalResolverResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGlobalResolver operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGlobalResolver.</param>
        /// 
        /// <returns>Returns a  GetGlobalResolverResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetGlobalResolver">REST API Reference for GetGlobalResolver Operation</seealso>
        public virtual GetGlobalResolverResponse EndGetGlobalResolver(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGlobalResolverResponse>(asyncResult);
        }

        #endregion
        
        #region  GetHostedZoneAssociation

        /// <summary>
        /// Retrieves information about a hosted zone association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZoneAssociation service method.</param>
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
        public virtual GetHostedZoneAssociationResponse GetHostedZoneAssociation(GetHostedZoneAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetHostedZoneAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHostedZoneAssociationResponseUnmarshaller.Instance;

            return Invoke<GetHostedZoneAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetHostedZoneAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZoneAssociation operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHostedZoneAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetHostedZoneAssociation">REST API Reference for GetHostedZoneAssociation Operation</seealso>
        public virtual IAsyncResult BeginGetHostedZoneAssociation(GetHostedZoneAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetHostedZoneAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHostedZoneAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetHostedZoneAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHostedZoneAssociation.</param>
        /// 
        /// <returns>Returns a  GetHostedZoneAssociationResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetHostedZoneAssociation">REST API Reference for GetHostedZoneAssociation Operation</seealso>
        public virtual GetHostedZoneAssociationResponse EndGetHostedZoneAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetHostedZoneAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetManagedFirewallDomainList

        /// <summary>
        /// Retrieves information about an AWS-managed firewall domain list. Managed domain lists
        /// contain domains associated with malicious activity, content categories, or specific
        /// threats.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedFirewallDomainList service method.</param>
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
        public virtual GetManagedFirewallDomainListResponse GetManagedFirewallDomainList(GetManagedFirewallDomainListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedFirewallDomainListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedFirewallDomainListResponseUnmarshaller.Instance;

            return Invoke<GetManagedFirewallDomainListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetManagedFirewallDomainList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetManagedFirewallDomainList operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetManagedFirewallDomainList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetManagedFirewallDomainList">REST API Reference for GetManagedFirewallDomainList Operation</seealso>
        public virtual IAsyncResult BeginGetManagedFirewallDomainList(GetManagedFirewallDomainListRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedFirewallDomainListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedFirewallDomainListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetManagedFirewallDomainList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetManagedFirewallDomainList.</param>
        /// 
        /// <returns>Returns a  GetManagedFirewallDomainListResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetManagedFirewallDomainList">REST API Reference for GetManagedFirewallDomainList Operation</seealso>
        public virtual GetManagedFirewallDomainListResponse EndGetManagedFirewallDomainList(IAsyncResult asyncResult)
        {
            return EndInvoke<GetManagedFirewallDomainListResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportFirewallDomains

        /// <summary>
        /// Imports a list of domains from an Amazon S3 file into a firewall domain list. The
        /// file should contain one domain per line.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportFirewallDomains service method.</param>
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
        public virtual ImportFirewallDomainsResponse ImportFirewallDomains(ImportFirewallDomainsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportFirewallDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportFirewallDomainsResponseUnmarshaller.Instance;

            return Invoke<ImportFirewallDomainsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportFirewallDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportFirewallDomains operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportFirewallDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ImportFirewallDomains">REST API Reference for ImportFirewallDomains Operation</seealso>
        public virtual IAsyncResult BeginImportFirewallDomains(ImportFirewallDomainsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportFirewallDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportFirewallDomainsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportFirewallDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportFirewallDomains.</param>
        /// 
        /// <returns>Returns a  ImportFirewallDomainsResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ImportFirewallDomains">REST API Reference for ImportFirewallDomains Operation</seealso>
        public virtual ImportFirewallDomainsResponse EndImportFirewallDomains(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportFirewallDomainsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccessSources

        /// <summary>
        /// Lists all access sources with pagination support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessSources service method.</param>
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
        public virtual ListAccessSourcesResponse ListAccessSources(ListAccessSourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessSourcesResponseUnmarshaller.Instance;

            return Invoke<ListAccessSourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessSources operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListAccessSources">REST API Reference for ListAccessSources Operation</seealso>
        public virtual IAsyncResult BeginListAccessSources(ListAccessSourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessSourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessSources.</param>
        /// 
        /// <returns>Returns a  ListAccessSourcesResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListAccessSources">REST API Reference for ListAccessSources Operation</seealso>
        public virtual ListAccessSourcesResponse EndListAccessSources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccessSourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccessTokens

        /// <summary>
        /// Lists all access tokens for a DNS view with pagination support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessTokens service method.</param>
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
        public virtual ListAccessTokensResponse ListAccessTokens(ListAccessTokensRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessTokensRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessTokensResponseUnmarshaller.Instance;

            return Invoke<ListAccessTokensResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessTokens operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessTokens operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessTokens
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListAccessTokens">REST API Reference for ListAccessTokens Operation</seealso>
        public virtual IAsyncResult BeginListAccessTokens(ListAccessTokensRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessTokensRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessTokensResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessTokens operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessTokens.</param>
        /// 
        /// <returns>Returns a  ListAccessTokensResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListAccessTokens">REST API Reference for ListAccessTokens Operation</seealso>
        public virtual ListAccessTokensResponse EndListAccessTokens(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccessTokensResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDNSViews

        /// <summary>
        /// Lists all DNS views for a Route 53 Global Resolver with pagination support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDNSViews service method.</param>
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
        public virtual ListDNSViewsResponse ListDNSViews(ListDNSViewsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDNSViewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDNSViewsResponseUnmarshaller.Instance;

            return Invoke<ListDNSViewsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDNSViews operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDNSViews operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDNSViews
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListDNSViews">REST API Reference for ListDNSViews Operation</seealso>
        public virtual IAsyncResult BeginListDNSViews(ListDNSViewsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDNSViewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDNSViewsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDNSViews operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDNSViews.</param>
        /// 
        /// <returns>Returns a  ListDNSViewsResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListDNSViews">REST API Reference for ListDNSViews Operation</seealso>
        public virtual ListDNSViewsResponse EndListDNSViews(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDNSViewsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFirewallDomainLists

        /// <summary>
        /// Lists all firewall domain lists for a Route 53 Global Resolver with pagination support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallDomainLists service method.</param>
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
        public virtual ListFirewallDomainListsResponse ListFirewallDomainLists(ListFirewallDomainListsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFirewallDomainListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallDomainListsResponseUnmarshaller.Instance;

            return Invoke<ListFirewallDomainListsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFirewallDomainLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallDomainLists operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFirewallDomainLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListFirewallDomainLists">REST API Reference for ListFirewallDomainLists Operation</seealso>
        public virtual IAsyncResult BeginListFirewallDomainLists(ListFirewallDomainListsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFirewallDomainListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallDomainListsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFirewallDomainLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFirewallDomainLists.</param>
        /// 
        /// <returns>Returns a  ListFirewallDomainListsResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListFirewallDomainLists">REST API Reference for ListFirewallDomainLists Operation</seealso>
        public virtual ListFirewallDomainListsResponse EndListFirewallDomainLists(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFirewallDomainListsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFirewallDomains

        /// <summary>
        /// Lists all the domains in DNS Firewall domain list you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallDomains service method.</param>
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
        public virtual ListFirewallDomainsResponse ListFirewallDomains(ListFirewallDomainsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFirewallDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallDomainsResponseUnmarshaller.Instance;

            return Invoke<ListFirewallDomainsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFirewallDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallDomains operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFirewallDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListFirewallDomains">REST API Reference for ListFirewallDomains Operation</seealso>
        public virtual IAsyncResult BeginListFirewallDomains(ListFirewallDomainsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFirewallDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallDomainsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFirewallDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFirewallDomains.</param>
        /// 
        /// <returns>Returns a  ListFirewallDomainsResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListFirewallDomains">REST API Reference for ListFirewallDomains Operation</seealso>
        public virtual ListFirewallDomainsResponse EndListFirewallDomains(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFirewallDomainsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFirewallRules

        /// <summary>
        /// Lists all DNS firewall rules for a DNS view with pagination support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallRules service method.</param>
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
        public virtual ListFirewallRulesResponse ListFirewallRules(ListFirewallRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFirewallRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallRulesResponseUnmarshaller.Instance;

            return Invoke<ListFirewallRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFirewallRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallRules operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFirewallRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListFirewallRules">REST API Reference for ListFirewallRules Operation</seealso>
        public virtual IAsyncResult BeginListFirewallRules(ListFirewallRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFirewallRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFirewallRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFirewallRules.</param>
        /// 
        /// <returns>Returns a  ListFirewallRulesResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListFirewallRules">REST API Reference for ListFirewallRules Operation</seealso>
        public virtual ListFirewallRulesResponse EndListFirewallRules(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFirewallRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGlobalResolvers

        /// <summary>
        /// Lists all Route 53 Global Resolver instances in your account with pagination support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGlobalResolvers service method.</param>
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
        public virtual ListGlobalResolversResponse ListGlobalResolvers(ListGlobalResolversRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGlobalResolversRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGlobalResolversResponseUnmarshaller.Instance;

            return Invoke<ListGlobalResolversResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGlobalResolvers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGlobalResolvers operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGlobalResolvers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListGlobalResolvers">REST API Reference for ListGlobalResolvers Operation</seealso>
        public virtual IAsyncResult BeginListGlobalResolvers(ListGlobalResolversRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGlobalResolversRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGlobalResolversResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGlobalResolvers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGlobalResolvers.</param>
        /// 
        /// <returns>Returns a  ListGlobalResolversResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListGlobalResolvers">REST API Reference for ListGlobalResolvers Operation</seealso>
        public virtual ListGlobalResolversResponse EndListGlobalResolvers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGlobalResolversResponse>(asyncResult);
        }

        #endregion
        
        #region  ListHostedZoneAssociations

        /// <summary>
        /// Lists all hosted zone associations for a Route 53 Global Resolver resource with pagination
        /// support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZoneAssociations service method.</param>
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
        public virtual ListHostedZoneAssociationsResponse ListHostedZoneAssociations(ListHostedZoneAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListHostedZoneAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHostedZoneAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListHostedZoneAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListHostedZoneAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZoneAssociations operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHostedZoneAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListHostedZoneAssociations">REST API Reference for ListHostedZoneAssociations Operation</seealso>
        public virtual IAsyncResult BeginListHostedZoneAssociations(ListHostedZoneAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListHostedZoneAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHostedZoneAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListHostedZoneAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHostedZoneAssociations.</param>
        /// 
        /// <returns>Returns a  ListHostedZoneAssociationsResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListHostedZoneAssociations">REST API Reference for ListHostedZoneAssociations Operation</seealso>
        public virtual ListHostedZoneAssociationsResponse EndListHostedZoneAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListHostedZoneAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListManagedFirewallDomainLists

        /// <summary>
        /// Returns a paginated list of the AWS Managed DNS Lists and the categories for DNS Firewall.
        /// The categories are either <c>THREAT</c> or <c>CONTENT</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedFirewallDomainLists service method.</param>
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
        public virtual ListManagedFirewallDomainListsResponse ListManagedFirewallDomainLists(ListManagedFirewallDomainListsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedFirewallDomainListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedFirewallDomainListsResponseUnmarshaller.Instance;

            return Invoke<ListManagedFirewallDomainListsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListManagedFirewallDomainLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListManagedFirewallDomainLists operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListManagedFirewallDomainLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListManagedFirewallDomainLists">REST API Reference for ListManagedFirewallDomainLists Operation</seealso>
        public virtual IAsyncResult BeginListManagedFirewallDomainLists(ListManagedFirewallDomainListsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedFirewallDomainListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedFirewallDomainListsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedFirewallDomainLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedFirewallDomainLists.</param>
        /// 
        /// <returns>Returns a  ListManagedFirewallDomainListsResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListManagedFirewallDomainLists">REST API Reference for ListManagedFirewallDomainLists Operation</seealso>
        public virtual ListManagedFirewallDomainListsResponse EndListManagedFirewallDomainLists(IAsyncResult asyncResult)
        {
            return EndInvoke<ListManagedFirewallDomainListsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags associated with a Route 53 Global Resolver resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds or updates tags for a Route 53 Global Resolver resource. Tags are key-value pairs
        /// that help you organize and identify your resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from a Route 53 Global Resolver resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAccessSource

        /// <summary>
        /// Updates the configuration of an access source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessSource service method.</param>
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
        public virtual UpdateAccessSourceResponse UpdateAccessSource(UpdateAccessSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccessSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateAccessSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccessSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessSource operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccessSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateAccessSource">REST API Reference for UpdateAccessSource Operation</seealso>
        public virtual IAsyncResult BeginUpdateAccessSource(UpdateAccessSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccessSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccessSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccessSource.</param>
        /// 
        /// <returns>Returns a  UpdateAccessSourceResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateAccessSource">REST API Reference for UpdateAccessSource Operation</seealso>
        public virtual UpdateAccessSourceResponse EndUpdateAccessSource(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAccessSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAccessToken

        /// <summary>
        /// Updates the configuration of an access token.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessToken service method.</param>
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
        public virtual UpdateAccessTokenResponse UpdateAccessToken(UpdateAccessTokenRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessTokenResponseUnmarshaller.Instance;

            return Invoke<UpdateAccessTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccessToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessToken operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccessToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateAccessToken">REST API Reference for UpdateAccessToken Operation</seealso>
        public virtual IAsyncResult BeginUpdateAccessToken(UpdateAccessTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccessToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccessToken.</param>
        /// 
        /// <returns>Returns a  UpdateAccessTokenResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateAccessToken">REST API Reference for UpdateAccessToken Operation</seealso>
        public virtual UpdateAccessTokenResponse EndUpdateAccessToken(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAccessTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDNSView

        /// <summary>
        /// Updates the configuration of a DNS view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDNSView service method.</param>
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
        public virtual UpdateDNSViewResponse UpdateDNSView(UpdateDNSViewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDNSViewResponseUnmarshaller.Instance;

            return Invoke<UpdateDNSViewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDNSView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDNSView operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDNSView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateDNSView">REST API Reference for UpdateDNSView Operation</seealso>
        public virtual IAsyncResult BeginUpdateDNSView(UpdateDNSViewRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDNSViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDNSViewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDNSView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDNSView.</param>
        /// 
        /// <returns>Returns a  UpdateDNSViewResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateDNSView">REST API Reference for UpdateDNSView Operation</seealso>
        public virtual UpdateDNSViewResponse EndUpdateDNSView(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDNSViewResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFirewallDomains

        /// <summary>
        /// Updates a DNS Firewall domain list from an array of specified domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallDomains service method.</param>
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
        public virtual UpdateFirewallDomainsResponse UpdateFirewallDomains(UpdateFirewallDomainsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallDomainsResponseUnmarshaller.Instance;

            return Invoke<UpdateFirewallDomainsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFirewallDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallDomains operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFirewallDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateFirewallDomains">REST API Reference for UpdateFirewallDomains Operation</seealso>
        public virtual IAsyncResult BeginUpdateFirewallDomains(UpdateFirewallDomainsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallDomainsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFirewallDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFirewallDomains.</param>
        /// 
        /// <returns>Returns a  UpdateFirewallDomainsResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateFirewallDomains">REST API Reference for UpdateFirewallDomains Operation</seealso>
        public virtual UpdateFirewallDomainsResponse EndUpdateFirewallDomains(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFirewallDomainsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFirewallRule

        /// <summary>
        /// Updates the configuration of a DNS firewall rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallRule service method.</param>
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
        public virtual UpdateFirewallRuleResponse UpdateFirewallRule(UpdateFirewallRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateFirewallRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFirewallRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallRule operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFirewallRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateFirewallRule">REST API Reference for UpdateFirewallRule Operation</seealso>
        public virtual IAsyncResult BeginUpdateFirewallRule(UpdateFirewallRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFirewallRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFirewallRule.</param>
        /// 
        /// <returns>Returns a  UpdateFirewallRuleResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateFirewallRule">REST API Reference for UpdateFirewallRule Operation</seealso>
        public virtual UpdateFirewallRuleResponse EndUpdateFirewallRule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFirewallRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGlobalResolver

        /// <summary>
        /// Updates the configuration of a Route 53 Global Resolver instance. You can modify the
        /// name, description, and observability region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalResolver service method.</param>
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
        public virtual UpdateGlobalResolverResponse UpdateGlobalResolver(UpdateGlobalResolverRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGlobalResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalResolverResponseUnmarshaller.Instance;

            return Invoke<UpdateGlobalResolverResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGlobalResolver operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalResolver operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGlobalResolver
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateGlobalResolver">REST API Reference for UpdateGlobalResolver Operation</seealso>
        public virtual IAsyncResult BeginUpdateGlobalResolver(UpdateGlobalResolverRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGlobalResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalResolverResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGlobalResolver operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGlobalResolver.</param>
        /// 
        /// <returns>Returns a  UpdateGlobalResolverResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateGlobalResolver">REST API Reference for UpdateGlobalResolver Operation</seealso>
        public virtual UpdateGlobalResolverResponse EndUpdateGlobalResolver(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGlobalResolverResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateHostedZoneAssociation

        /// <summary>
        /// Updates the configuration of a hosted zone association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHostedZoneAssociation service method.</param>
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
        public virtual UpdateHostedZoneAssociationResponse UpdateHostedZoneAssociation(UpdateHostedZoneAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateHostedZoneAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHostedZoneAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateHostedZoneAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHostedZoneAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHostedZoneAssociation operation on AmazonRoute53GlobalResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateHostedZoneAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateHostedZoneAssociation">REST API Reference for UpdateHostedZoneAssociation Operation</seealso>
        public virtual IAsyncResult BeginUpdateHostedZoneAssociation(UpdateHostedZoneAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateHostedZoneAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHostedZoneAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateHostedZoneAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateHostedZoneAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateHostedZoneAssociationResult from Route53GlobalResolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateHostedZoneAssociation">REST API Reference for UpdateHostedZoneAssociation Operation</seealso>
        public virtual UpdateHostedZoneAssociationResponse EndUpdateHostedZoneAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateHostedZoneAssociationResponse>(asyncResult);
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