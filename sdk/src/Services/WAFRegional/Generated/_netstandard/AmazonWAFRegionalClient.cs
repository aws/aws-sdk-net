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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.WAFRegional.Model;
using Amazon.WAFRegional.Model.Internal.MarshallTransformations;
using Amazon.WAFRegional.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.WAFRegional
{
    /// <summary>
    /// <para>Implementation for accessing WAFRegional</para>
    ///
    /// <note> 
    /// <para>
    /// This is <b>AWS WAF Classic Regional</b> documentation. For more information, see <a
    /// href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
    /// WAF Classic</a> in the developer guide.
    /// </para>
    ///  
    /// <para>
    ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
    /// for regional and global use. 
    /// </para>
    ///  </note> 
    /// <para>
    /// This is the <i>AWS WAF Regional Classic API Reference</i> for using AWS WAF Classic
    /// with the AWS resources, Elastic Load Balancing (ELB) Application Load Balancers and
    /// API Gateway APIs. The AWS WAF Classic actions and data types listed in the reference
    /// are available for protecting Elastic Load Balancing (ELB) Application Load Balancers
    /// and API Gateway APIs. You can use these actions and data types by means of the endpoints
    /// listed in <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#waf_region">AWS
    /// Regions and Endpoints</a>. This guide is for developers who need detailed information
    /// about the AWS WAF Classic API actions, data types, and errors. For detailed information
    /// about AWS WAF Classic features and an overview of how to use the AWS WAF Classic API,
    /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
    /// WAF Classic</a> in the developer guide.
    /// </para>
    /// </summary>
    public partial class AmazonWAFRegionalClient : AmazonServiceClient, IAmazonWAFRegional
    {
        private static IServiceMetadata serviceMetadata = new AmazonWAFRegionalMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonWAFRegionalClient with the credentials loaded from the application's
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
        public AmazonWAFRegionalClient()
            : base(new AmazonWAFRegionalConfig()) { }

        /// <summary>
        /// Constructs AmazonWAFRegionalClient with the credentials loaded from the application's
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
        public AmazonWAFRegionalClient(RegionEndpoint region)
            : base(new AmazonWAFRegionalConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonWAFRegionalClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonWAFRegionalClient Configuration Object</param>
        public AmazonWAFRegionalClient(AmazonWAFRegionalConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonWAFRegionalClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonWAFRegionalClient(AWSCredentials credentials)
            : this(credentials, new AmazonWAFRegionalConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWAFRegionalClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWAFRegionalClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonWAFRegionalConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWAFRegionalClient with AWS Credentials and an
        /// AmazonWAFRegionalClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonWAFRegionalClient Configuration Object</param>
        public AmazonWAFRegionalClient(AWSCredentials credentials, AmazonWAFRegionalConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWAFRegionalClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonWAFRegionalClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWAFRegionalConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWAFRegionalClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWAFRegionalClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWAFRegionalConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonWAFRegionalClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWAFRegionalClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonWAFRegionalClient Configuration Object</param>
        public AmazonWAFRegionalClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonWAFRegionalConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWAFRegionalClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonWAFRegionalClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWAFRegionalConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWAFRegionalClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWAFRegionalClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWAFRegionalConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWAFRegionalClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWAFRegionalClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonWAFRegionalClient Configuration Object</param>
        public AmazonWAFRegionalClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonWAFRegionalConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonWAFRegionalEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonWAFRegionalAuthSchemeHandler());
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


        #region  AssociateWebACL

        internal virtual AssociateWebACLResponse AssociateWebACL(AssociateWebACLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWebACLResponseUnmarshaller.Instance;

            return Invoke<AssociateWebACLResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic Regional</b> documentation. For more information, see <a
        /// href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Associates a web ACL with a resource, either an application load balancer or Amazon
        /// API Gateway stage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateWebACL service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFUnavailableEntityException">
        /// The operation failed because the entity referenced is temporarily unavailable. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/AssociateWebACL">REST API Reference for AssociateWebACL Operation</seealso>
        public virtual Task<AssociateWebACLResponse> AssociateWebACLAsync(AssociateWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateWebACLResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateByteMatchSet

        internal virtual CreateByteMatchSetResponse CreateByteMatchSet(CreateByteMatchSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateByteMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateByteMatchSetResponseUnmarshaller.Instance;

            return Invoke<CreateByteMatchSetResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>ByteMatchSet</c>. You then use <a>UpdateByteMatchSet</a> to identify
        /// the part of a web request that you want AWS WAF to inspect, such as the values of
        /// the <c>User-Agent</c> header or the query string. For example, you can create a <c>ByteMatchSet</c>
        /// that matches any requests with <c>User-Agent</c> headers that contain the string <c>BadBot</c>.
        /// You can then configure AWS WAF to reject those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>ByteMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateByteMatchSet</a> request to specify the part of the request that
        /// you want AWS WAF to inspect (for example, the header or the URI) and the value that
        /// you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description of the <a>ByteMatchSet</a>. You can't change <c>Name</c> after you create a <c>ByteMatchSet</c>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateByteMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateByteMatchSet">REST API Reference for CreateByteMatchSet Operation</seealso>
        public virtual Task<CreateByteMatchSetResponse> CreateByteMatchSetAsync(string name, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateByteMatchSetRequest();
            request.Name = name;
            request.ChangeToken = changeToken;
            return CreateByteMatchSetAsync(request, cancellationToken);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>ByteMatchSet</c>. You then use <a>UpdateByteMatchSet</a> to identify
        /// the part of a web request that you want AWS WAF to inspect, such as the values of
        /// the <c>User-Agent</c> header or the query string. For example, you can create a <c>ByteMatchSet</c>
        /// that matches any requests with <c>User-Agent</c> headers that contain the string <c>BadBot</c>.
        /// You can then configure AWS WAF to reject those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>ByteMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateByteMatchSet</a> request to specify the part of the request that
        /// you want AWS WAF to inspect (for example, the header or the URI) and the value that
        /// you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateByteMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateByteMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateByteMatchSet">REST API Reference for CreateByteMatchSet Operation</seealso>
        public virtual Task<CreateByteMatchSetResponse> CreateByteMatchSetAsync(CreateByteMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateByteMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateByteMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateByteMatchSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateGeoMatchSet

        internal virtual CreateGeoMatchSetResponse CreateGeoMatchSet(CreateGeoMatchSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGeoMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGeoMatchSetResponseUnmarshaller.Instance;

            return Invoke<CreateGeoMatchSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates an <a>GeoMatchSet</a>, which you use to specify which web requests you want
        /// to allow or block based on the country that the requests originate from. For example,
        /// if you're receiving a lot of requests from one or more countries and you want to block
        /// the requests, you can create an <c>GeoMatchSet</c> that contains those countries and
        /// then configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>GeoMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateGeoMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateGeoMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateGeoMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateGeoMatchSetSet</c> request to specify the countries that you want
        /// AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGeoMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGeoMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateGeoMatchSet">REST API Reference for CreateGeoMatchSet Operation</seealso>
        public virtual Task<CreateGeoMatchSetResponse> CreateGeoMatchSetAsync(CreateGeoMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGeoMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGeoMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGeoMatchSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateIPSet

        internal virtual CreateIPSetResponse CreateIPSet(CreateIPSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIPSetResponseUnmarshaller.Instance;

            return Invoke<CreateIPSetResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates an <a>IPSet</a>, which you use to specify which web requests that you want
        /// to allow or block based on the IP addresses that the requests originate from. For
        /// example, if you're receiving a lot of requests from one or more individual IP addresses
        /// or one or more ranges of IP addresses and you want to block the requests, you can
        /// create an <c>IPSet</c> that contains those IP addresses and then configure AWS WAF
        /// to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <c>IPSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateIPSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateIPSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateIPSet</c> request to specify the IP addresses that you want AWS
        /// WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description of the <a>IPSet</a>. You can't change <c>Name</c> after you create the <c>IPSet</c>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIPSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        public virtual Task<CreateIPSetResponse> CreateIPSetAsync(string name, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateIPSetRequest();
            request.Name = name;
            request.ChangeToken = changeToken;
            return CreateIPSetAsync(request, cancellationToken);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates an <a>IPSet</a>, which you use to specify which web requests that you want
        /// to allow or block based on the IP addresses that the requests originate from. For
        /// example, if you're receiving a lot of requests from one or more individual IP addresses
        /// or one or more ranges of IP addresses and you want to block the requests, you can
        /// create an <c>IPSet</c> that contains those IP addresses and then configure AWS WAF
        /// to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <c>IPSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateIPSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateIPSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateIPSet</c> request to specify the IP addresses that you want AWS
        /// WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIPSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        public virtual Task<CreateIPSetResponse> CreateIPSetAsync(CreateIPSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIPSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIPSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRateBasedRule

        internal virtual CreateRateBasedRuleResponse CreateRateBasedRule(CreateRateBasedRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRateBasedRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRateBasedRuleResponseUnmarshaller.Instance;

            return Invoke<CreateRateBasedRuleResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>RateBasedRule</a>. The <c>RateBasedRule</c> contains a <c>RateLimit</c>,
        /// which specifies the maximum number of requests that AWS WAF allows from a specified
        /// IP address in a five-minute period. The <c>RateBasedRule</c> also contains the <c>IPSet</c>
        /// objects, <c>ByteMatchSet</c> objects, and other predicates that identify the requests
        /// that you want to count or block if these requests exceed the <c>RateLimit</c>.
        /// </para>
        ///  
        /// <para>
        /// If you add more than one predicate to a <c>RateBasedRule</c>, a request not only must
        /// exceed the <c>RateLimit</c>, but it also must match all the conditions to be counted
        /// or blocked. For example, suppose you add the following to a <c>RateBasedRule</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An <c>IPSet</c> that matches the IP address <c>192.0.2.44/32</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> that matches <c>BadBot</c> in the <c>User-Agent</c> header
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Further, you specify a <c>RateLimit</c> of 1,000.
        /// </para>
        ///  
        /// <para>
        /// You then add the <c>RateBasedRule</c> to a <c>WebACL</c> and specify that you want
        /// to block requests that meet the conditions in the rule. For a request to be blocked,
        /// it must come from the IP address 192.0.2.44 <i>and</i> the <c>User-Agent</c> header
        /// in the request must contain the value <c>BadBot</c>. Further, requests that match
        /// these two conditions must be received at a rate of more than 1,000 requests every
        /// five minutes. If both conditions are met and the rate is exceeded, AWS WAF blocks
        /// the requests. If the rate drops below 1,000 for a five-minute period, AWS WAF no longer
        /// blocks the requests.
        /// </para>
        ///  
        /// <para>
        /// As a second example, suppose you want to limit requests to a particular page on your
        /// site. To do this, you could add the following to a <c>RateBasedRule</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> with <c>FieldToMatch</c> of <c>URI</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>PositionalConstraint</c> of <c>STARTS_WITH</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>TargetString</c> of <c>login</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Further, you specify a <c>RateLimit</c> of 1,000.
        /// </para>
        ///  
        /// <para>
        /// By adding this <c>RateBasedRule</c> to a <c>WebACL</c>, you could limit requests to
        /// your login page without affecting the rest of your site.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>RateBasedRule</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the rule. For more information,
        /// see <a>CreateByteMatchSet</a>, <a>CreateIPSet</a>, and <a>CreateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateRateBasedRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRateBasedRule</c> request to specify the predicates that you want
        /// to include in the rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <c>WebACL</c> that contains the <c>RateBasedRule</c>. For more
        /// information, see <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRateBasedRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRateBasedRule service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateRateBasedRule">REST API Reference for CreateRateBasedRule Operation</seealso>
        public virtual Task<CreateRateBasedRuleResponse> CreateRateBasedRuleAsync(CreateRateBasedRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRateBasedRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRateBasedRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRateBasedRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRegexMatchSet

        internal virtual CreateRegexMatchSetResponse CreateRegexMatchSet(CreateRegexMatchSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRegexMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegexMatchSetResponseUnmarshaller.Instance;

            return Invoke<CreateRegexMatchSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>RegexMatchSet</a>. You then use <a>UpdateRegexMatchSet</a> to identify
        /// the part of a web request that you want AWS WAF to inspect, such as the values of
        /// the <c>User-Agent</c> header or the query string. For example, you can create a <c>RegexMatchSet</c>
        /// that contains a <c>RegexMatchTuple</c> that looks for any requests with <c>User-Agent</c>
        /// headers that match a <c>RegexPatternSet</c> with pattern <c>B[a@]dB[o0]t</c>. You
        /// can then configure AWS WAF to reject those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>RegexMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateRegexMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateRegexMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateRegexMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateRegexMatchSet</a> request to specify the part of the request that
        /// you want AWS WAF to inspect (for example, the header or the URI) and the value, using
        /// a <c>RegexPatternSet</c>, that you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegexMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRegexMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateRegexMatchSet">REST API Reference for CreateRegexMatchSet Operation</seealso>
        public virtual Task<CreateRegexMatchSetResponse> CreateRegexMatchSetAsync(CreateRegexMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRegexMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegexMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRegexMatchSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRegexPatternSet

        internal virtual CreateRegexPatternSetResponse CreateRegexPatternSet(CreateRegexPatternSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegexPatternSetResponseUnmarshaller.Instance;

            return Invoke<CreateRegexPatternSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>RegexPatternSet</c>. You then use <a>UpdateRegexPatternSet</a> to specify
        /// the regular expression (regex) pattern that you want AWS WAF to search for, such as
        /// <c>B[a@]dB[o0]t</c>. You can then configure AWS WAF to reject those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>RegexPatternSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateRegexPatternSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateRegexPatternSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateRegexPatternSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateRegexPatternSet</a> request to specify the string that you want
        /// AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegexPatternSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRegexPatternSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateRegexPatternSet">REST API Reference for CreateRegexPatternSet Operation</seealso>
        public virtual Task<CreateRegexPatternSetResponse> CreateRegexPatternSetAsync(CreateRegexPatternSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegexPatternSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRegexPatternSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRule

        internal virtual CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return Invoke<CreateRuleResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>Rule</c>, which contains the <c>IPSet</c> objects, <c>ByteMatchSet</c>
        /// objects, and other predicates that identify the requests that you want to block. If
        /// you add more than one predicate to a <c>Rule</c>, a request must match all of the
        /// specifications to be allowed or blocked. For example, suppose that you add the following
        /// to a <c>Rule</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An <c>IPSet</c> that matches the IP address <c>192.0.2.44/32</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> that matches <c>BadBot</c> in the <c>User-Agent</c> header
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You then add the <c>Rule</c> to a <c>WebACL</c> and specify that you want to blocks
        /// requests that satisfy the <c>Rule</c>. For a request to be blocked, it must come from
        /// the IP address 192.0.2.44 <i>and</i> the <c>User-Agent</c> header in the request must
        /// contain the value <c>BadBot</c>.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>Rule</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the <c>Rule</c>. For
        /// more information, see <a>CreateByteMatchSet</a>, <a>CreateIPSet</a>, and <a>CreateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRule</c> request to specify the predicates that you want to include
        /// in the <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <c>WebACL</c> that contains the <c>Rule</c>. For more information,
        /// see <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description of the <a>Rule</a>. You can't change the name of a <c>Rule</c> after you create it.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="metricName">A friendly name or description for the metrics for this <c>Rule</c>. The name can contain only alphanumeric characters (A-Z, a-z, 0-9), with maximum length 128 and minimum length one. It can't contain whitespace or metric names reserved for AWS WAF, including "All" and "Default_Action." You can't change the name of the metric after you create the <c>Rule</c>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual Task<CreateRuleResponse> CreateRuleAsync(string name, string changeToken, string metricName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateRuleRequest();
            request.Name = name;
            request.ChangeToken = changeToken;
            request.MetricName = metricName;
            return CreateRuleAsync(request, cancellationToken);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>Rule</c>, which contains the <c>IPSet</c> objects, <c>ByteMatchSet</c>
        /// objects, and other predicates that identify the requests that you want to block. If
        /// you add more than one predicate to a <c>Rule</c>, a request must match all of the
        /// specifications to be allowed or blocked. For example, suppose that you add the following
        /// to a <c>Rule</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An <c>IPSet</c> that matches the IP address <c>192.0.2.44/32</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> that matches <c>BadBot</c> in the <c>User-Agent</c> header
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You then add the <c>Rule</c> to a <c>WebACL</c> and specify that you want to blocks
        /// requests that satisfy the <c>Rule</c>. For a request to be blocked, it must come from
        /// the IP address 192.0.2.44 <i>and</i> the <c>User-Agent</c> header in the request must
        /// contain the value <c>BadBot</c>.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>Rule</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the <c>Rule</c>. For
        /// more information, see <a>CreateByteMatchSet</a>, <a>CreateIPSet</a>, and <a>CreateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRule</c> request to specify the predicates that you want to include
        /// in the <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <c>WebACL</c> that contains the <c>Rule</c>. For more information,
        /// see <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRuleGroup

        internal virtual CreateRuleGroupResponse CreateRuleGroup(CreateRuleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleGroupResponseUnmarshaller.Instance;

            return Invoke<CreateRuleGroupResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>RuleGroup</c>. A rule group is a collection of predefined rules that
        /// you add to a web ACL. You use <a>UpdateRuleGroup</a> to add rules to the rule group.
        /// </para>
        ///  
        /// <para>
        /// Rule groups are subject to the following limits:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Three rule groups per account. You can request an increase to this limit by contacting
        /// customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// One rule group per web ACL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ten rules per rule group.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRuleGroup service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateRuleGroup">REST API Reference for CreateRuleGroup Operation</seealso>
        public virtual Task<CreateRuleGroupResponse> CreateRuleGroupAsync(CreateRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRuleGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSizeConstraintSet

        internal virtual CreateSizeConstraintSetResponse CreateSizeConstraintSet(CreateSizeConstraintSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSizeConstraintSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSizeConstraintSetResponseUnmarshaller.Instance;

            return Invoke<CreateSizeConstraintSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>SizeConstraintSet</c>. You then use <a>UpdateSizeConstraintSet</a> to
        /// identify the part of a web request that you want AWS WAF to check for length, such
        /// as the length of the <c>User-Agent</c> header or the length of the query string. For
        /// example, you can create a <c>SizeConstraintSet</c> that matches any requests that
        /// have a query string that is longer than 100 bytes. You can then configure AWS WAF
        /// to reject those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>SizeConstraintSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateSizeConstraintSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateSizeConstraintSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateSizeConstraintSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateSizeConstraintSet</a> request to specify the part of the request
        /// that you want AWS WAF to inspect (for example, the header or the URI) and the value
        /// that you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSizeConstraintSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSizeConstraintSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateSizeConstraintSet">REST API Reference for CreateSizeConstraintSet Operation</seealso>
        public virtual Task<CreateSizeConstraintSetResponse> CreateSizeConstraintSetAsync(CreateSizeConstraintSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSizeConstraintSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSizeConstraintSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSizeConstraintSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSqlInjectionMatchSet

        internal virtual CreateSqlInjectionMatchSetResponse CreateSqlInjectionMatchSet(CreateSqlInjectionMatchSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSqlInjectionMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSqlInjectionMatchSetResponseUnmarshaller.Instance;

            return Invoke<CreateSqlInjectionMatchSetResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>SqlInjectionMatchSet</a>, which you use to allow, block, or count requests
        /// that contain snippets of SQL code in a specified part of web requests. AWS WAF searches
        /// for character sequences that are likely to be malicious strings.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>SqlInjectionMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateSqlInjectionMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateSqlInjectionMatchSet</a> request to specify the parts of web requests
        /// in which you want to allow, block, or count malicious SQL code.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description for the <a>SqlInjectionMatchSet</a> that you're creating. You can't change <c>Name</c> after you create the <c>SqlInjectionMatchSet</c>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSqlInjectionMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateSqlInjectionMatchSet">REST API Reference for CreateSqlInjectionMatchSet Operation</seealso>
        public virtual Task<CreateSqlInjectionMatchSetResponse> CreateSqlInjectionMatchSetAsync(string name, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateSqlInjectionMatchSetRequest();
            request.Name = name;
            request.ChangeToken = changeToken;
            return CreateSqlInjectionMatchSetAsync(request, cancellationToken);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>SqlInjectionMatchSet</a>, which you use to allow, block, or count requests
        /// that contain snippets of SQL code in a specified part of web requests. AWS WAF searches
        /// for character sequences that are likely to be malicious strings.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>SqlInjectionMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateSqlInjectionMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateSqlInjectionMatchSet</a> request to specify the parts of web requests
        /// in which you want to allow, block, or count malicious SQL code.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSqlInjectionMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSqlInjectionMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateSqlInjectionMatchSet">REST API Reference for CreateSqlInjectionMatchSet Operation</seealso>
        public virtual Task<CreateSqlInjectionMatchSetResponse> CreateSqlInjectionMatchSetAsync(CreateSqlInjectionMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSqlInjectionMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSqlInjectionMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSqlInjectionMatchSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateWebACL

        internal virtual CreateWebACLResponse CreateWebACL(CreateWebACLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebACLResponseUnmarshaller.Instance;

            return Invoke<CreateWebACLResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <c>WebACL</c>, which contains the <c>Rules</c> that identify the CloudFront
        /// web requests that you want to allow, block, or count. AWS WAF evaluates <c>Rules</c>
        /// in order based on the value of <c>Priority</c> for each <c>Rule</c>.
        /// </para>
        ///  
        /// <para>
        /// You also specify a default action, either <c>ALLOW</c> or <c>BLOCK</c>. If a web request
        /// doesn't match any of the <c>Rules</c> in a <c>WebACL</c>, AWS WAF responds to the
        /// request with the default action. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>WebACL</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the <c>ByteMatchSet</c> objects and other predicates that you want
        /// to include in <c>Rules</c>. For more information, see <a>CreateByteMatchSet</a>, <a>UpdateByteMatchSet</a>,
        /// <a>CreateIPSet</a>, <a>UpdateIPSet</a>, <a>CreateSqlInjectionMatchSet</a>, and <a>UpdateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update the <c>Rules</c> that you want to include in the <c>WebACL</c>.
        /// For more information, see <a>CreateRule</a> and <a>UpdateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateWebACL</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateWebACL</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateWebACL</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateWebACL</a> request to specify the <c>Rules</c> that you want to
        /// include in the <c>WebACL</c>, to specify the default action, and to associate the
        /// <c>WebACL</c> with a CloudFront distribution.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS
        /// WAF Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWebACL service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateWebACL">REST API Reference for CreateWebACL Operation</seealso>
        public virtual Task<CreateWebACLResponse> CreateWebACLAsync(CreateWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWebACLResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateWebACLMigrationStack

        internal virtual CreateWebACLMigrationStackResponse CreateWebACLMigrationStack(CreateWebACLMigrationStackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWebACLMigrationStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebACLMigrationStackResponseUnmarshaller.Instance;

            return Invoke<CreateWebACLMigrationStackResponse>(request, options);
        }



        /// <summary>
        /// Creates an AWS CloudFormation WAFV2 template for the specified web ACL in the specified
        /// Amazon S3 bucket. Then, in CloudFormation, you create a stack from the template, to
        /// create the web ACL and its resources in AWS WAFV2. Use this to migrate your AWS WAF
        /// Classic web ACL to the latest version of AWS WAF.
        /// 
        ///  
        /// <para>
        /// This is part of a larger migration procedure for web ACLs from AWS WAF Classic to
        /// the latest version of AWS WAF. For the full procedure, including caveats and manual
        /// steps to complete the migration and switch over to the new web ACL, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-migrating-from-classic.html">Migrating
        /// your AWS WAF Classic resources to AWS WAF</a> in the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebACLMigrationStack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWebACLMigrationStack service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFEntityMigrationException">
        /// The operation failed due to a problem with the migration. The failure cause is provided
        /// in the exception, in the <c>MigrationErrorType</c>: 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENTITY_NOT_SUPPORTED</c> - The web ACL has an unsupported entity but the <c>IgnoreUnsupportedType</c>
        /// is not set to true.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENTITY_NOT_FOUND</c> - The web ACL doesn't exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3_BUCKET_NO_PERMISSION</c> - You don't have permission to perform the <c>PutObject</c>
        /// action to the specified Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3_BUCKET_NOT_ACCESSIBLE</c> - The bucket policy doesn't allow AWS WAF to perform
        /// the <c>PutObject</c> action in the bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3_BUCKET_NOT_FOUND</c> - The S3 bucket doesn't exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3_BUCKET_INVALID_REGION</c> - The S3 bucket is not in the same Region as the
        /// web ACL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3_INTERNAL_ERROR</c> - AWS WAF failed to create the template in the S3 bucket
        /// for another reason.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateWebACLMigrationStack">REST API Reference for CreateWebACLMigrationStack Operation</seealso>
        public virtual Task<CreateWebACLMigrationStackResponse> CreateWebACLMigrationStackAsync(CreateWebACLMigrationStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWebACLMigrationStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebACLMigrationStackResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWebACLMigrationStackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateXssMatchSet

        internal virtual CreateXssMatchSetResponse CreateXssMatchSet(CreateXssMatchSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateXssMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateXssMatchSetResponseUnmarshaller.Instance;

            return Invoke<CreateXssMatchSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates an <a>XssMatchSet</a>, which you use to allow, block, or count requests that
        /// contain cross-site scripting attacks in the specified part of web requests. AWS WAF
        /// searches for character sequences that are likely to be malicious strings.
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <c>XssMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>CreateXssMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>CreateXssMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateXssMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateXssMatchSet</a> request to specify the parts of web requests in
        /// which you want to allow, block, or count cross-site scripting attacks.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateXssMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateXssMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateXssMatchSet">REST API Reference for CreateXssMatchSet Operation</seealso>
        public virtual Task<CreateXssMatchSetResponse> CreateXssMatchSetAsync(CreateXssMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateXssMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateXssMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateXssMatchSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteByteMatchSet

        internal virtual DeleteByteMatchSetResponse DeleteByteMatchSet(DeleteByteMatchSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteByteMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteByteMatchSetResponseUnmarshaller.Instance;

            return Invoke<DeleteByteMatchSetResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>ByteMatchSet</a>. You can't delete a <c>ByteMatchSet</c>
        /// if it's still used in any <c>Rules</c> or if it still includes any <a>ByteMatchTuple</a>
        /// objects (any filters).
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>ByteMatchSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>ByteMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>ByteMatchSet</c> to remove filters, if any. For more information, see
        /// <a>UpdateByteMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteByteMatchSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="byteMatchSetId">The <c>ByteMatchSetId</c> of the <a>ByteMatchSet</a> that you want to delete. <c>ByteMatchSetId</c> is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteByteMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteByteMatchSet">REST API Reference for DeleteByteMatchSet Operation</seealso>
        public virtual Task<DeleteByteMatchSetResponse> DeleteByteMatchSetAsync(string byteMatchSetId, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteByteMatchSetRequest();
            request.ByteMatchSetId = byteMatchSetId;
            request.ChangeToken = changeToken;
            return DeleteByteMatchSetAsync(request, cancellationToken);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>ByteMatchSet</a>. You can't delete a <c>ByteMatchSet</c>
        /// if it's still used in any <c>Rules</c> or if it still includes any <a>ByteMatchTuple</a>
        /// objects (any filters).
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>ByteMatchSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>ByteMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>ByteMatchSet</c> to remove filters, if any. For more information, see
        /// <a>UpdateByteMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteByteMatchSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteByteMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteByteMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteByteMatchSet">REST API Reference for DeleteByteMatchSet Operation</seealso>
        public virtual Task<DeleteByteMatchSetResponse> DeleteByteMatchSetAsync(DeleteByteMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteByteMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteByteMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteByteMatchSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteGeoMatchSet

        internal virtual DeleteGeoMatchSetResponse DeleteGeoMatchSet(DeleteGeoMatchSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGeoMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGeoMatchSetResponseUnmarshaller.Instance;

            return Invoke<DeleteGeoMatchSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>GeoMatchSet</a>. You can't delete a <c>GeoMatchSet</c> if
        /// it's still used in any <c>Rules</c> or if it still includes any countries.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>GeoMatchSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>GeoMatchSet</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>GeoMatchSet</c> to remove any countries. For more information, see <a>UpdateGeoMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteGeoMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteGeoMatchSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGeoMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGeoMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteGeoMatchSet">REST API Reference for DeleteGeoMatchSet Operation</seealso>
        public virtual Task<DeleteGeoMatchSetResponse> DeleteGeoMatchSetAsync(DeleteGeoMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGeoMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGeoMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGeoMatchSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteIPSet

        internal virtual DeleteIPSetResponse DeleteIPSet(DeleteIPSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIPSetResponseUnmarshaller.Instance;

            return Invoke<DeleteIPSetResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes an <a>IPSet</a>. You can't delete an <c>IPSet</c> if it's still
        /// used in any <c>Rules</c> or if it still includes any IP addresses.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove an <c>IPSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete an <c>IPSet</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>IPSet</c> to remove IP address ranges, if any. For more information,
        /// see <a>UpdateIPSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteIPSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteIPSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="ipSetId">The <c>IPSetId</c> of the <a>IPSet</a> that you want to delete. <c>IPSetId</c> is returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIPSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        public virtual Task<DeleteIPSetResponse> DeleteIPSetAsync(string ipSetId, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteIPSetRequest();
            request.IPSetId = ipSetId;
            request.ChangeToken = changeToken;
            return DeleteIPSetAsync(request, cancellationToken);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes an <a>IPSet</a>. You can't delete an <c>IPSet</c> if it's still
        /// used in any <c>Rules</c> or if it still includes any IP addresses.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove an <c>IPSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete an <c>IPSet</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>IPSet</c> to remove IP address ranges, if any. For more information,
        /// see <a>UpdateIPSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteIPSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteIPSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIPSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        public virtual Task<DeleteIPSetResponse> DeleteIPSetAsync(DeleteIPSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIPSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIPSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteLoggingConfiguration

        internal virtual DeleteLoggingConfigurationResponse DeleteLoggingConfiguration(DeleteLoggingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteLoggingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes the <a>LoggingConfiguration</a> from the specified web ACL.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLoggingConfiguration service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteLoggingConfiguration">REST API Reference for DeleteLoggingConfiguration Operation</seealso>
        public virtual Task<DeleteLoggingConfigurationResponse> DeleteLoggingConfigurationAsync(DeleteLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoggingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLoggingConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeletePermissionPolicy

        internal virtual DeletePermissionPolicyResponse DeletePermissionPolicy(DeletePermissionPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePermissionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePermissionPolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePermissionPolicyResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes an IAM policy from the specified RuleGroup.
        /// </para>
        ///  
        /// <para>
        /// The user making the request must be the owner of the RuleGroup.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePermissionPolicy service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeletePermissionPolicy">REST API Reference for DeletePermissionPolicy Operation</seealso>
        public virtual Task<DeletePermissionPolicyResponse> DeletePermissionPolicyAsync(DeletePermissionPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePermissionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePermissionPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePermissionPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRateBasedRule

        internal virtual DeleteRateBasedRuleResponse DeleteRateBasedRule(DeleteRateBasedRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRateBasedRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRateBasedRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteRateBasedRuleResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>RateBasedRule</a>. You can't delete a rule if it's still
        /// used in any <c>WebACL</c> objects or if it still includes any predicates, such as
        /// <c>ByteMatchSet</c> objects.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a rule from a <c>WebACL</c>, use <a>UpdateWebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>RateBasedRule</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>RateBasedRule</c> to remove predicates, if any. For more information,
        /// see <a>UpdateRateBasedRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteRateBasedRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteRateBasedRule</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRateBasedRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRateBasedRule service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteRateBasedRule">REST API Reference for DeleteRateBasedRule Operation</seealso>
        public virtual Task<DeleteRateBasedRuleResponse> DeleteRateBasedRuleAsync(DeleteRateBasedRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRateBasedRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRateBasedRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRateBasedRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRegexMatchSet

        internal virtual DeleteRegexMatchSetResponse DeleteRegexMatchSet(DeleteRegexMatchSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRegexMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegexMatchSetResponseUnmarshaller.Instance;

            return Invoke<DeleteRegexMatchSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>RegexMatchSet</a>. You can't delete a <c>RegexMatchSet</c>
        /// if it's still used in any <c>Rules</c> or if it still includes any <c>RegexMatchTuples</c>
        /// objects (any filters).
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>RegexMatchSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>RegexMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>RegexMatchSet</c> to remove filters, if any. For more information, see
        /// <a>UpdateRegexMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteRegexMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteRegexMatchSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegexMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRegexMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteRegexMatchSet">REST API Reference for DeleteRegexMatchSet Operation</seealso>
        public virtual Task<DeleteRegexMatchSetResponse> DeleteRegexMatchSetAsync(DeleteRegexMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRegexMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegexMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRegexMatchSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRegexPatternSet

        internal virtual DeleteRegexPatternSetResponse DeleteRegexPatternSet(DeleteRegexPatternSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegexPatternSetResponseUnmarshaller.Instance;

            return Invoke<DeleteRegexPatternSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>RegexPatternSet</a>. You can't delete a <c>RegexPatternSet</c>
        /// if it's still used in any <c>RegexMatchSet</c> or if the <c>RegexPatternSet</c> is
        /// not empty. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegexPatternSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRegexPatternSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteRegexPatternSet">REST API Reference for DeleteRegexPatternSet Operation</seealso>
        public virtual Task<DeleteRegexPatternSetResponse> DeleteRegexPatternSetAsync(DeleteRegexPatternSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegexPatternSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRegexPatternSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRule

        internal virtual DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>Rule</a>. You can't delete a <c>Rule</c> if it's still used
        /// in any <c>WebACL</c> objects or if it still includes any predicates, such as <c>ByteMatchSet</c>
        /// objects.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>Rule</c> from a <c>WebACL</c>, use <a>UpdateWebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>Rule</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>Rule</c> to remove predicates, if any. For more information, see <a>UpdateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteRule</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="ruleId">The <c>RuleId</c> of the <a>Rule</a> that you want to delete. <c>RuleId</c> is returned by <a>CreateRule</a> and by <a>ListRules</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual Task<DeleteRuleResponse> DeleteRuleAsync(string ruleId, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteRuleRequest();
            request.RuleId = ruleId;
            request.ChangeToken = changeToken;
            return DeleteRuleAsync(request, cancellationToken);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>Rule</a>. You can't delete a <c>Rule</c> if it's still used
        /// in any <c>WebACL</c> objects or if it still includes any predicates, such as <c>ByteMatchSet</c>
        /// objects.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>Rule</c> from a <c>WebACL</c>, use <a>UpdateWebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>Rule</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>Rule</c> to remove predicates, if any. For more information, see <a>UpdateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteRule</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteRule</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRuleGroup

        internal virtual DeleteRuleGroupResponse DeleteRuleGroup(DeleteRuleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleGroupResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>RuleGroup</a>. You can't delete a <c>RuleGroup</c> if it's
        /// still used in any <c>WebACL</c> objects or if it still includes any rules.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>RuleGroup</c> from a <c>WebACL</c>, use <a>UpdateWebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>RuleGroup</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>RuleGroup</c> to remove rules, if any. For more information, see <a>UpdateRuleGroup</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteRuleGroup</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteRuleGroup</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRuleGroup service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteRuleGroup">REST API Reference for DeleteRuleGroup Operation</seealso>
        public virtual Task<DeleteRuleGroupResponse> DeleteRuleGroupAsync(DeleteRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRuleGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSizeConstraintSet

        internal virtual DeleteSizeConstraintSetResponse DeleteSizeConstraintSet(DeleteSizeConstraintSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSizeConstraintSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSizeConstraintSetResponseUnmarshaller.Instance;

            return Invoke<DeleteSizeConstraintSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>SizeConstraintSet</a>. You can't delete a <c>SizeConstraintSet</c>
        /// if it's still used in any <c>Rules</c> or if it still includes any <a>SizeConstraint</a>
        /// objects (any filters).
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>SizeConstraintSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>SizeConstraintSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>SizeConstraintSet</c> to remove filters, if any. For more information,
        /// see <a>UpdateSizeConstraintSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteSizeConstraintSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteSizeConstraintSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSizeConstraintSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSizeConstraintSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteSizeConstraintSet">REST API Reference for DeleteSizeConstraintSet Operation</seealso>
        public virtual Task<DeleteSizeConstraintSetResponse> DeleteSizeConstraintSetAsync(DeleteSizeConstraintSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSizeConstraintSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSizeConstraintSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSizeConstraintSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSqlInjectionMatchSet

        internal virtual DeleteSqlInjectionMatchSetResponse DeleteSqlInjectionMatchSet(DeleteSqlInjectionMatchSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSqlInjectionMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSqlInjectionMatchSetResponseUnmarshaller.Instance;

            return Invoke<DeleteSqlInjectionMatchSetResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>SqlInjectionMatchSet</a>. You can't delete a <c>SqlInjectionMatchSet</c>
        /// if it's still used in any <c>Rules</c> or if it still contains any <a>SqlInjectionMatchTuple</a>
        /// objects.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>SqlInjectionMatchSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>SqlInjectionMatchSet</c> from AWS WAF, perform the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>SqlInjectionMatchSet</c> to remove filters, if any. For more information,
        /// see <a>UpdateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="sqlInjectionMatchSetId">The <c>SqlInjectionMatchSetId</c> of the <a>SqlInjectionMatchSet</a> that you want to delete. <c>SqlInjectionMatchSetId</c> is returned by <a>CreateSqlInjectionMatchSet</a> and by <a>ListSqlInjectionMatchSets</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSqlInjectionMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteSqlInjectionMatchSet">REST API Reference for DeleteSqlInjectionMatchSet Operation</seealso>
        public virtual Task<DeleteSqlInjectionMatchSetResponse> DeleteSqlInjectionMatchSetAsync(string sqlInjectionMatchSetId, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteSqlInjectionMatchSetRequest();
            request.SqlInjectionMatchSetId = sqlInjectionMatchSetId;
            request.ChangeToken = changeToken;
            return DeleteSqlInjectionMatchSetAsync(request, cancellationToken);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>SqlInjectionMatchSet</a>. You can't delete a <c>SqlInjectionMatchSet</c>
        /// if it's still used in any <c>Rules</c> or if it still contains any <a>SqlInjectionMatchTuple</a>
        /// objects.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove a <c>SqlInjectionMatchSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <c>SqlInjectionMatchSet</c> from AWS WAF, perform the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>SqlInjectionMatchSet</c> to remove filters, if any. For more information,
        /// see <a>UpdateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteSqlInjectionMatchSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSqlInjectionMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSqlInjectionMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteSqlInjectionMatchSet">REST API Reference for DeleteSqlInjectionMatchSet Operation</seealso>
        public virtual Task<DeleteSqlInjectionMatchSetResponse> DeleteSqlInjectionMatchSetAsync(DeleteSqlInjectionMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSqlInjectionMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSqlInjectionMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSqlInjectionMatchSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteWebACL

        internal virtual DeleteWebACLResponse DeleteWebACL(DeleteWebACLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebACLResponseUnmarshaller.Instance;

            return Invoke<DeleteWebACLResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>WebACL</a>. You can't delete a <c>WebACL</c> if it still
        /// contains any <c>Rules</c>.
        /// </para>
        ///  
        /// <para>
        /// To delete a <c>WebACL</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>WebACL</c> to remove <c>Rules</c>, if any. For more information, see
        /// <a>UpdateWebACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteWebACL</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteWebACL</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="webACLId">The <c>WebACLId</c> of the <a>WebACL</a> that you want to delete. <c>WebACLId</c> is returned by <a>CreateWebACL</a> and by <a>ListWebACLs</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWebACL service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteWebACL">REST API Reference for DeleteWebACL Operation</seealso>
        public virtual Task<DeleteWebACLResponse> DeleteWebACLAsync(string webACLId, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteWebACLRequest();
            request.WebACLId = webACLId;
            request.ChangeToken = changeToken;
            return DeleteWebACLAsync(request, cancellationToken);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes a <a>WebACL</a>. You can't delete a <c>WebACL</c> if it still
        /// contains any <c>Rules</c>.
        /// </para>
        ///  
        /// <para>
        /// To delete a <c>WebACL</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>WebACL</c> to remove <c>Rules</c>, if any. For more information, see
        /// <a>UpdateWebACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteWebACL</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteWebACL</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWebACL service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteWebACL">REST API Reference for DeleteWebACL Operation</seealso>
        public virtual Task<DeleteWebACLResponse> DeleteWebACLAsync(DeleteWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWebACLResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteXssMatchSet

        internal virtual DeleteXssMatchSetResponse DeleteXssMatchSet(DeleteXssMatchSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteXssMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteXssMatchSetResponseUnmarshaller.Instance;

            return Invoke<DeleteXssMatchSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Permanently deletes an <a>XssMatchSet</a>. You can't delete an <c>XssMatchSet</c>
        /// if it's still used in any <c>Rules</c> or if it still contains any <a>XssMatchTuple</a>
        /// objects.
        /// </para>
        ///  
        /// <para>
        /// If you just want to remove an <c>XssMatchSet</c> from a <c>Rule</c>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete an <c>XssMatchSet</c> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <c>XssMatchSet</c> to remove filters, if any. For more information, see
        /// <a>UpdateXssMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of a <c>DeleteXssMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <c>DeleteXssMatchSet</c> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteXssMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteXssMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>WebACL</c> that still contains one or more <c>Rule</c> objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that still contains one or more <c>ByteMatchSet</c>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that contains one or more <c>ByteMatchTuple</c>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <c>IPSet</c> that references one or more IP addresses.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteXssMatchSet">REST API Reference for DeleteXssMatchSet Operation</seealso>
        public virtual Task<DeleteXssMatchSetResponse> DeleteXssMatchSetAsync(DeleteXssMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteXssMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteXssMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteXssMatchSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateWebACL

        internal virtual DisassociateWebACLResponse DisassociateWebACL(DisassociateWebACLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWebACLResponseUnmarshaller.Instance;

            return Invoke<DisassociateWebACLResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic Regional</b> documentation. For more information, see <a
        /// href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Removes a web ACL from the specified resource, either an application load balancer
        /// or Amazon API Gateway stage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateWebACL service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DisassociateWebACL">REST API Reference for DisassociateWebACL Operation</seealso>
        public virtual Task<DisassociateWebACLResponse> DisassociateWebACLAsync(DisassociateWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateWebACLResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetByteMatchSet

        internal virtual GetByteMatchSetResponse GetByteMatchSet(GetByteMatchSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetByteMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetByteMatchSetResponseUnmarshaller.Instance;

            return Invoke<GetByteMatchSetResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>ByteMatchSet</a> specified by <c>ByteMatchSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="byteMatchSetId">The <c>ByteMatchSetId</c> of the <a>ByteMatchSet</a> that you want to get. <c>ByteMatchSetId</c> is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetByteMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetByteMatchSet">REST API Reference for GetByteMatchSet Operation</seealso>
        public virtual Task<GetByteMatchSetResponse> GetByteMatchSetAsync(string byteMatchSetId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetByteMatchSetRequest();
            request.ByteMatchSetId = byteMatchSetId;
            return GetByteMatchSetAsync(request, cancellationToken);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>ByteMatchSet</a> specified by <c>ByteMatchSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetByteMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetByteMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetByteMatchSet">REST API Reference for GetByteMatchSet Operation</seealso>
        public virtual Task<GetByteMatchSetResponse> GetByteMatchSetAsync(GetByteMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetByteMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetByteMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetByteMatchSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetChangeToken

        internal virtual GetChangeTokenResponse GetChangeToken()
        {
            return GetChangeToken(new GetChangeTokenRequest());
        }
        internal virtual GetChangeTokenResponse GetChangeToken(GetChangeTokenRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetChangeTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChangeTokenResponseUnmarshaller.Instance;

            return Invoke<GetChangeTokenResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// When you want to create, update, or delete AWS WAF objects, get a change token and
        /// include the change token in the create, update, or delete request. Change tokens ensure
        /// that your application doesn't submit conflicting requests to AWS WAF.
        /// </para>
        ///  
        /// <para>
        /// Each create, update, or delete request must use a unique change token. If your application
        /// submits a <c>GetChangeToken</c> request and then submits a second <c>GetChangeToken</c>
        /// request before submitting a create, update, or delete request, the second <c>GetChangeToken</c>
        /// request returns the same value as the first <c>GetChangeToken</c> request.
        /// </para>
        ///  
        /// <para>
        /// When you use a change token in a create, update, or delete request, the status of
        /// the change token changes to <c>PENDING</c>, which indicates that AWS WAF is propagating
        /// the change to all AWS WAF servers. Use <c>GetChangeTokenStatus</c> to determine the
        /// status of your change token.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChangeToken service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetChangeToken">REST API Reference for GetChangeToken Operation</seealso>
        public virtual Task<GetChangeTokenResponse> GetChangeTokenAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetChangeTokenAsync(new GetChangeTokenRequest(), cancellationToken);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// When you want to create, update, or delete AWS WAF objects, get a change token and
        /// include the change token in the create, update, or delete request. Change tokens ensure
        /// that your application doesn't submit conflicting requests to AWS WAF.
        /// </para>
        ///  
        /// <para>
        /// Each create, update, or delete request must use a unique change token. If your application
        /// submits a <c>GetChangeToken</c> request and then submits a second <c>GetChangeToken</c>
        /// request before submitting a create, update, or delete request, the second <c>GetChangeToken</c>
        /// request returns the same value as the first <c>GetChangeToken</c> request.
        /// </para>
        ///  
        /// <para>
        /// When you use a change token in a create, update, or delete request, the status of
        /// the change token changes to <c>PENDING</c>, which indicates that AWS WAF is propagating
        /// the change to all AWS WAF servers. Use <c>GetChangeTokenStatus</c> to determine the
        /// status of your change token.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChangeToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChangeToken service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetChangeToken">REST API Reference for GetChangeToken Operation</seealso>
        public virtual Task<GetChangeTokenResponse> GetChangeTokenAsync(GetChangeTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetChangeTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChangeTokenResponseUnmarshaller.Instance;

            return InvokeAsync<GetChangeTokenResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetChangeTokenStatus

        internal virtual GetChangeTokenStatusResponse GetChangeTokenStatus(GetChangeTokenStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetChangeTokenStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChangeTokenStatusResponseUnmarshaller.Instance;

            return Invoke<GetChangeTokenStatusResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the status of a <c>ChangeToken</c> that you got by calling <a>GetChangeToken</a>.
        /// <c>ChangeTokenStatus</c> is one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PROVISIONED</c>: You requested the change token by calling <c>GetChangeToken</c>,
        /// but you haven't used it yet in a call to create, update, or delete an AWS WAF object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c>: AWS WAF is propagating the create, update, or delete request to all
        /// AWS WAF servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSYNC</c>: Propagation is complete.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="changeToken">The change token for which you want to get the status. This change token was previously returned in the <c>GetChangeToken</c> response.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChangeTokenStatus service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetChangeTokenStatus">REST API Reference for GetChangeTokenStatus Operation</seealso>
        public virtual Task<GetChangeTokenStatusResponse> GetChangeTokenStatusAsync(string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetChangeTokenStatusRequest();
            request.ChangeToken = changeToken;
            return GetChangeTokenStatusAsync(request, cancellationToken);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the status of a <c>ChangeToken</c> that you got by calling <a>GetChangeToken</a>.
        /// <c>ChangeTokenStatus</c> is one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PROVISIONED</c>: You requested the change token by calling <c>GetChangeToken</c>,
        /// but you haven't used it yet in a call to create, update, or delete an AWS WAF object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c>: AWS WAF is propagating the create, update, or delete request to all
        /// AWS WAF servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSYNC</c>: Propagation is complete.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChangeTokenStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChangeTokenStatus service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetChangeTokenStatus">REST API Reference for GetChangeTokenStatus Operation</seealso>
        public virtual Task<GetChangeTokenStatusResponse> GetChangeTokenStatusAsync(GetChangeTokenStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetChangeTokenStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChangeTokenStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetChangeTokenStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetGeoMatchSet

        internal virtual GetGeoMatchSetResponse GetGeoMatchSet(GetGeoMatchSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGeoMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGeoMatchSetResponseUnmarshaller.Instance;

            return Invoke<GetGeoMatchSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>GeoMatchSet</a> that is specified by <c>GeoMatchSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeoMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGeoMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetGeoMatchSet">REST API Reference for GetGeoMatchSet Operation</seealso>
        public virtual Task<GetGeoMatchSetResponse> GetGeoMatchSetAsync(GetGeoMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGeoMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGeoMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetGeoMatchSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetIPSet

        internal virtual GetIPSetResponse GetIPSet(GetIPSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIPSetResponseUnmarshaller.Instance;

            return Invoke<GetIPSetResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>IPSet</a> that is specified by <c>IPSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="ipSetId">The <c>IPSetId</c> of the <a>IPSet</a> that you want to get. <c>IPSetId</c> is returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIPSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        public virtual Task<GetIPSetResponse> GetIPSetAsync(string ipSetId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetIPSetRequest();
            request.IPSetId = ipSetId;
            return GetIPSetAsync(request, cancellationToken);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>IPSet</a> that is specified by <c>IPSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIPSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        public virtual Task<GetIPSetResponse> GetIPSetAsync(GetIPSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIPSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetIPSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetLoggingConfiguration

        internal virtual GetLoggingConfigurationResponse GetLoggingConfiguration(GetLoggingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetLoggingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>LoggingConfiguration</a> for the specified web ACL.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLoggingConfiguration service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetLoggingConfiguration">REST API Reference for GetLoggingConfiguration Operation</seealso>
        public virtual Task<GetLoggingConfigurationResponse> GetLoggingConfigurationAsync(GetLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoggingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetLoggingConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetPermissionPolicy

        internal virtual GetPermissionPolicyResponse GetPermissionPolicy(GetPermissionPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPermissionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPermissionPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPermissionPolicyResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the IAM policy attached to the RuleGroup.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPermissionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPermissionPolicy service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetPermissionPolicy">REST API Reference for GetPermissionPolicy Operation</seealso>
        public virtual Task<GetPermissionPolicyResponse> GetPermissionPolicyAsync(GetPermissionPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPermissionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPermissionPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetPermissionPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRateBasedRule

        internal virtual GetRateBasedRuleResponse GetRateBasedRule(GetRateBasedRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRateBasedRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRateBasedRuleResponseUnmarshaller.Instance;

            return Invoke<GetRateBasedRuleResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>RateBasedRule</a> that is specified by the <c>RuleId</c> that you included
        /// in the <c>GetRateBasedRule</c> request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRateBasedRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRateBasedRule service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetRateBasedRule">REST API Reference for GetRateBasedRule Operation</seealso>
        public virtual Task<GetRateBasedRuleResponse> GetRateBasedRuleAsync(GetRateBasedRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRateBasedRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRateBasedRuleResponseUnmarshaller.Instance;

            return InvokeAsync<GetRateBasedRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRateBasedRuleManagedKeys

        internal virtual GetRateBasedRuleManagedKeysResponse GetRateBasedRuleManagedKeys(GetRateBasedRuleManagedKeysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRateBasedRuleManagedKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRateBasedRuleManagedKeysResponseUnmarshaller.Instance;

            return Invoke<GetRateBasedRuleManagedKeysResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of IP addresses currently being blocked by the <a>RateBasedRule</a>
        /// that is specified by the <c>RuleId</c>. The maximum number of managed keys that will
        /// be blocked is 10,000. If more than 10,000 addresses exceed the rate limit, the 10,000
        /// addresses with the highest rates will be blocked.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRateBasedRuleManagedKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRateBasedRuleManagedKeys service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetRateBasedRuleManagedKeys">REST API Reference for GetRateBasedRuleManagedKeys Operation</seealso>
        public virtual Task<GetRateBasedRuleManagedKeysResponse> GetRateBasedRuleManagedKeysAsync(GetRateBasedRuleManagedKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRateBasedRuleManagedKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRateBasedRuleManagedKeysResponseUnmarshaller.Instance;

            return InvokeAsync<GetRateBasedRuleManagedKeysResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRegexMatchSet

        internal virtual GetRegexMatchSetResponse GetRegexMatchSet(GetRegexMatchSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRegexMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegexMatchSetResponseUnmarshaller.Instance;

            return Invoke<GetRegexMatchSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>RegexMatchSet</a> specified by <c>RegexMatchSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegexMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRegexMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetRegexMatchSet">REST API Reference for GetRegexMatchSet Operation</seealso>
        public virtual Task<GetRegexMatchSetResponse> GetRegexMatchSetAsync(GetRegexMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRegexMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegexMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetRegexMatchSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRegexPatternSet

        internal virtual GetRegexPatternSetResponse GetRegexPatternSet(GetRegexPatternSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegexPatternSetResponseUnmarshaller.Instance;

            return Invoke<GetRegexPatternSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>RegexPatternSet</a> specified by <c>RegexPatternSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegexPatternSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRegexPatternSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetRegexPatternSet">REST API Reference for GetRegexPatternSet Operation</seealso>
        public virtual Task<GetRegexPatternSetResponse> GetRegexPatternSetAsync(GetRegexPatternSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegexPatternSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetRegexPatternSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRule

        internal virtual GetRuleResponse GetRule(GetRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuleResponseUnmarshaller.Instance;

            return Invoke<GetRuleResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>Rule</a> that is specified by the <c>RuleId</c> that you included in
        /// the <c>GetRule</c> request.
        /// </para>
        /// </summary>
        /// <param name="ruleId">The <c>RuleId</c> of the <a>Rule</a> that you want to get. <c>RuleId</c> is returned by <a>CreateRule</a> and by <a>ListRules</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRule service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetRule">REST API Reference for GetRule Operation</seealso>
        public virtual Task<GetRuleResponse> GetRuleAsync(string ruleId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetRuleRequest();
            request.RuleId = ruleId;
            return GetRuleAsync(request, cancellationToken);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>Rule</a> that is specified by the <c>RuleId</c> that you included in
        /// the <c>GetRule</c> request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRule service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetRule">REST API Reference for GetRule Operation</seealso>
        public virtual Task<GetRuleResponse> GetRuleAsync(GetRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuleResponseUnmarshaller.Instance;

            return InvokeAsync<GetRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRuleGroup

        internal virtual GetRuleGroupResponse GetRuleGroup(GetRuleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuleGroupResponseUnmarshaller.Instance;

            return Invoke<GetRuleGroupResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>RuleGroup</a> that is specified by the <c>RuleGroupId</c> that you
        /// included in the <c>GetRuleGroup</c> request.
        /// </para>
        ///  
        /// <para>
        /// To view the rules in a rule group, use <a>ListActivatedRulesInRuleGroup</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRuleGroup service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetRuleGroup">REST API Reference for GetRuleGroup Operation</seealso>
        public virtual Task<GetRuleGroupResponse> GetRuleGroupAsync(GetRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetRuleGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSampledRequests

        internal virtual GetSampledRequestsResponse GetSampledRequests(GetSampledRequestsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSampledRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSampledRequestsResponseUnmarshaller.Instance;

            return Invoke<GetSampledRequestsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Gets detailed information about a specified number of requests--a sample--that AWS
        /// WAF randomly selects from among the first 5,000 requests that your AWS resource received
        /// during a time range that you choose. You can specify a sample size of up to 500 requests,
        /// and you can specify any time range in the previous three hours.
        /// </para>
        ///  
        /// <para>
        ///  <c>GetSampledRequests</c> returns a time range, which is usually the time range that
        /// you specified. However, if your resource (such as a CloudFront distribution) received
        /// 5,000 requests before the specified time range elapsed, <c>GetSampledRequests</c>
        /// returns an updated time range. This new time range indicates the actual period during
        /// which AWS WAF selected the requests in the sample.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSampledRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSampledRequests service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetSampledRequests">REST API Reference for GetSampledRequests Operation</seealso>
        public virtual Task<GetSampledRequestsResponse> GetSampledRequestsAsync(GetSampledRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSampledRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSampledRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSampledRequestsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSizeConstraintSet

        internal virtual GetSizeConstraintSetResponse GetSizeConstraintSet(GetSizeConstraintSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSizeConstraintSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSizeConstraintSetResponseUnmarshaller.Instance;

            return Invoke<GetSizeConstraintSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>SizeConstraintSet</a> specified by <c>SizeConstraintSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSizeConstraintSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSizeConstraintSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetSizeConstraintSet">REST API Reference for GetSizeConstraintSet Operation</seealso>
        public virtual Task<GetSizeConstraintSetResponse> GetSizeConstraintSetAsync(GetSizeConstraintSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSizeConstraintSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSizeConstraintSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetSizeConstraintSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSqlInjectionMatchSet

        internal virtual GetSqlInjectionMatchSetResponse GetSqlInjectionMatchSet(GetSqlInjectionMatchSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSqlInjectionMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSqlInjectionMatchSetResponseUnmarshaller.Instance;

            return Invoke<GetSqlInjectionMatchSetResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>SqlInjectionMatchSet</a> that is specified by <c>SqlInjectionMatchSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="sqlInjectionMatchSetId">The <c>SqlInjectionMatchSetId</c> of the <a>SqlInjectionMatchSet</a> that you want to get. <c>SqlInjectionMatchSetId</c> is returned by <a>CreateSqlInjectionMatchSet</a> and by <a>ListSqlInjectionMatchSets</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSqlInjectionMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetSqlInjectionMatchSet">REST API Reference for GetSqlInjectionMatchSet Operation</seealso>
        public virtual Task<GetSqlInjectionMatchSetResponse> GetSqlInjectionMatchSetAsync(string sqlInjectionMatchSetId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetSqlInjectionMatchSetRequest();
            request.SqlInjectionMatchSetId = sqlInjectionMatchSetId;
            return GetSqlInjectionMatchSetAsync(request, cancellationToken);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>SqlInjectionMatchSet</a> that is specified by <c>SqlInjectionMatchSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSqlInjectionMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSqlInjectionMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetSqlInjectionMatchSet">REST API Reference for GetSqlInjectionMatchSet Operation</seealso>
        public virtual Task<GetSqlInjectionMatchSetResponse> GetSqlInjectionMatchSetAsync(GetSqlInjectionMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSqlInjectionMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSqlInjectionMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetSqlInjectionMatchSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetWebACL

        internal virtual GetWebACLResponse GetWebACL(GetWebACLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebACLResponseUnmarshaller.Instance;

            return Invoke<GetWebACLResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>WebACL</a> that is specified by <c>WebACLId</c>.
        /// </para>
        /// </summary>
        /// <param name="webACLId">The <c>WebACLId</c> of the <a>WebACL</a> that you want to get. <c>WebACLId</c> is returned by <a>CreateWebACL</a> and by <a>ListWebACLs</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebACL service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetWebACL">REST API Reference for GetWebACL Operation</seealso>
        public virtual Task<GetWebACLResponse> GetWebACLAsync(string webACLId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetWebACLRequest();
            request.WebACLId = webACLId;
            return GetWebACLAsync(request, cancellationToken);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>WebACL</a> that is specified by <c>WebACLId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebACL service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetWebACL">REST API Reference for GetWebACL Operation</seealso>
        public virtual Task<GetWebACLResponse> GetWebACLAsync(GetWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<GetWebACLResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetWebACLForResource

        internal virtual GetWebACLForResourceResponse GetWebACLForResource(GetWebACLForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWebACLForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebACLForResourceResponseUnmarshaller.Instance;

            return Invoke<GetWebACLForResourceResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic Regional</b> documentation. For more information, see <a
        /// href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the web ACL for the specified resource, either an application load balancer
        /// or Amazon API Gateway stage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebACLForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebACLForResource service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFUnavailableEntityException">
        /// The operation failed because the entity referenced is temporarily unavailable. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetWebACLForResource">REST API Reference for GetWebACLForResource Operation</seealso>
        public virtual Task<GetWebACLForResourceResponse> GetWebACLForResourceAsync(GetWebACLForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWebACLForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebACLForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetWebACLForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetXssMatchSet

        internal virtual GetXssMatchSetResponse GetXssMatchSet(GetXssMatchSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetXssMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetXssMatchSetResponseUnmarshaller.Instance;

            return Invoke<GetXssMatchSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>XssMatchSet</a> that is specified by <c>XssMatchSetId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetXssMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetXssMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetXssMatchSet">REST API Reference for GetXssMatchSet Operation</seealso>
        public virtual Task<GetXssMatchSetResponse> GetXssMatchSetAsync(GetXssMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetXssMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetXssMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetXssMatchSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListActivatedRulesInRuleGroup

        internal virtual ListActivatedRulesInRuleGroupResponse ListActivatedRulesInRuleGroup(ListActivatedRulesInRuleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListActivatedRulesInRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActivatedRulesInRuleGroupResponseUnmarshaller.Instance;

            return Invoke<ListActivatedRulesInRuleGroupResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>ActivatedRule</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActivatedRulesInRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListActivatedRulesInRuleGroup service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListActivatedRulesInRuleGroup">REST API Reference for ListActivatedRulesInRuleGroup Operation</seealso>
        public virtual Task<ListActivatedRulesInRuleGroupResponse> ListActivatedRulesInRuleGroupAsync(ListActivatedRulesInRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListActivatedRulesInRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActivatedRulesInRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ListActivatedRulesInRuleGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListByteMatchSets

        internal virtual ListByteMatchSetsResponse ListByteMatchSets(ListByteMatchSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListByteMatchSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListByteMatchSetsResponseUnmarshaller.Instance;

            return Invoke<ListByteMatchSetsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>ByteMatchSetSummary</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListByteMatchSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListByteMatchSets service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListByteMatchSets">REST API Reference for ListByteMatchSets Operation</seealso>
        public virtual Task<ListByteMatchSetsResponse> ListByteMatchSetsAsync(ListByteMatchSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListByteMatchSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListByteMatchSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListByteMatchSetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListGeoMatchSets

        internal virtual ListGeoMatchSetsResponse ListGeoMatchSets(ListGeoMatchSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGeoMatchSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGeoMatchSetsResponseUnmarshaller.Instance;

            return Invoke<ListGeoMatchSetsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>GeoMatchSetSummary</a> objects in the response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeoMatchSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGeoMatchSets service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListGeoMatchSets">REST API Reference for ListGeoMatchSets Operation</seealso>
        public virtual Task<ListGeoMatchSetsResponse> ListGeoMatchSetsAsync(ListGeoMatchSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGeoMatchSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGeoMatchSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGeoMatchSetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListIPSets

        internal virtual ListIPSetsResponse ListIPSets(ListIPSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIPSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIPSetsResponseUnmarshaller.Instance;

            return Invoke<ListIPSetsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>IPSetSummary</a> objects in the response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIPSets service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        public virtual Task<ListIPSetsResponse> ListIPSetsAsync(ListIPSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIPSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIPSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIPSetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListLoggingConfigurations

        internal virtual ListLoggingConfigurationsResponse ListLoggingConfigurations(ListLoggingConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLoggingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLoggingConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListLoggingConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>LoggingConfiguration</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLoggingConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLoggingConfigurations service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListLoggingConfigurations">REST API Reference for ListLoggingConfigurations Operation</seealso>
        public virtual Task<ListLoggingConfigurationsResponse> ListLoggingConfigurationsAsync(ListLoggingConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLoggingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLoggingConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLoggingConfigurationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRateBasedRules

        internal virtual ListRateBasedRulesResponse ListRateBasedRules(ListRateBasedRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRateBasedRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRateBasedRulesResponseUnmarshaller.Instance;

            return Invoke<ListRateBasedRulesResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>RuleSummary</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRateBasedRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRateBasedRules service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListRateBasedRules">REST API Reference for ListRateBasedRules Operation</seealso>
        public virtual Task<ListRateBasedRulesResponse> ListRateBasedRulesAsync(ListRateBasedRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRateBasedRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRateBasedRulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRateBasedRulesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRegexMatchSets

        internal virtual ListRegexMatchSetsResponse ListRegexMatchSets(ListRegexMatchSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRegexMatchSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegexMatchSetsResponseUnmarshaller.Instance;

            return Invoke<ListRegexMatchSetsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>RegexMatchSetSummary</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegexMatchSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegexMatchSets service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListRegexMatchSets">REST API Reference for ListRegexMatchSets Operation</seealso>
        public virtual Task<ListRegexMatchSetsResponse> ListRegexMatchSetsAsync(ListRegexMatchSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRegexMatchSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegexMatchSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRegexMatchSetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRegexPatternSets

        internal virtual ListRegexPatternSetsResponse ListRegexPatternSets(ListRegexPatternSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRegexPatternSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegexPatternSetsResponseUnmarshaller.Instance;

            return Invoke<ListRegexPatternSetsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>RegexPatternSetSummary</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegexPatternSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegexPatternSets service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListRegexPatternSets">REST API Reference for ListRegexPatternSets Operation</seealso>
        public virtual Task<ListRegexPatternSetsResponse> ListRegexPatternSetsAsync(ListRegexPatternSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRegexPatternSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegexPatternSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRegexPatternSetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListResourcesForWebACL

        internal virtual ListResourcesForWebACLResponse ListResourcesForWebACL(ListResourcesForWebACLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourcesForWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesForWebACLResponseUnmarshaller.Instance;

            return Invoke<ListResourcesForWebACLResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic Regional</b> documentation. For more information, see <a
        /// href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of resources associated with the specified web ACL.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourcesForWebACL service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListResourcesForWebACL">REST API Reference for ListResourcesForWebACL Operation</seealso>
        public virtual Task<ListResourcesForWebACLResponse> ListResourcesForWebACLAsync(ListResourcesForWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourcesForWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesForWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourcesForWebACLResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRuleGroups

        internal virtual ListRuleGroupsResponse ListRuleGroups(ListRuleGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleGroupsResponseUnmarshaller.Instance;

            return Invoke<ListRuleGroupsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>RuleGroup</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRuleGroups service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListRuleGroups">REST API Reference for ListRuleGroups Operation</seealso>
        public virtual Task<ListRuleGroupsResponse> ListRuleGroupsAsync(ListRuleGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRuleGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRules

        internal virtual ListRulesResponse ListRules(ListRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesResponseUnmarshaller.Instance;

            return Invoke<ListRulesResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>RuleSummary</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRulesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSizeConstraintSets

        internal virtual ListSizeConstraintSetsResponse ListSizeConstraintSets(ListSizeConstraintSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSizeConstraintSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSizeConstraintSetsResponseUnmarshaller.Instance;

            return Invoke<ListSizeConstraintSetsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>SizeConstraintSetSummary</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSizeConstraintSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSizeConstraintSets service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListSizeConstraintSets">REST API Reference for ListSizeConstraintSets Operation</seealso>
        public virtual Task<ListSizeConstraintSetsResponse> ListSizeConstraintSetsAsync(ListSizeConstraintSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSizeConstraintSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSizeConstraintSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSizeConstraintSetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSqlInjectionMatchSets

        internal virtual ListSqlInjectionMatchSetsResponse ListSqlInjectionMatchSets(ListSqlInjectionMatchSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSqlInjectionMatchSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSqlInjectionMatchSetsResponseUnmarshaller.Instance;

            return Invoke<ListSqlInjectionMatchSetsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>SqlInjectionMatchSet</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSqlInjectionMatchSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSqlInjectionMatchSets service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListSqlInjectionMatchSets">REST API Reference for ListSqlInjectionMatchSets Operation</seealso>
        public virtual Task<ListSqlInjectionMatchSetsResponse> ListSqlInjectionMatchSetsAsync(ListSqlInjectionMatchSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSqlInjectionMatchSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSqlInjectionMatchSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSqlInjectionMatchSetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSubscribedRuleGroups

        internal virtual ListSubscribedRuleGroupsResponse ListSubscribedRuleGroups(ListSubscribedRuleGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscribedRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscribedRuleGroupsResponseUnmarshaller.Instance;

            return Invoke<ListSubscribedRuleGroupsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>RuleGroup</a> objects that you are subscribed to.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribedRuleGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscribedRuleGroups service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListSubscribedRuleGroups">REST API Reference for ListSubscribedRuleGroups Operation</seealso>
        public virtual Task<ListSubscribedRuleGroupsResponse> ListSubscribedRuleGroupsAsync(ListSubscribedRuleGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscribedRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscribedRuleGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSubscribedRuleGroupsResponse>(request, options, cancellationToken);
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
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the tags associated with the specified AWS resource. Tags are key:value
        /// pairs that you can use to categorize and manage your resources, for purposes like
        /// billing. For example, you might set the tag key to "customer" and the value to the
        /// customer name or ID. You can specify one or more tags to add to each AWS resource,
        /// up to 50 tags for a resource.
        /// </para>
        ///  
        /// <para>
        /// Tagging is only available through the API, SDKs, and CLI. You can't manage or view
        /// tags through the AWS WAF Classic console. You can tag the AWS resources that you manage
        /// through AWS WAF Classic: web ACLs, rule groups, and rules. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWebACLs

        internal virtual ListWebACLsResponse ListWebACLs(ListWebACLsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWebACLsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebACLsResponseUnmarshaller.Instance;

            return Invoke<ListWebACLsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>WebACLSummary</a> objects in the response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebACLs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWebACLs service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListWebACLs">REST API Reference for ListWebACLs Operation</seealso>
        public virtual Task<ListWebACLsResponse> ListWebACLsAsync(ListWebACLsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWebACLsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebACLsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWebACLsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListXssMatchSets

        internal virtual ListXssMatchSetsResponse ListXssMatchSets(ListXssMatchSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListXssMatchSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListXssMatchSetsResponseUnmarshaller.Instance;

            return Invoke<ListXssMatchSetsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns an array of <a>XssMatchSet</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListXssMatchSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListXssMatchSets service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListXssMatchSets">REST API Reference for ListXssMatchSets Operation</seealso>
        public virtual Task<ListXssMatchSetsResponse> ListXssMatchSetsAsync(ListXssMatchSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListXssMatchSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListXssMatchSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListXssMatchSetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutLoggingConfiguration

        internal virtual PutLoggingConfigurationResponse PutLoggingConfiguration(PutLoggingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutLoggingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Associates a <a>LoggingConfiguration</a> with a specified web ACL.
        /// </para>
        ///  
        /// <para>
        /// You can access information about all traffic that AWS WAF inspects using the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create an Amazon Kinesis Data Firehose. 
        /// </para>
        ///  
        /// <para>
        /// Create the data firehose with a PUT source and in the region that you are operating.
        /// However, if you are capturing logs for Amazon CloudFront, always create the firehose
        /// in US East (N. Virginia). 
        /// </para>
        ///  <note> 
        /// <para>
        /// Do not create the data firehose using a <c>Kinesis stream</c> as your source.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Associate that firehose to your web ACL using a <c>PutLoggingConfiguration</c> request.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you successfully enable logging using a <c>PutLoggingConfiguration</c> request,
        /// AWS WAF will create a service linked role with the necessary permissions to write
        /// logs to the Amazon Kinesis Data Firehose. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
        /// Web ACL Traffic Information</a> in the <i>AWS WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLoggingConfiguration service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFServiceLinkedRoleErrorException">
        /// AWS WAF is not able to access the service linked role. This can be caused by a previous
        /// <c>PutLoggingConfiguration</c> request, which can lock the service linked role for
        /// about 20 seconds. Please try your request again. The service linked role can also
        /// be locked by a previous <c>DeleteServiceLinkedRole</c> request, which can lock the
        /// role for 15 minutes or more. If you recently made a <c>DeleteServiceLinkedRole</c>,
        /// wait at least 15 minutes and try the request again. If you receive this same exception
        /// again, you will have to wait additional time until the role is unlocked.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/PutLoggingConfiguration">REST API Reference for PutLoggingConfiguration Operation</seealso>
        public virtual Task<PutLoggingConfigurationResponse> PutLoggingConfigurationAsync(PutLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLoggingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutLoggingConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutPermissionPolicy

        internal virtual PutPermissionPolicyResponse PutPermissionPolicy(PutPermissionPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutPermissionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPermissionPolicyResponseUnmarshaller.Instance;

            return Invoke<PutPermissionPolicyResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Attaches an IAM policy to the specified resource. The only supported use for this
        /// action is to share a RuleGroup across accounts.
        /// </para>
        ///  
        /// <para>
        /// The <c>PutPermissionPolicy</c> is subject to the following restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can attach only one policy with each <c>PutPermissionPolicy</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy must include an <c>Effect</c>, <c>Action</c> and <c>Principal</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Effect</c> must specify <c>Allow</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Action</c> in the policy must be <c>waf:UpdateWebACL</c>, <c>waf-regional:UpdateWebACL</c>,
        /// <c>waf:GetRuleGroup</c> and <c>waf-regional:GetRuleGroup</c> . Any extra or wildcard
        /// actions in the policy will be rejected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy cannot include a <c>Resource</c> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN in the request must be a valid WAF RuleGroup ARN and the RuleGroup must exist
        /// in the same region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user making the request must be the owner of the RuleGroup.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your policy must be composed using IAM Policy version 2012-10-17.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html">IAM
        /// Policies</a>. 
        /// </para>
        ///  
        /// <para>
        /// An example of a valid policy parameter is shown in the Examples section below.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPermissionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutPermissionPolicy service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidPermissionPolicyException">
        /// The operation failed because the specified policy is not in the proper format. 
        /// 
        ///  
        /// <para>
        /// The policy is subject to the following restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can attach only one policy with each <c>PutPermissionPolicy</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy must include an <c>Effect</c>, <c>Action</c> and <c>Principal</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Effect</c> must specify <c>Allow</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Action</c> in the policy must be <c>waf:UpdateWebACL</c>, <c>waf-regional:UpdateWebACL</c>,
        /// <c>waf:GetRuleGroup</c> and <c>waf-regional:GetRuleGroup</c> . Any extra or wildcard
        /// actions in the policy will be rejected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy cannot include a <c>Resource</c> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN in the request must be a valid WAF RuleGroup ARN and the RuleGroup must exist
        /// in the same region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user making the request must be the owner of the RuleGroup.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your policy must be composed using IAM Policy version 2012-10-17.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/PutPermissionPolicy">REST API Reference for PutPermissionPolicy Operation</seealso>
        public virtual Task<PutPermissionPolicyResponse> PutPermissionPolicyAsync(PutPermissionPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutPermissionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPermissionPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutPermissionPolicyResponse>(request, options, cancellationToken);
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
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Associates tags with the specified AWS resource. Tags are key:value pairs that you
        /// can use to categorize and manage your resources, for purposes like billing. For example,
        /// you might set the tag key to "customer" and the value to the customer name or ID.
        /// You can specify one or more tags to add to each AWS resource, up to 50 tags for a
        /// resource.
        /// </para>
        ///  
        /// <para>
        /// Tagging is only available through the API, SDKs, and CLI. You can't manage or view
        /// tags through the AWS WAF Classic console. You can use this action to tag the AWS resources
        /// that you manage through AWS WAF Classic: web ACLs, rule groups, and rules. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFBadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFTagOperationInternalErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateByteMatchSet

        internal virtual UpdateByteMatchSetResponse UpdateByteMatchSet(UpdateByteMatchSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateByteMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateByteMatchSetResponseUnmarshaller.Instance;

            return Invoke<UpdateByteMatchSetResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>ByteMatchTuple</a> objects (filters) in a <a>ByteMatchSet</a>.
        /// For each <c>ByteMatchTuple</c> object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change a <c>ByteMatchSetUpdate</c>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The part of a web request that you want AWS WAF to inspect, such as a query string
        /// or the value of the <c>User-Agent</c> header. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The bytes (typically a string that corresponds with ASCII characters) that you want
        /// AWS WAF to look for. For more information, including how you specify the values for
        /// the AWS WAF API and the AWS CLI or SDKs, see <c>TargetString</c> in the <a>ByteMatchTuple</a>
        /// data type. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Where to look, such as at the beginning or the end of a query string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether to perform any conversions on the request, such as converting it to lowercase,
        /// before inspecting it for the specified string.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, you can add a <c>ByteMatchSetUpdate</c> object that matches web requests
        /// in which <c>User-Agent</c> headers contain the string <c>BadBot</c>. You can then
        /// configure AWS WAF to block those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>ByteMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <c>ByteMatchSet.</c> For more information, see <a>CreateByteMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateByteMatchSet</c> request to specify the part of the request that
        /// you want AWS WAF to inspect (for example, the header or the URI) and the value that
        /// you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="byteMatchSetId">The <c>ByteMatchSetId</c> of the <a>ByteMatchSet</a> that you want to update. <c>ByteMatchSetId</c> is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.</param>
        /// <param name="updates">An array of <c>ByteMatchSetUpdate</c> objects that you want to insert into or delete from a <a>ByteMatchSet</a>. For more information, see the applicable data types: <ul> <li>  <a>ByteMatchSetUpdate</a>: Contains <c>Action</c> and <c>ByteMatchTuple</c>  </li> <li>  <a>ByteMatchTuple</a>: Contains <c>FieldToMatch</c>, <c>PositionalConstraint</c>, <c>TargetString</c>, and <c>TextTransformation</c>  </li> <li>  <a>FieldToMatch</a>: Contains <c>Data</c> and <c>Type</c>  </li> </ul></param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateByteMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateByteMatchSet">REST API Reference for UpdateByteMatchSet Operation</seealso>
        public virtual Task<UpdateByteMatchSetResponse> UpdateByteMatchSetAsync(string byteMatchSetId, List<ByteMatchSetUpdate> updates, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateByteMatchSetRequest();
            request.ByteMatchSetId = byteMatchSetId;
            request.Updates = updates;
            request.ChangeToken = changeToken;
            return UpdateByteMatchSetAsync(request, cancellationToken);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>ByteMatchTuple</a> objects (filters) in a <a>ByteMatchSet</a>.
        /// For each <c>ByteMatchTuple</c> object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change a <c>ByteMatchSetUpdate</c>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The part of a web request that you want AWS WAF to inspect, such as a query string
        /// or the value of the <c>User-Agent</c> header. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The bytes (typically a string that corresponds with ASCII characters) that you want
        /// AWS WAF to look for. For more information, including how you specify the values for
        /// the AWS WAF API and the AWS CLI or SDKs, see <c>TargetString</c> in the <a>ByteMatchTuple</a>
        /// data type. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Where to look, such as at the beginning or the end of a query string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether to perform any conversions on the request, such as converting it to lowercase,
        /// before inspecting it for the specified string.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, you can add a <c>ByteMatchSetUpdate</c> object that matches web requests
        /// in which <c>User-Agent</c> headers contain the string <c>BadBot</c>. You can then
        /// configure AWS WAF to block those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>ByteMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <c>ByteMatchSet.</c> For more information, see <a>CreateByteMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateByteMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateByteMatchSet</c> request to specify the part of the request that
        /// you want AWS WAF to inspect (for example, the header or the URI) and the value that
        /// you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateByteMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateByteMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateByteMatchSet">REST API Reference for UpdateByteMatchSet Operation</seealso>
        public virtual Task<UpdateByteMatchSetResponse> UpdateByteMatchSetAsync(UpdateByteMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateByteMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateByteMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateByteMatchSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateGeoMatchSet

        internal virtual UpdateGeoMatchSetResponse UpdateGeoMatchSet(UpdateGeoMatchSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGeoMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGeoMatchSetResponseUnmarshaller.Instance;

            return Invoke<UpdateGeoMatchSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>GeoMatchConstraint</a> objects in an <c>GeoMatchSet</c>. For
        /// each <c>GeoMatchConstraint</c> object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change an <c>GeoMatchConstraint</c>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Type</c>. The only valid value for <c>Type</c> is <c>Country</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Value</c>, which is a two character code for the country to add to the <c>GeoMatchConstraint</c>
        /// object. Valid codes are listed in <a>GeoMatchConstraint$Value</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To create and configure an <c>GeoMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateGeoMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateGeoMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateGeoMatchSet</c> request to specify the country that you want AWS
        /// WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you update an <c>GeoMatchSet</c>, you specify the country that you want to add
        /// and/or the country that you want to delete. If you want to change a country, you delete
        /// the existing country and add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGeoMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGeoMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateGeoMatchSet">REST API Reference for UpdateGeoMatchSet Operation</seealso>
        public virtual Task<UpdateGeoMatchSetResponse> UpdateGeoMatchSetAsync(UpdateGeoMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGeoMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGeoMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGeoMatchSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateIPSet

        internal virtual UpdateIPSetResponse UpdateIPSet(UpdateIPSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIPSetResponseUnmarshaller.Instance;

            return Invoke<UpdateIPSetResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>IPSetDescriptor</a> objects in an <c>IPSet</c>. For each <c>IPSetDescriptor</c>
        /// object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change an <c>IPSetDescriptor</c>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address version, <c>IPv4</c> or <c>IPv6</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address in CIDR notation, for example, <c>192.0.2.0/24</c> (for the range of
        /// IP addresses from <c>192.0.2.0</c> to <c>192.0.2.255</c>) or <c>192.0.2.44/32</c>
        /// (for the individual IP address <c>192.0.2.44</c>). 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// AWS WAF supports IPv4 address ranges: /8 and any range between /16 through /32. AWS
        /// WAF supports IPv6 address ranges: /24, /32, /48, /56, /64, and /128. For more information
        /// about CIDR notation, see the Wikipedia entry <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
        /// Inter-Domain Routing</a>.
        /// </para>
        ///  
        /// <para>
        /// IPv6 addresses can be represented using any of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 1111:0000:0000:0000:0000:0000:0000:0111/128
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1111:0:0:0:0:0:0:0111/128
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1111::0111/128
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1111::111/128
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You use an <c>IPSet</c> to specify which web requests you want to allow or block based
        /// on the IP addresses that the requests originated from. For example, if you're receiving
        /// a lot of requests from one or a small number of IP addresses and you want to block
        /// the requests, you can create an <c>IPSet</c> that specifies those IP addresses, and
        /// then configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <c>IPSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateIPSet</c> request to specify the IP addresses that you want AWS
        /// WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you update an <c>IPSet</c>, you specify the IP addresses that you want to add
        /// and/or the IP addresses that you want to delete. If you want to change an IP address,
        /// you delete the existing IP address and add the new one.
        /// </para>
        ///  
        /// <para>
        /// You can insert a maximum of 1000 addresses in a single request.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="ipSetId">The <c>IPSetId</c> of the <a>IPSet</a> that you want to update. <c>IPSetId</c> is returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.</param>
        /// <param name="updates">An array of <c>IPSetUpdate</c> objects that you want to insert into or delete from an <a>IPSet</a>. For more information, see the applicable data types: <ul> <li>  <a>IPSetUpdate</a>: Contains <c>Action</c> and <c>IPSetDescriptor</c>  </li> <li>  <a>IPSetDescriptor</a>: Contains <c>Type</c> and <c>Value</c>  </li> </ul> You can insert a maximum of 1000 addresses in a single request.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIPSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        public virtual Task<UpdateIPSetResponse> UpdateIPSetAsync(string ipSetId, List<IPSetUpdate> updates, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateIPSetRequest();
            request.IPSetId = ipSetId;
            request.Updates = updates;
            request.ChangeToken = changeToken;
            return UpdateIPSetAsync(request, cancellationToken);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>IPSetDescriptor</a> objects in an <c>IPSet</c>. For each <c>IPSetDescriptor</c>
        /// object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change an <c>IPSetDescriptor</c>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address version, <c>IPv4</c> or <c>IPv6</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address in CIDR notation, for example, <c>192.0.2.0/24</c> (for the range of
        /// IP addresses from <c>192.0.2.0</c> to <c>192.0.2.255</c>) or <c>192.0.2.44/32</c>
        /// (for the individual IP address <c>192.0.2.44</c>). 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// AWS WAF supports IPv4 address ranges: /8 and any range between /16 through /32. AWS
        /// WAF supports IPv6 address ranges: /24, /32, /48, /56, /64, and /128. For more information
        /// about CIDR notation, see the Wikipedia entry <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
        /// Inter-Domain Routing</a>.
        /// </para>
        ///  
        /// <para>
        /// IPv6 addresses can be represented using any of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 1111:0000:0000:0000:0000:0000:0000:0111/128
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1111:0:0:0:0:0:0:0111/128
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1111::0111/128
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1111::111/128
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You use an <c>IPSet</c> to specify which web requests you want to allow or block based
        /// on the IP addresses that the requests originated from. For example, if you're receiving
        /// a lot of requests from one or a small number of IP addresses and you want to block
        /// the requests, you can create an <c>IPSet</c> that specifies those IP addresses, and
        /// then configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <c>IPSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateIPSet</c> request to specify the IP addresses that you want AWS
        /// WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you update an <c>IPSet</c>, you specify the IP addresses that you want to add
        /// and/or the IP addresses that you want to delete. If you want to change an IP address,
        /// you delete the existing IP address and add the new one.
        /// </para>
        ///  
        /// <para>
        /// You can insert a maximum of 1000 addresses in a single request.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIPSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        public virtual Task<UpdateIPSetResponse> UpdateIPSetAsync(UpdateIPSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIPSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIPSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRateBasedRule

        internal virtual UpdateRateBasedRuleResponse UpdateRateBasedRule(UpdateRateBasedRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRateBasedRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRateBasedRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateRateBasedRuleResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>Predicate</a> objects in a rule and updates the <c>RateLimit</c>
        /// in the rule. 
        /// </para>
        ///  
        /// <para>
        /// Each <c>Predicate</c> object identifies a predicate, such as a <a>ByteMatchSet</a>
        /// or an <a>IPSet</a>, that specifies the web requests that you want to block or count.
        /// The <c>RateLimit</c> specifies the number of requests every five minutes that triggers
        /// the rule.
        /// </para>
        ///  
        /// <para>
        /// If you add more than one predicate to a <c>RateBasedRule</c>, a request must match
        /// all the predicates and exceed the <c>RateLimit</c> to be counted or blocked. For example,
        /// suppose you add the following to a <c>RateBasedRule</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An <c>IPSet</c> that matches the IP address <c>192.0.2.44/32</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> that matches <c>BadBot</c> in the <c>User-Agent</c> header
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Further, you specify a <c>RateLimit</c> of 1,000.
        /// </para>
        ///  
        /// <para>
        /// You then add the <c>RateBasedRule</c> to a <c>WebACL</c> and specify that you want
        /// to block requests that satisfy the rule. For a request to be blocked, it must come
        /// from the IP address 192.0.2.44 <i>and</i> the <c>User-Agent</c> header in the request
        /// must contain the value <c>BadBot</c>. Further, requests that match these two conditions
        /// much be received at a rate of more than 1,000 every five minutes. If the rate drops
        /// below this limit, AWS WAF no longer blocks the requests.
        /// </para>
        ///  
        /// <para>
        /// As a second example, suppose you want to limit requests to a particular page on your
        /// site. To do this, you could add the following to a <c>RateBasedRule</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> with <c>FieldToMatch</c> of <c>URI</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>PositionalConstraint</c> of <c>STARTS_WITH</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>TargetString</c> of <c>login</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Further, you specify a <c>RateLimit</c> of 1,000.
        /// </para>
        ///  
        /// <para>
        /// By adding this <c>RateBasedRule</c> to a <c>WebACL</c>, you could limit requests to
        /// your login page without affecting the rest of your site.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRateBasedRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRateBasedRule service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateRateBasedRule">REST API Reference for UpdateRateBasedRule Operation</seealso>
        public virtual Task<UpdateRateBasedRuleResponse> UpdateRateBasedRuleAsync(UpdateRateBasedRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRateBasedRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRateBasedRuleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRateBasedRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRegexMatchSet

        internal virtual UpdateRegexMatchSetResponse UpdateRegexMatchSet(UpdateRegexMatchSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRegexMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegexMatchSetResponseUnmarshaller.Instance;

            return Invoke<UpdateRegexMatchSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>RegexMatchTuple</a> objects (filters) in a <a>RegexMatchSet</a>.
        /// For each <c>RegexMatchSetUpdate</c> object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change a <c>RegexMatchSetUpdate</c>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The part of a web request that you want AWS WAF to inspectupdate, such as a query
        /// string or the value of the <c>User-Agent</c> header. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The identifier of the pattern (a regular expression) that you want AWS WAF to look
        /// for. For more information, see <a>RegexPatternSet</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether to perform any conversions on the request, such as converting it to lowercase,
        /// before inspecting it for the specified string.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For example, you can create a <c>RegexPatternSet</c> that matches any requests with
        /// <c>User-Agent</c> headers that contain the string <c>B[a@]dB[o0]t</c>. You can then
        /// configure AWS WAF to reject those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>RegexMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <c>RegexMatchSet.</c> For more information, see <a>CreateRegexMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateRegexMatchSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRegexMatchSet</c> request to specify the part of the request that
        /// you want AWS WAF to inspect (for example, the header or the URI) and the identifier
        /// of the <c>RegexPatternSet</c> that contain the regular expression patters you want
        /// AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegexMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRegexMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateRegexMatchSet">REST API Reference for UpdateRegexMatchSet Operation</seealso>
        public virtual Task<UpdateRegexMatchSetResponse> UpdateRegexMatchSetAsync(UpdateRegexMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRegexMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegexMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRegexMatchSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRegexPatternSet

        internal virtual UpdateRegexPatternSetResponse UpdateRegexPatternSet(UpdateRegexPatternSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegexPatternSetResponseUnmarshaller.Instance;

            return Invoke<UpdateRegexPatternSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <c>RegexPatternString</c> objects in a <a>RegexPatternSet</a>.
        /// For each <c>RegexPatternString</c> object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the <c>RegexPatternString</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The regular expression pattern that you want to insert or delete. For more information,
        /// see <a>RegexPatternSet</a>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For example, you can create a <c>RegexPatternString</c> such as <c>B[a@]dB[o0]t</c>.
        /// AWS WAF will match this <c>RegexPatternString</c> to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// BadBot
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BadB0t
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// B@dBot
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// B@dB0t
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To create and configure a <c>RegexPatternSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <c>RegexPatternSet.</c> For more information, see <a>CreateRegexPatternSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateRegexPatternSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRegexPatternSet</c> request to specify the regular expression pattern
        /// that you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegexPatternSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRegexPatternSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidRegexPatternException">
        /// The regular expression (regex) you specified in <c>RegexPatternString</c> is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateRegexPatternSet">REST API Reference for UpdateRegexPatternSet Operation</seealso>
        public virtual Task<UpdateRegexPatternSetResponse> UpdateRegexPatternSetAsync(UpdateRegexPatternSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegexPatternSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRegexPatternSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRule

        internal virtual UpdateRuleResponse UpdateRule(UpdateRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateRuleResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>Predicate</a> objects in a <c>Rule</c>. Each <c>Predicate</c>
        /// object identifies a predicate, such as a <a>ByteMatchSet</a> or an <a>IPSet</a>, that
        /// specifies the web requests that you want to allow, block, or count. If you add more
        /// than one predicate to a <c>Rule</c>, a request must match all of the specifications
        /// to be allowed, blocked, or counted. For example, suppose that you add the following
        /// to a <c>Rule</c>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> that matches the value <c>BadBot</c> in the <c>User-Agent</c>
        /// header
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An <c>IPSet</c> that matches the IP address <c>192.0.2.44</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You then add the <c>Rule</c> to a <c>WebACL</c> and specify that you want to block
        /// requests that satisfy the <c>Rule</c>. For a request to be blocked, the <c>User-Agent</c>
        /// header in the request must contain the value <c>BadBot</c> <i>and</i> the request
        /// must originate from the IP address 192.0.2.44.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>Rule</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create the <c>Rule</c>. See <a>CreateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRule</c> request to add predicates to the <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <c>WebACL</c> that contains the <c>Rule</c>. See <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If you want to replace one <c>ByteMatchSet</c> or <c>IPSet</c> with another, you delete
        /// the existing one and add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="ruleId">The <c>RuleId</c> of the <c>Rule</c> that you want to update. <c>RuleId</c> is returned by <c>CreateRule</c> and by <a>ListRules</a>.</param>
        /// <param name="updates">An array of <c>RuleUpdate</c> objects that you want to insert into or delete from a <a>Rule</a>. For more information, see the applicable data types: <ul> <li>  <a>RuleUpdate</a>: Contains <c>Action</c> and <c>Predicate</c>  </li> <li>  <a>Predicate</a>: Contains <c>DataId</c>, <c>Negated</c>, and <c>Type</c>  </li> <li>  <a>FieldToMatch</a>: Contains <c>Data</c> and <c>Type</c>  </li> </ul></param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRule service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        public virtual Task<UpdateRuleResponse> UpdateRuleAsync(string ruleId, List<RuleUpdate> updates, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateRuleRequest();
            request.RuleId = ruleId;
            request.Updates = updates;
            request.ChangeToken = changeToken;
            return UpdateRuleAsync(request, cancellationToken);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>Predicate</a> objects in a <c>Rule</c>. Each <c>Predicate</c>
        /// object identifies a predicate, such as a <a>ByteMatchSet</a> or an <a>IPSet</a>, that
        /// specifies the web requests that you want to allow, block, or count. If you add more
        /// than one predicate to a <c>Rule</c>, a request must match all of the specifications
        /// to be allowed, blocked, or counted. For example, suppose that you add the following
        /// to a <c>Rule</c>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A <c>ByteMatchSet</c> that matches the value <c>BadBot</c> in the <c>User-Agent</c>
        /// header
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An <c>IPSet</c> that matches the IP address <c>192.0.2.44</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You then add the <c>Rule</c> to a <c>WebACL</c> and specify that you want to block
        /// requests that satisfy the <c>Rule</c>. For a request to be blocked, the <c>User-Agent</c>
        /// header in the request must contain the value <c>BadBot</c> <i>and</i> the request
        /// must originate from the IP address 192.0.2.44.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>Rule</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create the <c>Rule</c>. See <a>CreateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRule</c> request to add predicates to the <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <c>WebACL</c> that contains the <c>Rule</c>. See <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If you want to replace one <c>ByteMatchSet</c> or <c>IPSet</c> with another, you delete
        /// the existing one and add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRule service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        public virtual Task<UpdateRuleResponse> UpdateRuleAsync(UpdateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRuleGroup

        internal virtual UpdateRuleGroupResponse UpdateRuleGroup(UpdateRuleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateRuleGroupResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>ActivatedRule</a> objects in a <c>RuleGroup</c>.
        /// </para>
        ///  
        /// <para>
        /// You can only insert <c>REGULAR</c> rules into a rule group.
        /// </para>
        ///  
        /// <para>
        /// You can have a maximum of ten rules per rule group.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>RuleGroup</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the <c>Rules</c> that you want to include in the <c>RuleGroup</c>.
        /// See <a>CreateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateRuleGroup</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateRuleGroup</c> request to add <c>Rules</c> to the <c>RuleGroup</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <c>WebACL</c> that contains the <c>RuleGroup</c>. See <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If you want to replace one <c>Rule</c> with another, you delete the existing one and
        /// add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRuleGroup service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateRuleGroup">REST API Reference for UpdateRuleGroup Operation</seealso>
        public virtual Task<UpdateRuleGroupResponse> UpdateRuleGroupAsync(UpdateRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRuleGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSizeConstraintSet

        internal virtual UpdateSizeConstraintSetResponse UpdateSizeConstraintSet(UpdateSizeConstraintSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSizeConstraintSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSizeConstraintSetResponseUnmarshaller.Instance;

            return Invoke<UpdateSizeConstraintSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>SizeConstraint</a> objects (filters) in a <a>SizeConstraintSet</a>.
        /// For each <c>SizeConstraint</c> object, you specify the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change a <c>SizeConstraintSetUpdate</c>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The part of a web request that you want AWS WAF to evaluate, such as the length of
        /// a query string or the length of the <c>User-Agent</c> header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether to perform any transformations on the request, such as converting it to lowercase,
        /// before checking its length. Note that transformations of the request body are not
        /// supported because the AWS resource forwards only the first <c>8192</c> bytes of your
        /// request to AWS WAF.
        /// </para>
        ///  
        /// <para>
        /// You can only specify a single type of TextTransformation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>ComparisonOperator</c> used for evaluating the selected part of the request against
        /// the specified <c>Size</c>, such as equals, greater than, less than, and so on.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The length, in bytes, that you want AWS WAF to watch for in selected part of the request.
        /// The length is computed after applying the transformation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, you can add a <c>SizeConstraintSetUpdate</c> object that matches web
        /// requests in which the length of the <c>User-Agent</c> header is greater than 100 bytes.
        /// You can then configure AWS WAF to block those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>SizeConstraintSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <c>SizeConstraintSet.</c> For more information, see <a>CreateSizeConstraintSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <c>UpdateSizeConstraintSet</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateSizeConstraintSet</c> request to specify the part of the request
        /// that you want AWS WAF to inspect (for example, the header or the URI) and the value
        /// that you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSizeConstraintSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSizeConstraintSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateSizeConstraintSet">REST API Reference for UpdateSizeConstraintSet Operation</seealso>
        public virtual Task<UpdateSizeConstraintSetResponse> UpdateSizeConstraintSetAsync(UpdateSizeConstraintSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSizeConstraintSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSizeConstraintSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSizeConstraintSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSqlInjectionMatchSet

        internal virtual UpdateSqlInjectionMatchSetResponse UpdateSqlInjectionMatchSet(UpdateSqlInjectionMatchSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSqlInjectionMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSqlInjectionMatchSetResponseUnmarshaller.Instance;

            return Invoke<UpdateSqlInjectionMatchSetResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>SqlInjectionMatchTuple</a> objects (filters) in a <a>SqlInjectionMatchSet</a>.
        /// For each <c>SqlInjectionMatchTuple</c> object, you specify the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Action</c>: Whether to insert the object into or delete the object from the array.
        /// To change a <c>SqlInjectionMatchTuple</c>, you delete the existing object and add
        /// a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FieldToMatch</c>: The part of web requests that you want AWS WAF to inspect and,
        /// if you want AWS WAF to inspect a header or custom query parameter, the name of the
        /// header or parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TextTransformation</c>: Which text transformation, if any, to perform on the web
        /// request before inspecting the request for snippets of malicious SQL code.
        /// </para>
        ///  
        /// <para>
        /// You can only specify a single type of TextTransformation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You use <c>SqlInjectionMatchSet</c> objects to specify which CloudFront requests that
        /// you want to allow, block, or count. For example, if you're receiving requests that
        /// contain snippets of SQL code in the query string and you want to block the requests,
        /// you can create a <c>SqlInjectionMatchSet</c> with the applicable settings, and then
        /// configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>SqlInjectionMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateSqlInjectionMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateSqlInjectionMatchSet</c> request to specify the parts of web requests
        /// that you want AWS WAF to inspect for snippets of SQL code.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="sqlInjectionMatchSetId">The <c>SqlInjectionMatchSetId</c> of the <c>SqlInjectionMatchSet</c> that you want to update. <c>SqlInjectionMatchSetId</c> is returned by <a>CreateSqlInjectionMatchSet</a> and by <a>ListSqlInjectionMatchSets</a>.</param>
        /// <param name="updates">An array of <c>SqlInjectionMatchSetUpdate</c> objects that you want to insert into or delete from a <a>SqlInjectionMatchSet</a>. For more information, see the applicable data types: <ul> <li>  <a>SqlInjectionMatchSetUpdate</a>: Contains <c>Action</c> and <c>SqlInjectionMatchTuple</c>  </li> <li>  <a>SqlInjectionMatchTuple</a>: Contains <c>FieldToMatch</c> and <c>TextTransformation</c>  </li> <li>  <a>FieldToMatch</a>: Contains <c>Data</c> and <c>Type</c>  </li> </ul></param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSqlInjectionMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateSqlInjectionMatchSet">REST API Reference for UpdateSqlInjectionMatchSet Operation</seealso>
        public virtual Task<UpdateSqlInjectionMatchSetResponse> UpdateSqlInjectionMatchSetAsync(string sqlInjectionMatchSetId, List<SqlInjectionMatchSetUpdate> updates, string changeToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateSqlInjectionMatchSetRequest();
            request.SqlInjectionMatchSetId = sqlInjectionMatchSetId;
            request.Updates = updates;
            request.ChangeToken = changeToken;
            return UpdateSqlInjectionMatchSetAsync(request, cancellationToken);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>SqlInjectionMatchTuple</a> objects (filters) in a <a>SqlInjectionMatchSet</a>.
        /// For each <c>SqlInjectionMatchTuple</c> object, you specify the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Action</c>: Whether to insert the object into or delete the object from the array.
        /// To change a <c>SqlInjectionMatchTuple</c>, you delete the existing object and add
        /// a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FieldToMatch</c>: The part of web requests that you want AWS WAF to inspect and,
        /// if you want AWS WAF to inspect a header or custom query parameter, the name of the
        /// header or parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TextTransformation</c>: Which text transformation, if any, to perform on the web
        /// request before inspecting the request for snippets of malicious SQL code.
        /// </para>
        ///  
        /// <para>
        /// You can only specify a single type of TextTransformation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You use <c>SqlInjectionMatchSet</c> objects to specify which CloudFront requests that
        /// you want to allow, block, or count. For example, if you're receiving requests that
        /// contain snippets of SQL code in the query string and you want to block the requests,
        /// you can create a <c>SqlInjectionMatchSet</c> with the applicable settings, and then
        /// configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <c>SqlInjectionMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateSqlInjectionMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateSqlInjectionMatchSet</c> request to specify the parts of web requests
        /// that you want AWS WAF to inspect for snippets of SQL code.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSqlInjectionMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSqlInjectionMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateSqlInjectionMatchSet">REST API Reference for UpdateSqlInjectionMatchSet Operation</seealso>
        public virtual Task<UpdateSqlInjectionMatchSetResponse> UpdateSqlInjectionMatchSetAsync(UpdateSqlInjectionMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSqlInjectionMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSqlInjectionMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSqlInjectionMatchSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateWebACL

        internal virtual UpdateWebACLResponse UpdateWebACL(UpdateWebACLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWebACLResponseUnmarshaller.Instance;

            return Invoke<UpdateWebACLResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>ActivatedRule</a> objects in a <c>WebACL</c>. Each <c>Rule</c>
        /// identifies web requests that you want to allow, block, or count. When you update a
        /// <c>WebACL</c>, you specify the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A default action for the <c>WebACL</c>, either <c>ALLOW</c> or <c>BLOCK</c>. AWS WAF
        /// performs the default action if a request doesn't match the criteria in any of the
        /// <c>Rules</c> in a <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Rules</c> that you want to add or delete. If you want to replace one <c>Rule</c>
        /// with another, you delete the existing <c>Rule</c> and add the new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each <c>Rule</c>, whether you want AWS WAF to allow requests, block requests,
        /// or count requests that match the conditions in the <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The order in which you want AWS WAF to evaluate the <c>Rules</c> in a <c>WebACL</c>.
        /// If you add more than one <c>Rule</c> to a <c>WebACL</c>, AWS WAF evaluates each request
        /// against the <c>Rules</c> in order based on the value of <c>Priority</c>. (The <c>Rule</c>
        /// that has the lowest value for <c>Priority</c> is evaluated first.) When a web request
        /// matches all the predicates (such as <c>ByteMatchSets</c> and <c>IPSets</c>) in a <c>Rule</c>,
        /// AWS WAF immediately takes the corresponding action, allow or block, and doesn't evaluate
        /// the request against the remaining <c>Rules</c> in the <c>WebACL</c>, if any. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To create and configure a <c>WebACL</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in <c>Rules</c>. For more
        /// information, see <a>CreateByteMatchSet</a>, <a>UpdateByteMatchSet</a>, <a>CreateIPSet</a>,
        /// <a>UpdateIPSet</a>, <a>CreateSqlInjectionMatchSet</a>, and <a>UpdateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update the <c>Rules</c> that you want to include in the <c>WebACL</c>.
        /// For more information, see <a>CreateRule</a> and <a>UpdateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a <c>WebACL</c>. See <a>CreateWebACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateWebACL</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateWebACL</c> request to specify the <c>Rules</c> that you want to
        /// include in the <c>WebACL</c>, to specify the default action, and to associate the
        /// <c>WebACL</c> with a CloudFront distribution. 
        /// </para>
        ///  
        /// <para>
        /// The <c>ActivatedRule</c> can be a rule group. If you specify a rule group as your
        /// <c>ActivatedRule</c> , you can exclude specific rules from that rule group.
        /// </para>
        ///  
        /// <para>
        /// If you already have a rule group associated with a web ACL and want to submit an <c>UpdateWebACL</c>
        /// request to exclude certain rules from that rule group, you must first remove the rule
        /// group from the web ACL, the re-insert it again, specifying the excluded rules. For
        /// details, see <a>ActivatedRule$ExcludedRules</a> . 
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// Be aware that if you try to add a RATE_BASED rule to a web ACL without setting the
        /// rule type when first creating the rule, the <a>UpdateWebACL</a> request will fail
        /// because the request tries to add a REGULAR rule (the default rule type) with the specified
        /// ID, which does not exist. 
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWebACL service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFReferencedItemException">
        /// The operation failed because you tried to delete an object that is still in use. For
        /// example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <c>ByteMatchSet</c> that is still referenced by a <c>Rule</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <c>Rule</c> that is still referenced by a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFSubscriptionNotFoundException">
        /// The specified subscription does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateWebACL">REST API Reference for UpdateWebACL Operation</seealso>
        public virtual Task<UpdateWebACLResponse> UpdateWebACLAsync(UpdateWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWebACLResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateXssMatchSet

        internal virtual UpdateXssMatchSetResponse UpdateXssMatchSet(UpdateXssMatchSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateXssMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateXssMatchSetResponseUnmarshaller.Instance;

            return Invoke<UpdateXssMatchSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
        /// WAF Classic</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
        /// for regional and global use. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Inserts or deletes <a>XssMatchTuple</a> objects (filters) in an <a>XssMatchSet</a>.
        /// For each <c>XssMatchTuple</c> object, you specify the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Action</c>: Whether to insert the object into or delete the object from the array.
        /// To change an <c>XssMatchTuple</c>, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FieldToMatch</c>: The part of web requests that you want AWS WAF to inspect and,
        /// if you want AWS WAF to inspect a header or custom query parameter, the name of the
        /// header or parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TextTransformation</c>: Which text transformation, if any, to perform on the web
        /// request before inspecting the request for cross-site scripting attacks.
        /// </para>
        ///  
        /// <para>
        /// You can only specify a single type of TextTransformation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You use <c>XssMatchSet</c> objects to specify which CloudFront requests that you want
        /// to allow, block, or count. For example, if you're receiving requests that contain
        /// cross-site scripting attacks in the request body and you want to block the requests,
        /// you can create an <c>XssMatchSet</c> with the applicable settings, and then configure
        /// AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <c>XssMatchSet</c>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateXssMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <c>UpdateXssMatchSet</c> request to specify the parts of web requests that
        /// you want AWS WAF to inspect for cross-site scripting attacks.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateXssMatchSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateXssMatchSet service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidAccountException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// an invalid account identifier.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidOperationException">
        /// The operation failed because there was nothing to do. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to remove a <c>Rule</c> from a <c>WebACL</c>, but the <c>Rule</c> isn't
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <c>IPSet</c>, but the IP address isn't in
        /// the specified <c>IPSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <c>ByteMatchTuple</c> from a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// isn't in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to a <c>WebACL</c>, but the <c>Rule</c> already exists
        /// in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to a <c>ByteMatchSet</c>, but the <c>ByteMatchTuple</c>
        /// already exists in the specified <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update an object (<c>ByteMatchSet</c>, <c>IPSet</c>, <c>Rule</c>, or
        /// <c>WebACL</c>) using an action other than <c>INSERT</c> or <c>DELETE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>WebACL</c> with a <c>DefaultAction</c> <c>Type</c> other
        /// than <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <c>RateBasedRule</c> with a <c>RateKey</c> value other than
        /// <c>IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>WafAction</c> <c>Type</c> other than
        /// <c>ALLOW</c>, <c>BLOCK</c>, or <c>COUNT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>FieldToMatch</c> <c>Type</c> other
        /// than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>ByteMatchSet</c> with a <c>Field</c> of <c>HEADER</c> but
        /// no value for <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>WebACL</c>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <c>Rule</c> to or delete a <c>Rule</c> from a <c>WebACL</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchSet</c> to or delete a <c>ByteMatchSet</c> from a <c>Rule</c>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <c>IPSet</c> that
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <c>ByteMatchTuple</c> to or delete a <c>ByteMatchTuple</c> from
        /// a <c>ByteMatchSet</c> that doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateXssMatchSet">REST API Reference for UpdateXssMatchSet Operation</seealso>
        public virtual Task<UpdateXssMatchSetResponse> UpdateXssMatchSetAsync(UpdateXssMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateXssMatchSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateXssMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateXssMatchSetResponse>(request, options, cancellationToken);
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