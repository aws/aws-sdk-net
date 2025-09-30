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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CloudFront.Model;
using Amazon.CloudFront.Model.Internal.MarshallTransformations;
using Amazon.CloudFront.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.CloudFront
{
    /// <summary>
    /// <para>Implementation for accessing CloudFront</para>
    ///
    /// Amazon CloudFront 
    /// <para>
    /// This is the <i>Amazon CloudFront API Reference</i>. This guide is for developers who
    /// need detailed information about CloudFront API actions, data types, and errors. For
    /// detailed information about CloudFront features, see the <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Introduction.html">Amazon
    /// CloudFront Developer Guide</a>.
    /// 
    /// 
    /// </para>
    /// </summary>
    public partial class AmazonCloudFrontClient : AmazonServiceClient, IAmazonCloudFront
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudFrontMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudFrontClient with the credentials loaded from the application's
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
        public AmazonCloudFrontClient()
            : base(new AmazonCloudFrontConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with the credentials loaded from the application's
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
        public AmazonCloudFrontClient(RegionEndpoint region)
            : base(new AmazonCloudFrontConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudFrontClient Configuration Object</param>
        public AmazonCloudFrontClient(AmazonCloudFrontConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudFrontClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudFrontConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFrontClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudFrontConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Credentials and an
        /// AmazonCloudFrontClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudFrontClient Configuration Object</param>
        public AmazonCloudFrontClient(AWSCredentials credentials, AmazonCloudFrontConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFrontConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFrontConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFrontClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudFrontClient Configuration Object</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudFrontConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFrontConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFrontConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFrontClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudFrontClient Configuration Object</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudFrontConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ICloudFrontPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICloudFrontPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CloudFrontPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudFrontEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudFrontAuthSchemeHandler());
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


        #region  AssociateAlias

        internal virtual AssociateAliasResponse AssociateAlias(AssociateAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAliasResponseUnmarshaller.Instance;

            return Invoke<AssociateAliasResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// The <c>AssociateAlias</c> API operation only supports standard distributions. To move
        /// domains between distribution tenants and/or standard distributions, we recommend that
        /// you use the <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDomainAssociation.html">UpdateDomainAssociation</a>
        /// API operation instead.
        /// 
        ///  </note> 
        /// <para>
        /// Associates an alias with a CloudFront standard distribution. An alias is commonly
        /// known as a custom domain or vanity domain. It can also be called a CNAME or alternate
        /// domain name.
        /// </para>
        ///  
        /// <para>
        /// With this operation, you can move an alias that's already used for a standard distribution
        /// to a different standard distribution. This prevents the downtime that could occur
        /// if you first remove the alias from one standard distribution and then separately add
        /// the alias to another standard distribution.
        /// </para>
        ///  
        /// <para>
        /// To use this operation, specify the alias and the ID of the target standard distribution.
        /// </para>
        ///  
        /// <para>
        /// For more information, including how to set up the target standard distribution, prerequisites
        /// that you must complete, and other restrictions, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/CNAMEs.html#alternate-domain-names-move">Moving
        /// an alternate domain name to a different standard distribution or distribution tenant</a>
        /// in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateAlias service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/AssociateAlias">REST API Reference for AssociateAlias Operation</seealso>
        public virtual Task<AssociateAliasResponse> AssociateAliasAsync(AssociateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateDistributionTenantWebACL

        internal virtual AssociateDistributionTenantWebACLResponse AssociateDistributionTenantWebACL(AssociateDistributionTenantWebACLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateDistributionTenantWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDistributionTenantWebACLResponseUnmarshaller.Instance;

            return Invoke<AssociateDistributionTenantWebACLResponse>(request, options);
        }



        /// <summary>
        /// Associates the WAF web ACL with a distribution tenant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDistributionTenantWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateDistributionTenantWebACL service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/AssociateDistributionTenantWebACL">REST API Reference for AssociateDistributionTenantWebACL Operation</seealso>
        public virtual Task<AssociateDistributionTenantWebACLResponse> AssociateDistributionTenantWebACLAsync(AssociateDistributionTenantWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateDistributionTenantWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDistributionTenantWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateDistributionTenantWebACLResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateDistributionWebACL

        internal virtual AssociateDistributionWebACLResponse AssociateDistributionWebACL(AssociateDistributionWebACLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateDistributionWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDistributionWebACLResponseUnmarshaller.Instance;

            return Invoke<AssociateDistributionWebACLResponse>(request, options);
        }



        /// <summary>
        /// Associates the WAF web ACL with a distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDistributionWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateDistributionWebACL service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/AssociateDistributionWebACL">REST API Reference for AssociateDistributionWebACL Operation</seealso>
        public virtual Task<AssociateDistributionWebACLResponse> AssociateDistributionWebACLAsync(AssociateDistributionWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateDistributionWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDistributionWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateDistributionWebACLResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CopyDistribution

        internal virtual CopyDistributionResponse CopyDistribution(CopyDistributionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDistributionResponseUnmarshaller.Instance;

            return Invoke<CopyDistributionResponse>(request, options);
        }



        /// <summary>
        /// Creates a staging distribution using the configuration of the provided primary distribution.
        /// A staging distribution is a copy of an existing distribution (called the primary distribution)
        /// that you can use in a continuous deployment workflow.
        /// 
        ///  
        /// <para>
        /// After you create a staging distribution, you can use <c>UpdateDistribution</c> to
        /// modify the staging distribution's configuration. Then you can use <c>CreateContinuousDeploymentPolicy</c>
        /// to incrementally move traffic to the staging distribution.
        /// </para>
        ///  
        /// <para>
        /// This API operation requires the following IAM permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_GetDistribution.html">GetDistribution</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_CreateDistribution.html">CreateDistribution</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_CopyDistribution.html">CopyDistribution</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDistribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// The CNAME specified is already defined for CloudFront.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.DistributionAlreadyExistsException">
        /// The caller reference you attempted to create the distribution with is associated with
        /// another distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalFieldLevelEncryptionConfigAssociationWithCacheBehaviorException">
        /// The specified configuration for field-level encryption can't be associated with the
        /// specified cache behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidDefaultRootObjectException">
        /// The default root object file name is too big or contains an invalid character.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidErrorCodeException">
        /// An invalid error code was specified.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidForwardCookiesException">
        /// Your request contains forward cookies option which doesn't match with the expectation
        /// for the <c>whitelisted</c> list of cookie names. Either list of cookie names has been
        /// specified when not allowed or list of cookie names is missing when expected.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidFunctionAssociationException">
        /// A CloudFront function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidGeoRestrictionParameterException">
        /// The specified geo restriction parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidHeadersForS3OriginException">
        /// The headers specified are not valid for an Amazon S3 origin.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLambdaFunctionAssociationException">
        /// The specified Lambda@Edge function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLocationCodeException">
        /// The location code specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidMinimumProtocolVersionException">
        /// The minimum protocol version specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessControlException">
        /// The origin access control is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginException">
        /// The Amazon S3 origin server specified does not refer to a valid Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginKeepaliveTimeoutException">
        /// The keep alive timeout specified for the origin is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginReadTimeoutException">
        /// The read timeout specified for the origin is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidProtocolSettingsException">
        /// You cannot specify SSLv3 as the minimum protocol version if you only want to support
        /// only clients that support Server Name Indication (SNI).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidQueryStringParametersException">
        /// The query string parameters specified are not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or does not begin with a slash (/).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the <c>RequiredProtocols</c> element from your distribution
        /// configuration.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidResponseCodeException">
        /// A response code is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTTLOrderException">
        /// The TTL order specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidViewerCertificateException">
        /// A viewer certificate specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidWebACLIdException">
        /// A web ACL ID specified is not valid. To specify a web ACL created using the latest
        /// version of WAF, use the ACL ARN, for example <c>arn:aws:wafv2:us-east-1:123456789012:global/webacl/ExampleWebACL/473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// To specify a web ACL created using WAF Classic, use the ACL ID, for example <c>473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCachePolicyException">
        /// The cache policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginException">
        /// No origin exists with the specified <c>Origin Id</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginRequestPolicyException">
        /// The origin request policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchRealtimeLogConfigException">
        /// The real-time log configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResponseHeadersPolicyException">
        /// The response headers policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.RealtimeLogConfigOwnerMismatchException">
        /// The specified real-time log configuration belongs to a different Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCacheBehaviorsException">
        /// You cannot create more cache behaviors for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCertificatesException">
        /// You cannot create anymore custom SSL/TLS certificates.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCookieNamesInWhiteListException">
        /// Your request contains more cookie names in the whitelist than are allowed per cache
        /// behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToCachePolicyException">
        /// The maximum number of distributions have been associated with the specified cache
        /// policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToFieldLevelEncryptionConfigException">
        /// The maximum number of distributions have been associated with the specified configuration
        /// for field-level encryption.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToKeyGroupException">
        /// The number of distributions that reference this key group is more than the maximum
        /// allowed. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToOriginAccessControlException">
        /// The maximum number of distributions have been associated with the specified origin
        /// access control.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToOriginRequestPolicyException">
        /// The maximum number of distributions have been associated with the specified origin
        /// request policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToResponseHeadersPolicyException">
        /// The maximum number of distributions have been associated with the specified response
        /// headers policy.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsException">
        /// Processing your request would cause you to exceed the maximum number of distributions
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithFunctionAssociationsException">
        /// You have reached the maximum number of distributions that are associated with a CloudFront
        /// function. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithLambdaAssociationsException">
        /// Processing your request would cause the maximum number of distributions with Lambda@Edge
        /// function associations per owner to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithSingleFunctionARNException">
        /// The maximum number of distributions have been associated with the specified Lambda@Edge
        /// function.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFunctionAssociationsException">
        /// You have reached the maximum number of CloudFront function associations for this distribution.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInForwardedValuesException">
        /// Your request contains too many headers in forwarded values.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyKeyGroupsAssociatedToDistributionException">
        /// The number of key groups referenced by this distribution is more than the maximum
        /// allowed. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyLambdaFunctionAssociationsException">
        /// Your request contains more Lambda@Edge function associations than are allowed per
        /// distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginCustomHeadersException">
        /// Your request contains too many origin custom headers.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginGroupsPerDistributionException">
        /// Processing your request would cause you to exceed the maximum number of origin groups
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginsException">
        /// You cannot create more origins for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringParametersException">
        /// Your request contains too many query string parameters.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedKeyGroupDoesNotExistException">
        /// The specified key group does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CopyDistribution">REST API Reference for CopyDistribution Operation</seealso>
        public virtual Task<CopyDistributionResponse> CopyDistributionAsync(CopyDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<CopyDistributionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAnycastIpList

        internal virtual CreateAnycastIpListResponse CreateAnycastIpList(CreateAnycastIpListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAnycastIpListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnycastIpListResponseUnmarshaller.Instance;

            return Invoke<CreateAnycastIpListResponse>(request, options);
        }



        /// <summary>
        /// Creates an Anycast static IP list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnycastIpList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAnycastIpList service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityAlreadyExistsException">
        /// The entity already exists. You must provide a unique entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityLimitExceededException">
        /// The entity limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// The tagging specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateAnycastIpList">REST API Reference for CreateAnycastIpList Operation</seealso>
        public virtual Task<CreateAnycastIpListResponse> CreateAnycastIpListAsync(CreateAnycastIpListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAnycastIpListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnycastIpListResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAnycastIpListResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCachePolicy

        internal virtual CreateCachePolicyResponse CreateCachePolicy(CreateCachePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCachePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCachePolicyResponseUnmarshaller.Instance;

            return Invoke<CreateCachePolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates a cache policy.
        /// 
        ///  
        /// <para>
        /// After you create a cache policy, you can attach it to one or more cache behaviors.
        /// When it's attached to a cache behavior, the cache policy determines the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The values that CloudFront includes in the <i>cache key</i>. These values can include
        /// HTTP headers, cookies, and URL query strings. CloudFront uses the cache key to find
        /// an object in its cache that it can return to the viewer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The default, minimum, and maximum time to live (TTL) values that you want objects
        /// to stay in the CloudFront cache.
        /// </para>
        ///  <important> 
        /// <para>
        /// If your minimum TTL is greater than 0, CloudFront will cache content for at least
        /// the duration specified in the cache policy's minimum TTL, even if the <c>Cache-Control:
        /// no-cache</c>, <c>no-store</c>, or <c>private</c> directives are present in the origin
        /// headers.
        /// </para>
        ///  </important> </li> </ul> 
        /// <para>
        /// The headers, cookies, and query strings that are included in the cache key are also
        /// included in requests that CloudFront sends to the origin. CloudFront sends a request
        /// when it can't find an object in its cache that matches the request's cache key. If
        /// you want to send values to the origin but <i>not</i> include them in the cache key,
        /// use <c>OriginRequestPolicy</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about cache policies, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-the-cache-key.html">Controlling
        /// the cache key</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCachePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCachePolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CachePolicyAlreadyExistsException">
        /// A cache policy with this name already exists. You must provide a unique name. To modify
        /// an existing cache policy, use <c>UpdateCachePolicy</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCachePoliciesException">
        /// You have reached the maximum number of cache policies for this Amazon Web Services
        /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCookiesInCachePolicyException">
        /// The number of cookies in the cache policy exceeds the maximum. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInCachePolicyException">
        /// The number of headers in the cache policy exceeds the maximum. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringsInCachePolicyException">
        /// The number of query strings in the cache policy exceeds the maximum. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateCachePolicy">REST API Reference for CreateCachePolicy Operation</seealso>
        public virtual Task<CreateCachePolicyResponse> CreateCachePolicyAsync(CreateCachePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCachePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCachePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCachePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCloudFrontOriginAccessIdentity

        internal virtual CreateCloudFrontOriginAccessIdentityResponse CreateCloudFrontOriginAccessIdentity(CreateCloudFrontOriginAccessIdentityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return Invoke<CreateCloudFrontOriginAccessIdentityResponse>(request, options);
        }



        /// <summary>
        /// Creates a new origin access identity. If you're using Amazon S3 for your origin, you
        /// can use an origin access identity to require users to access your content using a
        /// CloudFront URL instead of the Amazon S3 URL. For more information about how to use
        /// origin access identities, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">Serving
        /// Private Content through CloudFront</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFrontOriginAccessIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.CloudFrontOriginAccessIdentityAlreadyExistsException">
        /// If the <c>CallerReference</c> is a value you already sent in a previous request to
        /// create an identity but the content of the <c>CloudFrontOriginAccessIdentityConfig</c>
        /// is different from the original request, CloudFront returns a <c>CloudFrontOriginAccessIdentityAlreadyExists</c>
        /// error.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCloudFrontOriginAccessIdentitiesException">
        /// Processing your request would cause you to exceed the maximum number of origin access
        /// identities allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateCloudFrontOriginAccessIdentity">REST API Reference for CreateCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual Task<CreateCloudFrontOriginAccessIdentityResponse> CreateCloudFrontOriginAccessIdentityAsync(CreateCloudFrontOriginAccessIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCloudFrontOriginAccessIdentityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateConnectionGroup

        internal virtual CreateConnectionGroupResponse CreateConnectionGroup(CreateConnectionGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionGroupResponseUnmarshaller.Instance;

            return Invoke<CreateConnectionGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a connection group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnectionGroup service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityAlreadyExistsException">
        /// The entity already exists. You must provide a unique entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityLimitExceededException">
        /// The entity limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// The tagging specified is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateConnectionGroup">REST API Reference for CreateConnectionGroup Operation</seealso>
        public virtual Task<CreateConnectionGroupResponse> CreateConnectionGroupAsync(CreateConnectionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConnectionGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateContinuousDeploymentPolicy

        internal virtual CreateContinuousDeploymentPolicyResponse CreateContinuousDeploymentPolicy(CreateContinuousDeploymentPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContinuousDeploymentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContinuousDeploymentPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateContinuousDeploymentPolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates a continuous deployment policy that distributes traffic for a custom domain
        /// name to two different CloudFront distributions.
        /// 
        ///  
        /// <para>
        /// To use a continuous deployment policy, first use <c>CopyDistribution</c> to create
        /// a staging distribution, then use <c>UpdateDistribution</c> to modify the staging distribution's
        /// configuration.
        /// </para>
        ///  
        /// <para>
        /// After you create and update a staging distribution, you can use a continuous deployment
        /// policy to incrementally move traffic to the staging distribution. This workflow enables
        /// you to test changes to a distribution's configuration before moving all of your domain's
        /// production traffic to the new configuration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContinuousDeploymentPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateContinuousDeploymentPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ContinuousDeploymentPolicyAlreadyExistsException">
        /// A continuous deployment policy with this configuration already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StagingDistributionInUseException">
        /// A continuous deployment policy for this staging distribution already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyContinuousDeploymentPoliciesException">
        /// You have reached the maximum number of continuous deployment policies for this Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateContinuousDeploymentPolicy">REST API Reference for CreateContinuousDeploymentPolicy Operation</seealso>
        public virtual Task<CreateContinuousDeploymentPolicyResponse> CreateContinuousDeploymentPolicyAsync(CreateContinuousDeploymentPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContinuousDeploymentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContinuousDeploymentPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateContinuousDeploymentPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDistribution

        internal virtual CreateDistributionResponse CreateDistribution(CreateDistributionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDistributionResponseUnmarshaller.Instance;

            return Invoke<CreateDistributionResponse>(request, options);
        }



        /// <summary>
        /// Creates a CloudFront distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDistribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// The CNAME specified is already defined for CloudFront.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ContinuousDeploymentPolicyInUseException">
        /// You cannot delete a continuous deployment policy that is associated with a primary
        /// distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.DistributionAlreadyExistsException">
        /// The caller reference you attempted to create the distribution with is associated with
        /// another distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityLimitExceededException">
        /// The entity limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalFieldLevelEncryptionConfigAssociationWithCacheBehaviorException">
        /// The specified configuration for field-level encryption can't be associated with the
        /// specified cache behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalOriginAccessConfigurationException">
        /// An origin cannot contain both an origin access control (OAC) and an origin access
        /// identity (OAI).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidDefaultRootObjectException">
        /// The default root object file name is too big or contains an invalid character.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidDomainNameForOriginAccessControlException">
        /// An origin access control is associated with an origin whose domain name is not supported.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidErrorCodeException">
        /// An invalid error code was specified.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidForwardCookiesException">
        /// Your request contains forward cookies option which doesn't match with the expectation
        /// for the <c>whitelisted</c> list of cookie names. Either list of cookie names has been
        /// specified when not allowed or list of cookie names is missing when expected.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidFunctionAssociationException">
        /// A CloudFront function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidGeoRestrictionParameterException">
        /// The specified geo restriction parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidHeadersForS3OriginException">
        /// The headers specified are not valid for an Amazon S3 origin.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLambdaFunctionAssociationException">
        /// The specified Lambda@Edge function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLocationCodeException">
        /// The location code specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidMinimumProtocolVersionException">
        /// The minimum protocol version specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessControlException">
        /// The origin access control is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginException">
        /// The Amazon S3 origin server specified does not refer to a valid Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginKeepaliveTimeoutException">
        /// The keep alive timeout specified for the origin is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginReadTimeoutException">
        /// The read timeout specified for the origin is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidProtocolSettingsException">
        /// You cannot specify SSLv3 as the minimum protocol version if you only want to support
        /// only clients that support Server Name Indication (SNI).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidQueryStringParametersException">
        /// The query string parameters specified are not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or does not begin with a slash (/).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the <c>RequiredProtocols</c> element from your distribution
        /// configuration.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidResponseCodeException">
        /// A response code is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTTLOrderException">
        /// The TTL order specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidViewerCertificateException">
        /// A viewer certificate specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidWebACLIdException">
        /// A web ACL ID specified is not valid. To specify a web ACL created using the latest
        /// version of WAF, use the ACL ARN, for example <c>arn:aws:wafv2:us-east-1:123456789012:global/webacl/ExampleWebACL/473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// To specify a web ACL created using WAF Classic, use the ACL ID, for example <c>473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCachePolicyException">
        /// The cache policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchContinuousDeploymentPolicyException">
        /// The continuous deployment policy doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginException">
        /// No origin exists with the specified <c>Origin Id</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginRequestPolicyException">
        /// The origin request policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchRealtimeLogConfigException">
        /// The real-time log configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResponseHeadersPolicyException">
        /// The response headers policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.RealtimeLogConfigOwnerMismatchException">
        /// The specified real-time log configuration belongs to a different Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCacheBehaviorsException">
        /// You cannot create more cache behaviors for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCertificatesException">
        /// You cannot create anymore custom SSL/TLS certificates.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCookieNamesInWhiteListException">
        /// Your request contains more cookie names in the whitelist than are allowed per cache
        /// behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToCachePolicyException">
        /// The maximum number of distributions have been associated with the specified cache
        /// policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToFieldLevelEncryptionConfigException">
        /// The maximum number of distributions have been associated with the specified configuration
        /// for field-level encryption.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToKeyGroupException">
        /// The number of distributions that reference this key group is more than the maximum
        /// allowed. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToOriginAccessControlException">
        /// The maximum number of distributions have been associated with the specified origin
        /// access control.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToOriginRequestPolicyException">
        /// The maximum number of distributions have been associated with the specified origin
        /// request policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToResponseHeadersPolicyException">
        /// The maximum number of distributions have been associated with the specified response
        /// headers policy.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsException">
        /// Processing your request would cause you to exceed the maximum number of distributions
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithFunctionAssociationsException">
        /// You have reached the maximum number of distributions that are associated with a CloudFront
        /// function. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithLambdaAssociationsException">
        /// Processing your request would cause the maximum number of distributions with Lambda@Edge
        /// function associations per owner to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithSingleFunctionARNException">
        /// The maximum number of distributions have been associated with the specified Lambda@Edge
        /// function.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFunctionAssociationsException">
        /// You have reached the maximum number of CloudFront function associations for this distribution.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInForwardedValuesException">
        /// Your request contains too many headers in forwarded values.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyKeyGroupsAssociatedToDistributionException">
        /// The number of key groups referenced by this distribution is more than the maximum
        /// allowed. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyLambdaFunctionAssociationsException">
        /// Your request contains more Lambda@Edge function associations than are allowed per
        /// distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginCustomHeadersException">
        /// Your request contains too many origin custom headers.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginGroupsPerDistributionException">
        /// Processing your request would cause you to exceed the maximum number of origin groups
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginsException">
        /// You cannot create more origins for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringParametersException">
        /// Your request contains too many query string parameters.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedKeyGroupDoesNotExistException">
        /// The specified key group does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateDistribution">REST API Reference for CreateDistribution Operation</seealso>
        public virtual Task<CreateDistributionResponse> CreateDistributionAsync(CreateDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDistributionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDistributionTenant

        internal virtual CreateDistributionTenantResponse CreateDistributionTenant(CreateDistributionTenantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDistributionTenantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDistributionTenantResponseUnmarshaller.Instance;

            return Invoke<CreateDistributionTenantResponse>(request, options);
        }



        /// <summary>
        /// Creates a distribution tenant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDistributionTenant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDistributionTenant service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// The CNAME specified is already defined for CloudFront.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityAlreadyExistsException">
        /// The entity already exists. You must provide a unique entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityLimitExceededException">
        /// The entity limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidAssociationException">
        /// The specified CloudFront resource can't be associated.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// The tagging specified is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateDistributionTenant">REST API Reference for CreateDistributionTenant Operation</seealso>
        public virtual Task<CreateDistributionTenantResponse> CreateDistributionTenantAsync(CreateDistributionTenantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDistributionTenantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDistributionTenantResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDistributionTenantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDistributionWithTags

        internal virtual CreateDistributionWithTagsResponse CreateDistributionWithTags(CreateDistributionWithTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDistributionWithTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDistributionWithTagsResponseUnmarshaller.Instance;

            return Invoke<CreateDistributionWithTagsResponse>(request, options);
        }



        /// <summary>
        /// Create a new distribution with tags. This API operation requires the following IAM
        /// permissions:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_CreateDistribution.html">CreateDistribution</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_TagResource.html">TagResource</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDistributionWithTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDistributionWithTags service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// The CNAME specified is already defined for CloudFront.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ContinuousDeploymentPolicyInUseException">
        /// You cannot delete a continuous deployment policy that is associated with a primary
        /// distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.DistributionAlreadyExistsException">
        /// The caller reference you attempted to create the distribution with is associated with
        /// another distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalFieldLevelEncryptionConfigAssociationWithCacheBehaviorException">
        /// The specified configuration for field-level encryption can't be associated with the
        /// specified cache behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalOriginAccessConfigurationException">
        /// An origin cannot contain both an origin access control (OAC) and an origin access
        /// identity (OAI).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidDefaultRootObjectException">
        /// The default root object file name is too big or contains an invalid character.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidDomainNameForOriginAccessControlException">
        /// An origin access control is associated with an origin whose domain name is not supported.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidErrorCodeException">
        /// An invalid error code was specified.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidForwardCookiesException">
        /// Your request contains forward cookies option which doesn't match with the expectation
        /// for the <c>whitelisted</c> list of cookie names. Either list of cookie names has been
        /// specified when not allowed or list of cookie names is missing when expected.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidFunctionAssociationException">
        /// A CloudFront function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidGeoRestrictionParameterException">
        /// The specified geo restriction parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidHeadersForS3OriginException">
        /// The headers specified are not valid for an Amazon S3 origin.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLambdaFunctionAssociationException">
        /// The specified Lambda@Edge function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLocationCodeException">
        /// The location code specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidMinimumProtocolVersionException">
        /// The minimum protocol version specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessControlException">
        /// The origin access control is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginException">
        /// The Amazon S3 origin server specified does not refer to a valid Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginKeepaliveTimeoutException">
        /// The keep alive timeout specified for the origin is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginReadTimeoutException">
        /// The read timeout specified for the origin is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidProtocolSettingsException">
        /// You cannot specify SSLv3 as the minimum protocol version if you only want to support
        /// only clients that support Server Name Indication (SNI).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidQueryStringParametersException">
        /// The query string parameters specified are not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or does not begin with a slash (/).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the <c>RequiredProtocols</c> element from your distribution
        /// configuration.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidResponseCodeException">
        /// A response code is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// The tagging specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTTLOrderException">
        /// The TTL order specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidViewerCertificateException">
        /// A viewer certificate specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidWebACLIdException">
        /// A web ACL ID specified is not valid. To specify a web ACL created using the latest
        /// version of WAF, use the ACL ARN, for example <c>arn:aws:wafv2:us-east-1:123456789012:global/webacl/ExampleWebACL/473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// To specify a web ACL created using WAF Classic, use the ACL ID, for example <c>473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCachePolicyException">
        /// The cache policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchContinuousDeploymentPolicyException">
        /// The continuous deployment policy doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginException">
        /// No origin exists with the specified <c>Origin Id</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginRequestPolicyException">
        /// The origin request policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchRealtimeLogConfigException">
        /// The real-time log configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResponseHeadersPolicyException">
        /// The response headers policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.RealtimeLogConfigOwnerMismatchException">
        /// The specified real-time log configuration belongs to a different Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCacheBehaviorsException">
        /// You cannot create more cache behaviors for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCertificatesException">
        /// You cannot create anymore custom SSL/TLS certificates.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCookieNamesInWhiteListException">
        /// Your request contains more cookie names in the whitelist than are allowed per cache
        /// behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToCachePolicyException">
        /// The maximum number of distributions have been associated with the specified cache
        /// policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToFieldLevelEncryptionConfigException">
        /// The maximum number of distributions have been associated with the specified configuration
        /// for field-level encryption.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToKeyGroupException">
        /// The number of distributions that reference this key group is more than the maximum
        /// allowed. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToOriginAccessControlException">
        /// The maximum number of distributions have been associated with the specified origin
        /// access control.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToOriginRequestPolicyException">
        /// The maximum number of distributions have been associated with the specified origin
        /// request policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToResponseHeadersPolicyException">
        /// The maximum number of distributions have been associated with the specified response
        /// headers policy.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsException">
        /// Processing your request would cause you to exceed the maximum number of distributions
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithFunctionAssociationsException">
        /// You have reached the maximum number of distributions that are associated with a CloudFront
        /// function. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithLambdaAssociationsException">
        /// Processing your request would cause the maximum number of distributions with Lambda@Edge
        /// function associations per owner to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithSingleFunctionARNException">
        /// The maximum number of distributions have been associated with the specified Lambda@Edge
        /// function.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFunctionAssociationsException">
        /// You have reached the maximum number of CloudFront function associations for this distribution.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInForwardedValuesException">
        /// Your request contains too many headers in forwarded values.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyKeyGroupsAssociatedToDistributionException">
        /// The number of key groups referenced by this distribution is more than the maximum
        /// allowed. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyLambdaFunctionAssociationsException">
        /// Your request contains more Lambda@Edge function associations than are allowed per
        /// distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginCustomHeadersException">
        /// Your request contains too many origin custom headers.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginGroupsPerDistributionException">
        /// Processing your request would cause you to exceed the maximum number of origin groups
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginsException">
        /// You cannot create more origins for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringParametersException">
        /// Your request contains too many query string parameters.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedKeyGroupDoesNotExistException">
        /// The specified key group does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateDistributionWithTags">REST API Reference for CreateDistributionWithTags Operation</seealso>
        public virtual Task<CreateDistributionWithTagsResponse> CreateDistributionWithTagsAsync(CreateDistributionWithTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDistributionWithTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDistributionWithTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDistributionWithTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFieldLevelEncryptionConfig

        internal virtual CreateFieldLevelEncryptionConfigResponse CreateFieldLevelEncryptionConfig(CreateFieldLevelEncryptionConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFieldLevelEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<CreateFieldLevelEncryptionConfigResponse>(request, options);
        }



        /// <summary>
        /// Create a new field-level encryption configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFieldLevelEncryptionConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFieldLevelEncryptionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.FieldLevelEncryptionConfigAlreadyExistsException">
        /// The specified configuration for field-level encryption already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionProfileException">
        /// The specified profile for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.QueryArgProfileEmptyException">
        /// No profile specified for the field-level encryption query argument.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionConfigsException">
        /// The maximum number of configurations for field-level encryption have been created.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionContentTypeProfilesException">
        /// The maximum number of content type profiles for field-level encryption have been created.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionQueryArgProfilesException">
        /// The maximum number of query arg profiles for field-level encryption have been created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateFieldLevelEncryptionConfig">REST API Reference for CreateFieldLevelEncryptionConfig Operation</seealso>
        public virtual Task<CreateFieldLevelEncryptionConfigResponse> CreateFieldLevelEncryptionConfigAsync(CreateFieldLevelEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFieldLevelEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFieldLevelEncryptionConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFieldLevelEncryptionProfile

        internal virtual CreateFieldLevelEncryptionProfileResponse CreateFieldLevelEncryptionProfile(CreateFieldLevelEncryptionProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFieldLevelEncryptionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return Invoke<CreateFieldLevelEncryptionProfileResponse>(request, options);
        }



        /// <summary>
        /// Create a field-level encryption profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFieldLevelEncryptionProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFieldLevelEncryptionProfile service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.FieldLevelEncryptionProfileAlreadyExistsException">
        /// The specified profile for field-level encryption already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.FieldLevelEncryptionProfileSizeExceededException">
        /// The maximum size of a profile for field-level encryption was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchPublicKeyException">
        /// The specified public key doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionEncryptionEntitiesException">
        /// The maximum number of encryption entities for field-level encryption have been created.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionFieldPatternsException">
        /// The maximum number of field patterns for field-level encryption have been created.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionProfilesException">
        /// The maximum number of profiles for field-level encryption have been created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateFieldLevelEncryptionProfile">REST API Reference for CreateFieldLevelEncryptionProfile Operation</seealso>
        public virtual Task<CreateFieldLevelEncryptionProfileResponse> CreateFieldLevelEncryptionProfileAsync(CreateFieldLevelEncryptionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFieldLevelEncryptionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFieldLevelEncryptionProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFunction

        internal virtual CreateFunctionResponse CreateFunction(CreateFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFunctionResponseUnmarshaller.Instance;

            return Invoke<CreateFunctionResponse>(request, options);
        }



        /// <summary>
        /// Creates a CloudFront function.
        /// 
        ///  
        /// <para>
        /// To create a function, you provide the function code and some configuration information
        /// about the function. The response contains an Amazon Resource Name (ARN) that uniquely
        /// identifies the function.
        /// </para>
        ///  
        /// <para>
        /// When you create a function, it's in the <c>DEVELOPMENT</c> stage. In this stage, you
        /// can test the function with <c>TestFunction</c>, and update it with <c>UpdateFunction</c>.
        /// </para>
        ///  
        /// <para>
        /// When you're ready to use your function with a CloudFront distribution, use <c>PublishFunction</c>
        /// to copy the function from the <c>DEVELOPMENT</c> stage to <c>LIVE</c>. When it's live,
        /// you can attach the function to a distribution's cache behavior, using the function's
        /// ARN.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFunction service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.FunctionAlreadyExistsException">
        /// A function with the same name already exists in this Amazon Web Services account.
        /// To create a function, you must provide a unique name. To update an existing function,
        /// use <c>UpdateFunction</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.FunctionSizeLimitExceededException">
        /// The function is too large. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFunctionsException">
        /// You have reached the maximum number of CloudFront functions for this Amazon Web Services
        /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateFunction">REST API Reference for CreateFunction Operation</seealso>
        public virtual Task<CreateFunctionResponse> CreateFunctionAsync(CreateFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFunctionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateInvalidation

        internal virtual CreateInvalidationResponse CreateInvalidation(CreateInvalidationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInvalidationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInvalidationResponseUnmarshaller.Instance;

            return Invoke<CreateInvalidationResponse>(request, options);
        }



        /// <summary>
        /// Create a new invalidation. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Invalidation.html">Invalidating
        /// files</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInvalidation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInvalidation service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.BatchTooLargeException">
        /// Invalidation batch specified is too large.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyInvalidationsInProgressException">
        /// You have exceeded the maximum number of allowable InProgress invalidation batch requests,
        /// or invalidation objects.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateInvalidation">REST API Reference for CreateInvalidation Operation</seealso>
        public virtual Task<CreateInvalidationResponse> CreateInvalidationAsync(CreateInvalidationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInvalidationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInvalidationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInvalidationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateInvalidationForDistributionTenant

        internal virtual CreateInvalidationForDistributionTenantResponse CreateInvalidationForDistributionTenant(CreateInvalidationForDistributionTenantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInvalidationForDistributionTenantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInvalidationForDistributionTenantResponseUnmarshaller.Instance;

            return Invoke<CreateInvalidationForDistributionTenantResponse>(request, options);
        }



        /// <summary>
        /// Creates an invalidation for a distribution tenant. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Invalidation.html">Invalidating
        /// files</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInvalidationForDistributionTenant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInvalidationForDistributionTenant service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.BatchTooLargeException">
        /// Invalidation batch specified is too large.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyInvalidationsInProgressException">
        /// You have exceeded the maximum number of allowable InProgress invalidation batch requests,
        /// or invalidation objects.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateInvalidationForDistributionTenant">REST API Reference for CreateInvalidationForDistributionTenant Operation</seealso>
        public virtual Task<CreateInvalidationForDistributionTenantResponse> CreateInvalidationForDistributionTenantAsync(CreateInvalidationForDistributionTenantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInvalidationForDistributionTenantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInvalidationForDistributionTenantResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInvalidationForDistributionTenantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateKeyGroup

        internal virtual CreateKeyGroupResponse CreateKeyGroup(CreateKeyGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKeyGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyGroupResponseUnmarshaller.Instance;

            return Invoke<CreateKeyGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a key group that you can use with <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">CloudFront
        /// signed URLs and signed cookies</a>.
        /// 
        ///  
        /// <para>
        /// To create a key group, you must specify at least one public key for the key group.
        /// After you create a key group, you can reference it from one or more cache behaviors.
        /// When you reference a key group in a cache behavior, CloudFront requires signed URLs
        /// or signed cookies for all requests that match the cache behavior. The URLs or cookies
        /// must be signed with a private key whose corresponding public key is in the key group.
        /// The signed URL or cookie contains information about which public key CloudFront should
        /// use to verify the signature. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">Serving
        /// private content</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateKeyGroup service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.KeyGroupAlreadyExistsException">
        /// A key group with this name already exists. You must provide a unique name. To modify
        /// an existing key group, use <c>UpdateKeyGroup</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyKeyGroupsException">
        /// You have reached the maximum number of key groups for this Amazon Web Services account.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyPublicKeysInKeyGroupException">
        /// The number of public keys in this key group is more than the maximum allowed. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateKeyGroup">REST API Reference for CreateKeyGroup Operation</seealso>
        public virtual Task<CreateKeyGroupResponse> CreateKeyGroupAsync(CreateKeyGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKeyGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKeyGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateKeyValueStore

        internal virtual CreateKeyValueStoreResponse CreateKeyValueStore(CreateKeyValueStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKeyValueStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyValueStoreResponseUnmarshaller.Instance;

            return Invoke<CreateKeyValueStoreResponse>(request, options);
        }



        /// <summary>
        /// Specifies the key value store resource to add to your account. In your account, the
        /// key value store names must be unique. You can also import key value store data in
        /// JSON format from an S3 bucket by providing a valid <c>ImportSource</c> that you own.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyValueStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateKeyValueStore service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityAlreadyExistsException">
        /// The entity already exists. You must provide a unique entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityLimitExceededException">
        /// The entity limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntitySizeLimitExceededException">
        /// The entity size limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateKeyValueStore">REST API Reference for CreateKeyValueStore Operation</seealso>
        public virtual Task<CreateKeyValueStoreResponse> CreateKeyValueStoreAsync(CreateKeyValueStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKeyValueStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyValueStoreResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKeyValueStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateMonitoringSubscription

        internal virtual CreateMonitoringSubscriptionResponse CreateMonitoringSubscription(CreateMonitoringSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMonitoringSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMonitoringSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateMonitoringSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Enables or disables additional Amazon CloudWatch metrics for the specified CloudFront
        /// distribution. The additional metrics incur an additional cost.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/viewing-cloudfront-metrics.html#monitoring-console.distributions-additional">Viewing
        /// additional CloudFront distribution metrics</a> in the <i>Amazon CloudFront Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitoringSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMonitoringSubscription service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MonitoringSubscriptionAlreadyExistsException">
        /// A monitoring subscription already exists for the specified distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateMonitoringSubscription">REST API Reference for CreateMonitoringSubscription Operation</seealso>
        public virtual Task<CreateMonitoringSubscriptionResponse> CreateMonitoringSubscriptionAsync(CreateMonitoringSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMonitoringSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMonitoringSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMonitoringSubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateOriginAccessControl

        internal virtual CreateOriginAccessControlResponse CreateOriginAccessControl(CreateOriginAccessControlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOriginAccessControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOriginAccessControlResponseUnmarshaller.Instance;

            return Invoke<CreateOriginAccessControlResponse>(request, options);
        }



        /// <summary>
        /// Creates a new origin access control in CloudFront. After you create an origin access
        /// control, you can add it to an origin in a CloudFront distribution so that CloudFront
        /// sends authenticated (signed) requests to the origin.
        /// 
        ///  
        /// <para>
        /// This makes it possible to block public access to the origin, allowing viewers (users)
        /// to access the origin's content only through CloudFront.
        /// </para>
        ///  
        /// <para>
        /// For more information about using a CloudFront origin access control, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/private-content-restricting-access-to-origin.html">Restricting
        /// access to an Amazon Web Services origin</a> in the <i>Amazon CloudFront Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOriginAccessControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOriginAccessControl service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.OriginAccessControlAlreadyExistsException">
        /// An origin access control with the specified parameters already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginAccessControlsException">
        /// The number of origin access controls in your Amazon Web Services account exceeds the
        /// maximum allowed.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateOriginAccessControl">REST API Reference for CreateOriginAccessControl Operation</seealso>
        public virtual Task<CreateOriginAccessControlResponse> CreateOriginAccessControlAsync(CreateOriginAccessControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOriginAccessControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOriginAccessControlResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOriginAccessControlResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateOriginRequestPolicy

        internal virtual CreateOriginRequestPolicyResponse CreateOriginRequestPolicy(CreateOriginRequestPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOriginRequestPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOriginRequestPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateOriginRequestPolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates an origin request policy.
        /// 
        ///  
        /// <para>
        /// After you create an origin request policy, you can attach it to one or more cache
        /// behaviors. When it's attached to a cache behavior, the origin request policy determines
        /// the values that CloudFront includes in requests that it sends to the origin. Each
        /// request that CloudFront sends to the origin includes the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The request body and the URL path (without the domain name) from the viewer request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The headers that CloudFront automatically includes in every origin request, including
        /// <c>Host</c>, <c>User-Agent</c>, and <c>X-Amz-Cf-Id</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All HTTP headers, cookies, and URL query strings that are specified in the cache policy
        /// or the origin request policy. These can include items from the viewer request and,
        /// in the case of headers, additional ones that are added by CloudFront.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// CloudFront sends a request when it can't find a valid object in its cache that matches
        /// the request. If you want to send values to the origin and also include them in the
        /// cache key, use <c>CachePolicy</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about origin request policies, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-origin-requests.html">Controlling
        /// origin requests</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOriginRequestPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOriginRequestPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.OriginRequestPolicyAlreadyExistsException">
        /// An origin request policy with this name already exists. You must provide a unique
        /// name. To modify an existing origin request policy, use <c>UpdateOriginRequestPolicy</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCookiesInOriginRequestPolicyException">
        /// The number of cookies in the origin request policy exceeds the maximum. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInOriginRequestPolicyException">
        /// The number of headers in the origin request policy exceeds the maximum. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginRequestPoliciesException">
        /// You have reached the maximum number of origin request policies for this Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringsInOriginRequestPolicyException">
        /// The number of query strings in the origin request policy exceeds the maximum. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateOriginRequestPolicy">REST API Reference for CreateOriginRequestPolicy Operation</seealso>
        public virtual Task<CreateOriginRequestPolicyResponse> CreateOriginRequestPolicyAsync(CreateOriginRequestPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOriginRequestPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOriginRequestPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOriginRequestPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePublicKey

        internal virtual CreatePublicKeyResponse CreatePublicKey(CreatePublicKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePublicKeyResponseUnmarshaller.Instance;

            return Invoke<CreatePublicKeyResponse>(request, options);
        }



        /// <summary>
        /// Uploads a public key to CloudFront that you can use with <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">signed
        /// URLs and signed cookies</a>, or with <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/field-level-encryption.html">field-level
        /// encryption</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePublicKey service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PublicKeyAlreadyExistsException">
        /// The specified public key already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyPublicKeysException">
        /// The maximum number of public keys for field-level encryption have been created. To
        /// create a new public key, delete one of the existing keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreatePublicKey">REST API Reference for CreatePublicKey Operation</seealso>
        public virtual Task<CreatePublicKeyResponse> CreatePublicKeyAsync(CreatePublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePublicKeyResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePublicKeyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRealtimeLogConfig

        internal virtual CreateRealtimeLogConfigResponse CreateRealtimeLogConfig(CreateRealtimeLogConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRealtimeLogConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRealtimeLogConfigResponseUnmarshaller.Instance;

            return Invoke<CreateRealtimeLogConfigResponse>(request, options);
        }



        /// <summary>
        /// Creates a real-time log configuration.
        /// 
        ///  
        /// <para>
        /// After you create a real-time log configuration, you can attach it to one or more cache
        /// behaviors to send real-time log data to the specified Amazon Kinesis data stream.
        /// </para>
        ///  
        /// <para>
        /// For more information about real-time log configurations, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/real-time-logs.html">Real-time
        /// logs</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRealtimeLogConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRealtimeLogConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.RealtimeLogConfigAlreadyExistsException">
        /// A real-time log configuration with this name already exists. You must provide a unique
        /// name. To modify an existing real-time log configuration, use <c>UpdateRealtimeLogConfig</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyRealtimeLogConfigsException">
        /// You have reached the maximum number of real-time log configurations for this Amazon
        /// Web Services account. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateRealtimeLogConfig">REST API Reference for CreateRealtimeLogConfig Operation</seealso>
        public virtual Task<CreateRealtimeLogConfigResponse> CreateRealtimeLogConfigAsync(CreateRealtimeLogConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRealtimeLogConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRealtimeLogConfigResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRealtimeLogConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateResponseHeadersPolicy

        internal virtual CreateResponseHeadersPolicyResponse CreateResponseHeadersPolicy(CreateResponseHeadersPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResponseHeadersPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResponseHeadersPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateResponseHeadersPolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates a response headers policy.
        /// 
        ///  
        /// <para>
        /// A response headers policy contains information about a set of HTTP headers. To create
        /// a response headers policy, you provide some metadata about the policy and a set of
        /// configurations that specify the headers.
        /// </para>
        ///  
        /// <para>
        /// After you create a response headers policy, you can use its ID to attach it to one
        /// or more cache behaviors in a CloudFront distribution. When it's attached to a cache
        /// behavior, the response headers policy affects the HTTP headers that CloudFront includes
        /// in HTTP responses to requests that match the cache behavior. CloudFront adds or removes
        /// response headers according to the configuration of the response headers policy.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/modifying-response-headers.html">Adding
        /// or removing HTTP headers in CloudFront responses</a> in the <i>Amazon CloudFront Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResponseHeadersPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResponseHeadersPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ResponseHeadersPolicyAlreadyExistsException">
        /// A response headers policy with this name already exists. You must provide a unique
        /// name. To modify an existing response headers policy, use <c>UpdateResponseHeadersPolicy</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooLongCSPInResponseHeadersPolicyException">
        /// The length of the <c>Content-Security-Policy</c> header value in the response headers
        /// policy exceeds the maximum.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCustomHeadersInResponseHeadersPolicyException">
        /// The number of custom headers in the response headers policy exceeds the maximum.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyRemoveHeadersInResponseHeadersPolicyException">
        /// The number of headers in <c>RemoveHeadersConfig</c> in the response headers policy
        /// exceeds the maximum.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyResponseHeadersPoliciesException">
        /// You have reached the maximum number of response headers policies for this Amazon Web
        /// Services account.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateResponseHeadersPolicy">REST API Reference for CreateResponseHeadersPolicy Operation</seealso>
        public virtual Task<CreateResponseHeadersPolicyResponse> CreateResponseHeadersPolicyAsync(CreateResponseHeadersPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResponseHeadersPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResponseHeadersPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResponseHeadersPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateStreamingDistribution

        internal virtual CreateStreamingDistributionResponse CreateStreamingDistribution(CreateStreamingDistributionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStreamingDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamingDistributionResponseUnmarshaller.Instance;

            return Invoke<CreateStreamingDistributionResponse>(request, options);
        }



        /// <summary>
        /// This API is deprecated. Amazon CloudFront is deprecating real-time messaging protocol
        /// (RTMP) distributions on December 31, 2020. For more information, <a href="http://forums.aws.amazon.com/ann.jspa?annID=7356">read
        /// the announcement</a> on the Amazon CloudFront discussion forum.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingDistribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// The CNAME specified is already defined for CloudFront.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessControlException">
        /// The origin access control is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginException">
        /// The Amazon S3 origin server specified does not refer to a valid Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StreamingDistributionAlreadyExistsException">
        /// The caller reference you attempted to create the streaming distribution with is associated
        /// with another distribution
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyStreamingDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyStreamingDistributionsException">
        /// Processing your request would cause you to exceed the maximum number of streaming
        /// distributions allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateStreamingDistribution">REST API Reference for CreateStreamingDistribution Operation</seealso>
        public virtual Task<CreateStreamingDistributionResponse> CreateStreamingDistributionAsync(CreateStreamingDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStreamingDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamingDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStreamingDistributionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateStreamingDistributionWithTags

        internal virtual CreateStreamingDistributionWithTagsResponse CreateStreamingDistributionWithTags(CreateStreamingDistributionWithTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStreamingDistributionWithTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance;

            return Invoke<CreateStreamingDistributionWithTagsResponse>(request, options);
        }



        /// <summary>
        /// This API is deprecated. Amazon CloudFront is deprecating real-time messaging protocol
        /// (RTMP) distributions on December 31, 2020. For more information, <a href="http://forums.aws.amazon.com/ann.jspa?annID=7356">read
        /// the announcement</a> on the Amazon CloudFront discussion forum.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingDistributionWithTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStreamingDistributionWithTags service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// The CNAME specified is already defined for CloudFront.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessControlException">
        /// The origin access control is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginException">
        /// The Amazon S3 origin server specified does not refer to a valid Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// The tagging specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StreamingDistributionAlreadyExistsException">
        /// The caller reference you attempted to create the streaming distribution with is associated
        /// with another distribution
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyStreamingDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyStreamingDistributionsException">
        /// Processing your request would cause you to exceed the maximum number of streaming
        /// distributions allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateStreamingDistributionWithTags">REST API Reference for CreateStreamingDistributionWithTags Operation</seealso>
        public virtual Task<CreateStreamingDistributionWithTagsResponse> CreateStreamingDistributionWithTagsAsync(CreateStreamingDistributionWithTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStreamingDistributionWithTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStreamingDistributionWithTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateVpcOrigin

        internal virtual CreateVpcOriginResponse CreateVpcOrigin(CreateVpcOriginRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcOriginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcOriginResponseUnmarshaller.Instance;

            return Invoke<CreateVpcOriginResponse>(request, options);
        }



        /// <summary>
        /// Create an Amazon CloudFront VPC origin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcOrigin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpcOrigin service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityAlreadyExistsException">
        /// The entity already exists. You must provide a unique entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityLimitExceededException">
        /// The entity limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// The tagging specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/CreateVpcOrigin">REST API Reference for CreateVpcOrigin Operation</seealso>
        public virtual Task<CreateVpcOriginResponse> CreateVpcOriginAsync(CreateVpcOriginRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcOriginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcOriginResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcOriginResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAnycastIpList

        internal virtual DeleteAnycastIpListResponse DeleteAnycastIpList(DeleteAnycastIpListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAnycastIpListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnycastIpListResponseUnmarshaller.Instance;

            return Invoke<DeleteAnycastIpListResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Anycast static IP list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnycastIpList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAnycastIpList service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CannotDeleteEntityWhileInUseException">
        /// The entity cannot be deleted while it is in use.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalDeleteException">
        /// Deletion is not allowed for this entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteAnycastIpList">REST API Reference for DeleteAnycastIpList Operation</seealso>
        public virtual Task<DeleteAnycastIpListResponse> DeleteAnycastIpListAsync(DeleteAnycastIpListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAnycastIpListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnycastIpListResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAnycastIpListResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCachePolicy

        internal virtual DeleteCachePolicyResponse DeleteCachePolicy(DeleteCachePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCachePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCachePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteCachePolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes a cache policy.
        /// 
        ///  
        /// <para>
        /// You cannot delete a cache policy if it's attached to a cache behavior. First update
        /// your distributions to remove the cache policy from all cache behaviors, then delete
        /// the cache policy.
        /// </para>
        ///  
        /// <para>
        /// To delete a cache policy, you must provide the policy's identifier and version. To
        /// get these values, you can use <c>ListCachePolicies</c> or <c>GetCachePolicy</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCachePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCachePolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CachePolicyInUseException">
        /// Cannot delete the cache policy because it is attached to one or more cache behaviors.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalDeleteException">
        /// Deletion is not allowed for this entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCachePolicyException">
        /// The cache policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteCachePolicy">REST API Reference for DeleteCachePolicy Operation</seealso>
        public virtual Task<DeleteCachePolicyResponse> DeleteCachePolicyAsync(DeleteCachePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCachePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCachePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCachePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCloudFrontOriginAccessIdentity

        internal virtual DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity()
        {
            return DeleteCloudFrontOriginAccessIdentity(new DeleteCloudFrontOriginAccessIdentityRequest());
        }
        internal virtual DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return Invoke<DeleteCloudFrontOriginAccessIdentityResponse>(request, options);
        }


        /// <summary>
        /// Delete an origin access identity.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CloudFrontOriginAccessIdentityInUseException">
        /// The Origin Access Identity specified is already in use.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteCloudFrontOriginAccessIdentity">REST API Reference for DeleteCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual Task<DeleteCloudFrontOriginAccessIdentityResponse> DeleteCloudFrontOriginAccessIdentityAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteCloudFrontOriginAccessIdentityAsync(new DeleteCloudFrontOriginAccessIdentityRequest(), cancellationToken);
        }



        /// <summary>
        /// Delete an origin access identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudFrontOriginAccessIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CloudFrontOriginAccessIdentityInUseException">
        /// The Origin Access Identity specified is already in use.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteCloudFrontOriginAccessIdentity">REST API Reference for DeleteCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual Task<DeleteCloudFrontOriginAccessIdentityResponse> DeleteCloudFrontOriginAccessIdentityAsync(DeleteCloudFrontOriginAccessIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCloudFrontOriginAccessIdentityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteConnectionGroup

        internal virtual DeleteConnectionGroupResponse DeleteConnectionGroup(DeleteConnectionGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectionGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a connection group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnectionGroup service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CannotDeleteEntityWhileInUseException">
        /// The entity cannot be deleted while it is in use.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ResourceNotDisabledException">
        /// The specified CloudFront resource hasn't been disabled yet.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteConnectionGroup">REST API Reference for DeleteConnectionGroup Operation</seealso>
        public virtual Task<DeleteConnectionGroupResponse> DeleteConnectionGroupAsync(DeleteConnectionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConnectionGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteContinuousDeploymentPolicy

        internal virtual DeleteContinuousDeploymentPolicyResponse DeleteContinuousDeploymentPolicy(DeleteContinuousDeploymentPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContinuousDeploymentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContinuousDeploymentPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteContinuousDeploymentPolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes a continuous deployment policy.
        /// 
        ///  
        /// <para>
        /// You cannot delete a continuous deployment policy that's attached to a primary distribution.
        /// First update your distribution to remove the continuous deployment policy, then you
        /// can delete the policy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContinuousDeploymentPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteContinuousDeploymentPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ContinuousDeploymentPolicyInUseException">
        /// You cannot delete a continuous deployment policy that is associated with a primary
        /// distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchContinuousDeploymentPolicyException">
        /// The continuous deployment policy doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteContinuousDeploymentPolicy">REST API Reference for DeleteContinuousDeploymentPolicy Operation</seealso>
        public virtual Task<DeleteContinuousDeploymentPolicyResponse> DeleteContinuousDeploymentPolicyAsync(DeleteContinuousDeploymentPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContinuousDeploymentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContinuousDeploymentPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteContinuousDeploymentPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDistribution

        internal virtual DeleteDistributionResponse DeleteDistribution()
        {
            return DeleteDistribution(new DeleteDistributionRequest());
        }
        internal virtual DeleteDistributionResponse DeleteDistribution(DeleteDistributionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDistributionResponseUnmarshaller.Instance;

            return Invoke<DeleteDistributionResponse>(request, options);
        }


        /// <summary>
        /// Delete a distribution.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.DistributionNotDisabledException">
        /// The specified CloudFront distribution is not disabled. You must disable the distribution
        /// before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ResourceInUseException">
        /// Cannot delete this resource because it is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteDistribution">REST API Reference for DeleteDistribution Operation</seealso>
        public virtual Task<DeleteDistributionResponse> DeleteDistributionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteDistributionAsync(new DeleteDistributionRequest(), cancellationToken);
        }



        /// <summary>
        /// Delete a distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.DistributionNotDisabledException">
        /// The specified CloudFront distribution is not disabled. You must disable the distribution
        /// before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ResourceInUseException">
        /// Cannot delete this resource because it is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteDistribution">REST API Reference for DeleteDistribution Operation</seealso>
        public virtual Task<DeleteDistributionResponse> DeleteDistributionAsync(DeleteDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDistributionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDistributionTenant

        internal virtual DeleteDistributionTenantResponse DeleteDistributionTenant(DeleteDistributionTenantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDistributionTenantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDistributionTenantResponseUnmarshaller.Instance;

            return Invoke<DeleteDistributionTenantResponse>(request, options);
        }



        /// <summary>
        /// Deletes a distribution tenant. If you use this API operation to delete a distribution
        /// tenant that is currently enabled, the request will fail.
        /// 
        ///  
        /// <para>
        /// To delete a distribution tenant, you must first disable the distribution tenant by
        /// using the <c>UpdateDistributionTenant</c> API operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistributionTenant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDistributionTenant service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ResourceNotDisabledException">
        /// The specified CloudFront resource hasn't been disabled yet.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteDistributionTenant">REST API Reference for DeleteDistributionTenant Operation</seealso>
        public virtual Task<DeleteDistributionTenantResponse> DeleteDistributionTenantAsync(DeleteDistributionTenantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDistributionTenantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDistributionTenantResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDistributionTenantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFieldLevelEncryptionConfig

        internal virtual DeleteFieldLevelEncryptionConfigResponse DeleteFieldLevelEncryptionConfig(DeleteFieldLevelEncryptionConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFieldLevelEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteFieldLevelEncryptionConfigResponse>(request, options);
        }



        /// <summary>
        /// Remove a field-level encryption configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFieldLevelEncryptionConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFieldLevelEncryptionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.FieldLevelEncryptionConfigInUseException">
        /// The specified configuration for field-level encryption is in use.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteFieldLevelEncryptionConfig">REST API Reference for DeleteFieldLevelEncryptionConfig Operation</seealso>
        public virtual Task<DeleteFieldLevelEncryptionConfigResponse> DeleteFieldLevelEncryptionConfigAsync(DeleteFieldLevelEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFieldLevelEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFieldLevelEncryptionConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFieldLevelEncryptionProfile

        internal virtual DeleteFieldLevelEncryptionProfileResponse DeleteFieldLevelEncryptionProfile(DeleteFieldLevelEncryptionProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFieldLevelEncryptionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteFieldLevelEncryptionProfileResponse>(request, options);
        }



        /// <summary>
        /// Remove a field-level encryption profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFieldLevelEncryptionProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFieldLevelEncryptionProfile service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.FieldLevelEncryptionProfileInUseException">
        /// The specified profile for field-level encryption is in use.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionProfileException">
        /// The specified profile for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteFieldLevelEncryptionProfile">REST API Reference for DeleteFieldLevelEncryptionProfile Operation</seealso>
        public virtual Task<DeleteFieldLevelEncryptionProfileResponse> DeleteFieldLevelEncryptionProfileAsync(DeleteFieldLevelEncryptionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFieldLevelEncryptionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFieldLevelEncryptionProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFunction

        internal virtual DeleteFunctionResponse DeleteFunction(DeleteFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionResponseUnmarshaller.Instance;

            return Invoke<DeleteFunctionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a CloudFront function.
        /// 
        ///  
        /// <para>
        /// You cannot delete a function if it's associated with a cache behavior. First, update
        /// your distributions to remove the function association from all cache behaviors, then
        /// delete the function.
        /// </para>
        ///  
        /// <para>
        /// To delete a function, you must provide the function's name and version (<c>ETag</c>
        /// value). To get these values, you can use <c>ListFunctions</c> and <c>DescribeFunction</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFunction service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.FunctionInUseException">
        /// Cannot delete the function because it's attached to one or more cache behaviors.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFunctionExistsException">
        /// The function does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        public virtual Task<DeleteFunctionResponse> DeleteFunctionAsync(DeleteFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFunctionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteKeyGroup

        internal virtual DeleteKeyGroupResponse DeleteKeyGroup(DeleteKeyGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKeyGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeyGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteKeyGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a key group.
        /// 
        ///  
        /// <para>
        /// You cannot delete a key group that is referenced in a cache behavior. First update
        /// your distributions to remove the key group from all cache behaviors, then delete the
        /// key group.
        /// </para>
        ///  
        /// <para>
        /// To delete a key group, you must provide the key group's identifier and version. To
        /// get these values, use <c>ListKeyGroups</c> followed by <c>GetKeyGroup</c> or <c>GetKeyGroupConfig</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteKeyGroup service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// A resource that was specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ResourceInUseException">
        /// Cannot delete this resource because it is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteKeyGroup">REST API Reference for DeleteKeyGroup Operation</seealso>
        public virtual Task<DeleteKeyGroupResponse> DeleteKeyGroupAsync(DeleteKeyGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKeyGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeyGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKeyGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteKeyValueStore

        internal virtual DeleteKeyValueStoreResponse DeleteKeyValueStore(DeleteKeyValueStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKeyValueStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeyValueStoreResponseUnmarshaller.Instance;

            return Invoke<DeleteKeyValueStoreResponse>(request, options);
        }



        /// <summary>
        /// Specifies the key value store to delete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyValueStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteKeyValueStore service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CannotDeleteEntityWhileInUseException">
        /// The entity cannot be deleted while it is in use.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteKeyValueStore">REST API Reference for DeleteKeyValueStore Operation</seealso>
        public virtual Task<DeleteKeyValueStoreResponse> DeleteKeyValueStoreAsync(DeleteKeyValueStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKeyValueStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeyValueStoreResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKeyValueStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteMonitoringSubscription

        internal virtual DeleteMonitoringSubscriptionResponse DeleteMonitoringSubscription(DeleteMonitoringSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMonitoringSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMonitoringSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteMonitoringSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Disables additional CloudWatch metrics for the specified CloudFront distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitoringSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMonitoringSubscription service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchMonitoringSubscriptionException">
        /// A monitoring subscription does not exist for the specified distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteMonitoringSubscription">REST API Reference for DeleteMonitoringSubscription Operation</seealso>
        public virtual Task<DeleteMonitoringSubscriptionResponse> DeleteMonitoringSubscriptionAsync(DeleteMonitoringSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMonitoringSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMonitoringSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMonitoringSubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteOriginAccessControl

        internal virtual DeleteOriginAccessControlResponse DeleteOriginAccessControl(DeleteOriginAccessControlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOriginAccessControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOriginAccessControlResponseUnmarshaller.Instance;

            return Invoke<DeleteOriginAccessControlResponse>(request, options);
        }



        /// <summary>
        /// Deletes a CloudFront origin access control.
        /// 
        ///  
        /// <para>
        /// You cannot delete an origin access control if it's in use. First, update all distributions
        /// to remove the origin access control from all origins, then delete the origin access
        /// control.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOriginAccessControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOriginAccessControl service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginAccessControlException">
        /// The origin access control does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.OriginAccessControlInUseException">
        /// Cannot delete the origin access control because it's in use by one or more distributions.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteOriginAccessControl">REST API Reference for DeleteOriginAccessControl Operation</seealso>
        public virtual Task<DeleteOriginAccessControlResponse> DeleteOriginAccessControlAsync(DeleteOriginAccessControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOriginAccessControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOriginAccessControlResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOriginAccessControlResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteOriginRequestPolicy

        internal virtual DeleteOriginRequestPolicyResponse DeleteOriginRequestPolicy(DeleteOriginRequestPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOriginRequestPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOriginRequestPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteOriginRequestPolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes an origin request policy.
        /// 
        ///  
        /// <para>
        /// You cannot delete an origin request policy if it's attached to any cache behaviors.
        /// First update your distributions to remove the origin request policy from all cache
        /// behaviors, then delete the origin request policy.
        /// </para>
        ///  
        /// <para>
        /// To delete an origin request policy, you must provide the policy's identifier and version.
        /// To get the identifier, you can use <c>ListOriginRequestPolicies</c> or <c>GetOriginRequestPolicy</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOriginRequestPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOriginRequestPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalDeleteException">
        /// Deletion is not allowed for this entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginRequestPolicyException">
        /// The origin request policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.OriginRequestPolicyInUseException">
        /// Cannot delete the origin request policy because it is attached to one or more cache
        /// behaviors.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteOriginRequestPolicy">REST API Reference for DeleteOriginRequestPolicy Operation</seealso>
        public virtual Task<DeleteOriginRequestPolicyResponse> DeleteOriginRequestPolicyAsync(DeleteOriginRequestPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOriginRequestPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOriginRequestPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOriginRequestPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeletePublicKey

        internal virtual DeletePublicKeyResponse DeletePublicKey(DeletePublicKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePublicKeyResponseUnmarshaller.Instance;

            return Invoke<DeletePublicKeyResponse>(request, options);
        }



        /// <summary>
        /// Remove a public key you previously added to CloudFront.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePublicKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePublicKey service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchPublicKeyException">
        /// The specified public key doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PublicKeyInUseException">
        /// The specified public key is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeletePublicKey">REST API Reference for DeletePublicKey Operation</seealso>
        public virtual Task<DeletePublicKeyResponse> DeletePublicKeyAsync(DeletePublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePublicKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePublicKeyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRealtimeLogConfig

        internal virtual DeleteRealtimeLogConfigResponse DeleteRealtimeLogConfig(DeleteRealtimeLogConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRealtimeLogConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRealtimeLogConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteRealtimeLogConfigResponse>(request, options);
        }



        /// <summary>
        /// Deletes a real-time log configuration.
        /// 
        ///  
        /// <para>
        /// You cannot delete a real-time log configuration if it's attached to a cache behavior.
        /// First update your distributions to remove the real-time log configuration from all
        /// cache behaviors, then delete the real-time log configuration.
        /// </para>
        ///  
        /// <para>
        /// To delete a real-time log configuration, you can provide the configuration's name
        /// or its Amazon Resource Name (ARN). You must provide at least one. If you provide both,
        /// CloudFront uses the name to identify the real-time log configuration to delete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRealtimeLogConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRealtimeLogConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchRealtimeLogConfigException">
        /// The real-time log configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.RealtimeLogConfigInUseException">
        /// Cannot delete the real-time log configuration because it is attached to one or more
        /// cache behaviors.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteRealtimeLogConfig">REST API Reference for DeleteRealtimeLogConfig Operation</seealso>
        public virtual Task<DeleteRealtimeLogConfigResponse> DeleteRealtimeLogConfigAsync(DeleteRealtimeLogConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRealtimeLogConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRealtimeLogConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRealtimeLogConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteResponseHeadersPolicy

        internal virtual DeleteResponseHeadersPolicyResponse DeleteResponseHeadersPolicy(DeleteResponseHeadersPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResponseHeadersPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResponseHeadersPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResponseHeadersPolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes a response headers policy.
        /// 
        ///  
        /// <para>
        /// You cannot delete a response headers policy if it's attached to a cache behavior.
        /// First update your distributions to remove the response headers policy from all cache
        /// behaviors, then delete the response headers policy.
        /// </para>
        ///  
        /// <para>
        /// To delete a response headers policy, you must provide the policy's identifier and
        /// version. To get these values, you can use <c>ListResponseHeadersPolicies</c> or <c>GetResponseHeadersPolicy</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResponseHeadersPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResponseHeadersPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalDeleteException">
        /// Deletion is not allowed for this entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResponseHeadersPolicyException">
        /// The response headers policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ResponseHeadersPolicyInUseException">
        /// Cannot delete the response headers policy because it is attached to one or more cache
        /// behaviors in a CloudFront distribution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteResponseHeadersPolicy">REST API Reference for DeleteResponseHeadersPolicy Operation</seealso>
        public virtual Task<DeleteResponseHeadersPolicyResponse> DeleteResponseHeadersPolicyAsync(DeleteResponseHeadersPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResponseHeadersPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResponseHeadersPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResponseHeadersPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteStreamingDistribution

        internal virtual DeleteStreamingDistributionResponse DeleteStreamingDistribution()
        {
            return DeleteStreamingDistribution(new DeleteStreamingDistributionRequest());
        }
        internal virtual DeleteStreamingDistributionResponse DeleteStreamingDistribution(DeleteStreamingDistributionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStreamingDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamingDistributionResponseUnmarshaller.Instance;

            return Invoke<DeleteStreamingDistributionResponse>(request, options);
        }


        /// <summary>
        /// Delete a streaming distribution. To delete an RTMP distribution using the CloudFront
        /// API, perform the following steps.
        /// 
        ///  
        /// <para>
        ///  <b>To delete an RTMP distribution using the CloudFront API</b>:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Disable the RTMP distribution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>GET Streaming Distribution Config</c> request to get the current configuration
        /// and the <c>Etag</c> header for the distribution. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update the XML document that was returned in the response to your <c>GET Streaming
        /// Distribution Config</c> request to change the value of <c>Enabled</c> to <c>false</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>PUT Streaming Distribution Config</c> request to update the configuration
        /// for your distribution. In the request body, include the XML document that you updated
        /// in Step 3. Then set the value of the HTTP <c>If-Match</c> header to the value of the
        /// <c>ETag</c> header that CloudFront returned when you submitted the <c>GET Streaming
        /// Distribution Config</c> request in Step 2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Review the response to the <c>PUT Streaming Distribution Config</c> request to confirm
        /// that the distribution was successfully disabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>GET Streaming Distribution Config</c> request to confirm that your changes
        /// have propagated. When propagation is complete, the value of <c>Status</c> is <c>Deployed</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DELETE Streaming Distribution</c> request. Set the value of the HTTP <c>If-Match</c>
        /// header to the value of the <c>ETag</c> header that CloudFront returned when you submitted
        /// the <c>GET Streaming Distribution Config</c> request in Step 2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Review the response to your <c>DELETE Streaming Distribution</c> request to confirm
        /// that the distribution was successfully deleted.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For information about deleting a distribution using the CloudFront console, see <a
        /// href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/HowToDeleteDistribution.html">Deleting
        /// a Distribution</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StreamingDistributionNotDisabledException">
        /// The specified CloudFront distribution is not disabled. You must disable the distribution
        /// before you can delete it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteStreamingDistribution">REST API Reference for DeleteStreamingDistribution Operation</seealso>
        public virtual Task<DeleteStreamingDistributionResponse> DeleteStreamingDistributionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteStreamingDistributionAsync(new DeleteStreamingDistributionRequest(), cancellationToken);
        }



        /// <summary>
        /// Delete a streaming distribution. To delete an RTMP distribution using the CloudFront
        /// API, perform the following steps.
        /// 
        ///  
        /// <para>
        ///  <b>To delete an RTMP distribution using the CloudFront API</b>:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Disable the RTMP distribution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>GET Streaming Distribution Config</c> request to get the current configuration
        /// and the <c>Etag</c> header for the distribution. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update the XML document that was returned in the response to your <c>GET Streaming
        /// Distribution Config</c> request to change the value of <c>Enabled</c> to <c>false</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>PUT Streaming Distribution Config</c> request to update the configuration
        /// for your distribution. In the request body, include the XML document that you updated
        /// in Step 3. Then set the value of the HTTP <c>If-Match</c> header to the value of the
        /// <c>ETag</c> header that CloudFront returned when you submitted the <c>GET Streaming
        /// Distribution Config</c> request in Step 2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Review the response to the <c>PUT Streaming Distribution Config</c> request to confirm
        /// that the distribution was successfully disabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>GET Streaming Distribution Config</c> request to confirm that your changes
        /// have propagated. When propagation is complete, the value of <c>Status</c> is <c>Deployed</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DELETE Streaming Distribution</c> request. Set the value of the HTTP <c>If-Match</c>
        /// header to the value of the <c>ETag</c> header that CloudFront returned when you submitted
        /// the <c>GET Streaming Distribution Config</c> request in Step 2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Review the response to your <c>DELETE Streaming Distribution</c> request to confirm
        /// that the distribution was successfully deleted.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For information about deleting a distribution using the CloudFront console, see <a
        /// href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/HowToDeleteDistribution.html">Deleting
        /// a Distribution</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamingDistribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StreamingDistributionNotDisabledException">
        /// The specified CloudFront distribution is not disabled. You must disable the distribution
        /// before you can delete it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteStreamingDistribution">REST API Reference for DeleteStreamingDistribution Operation</seealso>
        public virtual Task<DeleteStreamingDistributionResponse> DeleteStreamingDistributionAsync(DeleteStreamingDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStreamingDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamingDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStreamingDistributionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteVpcOrigin

        internal virtual DeleteVpcOriginResponse DeleteVpcOrigin(DeleteVpcOriginRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcOriginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcOriginResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcOriginResponse>(request, options);
        }



        /// <summary>
        /// Delete an Amazon CloudFront VPC origin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcOrigin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpcOrigin service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CannotDeleteEntityWhileInUseException">
        /// The entity cannot be deleted while it is in use.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalDeleteException">
        /// Deletion is not allowed for this entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DeleteVpcOrigin">REST API Reference for DeleteVpcOrigin Operation</seealso>
        public virtual Task<DeleteVpcOriginResponse> DeleteVpcOriginAsync(DeleteVpcOriginRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcOriginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcOriginResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcOriginResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFunction

        internal virtual DescribeFunctionResponse DescribeFunction(DescribeFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFunctionResponseUnmarshaller.Instance;

            return Invoke<DescribeFunctionResponse>(request, options);
        }



        /// <summary>
        /// Gets configuration information and metadata about a CloudFront function, but not the
        /// function's code. To get a function's code, use <c>GetFunction</c>.
        /// 
        ///  
        /// <para>
        /// To get configuration information and metadata about a function, you must provide the
        /// function's name and stage. To get these values, you can use <c>ListFunctions</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFunction service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFunctionExistsException">
        /// The function does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DescribeFunction">REST API Reference for DescribeFunction Operation</seealso>
        public virtual Task<DescribeFunctionResponse> DescribeFunctionAsync(DescribeFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFunctionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeKeyValueStore

        internal virtual DescribeKeyValueStoreResponse DescribeKeyValueStore(DescribeKeyValueStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeKeyValueStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyValueStoreResponseUnmarshaller.Instance;

            return Invoke<DescribeKeyValueStoreResponse>(request, options);
        }



        /// <summary>
        /// Specifies the key value store and its configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyValueStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKeyValueStore service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DescribeKeyValueStore">REST API Reference for DescribeKeyValueStore Operation</seealso>
        public virtual Task<DescribeKeyValueStoreResponse> DescribeKeyValueStoreAsync(DescribeKeyValueStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeKeyValueStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyValueStoreResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeKeyValueStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateDistributionTenantWebACL

        internal virtual DisassociateDistributionTenantWebACLResponse DisassociateDistributionTenantWebACL(DisassociateDistributionTenantWebACLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateDistributionTenantWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDistributionTenantWebACLResponseUnmarshaller.Instance;

            return Invoke<DisassociateDistributionTenantWebACLResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a distribution tenant from the WAF web ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDistributionTenantWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateDistributionTenantWebACL service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DisassociateDistributionTenantWebACL">REST API Reference for DisassociateDistributionTenantWebACL Operation</seealso>
        public virtual Task<DisassociateDistributionTenantWebACLResponse> DisassociateDistributionTenantWebACLAsync(DisassociateDistributionTenantWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateDistributionTenantWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDistributionTenantWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateDistributionTenantWebACLResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateDistributionWebACL

        internal virtual DisassociateDistributionWebACLResponse DisassociateDistributionWebACL(DisassociateDistributionWebACLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateDistributionWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDistributionWebACLResponseUnmarshaller.Instance;

            return Invoke<DisassociateDistributionWebACLResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a distribution from the WAF web ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDistributionWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateDistributionWebACL service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/DisassociateDistributionWebACL">REST API Reference for DisassociateDistributionWebACL Operation</seealso>
        public virtual Task<DisassociateDistributionWebACLResponse> DisassociateDistributionWebACLAsync(DisassociateDistributionWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateDistributionWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDistributionWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateDistributionWebACLResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAnycastIpList

        internal virtual GetAnycastIpListResponse GetAnycastIpList(GetAnycastIpListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAnycastIpListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnycastIpListResponseUnmarshaller.Instance;

            return Invoke<GetAnycastIpListResponse>(request, options);
        }



        /// <summary>
        /// Gets an Anycast static IP list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnycastIpList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAnycastIpList service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetAnycastIpList">REST API Reference for GetAnycastIpList Operation</seealso>
        public virtual Task<GetAnycastIpListResponse> GetAnycastIpListAsync(GetAnycastIpListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAnycastIpListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnycastIpListResponseUnmarshaller.Instance;

            return InvokeAsync<GetAnycastIpListResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCachePolicy

        internal virtual GetCachePolicyResponse GetCachePolicy(GetCachePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCachePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCachePolicyResponseUnmarshaller.Instance;

            return Invoke<GetCachePolicyResponse>(request, options);
        }



        /// <summary>
        /// Gets a cache policy, including the following metadata:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The policy's identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The date and time when the policy was last modified.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get a cache policy, you must provide the policy's identifier. If the cache policy
        /// is attached to a distribution's cache behavior, you can get the policy's identifier
        /// using <c>ListDistributions</c> or <c>GetDistribution</c>. If the cache policy is not
        /// attached to a cache behavior, you can get the identifier using <c>ListCachePolicies</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCachePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCachePolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCachePolicyException">
        /// The cache policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetCachePolicy">REST API Reference for GetCachePolicy Operation</seealso>
        public virtual Task<GetCachePolicyResponse> GetCachePolicyAsync(GetCachePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCachePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCachePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetCachePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCachePolicyConfig

        internal virtual GetCachePolicyConfigResponse GetCachePolicyConfig(GetCachePolicyConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCachePolicyConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCachePolicyConfigResponseUnmarshaller.Instance;

            return Invoke<GetCachePolicyConfigResponse>(request, options);
        }



        /// <summary>
        /// Gets a cache policy configuration.
        /// 
        ///  
        /// <para>
        /// To get a cache policy configuration, you must provide the policy's identifier. If
        /// the cache policy is attached to a distribution's cache behavior, you can get the policy's
        /// identifier using <c>ListDistributions</c> or <c>GetDistribution</c>. If the cache
        /// policy is not attached to a cache behavior, you can get the identifier using <c>ListCachePolicies</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCachePolicyConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCachePolicyConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCachePolicyException">
        /// The cache policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetCachePolicyConfig">REST API Reference for GetCachePolicyConfig Operation</seealso>
        public virtual Task<GetCachePolicyConfigResponse> GetCachePolicyConfigAsync(GetCachePolicyConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCachePolicyConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCachePolicyConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetCachePolicyConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCloudFrontOriginAccessIdentity

        internal virtual GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity()
        {
            return GetCloudFrontOriginAccessIdentity(new GetCloudFrontOriginAccessIdentityRequest());
        }
        internal virtual GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return Invoke<GetCloudFrontOriginAccessIdentityResponse>(request, options);
        }


        /// <summary>
        /// Get the information about an origin access identity.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetCloudFrontOriginAccessIdentity">REST API Reference for GetCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual Task<GetCloudFrontOriginAccessIdentityResponse> GetCloudFrontOriginAccessIdentityAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetCloudFrontOriginAccessIdentityAsync(new GetCloudFrontOriginAccessIdentityRequest(), cancellationToken);
        }



        /// <summary>
        /// Get the information about an origin access identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetCloudFrontOriginAccessIdentity">REST API Reference for GetCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual Task<GetCloudFrontOriginAccessIdentityResponse> GetCloudFrontOriginAccessIdentityAsync(GetCloudFrontOriginAccessIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<GetCloudFrontOriginAccessIdentityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCloudFrontOriginAccessIdentityConfig

        internal virtual GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig()
        {
            return GetCloudFrontOriginAccessIdentityConfig(new GetCloudFrontOriginAccessIdentityConfigRequest());
        }
        internal virtual GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudFrontOriginAccessIdentityConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudFrontOriginAccessIdentityConfigResponseUnmarshaller.Instance;

            return Invoke<GetCloudFrontOriginAccessIdentityConfigResponse>(request, options);
        }


        /// <summary>
        /// Get the configuration information about an origin access identity.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentityConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetCloudFrontOriginAccessIdentityConfig">REST API Reference for GetCloudFrontOriginAccessIdentityConfig Operation</seealso>
        public virtual Task<GetCloudFrontOriginAccessIdentityConfigResponse> GetCloudFrontOriginAccessIdentityConfigAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetCloudFrontOriginAccessIdentityConfigAsync(new GetCloudFrontOriginAccessIdentityConfigRequest(), cancellationToken);
        }



        /// <summary>
        /// Get the configuration information about an origin access identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentityConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentityConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetCloudFrontOriginAccessIdentityConfig">REST API Reference for GetCloudFrontOriginAccessIdentityConfig Operation</seealso>
        public virtual Task<GetCloudFrontOriginAccessIdentityConfigResponse> GetCloudFrontOriginAccessIdentityConfigAsync(GetCloudFrontOriginAccessIdentityConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudFrontOriginAccessIdentityConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudFrontOriginAccessIdentityConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetCloudFrontOriginAccessIdentityConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetConnectionGroup

        internal virtual GetConnectionGroupResponse GetConnectionGroup(GetConnectionGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionGroupResponseUnmarshaller.Instance;

            return Invoke<GetConnectionGroupResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a connection group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnectionGroup service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetConnectionGroup">REST API Reference for GetConnectionGroup Operation</seealso>
        public virtual Task<GetConnectionGroupResponse> GetConnectionGroupAsync(GetConnectionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectionGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetConnectionGroupByRoutingEndpoint

        internal virtual GetConnectionGroupByRoutingEndpointResponse GetConnectionGroupByRoutingEndpoint(GetConnectionGroupByRoutingEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionGroupByRoutingEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionGroupByRoutingEndpointResponseUnmarshaller.Instance;

            return Invoke<GetConnectionGroupByRoutingEndpointResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a connection group by using the endpoint that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionGroupByRoutingEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnectionGroupByRoutingEndpoint service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetConnectionGroupByRoutingEndpoint">REST API Reference for GetConnectionGroupByRoutingEndpoint Operation</seealso>
        public virtual Task<GetConnectionGroupByRoutingEndpointResponse> GetConnectionGroupByRoutingEndpointAsync(GetConnectionGroupByRoutingEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionGroupByRoutingEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionGroupByRoutingEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectionGroupByRoutingEndpointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetContinuousDeploymentPolicy

        internal virtual GetContinuousDeploymentPolicyResponse GetContinuousDeploymentPolicy(GetContinuousDeploymentPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContinuousDeploymentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContinuousDeploymentPolicyResponseUnmarshaller.Instance;

            return Invoke<GetContinuousDeploymentPolicyResponse>(request, options);
        }



        /// <summary>
        /// Gets a continuous deployment policy, including metadata (the policy's identifier and
        /// the date and time when the policy was last modified).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContinuousDeploymentPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContinuousDeploymentPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchContinuousDeploymentPolicyException">
        /// The continuous deployment policy doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetContinuousDeploymentPolicy">REST API Reference for GetContinuousDeploymentPolicy Operation</seealso>
        public virtual Task<GetContinuousDeploymentPolicyResponse> GetContinuousDeploymentPolicyAsync(GetContinuousDeploymentPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContinuousDeploymentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContinuousDeploymentPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetContinuousDeploymentPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetContinuousDeploymentPolicyConfig

        internal virtual GetContinuousDeploymentPolicyConfigResponse GetContinuousDeploymentPolicyConfig(GetContinuousDeploymentPolicyConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContinuousDeploymentPolicyConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContinuousDeploymentPolicyConfigResponseUnmarshaller.Instance;

            return Invoke<GetContinuousDeploymentPolicyConfigResponse>(request, options);
        }



        /// <summary>
        /// Gets configuration information about a continuous deployment policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContinuousDeploymentPolicyConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContinuousDeploymentPolicyConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchContinuousDeploymentPolicyException">
        /// The continuous deployment policy doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetContinuousDeploymentPolicyConfig">REST API Reference for GetContinuousDeploymentPolicyConfig Operation</seealso>
        public virtual Task<GetContinuousDeploymentPolicyConfigResponse> GetContinuousDeploymentPolicyConfigAsync(GetContinuousDeploymentPolicyConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContinuousDeploymentPolicyConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContinuousDeploymentPolicyConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetContinuousDeploymentPolicyConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDistribution

        internal virtual GetDistributionResponse GetDistribution()
        {
            return GetDistribution(new GetDistributionRequest());
        }
        internal virtual GetDistributionResponse GetDistribution(GetDistributionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionResponseUnmarshaller.Instance;

            return Invoke<GetDistributionResponse>(request, options);
        }


        /// <summary>
        /// Get the information about a distribution.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetDistribution">REST API Reference for GetDistribution Operation</seealso>
        public virtual Task<GetDistributionResponse> GetDistributionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetDistributionAsync(new GetDistributionRequest(), cancellationToken);
        }



        /// <summary>
        /// Get the information about a distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetDistribution">REST API Reference for GetDistribution Operation</seealso>
        public virtual Task<GetDistributionResponse> GetDistributionAsync(GetDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<GetDistributionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDistributionConfig

        internal virtual GetDistributionConfigResponse GetDistributionConfig()
        {
            return GetDistributionConfig(new GetDistributionConfigRequest());
        }
        internal virtual GetDistributionConfigResponse GetDistributionConfig(GetDistributionConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDistributionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionConfigResponseUnmarshaller.Instance;

            return Invoke<GetDistributionConfigResponse>(request, options);
        }


        /// <summary>
        /// Get the configuration information about a distribution.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetDistributionConfig">REST API Reference for GetDistributionConfig Operation</seealso>
        public virtual Task<GetDistributionConfigResponse> GetDistributionConfigAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetDistributionConfigAsync(new GetDistributionConfigRequest(), cancellationToken);
        }



        /// <summary>
        /// Get the configuration information about a distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetDistributionConfig">REST API Reference for GetDistributionConfig Operation</seealso>
        public virtual Task<GetDistributionConfigResponse> GetDistributionConfigAsync(GetDistributionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDistributionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetDistributionConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDistributionTenant

        internal virtual GetDistributionTenantResponse GetDistributionTenant(GetDistributionTenantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDistributionTenantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionTenantResponseUnmarshaller.Instance;

            return Invoke<GetDistributionTenantResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a distribution tenant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionTenant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDistributionTenant service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetDistributionTenant">REST API Reference for GetDistributionTenant Operation</seealso>
        public virtual Task<GetDistributionTenantResponse> GetDistributionTenantAsync(GetDistributionTenantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDistributionTenantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionTenantResponseUnmarshaller.Instance;

            return InvokeAsync<GetDistributionTenantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDistributionTenantByDomain

        internal virtual GetDistributionTenantByDomainResponse GetDistributionTenantByDomain(GetDistributionTenantByDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDistributionTenantByDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionTenantByDomainResponseUnmarshaller.Instance;

            return Invoke<GetDistributionTenantByDomainResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a distribution tenant by the associated domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionTenantByDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDistributionTenantByDomain service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetDistributionTenantByDomain">REST API Reference for GetDistributionTenantByDomain Operation</seealso>
        public virtual Task<GetDistributionTenantByDomainResponse> GetDistributionTenantByDomainAsync(GetDistributionTenantByDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDistributionTenantByDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionTenantByDomainResponseUnmarshaller.Instance;

            return InvokeAsync<GetDistributionTenantByDomainResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFieldLevelEncryption

        internal virtual GetFieldLevelEncryptionResponse GetFieldLevelEncryption(GetFieldLevelEncryptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFieldLevelEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFieldLevelEncryptionResponseUnmarshaller.Instance;

            return Invoke<GetFieldLevelEncryptionResponse>(request, options);
        }



        /// <summary>
        /// Get the field-level encryption configuration information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFieldLevelEncryption service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetFieldLevelEncryption">REST API Reference for GetFieldLevelEncryption Operation</seealso>
        public virtual Task<GetFieldLevelEncryptionResponse> GetFieldLevelEncryptionAsync(GetFieldLevelEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFieldLevelEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFieldLevelEncryptionResponseUnmarshaller.Instance;

            return InvokeAsync<GetFieldLevelEncryptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFieldLevelEncryptionConfig

        internal virtual GetFieldLevelEncryptionConfigResponse GetFieldLevelEncryptionConfig(GetFieldLevelEncryptionConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFieldLevelEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<GetFieldLevelEncryptionConfigResponse>(request, options);
        }



        /// <summary>
        /// Get the field-level encryption configuration information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryptionConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFieldLevelEncryptionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetFieldLevelEncryptionConfig">REST API Reference for GetFieldLevelEncryptionConfig Operation</seealso>
        public virtual Task<GetFieldLevelEncryptionConfigResponse> GetFieldLevelEncryptionConfigAsync(GetFieldLevelEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFieldLevelEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetFieldLevelEncryptionConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFieldLevelEncryptionProfile

        internal virtual GetFieldLevelEncryptionProfileResponse GetFieldLevelEncryptionProfile(GetFieldLevelEncryptionProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFieldLevelEncryptionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return Invoke<GetFieldLevelEncryptionProfileResponse>(request, options);
        }



        /// <summary>
        /// Get the field-level encryption profile information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryptionProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFieldLevelEncryptionProfile service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionProfileException">
        /// The specified profile for field-level encryption doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetFieldLevelEncryptionProfile">REST API Reference for GetFieldLevelEncryptionProfile Operation</seealso>
        public virtual Task<GetFieldLevelEncryptionProfileResponse> GetFieldLevelEncryptionProfileAsync(GetFieldLevelEncryptionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFieldLevelEncryptionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetFieldLevelEncryptionProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFieldLevelEncryptionProfileConfig

        internal virtual GetFieldLevelEncryptionProfileConfigResponse GetFieldLevelEncryptionProfileConfig(GetFieldLevelEncryptionProfileConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFieldLevelEncryptionProfileConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFieldLevelEncryptionProfileConfigResponseUnmarshaller.Instance;

            return Invoke<GetFieldLevelEncryptionProfileConfigResponse>(request, options);
        }



        /// <summary>
        /// Get the field-level encryption profile configuration information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryptionProfileConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFieldLevelEncryptionProfileConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionProfileException">
        /// The specified profile for field-level encryption doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetFieldLevelEncryptionProfileConfig">REST API Reference for GetFieldLevelEncryptionProfileConfig Operation</seealso>
        public virtual Task<GetFieldLevelEncryptionProfileConfigResponse> GetFieldLevelEncryptionProfileConfigAsync(GetFieldLevelEncryptionProfileConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFieldLevelEncryptionProfileConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFieldLevelEncryptionProfileConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetFieldLevelEncryptionProfileConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFunction

        internal virtual GetFunctionResponse GetFunction(GetFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionResponseUnmarshaller.Instance;

            return Invoke<GetFunctionResponse>(request, options);
        }



        /// <summary>
        /// Gets the code of a CloudFront function. To get configuration information and metadata
        /// about a function, use <c>DescribeFunction</c>.
        /// 
        ///  
        /// <para>
        /// To get a function's code, you must provide the function's name and stage. To get these
        /// values, you can use <c>ListFunctions</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFunction service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFunctionExistsException">
        /// The function does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetFunction">REST API Reference for GetFunction Operation</seealso>
        public virtual Task<GetFunctionResponse> GetFunctionAsync(GetFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<GetFunctionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetInvalidation

        internal virtual GetInvalidationResponse GetInvalidation(GetInvalidationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInvalidationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvalidationResponseUnmarshaller.Instance;

            return Invoke<GetInvalidationResponse>(request, options);
        }



        /// <summary>
        /// Get the information about an invalidation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvalidation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInvalidation service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchInvalidationException">
        /// The specified invalidation does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetInvalidation">REST API Reference for GetInvalidation Operation</seealso>
        public virtual Task<GetInvalidationResponse> GetInvalidationAsync(GetInvalidationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInvalidationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvalidationResponseUnmarshaller.Instance;

            return InvokeAsync<GetInvalidationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetInvalidationForDistributionTenant

        internal virtual GetInvalidationForDistributionTenantResponse GetInvalidationForDistributionTenant(GetInvalidationForDistributionTenantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInvalidationForDistributionTenantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvalidationForDistributionTenantResponseUnmarshaller.Instance;

            return Invoke<GetInvalidationForDistributionTenantResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a specific invalidation for a distribution tenant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvalidationForDistributionTenant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInvalidationForDistributionTenant service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchInvalidationException">
        /// The specified invalidation does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetInvalidationForDistributionTenant">REST API Reference for GetInvalidationForDistributionTenant Operation</seealso>
        public virtual Task<GetInvalidationForDistributionTenantResponse> GetInvalidationForDistributionTenantAsync(GetInvalidationForDistributionTenantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInvalidationForDistributionTenantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvalidationForDistributionTenantResponseUnmarshaller.Instance;

            return InvokeAsync<GetInvalidationForDistributionTenantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetKeyGroup

        internal virtual GetKeyGroupResponse GetKeyGroup(GetKeyGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKeyGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyGroupResponseUnmarshaller.Instance;

            return Invoke<GetKeyGroupResponse>(request, options);
        }



        /// <summary>
        /// Gets a key group, including the date and time when the key group was last modified.
        /// 
        ///  
        /// <para>
        /// To get a key group, you must provide the key group's identifier. If the key group
        /// is referenced in a distribution's cache behavior, you can get the key group's identifier
        /// using <c>ListDistributions</c> or <c>GetDistribution</c>. If the key group is not
        /// referenced in a cache behavior, you can get the identifier using <c>ListKeyGroups</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyGroup service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// A resource that was specified is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetKeyGroup">REST API Reference for GetKeyGroup Operation</seealso>
        public virtual Task<GetKeyGroupResponse> GetKeyGroupAsync(GetKeyGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKeyGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetKeyGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetKeyGroupConfig

        internal virtual GetKeyGroupConfigResponse GetKeyGroupConfig(GetKeyGroupConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKeyGroupConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyGroupConfigResponseUnmarshaller.Instance;

            return Invoke<GetKeyGroupConfigResponse>(request, options);
        }



        /// <summary>
        /// Gets a key group configuration.
        /// 
        ///  
        /// <para>
        /// To get a key group configuration, you must provide the key group's identifier. If
        /// the key group is referenced in a distribution's cache behavior, you can get the key
        /// group's identifier using <c>ListDistributions</c> or <c>GetDistribution</c>. If the
        /// key group is not referenced in a cache behavior, you can get the identifier using
        /// <c>ListKeyGroups</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyGroupConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyGroupConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// A resource that was specified is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetKeyGroupConfig">REST API Reference for GetKeyGroupConfig Operation</seealso>
        public virtual Task<GetKeyGroupConfigResponse> GetKeyGroupConfigAsync(GetKeyGroupConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKeyGroupConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyGroupConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetKeyGroupConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetManagedCertificateDetails

        internal virtual GetManagedCertificateDetailsResponse GetManagedCertificateDetails(GetManagedCertificateDetailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedCertificateDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedCertificateDetailsResponseUnmarshaller.Instance;

            return Invoke<GetManagedCertificateDetailsResponse>(request, options);
        }



        /// <summary>
        /// Gets details about the CloudFront managed ACM certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedCertificateDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetManagedCertificateDetails service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetManagedCertificateDetails">REST API Reference for GetManagedCertificateDetails Operation</seealso>
        public virtual Task<GetManagedCertificateDetailsResponse> GetManagedCertificateDetailsAsync(GetManagedCertificateDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedCertificateDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedCertificateDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetManagedCertificateDetailsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMonitoringSubscription

        internal virtual GetMonitoringSubscriptionResponse GetMonitoringSubscription(GetMonitoringSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMonitoringSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMonitoringSubscriptionResponseUnmarshaller.Instance;

            return Invoke<GetMonitoringSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Gets information about whether additional CloudWatch metrics are enabled for the specified
        /// CloudFront distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMonitoringSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMonitoringSubscription service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchMonitoringSubscriptionException">
        /// A monitoring subscription does not exist for the specified distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetMonitoringSubscription">REST API Reference for GetMonitoringSubscription Operation</seealso>
        public virtual Task<GetMonitoringSubscriptionResponse> GetMonitoringSubscriptionAsync(GetMonitoringSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMonitoringSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMonitoringSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<GetMonitoringSubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetOriginAccessControl

        internal virtual GetOriginAccessControlResponse GetOriginAccessControl(GetOriginAccessControlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOriginAccessControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOriginAccessControlResponseUnmarshaller.Instance;

            return Invoke<GetOriginAccessControlResponse>(request, options);
        }



        /// <summary>
        /// Gets a CloudFront origin access control, including its unique identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOriginAccessControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOriginAccessControl service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginAccessControlException">
        /// The origin access control does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetOriginAccessControl">REST API Reference for GetOriginAccessControl Operation</seealso>
        public virtual Task<GetOriginAccessControlResponse> GetOriginAccessControlAsync(GetOriginAccessControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOriginAccessControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOriginAccessControlResponseUnmarshaller.Instance;

            return InvokeAsync<GetOriginAccessControlResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetOriginAccessControlConfig

        internal virtual GetOriginAccessControlConfigResponse GetOriginAccessControlConfig(GetOriginAccessControlConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOriginAccessControlConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOriginAccessControlConfigResponseUnmarshaller.Instance;

            return Invoke<GetOriginAccessControlConfigResponse>(request, options);
        }



        /// <summary>
        /// Gets a CloudFront origin access control configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOriginAccessControlConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOriginAccessControlConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginAccessControlException">
        /// The origin access control does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetOriginAccessControlConfig">REST API Reference for GetOriginAccessControlConfig Operation</seealso>
        public virtual Task<GetOriginAccessControlConfigResponse> GetOriginAccessControlConfigAsync(GetOriginAccessControlConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOriginAccessControlConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOriginAccessControlConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetOriginAccessControlConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetOriginRequestPolicy

        internal virtual GetOriginRequestPolicyResponse GetOriginRequestPolicy(GetOriginRequestPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOriginRequestPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOriginRequestPolicyResponseUnmarshaller.Instance;

            return Invoke<GetOriginRequestPolicyResponse>(request, options);
        }



        /// <summary>
        /// Gets an origin request policy, including the following metadata:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The policy's identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The date and time when the policy was last modified.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get an origin request policy, you must provide the policy's identifier. If the
        /// origin request policy is attached to a distribution's cache behavior, you can get
        /// the policy's identifier using <c>ListDistributions</c> or <c>GetDistribution</c>.
        /// If the origin request policy is not attached to a cache behavior, you can get the
        /// identifier using <c>ListOriginRequestPolicies</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOriginRequestPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOriginRequestPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginRequestPolicyException">
        /// The origin request policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetOriginRequestPolicy">REST API Reference for GetOriginRequestPolicy Operation</seealso>
        public virtual Task<GetOriginRequestPolicyResponse> GetOriginRequestPolicyAsync(GetOriginRequestPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOriginRequestPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOriginRequestPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetOriginRequestPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetOriginRequestPolicyConfig

        internal virtual GetOriginRequestPolicyConfigResponse GetOriginRequestPolicyConfig(GetOriginRequestPolicyConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOriginRequestPolicyConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOriginRequestPolicyConfigResponseUnmarshaller.Instance;

            return Invoke<GetOriginRequestPolicyConfigResponse>(request, options);
        }



        /// <summary>
        /// Gets an origin request policy configuration.
        /// 
        ///  
        /// <para>
        /// To get an origin request policy configuration, you must provide the policy's identifier.
        /// If the origin request policy is attached to a distribution's cache behavior, you can
        /// get the policy's identifier using <c>ListDistributions</c> or <c>GetDistribution</c>.
        /// If the origin request policy is not attached to a cache behavior, you can get the
        /// identifier using <c>ListOriginRequestPolicies</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOriginRequestPolicyConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOriginRequestPolicyConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginRequestPolicyException">
        /// The origin request policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetOriginRequestPolicyConfig">REST API Reference for GetOriginRequestPolicyConfig Operation</seealso>
        public virtual Task<GetOriginRequestPolicyConfigResponse> GetOriginRequestPolicyConfigAsync(GetOriginRequestPolicyConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOriginRequestPolicyConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOriginRequestPolicyConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetOriginRequestPolicyConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetPublicKey

        internal virtual GetPublicKeyResponse GetPublicKey(GetPublicKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicKeyResponseUnmarshaller.Instance;

            return Invoke<GetPublicKeyResponse>(request, options);
        }



        /// <summary>
        /// Gets a public key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPublicKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPublicKey service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchPublicKeyException">
        /// The specified public key doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetPublicKey">REST API Reference for GetPublicKey Operation</seealso>
        public virtual Task<GetPublicKeyResponse> GetPublicKeyAsync(GetPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicKeyResponseUnmarshaller.Instance;

            return InvokeAsync<GetPublicKeyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetPublicKeyConfig

        internal virtual GetPublicKeyConfigResponse GetPublicKeyConfig(GetPublicKeyConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPublicKeyConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicKeyConfigResponseUnmarshaller.Instance;

            return Invoke<GetPublicKeyConfigResponse>(request, options);
        }



        /// <summary>
        /// Gets a public key configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPublicKeyConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPublicKeyConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchPublicKeyException">
        /// The specified public key doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetPublicKeyConfig">REST API Reference for GetPublicKeyConfig Operation</seealso>
        public virtual Task<GetPublicKeyConfigResponse> GetPublicKeyConfigAsync(GetPublicKeyConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPublicKeyConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicKeyConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetPublicKeyConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRealtimeLogConfig

        internal virtual GetRealtimeLogConfigResponse GetRealtimeLogConfig(GetRealtimeLogConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRealtimeLogConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRealtimeLogConfigResponseUnmarshaller.Instance;

            return Invoke<GetRealtimeLogConfigResponse>(request, options);
        }



        /// <summary>
        /// Gets a real-time log configuration.
        /// 
        ///  
        /// <para>
        /// To get a real-time log configuration, you can provide the configuration's name or
        /// its Amazon Resource Name (ARN). You must provide at least one. If you provide both,
        /// CloudFront uses the name to identify the real-time log configuration to get.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRealtimeLogConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRealtimeLogConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchRealtimeLogConfigException">
        /// The real-time log configuration does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetRealtimeLogConfig">REST API Reference for GetRealtimeLogConfig Operation</seealso>
        public virtual Task<GetRealtimeLogConfigResponse> GetRealtimeLogConfigAsync(GetRealtimeLogConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRealtimeLogConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRealtimeLogConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetRealtimeLogConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetResponseHeadersPolicy

        internal virtual GetResponseHeadersPolicyResponse GetResponseHeadersPolicy(GetResponseHeadersPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResponseHeadersPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResponseHeadersPolicyResponseUnmarshaller.Instance;

            return Invoke<GetResponseHeadersPolicyResponse>(request, options);
        }



        /// <summary>
        /// Gets a response headers policy, including metadata (the policy's identifier and the
        /// date and time when the policy was last modified).
        /// 
        ///  
        /// <para>
        /// To get a response headers policy, you must provide the policy's identifier. If the
        /// response headers policy is attached to a distribution's cache behavior, you can get
        /// the policy's identifier using <c>ListDistributions</c> or <c>GetDistribution</c>.
        /// If the response headers policy is not attached to a cache behavior, you can get the
        /// identifier using <c>ListResponseHeadersPolicies</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResponseHeadersPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResponseHeadersPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResponseHeadersPolicyException">
        /// The response headers policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetResponseHeadersPolicy">REST API Reference for GetResponseHeadersPolicy Operation</seealso>
        public virtual Task<GetResponseHeadersPolicyResponse> GetResponseHeadersPolicyAsync(GetResponseHeadersPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResponseHeadersPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResponseHeadersPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetResponseHeadersPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetResponseHeadersPolicyConfig

        internal virtual GetResponseHeadersPolicyConfigResponse GetResponseHeadersPolicyConfig(GetResponseHeadersPolicyConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResponseHeadersPolicyConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResponseHeadersPolicyConfigResponseUnmarshaller.Instance;

            return Invoke<GetResponseHeadersPolicyConfigResponse>(request, options);
        }



        /// <summary>
        /// Gets a response headers policy configuration.
        /// 
        ///  
        /// <para>
        /// To get a response headers policy configuration, you must provide the policy's identifier.
        /// If the response headers policy is attached to a distribution's cache behavior, you
        /// can get the policy's identifier using <c>ListDistributions</c> or <c>GetDistribution</c>.
        /// If the response headers policy is not attached to a cache behavior, you can get the
        /// identifier using <c>ListResponseHeadersPolicies</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResponseHeadersPolicyConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResponseHeadersPolicyConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResponseHeadersPolicyException">
        /// The response headers policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetResponseHeadersPolicyConfig">REST API Reference for GetResponseHeadersPolicyConfig Operation</seealso>
        public virtual Task<GetResponseHeadersPolicyConfigResponse> GetResponseHeadersPolicyConfigAsync(GetResponseHeadersPolicyConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResponseHeadersPolicyConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResponseHeadersPolicyConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetResponseHeadersPolicyConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetStreamingDistribution

        internal virtual GetStreamingDistributionResponse GetStreamingDistribution()
        {
            return GetStreamingDistribution(new GetStreamingDistributionRequest());
        }
        internal virtual GetStreamingDistributionResponse GetStreamingDistribution(GetStreamingDistributionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStreamingDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStreamingDistributionResponseUnmarshaller.Instance;

            return Invoke<GetStreamingDistributionResponse>(request, options);
        }


        /// <summary>
        /// Gets information about a specified RTMP distribution, including the distribution configuration.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetStreamingDistribution">REST API Reference for GetStreamingDistribution Operation</seealso>
        public virtual Task<GetStreamingDistributionResponse> GetStreamingDistributionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetStreamingDistributionAsync(new GetStreamingDistributionRequest(), cancellationToken);
        }



        /// <summary>
        /// Gets information about a specified RTMP distribution, including the distribution configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetStreamingDistribution">REST API Reference for GetStreamingDistribution Operation</seealso>
        public virtual Task<GetStreamingDistributionResponse> GetStreamingDistributionAsync(GetStreamingDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStreamingDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStreamingDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<GetStreamingDistributionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetStreamingDistributionConfig

        internal virtual GetStreamingDistributionConfigResponse GetStreamingDistributionConfig()
        {
            return GetStreamingDistributionConfig(new GetStreamingDistributionConfigRequest());
        }
        internal virtual GetStreamingDistributionConfigResponse GetStreamingDistributionConfig(GetStreamingDistributionConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStreamingDistributionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStreamingDistributionConfigResponseUnmarshaller.Instance;

            return Invoke<GetStreamingDistributionConfigResponse>(request, options);
        }


        /// <summary>
        /// Get the configuration information about a streaming distribution.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStreamingDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetStreamingDistributionConfig">REST API Reference for GetStreamingDistributionConfig Operation</seealso>
        public virtual Task<GetStreamingDistributionConfigResponse> GetStreamingDistributionConfigAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetStreamingDistributionConfigAsync(new GetStreamingDistributionConfigRequest(), cancellationToken);
        }



        /// <summary>
        /// Get the configuration information about a streaming distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistributionConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStreamingDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetStreamingDistributionConfig">REST API Reference for GetStreamingDistributionConfig Operation</seealso>
        public virtual Task<GetStreamingDistributionConfigResponse> GetStreamingDistributionConfigAsync(GetStreamingDistributionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStreamingDistributionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStreamingDistributionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetStreamingDistributionConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetVpcOrigin

        internal virtual GetVpcOriginResponse GetVpcOrigin(GetVpcOriginRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVpcOriginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcOriginResponseUnmarshaller.Instance;

            return Invoke<GetVpcOriginResponse>(request, options);
        }



        /// <summary>
        /// Get the details of an Amazon CloudFront VPC origin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcOrigin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVpcOrigin service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/GetVpcOrigin">REST API Reference for GetVpcOrigin Operation</seealso>
        public virtual Task<GetVpcOriginResponse> GetVpcOriginAsync(GetVpcOriginRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVpcOriginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcOriginResponseUnmarshaller.Instance;

            return InvokeAsync<GetVpcOriginResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAnycastIpLists

        internal virtual ListAnycastIpListsResponse ListAnycastIpLists(ListAnycastIpListsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnycastIpListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnycastIpListsResponseUnmarshaller.Instance;

            return Invoke<ListAnycastIpListsResponse>(request, options);
        }



        /// <summary>
        /// Lists your Anycast static IP lists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnycastIpLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAnycastIpLists service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListAnycastIpLists">REST API Reference for ListAnycastIpLists Operation</seealso>
        public virtual Task<ListAnycastIpListsResponse> ListAnycastIpListsAsync(ListAnycastIpListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnycastIpListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnycastIpListsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAnycastIpListsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCachePolicies

        internal virtual ListCachePoliciesResponse ListCachePolicies(ListCachePoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCachePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCachePoliciesResponseUnmarshaller.Instance;

            return Invoke<ListCachePoliciesResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of cache policies.
        /// 
        ///  
        /// <para>
        /// You can optionally apply a filter to return only the managed policies created by Amazon
        /// Web Services, or only the custom policies created in your Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCachePolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCachePolicies service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCachePolicyException">
        /// The cache policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListCachePolicies">REST API Reference for ListCachePolicies Operation</seealso>
        public virtual Task<ListCachePoliciesResponse> ListCachePoliciesAsync(ListCachePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCachePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCachePoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCachePoliciesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCloudFrontOriginAccessIdentities

        internal virtual ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities()
        {
            return ListCloudFrontOriginAccessIdentities(new ListCloudFrontOriginAccessIdentitiesRequest());
        }
        internal virtual ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudFrontOriginAccessIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudFrontOriginAccessIdentitiesResponseUnmarshaller.Instance;

            return Invoke<ListCloudFrontOriginAccessIdentitiesResponse>(request, options);
        }


        /// <summary>
        /// Lists origin access identities.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListCloudFrontOriginAccessIdentities">REST API Reference for ListCloudFrontOriginAccessIdentities Operation</seealso>
        public virtual Task<ListCloudFrontOriginAccessIdentitiesResponse> ListCloudFrontOriginAccessIdentitiesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListCloudFrontOriginAccessIdentitiesAsync(new ListCloudFrontOriginAccessIdentitiesRequest(), cancellationToken);
        }



        /// <summary>
        /// Lists origin access identities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudFrontOriginAccessIdentities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListCloudFrontOriginAccessIdentities">REST API Reference for ListCloudFrontOriginAccessIdentities Operation</seealso>
        public virtual Task<ListCloudFrontOriginAccessIdentitiesResponse> ListCloudFrontOriginAccessIdentitiesAsync(ListCloudFrontOriginAccessIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudFrontOriginAccessIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudFrontOriginAccessIdentitiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCloudFrontOriginAccessIdentitiesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListConflictingAliases

        internal virtual ListConflictingAliasesResponse ListConflictingAliases(ListConflictingAliasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConflictingAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConflictingAliasesResponseUnmarshaller.Instance;

            return Invoke<ListConflictingAliasesResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// The <c>ListConflictingAliases</c> API operation only supports standard distributions.
        /// To list domain conflicts for both standard distributions and distribution tenants,
        /// we recommend that you use the <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ListDomainConflicts.html">ListDomainConflicts</a>
        /// API operation instead.
        /// 
        ///  </note> 
        /// <para>
        /// Gets a list of aliases that conflict or overlap with the provided alias, and the associated
        /// CloudFront standard distribution and Amazon Web Services accounts for each conflicting
        /// alias. An alias is commonly known as a custom domain or vanity domain. It can also
        /// be called a CNAME or alternate domain name.
        /// </para>
        ///  
        /// <para>
        /// In the returned list, the standard distribution and account IDs are partially hidden,
        /// which allows you to identify the standard distribution and accounts that you own,
        /// and helps to protect the information of ones that you don't own.
        /// </para>
        ///  
        /// <para>
        /// Use this operation to find aliases that are in use in CloudFront that conflict or
        /// overlap with the provided alias. For example, if you provide <c>www.example.com</c>
        /// as input, the returned list can include <c>www.example.com</c> and the overlapping
        /// wildcard alternate domain name (<c><em>.example.com</c>), if they exist. If you provide
        /// <c></em>.example.com</c> as input, the returned list can include <c>*.example.com</c>
        /// and any alternate domain names covered by that wildcard (for example, <c>www.example.com</c>,
        /// <c>test.example.com</c>, <c>dev.example.com</c>, and so on), if they exist.
        /// </para>
        ///  
        /// <para>
        /// To list conflicting aliases, specify the alias to search and the ID of a standard
        /// distribution in your account that has an attached TLS certificate that includes the
        /// provided alias. For more information, including how to set up the standard distribution
        /// and certificate, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/CNAMEs.html#alternate-domain-names-move">Moving
        /// an alternate domain name to a different standard distribution or distribution tenant</a>
        /// in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConflictingAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConflictingAliases service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListConflictingAliases">REST API Reference for ListConflictingAliases Operation</seealso>
        public virtual Task<ListConflictingAliasesResponse> ListConflictingAliasesAsync(ListConflictingAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConflictingAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConflictingAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListConflictingAliasesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListConnectionGroups

        internal virtual ListConnectionGroupsResponse ListConnectionGroups(ListConnectionGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectionGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectionGroupsResponseUnmarshaller.Instance;

            return Invoke<ListConnectionGroupsResponse>(request, options);
        }



        /// <summary>
        /// Lists the connection groups in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectionGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnectionGroups service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListConnectionGroups">REST API Reference for ListConnectionGroups Operation</seealso>
        public virtual Task<ListConnectionGroupsResponse> ListConnectionGroupsAsync(ListConnectionGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectionGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectionGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConnectionGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListContinuousDeploymentPolicies

        internal virtual ListContinuousDeploymentPoliciesResponse ListContinuousDeploymentPolicies(ListContinuousDeploymentPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContinuousDeploymentPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContinuousDeploymentPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListContinuousDeploymentPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of the continuous deployment policies in your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContinuousDeploymentPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContinuousDeploymentPolicies service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchContinuousDeploymentPolicyException">
        /// The continuous deployment policy doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListContinuousDeploymentPolicies">REST API Reference for ListContinuousDeploymentPolicies Operation</seealso>
        public virtual Task<ListContinuousDeploymentPoliciesResponse> ListContinuousDeploymentPoliciesAsync(ListContinuousDeploymentPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContinuousDeploymentPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContinuousDeploymentPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListContinuousDeploymentPoliciesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDistributions

        internal virtual ListDistributionsResponse ListDistributions()
        {
            return ListDistributions(new ListDistributionsRequest());
        }
        internal virtual ListDistributionsResponse ListDistributions(ListDistributionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsResponseUnmarshaller.Instance;

            return Invoke<ListDistributionsResponse>(request, options);
        }


        /// <summary>
        /// List CloudFront distributions.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributions">REST API Reference for ListDistributions Operation</seealso>
        public virtual Task<ListDistributionsResponse> ListDistributionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListDistributionsAsync(new ListDistributionsRequest(), cancellationToken);
        }



        /// <summary>
        /// List CloudFront distributions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributions">REST API Reference for ListDistributions Operation</seealso>
        public virtual Task<ListDistributionsResponse> ListDistributionsAsync(ListDistributionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDistributionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDistributionsByAnycastIpListId

        internal virtual ListDistributionsByAnycastIpListIdResponse ListDistributionsByAnycastIpListId(ListDistributionsByAnycastIpListIdRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionsByAnycastIpListIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsByAnycastIpListIdResponseUnmarshaller.Instance;

            return Invoke<ListDistributionsByAnycastIpListIdResponse>(request, options);
        }



        /// <summary>
        /// Lists the distributions in your account that are associated with the specified <c>AnycastIpListId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByAnycastIpListId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDistributionsByAnycastIpListId service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByAnycastIpListId">REST API Reference for ListDistributionsByAnycastIpListId Operation</seealso>
        public virtual Task<ListDistributionsByAnycastIpListIdResponse> ListDistributionsByAnycastIpListIdAsync(ListDistributionsByAnycastIpListIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionsByAnycastIpListIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsByAnycastIpListIdResponseUnmarshaller.Instance;

            return InvokeAsync<ListDistributionsByAnycastIpListIdResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDistributionsByCachePolicyId

        internal virtual ListDistributionsByCachePolicyIdResponse ListDistributionsByCachePolicyId(ListDistributionsByCachePolicyIdRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionsByCachePolicyIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsByCachePolicyIdResponseUnmarshaller.Instance;

            return Invoke<ListDistributionsByCachePolicyIdResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of distribution IDs for distributions that have a cache behavior that's
        /// associated with the specified cache policy.
        /// 
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByCachePolicyId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDistributionsByCachePolicyId service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCachePolicyException">
        /// The cache policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByCachePolicyId">REST API Reference for ListDistributionsByCachePolicyId Operation</seealso>
        public virtual Task<ListDistributionsByCachePolicyIdResponse> ListDistributionsByCachePolicyIdAsync(ListDistributionsByCachePolicyIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionsByCachePolicyIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsByCachePolicyIdResponseUnmarshaller.Instance;

            return InvokeAsync<ListDistributionsByCachePolicyIdResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDistributionsByConnectionMode

        internal virtual ListDistributionsByConnectionModeResponse ListDistributionsByConnectionMode(ListDistributionsByConnectionModeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionsByConnectionModeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsByConnectionModeResponseUnmarshaller.Instance;

            return Invoke<ListDistributionsByConnectionModeResponse>(request, options);
        }



        /// <summary>
        /// Lists the distributions by the connection mode that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByConnectionMode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDistributionsByConnectionMode service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByConnectionMode">REST API Reference for ListDistributionsByConnectionMode Operation</seealso>
        public virtual Task<ListDistributionsByConnectionModeResponse> ListDistributionsByConnectionModeAsync(ListDistributionsByConnectionModeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionsByConnectionModeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsByConnectionModeResponseUnmarshaller.Instance;

            return InvokeAsync<ListDistributionsByConnectionModeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDistributionsByKeyGroup

        internal virtual ListDistributionsByKeyGroupResponse ListDistributionsByKeyGroup(ListDistributionsByKeyGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionsByKeyGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsByKeyGroupResponseUnmarshaller.Instance;

            return Invoke<ListDistributionsByKeyGroupResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of distribution IDs for distributions that have a cache behavior that
        /// references the specified key group.
        /// 
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByKeyGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDistributionsByKeyGroup service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// A resource that was specified is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByKeyGroup">REST API Reference for ListDistributionsByKeyGroup Operation</seealso>
        public virtual Task<ListDistributionsByKeyGroupResponse> ListDistributionsByKeyGroupAsync(ListDistributionsByKeyGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionsByKeyGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsByKeyGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ListDistributionsByKeyGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDistributionsByOriginRequestPolicyId

        internal virtual ListDistributionsByOriginRequestPolicyIdResponse ListDistributionsByOriginRequestPolicyId(ListDistributionsByOriginRequestPolicyIdRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionsByOriginRequestPolicyIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsByOriginRequestPolicyIdResponseUnmarshaller.Instance;

            return Invoke<ListDistributionsByOriginRequestPolicyIdResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of distribution IDs for distributions that have a cache behavior that's
        /// associated with the specified origin request policy.
        /// 
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByOriginRequestPolicyId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDistributionsByOriginRequestPolicyId service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginRequestPolicyException">
        /// The origin request policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByOriginRequestPolicyId">REST API Reference for ListDistributionsByOriginRequestPolicyId Operation</seealso>
        public virtual Task<ListDistributionsByOriginRequestPolicyIdResponse> ListDistributionsByOriginRequestPolicyIdAsync(ListDistributionsByOriginRequestPolicyIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionsByOriginRequestPolicyIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsByOriginRequestPolicyIdResponseUnmarshaller.Instance;

            return InvokeAsync<ListDistributionsByOriginRequestPolicyIdResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDistributionsByRealtimeLogConfig

        internal virtual ListDistributionsByRealtimeLogConfigResponse ListDistributionsByRealtimeLogConfig(ListDistributionsByRealtimeLogConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionsByRealtimeLogConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsByRealtimeLogConfigResponseUnmarshaller.Instance;

            return Invoke<ListDistributionsByRealtimeLogConfigResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of distributions that have a cache behavior that's associated with the
        /// specified real-time log configuration.
        /// 
        ///  
        /// <para>
        /// You can specify the real-time log configuration by its name or its Amazon Resource
        /// Name (ARN). You must provide at least one. If you provide both, CloudFront uses the
        /// name to identify the real-time log configuration to list distributions for.
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByRealtimeLogConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDistributionsByRealtimeLogConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByRealtimeLogConfig">REST API Reference for ListDistributionsByRealtimeLogConfig Operation</seealso>
        public virtual Task<ListDistributionsByRealtimeLogConfigResponse> ListDistributionsByRealtimeLogConfigAsync(ListDistributionsByRealtimeLogConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionsByRealtimeLogConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsByRealtimeLogConfigResponseUnmarshaller.Instance;

            return InvokeAsync<ListDistributionsByRealtimeLogConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDistributionsByResponseHeadersPolicyId

        internal virtual ListDistributionsByResponseHeadersPolicyIdResponse ListDistributionsByResponseHeadersPolicyId(ListDistributionsByResponseHeadersPolicyIdRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionsByResponseHeadersPolicyIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsByResponseHeadersPolicyIdResponseUnmarshaller.Instance;

            return Invoke<ListDistributionsByResponseHeadersPolicyIdResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of distribution IDs for distributions that have a cache behavior that's
        /// associated with the specified response headers policy.
        /// 
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByResponseHeadersPolicyId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDistributionsByResponseHeadersPolicyId service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResponseHeadersPolicyException">
        /// The response headers policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByResponseHeadersPolicyId">REST API Reference for ListDistributionsByResponseHeadersPolicyId Operation</seealso>
        public virtual Task<ListDistributionsByResponseHeadersPolicyIdResponse> ListDistributionsByResponseHeadersPolicyIdAsync(ListDistributionsByResponseHeadersPolicyIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionsByResponseHeadersPolicyIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsByResponseHeadersPolicyIdResponseUnmarshaller.Instance;

            return InvokeAsync<ListDistributionsByResponseHeadersPolicyIdResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDistributionsByVpcOriginId

        internal virtual ListDistributionsByVpcOriginIdResponse ListDistributionsByVpcOriginId(ListDistributionsByVpcOriginIdRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionsByVpcOriginIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsByVpcOriginIdResponseUnmarshaller.Instance;

            return Invoke<ListDistributionsByVpcOriginIdResponse>(request, options);
        }



        /// <summary>
        /// List CloudFront distributions by their VPC origin ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByVpcOriginId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDistributionsByVpcOriginId service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByVpcOriginId">REST API Reference for ListDistributionsByVpcOriginId Operation</seealso>
        public virtual Task<ListDistributionsByVpcOriginIdResponse> ListDistributionsByVpcOriginIdAsync(ListDistributionsByVpcOriginIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionsByVpcOriginIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsByVpcOriginIdResponseUnmarshaller.Instance;

            return InvokeAsync<ListDistributionsByVpcOriginIdResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDistributionsByWebACLId

        internal virtual ListDistributionsByWebACLIdResponse ListDistributionsByWebACLId(ListDistributionsByWebACLIdRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionsByWebACLIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsByWebACLIdResponseUnmarshaller.Instance;

            return Invoke<ListDistributionsByWebACLIdResponse>(request, options);
        }



        /// <summary>
        /// List the distributions that are associated with a specified WAF web ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByWebACLId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDistributionsByWebACLId service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidWebACLIdException">
        /// A web ACL ID specified is not valid. To specify a web ACL created using the latest
        /// version of WAF, use the ACL ARN, for example <c>arn:aws:wafv2:us-east-1:123456789012:global/webacl/ExampleWebACL/473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// To specify a web ACL created using WAF Classic, use the ACL ID, for example <c>473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionsByWebACLId">REST API Reference for ListDistributionsByWebACLId Operation</seealso>
        public virtual Task<ListDistributionsByWebACLIdResponse> ListDistributionsByWebACLIdAsync(ListDistributionsByWebACLIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionsByWebACLIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionsByWebACLIdResponseUnmarshaller.Instance;

            return InvokeAsync<ListDistributionsByWebACLIdResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDistributionTenants

        internal virtual ListDistributionTenantsResponse ListDistributionTenants(ListDistributionTenantsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionTenantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionTenantsResponseUnmarshaller.Instance;

            return Invoke<ListDistributionTenantsResponse>(request, options);
        }



        /// <summary>
        /// Lists the distribution tenants in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionTenants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDistributionTenants service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionTenants">REST API Reference for ListDistributionTenants Operation</seealso>
        public virtual Task<ListDistributionTenantsResponse> ListDistributionTenantsAsync(ListDistributionTenantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionTenantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionTenantsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDistributionTenantsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDistributionTenantsByCustomization

        internal virtual ListDistributionTenantsByCustomizationResponse ListDistributionTenantsByCustomization(ListDistributionTenantsByCustomizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionTenantsByCustomizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionTenantsByCustomizationResponseUnmarshaller.Instance;

            return Invoke<ListDistributionTenantsByCustomizationResponse>(request, options);
        }



        /// <summary>
        /// Lists distribution tenants by the customization that you specify.
        /// 
        ///  
        /// <para>
        /// You must specify either the <c>CertificateArn</c> parameter or <c>WebACLArn</c> parameter,
        /// but not both in the same request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionTenantsByCustomization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDistributionTenantsByCustomization service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDistributionTenantsByCustomization">REST API Reference for ListDistributionTenantsByCustomization Operation</seealso>
        public virtual Task<ListDistributionTenantsByCustomizationResponse> ListDistributionTenantsByCustomizationAsync(ListDistributionTenantsByCustomizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDistributionTenantsByCustomizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDistributionTenantsByCustomizationResponseUnmarshaller.Instance;

            return InvokeAsync<ListDistributionTenantsByCustomizationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDomainConflicts

        internal virtual ListDomainConflictsResponse ListDomainConflicts(ListDomainConflictsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainConflictsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainConflictsResponseUnmarshaller.Instance;

            return Invoke<ListDomainConflictsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// We recommend that you use the <c>ListDomainConflicts</c> API operation to check for
        /// domain conflicts, as it supports both standard distributions and distribution tenants.
        /// <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ListConflictingAliases.html">ListConflictingAliases</a>
        /// performs similar checks but only supports standard distributions.
        /// 
        ///  </note> 
        /// <para>
        /// Lists existing domain associations that conflict with the domain that you specify.
        /// </para>
        ///  
        /// <para>
        /// You can use this API operation to identify potential domain conflicts when moving
        /// domains between standard distributions and/or distribution tenants. Domain conflicts
        /// must be resolved first before they can be moved. 
        /// </para>
        ///  
        /// <para>
        /// For example, if you provide <c>www.example.com</c> as input, the returned list can
        /// include <c>www.example.com</c> and the overlapping wildcard alternate domain name
        /// (<c><em>.example.com</c>), if they exist. If you provide <c></em>.example.com</c>
        /// as input, the returned list can include <c>*.example.com</c> and any alternate domain
        /// names covered by that wildcard (for example, <c>www.example.com</c>, <c>test.example.com</c>,
        /// <c>dev.example.com</c>, and so on), if they exist.
        /// </para>
        ///  
        /// <para>
        /// To list conflicting domains, specify the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The domain to search for
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ID of a standard distribution or distribution tenant in your account that has
        /// an attached TLS certificate, which covers the specified domain
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, including how to set up the standard distribution or distribution
        /// tenant, and the certificate, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/CNAMEs.html#alternate-domain-names-move">Moving
        /// an alternate domain name to a different standard distribution or distribution tenant</a>
        /// in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainConflicts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomainConflicts service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListDomainConflicts">REST API Reference for ListDomainConflicts Operation</seealso>
        public virtual Task<ListDomainConflictsResponse> ListDomainConflictsAsync(ListDomainConflictsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainConflictsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainConflictsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainConflictsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFieldLevelEncryptionConfigs

        internal virtual ListFieldLevelEncryptionConfigsResponse ListFieldLevelEncryptionConfigs(ListFieldLevelEncryptionConfigsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFieldLevelEncryptionConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFieldLevelEncryptionConfigsResponseUnmarshaller.Instance;

            return Invoke<ListFieldLevelEncryptionConfigsResponse>(request, options);
        }



        /// <summary>
        /// List all field-level encryption configurations that have been created in CloudFront
        /// for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFieldLevelEncryptionConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFieldLevelEncryptionConfigs service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListFieldLevelEncryptionConfigs">REST API Reference for ListFieldLevelEncryptionConfigs Operation</seealso>
        public virtual Task<ListFieldLevelEncryptionConfigsResponse> ListFieldLevelEncryptionConfigsAsync(ListFieldLevelEncryptionConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFieldLevelEncryptionConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFieldLevelEncryptionConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFieldLevelEncryptionConfigsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFieldLevelEncryptionProfiles

        internal virtual ListFieldLevelEncryptionProfilesResponse ListFieldLevelEncryptionProfiles(ListFieldLevelEncryptionProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFieldLevelEncryptionProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFieldLevelEncryptionProfilesResponseUnmarshaller.Instance;

            return Invoke<ListFieldLevelEncryptionProfilesResponse>(request, options);
        }



        /// <summary>
        /// Request a list of field-level encryption profiles that have been created in CloudFront
        /// for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFieldLevelEncryptionProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFieldLevelEncryptionProfiles service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListFieldLevelEncryptionProfiles">REST API Reference for ListFieldLevelEncryptionProfiles Operation</seealso>
        public virtual Task<ListFieldLevelEncryptionProfilesResponse> ListFieldLevelEncryptionProfilesAsync(ListFieldLevelEncryptionProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFieldLevelEncryptionProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFieldLevelEncryptionProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFieldLevelEncryptionProfilesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFunctions

        internal virtual ListFunctionsResponse ListFunctions(ListFunctionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionsResponseUnmarshaller.Instance;

            return Invoke<ListFunctionsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of all CloudFront functions in your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// You can optionally apply a filter to return only the functions that are in the specified
        /// stage, either <c>DEVELOPMENT</c> or <c>LIVE</c>.
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFunctions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        public virtual Task<ListFunctionsResponse> ListFunctionsAsync(ListFunctionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFunctionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListInvalidations

        internal virtual ListInvalidationsResponse ListInvalidations(ListInvalidationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInvalidationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvalidationsResponseUnmarshaller.Instance;

            return Invoke<ListInvalidationsResponse>(request, options);
        }



        /// <summary>
        /// Lists invalidation batches.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvalidations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInvalidations service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListInvalidations">REST API Reference for ListInvalidations Operation</seealso>
        public virtual Task<ListInvalidationsResponse> ListInvalidationsAsync(ListInvalidationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInvalidationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvalidationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInvalidationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListInvalidationsForDistributionTenant

        internal virtual ListInvalidationsForDistributionTenantResponse ListInvalidationsForDistributionTenant(ListInvalidationsForDistributionTenantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInvalidationsForDistributionTenantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvalidationsForDistributionTenantResponseUnmarshaller.Instance;

            return Invoke<ListInvalidationsForDistributionTenantResponse>(request, options);
        }



        /// <summary>
        /// Lists the invalidations for a distribution tenant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvalidationsForDistributionTenant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInvalidationsForDistributionTenant service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListInvalidationsForDistributionTenant">REST API Reference for ListInvalidationsForDistributionTenant Operation</seealso>
        public virtual Task<ListInvalidationsForDistributionTenantResponse> ListInvalidationsForDistributionTenantAsync(ListInvalidationsForDistributionTenantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInvalidationsForDistributionTenantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvalidationsForDistributionTenantResponseUnmarshaller.Instance;

            return InvokeAsync<ListInvalidationsForDistributionTenantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListKeyGroups

        internal virtual ListKeyGroupsResponse ListKeyGroups(ListKeyGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKeyGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeyGroupsResponseUnmarshaller.Instance;

            return Invoke<ListKeyGroupsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of key groups.
        /// 
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeyGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListKeyGroups service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListKeyGroups">REST API Reference for ListKeyGroups Operation</seealso>
        public virtual Task<ListKeyGroupsResponse> ListKeyGroupsAsync(ListKeyGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKeyGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeyGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListKeyGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListKeyValueStores

        internal virtual ListKeyValueStoresResponse ListKeyValueStores(ListKeyValueStoresRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKeyValueStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeyValueStoresResponseUnmarshaller.Instance;

            return Invoke<ListKeyValueStoresResponse>(request, options);
        }



        /// <summary>
        /// Specifies the key value stores to list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeyValueStores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListKeyValueStores service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListKeyValueStores">REST API Reference for ListKeyValueStores Operation</seealso>
        public virtual Task<ListKeyValueStoresResponse> ListKeyValueStoresAsync(ListKeyValueStoresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKeyValueStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeyValueStoresResponseUnmarshaller.Instance;

            return InvokeAsync<ListKeyValueStoresResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListOriginAccessControls

        internal virtual ListOriginAccessControlsResponse ListOriginAccessControls(ListOriginAccessControlsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOriginAccessControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOriginAccessControlsResponseUnmarshaller.Instance;

            return Invoke<ListOriginAccessControlsResponse>(request, options);
        }



        /// <summary>
        /// Gets the list of CloudFront origin access controls (OACs) in this Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// another request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the next request.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're not using origin access controls for your Amazon Web Services account, the
        /// <c>ListOriginAccessControls</c> operation doesn't return the <c>Items</c> element
        /// in the response.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOriginAccessControls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOriginAccessControls service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListOriginAccessControls">REST API Reference for ListOriginAccessControls Operation</seealso>
        public virtual Task<ListOriginAccessControlsResponse> ListOriginAccessControlsAsync(ListOriginAccessControlsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOriginAccessControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOriginAccessControlsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOriginAccessControlsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListOriginRequestPolicies

        internal virtual ListOriginRequestPoliciesResponse ListOriginRequestPolicies(ListOriginRequestPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOriginRequestPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOriginRequestPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListOriginRequestPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of origin request policies.
        /// 
        ///  
        /// <para>
        /// You can optionally apply a filter to return only the managed policies created by Amazon
        /// Web Services, or only the custom policies created in your Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOriginRequestPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOriginRequestPolicies service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginRequestPolicyException">
        /// The origin request policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListOriginRequestPolicies">REST API Reference for ListOriginRequestPolicies Operation</seealso>
        public virtual Task<ListOriginRequestPoliciesResponse> ListOriginRequestPoliciesAsync(ListOriginRequestPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOriginRequestPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOriginRequestPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListOriginRequestPoliciesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPublicKeys

        internal virtual ListPublicKeysResponse ListPublicKeys(ListPublicKeysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPublicKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPublicKeysResponseUnmarshaller.Instance;

            return Invoke<ListPublicKeysResponse>(request, options);
        }



        /// <summary>
        /// List all public keys that have been added to CloudFront for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPublicKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPublicKeys service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListPublicKeys">REST API Reference for ListPublicKeys Operation</seealso>
        public virtual Task<ListPublicKeysResponse> ListPublicKeysAsync(ListPublicKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPublicKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPublicKeysResponseUnmarshaller.Instance;

            return InvokeAsync<ListPublicKeysResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRealtimeLogConfigs

        internal virtual ListRealtimeLogConfigsResponse ListRealtimeLogConfigs(ListRealtimeLogConfigsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRealtimeLogConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRealtimeLogConfigsResponseUnmarshaller.Instance;

            return Invoke<ListRealtimeLogConfigsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of real-time log configurations.
        /// 
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRealtimeLogConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRealtimeLogConfigs service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchRealtimeLogConfigException">
        /// The real-time log configuration does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListRealtimeLogConfigs">REST API Reference for ListRealtimeLogConfigs Operation</seealso>
        public virtual Task<ListRealtimeLogConfigsResponse> ListRealtimeLogConfigsAsync(ListRealtimeLogConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRealtimeLogConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRealtimeLogConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRealtimeLogConfigsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListResponseHeadersPolicies

        internal virtual ListResponseHeadersPoliciesResponse ListResponseHeadersPolicies(ListResponseHeadersPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResponseHeadersPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResponseHeadersPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListResponseHeadersPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of response headers policies.
        /// 
        ///  
        /// <para>
        /// You can optionally apply a filter to get only the managed policies created by Amazon
        /// Web Services, or only the custom policies created in your Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify the maximum number of items to receive in the response.
        /// If the total number of items in the list exceeds the maximum that you specify, or
        /// the default maximum, the response is paginated. To get the next page of items, send
        /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
        /// as the <c>Marker</c> value in the subsequent request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResponseHeadersPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResponseHeadersPolicies service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResponseHeadersPolicyException">
        /// The response headers policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListResponseHeadersPolicies">REST API Reference for ListResponseHeadersPolicies Operation</seealso>
        public virtual Task<ListResponseHeadersPoliciesResponse> ListResponseHeadersPoliciesAsync(ListResponseHeadersPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResponseHeadersPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResponseHeadersPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResponseHeadersPoliciesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListStreamingDistributions

        internal virtual ListStreamingDistributionsResponse ListStreamingDistributions()
        {
            return ListStreamingDistributions(new ListStreamingDistributionsRequest());
        }
        internal virtual ListStreamingDistributionsResponse ListStreamingDistributions(ListStreamingDistributionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStreamingDistributionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamingDistributionsResponseUnmarshaller.Instance;

            return Invoke<ListStreamingDistributionsResponse>(request, options);
        }


        /// <summary>
        /// List streaming distributions.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListStreamingDistributions">REST API Reference for ListStreamingDistributions Operation</seealso>
        public virtual Task<ListStreamingDistributionsResponse> ListStreamingDistributionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListStreamingDistributionsAsync(new ListStreamingDistributionsRequest(), cancellationToken);
        }



        /// <summary>
        /// List streaming distributions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingDistributions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListStreamingDistributions">REST API Reference for ListStreamingDistributions Operation</seealso>
        public virtual Task<ListStreamingDistributionsResponse> ListStreamingDistributionsAsync(ListStreamingDistributionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStreamingDistributionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamingDistributionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStreamingDistributionsResponse>(request, options, cancellationToken);
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
        /// List tags for a CloudFront resource. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/tagging.html">Tagging
        /// a distribution</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// The tagging specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// A resource that was specified is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListVpcOrigins

        internal virtual ListVpcOriginsResponse ListVpcOrigins(ListVpcOriginsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVpcOriginsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcOriginsResponseUnmarshaller.Instance;

            return Invoke<ListVpcOriginsResponse>(request, options);
        }



        /// <summary>
        /// List the CloudFront VPC origins in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcOrigins service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVpcOrigins service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/ListVpcOrigins">REST API Reference for ListVpcOrigins Operation</seealso>
        public virtual Task<ListVpcOriginsResponse> ListVpcOriginsAsync(ListVpcOriginsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVpcOriginsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcOriginsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVpcOriginsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PublishFunction

        internal virtual PublishFunctionResponse PublishFunction(PublishFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PublishFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishFunctionResponseUnmarshaller.Instance;

            return Invoke<PublishFunctionResponse>(request, options);
        }



        /// <summary>
        /// Publishes a CloudFront function by copying the function code from the <c>DEVELOPMENT</c>
        /// stage to <c>LIVE</c>. This automatically updates all cache behaviors that are using
        /// this function to use the newly published copy in the <c>LIVE</c> stage.
        /// 
        ///  
        /// <para>
        /// When a function is published to the <c>LIVE</c> stage, you can attach the function
        /// to a distribution's cache behavior, using the function's Amazon Resource Name (ARN).
        /// </para>
        ///  
        /// <para>
        /// To publish a function, you must provide the function's name and version (<c>ETag</c>
        /// value). To get these values, you can use <c>ListFunctions</c> and <c>DescribeFunction</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PublishFunction service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFunctionExistsException">
        /// The function does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/PublishFunction">REST API Reference for PublishFunction Operation</seealso>
        public virtual Task<PublishFunctionResponse> PublishFunctionAsync(PublishFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PublishFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<PublishFunctionResponse>(request, options, cancellationToken);
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
        /// Add tags to a CloudFront resource. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/tagging.html">Tagging
        /// a distribution</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// The tagging specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// A resource that was specified is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TestFunction

        internal virtual TestFunctionResponse TestFunction(TestFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestFunctionResponseUnmarshaller.Instance;

            return Invoke<TestFunctionResponse>(request, options);
        }



        /// <summary>
        /// Tests a CloudFront function.
        /// 
        ///  
        /// <para>
        /// To test a function, you provide an <i>event object</i> that represents an HTTP request
        /// or response that your CloudFront distribution could receive in production. CloudFront
        /// runs the function, passing it the event object that you provided, and returns the
        /// function's result (the modified event object) in the response. The response also contains
        /// function logs and error messages, if any exist. For more information about testing
        /// functions, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/managing-functions.html#test-function">Testing
        /// functions</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To test a function, you provide the function's name and version (<c>ETag</c> value)
        /// along with the event object. To get the function's name and version, you can use <c>ListFunctions</c>
        /// and <c>DescribeFunction</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestFunction service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFunctionExistsException">
        /// The function does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TestFunctionFailedException">
        /// The CloudFront function failed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/TestFunction">REST API Reference for TestFunction Operation</seealso>
        public virtual Task<TestFunctionResponse> TestFunctionAsync(TestFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<TestFunctionResponse>(request, options, cancellationToken);
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
        /// Remove tags from a CloudFront resource. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/tagging.html">Tagging
        /// a distribution</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTaggingException">
        /// The tagging specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// A resource that was specified is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateCachePolicy

        internal virtual UpdateCachePolicyResponse UpdateCachePolicy(UpdateCachePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCachePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCachePolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateCachePolicyResponse>(request, options);
        }



        /// <summary>
        /// Updates a cache policy configuration.
        /// 
        ///  
        /// <para>
        /// When you update a cache policy configuration, all the fields are updated with the
        /// values provided in the request. You cannot update some fields independent of others.
        /// To update a cache policy configuration:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <c>GetCachePolicyConfig</c> to get the current configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Locally modify the fields in the cache policy configuration that you want to update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call <c>UpdateCachePolicy</c> by providing the entire cache policy configuration,
        /// including the fields that you modified and those that you didn't.
        /// </para>
        ///  </li> </ol> <important> 
        /// <para>
        /// If your minimum TTL is greater than 0, CloudFront will cache content for at least
        /// the duration specified in the cache policy's minimum TTL, even if the <c>Cache-Control:
        /// no-cache</c>, <c>no-store</c>, or <c>private</c> directives are present in the origin
        /// headers.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCachePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCachePolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CachePolicyAlreadyExistsException">
        /// A cache policy with this name already exists. You must provide a unique name. To modify
        /// an existing cache policy, use <c>UpdateCachePolicy</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCachePolicyException">
        /// The cache policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCookiesInCachePolicyException">
        /// The number of cookies in the cache policy exceeds the maximum. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInCachePolicyException">
        /// The number of headers in the cache policy exceeds the maximum. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringsInCachePolicyException">
        /// The number of query strings in the cache policy exceeds the maximum. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateCachePolicy">REST API Reference for UpdateCachePolicy Operation</seealso>
        public virtual Task<UpdateCachePolicyResponse> UpdateCachePolicyAsync(UpdateCachePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCachePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCachePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCachePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateCloudFrontOriginAccessIdentity

        internal virtual UpdateCloudFrontOriginAccessIdentityResponse UpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return Invoke<UpdateCloudFrontOriginAccessIdentityResponse>(request, options);
        }



        /// <summary>
        /// Update an origin access identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudFrontOriginAccessIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateCloudFrontOriginAccessIdentity">REST API Reference for UpdateCloudFrontOriginAccessIdentity Operation</seealso>
        public virtual Task<UpdateCloudFrontOriginAccessIdentityResponse> UpdateCloudFrontOriginAccessIdentityAsync(UpdateCloudFrontOriginAccessIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCloudFrontOriginAccessIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCloudFrontOriginAccessIdentityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateConnectionGroup

        internal virtual UpdateConnectionGroupResponse UpdateConnectionGroup(UpdateConnectionGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectionGroupResponse>(request, options);
        }



        /// <summary>
        /// Updates a connection group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConnectionGroup service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityAlreadyExistsException">
        /// The entity already exists. You must provide a unique entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityLimitExceededException">
        /// The entity limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ResourceInUseException">
        /// Cannot delete this resource because it is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateConnectionGroup">REST API Reference for UpdateConnectionGroup Operation</seealso>
        public virtual Task<UpdateConnectionGroupResponse> UpdateConnectionGroupAsync(UpdateConnectionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConnectionGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateContinuousDeploymentPolicy

        internal virtual UpdateContinuousDeploymentPolicyResponse UpdateContinuousDeploymentPolicy(UpdateContinuousDeploymentPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateContinuousDeploymentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContinuousDeploymentPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateContinuousDeploymentPolicyResponse>(request, options);
        }



        /// <summary>
        /// Updates a continuous deployment policy. You can update a continuous deployment policy
        /// to enable or disable it, to change the percentage of traffic that it sends to the
        /// staging distribution, or to change the staging distribution that it sends traffic
        /// to.
        /// 
        ///  
        /// <para>
        /// When you update a continuous deployment policy configuration, all the fields are updated
        /// with the values that are provided in the request. You cannot update some fields independent
        /// of others. To update a continuous deployment policy configuration:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <c>GetContinuousDeploymentPolicyConfig</c> to get the current configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Locally modify the fields in the continuous deployment policy configuration that you
        /// want to update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>UpdateContinuousDeploymentPolicy</c>, providing the entire continuous deployment
        /// policy configuration, including the fields that you modified and those that you didn't.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContinuousDeploymentPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContinuousDeploymentPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchContinuousDeploymentPolicyException">
        /// The continuous deployment policy doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StagingDistributionInUseException">
        /// A continuous deployment policy for this staging distribution already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateContinuousDeploymentPolicy">REST API Reference for UpdateContinuousDeploymentPolicy Operation</seealso>
        public virtual Task<UpdateContinuousDeploymentPolicyResponse> UpdateContinuousDeploymentPolicyAsync(UpdateContinuousDeploymentPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateContinuousDeploymentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContinuousDeploymentPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateContinuousDeploymentPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDistribution

        internal virtual UpdateDistributionResponse UpdateDistribution(UpdateDistributionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDistributionResponseUnmarshaller.Instance;

            return Invoke<UpdateDistributionResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration for a CloudFront distribution.
        /// 
        ///  
        /// <para>
        /// The update process includes getting the current distribution configuration, updating
        /// it to make your changes, and then submitting an <c>UpdateDistribution</c> request
        /// to make the updates.
        /// </para>
        ///  
        /// <para>
        ///  <b>To update a web distribution using the CloudFront API</b> 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <c>GetDistributionConfig</c> to get the current configuration, including the version
        /// identifier (<c>ETag</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update the distribution configuration that was returned in the response. Note the
        /// following important requirements and restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must copy the <c>ETag</c> field value from the response. (You'll use it for the
        /// <c>IfMatch</c> parameter in your request.) Then, remove the <c>ETag</c> field from
        /// the distribution configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't change the value of <c>CallerReference</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Submit an <c>UpdateDistribution</c> request, providing the updated distribution configuration.
        /// The new configuration replaces the existing configuration. The values that you specify
        /// in an <c>UpdateDistribution</c> request are not merged into your existing configuration.
        /// Make sure to include all fields: the ones that you modified and also the ones that
        /// you didn't.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// The CNAME specified is already defined for CloudFront.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ContinuousDeploymentPolicyInUseException">
        /// You cannot delete a continuous deployment policy that is associated with a primary
        /// distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalFieldLevelEncryptionConfigAssociationWithCacheBehaviorException">
        /// The specified configuration for field-level encryption can't be associated with the
        /// specified cache behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalOriginAccessConfigurationException">
        /// An origin cannot contain both an origin access control (OAC) and an origin access
        /// identity (OAI).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidDefaultRootObjectException">
        /// The default root object file name is too big or contains an invalid character.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidDomainNameForOriginAccessControlException">
        /// An origin access control is associated with an origin whose domain name is not supported.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidErrorCodeException">
        /// An invalid error code was specified.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidForwardCookiesException">
        /// Your request contains forward cookies option which doesn't match with the expectation
        /// for the <c>whitelisted</c> list of cookie names. Either list of cookie names has been
        /// specified when not allowed or list of cookie names is missing when expected.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidFunctionAssociationException">
        /// A CloudFront function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidGeoRestrictionParameterException">
        /// The specified geo restriction parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidHeadersForS3OriginException">
        /// The headers specified are not valid for an Amazon S3 origin.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLambdaFunctionAssociationException">
        /// The specified Lambda@Edge function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLocationCodeException">
        /// The location code specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidMinimumProtocolVersionException">
        /// The minimum protocol version specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessControlException">
        /// The origin access control is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginKeepaliveTimeoutException">
        /// The keep alive timeout specified for the origin is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginReadTimeoutException">
        /// The read timeout specified for the origin is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidQueryStringParametersException">
        /// The query string parameters specified are not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or does not begin with a slash (/).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the <c>RequiredProtocols</c> element from your distribution
        /// configuration.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidResponseCodeException">
        /// A response code is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTTLOrderException">
        /// The TTL order specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidViewerCertificateException">
        /// A viewer certificate specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidWebACLIdException">
        /// A web ACL ID specified is not valid. To specify a web ACL created using the latest
        /// version of WAF, use the ACL ARN, for example <c>arn:aws:wafv2:us-east-1:123456789012:global/webacl/ExampleWebACL/473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// To specify a web ACL created using WAF Classic, use the ACL ID, for example <c>473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCachePolicyException">
        /// The cache policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchContinuousDeploymentPolicyException">
        /// The continuous deployment policy doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginException">
        /// No origin exists with the specified <c>Origin Id</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginRequestPolicyException">
        /// The origin request policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchRealtimeLogConfigException">
        /// The real-time log configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResponseHeadersPolicyException">
        /// The response headers policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.RealtimeLogConfigOwnerMismatchException">
        /// The specified real-time log configuration belongs to a different Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StagingDistributionInUseException">
        /// A continuous deployment policy for this staging distribution already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCacheBehaviorsException">
        /// You cannot create more cache behaviors for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCertificatesException">
        /// You cannot create anymore custom SSL/TLS certificates.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCookieNamesInWhiteListException">
        /// Your request contains more cookie names in the whitelist than are allowed per cache
        /// behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToCachePolicyException">
        /// The maximum number of distributions have been associated with the specified cache
        /// policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToFieldLevelEncryptionConfigException">
        /// The maximum number of distributions have been associated with the specified configuration
        /// for field-level encryption.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToKeyGroupException">
        /// The number of distributions that reference this key group is more than the maximum
        /// allowed. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToOriginAccessControlException">
        /// The maximum number of distributions have been associated with the specified origin
        /// access control.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToOriginRequestPolicyException">
        /// The maximum number of distributions have been associated with the specified origin
        /// request policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToResponseHeadersPolicyException">
        /// The maximum number of distributions have been associated with the specified response
        /// headers policy.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithFunctionAssociationsException">
        /// You have reached the maximum number of distributions that are associated with a CloudFront
        /// function. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithLambdaAssociationsException">
        /// Processing your request would cause the maximum number of distributions with Lambda@Edge
        /// function associations per owner to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithSingleFunctionARNException">
        /// The maximum number of distributions have been associated with the specified Lambda@Edge
        /// function.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFunctionAssociationsException">
        /// You have reached the maximum number of CloudFront function associations for this distribution.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInForwardedValuesException">
        /// Your request contains too many headers in forwarded values.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyKeyGroupsAssociatedToDistributionException">
        /// The number of key groups referenced by this distribution is more than the maximum
        /// allowed. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyLambdaFunctionAssociationsException">
        /// Your request contains more Lambda@Edge function associations than are allowed per
        /// distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginCustomHeadersException">
        /// Your request contains too many origin custom headers.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginGroupsPerDistributionException">
        /// Processing your request would cause you to exceed the maximum number of origin groups
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginsException">
        /// You cannot create more origins for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringParametersException">
        /// Your request contains too many query string parameters.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedKeyGroupDoesNotExistException">
        /// The specified key group does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateDistribution">REST API Reference for UpdateDistribution Operation</seealso>
        public virtual Task<UpdateDistributionResponse> UpdateDistributionAsync(UpdateDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDistributionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDistributionTenant

        internal virtual UpdateDistributionTenantResponse UpdateDistributionTenant(UpdateDistributionTenantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDistributionTenantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDistributionTenantResponseUnmarshaller.Instance;

            return Invoke<UpdateDistributionTenantResponse>(request, options);
        }



        /// <summary>
        /// Updates a distribution tenant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistributionTenant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDistributionTenant service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// The CNAME specified is already defined for CloudFront.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityAlreadyExistsException">
        /// The entity already exists. You must provide a unique entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityLimitExceededException">
        /// The entity limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidAssociationException">
        /// The specified CloudFront resource can't be associated.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateDistributionTenant">REST API Reference for UpdateDistributionTenant Operation</seealso>
        public virtual Task<UpdateDistributionTenantResponse> UpdateDistributionTenantAsync(UpdateDistributionTenantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDistributionTenantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDistributionTenantResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDistributionTenantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDistributionWithStagingConfig

        internal virtual UpdateDistributionWithStagingConfigResponse UpdateDistributionWithStagingConfig(UpdateDistributionWithStagingConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDistributionWithStagingConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDistributionWithStagingConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateDistributionWithStagingConfigResponse>(request, options);
        }



        /// <summary>
        /// Copies the staging distribution's configuration to its corresponding primary distribution.
        /// The primary distribution retains its <c>Aliases</c> (also known as alternate domain
        /// names or CNAMEs) and <c>ContinuousDeploymentPolicyId</c> value, but otherwise its
        /// configuration is overwritten to match the staging distribution.
        /// 
        ///  
        /// <para>
        /// You can use this operation in a continuous deployment workflow after you have tested
        /// configuration changes on the staging distribution. After using a continuous deployment
        /// policy to move a portion of your domain name's traffic to the staging distribution
        /// and verifying that it works as intended, you can use this operation to copy the staging
        /// distribution's configuration to the primary distribution. This action will disable
        /// the continuous deployment policy and move your domain's traffic back to the primary
        /// distribution.
        /// </para>
        ///  
        /// <para>
        /// This API operation requires the following IAM permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_GetDistribution.html">GetDistribution</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistributionWithStagingConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDistributionWithStagingConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// The CNAME specified is already defined for CloudFront.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalFieldLevelEncryptionConfigAssociationWithCacheBehaviorException">
        /// The specified configuration for field-level encryption can't be associated with the
        /// specified cache behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidDefaultRootObjectException">
        /// The default root object file name is too big or contains an invalid character.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidErrorCodeException">
        /// An invalid error code was specified.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidForwardCookiesException">
        /// Your request contains forward cookies option which doesn't match with the expectation
        /// for the <c>whitelisted</c> list of cookie names. Either list of cookie names has been
        /// specified when not allowed or list of cookie names is missing when expected.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidFunctionAssociationException">
        /// A CloudFront function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidGeoRestrictionParameterException">
        /// The specified geo restriction parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidHeadersForS3OriginException">
        /// The headers specified are not valid for an Amazon S3 origin.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLambdaFunctionAssociationException">
        /// The specified Lambda@Edge function association is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidLocationCodeException">
        /// The location code specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidMinimumProtocolVersionException">
        /// The minimum protocol version specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessControlException">
        /// The origin access control is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginKeepaliveTimeoutException">
        /// The keep alive timeout specified for the origin is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginReadTimeoutException">
        /// The read timeout specified for the origin is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidQueryStringParametersException">
        /// The query string parameters specified are not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRelativePathException">
        /// The relative path is too big, is not URL-encoded, or does not begin with a slash (/).
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidRequiredProtocolException">
        /// This operation requires the HTTPS protocol. Ensure that you specify the HTTPS protocol
        /// in your request, or omit the <c>RequiredProtocols</c> element from your distribution
        /// configuration.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidResponseCodeException">
        /// A response code is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidTTLOrderException">
        /// The TTL order specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidViewerCertificateException">
        /// A viewer certificate specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidWebACLIdException">
        /// A web ACL ID specified is not valid. To specify a web ACL created using the latest
        /// version of WAF, use the ACL ARN, for example <c>arn:aws:wafv2:us-east-1:123456789012:global/webacl/ExampleWebACL/473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// To specify a web ACL created using WAF Classic, use the ACL ID, for example <c>473e64fd-f30b-4765-81a0-62ad96dd167a</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCachePolicyException">
        /// The cache policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginException">
        /// No origin exists with the specified <c>Origin Id</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginRequestPolicyException">
        /// The origin request policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchRealtimeLogConfigException">
        /// The real-time log configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResponseHeadersPolicyException">
        /// The response headers policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.RealtimeLogConfigOwnerMismatchException">
        /// The specified real-time log configuration belongs to a different Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCacheBehaviorsException">
        /// You cannot create more cache behaviors for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCertificatesException">
        /// You cannot create anymore custom SSL/TLS certificates.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCookieNamesInWhiteListException">
        /// Your request contains more cookie names in the whitelist than are allowed per cache
        /// behavior.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToCachePolicyException">
        /// The maximum number of distributions have been associated with the specified cache
        /// policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToFieldLevelEncryptionConfigException">
        /// The maximum number of distributions have been associated with the specified configuration
        /// for field-level encryption.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToKeyGroupException">
        /// The number of distributions that reference this key group is more than the maximum
        /// allowed. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToOriginAccessControlException">
        /// The maximum number of distributions have been associated with the specified origin
        /// access control.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToOriginRequestPolicyException">
        /// The maximum number of distributions have been associated with the specified origin
        /// request policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsAssociatedToResponseHeadersPolicyException">
        /// The maximum number of distributions have been associated with the specified response
        /// headers policy.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithFunctionAssociationsException">
        /// You have reached the maximum number of distributions that are associated with a CloudFront
        /// function. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithLambdaAssociationsException">
        /// Processing your request would cause the maximum number of distributions with Lambda@Edge
        /// function associations per owner to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyDistributionsWithSingleFunctionARNException">
        /// The maximum number of distributions have been associated with the specified Lambda@Edge
        /// function.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFunctionAssociationsException">
        /// You have reached the maximum number of CloudFront function associations for this distribution.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInForwardedValuesException">
        /// Your request contains too many headers in forwarded values.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyKeyGroupsAssociatedToDistributionException">
        /// The number of key groups referenced by this distribution is more than the maximum
        /// allowed. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyLambdaFunctionAssociationsException">
        /// Your request contains more Lambda@Edge function associations than are allowed per
        /// distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginCustomHeadersException">
        /// Your request contains too many origin custom headers.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginGroupsPerDistributionException">
        /// Processing your request would cause you to exceed the maximum number of origin groups
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyOriginsException">
        /// You cannot create more origins for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringParametersException">
        /// Your request contains too many query string parameters.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedKeyGroupDoesNotExistException">
        /// The specified key group does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateDistributionWithStagingConfig">REST API Reference for UpdateDistributionWithStagingConfig Operation</seealso>
        public virtual Task<UpdateDistributionWithStagingConfigResponse> UpdateDistributionWithStagingConfigAsync(UpdateDistributionWithStagingConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDistributionWithStagingConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDistributionWithStagingConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDistributionWithStagingConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDomainAssociation

        internal virtual UpdateDomainAssociationResponse UpdateDomainAssociation(UpdateDomainAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainAssociationResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// We recommend that you use the <c>UpdateDomainAssociation</c> API operation to move
        /// a domain association, as it supports both standard distributions and distribution
        /// tenants. <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_AssociateAlias.html">AssociateAlias</a>
        /// performs similar checks but only supports standard distributions.
        /// 
        ///  </note> 
        /// <para>
        /// Moves a domain from its current standard distribution or distribution tenant to another
        /// one.
        /// </para>
        ///  
        /// <para>
        /// You must first disable the source distribution (standard distribution or distribution
        /// tenant) and then separately call this operation to move the domain to another target
        /// distribution (standard distribution or distribution tenant).
        /// </para>
        ///  
        /// <para>
        /// To use this operation, specify the domain and the ID of the target resource (standard
        /// distribution or distribution tenant). For more information, including how to set up
        /// the target resource, prerequisites that you must complete, and other restrictions,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/CNAMEs.html#alternate-domain-names-move">Moving
        /// an alternate domain name to a different standard distribution or distribution tenant</a>
        /// in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomainAssociation service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateDomainAssociation">REST API Reference for UpdateDomainAssociation Operation</seealso>
        public virtual Task<UpdateDomainAssociationResponse> UpdateDomainAssociationAsync(UpdateDomainAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFieldLevelEncryptionConfig

        internal virtual UpdateFieldLevelEncryptionConfigResponse UpdateFieldLevelEncryptionConfig(UpdateFieldLevelEncryptionConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFieldLevelEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateFieldLevelEncryptionConfigResponse>(request, options);
        }



        /// <summary>
        /// Update a field-level encryption configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFieldLevelEncryptionConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFieldLevelEncryptionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionConfigException">
        /// The specified configuration for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionProfileException">
        /// The specified profile for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.QueryArgProfileEmptyException">
        /// No profile specified for the field-level encryption query argument.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionContentTypeProfilesException">
        /// The maximum number of content type profiles for field-level encryption have been created.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionQueryArgProfilesException">
        /// The maximum number of query arg profiles for field-level encryption have been created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateFieldLevelEncryptionConfig">REST API Reference for UpdateFieldLevelEncryptionConfig Operation</seealso>
        public virtual Task<UpdateFieldLevelEncryptionConfigResponse> UpdateFieldLevelEncryptionConfigAsync(UpdateFieldLevelEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFieldLevelEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFieldLevelEncryptionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFieldLevelEncryptionConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFieldLevelEncryptionProfile

        internal virtual UpdateFieldLevelEncryptionProfileResponse UpdateFieldLevelEncryptionProfile(UpdateFieldLevelEncryptionProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFieldLevelEncryptionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateFieldLevelEncryptionProfileResponse>(request, options);
        }



        /// <summary>
        /// Update a field-level encryption profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFieldLevelEncryptionProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFieldLevelEncryptionProfile service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.FieldLevelEncryptionProfileAlreadyExistsException">
        /// The specified profile for field-level encryption already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.FieldLevelEncryptionProfileSizeExceededException">
        /// The maximum size of a profile for field-level encryption was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFieldLevelEncryptionProfileException">
        /// The specified profile for field-level encryption doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchPublicKeyException">
        /// The specified public key doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionEncryptionEntitiesException">
        /// The maximum number of encryption entities for field-level encryption have been created.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyFieldLevelEncryptionFieldPatternsException">
        /// The maximum number of field patterns for field-level encryption have been created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateFieldLevelEncryptionProfile">REST API Reference for UpdateFieldLevelEncryptionProfile Operation</seealso>
        public virtual Task<UpdateFieldLevelEncryptionProfileResponse> UpdateFieldLevelEncryptionProfileAsync(UpdateFieldLevelEncryptionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFieldLevelEncryptionProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFieldLevelEncryptionProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFieldLevelEncryptionProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFunction

        internal virtual UpdateFunctionResponse UpdateFunction(UpdateFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionResponseUnmarshaller.Instance;

            return Invoke<UpdateFunctionResponse>(request, options);
        }



        /// <summary>
        /// Updates a CloudFront function.
        /// 
        ///  
        /// <para>
        /// You can update a function's code or the comment that describes the function. You cannot
        /// update a function's name.
        /// </para>
        ///  
        /// <para>
        /// To update a function, you provide the function's name and version (<c>ETag</c> value)
        /// along with the updated function code. To get the name and version, you can use <c>ListFunctions</c>
        /// and <c>DescribeFunction</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFunction service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.FunctionSizeLimitExceededException">
        /// The function is too large. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchFunctionExistsException">
        /// The function does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateFunction">REST API Reference for UpdateFunction Operation</seealso>
        public virtual Task<UpdateFunctionResponse> UpdateFunctionAsync(UpdateFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFunctionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateKeyGroup

        internal virtual UpdateKeyGroupResponse UpdateKeyGroup(UpdateKeyGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKeyGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKeyGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateKeyGroupResponse>(request, options);
        }



        /// <summary>
        /// Updates a key group.
        /// 
        ///  
        /// <para>
        /// When you update a key group, all the fields are updated with the values provided in
        /// the request. You cannot update some fields independent of others. To update a key
        /// group:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Get the current key group with <c>GetKeyGroup</c> or <c>GetKeyGroupConfig</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Locally modify the fields in the key group that you want to update. For example, add
        /// or remove public key IDs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call <c>UpdateKeyGroup</c> with the entire key group object, including the fields
        /// that you modified and those that you didn't.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateKeyGroup service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.KeyGroupAlreadyExistsException">
        /// A key group with this name already exists. You must provide a unique name. To modify
        /// an existing key group, use <c>UpdateKeyGroup</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResourceException">
        /// A resource that was specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyPublicKeysInKeyGroupException">
        /// The number of public keys in this key group is more than the maximum allowed. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateKeyGroup">REST API Reference for UpdateKeyGroup Operation</seealso>
        public virtual Task<UpdateKeyGroupResponse> UpdateKeyGroupAsync(UpdateKeyGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKeyGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKeyGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateKeyGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateKeyValueStore

        internal virtual UpdateKeyValueStoreResponse UpdateKeyValueStore(UpdateKeyValueStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKeyValueStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKeyValueStoreResponseUnmarshaller.Instance;

            return Invoke<UpdateKeyValueStoreResponse>(request, options);
        }



        /// <summary>
        /// Specifies the key value store to update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyValueStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateKeyValueStore service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateKeyValueStore">REST API Reference for UpdateKeyValueStore Operation</seealso>
        public virtual Task<UpdateKeyValueStoreResponse> UpdateKeyValueStoreAsync(UpdateKeyValueStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKeyValueStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKeyValueStoreResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateKeyValueStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateOriginAccessControl

        internal virtual UpdateOriginAccessControlResponse UpdateOriginAccessControl(UpdateOriginAccessControlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOriginAccessControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOriginAccessControlResponseUnmarshaller.Instance;

            return Invoke<UpdateOriginAccessControlResponse>(request, options);
        }



        /// <summary>
        /// Updates a CloudFront origin access control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOriginAccessControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOriginAccessControl service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginAccessControlException">
        /// The origin access control does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.OriginAccessControlAlreadyExistsException">
        /// An origin access control with the specified parameters already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateOriginAccessControl">REST API Reference for UpdateOriginAccessControl Operation</seealso>
        public virtual Task<UpdateOriginAccessControlResponse> UpdateOriginAccessControlAsync(UpdateOriginAccessControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOriginAccessControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOriginAccessControlResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateOriginAccessControlResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateOriginRequestPolicy

        internal virtual UpdateOriginRequestPolicyResponse UpdateOriginRequestPolicy(UpdateOriginRequestPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOriginRequestPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOriginRequestPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateOriginRequestPolicyResponse>(request, options);
        }



        /// <summary>
        /// Updates an origin request policy configuration.
        /// 
        ///  
        /// <para>
        /// When you update an origin request policy configuration, all the fields are updated
        /// with the values provided in the request. You cannot update some fields independent
        /// of others. To update an origin request policy configuration:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <c>GetOriginRequestPolicyConfig</c> to get the current configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Locally modify the fields in the origin request policy configuration that you want
        /// to update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call <c>UpdateOriginRequestPolicy</c> by providing the entire origin request policy
        /// configuration, including the fields that you modified and those that you didn't.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOriginRequestPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOriginRequestPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchOriginRequestPolicyException">
        /// The origin request policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.OriginRequestPolicyAlreadyExistsException">
        /// An origin request policy with this name already exists. You must provide a unique
        /// name. To modify an existing origin request policy, use <c>UpdateOriginRequestPolicy</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCookiesInOriginRequestPolicyException">
        /// The number of cookies in the origin request policy exceeds the maximum. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyHeadersInOriginRequestPolicyException">
        /// The number of headers in the origin request policy exceeds the maximum. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyQueryStringsInOriginRequestPolicyException">
        /// The number of query strings in the origin request policy exceeds the maximum. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateOriginRequestPolicy">REST API Reference for UpdateOriginRequestPolicy Operation</seealso>
        public virtual Task<UpdateOriginRequestPolicyResponse> UpdateOriginRequestPolicyAsync(UpdateOriginRequestPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOriginRequestPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOriginRequestPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateOriginRequestPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdatePublicKey

        internal virtual UpdatePublicKeyResponse UpdatePublicKey(UpdatePublicKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePublicKeyResponseUnmarshaller.Instance;

            return Invoke<UpdatePublicKeyResponse>(request, options);
        }



        /// <summary>
        /// Update public key information. Note that the only value you can change is the comment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePublicKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePublicKey service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CannotChangeImmutablePublicKeyFieldsException">
        /// You can't change the value of a public key.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchPublicKeyException">
        /// The specified public key doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdatePublicKey">REST API Reference for UpdatePublicKey Operation</seealso>
        public virtual Task<UpdatePublicKeyResponse> UpdatePublicKeyAsync(UpdatePublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePublicKeyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePublicKeyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRealtimeLogConfig

        internal virtual UpdateRealtimeLogConfigResponse UpdateRealtimeLogConfig(UpdateRealtimeLogConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRealtimeLogConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRealtimeLogConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateRealtimeLogConfigResponse>(request, options);
        }



        /// <summary>
        /// Updates a real-time log configuration.
        /// 
        ///  
        /// <para>
        /// When you update a real-time log configuration, all the parameters are updated with
        /// the values provided in the request. You cannot update some parameters independent
        /// of others. To update a real-time log configuration:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Call <c>GetRealtimeLogConfig</c> to get the current real-time log configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Locally modify the parameters in the real-time log configuration that you want to
        /// update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call this API (<c>UpdateRealtimeLogConfig</c>) by providing the entire real-time log
        /// configuration, including the parameters that you modified and those that you didn't.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// You cannot update a real-time log configuration's <c>Name</c> or <c>ARN</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRealtimeLogConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRealtimeLogConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchRealtimeLogConfigException">
        /// The real-time log configuration does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateRealtimeLogConfig">REST API Reference for UpdateRealtimeLogConfig Operation</seealso>
        public virtual Task<UpdateRealtimeLogConfigResponse> UpdateRealtimeLogConfigAsync(UpdateRealtimeLogConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRealtimeLogConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRealtimeLogConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRealtimeLogConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateResponseHeadersPolicy

        internal virtual UpdateResponseHeadersPolicyResponse UpdateResponseHeadersPolicy(UpdateResponseHeadersPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResponseHeadersPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResponseHeadersPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateResponseHeadersPolicyResponse>(request, options);
        }



        /// <summary>
        /// Updates a response headers policy.
        /// 
        ///  
        /// <para>
        /// When you update a response headers policy, the entire policy is replaced. You cannot
        /// update some policy fields independent of others. To update a response headers policy
        /// configuration:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <c>GetResponseHeadersPolicyConfig</c> to get the current policy's configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Modify the fields in the response headers policy configuration that you want to update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call <c>UpdateResponseHeadersPolicy</c>, providing the entire response headers policy
        /// configuration, including the fields that you modified and those that you didn't.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResponseHeadersPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResponseHeadersPolicy service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchResponseHeadersPolicyException">
        /// The response headers policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.ResponseHeadersPolicyAlreadyExistsException">
        /// A response headers policy with this name already exists. You must provide a unique
        /// name. To modify an existing response headers policy, use <c>UpdateResponseHeadersPolicy</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooLongCSPInResponseHeadersPolicyException">
        /// The length of the <c>Content-Security-Policy</c> header value in the response headers
        /// policy exceeds the maximum.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyCustomHeadersInResponseHeadersPolicyException">
        /// The number of custom headers in the response headers policy exceeds the maximum.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyRemoveHeadersInResponseHeadersPolicyException">
        /// The number of headers in <c>RemoveHeadersConfig</c> in the response headers policy
        /// exceeds the maximum.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html">Quotas</a>
        /// (formerly known as limits) in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateResponseHeadersPolicy">REST API Reference for UpdateResponseHeadersPolicy Operation</seealso>
        public virtual Task<UpdateResponseHeadersPolicyResponse> UpdateResponseHeadersPolicyAsync(UpdateResponseHeadersPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResponseHeadersPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResponseHeadersPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResponseHeadersPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateStreamingDistribution

        internal virtual UpdateStreamingDistributionResponse UpdateStreamingDistribution(UpdateStreamingDistributionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStreamingDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStreamingDistributionResponseUnmarshaller.Instance;

            return Invoke<UpdateStreamingDistributionResponse>(request, options);
        }



        /// <summary>
        /// Update a streaming distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamingDistribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CNAMEAlreadyExistsException">
        /// The CNAME specified is already defined for CloudFront.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessControlException">
        /// The origin access control is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidOriginAccessIdentityException">
        /// The origin access identity is not valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.MissingBodyException">
        /// This operation requires a body. Ensure that the body is present and the <c>Content-Type</c>
        /// header is set.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyStreamingDistributionCNAMEsException">
        /// Your request contains more CNAMEs than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TooManyTrustedSignersException">
        /// Your request contains more trusted signers than are allowed per distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.TrustedSignerDoesNotExistException">
        /// One or more of your trusted signers don't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateStreamingDistribution">REST API Reference for UpdateStreamingDistribution Operation</seealso>
        public virtual Task<UpdateStreamingDistributionResponse> UpdateStreamingDistributionAsync(UpdateStreamingDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStreamingDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStreamingDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStreamingDistributionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateVpcOrigin

        internal virtual UpdateVpcOriginResponse UpdateVpcOrigin(UpdateVpcOriginRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVpcOriginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcOriginResponseUnmarshaller.Instance;

            return Invoke<UpdateVpcOriginResponse>(request, options);
        }



        /// <summary>
        /// Update an Amazon CloudFront VPC origin in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcOrigin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVpcOrigin service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CannotUpdateEntityWhileInUseException">
        /// The entity cannot be updated while it is in use.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityAlreadyExistsException">
        /// The entity already exists. You must provide a unique entity.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityLimitExceededException">
        /// The entity limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.IllegalUpdateException">
        /// The update contains modifications that are not allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InconsistentQuantitiesException">
        /// The value of <c>Quantity</c> and the size of <c>Items</c> don't match.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <c>If-Match</c> version is missing or not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition in one or more of the request fields evaluated to <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.UnsupportedOperationException">
        /// This operation is not supported in this Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/UpdateVpcOrigin">REST API Reference for UpdateVpcOrigin Operation</seealso>
        public virtual Task<UpdateVpcOriginResponse> UpdateVpcOriginAsync(UpdateVpcOriginRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVpcOriginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcOriginResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVpcOriginResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  VerifyDnsConfiguration

        internal virtual VerifyDnsConfigurationResponse VerifyDnsConfiguration(VerifyDnsConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = VerifyDnsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyDnsConfigurationResponseUnmarshaller.Instance;

            return Invoke<VerifyDnsConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Verify the DNS configuration for your domain names. This API operation checks whether
        /// your domain name points to the correct routing endpoint of the connection group, such
        /// as d111111abcdef8.cloudfront.net. You can use this API operation to troubleshoot and
        /// resolve DNS configuration issues.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyDnsConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the VerifyDnsConfiguration service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.EntityNotFoundException">
        /// The entity was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// An argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2020-05-31/VerifyDnsConfiguration">REST API Reference for VerifyDnsConfiguration Operation</seealso>
        public virtual Task<VerifyDnsConfigurationResponse> VerifyDnsConfigurationAsync(VerifyDnsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = VerifyDnsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyDnsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<VerifyDnsConfigurationResponse>(request, options, cancellationToken);
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